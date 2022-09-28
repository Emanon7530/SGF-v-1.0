Public Class i_security
    Inherits System.Windows.Forms.Form
    Dim strValidUser As String
    Dim mValidUser As Boolean = False
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
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents tvw_Users As System.Windows.Forms.TreeView
    Friend WithEvents tvw_System As System.Windows.Forms.TreeView
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents ToolBarButton3 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton6 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton8 As System.Windows.Forms.ToolBarButton
    Friend WithEvents btnUser As System.Windows.Forms.ToolBarButton
    Friend WithEvents btnProgramas As System.Windows.Forms.ToolBarButton
    Friend WithEvents btnOk As System.Windows.Forms.ToolBarButton
    Friend WithEvents btnCancel As System.Windows.Forms.ToolBarButton
    Friend WithEvents btnRefresh As System.Windows.Forms.ToolBarButton
    Friend WithEvents btnExpand As System.Windows.Forms.ToolBarButton
    Friend WithEvents btnCollapse As System.Windows.Forms.ToolBarButton
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel2 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents LibXDbSourceTable2 As LibX.LibXDbSourceTable
    Friend WithEvents LibXDbSourceTable3 As LibX.LibXDbSourceTable
    Friend WithEvents DataSet1 As System.Data.DataSet
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
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents DataColumn17 As System.Data.DataColumn
    Friend WithEvents DataColumn18 As System.Data.DataColumn
    Friend WithEvents DataColumn19 As System.Data.DataColumn
    Friend WithEvents DataColumn20 As System.Data.DataColumn
    Friend WithEvents DataColumn21 As System.Data.DataColumn
    Friend WithEvents scusers As System.Data.DataTable
    Friend WithEvents stmenue As System.Data.DataTable
    Friend WithEvents stmenud As System.Data.DataTable
    Friend WithEvents btnAccess As System.Windows.Forms.ToolBarButton
    Friend WithEvents btnAsign As System.Windows.Forms.ToolBarButton
    Friend WithEvents StatusBarPanel3 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel4 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel5 As System.Windows.Forms.StatusBarPanel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(i_security))
        Me.StatusBar1 = New System.Windows.Forms.StatusBar
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel
        Me.StatusBarPanel2 = New System.Windows.Forms.StatusBarPanel
        Me.StatusBarPanel3 = New System.Windows.Forms.StatusBarPanel
        Me.StatusBarPanel4 = New System.Windows.Forms.StatusBarPanel
        Me.StatusBarPanel5 = New System.Windows.Forms.StatusBarPanel
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.btnUser = New System.Windows.Forms.ToolBarButton
        Me.btnProgramas = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton3 = New System.Windows.Forms.ToolBarButton
        Me.btnOk = New System.Windows.Forms.ToolBarButton
        Me.btnCancel = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton6 = New System.Windows.Forms.ToolBarButton
        Me.btnRefresh = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton8 = New System.Windows.Forms.ToolBarButton
        Me.btnExpand = New System.Windows.Forms.ToolBarButton
        Me.btnCollapse = New System.Windows.Forms.ToolBarButton
        Me.btnAccess = New System.Windows.Forms.ToolBarButton
        Me.btnAsign = New System.Windows.Forms.ToolBarButton
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem12 = New System.Windows.Forms.MenuItem
        Me.MenuItem13 = New System.Windows.Forms.MenuItem
        Me.MenuItem14 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem15 = New System.Windows.Forms.MenuItem
        Me.MenuItem16 = New System.Windows.Forms.MenuItem
        Me.MenuItem18 = New System.Windows.Forms.MenuItem
        Me.MenuItem17 = New System.Windows.Forms.MenuItem
        Me.tvw_Users = New System.Windows.Forms.TreeView
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.tvw_System = New System.Windows.Forms.TreeView
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem19 = New System.Windows.Forms.MenuItem
        Me.MenuItem20 = New System.Windows.Forms.MenuItem
        Me.MenuItem21 = New System.Windows.Forms.MenuItem
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.DataSet1 = New System.Data.DataSet
        Me.scusers = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.stmenue = New System.Data.DataTable
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn7 = New System.Data.DataColumn
        Me.DataColumn8 = New System.Data.DataColumn
        Me.DataColumn9 = New System.Data.DataColumn
        Me.DataColumn10 = New System.Data.DataColumn
        Me.DataColumn11 = New System.Data.DataColumn
        Me.stmenud = New System.Data.DataTable
        Me.DataColumn12 = New System.Data.DataColumn
        Me.DataColumn13 = New System.Data.DataColumn
        Me.DataColumn14 = New System.Data.DataColumn
        Me.DataColumn15 = New System.Data.DataColumn
        Me.DataColumn16 = New System.Data.DataColumn
        Me.DataColumn17 = New System.Data.DataColumn
        Me.DataColumn18 = New System.Data.DataColumn
        Me.DataColumn19 = New System.Data.DataColumn
        Me.DataColumn20 = New System.Data.DataColumn
        Me.DataColumn21 = New System.Data.DataColumn
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable3 = New LibX.LibXDbSourceTable
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.scusers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stmenue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stmenud, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = New System.Drawing.Point(0, 419)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel1, Me.StatusBarPanel2, Me.StatusBarPanel3, Me.StatusBarPanel4, Me.StatusBarPanel5})
        Me.StatusBar1.ShowPanels = True
        Me.StatusBar1.Size = New System.Drawing.Size(952, 22)
        Me.StatusBar1.TabIndex = 0
        Me.StatusBar1.Text = "StatusBar1"
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.Text = "Usuario Seleccionado:"
        Me.StatusBarPanel1.Width = 300
        '
        'StatusBarPanel2
        '
        Me.StatusBarPanel2.Text = "StatusBarPanel2"
        '
        'StatusBarPanel3
        '
        Me.StatusBarPanel3.Text = "StatusBarPanel3"
        Me.StatusBarPanel3.Width = 200
        '
        'StatusBarPanel4
        '
        Me.StatusBarPanel4.Text = "StatusBarPanel4"
        Me.StatusBarPanel4.Width = 300
        '
        'StatusBarPanel5
        '
        Me.StatusBarPanel5.Text = "StatusBarPanel5"
        Me.StatusBarPanel5.Width = 400
        '
        'ToolBar1
        '
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.btnUser, Me.btnProgramas, Me.ToolBarButton3, Me.btnOk, Me.btnCancel, Me.ToolBarButton6, Me.btnRefresh, Me.ToolBarButton8, Me.btnExpand, Me.btnCollapse, Me.btnAccess, Me.btnAsign})
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImageList1
        Me.ToolBar1.Location = New System.Drawing.Point(0, 0)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(952, 42)
        Me.ToolBar1.TabIndex = 1
        '
        'btnUser
        '
        Me.btnUser.ImageIndex = 1
        Me.btnUser.Text = "Usuarios"
        '
        'btnProgramas
        '
        Me.btnProgramas.ImageIndex = 2
        Me.btnProgramas.Text = "Programas"
        '
        'ToolBarButton3
        '
        Me.ToolBarButton3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'btnOk
        '
        Me.btnOk.Enabled = False
        Me.btnOk.ImageIndex = 5
        Me.btnOk.Text = "Aceptar"
        '
        'btnCancel
        '
        Me.btnCancel.Enabled = False
        Me.btnCancel.ImageIndex = 6
        Me.btnCancel.Text = "Cancelar"
        '
        'ToolBarButton6
        '
        Me.ToolBarButton6.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'btnRefresh
        '
        Me.btnRefresh.ImageIndex = 7
        Me.btnRefresh.Text = "Refrescar"
        '
        'ToolBarButton8
        '
        Me.ToolBarButton8.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'btnExpand
        '
        Me.btnExpand.ImageIndex = 2
        Me.btnExpand.Text = "Expandir"
        '
        'btnCollapse
        '
        Me.btnCollapse.ImageIndex = 8
        Me.btnCollapse.Text = "Collapsar"
        '
        'btnAccess
        '
        Me.btnAccess.Text = "Accesos"
        '
        'btnAsign
        '
        Me.btnAsign.Text = "Asignar Accesos"
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem5})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem8, Me.MenuItem9, Me.MenuItem10})
        Me.MenuItem1.Text = "Archivo"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 0
        Me.MenuItem8.Text = "Imprimir"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 1
        Me.MenuItem9.Text = "-"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 2
        Me.MenuItem10.Text = "Salir"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem11})
        Me.MenuItem2.Text = "Editar"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 0
        Me.MenuItem11.Text = "Refrescar"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.Text = "Ver"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 3
        Me.MenuItem4.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem6, Me.MenuItem7, Me.MenuItem12, Me.MenuItem13, Me.MenuItem14})
        Me.MenuItem4.Text = "Herramientas"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 0
        Me.MenuItem6.Text = "Usuarios"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 1
        Me.MenuItem7.Text = "Programas"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 2
        Me.MenuItem12.Text = "-"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 3
        Me.MenuItem13.Text = "Expandir"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 4
        Me.MenuItem14.Text = "Colapsar"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 4
        Me.MenuItem5.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem15, Me.MenuItem16, Me.MenuItem18, Me.MenuItem17})
        Me.MenuItem5.Text = "Ayuda"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 0
        Me.MenuItem15.Text = "Indice"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 1
        Me.MenuItem16.Text = "-"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 2
        Me.MenuItem18.Text = "Contenido"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 3
        Me.MenuItem17.Text = "Sobre SGT Security"
        '
        'tvw_Users
        '
        Me.tvw_Users.CheckBoxes = True
        Me.tvw_Users.Dock = System.Windows.Forms.DockStyle.Left
        Me.tvw_Users.FullRowSelect = True
        Me.tvw_Users.HotTracking = True
        Me.tvw_Users.ImageList = Me.ImageList1
        Me.tvw_Users.Location = New System.Drawing.Point(0, 42)
        Me.tvw_Users.Name = "tvw_Users"
        Me.tvw_Users.Nodes.AddRange(New System.Windows.Forms.TreeNode() {New System.Windows.Forms.TreeNode("Usuarios")})
        Me.tvw_Users.ShowRootLines = False
        Me.tvw_Users.Size = New System.Drawing.Size(200, 377)
        Me.tvw_Users.TabIndex = 2
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(200, 42)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 377)
        Me.Splitter1.TabIndex = 3
        Me.Splitter1.TabStop = False
        '
        'tvw_System
        '
        Me.tvw_System.CheckBoxes = True
        Me.tvw_System.ContextMenu = Me.ContextMenu1
        Me.tvw_System.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvw_System.ImageList = Me.ImageList1
        Me.tvw_System.Location = New System.Drawing.Point(203, 42)
        Me.tvw_System.Name = "tvw_System"
        Me.tvw_System.Nodes.AddRange(New System.Windows.Forms.TreeNode() {New System.Windows.Forms.TreeNode("Sistemas", 2, 2)})
        Me.tvw_System.Size = New System.Drawing.Size(749, 377)
        Me.tvw_System.TabIndex = 4
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem19, Me.MenuItem20, Me.MenuItem21})
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 0
        Me.MenuItem19.Text = "Agregar"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 1
        Me.MenuItem20.Text = "Editar"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 2
        Me.MenuItem21.Text = "Eliminar"
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
        Me.LibXConnector1.DataMember = "scusers"
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
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.LibXDbSourceTable1, Me.LibXDbSourceTable2, Me.LibXDbSourceTable3})
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
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.scusers, Me.stmenue, Me.stmenud})
        '
        'scusers
        '
        Me.scusers.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5})
        Me.scusers.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"userid"}, True)})
        Me.scusers.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn1}
        Me.scusers.TableName = "scusers"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.AutoIncrement = True
        Me.DataColumn1.ColumnName = "userid"
        Me.DataColumn1.DataType = GetType(System.Int32)
        Me.DataColumn1.ReadOnly = True
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "groupid"
        Me.DataColumn2.DataType = GetType(System.Int32)
        '
        'DataColumn3
        '
        Me.DataColumn3.AllowDBNull = False
        Me.DataColumn3.ColumnName = "vend_code"
        Me.DataColumn3.DataType = GetType(System.Int32)
        '
        'DataColumn4
        '
        Me.DataColumn4.AllowDBNull = False
        Me.DataColumn4.ColumnName = "username"
        Me.DataColumn4.MaxLength = 8
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "passwrd"
        Me.DataColumn5.MaxLength = 20
        '
        'stmenue
        '
        Me.stmenue.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11})
        Me.stmenue.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"menu_code"}, True)})
        Me.stmenue.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn6}
        Me.stmenue.TableName = "stmenue"
        '
        'DataColumn6
        '
        Me.DataColumn6.AllowDBNull = False
        Me.DataColumn6.AutoIncrement = True
        Me.DataColumn6.ColumnName = "menu_code"
        Me.DataColumn6.DataType = GetType(System.Int32)
        Me.DataColumn6.ReadOnly = True
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "Type"
        Me.DataColumn7.DataType = GetType(System.Int32)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "descr"
        Me.DataColumn8.MaxLength = 40
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "path"
        Me.DataColumn9.MaxLength = 60
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "shortcut"
        Me.DataColumn10.MaxLength = 1
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "menu_modulo"
        Me.DataColumn11.MaxLength = 3
        '
        'stmenud
        '
        Me.stmenud.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21})
        Me.stmenud.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"menu_code", "progid"}, True)})
        Me.stmenud.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn12, Me.DataColumn13}
        Me.stmenud.TableName = "stmenud"
        '
        'DataColumn12
        '
        Me.DataColumn12.AllowDBNull = False
        Me.DataColumn12.ColumnName = "menu_code"
        Me.DataColumn12.DataType = GetType(System.Int32)
        '
        'DataColumn13
        '
        Me.DataColumn13.AllowDBNull = False
        Me.DataColumn13.AutoIncrement = True
        Me.DataColumn13.ColumnName = "progid"
        Me.DataColumn13.DataType = GetType(System.Int32)
        Me.DataColumn13.ReadOnly = True
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "Nivel1"
        Me.DataColumn14.DataType = GetType(System.Int32)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "Nivel2"
        Me.DataColumn15.DataType = GetType(System.Int32)
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "Nivel3"
        Me.DataColumn16.DataType = GetType(System.Int32)
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "Type"
        Me.DataColumn17.DataType = GetType(System.Int32)
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "descr"
        Me.DataColumn18.MaxLength = 40
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "path"
        Me.DataColumn19.MaxLength = 60
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "program"
        Me.DataColumn20.MaxLength = 15
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "parameters"
        Me.DataColumn21.MaxLength = 60
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
        Me.LibXDbSourceTable1.SerialColumnName = "userid"
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = Nothing
        Me.LibXDbSourceTable1.TableName = "scusers"
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
        Me.LibXDbSourceTable2.SerialColumnName = "menu_code"
        Me.LibXDbSourceTable2.Sort = Nothing
        Me.LibXDbSourceTable2.Source = Nothing
        Me.LibXDbSourceTable2.TableName = "stmenue"
        Me.LibXDbSourceTable2.UpdateOrder = 0
        Me.LibXDbSourceTable2.UseRowRetrieve = False
        '
        'LibXDbSourceTable3
        '
        Me.LibXDbSourceTable3.AllowDelete = True
        Me.LibXDbSourceTable3.AllowEdit = True
        Me.LibXDbSourceTable3.AllowNew = True
        Me.LibXDbSourceTable3.AutoIncrementSerial = False
        Me.LibXDbSourceTable3.CustomDbUpdate = False
        Me.LibXDbSourceTable3.DeleteOrder = 0
        Me.LibXDbSourceTable3.FillOnQuery = True
        Me.LibXDbSourceTable3.FillOnRowChange = False
        Me.LibXDbSourceTable3.HeaderIsOnGrid = False
        Me.LibXDbSourceTable3.InnerJon = True
        Me.LibXDbSourceTable3.InsertOrder = 0
        Me.LibXDbSourceTable3.IsDetail = False
        Me.LibXDbSourceTable3.KeyFields = Nothing
        Me.LibXDbSourceTable3.LineColName = Nothing
        Me.LibXDbSourceTable3.MasterDetailRelation = Nothing
        Me.LibXDbSourceTable3.MasterTableName = Nothing
        Me.LibXDbSourceTable3.SerialColumnName = "progid"
        Me.LibXDbSourceTable3.Sort = Nothing
        Me.LibXDbSourceTable3.Source = Nothing
        Me.LibXDbSourceTable3.TableName = "stmenud"
        Me.LibXDbSourceTable3.UpdateOrder = 0
        Me.LibXDbSourceTable3.UseRowRetrieve = False
        '
        'i_security
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(952, 441)
        Me.Controls.Add(Me.tvw_System)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.tvw_Users)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.StatusBar1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Menu = Me.MainMenu1
        Me.Name = "i_security"
        Me.Text = "SGF Security Console"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.scusers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stmenue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stmenud, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oTable, otable1 As DataTable
        Dim SelectStmt As String
        Dim ValidUser As String
        Dim Users As String()

        Try
            If LibX.Data.Manager.Login = False Then
                Throw New ApplicationException("No tiene permiso para ejecutar este programa!")
            End If

            Users = Split(Configuration.ConfigurationSettings.AppSettings.Get("LibxAllowUser"), ",")
            ValidUser = Configuration.ConfigurationSettings.AppSettings.Get("LibxAllowUser")

            For Each oUser As String In Users
                If LibX.User.UserName.ToLower.Trim = oUser.ToLower.Trim Then
                    mValidUser = True
                End If
            Next

            If mValidUser = False Then
                Throw New ApplicationException("No tiene permiso para ejecutar este programa!")
            End If

            LoadUser()

        Catch ex As Exception
            LibX.Log.UseConnection = False
            LibX.Log.Show(ex)
            Application.Exit()
        End Try
    End Sub

    Private Sub LoadUser()
        Dim oTable As DataTable
        Dim SelectStmt As String

        Try
            '// Usuarios
            SelectStmt = "select userid,username,vend_name,scusers.vend_code from scusers " & _
                         " inner join ftvendm on ftvendm.vend_code = scusers.vend_code " & _
                         " and scusers.username <> 'UserAdmin'"

            oTable = LibX.Data.Manager.GetDataTable(SelectStmt)
            tvw_Users.Nodes(0).Nodes.Clear()

            For Each oRow As DataRow In oTable.Rows
                Dim lvw_Node As TreeNode = tvw_Users.Nodes(0).Nodes.Add(oRow!vend_name)
                lvw_Node.Tag = oRow.ItemArray
                lvw_Node.ImageIndex = 1
                lvw_Node.SelectedImageIndex = 1
            Next

            tvw_Users.Nodes(0).Expand()


        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub
    Private Sub tvw_System_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvw_System.AfterSelect

    End Sub

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Try
            If e.Button Is btnExpand Then
                tvw_System.ExpandAll()
            End If

            If e.Button Is btnCollapse Then
                tvw_System.CollapseAll()
            End If

            If e.Button Is btnOk Then
                btnOk.Enabled = False
                btnCancel.Enabled = False
                SaveAccesos()
            End If

            If e.Button Is btnCancel Then
                btnOk.Enabled = False
                btnCancel.Enabled = False
            End If

            If e.Button Is btnRefresh Then
                LoadUser()
                RefreshOptions()
            End If

            If e.Button Is btnProgramas Then
                LibX.LibXRunner.Run("i_stprogrm01", "ADM")
            End If

            If e.Button Is btnUser Then
                LibX.LibXRunner.Run("i_users", "ADM")
            End If

            If e.Button Is btnAccess Then
                LibX.LibXRunner.Run("i_access01", "ADM")
            End If

            If e.Button Is btnAsign Then
                LibX.LibXRunner.Run("i_asign01", "ADM")
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub RefreshOptions()
        For Each oNode As TreeNode In tvw_Users.Nodes(0).Nodes
            If oNode.Checked = True Then
                LoadOpciones(oNode.Tag(0))
                Exit Sub
            End If
        Next
    End Sub

    Private Sub LoadOpciones(ByVal pUserID As String)
        Dim oTable, otable1 As DataTable
        Dim SelectStmt As String

        Try
            '// Opciones
            SelectStmt = "select * from stmenue "

            oTable = LibX.Data.Manager.GetDataTable(SelectStmt)
            tvw_System.Nodes(0).Nodes.Clear()

            tvw_System.Nodes(0).ImageIndex = 2
            tvw_System.Nodes(0).SelectedImageIndex = 2

            For Each oRow As DataRow In oTable.Rows
                Dim lvw_Node As TreeNode = tvw_System.Nodes(0).Nodes.Add(oRow!descr.ToString.Trim)
                lvw_Node.ImageIndex = 3
                lvw_Node.SelectedImageIndex = 3
                lvw_Node.Tag = oRow!menu_code

                SelectStmt = "select distinct descr,program,id,progid,allowAdd, " & _
                             " allowedit,allowdelete,allowquery,allowprint " & _
                             " from stmenud,scpermsm " & _
                             " where menu_code = " & oRow!menu_code.ToString & _
                             "   and stmenud.program *= scpermsm.progname " & _
                             "   and scpermsm.userid = '" & pUserID & "'" & _
                             " order by progid "
                'SelectStmt = "select distinct descr,program,id,progid " & _
                '             " from stmenud,scpermsm " & _
                '             " where menu_code = " & oRow!menu_code.ToString & _
                '             "   and stmenud.program *= scpermsm.progname " & _
                '             "   and scpermsm.userid = '" & pUserID & "'" & _
                '             " order by progid "

                otable1 = LibX.Data.Manager.GetDataTable(SelectStmt)

                For Each oRow1 As DataRow In otable1.Rows
                    Dim lvw_Node1 As TreeNode = lvw_Node.Nodes.Add(oRow1!descr.ToString.Trim)
                    lvw_Node1.Tag = oRow1!program.ToString.Trim

                    If oRow1!id.ToString.Trim <> "0" AndAlso oRow1!id.ToString.Trim <> "" Then
                        lvw_Node1.Checked = True
                        'lvw_Node1.Parent.Checked = False 'AQUI
                    Else
                        lvw_Node1.Checked = False
                    End If

                    lvw_Node1.Nodes.Add("Agregar")
                    lvw_Node1.Nodes(0).Checked = IIf(oRow1!AllowAdd Is DBNull.Value OrElse oRow1!AllowAdd = 0, False, True)
                    lvw_Node1.Nodes.Add("Editar")
                    lvw_Node1.Nodes(1).Checked = IIf(oRow1!AllowEdit Is DBNull.Value OrElse oRow1!AllowEdit = 0, False, True)
                    lvw_Node1.Nodes.Add("Borrar")
                    lvw_Node1.Nodes(2).Checked = IIf(oRow1!AllowDelete Is DBNull.Value OrElse oRow1!AllowDelete = 0, False, True)
                    lvw_Node1.Nodes.Add("Buscar")
                    lvw_Node1.Nodes(3).Checked = IIf(oRow1!AllowQuery Is DBNull.Value OrElse oRow1!AllowQuery = 0, False, True)
                    lvw_Node1.Nodes.Add("Imprimir")
                    lvw_Node1.Nodes(4).Checked = IIf(oRow1!AllowPrint Is DBNull.Value OrElse oRow1!AllowQuery = 0, False, True)

                    lvw_Node1.ImageIndex = 4
                    lvw_Node1.SelectedImageIndex = 4
                Next

                '// Expandir Programas
                lvw_Node.Expand()
            Next

            '// Expandir los sistemas
            tvw_System.Nodes(0).Expand()


        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub
    Private Sub SaveAccesos()
        Dim XInsert As LibX.Data.XInsertStmt
        Dim xDelete As LibX.Data.XDeleteStmt
        Dim xUpdate As LibX.Data.XUpdateStmt
        Dim oRow As DataRow
        Try
            XInsert = New LibX.Data.XInsertStmt("scPermsm", "id")
            xDelete = New LibX.Data.XDeleteStmt("scPermsm")

            xDelete.Parameters.Add("userid", "")
            XInsert!userid = ""
            XInsert!progname = ""
            XInsert.Fields("AllowAdd") = 0
            XInsert.Fields("AllowEdit") = 0
            XInsert.Fields("AllowDelete") = 0
            XInsert.Fields("AllowQuery") = 0
            XInsert.Fields("AllowPrint") = 0


            '// Recorrer los usuarios seleccionados
            For Each oUserNode As TreeNode In tvw_Users.Nodes(0).Nodes

                '// Si este usuario fue seleccionado
                '// aplicar los accesos
                If oUserNode.Checked = True Then
                    oUserNode.Checked = False

                    '// Borrar todo el acceso de este usuario
                    xDelete.Fields("userid").value = oUserNode.Tag(0).ToString '// UserID
                    xDelete.Execute()

                    '// Insertar las opciones seleccionadas
                    For Each oProgramNode As TreeNode In tvw_System.Nodes(0).Nodes

                        '// Si esta opcion esta seleccionada
                        If oProgramNode.Checked = True Then
                            If oProgramNode.GetNodeCount(False) > 0 Then
                                For Each oNode As TreeNode In oProgramNode.Nodes
                                    If oNode.Checked = True AndAlso oNode.GetNodeCount(False) Then
                                        If onode.Nodes(0).Checked = True Then '// Agregar
                                            XInsert.Fields("AllowAdd").value = 1
                                        Else
                                            XInsert.Fields("AllowAdd").value = 0
                                        End If

                                        If onode.Nodes(1).Checked = True Then '// Editar
                                            XInsert.Fields("AllowEdit").value = 1
                                        Else
                                            XInsert.Fields("AllowEdit").value = 0
                                        End If
                                        If onode.Nodes(2).Checked = True Then '// Borrar
                                            XInsert.Fields("AllowDelete").value = 1
                                        Else
                                            XInsert.Fields("AllowDelete").value = 0
                                        End If
                                        If onode.Nodes(3).Checked = True Then '// Buscar
                                            XInsert.Fields("AllowQuery").value = 1
                                        Else
                                            XInsert.Fields("AllowQuery").value = 0
                                        End If
                                        If onode.Nodes(4).Checked = True Then '// Imprimir
                                            XInsert.Fields("AllowPrint").value = 1
                                        Else
                                            XInsert.Fields("AllowPrint").value = 0
                                        End If

                                        XInsert.Fields("progname").value = oNode.Tag.ToString
                                        XInsert.Fields("userid").value = oUserNode.Tag(0).ToString '// UserID
                                        XInsert.Execute()
                                    End If
                                Next
                            Else
                                If oProgramNode.Nodes(0).Checked = True Then '// Agregar
                                    XInsert.Fields("AllowAdd").value = 1
                                Else
                                    XInsert.Fields("AllowAdd").value = 0
                                End If

                                If oProgramNode.Nodes(1).Checked = True Then '// Editar
                                    XInsert.Fields("AllowEdit").value = 1
                                Else
                                    XInsert.Fields("AllowEdit").value = 0
                                End If
                                If oProgramNode.Nodes(2).Checked = True Then '// Borrar
                                    XInsert.Fields("AllowDelete").value = 1
                                Else
                                    XInsert.Fields("AllowDelete").value = 0
                                End If
                                If oProgramNode.Nodes(3).Checked = True Then '// Buscar
                                    XInsert.Fields("AllowQuery").value = 1
                                Else
                                    XInsert.Fields("AllowQuery").value = 0
                                End If
                                If oProgramNode.Nodes(4).Checked = True Then '// Buscar
                                    XInsert.Fields("AllowPrint").value = 1
                                Else
                                    XInsert.Fields("AllowPrint").value = 0
                                End If

                                XInsert.Fields("progname").value = oProgramNode.Tag.ToString
                                XInsert.Fields("userid").value = oUserNode.Tag(0).ToString '// UserID
                                XInsert.Execute()
                            End If
                        Else
                            If oProgramNode.GetNodeCount(False) > 0 Then
                                For Each oNode As TreeNode In oProgramNode.Nodes
                                    If oNode.Checked = True AndAlso oNode.GetNodeCount(False) > 0 Then
                                        If onode.Nodes(0).Checked = True Then '// Agregar
                                            XInsert.Fields("AllowAdd").value = 1
                                        Else
                                            XInsert.Fields("AllowAdd").value = 0
                                        End If

                                        If onode.Nodes(1).Checked = True Then '// Editar
                                            XInsert.Fields("AllowEdit").value = 1
                                        Else
                                            XInsert.Fields("AllowEdit").value = 0
                                        End If
                                        If onode.Nodes(2).Checked = True Then '// Borrar
                                            XInsert.Fields("AllowDelete").value = 1
                                        Else
                                            XInsert.Fields("AllowDelete").value = 0
                                        End If
                                        If onode.Nodes(3).Checked = True Then '// Buscar
                                            XInsert.Fields("AllowQuery").value = 1
                                        Else
                                            XInsert.Fields("AllowQuery").value = 0
                                        End If
                                        If onode.Nodes(4).Checked = True Then '// Buscar
                                            XInsert.Fields("AllowPrint").value = 1
                                        Else
                                            XInsert.Fields("AllowPrint").value = 0
                                        End If

                                        XInsert.Fields("progname").value = oNode.Tag.ToString
                                        XInsert.Fields("userid").value = oUserNode.Tag(0).ToString '// UserID
                                        XInsert.Execute()
                                    End If
                                Next
                            End If
                        End If
                    Next
                End If
            Next

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub tvw_System_AfterCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvw_System.AfterCheck
        Try
            btnOk.Enabled = True
            btnCancel.Enabled = True
            'e.Node.Expand()

            If e.Node.GetNodeCount(False) > 0 Then
                For Each oNode As TreeNode In e.Node.Nodes
                    oNode.Checked = e.Node.Checked
                Next
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub tvw_Users_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvw_Users.AfterSelect
        If Not e.Node.Tag Is Nothing Then
            e.Node.Checked = True
            LoadOpciones(e.Node.Tag(0))
            Me.StatusBar1.Panels(1).Text = "Seleccionado(2)"
            Me.StatusBar1.Panels(2).Text = "UserID = " & e.Node.Tag(0).ToString.Trim
            Me.StatusBar1.Panels(3).Text = "UserName = " & e.Node.Tag(1).ToString.Trim
            Me.StatusBar1.Panels(4).Text = "Nombre = " & e.Node.Tag(2).ToString.Trim
        Else
            e.Node.Checked = False
        End If
    End Sub

    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem10.Click
        Application.Exit()
    End Sub

    Private Sub MenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem19.Click
        Dim oRow As DataRow = stmenue.NewRow

        Dim oParam As LibX.LibxPrgParams
        Try
            If Me.tvw_System.TopNode Is Me.tvw_System.SelectedNode Then
                oParam = New LibX.LibxPrgParams

                With oParam
                    .IsFromOther = True
                    '.Value = Me.tvw_System.SelectedNode.Tag
                    .initMode = LibX.LibxInitModes.Insert
                End With

                LibX.App.CurrentPrgParams = oParam
                LibX.LibXRunner.Run("i_stmenue01", "ADM", True)
            Else
                oParam = New LibX.LibxPrgParams

                With oParam
                    .IsFromOther = True
                    .Value = Me.tvw_System.SelectedNode.Tag
                    .initMode = LibX.LibxInitModes.Insert
                End With

                LibX.App.CurrentPrgParams = oParam
                LibX.LibXRunner.Run("i_stmenud01", "ADM", True)

            End If


            RefreshOptions()
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
End Class
