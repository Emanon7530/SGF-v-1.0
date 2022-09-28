Public Class invcosm01
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
    Friend WithEvents LibXNavigator1 As LibX.LibXNavigator
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    '<System.Diagnostics.DebuggerStepThrough()> 
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents XTextBox9 As LibX.XTextBox
    Friend WithEvents XTextBox10 As LibX.XTextBox
    Friend WithEvents XTextBox11 As LibX.XTextBox
    Friend WithEvents XTextBox12 As LibX.XTextBox
    Friend WithEvents XTextBox13 As LibX.XTextBox
    Friend WithEvents XTextBox14 As LibX.XTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents XTextBox2 As LibX.XTextBox
    Friend WithEvents XTextBox8 As LibX.XTextBox
    Friend WithEvents LibXLookup1 As LibX.LibXLookup
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents XTextBox4 As LibX.XTextBox
    Friend WithEvents Codigo As System.Windows.Forms.Label
    Friend WithEvents Nombre As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents XTextBox1 As LibX.XTextBox
    Friend WithEvents XTextBox6 As LibX.XTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents XTextBox7 As LibX.XTextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents XTextBox3 As LibX.XTextBox
    Friend WithEvents LibXLookup2 As LibX.LibXLookup
    Friend WithEvents LibXLookup3 As LibX.LibXLookup
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents LibxCheckBox4 As LibX.LibxCheckBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents XTextBox5 As LibX.XTextBox
    Friend WithEvents XTextBox15 As LibX.XTextBox
    Friend WithEvents XTextBox16 As LibX.XTextBox
    Friend WithEvents XTextBox17 As LibX.XTextBox
    Friend WithEvents XTextBox18 As LibX.XTextBox
    Friend WithEvents XTextBox19 As LibX.XTextBox
    Friend WithEvents XTextBox20 As LibX.XTextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents XTextBox21 As LibX.XTextBox
    Friend WithEvents XTextBox22 As LibX.XTextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents XTextBox23 As LibX.XTextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents XTextBox24 As LibX.XTextBox
    Friend WithEvents LabelSuplidor As System.Windows.Forms.Label
    Friend WithEvents LabelProducto As System.Windows.Forms.Label
    Friend WithEvents LabelAlmacen As System.Windows.Forms.Label
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents LibxCheckBox5 As LibX.LibxCheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents XTextBox25 As LibX.XTextBox
    Friend WithEvents XTextBox26 As LibX.XTextBox
    Friend WithEvents XTextBox27 As LibX.XTextBox
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.LibXNavigator1 = New LibX.LibXNavigator
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.LibXLookup3 = New LibX.LibXLookup
        Me.LibXLookup2 = New LibX.LibXLookup
        Me.LabelSuplidor = New System.Windows.Forms.Label
        Me.XTextBox3 = New LibX.XTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.LabelProducto = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.XTextBox2 = New LibX.XTextBox
        Me.XTextBox8 = New LibX.XTextBox
        Me.LabelAlmacen = New System.Windows.Forms.Label
        Me.LibXLookup1 = New LibX.LibXLookup
        Me.Label3 = New System.Windows.Forms.Label
        Me.XTextBox4 = New LibX.XTextBox
        Me.Codigo = New System.Windows.Forms.Label
        Me.Nombre = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.XTextBox1 = New LibX.XTextBox
        Me.XTextBox6 = New LibX.XTextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.XTextBox7 = New LibX.XTextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.XTextBox14 = New LibX.XTextBox
        Me.XTextBox13 = New LibX.XTextBox
        Me.XTextBox12 = New LibX.XTextBox
        Me.XTextBox11 = New LibX.XTextBox
        Me.XTextBox10 = New LibX.XTextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.XTextBox9 = New LibX.XTextBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.LibxCheckBox4 = New LibX.LibxCheckBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.XTextBox5 = New LibX.XTextBox
        Me.XTextBox15 = New LibX.XTextBox
        Me.XTextBox16 = New LibX.XTextBox
        Me.XTextBox17 = New LibX.XTextBox
        Me.XTextBox18 = New LibX.XTextBox
        Me.XTextBox19 = New LibX.XTextBox
        Me.XTextBox20 = New LibX.XTextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.XTextBox21 = New LibX.XTextBox
        Me.XTextBox22 = New LibX.XTextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.XTextBox23 = New LibX.XTextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.XTextBox24 = New LibX.XTextBox
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.LibxCheckBox5 = New LibX.LibxCheckBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.XTextBox25 = New LibX.XTextBox
        Me.XTextBox26 = New LibX.XTextBox
        Me.XTextBox27 = New LibX.XTextBox
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
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
        Me.LibXConnector1.UseTransactions = True
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
        Me.LibXNavigator1.Size = New System.Drawing.Size(786, 24)
        Me.LibXNavigator1.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(752, 408)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LibXLookup3)
        Me.GroupBox3.Controls.Add(Me.LibXLookup2)
        Me.GroupBox3.Controls.Add(Me.LabelSuplidor)
        Me.GroupBox3.Controls.Add(Me.XTextBox3)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.LabelProducto)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.XTextBox2)
        Me.GroupBox3.Controls.Add(Me.XTextBox8)
        Me.GroupBox3.Controls.Add(Me.LabelAlmacen)
        Me.GroupBox3.Controls.Add(Me.LibXLookup1)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.XTextBox4)
        Me.GroupBox3.Controls.Add(Me.Codigo)
        Me.GroupBox3.Controls.Add(Me.Nombre)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.XTextBox1)
        Me.GroupBox3.Controls.Add(Me.XTextBox6)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.XTextBox7)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 16)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(512, 192)
        Me.GroupBox3.TabIndex = 38
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Costos"
        '
        'LibXLookup3
        '
        Me.LibXLookup3.CheckText = Nothing
        Me.LibXLookup3.DataMember = Nothing
        Me.LibXLookup3.DataSource = Me.LibXConnector1
        Me.LibXLookup3.DestParameters = New String() {"ProductoID=ProductoID", "LabelProducto=Nombre"}
        Me.LibXLookup3.FilterField = Nothing
        Me.LibXLookup3.IgnoreFindInBrowseMode = False
        Me.LibXLookup3.Location = New System.Drawing.Point(488, 16)
        Me.LibXLookup3.LookCaption = Nothing
        Me.LibXLookup3.Name = "LibXLookup3"
        Me.LibXLookup3.ShowMessageNotFound = True
        Me.LibXLookup3.ShowWarning = False
        Me.LibXLookup3.Size = New System.Drawing.Size(16, 20)
        Me.LibXLookup3.SizesColumns = Nothing
        Me.LibXLookup3.SizesColumnsTab = Nothing
        Me.LibXLookup3.SqlString = Nothing
        Me.LibXLookup3.SQLTab = Nothing
        Me.LibXLookup3.SrcParameters = New String() {"ProcuctoID=ProductoID"}
        Me.LibXLookup3.TabIndex = 30
        Me.LibXLookup3.TableName = "Productos"
        Me.LibXLookup3.UseCopyConnection = False
        Me.LibXLookup3.UseRowRetrieveEvents = False
        Me.LibXLookup3.UseTab = False
        Me.LibXLookup3.VisParameters = New String() {"Código=ProductoID", "Nombre=Nombre"}
        Me.LibXLookup3.WhereCondition = Nothing
        Me.LibXLookup3.WhereParameters = Nothing
        '
        'LibXLookup2
        '
        Me.LibXLookup2.CheckText = Nothing
        Me.LibXLookup2.DataMember = Nothing
        Me.LibXLookup2.DataSource = Me.LibXConnector1
        Me.LibXLookup2.DestParameters = New String() {"SuplidorID=SuplidorID", "LabelSuplidor=Nombre"}
        Me.LibXLookup2.FilterField = Nothing
        Me.LibXLookup2.IgnoreFindInBrowseMode = False
        Me.LibXLookup2.Location = New System.Drawing.Point(488, 160)
        Me.LibXLookup2.LookCaption = Nothing
        Me.LibXLookup2.Name = "LibXLookup2"
        Me.LibXLookup2.ShowMessageNotFound = True
        Me.LibXLookup2.ShowWarning = False
        Me.LibXLookup2.Size = New System.Drawing.Size(16, 20)
        Me.LibXLookup2.SizesColumns = Nothing
        Me.LibXLookup2.SizesColumnsTab = Nothing
        Me.LibXLookup2.SqlString = Nothing
        Me.LibXLookup2.SQLTab = Nothing
        Me.LibXLookup2.SrcParameters = New String() {"SuplidorID=SuplidorID"}
        Me.LibXLookup2.TabIndex = 29
        Me.LibXLookup2.TableName = "Suplidores"
        Me.LibXLookup2.UseCopyConnection = False
        Me.LibXLookup2.UseRowRetrieveEvents = False
        Me.LibXLookup2.UseTab = False
        Me.LibXLookup2.VisParameters = New String() {"Código=SuplidorID", "Nombre=Nombre"}
        Me.LibXLookup2.WhereCondition = Nothing
        Me.LibXLookup2.WhereParameters = Nothing
        '
        'LabelSuplidor
        '
        Me.LabelSuplidor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelSuplidor.Location = New System.Drawing.Point(208, 160)
        Me.LabelSuplidor.Name = "LabelSuplidor"
        Me.LabelSuplidor.Size = New System.Drawing.Size(288, 20)
        Me.LabelSuplidor.TabIndex = 28
        '
        'XTextBox3
        '
        Me.XTextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "costos.SuplidorID"))
        Me.XTextBox3.EditInitialValue = Nothing
        Me.XTextBox3.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox3.FindInitialValue = Nothing
        Me.XTextBox3.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox3.IgnoreRequiered = False
        Me.XTextBox3.Location = New System.Drawing.Point(136, 160)
        Me.XTextBox3.Name = "XTextBox3"
        Me.XTextBox3.NewInitialValue = Nothing
        Me.XTextBox3.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox3.Requiered = False
        Me.XTextBox3.Size = New System.Drawing.Size(72, 20)
        Me.XTextBox3.TabIndex = 7
        Me.XTextBox3.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 168)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Suplidor:"
        '
        'LabelProducto
        '
        Me.LabelProducto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelProducto.Location = New System.Drawing.Point(208, 16)
        Me.LabelProducto.Name = "LabelProducto"
        Me.LabelProducto.Size = New System.Drawing.Size(288, 20)
        Me.LabelProducto.TabIndex = 25
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(16, 144)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 16)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Precio+ITBIS:"
        '
        'XTextBox2
        '
        Me.XTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "costos.AlmacenID"))
        Me.XTextBox2.EditInitialValue = Nothing
        Me.XTextBox2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.FindInitialValue = Nothing
        Me.XTextBox2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.IgnoreRequiered = False
        Me.XTextBox2.Location = New System.Drawing.Point(136, 40)
        Me.XTextBox2.Name = "XTextBox2"
        Me.XTextBox2.NewInitialValue = Nothing
        Me.XTextBox2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.Requiered = False
        Me.XTextBox2.Size = New System.Drawing.Size(72, 20)
        Me.XTextBox2.TabIndex = 2
        Me.XTextBox2.Text = ""
        '
        'XTextBox8
        '
        Me.XTextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "costos.PrecioITBIS"))
        Me.XTextBox8.EditInitialValue = Nothing
        Me.XTextBox8.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox8.FindInitialValue = Nothing
        Me.XTextBox8.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox8.IgnoreRequiered = False
        Me.XTextBox8.Location = New System.Drawing.Point(136, 136)
        Me.XTextBox8.Name = "XTextBox8"
        Me.XTextBox8.NewInitialValue = Nothing
        Me.XTextBox8.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox8.Requiered = False
        Me.XTextBox8.Size = New System.Drawing.Size(72, 20)
        Me.XTextBox8.TabIndex = 6
        Me.XTextBox8.Text = ""
        '
        'LabelAlmacen
        '
        Me.LabelAlmacen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelAlmacen.Location = New System.Drawing.Point(208, 40)
        Me.LabelAlmacen.Name = "LabelAlmacen"
        Me.LabelAlmacen.Size = New System.Drawing.Size(280, 20)
        Me.LabelAlmacen.TabIndex = 5
        '
        'LibXLookup1
        '
        Me.LibXLookup1.CheckText = Nothing
        Me.LibXLookup1.DataMember = Nothing
        Me.LibXLookup1.DataSource = Me.LibXConnector1
        Me.LibXLookup1.DestParameters = New String() {"AlmacenID=AlmacenID", "LabelAlmacen=Nombre"}
        Me.LibXLookup1.FilterField = Nothing
        Me.LibXLookup1.IgnoreFindInBrowseMode = False
        Me.LibXLookup1.Location = New System.Drawing.Point(488, 40)
        Me.LibXLookup1.LookCaption = Nothing
        Me.LibXLookup1.Name = "LibXLookup1"
        Me.LibXLookup1.ShowMessageNotFound = True
        Me.LibXLookup1.ShowWarning = False
        Me.LibXLookup1.Size = New System.Drawing.Size(16, 20)
        Me.LibXLookup1.SizesColumns = Nothing
        Me.LibXLookup1.SizesColumnsTab = Nothing
        Me.LibXLookup1.SqlString = Nothing
        Me.LibXLookup1.SQLTab = Nothing
        Me.LibXLookup1.SrcParameters = New String() {"AlmacenID=AlmacenID"}
        Me.LibXLookup1.TabIndex = 6
        Me.LibXLookup1.TableName = "Almacen"
        Me.LibXLookup1.UseCopyConnection = False
        Me.LibXLookup1.UseRowRetrieveEvents = False
        Me.LibXLookup1.UseTab = False
        Me.LibXLookup1.VisParameters = New String() {"Código=AlmacenID", "Nombre=Nombre"}
        Me.LibXLookup1.WhereCondition = Nothing
        Me.LibXLookup1.WhereParameters = Nothing
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Costo:"
        '
        'XTextBox4
        '
        Me.XTextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "costos.Costo"))
        Me.XTextBox4.EditInitialValue = Nothing
        Me.XTextBox4.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox4.FindInitialValue = Nothing
        Me.XTextBox4.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox4.IgnoreRequiered = False
        Me.XTextBox4.Location = New System.Drawing.Point(136, 64)
        Me.XTextBox4.Name = "XTextBox4"
        Me.XTextBox4.NewInitialValue = Nothing
        Me.XTextBox4.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox4.Requiered = False
        Me.XTextBox4.Size = New System.Drawing.Size(72, 20)
        Me.XTextBox4.TabIndex = 3
        Me.XTextBox4.Text = ""
        '
        'Codigo
        '
        Me.Codigo.Location = New System.Drawing.Point(16, 24)
        Me.Codigo.Name = "Codigo"
        Me.Codigo.Size = New System.Drawing.Size(100, 16)
        Me.Codigo.TabIndex = 0
        Me.Codigo.Text = "Codigo:"
        '
        'Nombre
        '
        Me.Nombre.Location = New System.Drawing.Point(16, 48)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(100, 16)
        Me.Nombre.TabIndex = 0
        Me.Nombre.Text = "Almacen:"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 16)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Costo+ITBIS:"
        '
        'XTextBox1
        '
        Me.XTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "costos.ProductoID"))
        Me.XTextBox1.EditInitialValue = Nothing
        Me.XTextBox1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.FindInitialValue = Nothing
        Me.XTextBox1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.IgnoreRequiered = False
        Me.XTextBox1.Location = New System.Drawing.Point(136, 16)
        Me.XTextBox1.Name = "XTextBox1"
        Me.XTextBox1.NewInitialValue = Nothing
        Me.XTextBox1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.Requiered = False
        Me.XTextBox1.Size = New System.Drawing.Size(72, 20)
        Me.XTextBox1.TabIndex = 1
        Me.XTextBox1.Text = ""
        '
        'XTextBox6
        '
        Me.XTextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "costos.CostoITBIS"))
        Me.XTextBox6.EditInitialValue = Nothing
        Me.XTextBox6.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox6.FindInitialValue = Nothing
        Me.XTextBox6.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox6.IgnoreRequiered = False
        Me.XTextBox6.Location = New System.Drawing.Point(136, 88)
        Me.XTextBox6.Name = "XTextBox6"
        Me.XTextBox6.NewInitialValue = Nothing
        Me.XTextBox6.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox6.Requiered = False
        Me.XTextBox6.Size = New System.Drawing.Size(72, 20)
        Me.XTextBox6.TabIndex = 4
        Me.XTextBox6.Text = ""
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(16, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 16)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Precio:"
        '
        'XTextBox7
        '
        Me.XTextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "costos.Precio"))
        Me.XTextBox7.EditInitialValue = Nothing
        Me.XTextBox7.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox7.FindInitialValue = Nothing
        Me.XTextBox7.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox7.IgnoreRequiered = False
        Me.XTextBox7.Location = New System.Drawing.Point(136, 112)
        Me.XTextBox7.Name = "XTextBox7"
        Me.XTextBox7.NewInitialValue = Nothing
        Me.XTextBox7.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox7.Requiered = False
        Me.XTextBox7.Size = New System.Drawing.Size(72, 20)
        Me.XTextBox7.TabIndex = 5
        Me.XTextBox7.Text = ""
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.XTextBox14)
        Me.GroupBox2.Controls.Add(Me.XTextBox13)
        Me.GroupBox2.Controls.Add(Me.XTextBox12)
        Me.GroupBox2.Controls.Add(Me.XTextBox11)
        Me.GroupBox2.Controls.Add(Me.XTextBox10)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.XTextBox9)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 216)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(256, 176)
        Me.GroupBox2.TabIndex = 37
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Control de Existencia"
        '
        'XTextBox14
        '
        Me.XTextBox14.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "costos.CantidaMinima"))
        Me.XTextBox14.EditInitialValue = Nothing
        Me.XTextBox14.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox14.FindInitialValue = Nothing
        Me.XTextBox14.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox14.IgnoreRequiered = False
        Me.XTextBox14.Location = New System.Drawing.Point(136, 144)
        Me.XTextBox14.Name = "XTextBox14"
        Me.XTextBox14.NewInitialValue = Nothing
        Me.XTextBox14.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox14.Requiered = False
        Me.XTextBox14.Size = New System.Drawing.Size(104, 20)
        Me.XTextBox14.TabIndex = 16
        Me.XTextBox14.Text = ""
        '
        'XTextBox13
        '
        Me.XTextBox13.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "costos.CantidadRecibida"))
        Me.XTextBox13.EditInitialValue = Nothing
        Me.XTextBox13.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox13.FindInitialValue = Nothing
        Me.XTextBox13.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox13.IgnoreRequiered = False
        Me.XTextBox13.Location = New System.Drawing.Point(136, 120)
        Me.XTextBox13.Name = "XTextBox13"
        Me.XTextBox13.NewInitialValue = Nothing
        Me.XTextBox13.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox13.Requiered = False
        Me.XTextBox13.Size = New System.Drawing.Size(104, 20)
        Me.XTextBox13.TabIndex = 47
        Me.XTextBox13.Text = ""
        '
        'XTextBox12
        '
        Me.XTextBox12.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "costos.no_orden"))
        Me.XTextBox12.EditInitialValue = Nothing
        Me.XTextBox12.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox12.FindInitialValue = Nothing
        Me.XTextBox12.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox12.IgnoreRequiered = False
        Me.XTextBox12.Location = New System.Drawing.Point(136, 96)
        Me.XTextBox12.Name = "XTextBox12"
        Me.XTextBox12.NewInitialValue = Nothing
        Me.XTextBox12.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox12.Requiered = False
        Me.XTextBox12.Size = New System.Drawing.Size(104, 20)
        Me.XTextBox12.TabIndex = 46
        Me.XTextBox12.Text = ""
        '
        'XTextBox11
        '
        Me.XTextBox11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "costos.CantidaOrdenada"))
        Me.XTextBox11.EditInitialValue = Nothing
        Me.XTextBox11.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox11.FindInitialValue = Nothing
        Me.XTextBox11.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox11.IgnoreRequiered = False
        Me.XTextBox11.Location = New System.Drawing.Point(136, 72)
        Me.XTextBox11.Name = "XTextBox11"
        Me.XTextBox11.NewInitialValue = Nothing
        Me.XTextBox11.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox11.Requiered = False
        Me.XTextBox11.Size = New System.Drawing.Size(104, 20)
        Me.XTextBox11.TabIndex = 45
        Me.XTextBox11.Text = ""
        '
        'XTextBox10
        '
        Me.XTextBox10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "costos.PuntoReorden"))
        Me.XTextBox10.EditInitialValue = Nothing
        Me.XTextBox10.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox10.FindInitialValue = Nothing
        Me.XTextBox10.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox10.IgnoreRequiered = False
        Me.XTextBox10.Location = New System.Drawing.Point(135, 48)
        Me.XTextBox10.Name = "XTextBox10"
        Me.XTextBox10.NewInitialValue = Nothing
        Me.XTextBox10.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox10.Requiered = False
        Me.XTextBox10.Size = New System.Drawing.Size(104, 20)
        Me.XTextBox10.TabIndex = 15
        Me.XTextBox10.Text = ""
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(8, 128)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(120, 16)
        Me.Label12.TabIndex = 43
        Me.Label12.Text = "Cantidad Recibida:"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(8, 104)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(120, 16)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "Numero Orden:"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(8, 80)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(120, 16)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "Cantidad Ordenada:"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(8, 152)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 16)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Exietencia Minima:"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 16)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Punto Reorden:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 16)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Existencia Maxima:"
        '
        'XTextBox9
        '
        Me.XTextBox9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "costos.CantidadMaxima"))
        Me.XTextBox9.EditInitialValue = Nothing
        Me.XTextBox9.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox9.FindInitialValue = Nothing
        Me.XTextBox9.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox9.IgnoreRequiered = False
        Me.XTextBox9.Location = New System.Drawing.Point(134, 21)
        Me.XTextBox9.Name = "XTextBox9"
        Me.XTextBox9.NewInitialValue = Nothing
        Me.XTextBox9.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox9.Requiered = False
        Me.XTextBox9.Size = New System.Drawing.Size(104, 20)
        Me.XTextBox9.TabIndex = 14
        Me.XTextBox9.Text = ""
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.XTextBox27)
        Me.GroupBox4.Controls.Add(Me.XTextBox26)
        Me.GroupBox4.Controls.Add(Me.XTextBox25)
        Me.GroupBox4.Controls.Add(Me.Label25)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.LibxCheckBox5)
        Me.GroupBox4.Controls.Add(Me.LibxCheckBox4)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Location = New System.Drawing.Point(536, 216)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(200, 176)
        Me.GroupBox4.TabIndex = 39
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Controles"
        '
        'LibxCheckBox4
        '
        Me.LibxCheckBox4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LibxCheckBox4.Checked = True
        Me.LibxCheckBox4.CheckState = System.Windows.Forms.CheckState.Checked
        Me.LibxCheckBox4.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.LibXConnector1, "costos.AplicaDscto"))
        Me.LibxCheckBox4.EditInitialValue = Nothing
        Me.LibxCheckBox4.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox4.FindInitialValue = Nothing
        Me.LibxCheckBox4.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox4.IgnoreRequiered = False
        Me.LibxCheckBox4.KeepEnabled = False
        Me.LibxCheckBox4.Location = New System.Drawing.Point(8, 24)
        Me.LibxCheckBox4.Name = "LibxCheckBox4"
        Me.LibxCheckBox4.NewInitialValue = Nothing
        Me.LibxCheckBox4.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox4.ReadOnly = False
        Me.LibxCheckBox4.Requiered = False
        Me.LibxCheckBox4.Size = New System.Drawing.Size(176, 24)
        Me.LibxCheckBox4.TabIndex = 12
        Me.LibxCheckBox4.Text = "Aplica Descuento:"
        Me.LibxCheckBox4.ThreeState = True
        Me.LibxCheckBox4.value = 1
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.XTextBox19)
        Me.GroupBox5.Controls.Add(Me.XTextBox18)
        Me.GroupBox5.Controls.Add(Me.XTextBox17)
        Me.GroupBox5.Controls.Add(Me.XTextBox16)
        Me.GroupBox5.Controls.Add(Me.XTextBox15)
        Me.GroupBox5.Controls.Add(Me.Label19)
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.XTextBox5)
        Me.GroupBox5.Location = New System.Drawing.Point(280, 216)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(248, 176)
        Me.GroupBox5.TabIndex = 42
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Fechas"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label23)
        Me.GroupBox6.Controls.Add(Me.Label22)
        Me.GroupBox6.Controls.Add(Me.XTextBox22)
        Me.GroupBox6.Controls.Add(Me.XTextBox23)
        Me.GroupBox6.Controls.Add(Me.XTextBox20)
        Me.GroupBox6.Controls.Add(Me.Label20)
        Me.GroupBox6.Controls.Add(Me.XTextBox21)
        Me.GroupBox6.Controls.Add(Me.Label21)
        Me.GroupBox6.Controls.Add(Me.Label24)
        Me.GroupBox6.Controls.Add(Me.XTextBox24)
        Me.GroupBox6.Location = New System.Drawing.Point(536, 16)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(200, 192)
        Me.GroupBox6.TabIndex = 43
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Localizacion"
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(8, 32)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 24)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Ult. Compra:"
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(8, 56)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 24)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Ult. Conteo:"
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(8, 80)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 24)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "Ult. Venta:"
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(8, 104)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(72, 24)
        Me.Label17.TabIndex = 3
        Me.Label17.Text = "Frizado:"
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(8, 128)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(88, 24)
        Me.Label18.TabIndex = 4
        Me.Label18.Text = "Expira Frizado:"
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(8, 149)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(88, 11)
        Me.Label19.TabIndex = 5
        Me.Label19.Text = "Descontinuado:"
        '
        'XTextBox5
        '
        Me.XTextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "costos.FechaCompra"))
        Me.XTextBox5.EditInitialValue = Nothing
        Me.XTextBox5.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox5.FindInitialValue = Nothing
        Me.XTextBox5.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox5.IgnoreRequiered = False
        Me.XTextBox5.Location = New System.Drawing.Point(88, 24)
        Me.XTextBox5.Name = "XTextBox5"
        Me.XTextBox5.NewInitialValue = Nothing
        Me.XTextBox5.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox5.Requiered = False
        Me.XTextBox5.Size = New System.Drawing.Size(144, 20)
        Me.XTextBox5.TabIndex = 49
        Me.XTextBox5.Text = ""
        '
        'XTextBox15
        '
        Me.XTextBox15.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "costos.FechaConteo"))
        Me.XTextBox15.EditInitialValue = Nothing
        Me.XTextBox15.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox15.FindInitialValue = Nothing
        Me.XTextBox15.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox15.IgnoreRequiered = False
        Me.XTextBox15.Location = New System.Drawing.Point(88, 48)
        Me.XTextBox15.Name = "XTextBox15"
        Me.XTextBox15.NewInitialValue = Nothing
        Me.XTextBox15.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox15.Requiered = False
        Me.XTextBox15.Size = New System.Drawing.Size(144, 20)
        Me.XTextBox15.TabIndex = 50
        Me.XTextBox15.Text = ""
        '
        'XTextBox16
        '
        Me.XTextBox16.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "costos.FechaVenta"))
        Me.XTextBox16.EditInitialValue = Nothing
        Me.XTextBox16.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox16.FindInitialValue = Nothing
        Me.XTextBox16.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox16.IgnoreRequiered = False
        Me.XTextBox16.Location = New System.Drawing.Point(88, 72)
        Me.XTextBox16.Name = "XTextBox16"
        Me.XTextBox16.NewInitialValue = Nothing
        Me.XTextBox16.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox16.Requiered = False
        Me.XTextBox16.Size = New System.Drawing.Size(144, 20)
        Me.XTextBox16.TabIndex = 51
        Me.XTextBox16.Text = ""
        '
        'XTextBox17
        '
        Me.XTextBox17.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "costos.FechaFrizado"))
        Me.XTextBox17.EditInitialValue = Nothing
        Me.XTextBox17.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox17.FindInitialValue = Nothing
        Me.XTextBox17.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox17.IgnoreRequiered = False
        Me.XTextBox17.Location = New System.Drawing.Point(88, 96)
        Me.XTextBox17.Name = "XTextBox17"
        Me.XTextBox17.NewInitialValue = Nothing
        Me.XTextBox17.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox17.Requiered = False
        Me.XTextBox17.Size = New System.Drawing.Size(144, 20)
        Me.XTextBox17.TabIndex = 52
        Me.XTextBox17.Text = ""
        '
        'XTextBox18
        '
        Me.XTextBox18.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "costos.ExpiraFrizado"))
        Me.XTextBox18.EditInitialValue = Nothing
        Me.XTextBox18.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox18.FindInitialValue = Nothing
        Me.XTextBox18.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox18.IgnoreRequiered = False
        Me.XTextBox18.Location = New System.Drawing.Point(88, 120)
        Me.XTextBox18.Name = "XTextBox18"
        Me.XTextBox18.NewInitialValue = Nothing
        Me.XTextBox18.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox18.Requiered = False
        Me.XTextBox18.Size = New System.Drawing.Size(144, 20)
        Me.XTextBox18.TabIndex = 53
        Me.XTextBox18.Text = ""
        '
        'XTextBox19
        '
        Me.XTextBox19.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "costos.FechaInativo"))
        Me.XTextBox19.EditInitialValue = Nothing
        Me.XTextBox19.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox19.FindInitialValue = Nothing
        Me.XTextBox19.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox19.IgnoreRequiered = False
        Me.XTextBox19.Location = New System.Drawing.Point(88, 144)
        Me.XTextBox19.Name = "XTextBox19"
        Me.XTextBox19.NewInitialValue = Nothing
        Me.XTextBox19.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox19.Requiered = False
        Me.XTextBox19.Size = New System.Drawing.Size(144, 20)
        Me.XTextBox19.TabIndex = 54
        Me.XTextBox19.Text = ""
        '
        'XTextBox20
        '
        Me.XTextBox20.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "costos.Fila"))
        Me.XTextBox20.EditInitialValue = Nothing
        Me.XTextBox20.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox20.FindInitialValue = Nothing
        Me.XTextBox20.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox20.IgnoreRequiered = False
        Me.XTextBox20.Location = New System.Drawing.Point(80, 80)
        Me.XTextBox20.Name = "XTextBox20"
        Me.XTextBox20.NewInitialValue = Nothing
        Me.XTextBox20.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox20.Requiered = False
        Me.XTextBox20.Size = New System.Drawing.Size(104, 20)
        Me.XTextBox20.TabIndex = 19
        Me.XTextBox20.Text = ""
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(8, 64)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(64, 24)
        Me.Label20.TabIndex = 51
        Me.Label20.Text = "Tramo:"
        '
        'XTextBox21
        '
        Me.XTextBox21.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "costos.Tramo"))
        Me.XTextBox21.EditInitialValue = Nothing
        Me.XTextBox21.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox21.FindInitialValue = Nothing
        Me.XTextBox21.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox21.IgnoreRequiered = False
        Me.XTextBox21.Location = New System.Drawing.Point(80, 56)
        Me.XTextBox21.Name = "XTextBox21"
        Me.XTextBox21.NewInitialValue = Nothing
        Me.XTextBox21.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox21.Requiered = False
        Me.XTextBox21.Size = New System.Drawing.Size(104, 20)
        Me.XTextBox21.TabIndex = 18
        Me.XTextBox21.Text = ""
        '
        'XTextBox22
        '
        Me.XTextBox22.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "costos.Ubicacion"))
        Me.XTextBox22.EditInitialValue = Nothing
        Me.XTextBox22.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox22.FindInitialValue = Nothing
        Me.XTextBox22.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox22.IgnoreRequiered = False
        Me.XTextBox22.Location = New System.Drawing.Point(8, 144)
        Me.XTextBox22.Name = "XTextBox22"
        Me.XTextBox22.NewInitialValue = Nothing
        Me.XTextBox22.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox22.Requiered = False
        Me.XTextBox22.Size = New System.Drawing.Size(176, 20)
        Me.XTextBox22.TabIndex = 56
        Me.XTextBox22.Text = ""
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(8, 112)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(64, 16)
        Me.Label21.TabIndex = 54
        Me.Label21.Text = "Columna:"
        '
        'XTextBox23
        '
        Me.XTextBox23.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "costos.Columna"))
        Me.XTextBox23.EditInitialValue = Nothing
        Me.XTextBox23.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox23.FindInitialValue = Nothing
        Me.XTextBox23.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox23.IgnoreRequiered = False
        Me.XTextBox23.Location = New System.Drawing.Point(80, 104)
        Me.XTextBox23.Name = "XTextBox23"
        Me.XTextBox23.NewInitialValue = Nothing
        Me.XTextBox23.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox23.Requiered = False
        Me.XTextBox23.Size = New System.Drawing.Size(104, 20)
        Me.XTextBox23.TabIndex = 55
        Me.XTextBox23.Text = ""
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(8, 88)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(64, 24)
        Me.Label22.TabIndex = 57
        Me.Label22.Text = "Fila:"
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(64, 128)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(56, 16)
        Me.Label23.TabIndex = 58
        Me.Label23.Text = "Ubicacion:"
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(8, 40)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(64, 24)
        Me.Label24.TabIndex = 59
        Me.Label24.Text = "Existencia:"
        '
        'XTextBox24
        '
        Me.XTextBox24.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "costos.Existencia"))
        Me.XTextBox24.EditInitialValue = Nothing
        Me.XTextBox24.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox24.FindInitialValue = Nothing
        Me.XTextBox24.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox24.IgnoreRequiered = False
        Me.XTextBox24.Location = New System.Drawing.Point(80, 32)
        Me.XTextBox24.Name = "XTextBox24"
        Me.XTextBox24.NewInitialValue = Nothing
        Me.XTextBox24.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox24.Requiered = False
        Me.XTextBox24.Size = New System.Drawing.Size(104, 20)
        Me.XTextBox24.TabIndex = 17
        Me.XTextBox24.Text = ""
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
        Me.LibXDbSourceTable1.SerialColumnName = Nothing
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = Nothing
        Me.LibXDbSourceTable1.TableName = "costos"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
        '
        'LibxCheckBox5
        '
        Me.LibxCheckBox5.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LibxCheckBox5.Checked = True
        Me.LibxCheckBox5.CheckState = System.Windows.Forms.CheckState.Checked
        Me.LibxCheckBox5.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.LibXConnector1, "costos.FrizadoConteo"))
        Me.LibxCheckBox5.EditInitialValue = Nothing
        Me.LibxCheckBox5.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox5.FindInitialValue = Nothing
        Me.LibxCheckBox5.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox5.IgnoreRequiered = False
        Me.LibxCheckBox5.KeepEnabled = False
        Me.LibxCheckBox5.Location = New System.Drawing.Point(8, 56)
        Me.LibxCheckBox5.Name = "LibxCheckBox5"
        Me.LibxCheckBox5.NewInitialValue = Nothing
        Me.LibxCheckBox5.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox5.ReadOnly = False
        Me.LibxCheckBox5.Requiered = False
        Me.LibxCheckBox5.Size = New System.Drawing.Size(176, 24)
        Me.LibxCheckBox5.TabIndex = 13
        Me.LibxCheckBox5.Text = "Frizado Conteo"
        Me.LibxCheckBox5.ThreeState = True
        Me.LibxCheckBox5.value = 1
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 16)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "Ultimo Costo:"
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(8, 112)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 16)
        Me.Label13.TabIndex = 61
        Me.Label13.Text = "Costo Prom.:"
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(8, 144)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(72, 16)
        Me.Label25.TabIndex = 62
        Me.Label25.Text = "Exist. Ant.:"
        '
        'XTextBox25
        '
        Me.XTextBox25.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "costos.UltimoCosto"))
        Me.XTextBox25.EditInitialValue = Nothing
        Me.XTextBox25.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox25.FindInitialValue = Nothing
        Me.XTextBox25.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox25.IgnoreRequiered = False
        Me.XTextBox25.Location = New System.Drawing.Point(88, 88)
        Me.XTextBox25.Name = "XTextBox25"
        Me.XTextBox25.NewInitialValue = Nothing
        Me.XTextBox25.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox25.Requiered = False
        Me.XTextBox25.Size = New System.Drawing.Size(104, 20)
        Me.XTextBox25.TabIndex = 63
        Me.XTextBox25.Text = ""
        '
        'XTextBox26
        '
        Me.XTextBox26.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "costos.CostoPromedio"))
        Me.XTextBox26.EditInitialValue = Nothing
        Me.XTextBox26.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox26.FindInitialValue = Nothing
        Me.XTextBox26.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox26.IgnoreRequiered = False
        Me.XTextBox26.Location = New System.Drawing.Point(88, 112)
        Me.XTextBox26.Name = "XTextBox26"
        Me.XTextBox26.NewInitialValue = Nothing
        Me.XTextBox26.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox26.Requiered = False
        Me.XTextBox26.Size = New System.Drawing.Size(104, 20)
        Me.XTextBox26.TabIndex = 64
        Me.XTextBox26.Text = ""
        '
        'XTextBox27
        '
        Me.XTextBox27.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "costos.ExistenciaAnterior"))
        Me.XTextBox27.EditInitialValue = Nothing
        Me.XTextBox27.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox27.FindInitialValue = Nothing
        Me.XTextBox27.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox27.IgnoreRequiered = False
        Me.XTextBox27.Location = New System.Drawing.Point(88, 136)
        Me.XTextBox27.Name = "XTextBox27"
        Me.XTextBox27.NewInitialValue = Nothing
        Me.XTextBox27.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox27.Requiered = False
        Me.XTextBox27.Size = New System.Drawing.Size(104, 20)
        Me.XTextBox27.TabIndex = 65
        Me.XTextBox27.Text = ""
        '
        'invcosm01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(786, 480)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "invcosm01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Costos"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cxpterm01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub XTextBox23_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XTextBox23.TextChanged

    End Sub
End Class
