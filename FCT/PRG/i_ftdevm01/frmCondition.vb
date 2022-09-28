Public Class frmCondition
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
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents ButtonFinish As System.Windows.Forms.Button
    Friend WithEvents ButtonNext As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.ButtonFinish = New System.Windows.Forms.Button
        Me.ButtonNext = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'RadioButton1
        '
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(24, 16)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(104, 16)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.Text = "Efectivo"
        '
        'RadioButton2
        '
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(144, 16)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(120, 16)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "Nota Crédito"
        '
        'ButtonFinish
        '
        Me.ButtonFinish.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonFinish.Location = New System.Drawing.Point(136, 64)
        Me.ButtonFinish.Name = "ButtonFinish"
        Me.ButtonFinish.TabIndex = 2
        Me.ButtonFinish.Text = "Cancelar"
        '
        'ButtonNext
        '
        Me.ButtonNext.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonNext.Location = New System.Drawing.Point(56, 64)
        Me.ButtonNext.Name = "ButtonNext"
        Me.ButtonNext.TabIndex = 2
        Me.ButtonNext.Text = "Continuar"
        '
        'frmCondition
        '
        Me.AcceptButton = Me.ButtonNext
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.ButtonFinish
        Me.ClientSize = New System.Drawing.Size(282, 112)
        Me.Controls.Add(Me.ButtonFinish)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.ButtonNext)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmCondition"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Forma de Pago"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Enum CondicionPagoEnum
        Efectivo
        NotaCredito
        CompraCredito
    End Enum

    Dim _CondicionPago As CondicionPagoEnum

    Public Property CondicionPago() As CondicionPagoEnum
        Get
            Return _CondicionPago
        End Get
        Set(ByVal Value As CondicionPagoEnum)
            _CondicionPago = Value
        End Set
    End Property

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        _CondicionPago = CondicionPagoEnum.Efectivo
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        _CondicionPago = CondicionPagoEnum.NotaCredito
    End Sub

    Private Sub ButtonNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonNext.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub ButtonFinish_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonFinish.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmCondition_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
