Imports SGT.Administracion.Entidades.Permission

Public Class frmAutorization
    Inherits System.Windows.Forms.Form
    Dim mTipo As Permission.TipoAutorizacionEnum
    Public Descuento As Decimal

    Public UserID As Integer
    Public Password As String
    Public scDefault As Integer

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
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtAutorizKey As System.Windows.Forms.TextBox
    Friend WithEvents txtUserID As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtAutorizKey = New System.Windows.Forms.TextBox()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Digite el Código de Autorización"
        '
        'btnOk
        '
        Me.btnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOk.Location = New System.Drawing.Point(123, 88)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 2
        Me.btnOk.Text = "OK"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(203, 88)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancelar"
        '
        'txtAutorizKey
        '
        Me.txtAutorizKey.Location = New System.Drawing.Point(8, 56)
        Me.txtAutorizKey.Name = "txtAutorizKey"
        Me.txtAutorizKey.PasswordChar = [Global].Microsoft.VisualBasic.ChrW(42)
        Me.txtAutorizKey.Size = New System.Drawing.Size(168, 20)
        Me.txtAutorizKey.TabIndex = 1
        '
        'txtUserID
        '
        Me.txtUserID.Location = New System.Drawing.Point(8, 32)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(168, 20)
        Me.txtUserID.TabIndex = 0
        '
        'frmAutorization
        '
        Me.AcceptButton = Me.btnOk
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(293, 176)
        Me.Controls.Add(Me.txtUserID)
        Me.Controls.Add(Me.txtAutorizKey)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmAutorization"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Autorización Requerida"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Dim ResultValid As Boolean

        ResultValid = isValid(txtAutorizKey.Text, mTipo)

        If ResultValid = True Then
            Me.DialogResult = Windows.Forms.DialogResult.Yes
        Else
            Me.DialogResult = Windows.Forms.DialogResult.No
        End If

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Public Function isValid(ByVal passwrd As String, ByVal Tipo As Permission.TipoAutorizacionEnum) As Boolean
        Dim IndDescuento As Integer
        Dim oRow As DataRow
        Dim SelectStmt As String

        Try
            scDefault = System.Configuration.ConfigurationSettings.AppSettings.Get("LibxScDefault")

            SelectStmt = "select scusers.*,autoriza from scusers " & _
                         " inner join ftvendm on scusers.vend_code = ftvendm.vend_code " & _
                         " where (scusers.username = '" & txtUserID.Text.Trim & _
                         "' and ftvendm.autoriza = '" & passwrd.Trim & "')" & _
                         " and scusers.suc_code =" & scDefault

            oRow = LibX.Data.Manager.GetDataRow(SelectStmt)

            If oRow Is Nothing Then
                Return False
            End If

            UserID = oRow!userid
            Password = passwrd
            Return True
        Catch ex As Exception
            LibX.Log.Add(ex)
            Return False
        End Try
    End Function

    Private Sub frmAutorization_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            If txtUserID.Text = "" AndAlso Not LibX.User.UserName Is Nothing Then
                txtUserID.Text = LibX.User.UserName.Trim
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
   
End Class
