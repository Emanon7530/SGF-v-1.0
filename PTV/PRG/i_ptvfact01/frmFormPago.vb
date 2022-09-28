Public Class frmFormPago
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
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents XTextBox11 As LibX.XTextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents XTextBox12 As LibX.XTextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents XTextBox13 As LibX.XTextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents XTextBox14 As LibX.XTextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents XTextBox15 As LibX.XTextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents XTextBox16 As LibX.XTextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.XTextBox11 = New LibX.XTextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.XTextBox12 = New LibX.XTextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.XTextBox13 = New LibX.XTextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.XTextBox14 = New LibX.XTextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.XTextBox15 = New LibX.XTextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.XTextBox16 = New LibX.XTextBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Controls.Add(Me.XTextBox11)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.XTextBox12)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.XTextBox13)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.XTextBox14)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.XTextBox15)
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.Controls.Add(Me.XTextBox16)
        Me.GroupBox3.Controls.Add(Me.Label26)
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Controls.Add(Me.Button5)
        Me.GroupBox3.Controls.Add(Me.Button6)
        Me.GroupBox3.Controls.Add(Me.Button7)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 64)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(408, 184)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Forma de Pago"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(305, 47)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(24, 20)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "..."
        '
        'XTextBox11
        '
        Me.XTextBox11.EditInitialValue = Nothing
        Me.XTextBox11.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox11.FindInitialValue = Nothing
        Me.XTextBox11.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox11.IgnoreRequiered = False
        Me.XTextBox11.Location = New System.Drawing.Point(151, 22)
        Me.XTextBox11.Name = "XTextBox11"
        Me.XTextBox11.NewInitialValue = Nothing
        Me.XTextBox11.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox11.Requiered = False
        Me.XTextBox11.Size = New System.Drawing.Size(152, 20)
        Me.XTextBox11.TabIndex = 20
        Me.XTextBox11.Text = ""
        Me.XTextBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(79, 22)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(64, 16)
        Me.Label21.TabIndex = 19
        Me.Label21.Text = "Efectivo:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XTextBox12
        '
        Me.XTextBox12.EditInitialValue = Nothing
        Me.XTextBox12.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox12.FindInitialValue = Nothing
        Me.XTextBox12.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox12.IgnoreRequiered = False
        Me.XTextBox12.Location = New System.Drawing.Point(151, 46)
        Me.XTextBox12.Name = "XTextBox12"
        Me.XTextBox12.NewInitialValue = Nothing
        Me.XTextBox12.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox12.Requiered = False
        Me.XTextBox12.Size = New System.Drawing.Size(152, 20)
        Me.XTextBox12.TabIndex = 20
        Me.XTextBox12.Text = ""
        Me.XTextBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(79, 46)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(64, 16)
        Me.Label22.TabIndex = 19
        Me.Label22.Text = "Tarjeta:"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XTextBox13
        '
        Me.XTextBox13.EditInitialValue = Nothing
        Me.XTextBox13.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox13.FindInitialValue = Nothing
        Me.XTextBox13.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox13.IgnoreRequiered = False
        Me.XTextBox13.Location = New System.Drawing.Point(151, 70)
        Me.XTextBox13.Name = "XTextBox13"
        Me.XTextBox13.NewInitialValue = Nothing
        Me.XTextBox13.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox13.Requiered = False
        Me.XTextBox13.Size = New System.Drawing.Size(152, 20)
        Me.XTextBox13.TabIndex = 20
        Me.XTextBox13.Text = ""
        Me.XTextBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(79, 70)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(64, 16)
        Me.Label23.TabIndex = 19
        Me.Label23.Text = "Cheque:"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XTextBox14
        '
        Me.XTextBox14.EditInitialValue = Nothing
        Me.XTextBox14.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox14.FindInitialValue = Nothing
        Me.XTextBox14.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox14.IgnoreRequiered = False
        Me.XTextBox14.Location = New System.Drawing.Point(151, 94)
        Me.XTextBox14.Name = "XTextBox14"
        Me.XTextBox14.NewInitialValue = Nothing
        Me.XTextBox14.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox14.Requiered = False
        Me.XTextBox14.Size = New System.Drawing.Size(152, 20)
        Me.XTextBox14.TabIndex = 20
        Me.XTextBox14.Text = ""
        Me.XTextBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(79, 94)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(64, 16)
        Me.Label24.TabIndex = 19
        Me.Label24.Text = "Crédito:"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XTextBox15
        '
        Me.XTextBox15.EditInitialValue = Nothing
        Me.XTextBox15.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox15.FindInitialValue = Nothing
        Me.XTextBox15.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox15.IgnoreRequiered = False
        Me.XTextBox15.Location = New System.Drawing.Point(151, 118)
        Me.XTextBox15.Name = "XTextBox15"
        Me.XTextBox15.NewInitialValue = Nothing
        Me.XTextBox15.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox15.Requiered = False
        Me.XTextBox15.Size = New System.Drawing.Size(152, 20)
        Me.XTextBox15.TabIndex = 20
        Me.XTextBox15.Text = ""
        Me.XTextBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(79, 118)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(64, 16)
        Me.Label25.TabIndex = 19
        Me.Label25.Text = "N/Crédito:"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XTextBox16
        '
        Me.XTextBox16.EditInitialValue = Nothing
        Me.XTextBox16.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox16.FindInitialValue = Nothing
        Me.XTextBox16.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox16.IgnoreRequiered = False
        Me.XTextBox16.Location = New System.Drawing.Point(151, 142)
        Me.XTextBox16.Name = "XTextBox16"
        Me.XTextBox16.NewInitialValue = Nothing
        Me.XTextBox16.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox16.Requiered = False
        Me.XTextBox16.Size = New System.Drawing.Size(152, 20)
        Me.XTextBox16.TabIndex = 20
        Me.XTextBox16.Text = ""
        Me.XTextBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(79, 142)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(64, 16)
        Me.Label26.TabIndex = 19
        Me.Label26.Text = "Seguro:"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(305, 72)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(24, 20)
        Me.Button4.TabIndex = 21
        Me.Button4.Text = "..."
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(305, 96)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(24, 20)
        Me.Button5.TabIndex = 21
        Me.Button5.Text = "..."
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(305, 120)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(24, 20)
        Me.Button6.TabIndex = 21
        Me.Button6.Text = "..."
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(305, 144)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(24, 20)
        Me.Button7.TabIndex = 21
        Me.Button7.Text = "..."
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(424, 56)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "FORMA DE PAGO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(131, 256)
        Me.Button1.Name = "Button1"
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Aceptar"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(219, 256)
        Me.Button2.Name = "Button2"
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Cancelar"
        '
        'frmFormPago
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(424, 294)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Button2)
        Me.Name = "frmFormPago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Forma de Pago"
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
