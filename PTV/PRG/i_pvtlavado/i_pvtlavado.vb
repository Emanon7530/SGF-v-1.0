Imports SGT.Caja.Entidades
Imports SGT.Inventario.Entidades
Imports SGT.Facturacion.Entidades
Imports SGT.PuntodeVenta.Entidades
Imports LibX
Imports System.Drawing.Printing
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class i_pvtlavado
    Inherits System.Windows.Forms.Form

    Dim radD As New Common.Items

    Dim _addIndex As New Common.Items
    Dim _oIndex As New Common.controlIndex

    Dim oCajaAbierta As CajaAbierta
    Dim oVend As Integer
    Dim oSuper As Integer
    Dim cItem As String
    Dim fSerial As Integer

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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents _btnAgregar As System.Windows.Forms.Button
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents DataTable2 As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents DataColumn17 As System.Data.DataColumn
    Friend WithEvents DataColumn18 As System.Data.DataColumn
    Friend WithEvents DataColumn19 As System.Data.DataColumn
    Friend WithEvents DataColumn20 As System.Data.DataColumn
    Friend WithEvents DataColumn21 As System.Data.DataColumn
    Friend WithEvents DataColumn22 As System.Data.DataColumn
    Friend WithEvents DataColumn23 As System.Data.DataColumn
    Friend WithEvents DataColumn24 As System.Data.DataColumn
    Friend WithEvents DataColumn25 As System.Data.DataColumn
    Friend WithEvents DataColumn26 As System.Data.DataColumn
    Friend WithEvents DataColumn27 As System.Data.DataColumn
    Friend WithEvents DataColumn28 As System.Data.DataColumn
    Friend WithEvents DataColumn29 As System.Data.DataColumn
    Friend WithEvents DataColumn30 As System.Data.DataColumn
    Friend WithEvents DataColumn31 As System.Data.DataColumn
    Friend WithEvents DataColumn32 As System.Data.DataColumn
    Friend WithEvents DataColumn33 As System.Data.DataColumn
    Friend WithEvents DataColumn34 As System.Data.DataColumn
    Friend WithEvents DataColumn35 As System.Data.DataColumn
    Friend WithEvents DataColumn36 As System.Data.DataColumn
    Friend WithEvents DataColumn37 As System.Data.DataColumn
    Friend WithEvents DataColumn38 As System.Data.DataColumn
    Friend WithEvents btn_1 As System.Windows.Forms.Button
    Friend WithEvents btn_2 As System.Windows.Forms.Button
    Friend WithEvents btn_3 As System.Windows.Forms.Button
    Friend WithEvents btn_6 As System.Windows.Forms.Button
    Friend WithEvents btn_7 As System.Windows.Forms.Button
    Friend WithEvents btn_8 As System.Windows.Forms.Button
    Friend WithEvents btn_a As System.Windows.Forms.Button
    Friend WithEvents btn_e As System.Windows.Forms.Button
    Friend WithEvents btn_g As System.Windows.Forms.Button
    Friend WithEvents btn_d As System.Windows.Forms.Button
    Friend WithEvents btn_m As System.Windows.Forms.Button
    Friend WithEvents btn_o As System.Windows.Forms.Button
    Friend WithEvents btn_f As System.Windows.Forms.Button
    Friend WithEvents btn_i As System.Windows.Forms.Button
    Friend WithEvents btn_9 As System.Windows.Forms.Button
    Friend WithEvents btn_4 As System.Windows.Forms.Button
    Friend WithEvents btn_p As System.Windows.Forms.Button
    Friend WithEvents btn_l As System.Windows.Forms.Button
    Friend WithEvents btn_0 As System.Windows.Forms.Button
    Friend WithEvents btn_5 As System.Windows.Forms.Button
    Friend WithEvents btn_x As System.Windows.Forms.Button
    Friend WithEvents xtxPlaca As LibX.XTextBox
    Friend WithEvents btn As System.Windows.Forms.Button
    Friend WithEvents btn_ As System.Windows.Forms.Button
    Friend WithEvents btn_del As System.Windows.Forms.Button
    Friend WithEvents btnPunto As System.Windows.Forms.Button
    Friend WithEvents longitud As System.Windows.Forms.Label
    Friend WithEvents LabelPlaca As System.Windows.Forms.Label
    Friend WithEvents LabelServicios As System.Windows.Forms.Label
    Friend WithEvents LabelLavadores As System.Windows.Forms.Label
    Friend WithEvents Vehiculos As System.Windows.Forms.GroupBox
    Friend WithEvents btmAceptar As System.Windows.Forms.Button
    Friend WithEvents btmCancelar As System.Windows.Forms.Button
    Friend WithEvents btnSig As System.Windows.Forms.Button
    Friend WithEvents labSuper As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LabelLavadores = New System.Windows.Forms.Label
        Me.LabelServicios = New System.Windows.Forms.Label
        Me.btn_del = New System.Windows.Forms.Button
        Me.btnPunto = New System.Windows.Forms.Button
        Me.btn = New System.Windows.Forms.Button
        Me.btn_ = New System.Windows.Forms.Button
        Me.btn_x = New System.Windows.Forms.Button
        Me.btn_p = New System.Windows.Forms.Button
        Me.btn_l = New System.Windows.Forms.Button
        Me.btn_0 = New System.Windows.Forms.Button
        Me.btn_5 = New System.Windows.Forms.Button
        Me.btn_f = New System.Windows.Forms.Button
        Me.btn_i = New System.Windows.Forms.Button
        Me.btn_9 = New System.Windows.Forms.Button
        Me.btn_4 = New System.Windows.Forms.Button
        Me.btn_o = New System.Windows.Forms.Button
        Me.btn_m = New System.Windows.Forms.Button
        Me.btn_d = New System.Windows.Forms.Button
        Me.btn_g = New System.Windows.Forms.Button
        Me.btn_e = New System.Windows.Forms.Button
        Me.btn_a = New System.Windows.Forms.Button
        Me.btn_8 = New System.Windows.Forms.Button
        Me.btn_7 = New System.Windows.Forms.Button
        Me.btn_6 = New System.Windows.Forms.Button
        Me.btn_3 = New System.Windows.Forms.Button
        Me.btn_2 = New System.Windows.Forms.Button
        Me.btn_1 = New System.Windows.Forms.Button
        Me.LabelPlaca = New System.Windows.Forms.Label
        Me.xtxPlaca = New LibX.XTextBox
        Me.longitud = New System.Windows.Forms.Label
        Me._btnAgregar = New System.Windows.Forms.Button
        Me.DataSet1 = New System.Data.DataSet
        Me.DataTable2 = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn7 = New System.Data.DataColumn
        Me.DataColumn8 = New System.Data.DataColumn
        Me.DataColumn9 = New System.Data.DataColumn
        Me.DataColumn10 = New System.Data.DataColumn
        Me.DataColumn11 = New System.Data.DataColumn
        Me.DataColumn12 = New System.Data.DataColumn
        Me.DataColumn13 = New System.Data.DataColumn
        Me.DataColumn14 = New System.Data.DataColumn
        Me.DataColumn15 = New System.Data.DataColumn
        Me.DataColumn16 = New System.Data.DataColumn
        Me.DataColumn17 = New System.Data.DataColumn
        Me.DataColumn18 = New System.Data.DataColumn
        Me.DataColumn19 = New System.Data.DataColumn
        Me.DataColumn20 = New System.Data.DataColumn
        Me.DataColumn21 = New System.Data.DataColumn
        Me.DataColumn22 = New System.Data.DataColumn
        Me.DataColumn23 = New System.Data.DataColumn
        Me.DataColumn24 = New System.Data.DataColumn
        Me.DataColumn25 = New System.Data.DataColumn
        Me.DataColumn26 = New System.Data.DataColumn
        Me.DataColumn27 = New System.Data.DataColumn
        Me.DataColumn28 = New System.Data.DataColumn
        Me.DataColumn29 = New System.Data.DataColumn
        Me.DataColumn30 = New System.Data.DataColumn
        Me.DataColumn31 = New System.Data.DataColumn
        Me.DataColumn32 = New System.Data.DataColumn
        Me.DataColumn33 = New System.Data.DataColumn
        Me.DataColumn34 = New System.Data.DataColumn
        Me.DataColumn35 = New System.Data.DataColumn
        Me.DataColumn36 = New System.Data.DataColumn
        Me.DataColumn37 = New System.Data.DataColumn
        Me.DataColumn38 = New System.Data.DataColumn
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.Vehiculos = New System.Windows.Forms.GroupBox
        Me.btmAceptar = New System.Windows.Forms.Button
        Me.btmCancelar = New System.Windows.Forms.Button
        Me.btnSig = New System.Windows.Forms.Button
        Me.labSuper = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Vehiculos.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.labSuper)
        Me.GroupBox1.Controls.Add(Me.LabelLavadores)
        Me.GroupBox1.Controls.Add(Me.LabelServicios)
        Me.GroupBox1.Controls.Add(Me.btn_del)
        Me.GroupBox1.Controls.Add(Me.btnPunto)
        Me.GroupBox1.Controls.Add(Me.btn)
        Me.GroupBox1.Controls.Add(Me.btn_)
        Me.GroupBox1.Controls.Add(Me.btn_x)
        Me.GroupBox1.Controls.Add(Me.btn_p)
        Me.GroupBox1.Controls.Add(Me.btn_l)
        Me.GroupBox1.Controls.Add(Me.btn_0)
        Me.GroupBox1.Controls.Add(Me.btn_5)
        Me.GroupBox1.Controls.Add(Me.btn_f)
        Me.GroupBox1.Controls.Add(Me.btn_i)
        Me.GroupBox1.Controls.Add(Me.btn_9)
        Me.GroupBox1.Controls.Add(Me.btn_4)
        Me.GroupBox1.Controls.Add(Me.btn_o)
        Me.GroupBox1.Controls.Add(Me.btn_m)
        Me.GroupBox1.Controls.Add(Me.btn_d)
        Me.GroupBox1.Controls.Add(Me.btn_g)
        Me.GroupBox1.Controls.Add(Me.btn_e)
        Me.GroupBox1.Controls.Add(Me.btn_a)
        Me.GroupBox1.Controls.Add(Me.btn_8)
        Me.GroupBox1.Controls.Add(Me.btn_7)
        Me.GroupBox1.Controls.Add(Me.btn_6)
        Me.GroupBox1.Controls.Add(Me.btn_3)
        Me.GroupBox1.Controls.Add(Me.btn_2)
        Me.GroupBox1.Controls.Add(Me.btn_1)
        Me.GroupBox1.Controls.Add(Me.LabelPlaca)
        Me.GroupBox1.Controls.Add(Me.xtxPlaca)
        Me.GroupBox1.Controls.Add(Me.longitud)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 136)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(704, 608)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'LabelLavadores
        '
        Me.LabelLavadores.BackColor = System.Drawing.SystemColors.Highlight
        Me.LabelLavadores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelLavadores.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLavadores.Location = New System.Drawing.Point(32, 8)
        Me.LabelLavadores.Name = "LabelLavadores"
        Me.LabelLavadores.Size = New System.Drawing.Size(632, 48)
        Me.LabelLavadores.TabIndex = 28
        Me.LabelLavadores.Text = "Lavadores"
        Me.LabelLavadores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelServicios
        '
        Me.LabelServicios.BackColor = System.Drawing.SystemColors.Highlight
        Me.LabelServicios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelServicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelServicios.Location = New System.Drawing.Point(32, 10)
        Me.LabelServicios.Name = "LabelServicios"
        Me.LabelServicios.Size = New System.Drawing.Size(624, 38)
        Me.LabelServicios.TabIndex = 27
        Me.LabelServicios.Text = "Servicios"
        Me.LabelServicios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_del
        '
        Me.btn_del.BackColor = System.Drawing.Color.DarkGray
        Me.btn_del.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_del.ForeColor = System.Drawing.Color.Black
        Me.btn_del.Location = New System.Drawing.Point(560, 496)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(128, 80)
        Me.btn_del.TabIndex = 26
        Me.btn_del.Text = "DL"
        '
        'btnPunto
        '
        Me.btnPunto.BackColor = System.Drawing.Color.DarkGray
        Me.btnPunto.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPunto.ForeColor = System.Drawing.Color.Black
        Me.btnPunto.Location = New System.Drawing.Point(424, 496)
        Me.btnPunto.Name = "btnPunto"
        Me.btnPunto.Size = New System.Drawing.Size(128, 80)
        Me.btnPunto.TabIndex = 25
        Me.btnPunto.Text = "."
        '
        'btn
        '
        Me.btn.BackColor = System.Drawing.Color.DarkGray
        Me.btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn.ForeColor = System.Drawing.Color.Black
        Me.btn.Location = New System.Drawing.Point(288, 496)
        Me.btn.Name = "btn"
        Me.btn.Size = New System.Drawing.Size(128, 80)
        Me.btn.TabIndex = 24
        '
        'btn_
        '
        Me.btn_.BackColor = System.Drawing.Color.DarkGray
        Me.btn_.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_.ForeColor = System.Drawing.Color.Black
        Me.btn_.Location = New System.Drawing.Point(152, 496)
        Me.btn_.Name = "btn_"
        Me.btn_.Size = New System.Drawing.Size(128, 80)
        Me.btn_.TabIndex = 23
        Me.btn_.Text = "-"
        '
        'btn_x
        '
        Me.btn_x.BackColor = System.Drawing.Color.DarkGray
        Me.btn_x.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_x.ForeColor = System.Drawing.Color.Black
        Me.btn_x.Location = New System.Drawing.Point(16, 496)
        Me.btn_x.Name = "btn_x"
        Me.btn_x.Size = New System.Drawing.Size(128, 80)
        Me.btn_x.TabIndex = 22
        Me.btn_x.Text = "X"
        '
        'btn_p
        '
        Me.btn_p.BackColor = System.Drawing.Color.DarkGray
        Me.btn_p.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_p.ForeColor = System.Drawing.Color.Black
        Me.btn_p.Location = New System.Drawing.Point(560, 408)
        Me.btn_p.Name = "btn_p"
        Me.btn_p.Size = New System.Drawing.Size(128, 80)
        Me.btn_p.TabIndex = 21
        Me.btn_p.Text = "P"
        '
        'btn_l
        '
        Me.btn_l.BackColor = System.Drawing.Color.DarkGray
        Me.btn_l.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_l.ForeColor = System.Drawing.Color.Black
        Me.btn_l.Location = New System.Drawing.Point(560, 320)
        Me.btn_l.Name = "btn_l"
        Me.btn_l.Size = New System.Drawing.Size(128, 80)
        Me.btn_l.TabIndex = 20
        Me.btn_l.Text = "L"
        '
        'btn_0
        '
        Me.btn_0.BackColor = System.Drawing.Color.DarkGray
        Me.btn_0.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_0.ForeColor = System.Drawing.Color.Black
        Me.btn_0.Location = New System.Drawing.Point(560, 232)
        Me.btn_0.Name = "btn_0"
        Me.btn_0.Size = New System.Drawing.Size(128, 80)
        Me.btn_0.TabIndex = 19
        Me.btn_0.Text = "0"
        '
        'btn_5
        '
        Me.btn_5.BackColor = System.Drawing.Color.DarkGray
        Me.btn_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_5.ForeColor = System.Drawing.Color.Black
        Me.btn_5.Location = New System.Drawing.Point(560, 144)
        Me.btn_5.Name = "btn_5"
        Me.btn_5.Size = New System.Drawing.Size(128, 80)
        Me.btn_5.TabIndex = 18
        Me.btn_5.Text = "5"
        '
        'btn_f
        '
        Me.btn_f.BackColor = System.Drawing.Color.DarkGray
        Me.btn_f.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_f.ForeColor = System.Drawing.Color.Black
        Me.btn_f.Location = New System.Drawing.Point(424, 408)
        Me.btn_f.Name = "btn_f"
        Me.btn_f.Size = New System.Drawing.Size(128, 80)
        Me.btn_f.TabIndex = 17
        Me.btn_f.Text = "F"
        '
        'btn_i
        '
        Me.btn_i.BackColor = System.Drawing.Color.DarkGray
        Me.btn_i.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_i.ForeColor = System.Drawing.Color.Black
        Me.btn_i.Location = New System.Drawing.Point(424, 320)
        Me.btn_i.Name = "btn_i"
        Me.btn_i.Size = New System.Drawing.Size(128, 80)
        Me.btn_i.TabIndex = 16
        Me.btn_i.Text = "I"
        '
        'btn_9
        '
        Me.btn_9.BackColor = System.Drawing.Color.DarkGray
        Me.btn_9.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_9.ForeColor = System.Drawing.Color.Black
        Me.btn_9.Location = New System.Drawing.Point(424, 232)
        Me.btn_9.Name = "btn_9"
        Me.btn_9.Size = New System.Drawing.Size(128, 80)
        Me.btn_9.TabIndex = 15
        Me.btn_9.Text = "9"
        '
        'btn_4
        '
        Me.btn_4.BackColor = System.Drawing.Color.DarkGray
        Me.btn_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_4.ForeColor = System.Drawing.Color.Black
        Me.btn_4.Location = New System.Drawing.Point(424, 144)
        Me.btn_4.Name = "btn_4"
        Me.btn_4.Size = New System.Drawing.Size(128, 80)
        Me.btn_4.TabIndex = 14
        Me.btn_4.Text = "4"
        '
        'btn_o
        '
        Me.btn_o.BackColor = System.Drawing.Color.DarkGray
        Me.btn_o.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_o.ForeColor = System.Drawing.Color.Black
        Me.btn_o.Location = New System.Drawing.Point(288, 408)
        Me.btn_o.Name = "btn_o"
        Me.btn_o.Size = New System.Drawing.Size(128, 80)
        Me.btn_o.TabIndex = 13
        Me.btn_o.Text = "O"
        '
        'btn_m
        '
        Me.btn_m.BackColor = System.Drawing.Color.DarkGray
        Me.btn_m.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_m.ForeColor = System.Drawing.Color.Black
        Me.btn_m.Location = New System.Drawing.Point(152, 408)
        Me.btn_m.Name = "btn_m"
        Me.btn_m.Size = New System.Drawing.Size(128, 80)
        Me.btn_m.TabIndex = 12
        Me.btn_m.Text = "M"
        '
        'btn_d
        '
        Me.btn_d.BackColor = System.Drawing.Color.DarkGray
        Me.btn_d.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_d.ForeColor = System.Drawing.Color.Black
        Me.btn_d.Location = New System.Drawing.Point(16, 408)
        Me.btn_d.Name = "btn_d"
        Me.btn_d.Size = New System.Drawing.Size(128, 80)
        Me.btn_d.TabIndex = 11
        Me.btn_d.Text = "D"
        '
        'btn_g
        '
        Me.btn_g.BackColor = System.Drawing.Color.DarkGray
        Me.btn_g.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_g.ForeColor = System.Drawing.Color.Black
        Me.btn_g.Location = New System.Drawing.Point(288, 320)
        Me.btn_g.Name = "btn_g"
        Me.btn_g.Size = New System.Drawing.Size(128, 80)
        Me.btn_g.TabIndex = 10
        Me.btn_g.Text = "G"
        '
        'btn_e
        '
        Me.btn_e.BackColor = System.Drawing.Color.DarkGray
        Me.btn_e.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_e.ForeColor = System.Drawing.Color.Black
        Me.btn_e.Location = New System.Drawing.Point(152, 320)
        Me.btn_e.Name = "btn_e"
        Me.btn_e.Size = New System.Drawing.Size(128, 80)
        Me.btn_e.TabIndex = 9
        Me.btn_e.Text = "E"
        '
        'btn_a
        '
        Me.btn_a.BackColor = System.Drawing.Color.DarkGray
        Me.btn_a.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_a.ForeColor = System.Drawing.Color.Black
        Me.btn_a.Location = New System.Drawing.Point(16, 320)
        Me.btn_a.Name = "btn_a"
        Me.btn_a.Size = New System.Drawing.Size(128, 80)
        Me.btn_a.TabIndex = 8
        Me.btn_a.Text = "A"
        '
        'btn_8
        '
        Me.btn_8.BackColor = System.Drawing.Color.DarkGray
        Me.btn_8.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_8.ForeColor = System.Drawing.Color.Black
        Me.btn_8.Location = New System.Drawing.Point(288, 232)
        Me.btn_8.Name = "btn_8"
        Me.btn_8.Size = New System.Drawing.Size(128, 80)
        Me.btn_8.TabIndex = 7
        Me.btn_8.Text = "8"
        '
        'btn_7
        '
        Me.btn_7.BackColor = System.Drawing.Color.DarkGray
        Me.btn_7.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_7.ForeColor = System.Drawing.Color.Black
        Me.btn_7.Location = New System.Drawing.Point(152, 232)
        Me.btn_7.Name = "btn_7"
        Me.btn_7.Size = New System.Drawing.Size(128, 80)
        Me.btn_7.TabIndex = 6
        Me.btn_7.Text = "7"
        '
        'btn_6
        '
        Me.btn_6.BackColor = System.Drawing.Color.DarkGray
        Me.btn_6.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_6.ForeColor = System.Drawing.Color.Black
        Me.btn_6.Location = New System.Drawing.Point(16, 232)
        Me.btn_6.Name = "btn_6"
        Me.btn_6.Size = New System.Drawing.Size(128, 80)
        Me.btn_6.TabIndex = 6
        Me.btn_6.Text = "6"
        '
        'btn_3
        '
        Me.btn_3.BackColor = System.Drawing.Color.DarkGray
        Me.btn_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_3.ForeColor = System.Drawing.Color.Black
        Me.btn_3.Location = New System.Drawing.Point(288, 144)
        Me.btn_3.Name = "btn_3"
        Me.btn_3.Size = New System.Drawing.Size(128, 80)
        Me.btn_3.TabIndex = 4
        Me.btn_3.Text = "3"
        '
        'btn_2
        '
        Me.btn_2.BackColor = System.Drawing.Color.DarkGray
        Me.btn_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_2.ForeColor = System.Drawing.Color.Black
        Me.btn_2.Location = New System.Drawing.Point(152, 144)
        Me.btn_2.Name = "btn_2"
        Me.btn_2.Size = New System.Drawing.Size(128, 80)
        Me.btn_2.TabIndex = 3
        Me.btn_2.Text = "2"
        '
        'btn_1
        '
        Me.btn_1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_1.BackColor = System.Drawing.Color.DarkGray
        Me.btn_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_1.ForeColor = System.Drawing.Color.Black
        Me.btn_1.Location = New System.Drawing.Point(16, 144)
        Me.btn_1.Name = "btn_1"
        Me.btn_1.Size = New System.Drawing.Size(128, 80)
        Me.btn_1.TabIndex = 2
        Me.btn_1.Text = "1"
        '
        'LabelPlaca
        '
        Me.LabelPlaca.BackColor = System.Drawing.SystemColors.Highlight
        Me.LabelPlaca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelPlaca.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPlaca.Location = New System.Drawing.Point(32, 10)
        Me.LabelPlaca.Name = "LabelPlaca"
        Me.LabelPlaca.Size = New System.Drawing.Size(632, 46)
        Me.LabelPlaca.TabIndex = 1
        Me.LabelPlaca.Text = "Placa"
        Me.LabelPlaca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'xtxPlaca
        '
        Me.xtxPlaca.AcceptsReturn = True
        Me.xtxPlaca.EditInitialValue = Nothing
        Me.xtxPlaca.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxPlaca.FieldDescription = ""
        Me.xtxPlaca.FindInitialValue = Nothing
        Me.xtxPlaca.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxPlaca.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xtxPlaca.ForeColor = System.Drawing.SystemColors.ControlText
        Me.xtxPlaca.IgnoreRequiered = False
        Me.xtxPlaca.Location = New System.Drawing.Point(32, 80)
        Me.xtxPlaca.Name = "xtxPlaca"
        Me.xtxPlaca.NewInitialValue = Nothing
        Me.xtxPlaca.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxPlaca.Requiered = True
        Me.xtxPlaca.Size = New System.Drawing.Size(632, 47)
        Me.xtxPlaca.StatusBarPanelDescripcion = Nothing
        Me.xtxPlaca.TabIndex = 0
        Me.xtxPlaca.Text = ""
        '
        'longitud
        '
        Me.longitud.AutoSize = True
        Me.longitud.BackColor = System.Drawing.SystemColors.HighlightText
        Me.longitud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.longitud.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.longitud.Location = New System.Drawing.Point(32, 56)
        Me.longitud.Name = "longitud"
        Me.longitud.Size = New System.Drawing.Size(0, 21)
        Me.longitud.TabIndex = 27
        Me.longitud.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.longitud.Visible = False
        '
        '_btnAgregar
        '
        Me._btnAgregar.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me._btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnAgregar.Location = New System.Drawing.Point(8, 8)
        Me._btnAgregar.Name = "_btnAgregar"
        Me._btnAgregar.Size = New System.Drawing.Size(104, 96)
        Me._btnAgregar.TabIndex = 1
        Me._btnAgregar.Text = "Agregar"
        '
        'DataSet1
        '
        Me.LibXConnector1.SetDataGenerator(Me.DataSet1, Me.LibXConnector1)
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, True)
        Me.DataSet1.EnforceConstraints = False
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable2})
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38})
        Me.DataTable2.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"ftserial_no", "suc_code"}, True)})
        Me.DataTable2.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn37}
        Me.DataTable2.TableName = "ftfactm"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.AutoIncrement = True
        Me.DataColumn1.ColumnName = "ftserial_no"
        Me.DataColumn1.DataType = GetType(System.Int32)
        Me.DataColumn1.ReadOnly = True
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "whse_code"
        Me.DataColumn2.DataType = GetType(System.Int32)
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "dev_type"
        Me.DataColumn3.MaxLength = 3
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "cotiz_serial"
        Me.DataColumn4.DataType = GetType(System.Int32)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "term_code"
        Me.DataColumn5.MaxLength = 5
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "addr_code"
        Me.DataColumn6.DataType = GetType(System.Int32)
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "vend_code"
        Me.DataColumn7.DataType = GetType(System.Int32)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "fact_number"
        Me.DataColumn8.DataType = GetType(System.Int32)
        '
        'DataColumn9
        '
        Me.DataColumn9.AllowDBNull = False
        Me.DataColumn9.ColumnName = "fact_date"
        Me.DataColumn9.DataType = GetType(System.DateTime)
        '
        'DataColumn10
        '
        Me.DataColumn10.AllowDBNull = False
        Me.DataColumn10.ColumnName = "fact_total"
        Me.DataColumn10.DataType = GetType(System.Decimal)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "descto"
        Me.DataColumn11.DataType = GetType(System.Decimal)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "itbis"
        Me.DataColumn12.DataType = GetType(System.Decimal)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "userid"
        Me.DataColumn13.MaxLength = 20
        '
        'DataColumn14
        '
        Me.DataColumn14.AllowDBNull = False
        Me.DataColumn14.ColumnName = "fact_status"
        Me.DataColumn14.DataType = GetType(System.Int32)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "date_created"
        Me.DataColumn15.DataType = GetType(System.DateTime)
        '
        'DataColumn16
        '
        Me.DataColumn16.AllowDBNull = False
        Me.DataColumn16.ColumnName = "type_code"
        Me.DataColumn16.MaxLength = 3
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "cust_code"
        Me.DataColumn17.DataType = GetType(System.Int32)
        '
        'DataColumn18
        '
        Me.DataColumn18.AllowDBNull = False
        Me.DataColumn18.ColumnName = "fact_cond"
        Me.DataColumn18.DataType = GetType(System.Int16)
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "bus_name"
        Me.DataColumn19.MaxLength = 100
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "fact_nota"
        Me.DataColumn20.MaxLength = 80
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "ftserial_afect"
        Me.DataColumn21.DataType = GetType(System.Int32)
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "pay_adelant"
        Me.DataColumn22.DataType = GetType(System.Int32)
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "phone"
        Me.DataColumn23.MaxLength = 13
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "pay_mora"
        Me.DataColumn24.DataType = GetType(System.Decimal)
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "porc_comision"
        Me.DataColumn25.DataType = GetType(System.Decimal)
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "caja_code"
        Me.DataColumn26.DataType = GetType(System.Int32)
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "caje_code"
        Me.DataColumn27.DataType = GetType(System.Int32)
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "init_serial"
        Me.DataColumn28.DataType = GetType(System.Int32)
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "fact_inddomicilio"
        Me.DataColumn29.DataType = GetType(System.Int32)
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "address"
        Me.DataColumn30.MaxLength = 200
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "seg_amount"
        Me.DataColumn31.DataType = GetType(System.Decimal)
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "prov_code"
        Me.DataColumn32.DataType = GetType(System.Int32)
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "fact_impresa"
        Me.DataColumn33.DataType = GetType(System.Int32)
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "fact_ncf"
        Me.DataColumn34.MaxLength = 40
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "cust_serial"
        Me.DataColumn35.DataType = GetType(System.Int32)
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "fact_time"
        Me.DataColumn36.MaxLength = 10
        '
        'DataColumn37
        '
        Me.DataColumn37.AllowDBNull = False
        Me.DataColumn37.ColumnName = "suc_code"
        Me.DataColumn37.DataType = GetType(System.Int32)
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "fact_create"
        Me.DataColumn38.DataType = GetType(System.DateTime)
        '
        'LibXConnector1
        '
        Me.LibXConnector1.AllowDelete = True
        Me.LibXConnector1.AllowEdit = True
        Me.LibXConnector1.AllowNew = True
        Me.LibXConnector1.AllowPrint = True
        Me.LibXConnector1.AllowQuery = True
        Me.LibXConnector1.BOF = False
        Me.LibXConnector1.CanExecuteFind = True
        Me.LibXConnector1.DataMember = "ftfactm"
        Me.LibXConnector1.DataSource = Me.DataSet1
        Me.LibXConnector1.EOF = False
        Me.LibXConnector1.HandledRowsFill = False
        Me.LibXConnector1.HandledUpdates = False
        Me.LibXConnector1.HasRecords = False
        Me.LibXConnector1.IsEditing = False
        Me.LibXConnector1.IsHeaderOnGrid = False
        Me.LibXConnector1.ModuleName = "PTV"
        Me.LibXConnector1.OwnerForm = Me
        Me.LibXConnector1.Parameters = Nothing
        Me.LibXConnector1.RecordCount = 0
        Me.LibXConnector1.ReportMode = False
        Me.LibXConnector1.ReportName = ""
        Me.LibXConnector1.ReportObject = Nothing
        Me.LibXConnector1.RequeryData = False
        Me.LibXConnector1.ShowWarningCancel = True
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.LibXDbSourceTable1})
        Me.LibXConnector1.State = LibX.LibxConnectorState.none
        Me.LibXConnector1.UpdatePrimaryKeyColumns = False
        Me.LibXConnector1.UseTransactions = True
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
        Me.LibXDbSourceTable1.SerialColumnName = "ftserial_no"
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = Nothing
        Me.LibXDbSourceTable1.TableName = "ftfactm"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
        '
        'Vehiculos
        '
        Me.Vehiculos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Vehiculos.Controls.Add(Me._btnAgregar)
        Me.Vehiculos.Location = New System.Drawing.Point(8, 8)
        Me.Vehiculos.Name = "Vehiculos"
        Me.Vehiculos.Size = New System.Drawing.Size(704, 120)
        Me.Vehiculos.TabIndex = 28
        Me.Vehiculos.TabStop = False
        '
        'btmAceptar
        '
        Me.btmAceptar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btmAceptar.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btmAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btmAceptar.Location = New System.Drawing.Point(108, 752)
        Me.btmAceptar.Name = "btmAceptar"
        Me.btmAceptar.Size = New System.Drawing.Size(128, 80)
        Me.btmAceptar.TabIndex = 2
        Me.btmAceptar.Text = "Guardar"
        '
        'btmCancelar
        '
        Me.btmCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btmCancelar.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btmCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btmCancelar.Location = New System.Drawing.Point(468, 752)
        Me.btmCancelar.Name = "btmCancelar"
        Me.btmCancelar.Size = New System.Drawing.Size(128, 80)
        Me.btmCancelar.TabIndex = 29
        Me.btmCancelar.Text = "Cancelar"
        '
        'btnSig
        '
        Me.btnSig.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSig.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnSig.Enabled = False
        Me.btnSig.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSig.Location = New System.Drawing.Point(300, 752)
        Me.btnSig.Name = "btnSig"
        Me.btnSig.Size = New System.Drawing.Size(128, 80)
        Me.btnSig.TabIndex = 30
        Me.btnSig.Text = "Aceptar"
        '
        'labSuper
        '
        Me.labSuper.BackColor = System.Drawing.SystemColors.Highlight
        Me.labSuper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labSuper.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labSuper.Location = New System.Drawing.Point(32, 8)
        Me.labSuper.Name = "labSuper"
        Me.labSuper.Size = New System.Drawing.Size(632, 48)
        Me.labSuper.TabIndex = 29
        Me.labSuper.Text = "Supervisores"
        Me.labSuper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'i_pvtlavado
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(720, 854)
        Me.Controls.Add(Me.btnSig)
        Me.Controls.Add(Me.btmCancelar)
        Me.Controls.Add(Me.Vehiculos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btmAceptar)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "i_pvtlavado"
        Me.Text = "FACTURACION DE SERVICIO                                                   Copyrig" & _
        "ht 2016 LSG v1.0 809-825-1017"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Vehiculos.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub i_pvtlavado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim hasCajas As Boolean = False
        Desactivar_botones()
        Dim sInit = LibX.Data.Manager.GetScalar("select max(init_serial) from cjinitm where init_status =1")
        Dim Scaja = LibX.Data.Manager.GetDataRow("select caja_code,vend_code,suc_code from cjinitm where init_serial = " & sInit)
        oCajaAbierta = New CajaAbierta(Scaja!caja_code, Scaja!suc_code)
    End Sub

    Private Sub Desactivar_botones()
        Me.xtxPlaca.Visible = False
        Me.xtxPlaca.Text = String.Empty
        Me.LabelPlaca.Visible = False
        Me.LabelLavadores.Visible = False
        Me.LabelServicios.Visible = False
        Me.labSuper.Visible = False
        Me.btmAceptar.Visible = False
        Me.btnSig.Visible = False
        Me.btn.Visible = False
        Me.btn_.Visible = False
        Me.btn_0.Visible = False
        Me.btn_1.Visible = False
        Me.btn_2.Visible = False
        Me.btn_3.Visible = False
        Me.btn_4.Visible = False
        Me.btn_5.Visible = False
        Me.btn_6.Visible = False
        Me.btn_6.Visible = False
        Me.btn_7.Visible = False
        Me.btn_7.Visible = False
        Me.btn_8.Visible = False
        Me.btn_9.Visible = False
        Me.btn_a.Visible = False
        Me.btn_d.Visible = False
        Me.btn_del.Visible = False
        Me.btn_e.Visible = False
        Me.btn_g.Visible = False
        Me.btn_f.Visible = False
        Me.btn_i.Visible = False
        Me.btn_l.Visible = False
        Me.btn_m.Visible = False
        Me.btn_o.Visible = False
        Me.btn_p.Visible = False
        Me.btn_x.Visible = False
        Me.btnPunto.Visible = False
    End Sub
    Private Sub Activar_botones()
        Me.xtxPlaca.Visible = True
        Me.xtxPlaca.Enabled = True
        Me.LabelPlaca.Visible = True
        Me.btmAceptar.Visible = True
        Me.btmAceptar.Enabled = False
        Me.btnSig.Visible = False
        Me.btn.Visible = True
        Me.btn_.Visible = True
        Me.btn_0.Visible = True
        Me.btn_1.Visible = True
        Me.btn_2.Visible = True
        Me.btn_3.Visible = True
        Me.btn_4.Visible = True
        Me.btn_5.Visible = True
        Me.btn_6.Visible = True
        Me.btn_6.Visible = True
        Me.btn_7.Visible = True
        Me.btn_7.Visible = True
        Me.btn_8.Visible = True
        Me.btn_9.Visible = True
        Me.btn_a.Visible = True
        Me.btn_d.Visible = True
        Me.btn_del.Visible = True
        Me.btn_e.Visible = True
        Me.btn_g.Visible = True
        Me.btn_f.Visible = True
        Me.btn_i.Visible = True
        Me.btn_l.Visible = True
        Me.btn_m.Visible = True
        Me.btn_o.Visible = True
        Me.btn_p.Visible = True
        Me.btn_x.Visible = True
        Me.btnPunto.Visible = True
    End Sub

    Private Sub _btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btnAgregar.Click
        BuscarGrupo()
    End Sub
    Private Sub BuscarGrupo()
        Dim x As Integer
        Dim y As Integer
        Dim x1 As Integer
        Dim y1 As Integer

        x = 115
        y = 8

        Try
            Dim oGrupo As DataTable = LibX.Data.Manager.GetDataTable("select * from ivgroupm where incluido =1 or oferta =1 order by group_name ")
            If oGrupo.Rows.Count > 0 Then
                For i As Integer = 0 To oGrupo.Rows.Count - 1
                    Dim tbindex As New Button
                    tbindex.Text = Convert.ToString(oGrupo.Rows(i)!group_name)
                    tbindex.Name = Convert.ToString(oGrupo.Rows(i)!group_name)
                    Me.Vehiculos.Controls.Add(tbindex)

                    With tbindex
                        .Location = New Point(x, y)
                        ''.Size = New System.Drawing.Size(110, 96)
                        .Size = New System.Drawing.Size(110, 50)
                        .ForeColor = Color.Black
                        .BackColor = System.Drawing.SystemColors.ControlDark
                        .Font = New System.Drawing.Font("Microsoft Sans Serif", 10.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                        .TabIndex = oGrupo.Rows(i)!group_code
                    End With

                    AddHandler tbindex.Click, AddressOf ButtonClick

                    x += 112
                    If i = 4 Then
                        ''Exit For
                        x = 115
                        y = 60
                    End If
                Next
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub
    Private Sub ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs)

        ' Referenciamos el control TextBox que ha desencadenado el evento
        '
        Dim tbindex As Button = DirectCast(sender, Button)
        Console.WriteLine(tbindex.Text)
        Console.WriteLine(tbindex.TabIndex)
        BuscarGrupoFijo(tbindex.TabIndex)
        btnSig.Enabled = False
        btnSig.Visible = True
        ''Activar_botones()

    End Sub

    Private Sub btn_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_1.Click
        ''A663080()
        If Me.xtxPlaca.TextLength > 7 Then
            Me.longitud.Text = "El numero de placa no puede ser mayor de 7"
            Me.longitud.ForeColor = Color.Red
            Me.longitud.Visible = True
        Else
            Me.longitud.Text = String.Empty
            Me.xtxPlaca.Text = Me.xtxPlaca.Text & btn_1.Text
        End If
        If Me.xtxPlaca.TextLength = 7 Then
            Me.longitud.Text = String.Empty
            btmAceptar.Enabled = True
        End If
    End Sub

    Private Sub btn_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_2.Click
        If Me.xtxPlaca.TextLength > 7 Then
            Me.longitud.Text = "El numero de placa no puede ser mayor de 7"
            Me.longitud.ForeColor = Color.Red
            Me.longitud.Visible = True
        Else
            Me.longitud.Text = String.Empty
            Me.xtxPlaca.Text = Me.xtxPlaca.Text & btn_2.Text
        End If
        If Me.xtxPlaca.TextLength = 7 Then
            Me.longitud.Text = String.Empty
            btmAceptar.Enabled = True
        End If

    End Sub

    Private Sub btn_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_3.Click
        If Me.xtxPlaca.TextLength > 7 Then
            Me.longitud.Text = "El numero de placa no puede ser mayor de 7"
            Me.longitud.ForeColor = Color.Red
            Me.longitud.Visible = True
        Else
            Me.longitud.Text = String.Empty
            Me.xtxPlaca.Text = Me.xtxPlaca.Text & btn_3.Text
        End If
        If Me.xtxPlaca.TextLength = 7 Then
            Me.longitud.Text = String.Empty
            btmAceptar.Enabled = True
        End If

    End Sub

    Private Sub btn_4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_4.Click
        If Me.xtxPlaca.TextLength > 7 Then
            Me.longitud.Text = "El numero de placa no puede ser mayor de 7"
            Me.longitud.ForeColor = Color.Red
            Me.longitud.Visible = True
        Else
            Me.longitud.Text = String.Empty
            Me.xtxPlaca.Text = Me.xtxPlaca.Text & btn_4.Text
        End If
        If Me.xtxPlaca.TextLength = 7 Then
            Me.longitud.Text = String.Empty
            btmAceptar.Enabled = True
        End If

    End Sub

    Private Sub btn_5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_5.Click
        If Me.xtxPlaca.TextLength > 7 Then
            Me.longitud.Text = "El numero de placa no puede ser mayor de 7"
            Me.longitud.ForeColor = Color.Red
            Me.longitud.Visible = True
        Else
            Me.longitud.Text = String.Empty
            Me.xtxPlaca.Text = Me.xtxPlaca.Text & btn_5.Text
        End If
        If Me.xtxPlaca.TextLength = 7 Then
            Me.longitud.Text = String.Empty
            btmAceptar.Enabled = True
        End If

    End Sub

    Private Sub btn_6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_6.Click
        If Me.xtxPlaca.TextLength > 7 Then
            Me.longitud.Text = "El numero de placa no puede ser mayor de 7"
            Me.longitud.ForeColor = Color.Red
            Me.longitud.Visible = True
        Else
            Me.longitud.Text = String.Empty
            Me.xtxPlaca.Text = Me.xtxPlaca.Text & btn_6.Text
        End If
        If Me.xtxPlaca.TextLength = 7 Then
            Me.longitud.Text = String.Empty
            btmAceptar.Enabled = True
        End If

    End Sub

    Private Sub btn_7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_7.Click
        If Me.xtxPlaca.TextLength > 7 Then
            Me.longitud.Text = "El numero de placa no puede ser mayor de 7"
            Me.longitud.ForeColor = Color.Red
            Me.longitud.Visible = True
        Else
            Me.longitud.Text = String.Empty
            Me.xtxPlaca.Text = Me.xtxPlaca.Text & btn_7.Text
        End If
        If Me.xtxPlaca.TextLength = 7 Then
            Me.longitud.Text = String.Empty
            btmAceptar.Enabled = True
        End If

    End Sub

    Private Sub btn_8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_8.Click
        If Me.xtxPlaca.TextLength > 7 Then
            Me.longitud.Text = "El numero de placa no puede ser mayor de 7"
            Me.longitud.ForeColor = Color.Red
            Me.longitud.Visible = True
        Else
            Me.longitud.Text = String.Empty
            Me.xtxPlaca.Text = Me.xtxPlaca.Text & btn_8.Text
        End If
        If Me.xtxPlaca.TextLength = 7 Then
            Me.longitud.Text = String.Empty
            btmAceptar.Enabled = True
        End If

    End Sub

    Private Sub btn_9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_9.Click
        If Me.xtxPlaca.TextLength > 7 Then
            Me.longitud.Text = "El numero de placa no puede ser mayor de 7"
            Me.longitud.ForeColor = Color.Red
            Me.longitud.Visible = True
        Else
            Me.longitud.Text = String.Empty
            Me.xtxPlaca.Text = Me.xtxPlaca.Text & btn_9.Text
        End If
        If Me.xtxPlaca.TextLength = 7 Then
            Me.longitud.Text = String.Empty
            btmAceptar.Enabled = True
        End If

    End Sub

    Private Sub btn_0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_0.Click
        If Me.xtxPlaca.TextLength > 7 Then
            Me.longitud.Text = "El numero de placa no puede ser mayor de 7"
            Me.longitud.ForeColor = Color.Red
            Me.longitud.Visible = True
        Else
            Me.longitud.Text = String.Empty
            Me.xtxPlaca.Text = Me.xtxPlaca.Text & btn_0.Text
        End If
        If Me.xtxPlaca.TextLength = 7 Then
            Me.longitud.Text = String.Empty
            btmAceptar.Enabled = True
        End If

    End Sub

    Private Sub btn_a_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_a.Click
        If Me.xtxPlaca.TextLength > 7 Then
            Me.longitud.Text = "El numero de placa no puede ser mayor de 7"
            Me.longitud.ForeColor = Color.Red
            Me.longitud.Visible = True
        Else
            Me.longitud.Text = String.Empty
            Me.xtxPlaca.Text = Me.xtxPlaca.Text & btn_a.Text
        End If
        If Me.xtxPlaca.TextLength = 7 Then
            Me.longitud.Text = String.Empty
            btmAceptar.Enabled = True
        End If

    End Sub

    Private Sub btn_e_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_e.Click
        If Me.xtxPlaca.TextLength > 7 Then
            Me.longitud.Text = "El numero de placa no puede ser mayor de 7"
            Me.longitud.ForeColor = Color.Red
            Me.longitud.Visible = True
        Else
            Me.longitud.Text = String.Empty
            Me.xtxPlaca.Text = Me.xtxPlaca.Text & btn_e.Text
        End If
        If Me.xtxPlaca.TextLength = 7 Then
            Me.longitud.Text = String.Empty
            btmAceptar.Enabled = True
        End If

    End Sub

    Private Sub btn_g_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_g.Click
        If Me.xtxPlaca.TextLength > 7 Then
            Me.longitud.Text = "El numero de placa no puede ser mayor de 7"
            Me.longitud.ForeColor = Color.Red
            Me.longitud.Visible = True
        Else
            Me.longitud.Text = String.Empty
            Me.xtxPlaca.Text = Me.xtxPlaca.Text & btn_g.Text
        End If
        If Me.xtxPlaca.TextLength = 7 Then
            Me.longitud.Text = String.Empty
            btmAceptar.Enabled = True
        End If

    End Sub

    Private Sub btn_i_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_i.Click
        If Me.xtxPlaca.TextLength > 7 Then
            Me.longitud.Text = "El numero de placa no puede ser mayor de 7"
            Me.longitud.ForeColor = Color.Red
            Me.longitud.Visible = True
        Else
            Me.longitud.Text = String.Empty
            Me.xtxPlaca.Text = Me.xtxPlaca.Text & btn_i.Text
        End If
        If Me.xtxPlaca.TextLength = 7 Then
            Me.longitud.Text = String.Empty
            btmAceptar.Enabled = True
        End If

    End Sub

    Private Sub btn_l_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_l.Click
        If Me.xtxPlaca.TextLength > 7 Then
            Me.longitud.Text = "El numero de placa no puede ser mayor de 7"
            Me.longitud.ForeColor = Color.Red
            Me.longitud.Visible = True
        Else
            Me.longitud.Text = String.Empty
            Me.xtxPlaca.Text = Me.xtxPlaca.Text & btn_l.Text
        End If
        If Me.xtxPlaca.TextLength = 7 Then
            Me.longitud.Text = String.Empty
            btmAceptar.Enabled = True
        End If

    End Sub

    Private Sub btn_d_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_d.Click
        If Me.xtxPlaca.TextLength > 7 Then
            Me.longitud.Text = "El numero de placa no puede ser mayor de 7"
            Me.longitud.ForeColor = Color.Red
            Me.longitud.Visible = True
        Else
            Me.longitud.Text = String.Empty
            Me.xtxPlaca.Text = Me.xtxPlaca.Text & btn_d.Text
        End If
        If Me.xtxPlaca.TextLength = 7 Then
            Me.longitud.Text = String.Empty
            btmAceptar.Enabled = True
        End If

    End Sub

    Private Sub btn_m_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_m.Click
        If Me.xtxPlaca.TextLength > 7 Then
            Me.longitud.Text = "El numero de placa no puede ser mayor de 7"
            Me.longitud.ForeColor = Color.Red
            Me.longitud.Visible = True
        Else
            Me.longitud.Text = String.Empty
            Me.xtxPlaca.Text = Me.xtxPlaca.Text & btn_m.Text
        End If
        If Me.xtxPlaca.TextLength = 7 Then
            Me.longitud.Text = String.Empty
            btmAceptar.Enabled = True
        End If

    End Sub

    Private Sub btn_o_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_o.Click
        If Me.xtxPlaca.TextLength > 7 Then
            Me.longitud.Text = "El numero de placa no puede ser mayor de 7"
            Me.longitud.ForeColor = Color.Red
            Me.longitud.Visible = True
        Else
            Me.longitud.Text = String.Empty
            Me.xtxPlaca.Text = Me.xtxPlaca.Text & btn_o.Text
        End If
        If Me.xtxPlaca.TextLength = 7 Then
            Me.longitud.Text = String.Empty
            btmAceptar.Enabled = True
        End If

    End Sub

    Private Sub btn_f_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_f.Click
        If Me.xtxPlaca.TextLength > 7 Then
            Me.longitud.Text = "El numero de placa no puede ser mayor de 7"
            Me.longitud.ForeColor = Color.Red
            Me.longitud.Visible = True
        Else
            Me.longitud.Text = String.Empty
            Me.xtxPlaca.Text = Me.xtxPlaca.Text & btn_f.Text
        End If
        If Me.xtxPlaca.TextLength = 7 Then
            Me.longitud.Text = String.Empty
            btmAceptar.Enabled = True
        End If

    End Sub

    Private Sub btn_p_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_p.Click
        If Me.xtxPlaca.TextLength > 7 Then
            Me.longitud.Text = "El numero de placa no puede ser mayor de 7"
            Me.longitud.ForeColor = Color.Red
            Me.longitud.Visible = True
        Else
            Me.longitud.Text = String.Empty
            Me.xtxPlaca.Text = Me.xtxPlaca.Text & btn_p.Text
        End If
        If Me.xtxPlaca.TextLength = 7 Then
            Me.longitud.Text = String.Empty
            btmAceptar.Enabled = True
        End If

    End Sub

    Private Sub btn_x_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_x.Click
        If Me.xtxPlaca.TextLength > 7 Then
            Me.longitud.Text = "El numero de placa no puede ser mayor de 7"
            Me.longitud.ForeColor = Color.Red
            Me.longitud.Visible = True
        Else
            Me.longitud.Text = String.Empty
            Me.xtxPlaca.Text = Me.xtxPlaca.Text & btn_x.Text
        End If
        If Me.xtxPlaca.TextLength = 7 Then
            Me.longitud.Text = String.Empty
            btmAceptar.Enabled = True
        End If

    End Sub

    Private Sub btn__Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_.Click
        If Me.xtxPlaca.TextLength > 7 Then
            Me.longitud.Text = "El numero de placa no puede ser mayor de 7"
            Me.longitud.ForeColor = Color.Red
            Me.longitud.Visible = True
        Else
            longitud.Text = ""
            Me.xtxPlaca.Text = Me.xtxPlaca.Text & btn_.Text
        End If
        If Me.xtxPlaca.TextLength = 7 Then
            longitud.Text = ""
            btmAceptar.Enabled = True
        End If

    End Sub

    Private Sub btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn.Click
        If Me.xtxPlaca.TextLength > 7 Then
            Me.longitud.Text = "El numero de placa no puede ser mayor de 7"
            Me.longitud.ForeColor = Color.Red
            Me.longitud.Visible = True
        Else
            longitud.Text = ""
            Me.xtxPlaca.Text = Me.xtxPlaca.Text & btn.Text
        End If
        If Me.xtxPlaca.TextLength = 7 Then
            longitud.Text = ""
            btmAceptar.Enabled = True
        End If

    End Sub

    Private Sub btnPunto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPunto.Click
        If Me.xtxPlaca.TextLength > 7 Then
            Me.longitud.Text = "El numero de placa no puede ser mayor de 7"
            Me.longitud.ForeColor = Color.Red
            Me.longitud.Visible = True
        Else
            Me.xtxPlaca.Text = Me.xtxPlaca.Text & btnPunto.Text
            longitud.Text = ""
        End If
        If Me.xtxPlaca.TextLength = 7 Then
            longitud.Text = ""
            btmAceptar.Enabled = True
        End If

    End Sub

    Private Sub btn_del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_del.Click
        Me.xtxPlaca.Text = String.Empty
        Me.longitud.Text = String.Empty
    End Sub
    Private Sub BuscarGrupoFijo(ByVal iGrupo As Integer)
        Dim x As Integer
        Dim y As Integer
        Dim z As Integer = 1
        Dim oItem As DataTable = LibX.Data.Manager.GetDataTable("select item_code,item_name,price from ivitemv1 where group_code =" & iGrupo & " and item_status =1")

        ''x = 180
        x = 32
        ''y = 141
        y = 65

        Try
            Me.LabelServicios.Visible = True

            radD = New Common.Items

            LabelServicios.Visible = True
            If oItem.Rows.Count > 0 Then
                For i As Integer = 0 To oItem.Rows.Count - 1
                    Dim pBoton As New Button
                    pBoton.Text = Convert.ToString(oItem.Rows(i)!item_name) & "  " & oItem.Rows(i)!price
                    ''pBoton.Name = Convert.ToString(oItem.Rows(i)!item_name)
                    pBoton.Name = oItem.Rows(i)!item_code
                    Me.GroupBox1.Controls.Add(pBoton)

                    With pBoton
                        .Location = New Point(x, y)
                        .Size = New System.Drawing.Size(104, 180)
                        .ForeColor = Color.Black
                        .BackColor = Color.DarkGray
                        .Font = New Font("Microsoft Sans Serif", 15.75)
                        .Size = New Size(625, 77)
                        .TextAlign = ContentAlignment.BottomLeft
                        .TextAlign = ContentAlignment.BottomCenter
                        .TabIndex = z
                    End With

                    z += 1
                    y += 80
                    If i = 12 Then
                        Exit For
                    End If

                    With _oIndex
                        .ControlIndex = pBoton.TabIndex
                        .Nombre = pBoton.Name
                    End With

                    With _addIndex
                        .Addindex(_oIndex.ControlIndex, _oIndex.Nombre)
                    End With

                    AddHandler pBoton.Click, AddressOf ButtonPrdClick
                Next
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
    Public Sub RemoveControl()
        Try
            Dim num_controles As Int32 = GroupBox1.Controls.Count - 1
            For c As Integer = num_controles To 0 Step -1
                Dim ctrl As Windows.Forms.Control = GroupBox1.Controls(c)
                'If ctrl.Text = labSuper.Text Then
                '    ctrl.Name = ""
                'End If
                If Len(ctrl.Text) > 6 And ctrl.Text <> LabelLavadores.Text And ctrl.Name <> Me.LabelServicios.Text And ctrl.Text <> Me.xtxPlaca.Text And ctrl.Text <> labSuper.Text Then
                    Me.GroupBox1.Controls.Remove(ctrl)
                    ctrl.Dispose()
                End If
            Next
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
    Public Sub InativarControles()
        Try
            Dim num_controles As Int32 = Vehiculos.Controls.Count - 1
            For c As Integer = num_controles To 0 Step -1
                Dim ctrl As Windows.Forms.Control = Vehiculos.Controls(c)
                If Len(ctrl.Text) > 6 And ctrl.Name <> _btnAgregar.Name Then
                    ctrl.Enabled = False
                End If
            Next
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
    Public Sub AnativarControles()
        Try
            Dim num_controles As Int32 = Vehiculos.Controls.Count - 1
            For c As Integer = num_controles To 0 Step -1
                Dim ctrl As Windows.Forms.Control = Vehiculos.Controls(c)
                If ctrl.Name <> _btnAgregar.Name Then
                    ctrl.Enabled = True
                End If
            Next
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
    Private Sub BuscarLavadores()
        Dim x As Integer
        Dim y As Integer
        Dim j As Integer

        Dim oLavador As DataTable = LibX.Data.Manager.GetDataTable("select vend_code,vend_name from ftvendm where vend_cargo =2")
        Try
            x = 32
            y = 65

            Me.LabelLavadores.Visible = True
            If oLavador.Rows.Count > 0 Then

                For i As Integer = 0 To oLavador.Rows.Count - 1
                    Dim pBotonl As New Button

                    pBotonl.Text = oLavador.Rows(i)!vend_code & " " & oLavador.Rows(i)!vend_name
                    pBotonl.Name = Convert.ToString(oLavador.Rows(i)!vend_code)
                    Me.GroupBox1.Controls.Add(pBotonl)

                    Dim oVendOcupado As Integer = LibX.Data.Manager.GetScalar("select ftfactm.vend_code from ftfactm where vend_code = " & oLavador.Rows(i)!vend_code & _
                                                                                                                                "and ftfactm.fact_status = 1")
                    With pBotonl
                        .Location = New Point(x, y)
                        .Size = New System.Drawing.Size(96, 48)
                        If oVendOcupado > 0 Then
                            .ForeColor = Color.Black
                            .BackColor = Color.Red
                            ''.Enabled = False
                        Else
                            .ForeColor = Color.Black
                            .BackColor = Color.DarkGray
                        End If
                        .Font = New Font("Microsoft Sans Serif", 26)
                        .Size = New Size(110, 96)
                        .TextAlign = ContentAlignment.BottomCenter
                    End With

                    x += 112
                    j = j + 1
                    If j = 6 Then
                        j = 0
                        y = y + 100
                        x = 32
                    End If

                    With _oIndex
                        .ControlIndex = pBotonl.TabIndex
                        .Nombre = pBotonl.Name
                    End With

                    With _addIndex
                        .Addindex(_oIndex.ControlIndex, _oIndex.Nombre)
                    End With

                    AddHandler pBotonl.Click, AddressOf ButtonLabClick
                Next
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
    Private Sub BuscarSupervisor()
        Dim x As Integer
        Dim y As Integer
        Dim j As Integer

        Dim oSupervisor As DataTable = LibX.Data.Manager.GetDataTable("select vend_code,vend_name from ftvendm where vend_cargo =4")
        Try
            x = 32
            y = 65

            Me.labSuper.Visible = True
            If oSupervisor.Rows.Count > 0 Then

                For i As Integer = 0 To oSupervisor.Rows.Count - 1
                    Dim pBotonl As New Button

                    pBotonl.Text = oSupervisor.Rows(i)!vend_code & " " & oSupervisor.Rows(i)!vend_name
                    pBotonl.Name = Convert.ToString(oSupervisor.Rows(i)!vend_code)
                    Me.GroupBox1.Controls.Add(pBotonl)

                    With pBotonl
                        .Location = New Point(x, y)
                        .Size = New System.Drawing.Size(96, 48)
                        .ForeColor = Color.Black
                        .BackColor = Color.DarkGray
                        .Font = New Font("Microsoft Sans Serif", 26)
                        .Size = New Size(110, 96)
                        .TextAlign = ContentAlignment.BottomCenter
                    End With

                    x += 112
                    j = j + 1
                    If j = 6 Then
                        j = 0
                        y = y + 100
                        x = 32
                    End If

                    With _oIndex
                        .ControlIndex = pBotonl.TabIndex
                        .Nombre = pBotonl.Name
                    End With

                    With _addIndex
                        .Addindex(_oIndex.ControlIndex, _oIndex.Nombre)
                    End With

                    AddHandler pBotonl.Click, AddressOf ButtonSupClick
                Next
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
    Private Sub ButtonPrdClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim pBotonl As Button = DirectCast(sender, Button)
            Console.WriteLine(pBotonl.Text)
            Console.WriteLine(pBotonl.TabIndex)
            pBotonl.Enabled = False
            btnSig.Enabled = True

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
    Public Sub AgregarProductos()
        Try
            Dim num_controles As Int32 = GroupBox1.Controls.Count - 1
            For c As Integer = num_controles To 0 Step -1
                Dim ctrl As Windows.Forms.Control = GroupBox1.Controls(c)
                If ctrl.Enabled = False Then
                    cItem = sItem(ctrl.Name)
                    If cItem <> "" Then
                        Dim ItemRow As DataRow = LibX.Data.Manager.GetDataRow("select unit_code,item_code,whse_code,1 as qty,price,0 as dscto,1 as factor,0 as itbis,purch_cost,null as ind,1 suc_code " & _
                                                                              " from ivitemv1 where item_code = '" & cItem & "' and item_status = 1 and whse_code = 1")
                        Dim addD As New Common.ItemDetail
                        With addD
                            .ItemID = ItemRow!item_code
                            .iwhse = 1 ''ItemRow!whse_code
                            .iUnit = ItemRow!unit_code
                            .iQty = 1
                            .iDscto = 0
                            .iFactor = 1
                            .iInd = 0
                            .iItbis = 0
                            .iLIne = 1
                            .iSerial = 0
                            .ValorPrice = ItemRow!price
                            .iCost = ItemRow!purch_cost
                        End With
                        With radD
                            .AddDatail(addD)
                        End With
                        cItem = String.Empty
                    End If
                End If
            Next
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
    Function sItem(ByVal rItem As String) As String
        Dim itemD As String
        If Len(rItem) = 6 Then
            itemD = rItem
        End If
        If Len(rItem) = 5 Then
            itemD = "0" & rItem
        End If
        If Len(rItem) = 4 Then
            itemD = "00" & rItem
        End If
        If Len(rItem) = 3 Then
            itemD = "000" & rItem
        End If
        If Len(rItem) = 2 Then
            itemD = "0000" & rItem
        End If
        If Len(rItem) = 1 Then
            itemD = "00000" & rItem
        End If
        Return itemD
    End Function

    Private Sub ButtonLabClick(ByVal sender As System.Object, ByVal e As System.EventArgs)

        ' Referenciamos el control TextBox que ha desencadenado el evento
        '
        Dim pBoton As Button = DirectCast(sender, Button)
        Console.WriteLine(pBoton.Text)
        Console.WriteLine(pBoton.TabIndex)

        oVend = CInt(pBoton.Name)
        pBoton.Enabled = False
        RemoveControl()
        LabelLavadores.Visible = False
        ''Activar_botones()
        BuscarSupervisor()
        Me.labSuper.Visible = True
    End Sub
    Private Sub ButtonSupClick(ByVal sender As System.Object, ByVal e As System.EventArgs)

        ' Referenciamos el control TextBox que ha desencadenado el evento
        '
        Dim pBoton As Button = DirectCast(sender, Button)
        Console.WriteLine(pBoton.Text)
        Console.WriteLine(pBoton.TabIndex)

        oSuper = CInt(pBoton.Name)
        pBoton.Enabled = False
        RemoveControl()
        labSuper.Visible = False
        Activar_botones()

    End Sub
    Private Sub btmAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btmAceptar.Click
        Dim oParametroNCF As SGT.Facturacion.Entidades.ParametrosCreditoFiscal
        Dim blnSuccess As Boolean = False
        Dim SelecStmt As String
        Dim WhereStmt As String
        Dim mNumero As Integer
        Dim cIASerial As Integer
        Dim AxCrystalReport1 As LibX.ReportLib

        Try
            Dim dExiste = LibX.Data.Manager.GetScalar("select count(*) from ftfactm where phone = '" & xtxPlaca.Text & "' and fact_status = 1")
            If dExiste > 0 Then
                Throw New ApplicationException("Esxiste una factura en espera con esta placa, verifique!")
            End If
            If Me.xtxPlaca.Text <> "" Then
                GuardarFactura()
                '// Tomar el Connection String del config
                AxCrystalReport1 = New LibX.ReportLib("PTV", "r_pvlavado01.rpt")
                WhereStmt = String.Concat("ftfactm.ftserial_no = " & fSerial)

                With AxCrystalReport1
                    '// Recibir el SQL Query
                    .RetrieveSQLQuery()
                    SelecStmt = .SQLQuery
                    SelecStmt = LibX.MdlUtil.ReplaceWherePart(SelecStmt, WhereStmt)
                    .SQLQuery = SelecStmt

                    '// Ejecutar el reporte
                    .Copias = 0
                    ''.Destination = Crystal.DestinationConstants.crptToPrinter '// Imprimir Directo
                    .Action = 1
                End With

                '// refrescar
                ''LibXConnector1.ExecuteFind("ftfactm.ftserial_no = " & fSerial)
            Else
                Throw New ApplicationException("Debe indicar las informaciones de la factura")
            End If

            Desactivar_botones()
            AnativarControles()
            fSerial = 0

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub
    Private Sub GuardarFactura()
        Dim sTotal As Decimal
        Dim XInsert As LibX.Data.XInsertStmt
        Dim XUpdate As LibX.Data.XUpdateStmt
        Dim lineNo As Integer
        Try
            If Len(Me.xtxPlaca.Text) = 7 Then

                If LibX.Data.Manager.Connection.IsIntransaction = False Then
                    LibX.Data.Manager.Connection.BeginTransaction()
                End If

                XInsert = New LibX.Data.XInsertStmt("ftfactm", "ftserial_no")

                XInsert.Fields("whse_code") = 1
                XInsert.Fields("dev_type") = Nothing
                XInsert.Fields("cotiz_serial") = Nothing
                XInsert.Fields("term_code") = Nothing
                XInsert.Fields("addr_code") = 5
                XInsert.Fields("vend_code") = oVend
                XInsert.Fields("fact_number") = Nothing
                XInsert.Fields("fact_date") = oCajaAbierta.Fecha
                XInsert.Fields("fact_total") = 0
                XInsert.Fields("descto") = 0
                XInsert.Fields("itbis") = 0
                XInsert.Fields("userid") = oSuper '' LibX.User.UserID
                XInsert.Fields("fact_status") = 1
                XInsert.Fields("date_created") = LibX.Data.Manager.Connection.GetDate
                XInsert.Fields("type_code") = "FPV"
                XInsert.Fields("cust_code") = Nothing
                XInsert.Fields("fact_cond") = 1
                XInsert.Fields("bus_name") = Me.xtxPlaca.Text
                XInsert.Fields("fact_nota") = Nothing
                XInsert.Fields("ftserial_afect") = Nothing
                XInsert.Fields("pay_adelant") = Nothing
                XInsert.Fields("phone") = xtxPlaca.Text
                XInsert.Fields("pay_mora") = Nothing
                XInsert.Fields("porc_comision") = Nothing
                XInsert.Fields("caja_code") = oCajaAbierta.CajaCode
                XInsert.Fields("caje_code") = LibX.Data.Manager.GetScalar("select vend_code from cjinitm where init_serial=" & oCajaAbierta.Serial)
                XInsert.Fields("init_serial") = oCajaAbierta.Serial
                XInsert.Fields("fact_inddomicilio") = 0
                XInsert.Fields("address") = Nothing
                XInsert.Fields("seg_amount") = Nothing
                XInsert.Fields("prov_code") = Nothing
                XInsert.Fields("fact_impresa") = 0
                XInsert.Fields("fact_ncf") = Nothing
                XInsert.Fields("cust_serial") = Nothing
                XInsert.Fields("fact_time") = DateTime.Now.ToShortTimeString()
                XInsert.Fields("suc_code") = 1 ''LibX.User.Sucursal
                XInsert.Fields("fact_create") = LibX.Data.Manager.Connection.GetDate
                LibX.Data.Manager.LastSerialValue = XInsert.Execute()

                fSerial = LibX.Data.Manager.LastSerialValue


                For Each oItem As Common.ItemDetail In radD
                    lineNo += 1
                    XInsert = New LibX.Data.XInsertStmt("ftfactd")
                    XInsert.Fields("ftserial_no") = fSerial
                    XInsert.Fields("line_no") = lineNo
                    XInsert.Fields("unit_code") = oItem.iUnit
                    XInsert.Fields("item_code") = oItem.ItemID
                    XInsert.Fields("whse_code") = oItem.iwhse
                    XInsert.Fields("qty") = 1
                    XInsert.Fields("price") = oItem.ValorPrice
                    XInsert.Fields("dscto") = 0
                    XInsert.Fields("factor") = 1
                    XInsert.Fields("itbis") = 0
                    XInsert.Fields("costo") = oItem.iCost
                    XInsert.Fields("ind_cobertura") = Nothing
                    XInsert.Fields("suc_code") = 1 ''LibX.User.Sucursal
                    XInsert.Execute()
                    sTotal = sTotal + oItem.ValorPrice
                Next

                XUpdate = New LibX.Data.XUpdateStmt("ftfactm")
                XUpdate.FieldsSet("fact_total") = sTotal
                XUpdate.Fields("ftserial_no") = fSerial
                XUpdate.Execute()

                If LibX.Data.Manager.Connection.IsIntransaction = True Then
                    LibX.Data.Manager.Connection.CommitTransaction()
                End If
            End If
        Catch ex As Exception
            LibX.Log.Show(ex, True)
            If LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.RollBackTransaction()
            End If
        End Try
    End Sub

    Private Sub btnSig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSig.Click
        AgregarProductos()
        RemoveControl()
        InativarControles()
        Me.GroupBox1.Visible = True
        Me.LabelServicios.Visible = False
        BuscarLavadores()
        Me.LabelLavadores.Visible = True
        Me.btnSig.Visible = False
    End Sub

    Private Sub btmCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btmCancelar.Click
        RemoveControl()
        Desactivar_botones()
        AnativarControles()
        btmAceptar.BackColor = System.Drawing.SystemColors.InactiveCaption
    End Sub

    Private Sub xtxPlaca_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xtxPlaca.TextChanged
        If Len(xtxPlaca.Text) = 7 Then
            Me.longitud.Text = String.Empty
            btmAceptar.Enabled = True
            btmAceptar.BackColor = Color.Red
        Else
            btmAceptar.Enabled = False
            btmAceptar.BackColor = System.Drawing.SystemColors.InactiveCaption
        End If
    End Sub
End Class
