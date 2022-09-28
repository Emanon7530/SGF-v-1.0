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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(272, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(104, 160)
        Me.Button1.Name = "Button1"
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Iniciar"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 198)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Renumerar Productos"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Dtsp As New DTS.Package
        Try
            Dtsp.LoadFromSQLServer("OFICINA2\REDSOFT", "sa", "sa", "SGF = Salidah")
            Dtsp.Execute()
        Catch ex As Exception
            'Log.Show(ex)
        End Try

        'Dim dtsp As New DTS.Package
        'dtsp.LoadFromSQLServer( _
        '    ServerName:="MyServer", _
        '    ServerUserName:="MyUserID", _
        '    ServerPassword:="MyPassword", _
        '    PackageName:="DTSDemo")
        'dtsp.Execute()

        '-----------------------------------------------------

        '        Option Explicit

        'Public Sub main()

        '        Dim oPkg As DTS.Package2
        '        oPkg = New DTS.Package2

        '        oPkg.LoadFromSQLServer("(local)\dev", , , _
        '            DTSSQLStgFlag_UseTrustedConnection, , , , _
        '            "PackageExecutionWithParams")

        '        oPkg.Execute()
        '        oPkg.UnInitialize()

        '        oPkg = Nothing

    End Sub


    End Sub
End Class
