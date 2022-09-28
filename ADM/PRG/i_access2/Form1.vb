Public Class Form1
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
    Friend WithEvents Splitter2 As System.Windows.Forms.Splitter
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox6 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox7 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox8 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox9 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox10 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox11 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox12 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox13 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox14 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox15 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox16 As System.Windows.Forms.CheckBox
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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.StatusBar1 = New System.Windows.Forms.StatusBar
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
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.tvw_Users = New System.Windows.Forms.TreeView
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.tvw_System = New System.Windows.Forms.TreeView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.CheckBox3 = New System.Windows.Forms.CheckBox
        Me.CheckBox4 = New System.Windows.Forms.CheckBox
        Me.CheckBox5 = New System.Windows.Forms.CheckBox
        Me.CheckBox6 = New System.Windows.Forms.CheckBox
        Me.CheckBox7 = New System.Windows.Forms.CheckBox
        Me.CheckBox8 = New System.Windows.Forms.CheckBox
        Me.CheckBox9 = New System.Windows.Forms.CheckBox
        Me.CheckBox10 = New System.Windows.Forms.CheckBox
        Me.CheckBox11 = New System.Windows.Forms.CheckBox
        Me.CheckBox12 = New System.Windows.Forms.CheckBox
        Me.CheckBox13 = New System.Windows.Forms.CheckBox
        Me.CheckBox14 = New System.Windows.Forms.CheckBox
        Me.CheckBox15 = New System.Windows.Forms.CheckBox
        Me.CheckBox16 = New System.Windows.Forms.CheckBox
        Me.Splitter2 = New System.Windows.Forms.Splitter
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = New System.Drawing.Point(0, 416)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Size = New System.Drawing.Size(728, 22)
        Me.StatusBar1.TabIndex = 0
        Me.StatusBar1.Text = "StatusBar1"
        '
        'ToolBar1
        '
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.btnUser, Me.btnProgramas, Me.ToolBarButton3, Me.btnOk, Me.btnCancel, Me.ToolBarButton6, Me.btnRefresh, Me.ToolBarButton8, Me.btnExpand, Me.btnCollapse})
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImageList1
        Me.ToolBar1.Location = New System.Drawing.Point(0, 0)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(728, 42)
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
        Me.MenuItem1.Text = "Archivo"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Text = "Editar"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.Text = "Ver"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 3
        Me.MenuItem4.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem6, Me.MenuItem7})
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
        'MenuItem5
        '
        Me.MenuItem5.Index = 4
        Me.MenuItem5.Text = "Ayuda"
        '
        'tvw_Users
        '
        Me.tvw_Users.Dock = System.Windows.Forms.DockStyle.Left
        Me.tvw_Users.ImageList = Me.ImageList1
        Me.tvw_Users.Location = New System.Drawing.Point(0, 42)
        Me.tvw_Users.Name = "tvw_Users"
        Me.tvw_Users.Nodes.AddRange(New System.Windows.Forms.TreeNode() {New System.Windows.Forms.TreeNode("Usuarios")})
        Me.tvw_Users.ShowRootLines = False
        Me.tvw_Users.Size = New System.Drawing.Size(200, 374)
        Me.tvw_Users.TabIndex = 2
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(200, 42)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 374)
        Me.Splitter1.TabIndex = 3
        Me.Splitter1.TabStop = False
        '
        'tvw_System
        '
        Me.tvw_System.CheckBoxes = True
        Me.tvw_System.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvw_System.ImageList = Me.ImageList1
        Me.tvw_System.Location = New System.Drawing.Point(203, 42)
        Me.tvw_System.Name = "tvw_System"
        Me.tvw_System.Nodes.AddRange(New System.Windows.Forms.TreeNode() {New System.Windows.Forms.TreeNode("Sistemas")})
        Me.tvw_System.ShowRootLines = False
        Me.tvw_System.Size = New System.Drawing.Size(525, 374)
        Me.tvw_System.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.CheckBox3)
        Me.GroupBox1.Controls.Add(Me.CheckBox4)
        Me.GroupBox1.Controls.Add(Me.CheckBox5)
        Me.GroupBox1.Controls.Add(Me.CheckBox6)
        Me.GroupBox1.Controls.Add(Me.CheckBox7)
        Me.GroupBox1.Controls.Add(Me.CheckBox8)
        Me.GroupBox1.Controls.Add(Me.CheckBox9)
        Me.GroupBox1.Controls.Add(Me.CheckBox10)
        Me.GroupBox1.Controls.Add(Me.CheckBox11)
        Me.GroupBox1.Controls.Add(Me.CheckBox12)
        Me.GroupBox1.Controls.Add(Me.CheckBox13)
        Me.GroupBox1.Controls.Add(Me.CheckBox14)
        Me.GroupBox1.Controls.Add(Me.CheckBox15)
        Me.GroupBox1.Controls.Add(Me.CheckBox16)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Location = New System.Drawing.Point(203, 296)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(525, 120)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Permisos"
        '
        'CheckBox1
        '
        Me.CheckBox1.Location = New System.Drawing.Point(8, 24)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(104, 16)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "CheckBox1"
        '
        'CheckBox2
        '
        Me.CheckBox2.Location = New System.Drawing.Point(8, 48)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(104, 16)
        Me.CheckBox2.TabIndex = 0
        Me.CheckBox2.Text = "CheckBox1"
        '
        'CheckBox3
        '
        Me.CheckBox3.Location = New System.Drawing.Point(8, 72)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(104, 16)
        Me.CheckBox3.TabIndex = 0
        Me.CheckBox3.Text = "CheckBox1"
        '
        'CheckBox4
        '
        Me.CheckBox4.Location = New System.Drawing.Point(8, 96)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(104, 16)
        Me.CheckBox4.TabIndex = 0
        Me.CheckBox4.Text = "CheckBox1"
        '
        'CheckBox5
        '
        Me.CheckBox5.Location = New System.Drawing.Point(128, 96)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(104, 16)
        Me.CheckBox5.TabIndex = 0
        Me.CheckBox5.Text = "CheckBox1"
        '
        'CheckBox6
        '
        Me.CheckBox6.Location = New System.Drawing.Point(128, 24)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(104, 16)
        Me.CheckBox6.TabIndex = 0
        Me.CheckBox6.Text = "CheckBox1"
        '
        'CheckBox7
        '
        Me.CheckBox7.Location = New System.Drawing.Point(128, 48)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(104, 16)
        Me.CheckBox7.TabIndex = 0
        Me.CheckBox7.Text = "CheckBox1"
        '
        'CheckBox8
        '
        Me.CheckBox8.Location = New System.Drawing.Point(128, 72)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(104, 16)
        Me.CheckBox8.TabIndex = 0
        Me.CheckBox8.Text = "CheckBox1"
        '
        'CheckBox9
        '
        Me.CheckBox9.Location = New System.Drawing.Point(248, 48)
        Me.CheckBox9.Name = "CheckBox9"
        Me.CheckBox9.Size = New System.Drawing.Size(104, 16)
        Me.CheckBox9.TabIndex = 0
        Me.CheckBox9.Text = "CheckBox1"
        '
        'CheckBox10
        '
        Me.CheckBox10.Location = New System.Drawing.Point(248, 24)
        Me.CheckBox10.Name = "CheckBox10"
        Me.CheckBox10.Size = New System.Drawing.Size(104, 16)
        Me.CheckBox10.TabIndex = 0
        Me.CheckBox10.Text = "CheckBox1"
        '
        'CheckBox11
        '
        Me.CheckBox11.Location = New System.Drawing.Point(248, 96)
        Me.CheckBox11.Name = "CheckBox11"
        Me.CheckBox11.Size = New System.Drawing.Size(104, 16)
        Me.CheckBox11.TabIndex = 0
        Me.CheckBox11.Text = "CheckBox1"
        '
        'CheckBox12
        '
        Me.CheckBox12.Location = New System.Drawing.Point(248, 72)
        Me.CheckBox12.Name = "CheckBox12"
        Me.CheckBox12.Size = New System.Drawing.Size(104, 16)
        Me.CheckBox12.TabIndex = 0
        Me.CheckBox12.Text = "CheckBox1"
        '
        'CheckBox13
        '
        Me.CheckBox13.Location = New System.Drawing.Point(368, 48)
        Me.CheckBox13.Name = "CheckBox13"
        Me.CheckBox13.Size = New System.Drawing.Size(104, 16)
        Me.CheckBox13.TabIndex = 0
        Me.CheckBox13.Text = "CheckBox1"
        '
        'CheckBox14
        '
        Me.CheckBox14.Location = New System.Drawing.Point(368, 72)
        Me.CheckBox14.Name = "CheckBox14"
        Me.CheckBox14.Size = New System.Drawing.Size(104, 16)
        Me.CheckBox14.TabIndex = 0
        Me.CheckBox14.Text = "CheckBox1"
        '
        'CheckBox15
        '
        Me.CheckBox15.Location = New System.Drawing.Point(368, 96)
        Me.CheckBox15.Name = "CheckBox15"
        Me.CheckBox15.Size = New System.Drawing.Size(104, 16)
        Me.CheckBox15.TabIndex = 0
        Me.CheckBox15.Text = "CheckBox1"
        '
        'CheckBox16
        '
        Me.CheckBox16.Location = New System.Drawing.Point(368, 24)
        Me.CheckBox16.Name = "CheckBox16"
        Me.CheckBox16.Size = New System.Drawing.Size(104, 16)
        Me.CheckBox16.TabIndex = 0
        Me.CheckBox16.Text = "CheckBox1"
        '
        'Splitter2
        '
        Me.Splitter2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Splitter2.Location = New System.Drawing.Point(203, 293)
        Me.Splitter2.Name = "Splitter2"
        Me.Splitter2.Size = New System.Drawing.Size(525, 3)
        Me.Splitter2.TabIndex = 6
        Me.Splitter2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(728, 438)
        Me.Controls.Add(Me.Splitter2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tvw_System)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.tvw_Users)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.StatusBar1)
        Me.Menu = Me.MainMenu1
        Me.Name = "Form1"
        Me.Text = "Asignar Accesos y Permisos"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oTable, otable1 As DataTable
        Dim SelectStmt As String
        Try
            LibX.Data.Manager.OpenConnection()

            '// Usuarios
            SelectStmt = "select vend_name from scusers " & _
                         " inner join ftvendm on ftvendm.vend_code = scusers.vend_code"

            oTable = LibX.Data.Manager.GetDataTable(SelectStmt)

            For Each oRow As DataRow In oTable.Rows
                Dim lvw_Node As TreeNode = tvw_Users.Nodes(0).Nodes.Add(oRow!vend_name)
                lvw_Node.ImageIndex = 1
                lvw_node.SelectedImageIndex = 1
            Next

            '// Opciones
            SelectStmt = "select descr,menu_code from stmenue "

            oTable = LibX.Data.Manager.GetDataTable(SelectStmt)
            tvw_System.Nodes(0).ImageIndex = 2
            tvw_System.Nodes(0).SelectedImageIndex = 2
            tvw_System.Nodes(0).ExpandAll()

            For Each oRow As DataRow In oTable.Rows
                Dim lvw_Node As TreeNode = tvw_System.Nodes(0).Nodes.Add(oRow!descr.tostring.Trim)
                lvw_node.ImageIndex = 3
                lvw_node.SelectedImageIndex = 3

                SelectStmt = "select descr,program from stmenud " & _
                             " where menu_code = " & orow!menu_code.tostring

                otable1 = LibX.Data.Manager.GetDataTable(SelectStmt)
                lvw_node.ExpandAll()

                For Each oRow1 As DataRow In otable1.Rows
                    Dim lvw_Node1 As TreeNode = lvw_node.Nodes.Add(oRow1!descr.ToString.Trim)
                    lvw_Node1.Tag = oRow1!program.ToString.Trim

                    lvw_Node1.ImageIndex = 4
                    lvw_Node1.SelectedImageIndex = 4
                Next
            Next


        Catch ex As Exception
            LibX.Log.Show(ex)
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
            End If

            If e.Button Is btnCancel Then
                btnOk.Enabled = False
                btnCancel.Enabled = False

            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub SaveAccesos()
        Dim XInsert As LibX.Data.XInsertStmt

        Try
            XInsert = New LibX.Data.XInsertStmt("scaccess")

            For Each oNode As TreeNode In tvw_System.Nodes

            Next

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub tvw_System_AfterCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvw_System.AfterCheck
        Try
            btnOk.Enabled = True
            btnCancel.Enabled = True

            If e.Node.GetNodeCount(False) > 0 Then
                For Each oNode As TreeNode In e.Node.Nodes
                    oNode.Checked = e.Node.Checked
                Next
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
End Class
