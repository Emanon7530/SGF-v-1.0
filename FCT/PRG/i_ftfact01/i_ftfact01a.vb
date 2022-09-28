Public Class i_ftfact01a
    Inherits System.Windows.Forms.Form

    Dim _Porciento_Comsion As Decimal
    Dim _Serial As Integer

    '// Serial
    Public Property Serial() As Integer
        Get
            Return _Serial
        End Get
        Set(ByVal Value As Integer)
            _Serial = Value
        End Set
    End Property

    '// Comsion
    Public ReadOnly Property Comision() As Decimal
        Get
            Return _Porciento_Comsion
        End Get
    End Property
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtComision As System.Windows.Forms.TextBox
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtComision = New System.Windows.Forms.TextBox
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(32, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "% Comisión:"
        '
        'txtComision
        '
        Me.txtComision.Location = New System.Drawing.Point(104, 24)
        Me.txtComision.Name = "txtComision"
        Me.txtComision.TabIndex = 1
        Me.txtComision.Text = ""
        '
        'btnAceptar
        '
        Me.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnAceptar.Location = New System.Drawing.Point(40, 64)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.TabIndex = 2
        Me.btnAceptar.Text = "Aceptar"
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnCancel.Location = New System.Drawing.Point(128, 64)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancelar"
        '
        'i_ftfact01a
        '
        Me.AcceptButton = Me.btnAceptar
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(242, 104)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txtComision)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "i_ftfact01a"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambiar % Comisión"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Shadows Function ShowDialog() As System.Windows.Forms.DialogResult
        Dim Porciento As Integer
        Dim SelectStmt As String

        SelectStmt = "select porc_comision from ftfactm " & _
                    " where ftserial_no = " & Me.Serial.ToString

        _Porciento_Comsion = LibX.Data.Manager.GetScalar(SelectStmt)

        txtComision.Text = _Porciento_Comsion.ToString

        MyBase.ShowDialog()
    End Function

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim xUpdate As LibX.Data.XUpdateStmt

        _Porciento_Comsion = Val(txtComision.Text.Trim)

        xUpdate = New LibX.Data.XUpdateStmt("ftfactm")

        xUpdate.FieldsSet("porc_comision") = _Porciento_Comsion
        xUpdate.Fields("ftserial_no") = Me.Serial

        xUpdate.Execute()

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class
