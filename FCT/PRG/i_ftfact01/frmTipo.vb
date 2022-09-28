Imports SGT.Inventario.Entidades.Documento
Public Class frmTipo
    Inherits System.Windows.Forms.Form
    Dim isValid As Boolean = False
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
    Friend WithEvents ButtonFinish As System.Windows.Forms.Button
    Friend WithEvents ButtonNext As System.Windows.Forms.Button
    Friend WithEvents labelmessage As System.Windows.Forms.Label
    Friend WithEvents rbt_ConValorFISCAL As System.Windows.Forms.RadioButton
    Friend WithEvents rbt_SinValorFISCAL As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.rbt_ConValorFISCAL = New System.Windows.Forms.RadioButton
        Me.rbt_SinValorFISCAL = New System.Windows.Forms.RadioButton
        Me.ButtonFinish = New System.Windows.Forms.Button
        Me.ButtonNext = New System.Windows.Forms.Button
        Me.labelmessage = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'rbt_ConValorFISCAL
        '
        Me.rbt_ConValorFISCAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbt_ConValorFISCAL.Location = New System.Drawing.Point(24, 24)
        Me.rbt_ConValorFISCAL.Name = "rbt_ConValorFISCAL"
        Me.rbt_ConValorFISCAL.Size = New System.Drawing.Size(112, 24)
        Me.rbt_ConValorFISCAL.TabIndex = 0
        Me.rbt_ConValorFISCAL.Text = "Empresa"
        '
        'rbt_SinValorFISCAL
        '
        Me.rbt_SinValorFISCAL.Checked = True
        Me.rbt_SinValorFISCAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbt_SinValorFISCAL.Location = New System.Drawing.Point(152, 24)
        Me.rbt_SinValorFISCAL.Name = "rbt_SinValorFISCAL"
        Me.rbt_SinValorFISCAL.Size = New System.Drawing.Size(112, 24)
        Me.rbt_SinValorFISCAL.TabIndex = 1
        Me.rbt_SinValorFISCAL.TabStop = True
        Me.rbt_SinValorFISCAL.Text = "Personal"
        '
        'ButtonFinish
        '
        Me.ButtonFinish.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonFinish.Location = New System.Drawing.Point(136, 72)
        Me.ButtonFinish.Name = "ButtonFinish"
        Me.ButtonFinish.TabIndex = 2
        Me.ButtonFinish.Text = "Cancelar"
        '
        'ButtonNext
        '
        Me.ButtonNext.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonNext.Location = New System.Drawing.Point(56, 72)
        Me.ButtonNext.Name = "ButtonNext"
        Me.ButtonNext.TabIndex = 2
        Me.ButtonNext.Text = "Continuar"
        '
        'labelmessage
        '
        Me.labelmessage.ForeColor = System.Drawing.Color.Red
        Me.labelmessage.Location = New System.Drawing.Point(0, 96)
        Me.labelmessage.Name = "labelmessage"
        Me.labelmessage.Size = New System.Drawing.Size(280, 23)
        Me.labelmessage.TabIndex = 3
        Me.labelmessage.Visible = False
        '
        'frmTipo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(282, 120)
        Me.Controls.Add(Me.labelmessage)
        Me.Controls.Add(Me.ButtonFinish)
        Me.Controls.Add(Me.rbt_SinValorFISCAL)
        Me.Controls.Add(Me.rbt_ConValorFISCAL)
        Me.Controls.Add(Me.ButtonNext)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "frmTipo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Tipo de Numeración Fiscal (NCF)"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim _TipoNCF As TipoNCFEnum

    Public Property TipoNCF() As TipoNCFEnum
        Get
            Return _TipoNCF
        End Get
        Set(ByVal Value As TipoNCFEnum)
            _TipoNCF = Value
        End Set
    End Property

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbt_ConValorFISCAL.CheckedChanged
        _TipoNCF = TipoNCFEnum.ConValorFiscal
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbt_SinValorFISCAL.CheckedChanged
        _TipoNCF = TipoNCFEnum.SinValorFiscal
    End Sub

    Private Sub ButtonNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonNext.Click
        If (Me.rbt_SinValorFISCAL.Checked = True Or Me.rbt_ConValorFISCAL.Checked = True) Or isValid = True Then
            If Me.rbt_SinValorFISCAL.Checked = True Then
                _TipoNCF = TipoNCFEnum.SinValorFiscal
            End If

            If Me.rbt_ConValorFISCAL.Checked = True Then
                _TipoNCF = TipoNCFEnum.ConValorFiscal
            End If

            Me.DialogResult = DialogResult.OK
            Me.Close()
        Else
            Me.labelmessage.Text = "SELECCIONE EL TIPO DE DEVOLUCION"
            Me.labelmessage.Visible = True
        End If
    End Sub

    Private Sub ButtonFinish_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonFinish.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()

    End Sub

    Private Sub frmTipo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _TipoNCF = TipoNCFEnum.SinValorFiscal
        isValid = False
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        _TipoNCF = TipoNCFEnum.None
        Me.rbt_SinValorFISCAL.Checked = False
        Me.rbt_ConValorFISCAL.Checked = False

    End Sub

    Private Sub frmTipo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            '// Pasar
            If e.KeyCode = Keys.F12 Then
                Me.rbt_SinValorFISCAL.Checked = False
                Me.rbt_ConValorFISCAL.Checked = False
                isValid = True
                _TipoNCF = TipoNCFEnum.None
                ButtonNext_Click(sender, New EventArgs)
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
End Class
