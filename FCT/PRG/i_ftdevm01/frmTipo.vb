Public Class frmTipo
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
    Friend WithEvents ButtonFinish As System.Windows.Forms.Button
    Friend WithEvents ButtonNext As System.Windows.Forms.Button
    Friend WithEvents rbt_RMA As System.Windows.Forms.RadioButton
    Friend WithEvents rbt_CAM As System.Windows.Forms.RadioButton
    Friend WithEvents labelmessage As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.rbt_RMA = New System.Windows.Forms.RadioButton
        Me.rbt_CAM = New System.Windows.Forms.RadioButton
        Me.ButtonFinish = New System.Windows.Forms.Button
        Me.ButtonNext = New System.Windows.Forms.Button
        Me.labelmessage = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'rbt_RMA
        '
        Me.rbt_RMA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbt_RMA.Location = New System.Drawing.Point(24, 24)
        Me.rbt_RMA.Name = "rbt_RMA"
        Me.rbt_RMA.Size = New System.Drawing.Size(112, 24)
        Me.rbt_RMA.TabIndex = 0
        Me.rbt_RMA.Text = "Por R. M. A."
        '
        'rbt_CAM
        '
        Me.rbt_CAM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbt_CAM.Location = New System.Drawing.Point(152, 24)
        Me.rbt_CAM.Name = "rbt_CAM"
        Me.rbt_CAM.Size = New System.Drawing.Size(112, 24)
        Me.rbt_CAM.TabIndex = 1
        Me.rbt_CAM.Text = "por Cambio"
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
        Me.AcceptButton = Me.ButtonNext
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.ButtonFinish
        Me.ClientSize = New System.Drawing.Size(282, 120)
        Me.Controls.Add(Me.labelmessage)
        Me.Controls.Add(Me.ButtonFinish)
        Me.Controls.Add(Me.rbt_CAM)
        Me.Controls.Add(Me.rbt_RMA)
        Me.Controls.Add(Me.ButtonNext)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmTipo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Tipo de Devolución"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Enum TipoDevolucionEnum
        RMA
        Cambio
    End Enum

    Dim _TipoDevolucion As TipoDevolucionEnum

    Public Property TipoDevolucion() As TipoDevolucionEnum
        Get
            Return _TipoDevolucion
        End Get
        Set(ByVal Value As TipoDevolucionEnum)
            _TipoDevolucion = Value
        End Set
    End Property

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbt_RMA.CheckedChanged
        _TipoDevolucion = TipoDevolucionEnum.RMA
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbt_CAM.CheckedChanged
        _TipoDevolucion = TipoDevolucionEnum.Cambio
    End Sub

    Private Sub ButtonNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonNext.Click
        If Me.rbt_CAM.Checked = True Or Me.rbt_RMA.Checked = True Then
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Else
            Me.labelmessage.Text = "SELECCIONE EL TIPO DE DEVOLUCION"
            Me.labelmessage.visible = True
        End If
    End Sub

    Private Sub ButtonFinish_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonFinish.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmTipo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
