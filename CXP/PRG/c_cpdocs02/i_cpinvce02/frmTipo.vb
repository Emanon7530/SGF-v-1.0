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
    Friend WithEvents ButtonNext As System.Windows.Forms.Button
    Friend WithEvents labelmessage As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbt_RD As System.Windows.Forms.RadioButton
    Friend WithEvents rbt_US As System.Windows.Forms.RadioButton
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.ButtonNext = New System.Windows.Forms.Button
        Me.labelmessage = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rbt_US = New System.Windows.Forms.RadioButton
        Me.rbt_RD = New System.Windows.Forms.RadioButton
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonNext
        '
        Me.ButtonNext.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonNext.Location = New System.Drawing.Point(112, 80)
        Me.ButtonNext.Name = "ButtonNext"
        Me.ButtonNext.TabIndex = 2
        Me.ButtonNext.Text = "Continuar"
        '
        'labelmessage
        '
        Me.labelmessage.ForeColor = System.Drawing.Color.Red
        Me.labelmessage.Location = New System.Drawing.Point(16, 120)
        Me.labelmessage.Name = "labelmessage"
        Me.labelmessage.Size = New System.Drawing.Size(280, 23)
        Me.labelmessage.TabIndex = 3
        Me.labelmessage.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbt_US)
        Me.GroupBox2.Controls.Add(Me.rbt_RD)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(296, 56)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo Moneda"
        '
        'rbt_US
        '
        Me.rbt_US.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbt_US.Location = New System.Drawing.Point(176, 16)
        Me.rbt_US.Name = "rbt_US"
        Me.rbt_US.Size = New System.Drawing.Size(64, 24)
        Me.rbt_US.TabIndex = 7
        Me.rbt_US.Text = "$US"
        '
        'rbt_RD
        '
        Me.rbt_RD.Checked = True
        Me.rbt_RD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbt_RD.Location = New System.Drawing.Point(72, 16)
        Me.rbt_RD.Name = "rbt_RD"
        Me.rbt_RD.Size = New System.Drawing.Size(64, 24)
        Me.rbt_RD.TabIndex = 6
        Me.rbt_RD.TabStop = True
        Me.rbt_RD.Text = "$RD"
        '
        'LibXDbSourceTable1
        '
        Me.LibXDbSourceTable1.AllowDelete = True
        Me.LibXDbSourceTable1.AllowEdit = True
        Me.LibXDbSourceTable1.AllowNew = True
        Me.LibXDbSourceTable1.AutoIncrementSerial = False
        Me.LibXDbSourceTable1.CustomDbUpdate = False
        Me.LibXDbSourceTable1.DeleteOrder = 0
        Me.LibXDbSourceTable1.FillOnQuery = True
        Me.LibXDbSourceTable1.FillOnRowChange = False
        Me.LibXDbSourceTable1.HeaderIsOnGrid = False
        Me.LibXDbSourceTable1.InnerJon = True
        Me.LibXDbSourceTable1.InsertOrder = 0
        Me.LibXDbSourceTable1.IsDetail = False
        Me.LibXDbSourceTable1.KeyFields = Nothing
        Me.LibXDbSourceTable1.LineColName = Nothing
        Me.LibXDbSourceTable1.MasterDetailRelation = Nothing
        Me.LibXDbSourceTable1.MasterTableName = Nothing
        Me.LibXDbSourceTable1.SerialColumnName = Nothing
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = Nothing
        Me.LibXDbSourceTable1.TableName = "ftncfm"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
        '
        'frmTipo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(314, 144)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.labelmessage)
        Me.Controls.Add(Me.ButtonNext)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "frmTipo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Identificar el tipo de moneda"
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim _TipoNCF As TipoNCFEnum
    Dim _Moneda As MonedaEnum

    Public Property TipoNCF() As TipoNCFEnum
        Get
            Return _TipoNCF
        End Get
        Set(ByVal Value As TipoNCFEnum)
            _TipoNCF = Value
        End Set
    End Property
    Public Property Moneda() As MonedaEnum
        Get
            Return _Moneda
        End Get
        Set(ByVal Value As MonedaEnum)
            _Moneda = Value
        End Set
    End Property

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        _TipoNCF = TipoNCFEnum.ConValorFiscal
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        _TipoNCF = TipoNCFEnum.SinValorFiscal
    End Sub

    Private Sub ButtonNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonNext.Click
        ''    If (Me.rbt_SinValorFISCAL.Checked = True Or Me.rbt_ConValorFISCAL.Checked = True Or Me.rbt_GUBERNAMENTAL.Checked = True Or Me.rbt_ZONAFRANCA.Checked = True) Or isValid = True Then
        ''        If Me.rbt_SinValorFISCAL.Checked = True Then
        ''            _TipoNCF = TipoNCFEnum.SinValorFiscal
        ''        End If

        ''        If Me.rbt_ConValorFISCAL.Checked = True Then
        ''            _TipoNCF = TipoNCFEnum.ConValorFiscal
        ''        End If

        ''        If Me.rbt_GUBERNAMENTAL.Checked = True Then
        ''            _TipoNCF = TipoNCFEnum.Gubernamental
        ''        End If

        ''        If Me.rbt_ZONAFRANCA.Checked = True Then
        ''            _TipoNCF = TipoNCFEnum.ZonasFrancas
        ''        End If

        If (Me.rbt_RD.Checked = True Or Me.rbt_US.Checked = True) Or isValid = True Then
            If Me.rbt_RD.Checked = True Then
                _Moneda = MonedaEnum.RD
            End If
            If Me.rbt_US.Checked = True Then
                _Moneda = MonedaEnum.US
            End If
        End If

        Me.DialogResult = DialogResult.OK
        Me.Close()
        ''Else
        ''Me.labelmessage.Text = "SELECCIONE EL TIPO DE DEVOLUCION"
        ''Me.labelmessage.Visible = True
        ''End If
    End Sub

    Private Sub ButtonFinish_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = DialogResult.Cancel
        Me.Close()

    End Sub

    Private Sub frmTipo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _TipoNCF = TipoNCFEnum.SinValorFiscal
        isValid = False
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        _TipoNCF = TipoNCFEnum.None
        ''Me.rbt_SinValorFISCAL.Checked = False
        ''Me.rbt_ConValorFISCAL.Checked = False
        ''Me.rbt_GUBERNAMENTAL.Checked = False
        ''Me.rbt_ZONAFRANCA.Checked = False

    End Sub

    Private Sub frmTipo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            '// Pasar
            If e.KeyCode = Keys.F12 Then
                ''Me.rbt_SinValorFISCAL.Checked = False
                ''Me.rbt_ConValorFISCAL.Checked = False
                ''Me.rbt_GUBERNAMENTAL.Checked = False
                ''Me.rbt_ZONAFRANCA.Checked = False
                isValid = True
                _TipoNCF = TipoNCFEnum.None
                ButtonNext_Click(sender, New EventArgs)
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    ''Private Sub rbt_GUBERNAMENTAL_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    ''    _TipoNCF = TipoNCFEnum.Gubernamental
    ''End Sub

    ''Private Sub rbt_ZONAFRANCA_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    ''    _TipoNCF = TipoNCFEnum.ZonasFrancas
    ''End Sub

    Private Sub rbt_RD_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbt_RD.CheckedChanged
        _Moneda = MonedaEnum.RD
    End Sub

    Private Sub rbt_US_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbt_US.CheckedChanged
        _Moneda = MonedaEnum.US
    End Sub


End Class
