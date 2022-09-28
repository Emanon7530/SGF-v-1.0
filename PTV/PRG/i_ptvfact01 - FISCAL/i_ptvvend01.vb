Public Class i_ptvvend01
    Inherits System.Windows.Forms.Form
    Public mVendedor As SGT.Caja.Entidades.Cajera

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
    Friend WithEvents btnAccept As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents xtxtVend_code As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(i_ptvvend01))
        Me.btnAccept = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.xtxtVend_code = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider
        Me.SuspendLayout()
        '
        'btnAccept
        '
        Me.btnAccept.Location = New System.Drawing.Point(128, 80)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.TabIndex = 0
        Me.btnAccept.Text = "Aceptar"
        '
        'btnCancel
        '
        Me.btnCancel.CausesValidation = False
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(208, 80)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancelar"
        '
        'xtxtVend_code
        '
        Me.xtxtVend_code.Location = New System.Drawing.Point(96, 40)
        Me.xtxtVend_code.Name = "xtxtVend_code"
        Me.xtxtVend_code.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.xtxtVend_code.Size = New System.Drawing.Size(184, 20)
        Me.xtxtVend_code.TabIndex = 0
        Me.xtxtVend_code.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(96, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Código del Vendedor"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(88, 104)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'i_ptvvend01
        '
        Me.AcceptButton = Me.btnAccept
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(292, 112)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.xtxtVend_code)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAccept)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "i_ptvvend01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Identificación del Vendedor"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub i_ptvvend01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Function ValidaVendedor() As Boolean
        Dim SelectStmt As String
        Dim oRow As DataRow
        Try
            mVendedor.Code = Val(Me.xtxtVend_code.Text.Trim)

            If mVendedor.Load() = False Then
                Return False
            End If

            If mVendedor.Cargo = SGT.Caja.Entidades.TipoUsuarioEnum.Mensajero Then
                Return False
            End If

            Return True
        Catch ex As Exception
            Throw

        End Try
    End Function

    Public Overloads Function ShowDialog(ByVal oVendedor) As DialogResult
        mVendedor = oVendedor
        Return MyBase.ShowDialog
    End Function

    Private Sub btnAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccept.Click
        Try
            If ValidaVendedor() = False Then
                Me.ErrorProvider1.SetError(Me.xtxtVend_code, "Código del Vendedor Inválido!")
                Me.xtxtVend_code.Focus()
                Exit Sub
            End If

            Me.DialogResult = DialogResult.Yes
            Me.Close()
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub i_ptvvend01_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            If e.KeyCode = Keys.F5 Then
                btnAccept_Click(sender, e)
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub xtxtVend_code_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles xtxtVend_code.Validating
        If Me.xtxtVend_code.Text.Length <= 0 Then
            e.Cancel = False
            Me.ErrorProvider1.SetError(Me.xtxtVend_code, "Introduzca el código del vendedor")
        End If
    End Sub
End Class
