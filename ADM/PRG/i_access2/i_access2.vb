Public Class i_access2
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
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents CheckBox9 As System.Windows.Forms.CheckBox
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
    Friend WithEvents chk_Anular As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_Costos As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_descto As System.Windows.Forms.CheckBox
    Friend WithEvents chk_BceVencido As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_VtaSusp As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_Tools As System.Windows.Forms.CheckBox
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
    Friend WithEvents Splitter2 As System.Windows.Forms.Splitter
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_cajera As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(i_access2))
        Me.StatusBar1 = New System.Windows.Forms.StatusBar
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel
        Me.StatusBarPanel2 = New System.Windows.Forms.StatusBarPanel
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.chk_cajera = New System.Windows.Forms.CheckBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.chk_Anular = New System.Windows.Forms.CheckBox
        Me.Chk_Costos = New System.Windows.Forms.CheckBox
        Me.Chk_descto = New System.Windows.Forms.CheckBox
        Me.Chk_Tools = New System.Windows.Forms.CheckBox
        Me.CheckBox9 = New System.Windows.Forms.CheckBox
        Me.chk_BceVencido = New System.Windows.Forms.CheckBox
        Me.Chk_VtaSusp = New System.Windows.Forms.CheckBox
        Me.Splitter2 = New System.Windows.Forms.Splitter
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = New System.Drawing.Point(0, 419)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel1, Me.StatusBarPanel2})
        Me.StatusBar1.ShowPanels = True
        Me.StatusBar1.Size = New System.Drawing.Size(952, 22)
        Me.StatusBar1.TabIndex = 0
        Me.StatusBar1.Text = "StatusBar1"
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.Text = "StatusBarPanel1"
        Me.StatusBarPanel1.Width = 300
        '
        'StatusBarPanel2
        '
        Me.StatusBarPanel2.Text = "StatusBarPanel2"
        '
        'ToolBar1
        '
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.btnUser, Me.btnProgramas, Me.ToolBarButton3, Me.btnOk, Me.btnCancel, Me.ToolBarButton6, Me.btnRefresh, Me.ToolBarButton8, Me.btnExpand, Me.btnCollapse})
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
        Me.tvw_System.ShowRootLines = False
        Me.tvw_System.Size = New System.Drawing.Size(749, 289)
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chk_cajera)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.chk_Anular)
        Me.GroupBox1.Controls.Add(Me.Chk_Costos)
        Me.GroupBox1.Controls.Add(Me.Chk_descto)
        Me.GroupBox1.Controls.Add(Me.Chk_Tools)
        Me.GroupBox1.Controls.Add(Me.CheckBox9)
        Me.GroupBox1.Controls.Add(Me.chk_BceVencido)
        Me.GroupBox1.Controls.Add(Me.Chk_VtaSusp)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(203, 331)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(749, 88)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Autorizar"
        '
        'chk_cajera
        '
        Me.chk_cajera.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chk_cajera.Location = New System.Drawing.Point(8, 48)
        Me.chk_cajera.Name = "chk_cajera"
        Me.chk_cajera.Size = New System.Drawing.Size(104, 16)
        Me.chk_cajera.TabIndex = 2
        Me.chk_cajera.Tag = "CSTS"
        Me.chk_cajera.Text = "Ser Cajera"
        '
        'CheckBox1
        '
        Me.CheckBox1.Enabled = False
        Me.CheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox1.Location = New System.Drawing.Point(480, 48)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(136, 16)
        Me.CheckBox1.TabIndex = 1
        Me.CheckBox1.Text = "Autorizar Facturas"
        '
        'chk_Anular
        '
        Me.chk_Anular.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chk_Anular.Location = New System.Drawing.Point(8, 24)
        Me.chk_Anular.Name = "chk_Anular"
        Me.chk_Anular.Size = New System.Drawing.Size(120, 16)
        Me.chk_Anular.TabIndex = 0
        Me.chk_Anular.Tag = "ANL"
        Me.chk_Anular.Text = "Anular Documentos"
        '
        'Chk_Costos
        '
        Me.Chk_Costos.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Chk_Costos.Location = New System.Drawing.Point(624, 24)
        Me.Chk_Costos.Name = "Chk_Costos"
        Me.Chk_Costos.Size = New System.Drawing.Size(104, 16)
        Me.Chk_Costos.TabIndex = 0
        Me.Chk_Costos.Tag = "CSTS"
        Me.Chk_Costos.Text = "Ver Costos"
        '
        'Chk_descto
        '
        Me.Chk_descto.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Chk_descto.Location = New System.Drawing.Point(160, 24)
        Me.Chk_descto.Name = "Chk_descto"
        Me.Chk_descto.Size = New System.Drawing.Size(112, 16)
        Me.Chk_descto.TabIndex = 0
        Me.Chk_descto.Tag = "DSCTO"
        Me.Chk_descto.Text = "Aplicar Descuentos"
        '
        'Chk_Tools
        '
        Me.Chk_Tools.Enabled = False
        Me.Chk_Tools.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Chk_Tools.Location = New System.Drawing.Point(160, 48)
        Me.Chk_Tools.Name = "Chk_Tools"
        Me.Chk_Tools.Size = New System.Drawing.Size(136, 16)
        Me.Chk_Tools.TabIndex = 0
        Me.Chk_Tools.Text = "Acceder a Herramientas"
        '
        'CheckBox9
        '
        Me.CheckBox9.Enabled = False
        Me.CheckBox9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox9.Location = New System.Drawing.Point(320, 48)
        Me.CheckBox9.Name = "CheckBox9"
        Me.CheckBox9.Size = New System.Drawing.Size(136, 16)
        Me.CheckBox9.TabIndex = 0
        Me.CheckBox9.Text = "Vender a Precio Mínimo"
        '
        'chk_BceVencido
        '
        Me.chk_BceVencido.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chk_BceVencido.Location = New System.Drawing.Point(320, 24)
        Me.chk_BceVencido.Name = "chk_BceVencido"
        Me.chk_BceVencido.Size = New System.Drawing.Size(136, 16)
        Me.chk_BceVencido.TabIndex = 0
        Me.chk_BceVencido.Tag = "VNCD"
        Me.chk_BceVencido.Text = "Vender Factura Vencida"
        '
        'Chk_VtaSusp
        '
        Me.Chk_VtaSusp.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Chk_VtaSusp.Location = New System.Drawing.Point(480, 24)
        Me.Chk_VtaSusp.Name = "Chk_VtaSusp"
        Me.Chk_VtaSusp.Size = New System.Drawing.Size(120, 16)
        Me.Chk_VtaSusp.TabIndex = 0
        Me.Chk_VtaSusp.Tag = "SUSP"
        Me.Chk_VtaSusp.Text = "Venta Suspendida"
        '
        'Splitter2
        '
        Me.Splitter2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Splitter2.Location = New System.Drawing.Point(203, 328)
        Me.Splitter2.Name = "Splitter2"
        Me.Splitter2.Size = New System.Drawing.Size(749, 3)
        Me.Splitter2.TabIndex = 7
        Me.Splitter2.TabStop = False
        '
        'i_access2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(952, 441)
        Me.Controls.Add(Me.Splitter2)
        Me.Controls.Add(Me.tvw_System)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.tvw_Users)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.StatusBar1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Menu = Me.MainMenu1
        Me.Name = "i_access2"
        Me.Text = "SGT Security Console"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oTable, otable1 As DataTable
        Dim SelectStmt As String
        Dim ValidUser As String
        Try
            If LibX.Data.Manager.Login = False Then
                Throw New ApplicationException("No tiene permiso para ejecutar este programa!")
            End If

            ValidUser = Configuration.ConfigurationSettings.AppSettings.Get("LibxAllowUser")

            If LibX.User.UserID.Trim.ToLower <> ValidUser.Trim.ToLower Then
                Throw New ApplicationException("No tiene permiso para ejecutar este programa!")
            End If

            '// Usuarios
            SelectStmt = "select vend_name,userid from scusers " & _
                         " inner join ftvendm on ftvendm.vend_code = scusers.vend_code"

            oTable = LibX.Data.Manager.GetDataTable(SelectStmt)
            tvw_Users.Nodes(0).Nodes.Clear()

            For Each oRow As DataRow In oTable.Rows
                Dim lvw_Node As TreeNode = tvw_Users.Nodes(0).Nodes.Add(oRow!vend_name)
                lvw_Node.Tag = oRow!userid.ToString.Trim
                lvw_Node.ImageIndex = 1
                lvw_Node.SelectedImageIndex = 1
            Next

            tvw_Users.Nodes(0).Expand()


        Catch ex As Exception
            LibX.Log.UseConnection = False
            LibX.Log.Show(ex)
            Application.Exit()
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
                For Each oNode As TreeNode In tvw_Users.Nodes(0).Nodes
                    If oNode.Checked = True Then
                        LoadOpciones(oNode.Tag)
                        Exit Sub
                    End If
                Next
            End If

            If e.Button Is btnProgramas Then
                LibX.LibXRunner.Run("i_stprogrm01", "ADM")
            End If

            If e.Button Is btnUser Then
                LibX.LibXRunner.Run("i_users", "ADM")
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LoadOpciones(ByVal pUserID As String)
        Dim oTable, otable1 As DataTable
        Dim SelectStmt As String

        Try
            '// Opciones
            SelectStmt = "select descr,menu_code from stmenue "

            oTable = LibX.Data.Manager.GetDataTable(SelectStmt)
            tvw_System.Nodes(0).Nodes.Clear()
            Me.Chk_VtaSusp.Checked = False
            Me.chk_Anular.Checked = False
            Me.chk_BceVencido.Checked = False
            Me.Chk_Costos.Checked = False
            Me.Chk_descto.Checked = False
            Me.Chk_Tools.Checked = False
            Me.Chk_VtaSusp.Checked = False

            tvw_System.Nodes(0).ImageIndex = 2
            tvw_System.Nodes(0).SelectedImageIndex = 2

            For Each oRow As DataRow In oTable.Rows
                Dim lvw_Node As TreeNode = tvw_System.Nodes(0).Nodes.Add(oRow!descr.ToString.Trim)
                lvw_Node.ImageIndex = 3
                lvw_Node.SelectedImageIndex = 3

                SelectStmt = "select distinct descr,program,id from stmenud,scpermsm " & _
                             " where menu_code = " & oRow!menu_code.ToString & _
                             "   and stmenud.program *= scpermsm.progname " & _
                             "   and scpermsm.userid = '" & pUserID & "'"

                otable1 = LibX.Data.Manager.GetDataTable(SelectStmt)

                For Each oRow1 As DataRow In otable1.Rows
                    Dim lvw_Node1 As TreeNode = lvw_Node.Nodes.Add(oRow1!descr.ToString.Trim)
                    lvw_Node1.Tag = oRow1!program.ToString.Trim

                    If oRow1!id.ToString.Trim <> "0" And oRow1!id.ToString.Trim <> "" Then
                        lvw_Node1.Checked = True
                        lvw_Node1.Parent.Checked = True
                    Else
                        lvw_Node1.Checked = False
                    End If

                    lvw_Node1.ImageIndex = 4
                    lvw_Node1.SelectedImageIndex = 4
                Next
            Next

            SelectStmt = "select ftvendm.* from ftvendm, scusers " & _
                         " where ftvendm.vend_code = scusers.vend_code " & _
                         "   and scusers.userid = " & pUserID.ToString

            oTable = LibX.Data.Manager.GetDataTable(SelectStmt)

            If Not oTable Is Nothing Then
                If oTable.Rows.Count > 0 Then
                    '// Descuentos
                    If oTable.Rows(0)!vend_inddescto.ToString = "1" Then
                        Me.Chk_descto.Checked = True
                    End If

                    '// Ver Costos
                    If oTable.Rows(0)!vend_indcostos.ToString = "1" Then
                        Me.Chk_Costos.Checked = True
                    End If

                    '// Anular Documento
                    If oTable.Rows(0)!vend_indanular.ToString = "1" Then
                        Me.chk_Anular.Checked = True
                    End If

                    '// Vender con Documentos Vencidos
                    If oTable.Rows(0)!vend_vencido.ToString = "1" Then
                        Me.chk_BceVencido.Checked = True
                    End If

                    '// Vender con Documentos Vencidos
                    If oTable.Rows(0)!vend_indvender.ToString = "1" Then
                        Me.Chk_VtaSusp.Checked = True
                    End If
                End If
            End If


            tvw_System.Nodes(0).ExpandAll()

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
            XInsert = New LibX.Data.XInsertStmt("scPermsm")
            xDelete = New LibX.Data.XDeleteStmt("scPermsm")
            xUpdate = New LibX.Data.XUpdateStmt("ftvendm")

            xDelete.Parameters.Add("userid", "")
            XInsert!userid = ""
            XInsert!progname = ""
            XInsert!id = 0

            '// Descuentos
            If Me.Chk_descto.Checked = True Then
                xUpdate.FieldsSet("vend_inddescto") = 1
            Else
                xUpdate.FieldsSet("vend_inddescto") = 0
            End If

            '// Ver Costos
            If Me.Chk_Costos.Checked = True Then
                xUpdate.FieldsSet("vend_indcostos") = 1
            Else
                xUpdate.FieldsSet("vend_indcostos") = 0

            End If

            '// Anular Documento
            If Me.chk_Anular.Checked = True Then
                xUpdate.FieldsSet("vend_indanular") = 1
            Else
                xUpdate.FieldsSet("vend_indanular") = 0

            End If

            '// Vender con Documentos Vencidos
            If Me.chk_BceVencido.Checked = True Then
                xUpdate.FieldsSet("vend_vencido") = 1
            Else
                xUpdate.FieldsSet("vend_vencido") = 0

            End If

            '// Vender con Documentos Vencidos
            If Me.Chk_VtaSusp.Checked = True Then
                xUpdate.FieldsSet("vend_indvender") = 1
            Else
                xUpdate.FieldsSet("vend_indvender") = 0
            End If

            '// Vender con Documentos Vencidos
            If Me.chk_cajera.Checked = True Then
                xUpdate.FieldsSet("vend_indcajera") = 1
            Else
                xUpdate.FieldsSet("vend_indcajera") = 0
            End If

            '// Recorrer los usuarios seleccionados
            For Each oUserNode As TreeNode In tvw_Users.Nodes(0).Nodes

                '// Si este usuario fue seleccionado
                '// aplicar los accesos
                If oUserNode.Checked = True Then
                    oUserNode.Checked = False

                    '// Borrar todo el acceso de este usuario
                    xDelete.Fields("userid").value = oUserNode.Tag.ToString
                    xDelete.Execute()

                    '// Buscar su codigo de vendedor y aplicar sus nuevos permisos
                    oRow = LibX.Data.Manager.GetDataRow("Select vend_code from scusers where userid = " & oUserNode.Tag.ToString)
                    If Not oRow Is Nothing Then
                        xUpdate.Fields("vend_code") = oRow!vend_code
                        xUpdate.Execute()
                    End If

                    '// Insertar las opciones seleccionadas
                    For Each oProgramNode As TreeNode In tvw_System.Nodes(0).Nodes

                        '// Si esta opcion esta seleccionada
                        If oProgramNode.Checked = True Then
                            If oProgramNode.GetNodeCount(False) > 0 Then
                                For Each oNode As TreeNode In oProgramNode.Nodes
                                    If oNode.Checked = True Then
                                        XInsert.Fields("progname").value = oNode.Tag.ToString
                                        XInsert.Fields("userid").value = oUserNode.Tag.ToString
                                        XInsert.Fields("id").value = 1
                                        XInsert.Execute()
                                    End If
                                Next
                            Else
                                XInsert.Fields("progname").value = oProgramNode.Tag.ToString
                                XInsert.Fields("userid").value = oUserNode.Tag.ToString
                                XInsert.Fields("id").value = 1
                                XInsert.Execute()
                            End If
                        Else
                            If oProgramNode.GetNodeCount(False) > 0 Then
                                For Each oNode As TreeNode In oProgramNode.Nodes
                                    If oNode.Checked = True Then
                                        XInsert.Fields("progname").value = oNode.Tag.ToString
                                        XInsert.Fields("userid").value = oUserNode.Tag.ToString
                                        XInsert.Fields("id").value = 1
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
            e.Node.Expand()

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

            LoadOpciones(e.Node.Tag)
        Else
            e.Node.Checked = False
        End If
    End Sub

    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem10.Click
        Application.Exit()
    End Sub
End Class
