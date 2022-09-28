Public Class i_iventr01
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
    'Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents LibXNavigator1 As LibX.LibXNavigator
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextBox17 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBox18 As System.Windows.Forms.TextBox
    Friend WithEvents LibXCombo1 As LibX.LibXCombo
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents LibXGrid1 As LibX.LibXGrid
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents LibXLookup1 As LibX.LibXLookup
    Friend WithEvents LibXLookup2 As LibX.LibXLookup
    Friend WithEvents LibXLookup3 As LibX.LibXLookup
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox19 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TextBox20 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents XdataGridTableStyle1 As LibX.XdataGridTableStyle
    Friend WithEvents XEditTextBoxColumn2 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn3 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn4 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn5 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn6 As LibX.XEditTextBoxColumn
    Friend WithEvents XDataGridBoolColumn1 As LibX.XDataGridBoolColumn
    Friend WithEvents XEditTextBoxColumn7 As LibX.XEditTextBoxColumn
    Friend WithEvents XDataGridLinkColumn1 As LibX.XDataGridLinkColumn
    Friend WithEvents XEditTextBoxColumn1 As LibX.XEditTextBoxColumn
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.LibXNavigator1 = New LibX.LibXNavigator
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LibXLookup3 = New LibX.LibXLookup
        Me.LibXLookup2 = New LibX.LibXLookup
        Me.LibXLookup1 = New LibX.LibXLookup
        Me.LibXCombo1 = New LibX.LibXCombo
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.TextBox8 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TextBox9 = New System.Windows.Forms.TextBox
        Me.TextBox16 = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.TextBox17 = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.TextBox18 = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBox19 = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.TextBox20 = New System.Windows.Forms.TextBox
        Me.TextBox10 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.LibXGrid1 = New LibX.LibXGrid
        Me.XdataGridTableStyle1 = New LibX.XdataGridTableStyle
        Me.XDataGridLinkColumn1 = New LibX.XDataGridLinkColumn
        Me.XEditTextBoxColumn2 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn3 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn4 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn5 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn6 = New LibX.XEditTextBoxColumn
        Me.XDataGridBoolColumn1 = New LibX.XDataGridBoolColumn
        Me.XEditTextBoxColumn7 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn1 = New LibX.XEditTextBoxColumn
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LibXNavigator1
        '
        Me.LibXNavigator1.BuildMenu = True
        'Me.LibXNavigator1.Connector = Nothing
        Me.LibXNavigator1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LibXNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.LibXNavigator1.Name = "LibXNavigator1"
        Me.LibXNavigator1.Size = New System.Drawing.Size(786, 24)
        Me.LibXNavigator1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LibXLookup3)
        Me.GroupBox1.Controls.Add(Me.LibXLookup2)
        Me.GroupBox1.Controls.Add(Me.LibXLookup1)
        Me.GroupBox1.Controls.Add(Me.LibXCombo1)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox7)
        Me.GroupBox1.Controls.Add(Me.TextBox8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TextBox9)
        Me.GroupBox1.Controls.Add(Me.TextBox16)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.TextBox17)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.TextBox18)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox19)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.TextBox20)
        Me.GroupBox1.Controls.Add(Me.TextBox10)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(768, 152)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'LibXLookup3
        '
        Me.LibXLookup3.DataMember = Nothing
        Me.LibXLookup3.DataSource = Nothing
        Me.LibXLookup3.DestParameters = Nothing
        Me.LibXLookup3.Location = New System.Drawing.Point(368, 112)
        Me.LibXLookup3.LookCaption = Nothing
        Me.LibXLookup3.Name = "LibXLookup3"
        Me.LibXLookup3.Size = New System.Drawing.Size(16, 16)
        Me.LibXLookup3.SqlString = Nothing
        Me.LibXLookup3.SrcParameters = Nothing
        Me.LibXLookup3.TabIndex = 14
        Me.LibXLookup3.TableName = Nothing
        Me.LibXLookup3.UseCopyConnection = False
        Me.LibXLookup3.UseRowRetrieveEvents = False
        Me.LibXLookup3.VisParameters = Nothing
        Me.LibXLookup3.WhereCondition = Nothing
        '
        'LibXLookup2
        '
        Me.LibXLookup2.DataMember = Nothing
        Me.LibXLookup2.DataSource = Nothing
        Me.LibXLookup2.DestParameters = Nothing
        Me.LibXLookup2.Location = New System.Drawing.Point(368, 88)
        Me.LibXLookup2.LookCaption = Nothing
        Me.LibXLookup2.Name = "LibXLookup2"
        Me.LibXLookup2.Size = New System.Drawing.Size(16, 16)
        Me.LibXLookup2.SqlString = Nothing
        Me.LibXLookup2.SrcParameters = Nothing
        Me.LibXLookup2.TabIndex = 13
        Me.LibXLookup2.TableName = Nothing
        Me.LibXLookup2.UseCopyConnection = False
        Me.LibXLookup2.UseRowRetrieveEvents = False
        Me.LibXLookup2.VisParameters = Nothing
        Me.LibXLookup2.WhereCondition = Nothing
        '
        'LibXLookup1
        '
        Me.LibXLookup1.DataMember = Nothing
        Me.LibXLookup1.DataSource = Nothing
        Me.LibXLookup1.DestParameters = Nothing
        Me.LibXLookup1.Location = New System.Drawing.Point(368, 64)
        Me.LibXLookup1.LookCaption = Nothing
        Me.LibXLookup1.Name = "LibXLookup1"
        Me.LibXLookup1.Size = New System.Drawing.Size(16, 16)
        Me.LibXLookup1.SqlString = Nothing
        Me.LibXLookup1.SrcParameters = Nothing
        Me.LibXLookup1.TabIndex = 12
        Me.LibXLookup1.TableName = Nothing
        Me.LibXLookup1.UseCopyConnection = False
        Me.LibXLookup1.UseRowRetrieveEvents = False
        Me.LibXLookup1.VisParameters = Nothing
        Me.LibXLookup1.WhereCondition = Nothing
        '
        'LibXCombo1
        '
        Me.LibXCombo1.AllowDefaultSort = True
        Me.LibXCombo1.bound = True
        Me.LibXCombo1.currValue = Nothing
        Me.LibXCombo1.DefaultWhereString = Nothing
        Me.LibXCombo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LibXCombo1.Location = New System.Drawing.Point(264, 16)
        Me.LibXCombo1.LookupKeyDisplayFields = Nothing
        Me.LibXCombo1.LookupKeyField = Nothing
        Me.LibXCombo1.LookupTableName = Nothing
        Me.LibXCombo1.Name = "LibXCombo1"
        Me.LibXCombo1.Required = False
        Me.LibXCombo1.Size = New System.Drawing.Size(104, 21)
        Me.LibXCombo1.SqlString = Nothing
        Me.LibXCombo1.TabIndex = 11
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(144, 64)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(224, 20)
        Me.TextBox6.TabIndex = 10
        Me.TextBox6.Text = ""
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(80, 88)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(56, 20)
        Me.TextBox5.TabIndex = 9
        Me.TextBox5.Text = ""
        '
        'Label5
        '
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(16, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Almacen"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(80, 64)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(56, 20)
        Me.TextBox4.TabIndex = 7
        Me.TextBox4.Text = ""
        '
        'Label4
        '
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(16, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Moneda:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(80, 16)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = ""
        '
        'Label1
        '
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Factura No."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(144, 88)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(224, 20)
        Me.TextBox7.TabIndex = 10
        Me.TextBox7.Text = ""
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(80, 112)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(56, 20)
        Me.TextBox8.TabIndex = 9
        Me.TextBox8.Text = ""
        '
        'Label6
        '
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(16, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 16)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Suplidor:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(144, 112)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.ReadOnly = True
        Me.TextBox9.Size = New System.Drawing.Size(224, 20)
        Me.TextBox9.TabIndex = 10
        Me.TextBox9.Text = ""
        '
        'TextBox16
        '
        Me.TextBox16.Location = New System.Drawing.Point(80, 40)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.TabIndex = 1
        Me.TextBox16.Text = ""
        '
        'Label10
        '
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label10.Location = New System.Drawing.Point(56, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(16, 16)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Fecha:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label11
        '
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label11.Location = New System.Drawing.Point(608, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 16)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Usuario:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox17
        '
        Me.TextBox17.Location = New System.Drawing.Point(656, 16)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.ReadOnly = True
        Me.TextBox17.TabIndex = 1
        Me.TextBox17.Text = ""
        '
        'Label12
        '
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label12.Location = New System.Drawing.Point(608, 40)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 16)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Creado:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox18
        '
        Me.TextBox18.Location = New System.Drawing.Point(656, 40)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.ReadOnly = True
        Me.TextBox18.TabIndex = 1
        Me.TextBox18.Text = ""
        '
        'Label13
        '
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label13.Location = New System.Drawing.Point(208, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 16)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Estatus:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(416, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Monto Bruto:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(504, 16)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Text = ""
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(504, 40)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.TabIndex = 1
        Me.TextBox3.Text = ""
        '
        'Label3
        '
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(448, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "% FOB"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox19
        '
        Me.TextBox19.Location = New System.Drawing.Point(504, 64)
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.TabIndex = 1
        Me.TextBox19.Text = ""
        '
        'Label14
        '
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label14.Location = New System.Drawing.Point(392, 64)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(104, 16)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "% Gastos Generales:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label15
        '
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label15.Location = New System.Drawing.Point(400, 88)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(96, 16)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Gastos Aduanales:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox20
        '
        Me.TextBox20.Location = New System.Drawing.Point(504, 88)
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.TabIndex = 1
        Me.TextBox20.Text = ""
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(504, 112)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.ReadOnly = True
        Me.TextBox10.TabIndex = 1
        Me.TextBox10.Text = ""
        '
        'Label7
        '
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Location = New System.Drawing.Point(400, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Total Neto:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LibXGrid1
        '
        Me.LibXGrid1.AutoSearch = False
        Me.LibXGrid1.CaptionText = "Almacenes"
        Me.LibXGrid1.DataMember = "iventrdd"
        Me.LibXGrid1.FullRowSelect = False
        Me.LibXGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGrid1.IsReadOnly = False
        Me.LibXGrid1.Location = New System.Drawing.Point(8, 192)
        Me.LibXGrid1.Name = "LibXGrid1"
        Me.LibXGrid1.ReadOnly = True
        Me.LibXGrid1.showFooterBar = True
        Me.LibXGrid1.Size = New System.Drawing.Size(768, 200)
        Me.LibXGrid1.TabIndex = 2
        Me.LibXGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.XdataGridTableStyle1})
        Me.LibXGrid1.UseAutoFillLines = True
        '
        'XdataGridTableStyle1
        '
        Me.XdataGridTableStyle1.DataGrid = Me.LibXGrid1
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.XDataGridLinkColumn1, Me.XEditTextBoxColumn2, Me.XEditTextBoxColumn3, Me.XEditTextBoxColumn4, Me.XEditTextBoxColumn5, Me.XEditTextBoxColumn6, Me.XDataGridBoolColumn1, Me.XEditTextBoxColumn7, Me.XEditTextBoxColumn1})
        Me.XdataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle1.MappingName = "iventrdd"
        '
        'XDataGridLinkColumn1
        '
        Me.XDataGridLinkColumn1.Format = ""
        Me.XDataGridLinkColumn1.FormatInfo = Nothing
        Me.XDataGridLinkColumn1.HeaderText = "Articulo"
        Me.XDataGridLinkColumn1.ImageList = Nothing
        Me.XDataGridLinkColumn1.isReadOnly = False
        Me.XDataGridLinkColumn1.MappingName = "item_code"
        Me.XDataGridLinkColumn1.UseCustomCellFormat = False
        Me.XDataGridLinkColumn1.Width = 75
        '
        'XEditTextBoxColumn2
        '
        Me.XEditTextBoxColumn2.Format = ""
        Me.XEditTextBoxColumn2.FormatInfo = Nothing
        Me.XEditTextBoxColumn2.HeaderText = "Descripción"
        Me.XEditTextBoxColumn2.ImageList = Nothing
        Me.XEditTextBoxColumn2.isReadOnly = False
        Me.XEditTextBoxColumn2.MappingName = "item_name"
        Me.XEditTextBoxColumn2.UseCustomCellFormat = False
        Me.XEditTextBoxColumn2.Width = 150
        '
        'XEditTextBoxColumn3
        '
        Me.XEditTextBoxColumn3.Format = ""
        Me.XEditTextBoxColumn3.FormatInfo = Nothing
        Me.XEditTextBoxColumn3.HeaderText = "Almacén"
        Me.XEditTextBoxColumn3.ImageList = Nothing
        Me.XEditTextBoxColumn3.isReadOnly = False
        Me.XEditTextBoxColumn3.MappingName = "whse_code"
        Me.XEditTextBoxColumn3.UseCustomCellFormat = False
        Me.XEditTextBoxColumn3.Width = 50
        '
        'XEditTextBoxColumn4
        '
        Me.XEditTextBoxColumn4.Format = ""
        Me.XEditTextBoxColumn4.FormatInfo = Nothing
        Me.XEditTextBoxColumn4.HeaderText = "Unidad"
        Me.XEditTextBoxColumn4.ImageList = Nothing
        Me.XEditTextBoxColumn4.isReadOnly = False
        Me.XEditTextBoxColumn4.MappingName = "unit_code"
        Me.XEditTextBoxColumn4.UseCustomCellFormat = False
        Me.XEditTextBoxColumn4.Width = 75
        '
        'XEditTextBoxColumn5
        '
        Me.XEditTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.XEditTextBoxColumn5.Format = ""
        Me.XEditTextBoxColumn5.FormatInfo = Nothing
        Me.XEditTextBoxColumn5.HeaderText = "Cantidad"
        Me.XEditTextBoxColumn5.ImageList = Nothing
        Me.XEditTextBoxColumn5.isReadOnly = False
        Me.XEditTextBoxColumn5.MappingName = "qty"
        Me.XEditTextBoxColumn5.UseCustomCellFormat = False
        Me.XEditTextBoxColumn5.Width = 75
        '
        'XEditTextBoxColumn6
        '
        Me.XEditTextBoxColumn6.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.XEditTextBoxColumn6.Format = ""
        Me.XEditTextBoxColumn6.FormatInfo = Nothing
        Me.XEditTextBoxColumn6.HeaderText = "Costo"
        Me.XEditTextBoxColumn6.ImageList = Nothing
        Me.XEditTextBoxColumn6.isReadOnly = False
        Me.XEditTextBoxColumn6.MappingName = "costo"
        Me.XEditTextBoxColumn6.UseCustomCellFormat = False
        Me.XEditTextBoxColumn6.Width = 75
        '
        'XDataGridBoolColumn1
        '
        Me.XDataGridBoolColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.XDataGridBoolColumn1.FalseValue = CType(0, Short)
        Me.XDataGridBoolColumn1.HeaderText = "Impuestos"
        Me.XDataGridBoolColumn1.MappingName = "impto"
        Me.XDataGridBoolColumn1.NullValue = 0
        Me.XDataGridBoolColumn1.TrueValue = CType(1, Short)
        Me.XDataGridBoolColumn1.UseCustomCellFormat = False
        Me.XDataGridBoolColumn1.Width = 75
        '
        'XEditTextBoxColumn7
        '
        Me.XEditTextBoxColumn7.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.XEditTextBoxColumn7.Format = ""
        Me.XEditTextBoxColumn7.FormatInfo = Nothing
        Me.XEditTextBoxColumn7.HeaderText = "Precio"
        Me.XEditTextBoxColumn7.ImageList = Nothing
        Me.XEditTextBoxColumn7.isReadOnly = False
        Me.XEditTextBoxColumn7.MappingName = "price"
        Me.XEditTextBoxColumn7.UseCustomCellFormat = False
        Me.XEditTextBoxColumn7.Width = 75
        '
        'XEditTextBoxColumn1
        '
        Me.XEditTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.XEditTextBoxColumn1.Format = ""
        Me.XEditTextBoxColumn1.FormatInfo = Nothing
        Me.XEditTextBoxColumn1.HeaderText = "Importe"
        Me.XEditTextBoxColumn1.ImageList = Nothing
        Me.XEditTextBoxColumn1.isReadOnly = False
        Me.XEditTextBoxColumn1.MappingName = "importe"
        Me.XEditTextBoxColumn1.UseCustomCellFormat = False
        Me.XEditTextBoxColumn1.Width = 75
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button1.Location = New System.Drawing.Point(88, 424)
        Me.Button1.Name = "Button1"
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "&Grupos"
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button2.Location = New System.Drawing.Point(8, 424)
        Me.Button2.Name = "Button2"
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "&Almacen"
        '
        'Button3
        '
        Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button3.Location = New System.Drawing.Point(168, 424)
        Me.Button3.Name = "Button3"
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "&Subgrupos"
        '
        'Button4
        '
        Me.Button4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button4.Location = New System.Drawing.Point(248, 424)
        Me.Button4.Name = "Button4"
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "&Marcas"
        '
        'Button5
        '
        Me.Button5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button5.Location = New System.Drawing.Point(328, 424)
        Me.Button5.Name = "Button5"
        Me.Button5.TabIndex = 3
        Me.Button5.Text = "&Unidades"
        '
        'Button6
        '
        Me.Button6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button6.Location = New System.Drawing.Point(408, 424)
        Me.Button6.Name = "Button6"
        Me.Button6.TabIndex = 3
        Me.Button6.Text = "&Beneficio"
        '
        'Button7
        '
        Me.Button7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button7.Location = New System.Drawing.Point(488, 424)
        Me.Button7.Name = "Button7"
        Me.Button7.TabIndex = 3
        Me.Button7.Text = "&Productos"
        '
        'Button8
        '
        Me.Button8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button8.Location = New System.Drawing.Point(568, 424)
        Me.Button8.Name = "Button8"
        Me.Button8.TabIndex = 3
        Me.Button8.Text = "&Totales"
        '
        'i_iventr01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(786, 471)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LibXGrid1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button8)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "i_iventr01"
        Me.Text = "Entrada de Almacén Internacionales"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub TextBox16_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox16.TextChanged

    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click

    End Sub
End Class
