Public Class i_ivtype01
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LibXNavigator1 As LibX.LibXNavigator
    'Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents LibXDbSourceTable2 As LibX.LibXDbSourceTable
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox5 As LibX.LibxCheckBox
    Friend WithEvents CheckBox6 As LibX.LibxCheckBox
    Friend WithEvents CheckBox7 As LibX.LibxCheckBox
    Friend WithEvents CheckBox8 As LibX.LibxCheckBox
    Friend WithEvents LibXGrid1 As LibX.LibXGrid
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents XdataGridTableStyle1 As LibX.XdataGridTableStyle
    Friend WithEvents rbg_debito As System.Windows.Forms.RadioButton
    Friend WithEvents rbg_credito As System.Windows.Forms.RadioButton
    Friend WithEvents rbg_input As System.Windows.Forms.RadioButton
    Friend WithEvents rbg_output As System.Windows.Forms.RadioButton
    Friend WithEvents rbg_price As System.Windows.Forms.RadioButton
    Friend WithEvents rbg_cost As System.Windows.Forms.RadioButton
    Friend WithEvents rdg_local As System.Windows.Forms.RadioButton
    Friend WithEvents rbg_intern As System.Windows.Forms.RadioButton
    Friend WithEvents TextBox4 As LibX.XTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
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
    Friend WithEvents DataColumn22 As System.Data.DataColumn
    Friend WithEvents xck_pay_comm As LibX.LibxCheckBox
    Friend WithEvents DataTable3 As System.Data.DataTable
    Friend WithEvents DataColumn23 As System.Data.DataColumn
    Friend WithEvents DataColumn24 As System.Data.DataColumn
    Friend WithEvents DataColumn25 As System.Data.DataColumn
    Friend WithEvents LibXLookup1 As LibX.LibXLookup
    Friend WithEvents DataColumn18 As System.Data.DataColumn
    Friend WithEvents XDataGridTextButtonColumn1 As LibX.XDataGridTextButtonColumn
    Friend WithEvents XEditTextBoxColumn1 As LibX.XEditTextBoxColumn
    Friend WithEvents DataColumn19 As System.Data.DataColumn
    Friend WithEvents LibXCombo1 As LibX.LibXCombo
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataColumn20 As System.Data.DataColumn
    Friend WithEvents DataColumn21 As System.Data.DataColumn
    Friend WithEvents DataColumn26 As System.Data.DataColumn
    Friend WithEvents LibxCheckBox2 As LibX.LibxCheckBox
    Friend WithEvents DataColumn27 As System.Data.DataColumn
    Friend WithEvents gbx_Origen As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Entrada As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_valor As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Tipo As System.Windows.Forms.GroupBox
    Friend WithEvents DataColumn28 As System.Data.DataColumn
    Friend WithEvents TextBox5 As LibX.XTextBox
    Friend WithEvents DataColumn29 As System.Data.DataColumn
    Friend WithEvents DataColumn30 As System.Data.DataColumn
    Friend WithEvents LibxCheckBox4 As LibX.LibxCheckBox
    Friend WithEvents LibxCheckBox5 As LibX.LibxCheckBox
    Friend WithEvents DataColumn31 As System.Data.DataColumn
    Friend WithEvents xcbo_afect_domicilio As LibX.LibxCheckBox
    Friend WithEvents DataColumn32 As System.Data.DataColumn
    Friend WithEvents DataColumn33 As System.Data.DataColumn
    Friend WithEvents LibxCheckBox6 As LibX.LibxCheckBox
    Friend WithEvents TextBox6 As LibX.XTextBox
    Friend WithEvents chk_afect_seg As LibX.LibxCheckBox
    Friend WithEvents chk_afect_pos As LibX.LibxCheckBox
    Friend WithEvents chk_afect_cxp As LibX.LibxCheckBox
    Friend WithEvents chk_afect_cxc As LibX.LibxCheckBox
    Friend WithEvents chk_afect_inv As LibX.LibxCheckBox
    Friend WithEvents chk_afect_ctg As LibX.LibxCheckBox
    Friend WithEvents xtxt_type_orden As LibX.XTextBox
    Friend WithEvents xtxt_type_name As LibX.XTextBox
    Friend WithEvents xtxt_type_code As LibX.XTextBox
    Friend WithEvents DataColumn34 As System.Data.DataColumn
    Friend WithEvents LibxCheckBox1 As LibX.LibxCheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DataColumn17 As System.Data.DataColumn
    Friend WithEvents DataColumn35 As System.Data.DataColumn
    Friend WithEvents gCollast_number As LibX.XEditTextBoxColumn
    Friend WithEvents DataColumn37 As System.Data.DataColumn
    Friend WithEvents XTextBox1 As LibX.XTextBox
    Friend WithEvents XTextBox2 As LibX.XTextBox
    Friend WithEvents XTextBox3 As LibX.XTextBox
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents XTextBox4 As LibX.XTextBox
    Friend WithEvents DataColumn39 As System.Data.DataColumn
    Friend WithEvents DataColumn40 As System.Data.DataColumn
    Friend WithEvents DataColumn41 As System.Data.DataColumn
    Friend WithEvents DataColumn42 As System.Data.DataColumn
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents LibxCheckBox3 As LibX.LibxCheckBox
    Friend WithEvents LibxCheckBox7 As LibX.LibxCheckBox
    Friend WithEvents LibxCheckBox8 As LibX.LibxCheckBox
    Friend WithEvents LibxCheckBox9 As LibX.LibxCheckBox
    Friend WithEvents LibxCheckBox10 As LibX.LibxCheckBox
    Friend WithEvents LibxCheckBox11 As LibX.LibxCheckBox
    Friend WithEvents DataColumn36 As System.Data.DataColumn
    Friend WithEvents DataColumn38 As System.Data.DataColumn
    Friend WithEvents DataColumn43 As System.Data.DataColumn
    Friend WithEvents DataColumn44 As System.Data.DataColumn
    Friend WithEvents DataColumn45 As System.Data.DataColumn
    Friend WithEvents DataColumn46 As System.Data.DataColumn
    Friend WithEvents DataColumn47 As System.Data.DataColumn
    Friend WithEvents DataColumn48 As System.Data.DataColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox12 = New System.Windows.Forms.GroupBox
        Me.LibxCheckBox11 = New LibX.LibxCheckBox
        Me.DataSet1 = New System.Data.DataSet
        Me.DataTable1 = New System.Data.DataTable
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
        Me.DataColumn22 = New System.Data.DataColumn
        Me.DataColumn19 = New System.Data.DataColumn
        Me.DataColumn20 = New System.Data.DataColumn
        Me.DataColumn21 = New System.Data.DataColumn
        Me.DataColumn26 = New System.Data.DataColumn
        Me.DataColumn27 = New System.Data.DataColumn
        Me.DataColumn28 = New System.Data.DataColumn
        Me.DataColumn29 = New System.Data.DataColumn
        Me.DataColumn30 = New System.Data.DataColumn
        Me.DataColumn31 = New System.Data.DataColumn
        Me.DataColumn32 = New System.Data.DataColumn
        Me.DataColumn33 = New System.Data.DataColumn
        Me.DataColumn34 = New System.Data.DataColumn
        Me.DataColumn17 = New System.Data.DataColumn
        Me.DataColumn35 = New System.Data.DataColumn
        Me.DataColumn37 = New System.Data.DataColumn
        Me.DataColumn39 = New System.Data.DataColumn
        Me.DataColumn40 = New System.Data.DataColumn
        Me.DataColumn41 = New System.Data.DataColumn
        Me.DataColumn42 = New System.Data.DataColumn
        Me.DataColumn36 = New System.Data.DataColumn
        Me.DataColumn38 = New System.Data.DataColumn
        Me.DataColumn43 = New System.Data.DataColumn
        Me.DataColumn44 = New System.Data.DataColumn
        Me.DataColumn45 = New System.Data.DataColumn
        Me.DataTable3 = New System.Data.DataTable
        Me.DataColumn23 = New System.Data.DataColumn
        Me.DataColumn24 = New System.Data.DataColumn
        Me.DataColumn25 = New System.Data.DataColumn
        Me.DataColumn18 = New System.Data.DataColumn
        Me.LibxCheckBox10 = New LibX.LibxCheckBox
        Me.LibxCheckBox9 = New LibX.LibxCheckBox
        Me.LibxCheckBox8 = New LibX.LibxCheckBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.XTextBox4 = New LibX.XTextBox
        Me.XTextBox3 = New LibX.XTextBox
        Me.XTextBox2 = New LibX.XTextBox
        Me.XTextBox1 = New LibX.XTextBox
        Me.TextBox6 = New LibX.XTextBox
        Me.LibxCheckBox7 = New LibX.LibxCheckBox
        Me.LibxCheckBox6 = New LibX.LibxCheckBox
        Me.TextBox5 = New LibX.XTextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.xtxt_type_orden = New LibX.XTextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.LibXCombo1 = New LibX.LibXCombo
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBox4 = New LibX.XTextBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.chk_afect_seg = New LibX.LibxCheckBox
        Me.chk_afect_pos = New LibX.LibxCheckBox
        Me.chk_afect_cxp = New LibX.LibxCheckBox
        Me.chk_afect_cxc = New LibX.LibxCheckBox
        Me.chk_afect_inv = New LibX.LibxCheckBox
        Me.chk_afect_ctg = New LibX.LibxCheckBox
        Me.gbx_Origen = New System.Windows.Forms.GroupBox
        Me.rbg_debito = New System.Windows.Forms.RadioButton
        Me.rbg_credito = New System.Windows.Forms.RadioButton
        Me.xtxt_type_name = New LibX.XTextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.xtxt_type_code = New LibX.XTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.gbx_Entrada = New System.Windows.Forms.GroupBox
        Me.rbg_input = New System.Windows.Forms.RadioButton
        Me.rbg_output = New System.Windows.Forms.RadioButton
        Me.gbx_valor = New System.Windows.Forms.GroupBox
        Me.rbg_price = New System.Windows.Forms.RadioButton
        Me.rbg_cost = New System.Windows.Forms.RadioButton
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.LibxCheckBox3 = New LibX.LibxCheckBox
        Me.LibxCheckBox4 = New LibX.LibxCheckBox
        Me.LibxCheckBox2 = New LibX.LibxCheckBox
        Me.CheckBox5 = New LibX.LibxCheckBox
        Me.CheckBox6 = New LibX.LibxCheckBox
        Me.CheckBox7 = New LibX.LibxCheckBox
        Me.CheckBox8 = New LibX.LibxCheckBox
        Me.xck_pay_comm = New LibX.LibxCheckBox
        Me.LibxCheckBox5 = New LibX.LibxCheckBox
        Me.xcbo_afect_domicilio = New LibX.LibxCheckBox
        Me.LibxCheckBox1 = New LibX.LibxCheckBox
        Me.gbx_Tipo = New System.Windows.Forms.GroupBox
        Me.rdg_local = New System.Windows.Forms.RadioButton
        Me.rbg_intern = New System.Windows.Forms.RadioButton
        Me.LibXLookup1 = New LibX.LibXLookup
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.DataColumn46 = New System.Data.DataColumn
        Me.DataColumn47 = New System.Data.DataColumn
        Me.DataColumn48 = New System.Data.DataColumn
        Me.LibXGrid1 = New LibX.LibXGrid
        Me.XdataGridTableStyle1 = New LibX.XdataGridTableStyle
        Me.XDataGridTextButtonColumn1 = New LibX.XDataGridTextButtonColumn
        Me.XEditTextBoxColumn1 = New LibX.XEditTextBoxColumn
        Me.gCollast_number = New LibX.XEditTextBoxColumn
        Me.LibXNavigator1 = New LibX.LibXNavigator
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.gbx_Origen.SuspendLayout()
        Me.gbx_Entrada.SuspendLayout()
        Me.gbx_valor.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.gbx_Tipo.SuspendLayout()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox12)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.xtxt_type_orden)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.LibXCombo1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.gbx_Origen)
        Me.GroupBox1.Controls.Add(Me.xtxt_type_name)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.xtxt_type_code)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.gbx_Entrada)
        Me.GroupBox1.Controls.Add(Me.gbx_valor)
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Controls.Add(Me.gbx_Tipo)
        Me.GroupBox1.Controls.Add(Me.LibXLookup1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(672, 336)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.LibxCheckBox11)
        Me.GroupBox12.Controls.Add(Me.LibxCheckBox10)
        Me.GroupBox12.Controls.Add(Me.LibxCheckBox9)
        Me.GroupBox12.Controls.Add(Me.LibxCheckBox8)
        Me.GroupBox12.Controls.Add(Me.Label11)
        Me.GroupBox12.Controls.Add(Me.Label10)
        Me.GroupBox12.Controls.Add(Me.Label9)
        Me.GroupBox12.Controls.Add(Me.Label8)
        Me.GroupBox12.Controls.Add(Me.Label7)
        Me.GroupBox12.Controls.Add(Me.XTextBox4)
        Me.GroupBox12.Controls.Add(Me.XTextBox3)
        Me.GroupBox12.Controls.Add(Me.XTextBox2)
        Me.GroupBox12.Controls.Add(Me.XTextBox1)
        Me.GroupBox12.Controls.Add(Me.TextBox6)
        Me.GroupBox12.Controls.Add(Me.LibxCheckBox7)
        Me.GroupBox12.Controls.Add(Me.LibxCheckBox6)
        Me.GroupBox12.Location = New System.Drawing.Point(332, 168)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(152, 160)
        Me.GroupBox12.TabIndex = 7
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Opciones Impresión"
        '
        'LibxCheckBox11
        '
        Me.LibxCheckBox11.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LibxCheckBox11.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "ivtypem.auto_imp_dom"))
        Me.LibxCheckBox11.EditInitialValue = Nothing
        Me.LibxCheckBox11.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox11.FindInitialValue = Nothing
        Me.LibxCheckBox11.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox11.IgnoreRequiered = False
        Me.LibxCheckBox11.KeepEnabled = False
        Me.LibxCheckBox11.Location = New System.Drawing.Point(96, 132)
        Me.LibxCheckBox11.Name = "LibxCheckBox11"
        Me.LibxCheckBox11.NewInitialValue = Nothing
        Me.LibxCheckBox11.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox11.ReadOnly = False
        Me.LibxCheckBox11.Requiered = False
        Me.LibxCheckBox11.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LibxCheckBox11.Size = New System.Drawing.Size(48, 16)
        Me.LibxCheckBox11.TabIndex = 15
        Me.LibxCheckBox11.Text = "Auto"
        Me.LibxCheckBox11.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.LibxCheckBox11.ThreeState = True
        Me.LibxCheckBox11.value = Nothing
        '
        'DataSet1
        '
        Me.LibXConnector1.SetDataGenerator(Me.DataSet1, Me.LibXConnector1)
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, True)
        Me.DataSet1.EnforceConstraints = False
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1, Me.DataTable3})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn22, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn17, Me.DataColumn35, Me.DataColumn37, Me.DataColumn39, Me.DataColumn40, Me.DataColumn41, Me.DataColumn42, Me.DataColumn36, Me.DataColumn38, Me.DataColumn43, Me.DataColumn44, Me.DataColumn45})
        Me.DataTable1.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"type_code"}, True)})
        Me.DataTable1.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn1}
        Me.DataTable1.TableName = "ivtypem"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.ColumnName = "type_code"
        Me.DataColumn1.MaxLength = 3
        '
        'DataColumn2
        '
        Me.DataColumn2.AllowDBNull = False
        Me.DataColumn2.ColumnName = "type_name"
        Me.DataColumn2.MaxLength = 30
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "apply_cxc"
        Me.DataColumn3.DataType = GetType(System.Int16)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "apply_cxp"
        Me.DataColumn4.DataType = GetType(System.Int16)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "apply_inv"
        Me.DataColumn5.DataType = GetType(System.Int16)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "apply_ctg"
        Me.DataColumn6.DataType = GetType(System.Int16)
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "origen"
        Me.DataColumn7.DataType = GetType(System.Int32)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "apply_price"
        Me.DataColumn8.DataType = GetType(System.Int16)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "auto_number"
        Me.DataColumn9.DataType = GetType(System.Int16)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "last_number"
        Me.DataColumn10.DataType = GetType(System.Int32)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "use_salesman"
        Me.DataColumn11.DataType = GetType(System.Int16)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "use_customer"
        Me.DataColumn12.DataType = GetType(System.Int16)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "use_prov"
        Me.DataColumn13.DataType = GetType(System.Int16)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "doc_input"
        Me.DataColumn14.DataType = GetType(System.Int16)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "type_local"
        Me.DataColumn15.DataType = GetType(System.Int16)
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "type_default"
        Me.DataColumn16.DataType = GetType(System.Int16)
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "pay_comm"
        Me.DataColumn22.DataType = GetType(System.Int16)
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "progid"
        Me.DataColumn19.DataType = GetType(System.Int32)
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "apply_pos"
        Me.DataColumn20.DataType = GetType(System.Int32)
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "display_order"
        Me.DataColumn21.DataType = GetType(System.Int32)
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "afect_other"
        Me.DataColumn26.DataType = GetType(System.Int32)
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "afect_seguro"
        Me.DataColumn27.DataType = GetType(System.Int32)
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "reportName"
        Me.DataColumn28.MaxLength = 200
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "edit_price"
        Me.DataColumn29.DataType = GetType(System.Int32)
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "edit_costo"
        Me.DataColumn30.DataType = GetType(System.Int32)
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "afect_domicilio"
        Me.DataColumn31.DataType = GetType(System.Int32)
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "auto_imprimir"
        Me.DataColumn32.DataType = GetType(System.Int32)
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "no_copias"
        Me.DataColumn33.DataType = GetType(System.Int32)
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "genera_ncf"
        Me.DataColumn34.DataType = GetType(System.Int32)
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "type_note"
        Me.DataColumn17.MaxLength = 160
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "type_ncf_unico"
        Me.DataColumn35.MaxLength = 160
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "solo_domici"
        Me.DataColumn37.DataType = GetType(System.Int32)
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "no_copias_tar"
        Me.DataColumn39.DataType = GetType(System.Int32)
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "no_copias_cxc"
        Me.DataColumn40.DataType = GetType(System.Int32)
        '
        'DataColumn41
        '
        Me.DataColumn41.ColumnName = "no_copias_chk"
        Me.DataColumn41.DataType = GetType(System.Int32)
        '
        'DataColumn42
        '
        Me.DataColumn42.ColumnName = "no_copias_dom"
        Me.DataColumn42.DataType = GetType(System.Int32)
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "auto_imp_efe"
        Me.DataColumn36.DataType = GetType(System.Int32)
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "auto_imp_tar"
        Me.DataColumn38.DataType = GetType(System.Int32)
        '
        'DataColumn43
        '
        Me.DataColumn43.ColumnName = "auto_imp_cxc"
        Me.DataColumn43.DataType = GetType(System.Int32)
        '
        'DataColumn44
        '
        Me.DataColumn44.ColumnName = "auto_imp_chq"
        Me.DataColumn44.DataType = GetType(System.Int32)
        '
        'DataColumn45
        '
        Me.DataColumn45.ColumnName = "auto_imp_dom"
        Me.DataColumn45.DataType = GetType(System.Int32)
        '
        'DataTable3
        '
        Me.DataTable3.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn18, Me.DataColumn46, Me.DataColumn47, Me.DataColumn48})
        Me.DataTable3.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"type_code", "whse_code"}, True)})
        Me.DataTable3.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn23, Me.DataColumn24}
        Me.DataTable3.TableName = "ivtypen"
        '
        'DataColumn23
        '
        Me.DataColumn23.AllowDBNull = False
        Me.DataColumn23.ColumnName = "type_code"
        Me.DataColumn23.MaxLength = 3
        '
        'DataColumn24
        '
        Me.DataColumn24.AllowDBNull = False
        Me.DataColumn24.ColumnName = "whse_code"
        Me.DataColumn24.DataType = GetType(System.Int32)
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "last_number"
        Me.DataColumn25.DataType = GetType(System.Int32)
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "whse_name"
        Me.DataColumn18.MaxLength = 30
        '
        'LibxCheckBox10
        '
        Me.LibxCheckBox10.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LibxCheckBox10.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "ivtypem.auto_imp_cxc"))
        Me.LibxCheckBox10.EditInitialValue = Nothing
        Me.LibxCheckBox10.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox10.FindInitialValue = Nothing
        Me.LibxCheckBox10.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox10.IgnoreRequiered = False
        Me.LibxCheckBox10.KeepEnabled = False
        Me.LibxCheckBox10.Location = New System.Drawing.Point(96, 108)
        Me.LibxCheckBox10.Name = "LibxCheckBox10"
        Me.LibxCheckBox10.NewInitialValue = Nothing
        Me.LibxCheckBox10.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox10.ReadOnly = False
        Me.LibxCheckBox10.Requiered = False
        Me.LibxCheckBox10.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LibxCheckBox10.Size = New System.Drawing.Size(48, 16)
        Me.LibxCheckBox10.TabIndex = 12
        Me.LibxCheckBox10.Text = "Auto"
        Me.LibxCheckBox10.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.LibxCheckBox10.ThreeState = True
        Me.LibxCheckBox10.value = Nothing
        '
        'LibxCheckBox9
        '
        Me.LibxCheckBox9.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LibxCheckBox9.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "ivtypem.auto_imp_chq"))
        Me.LibxCheckBox9.EditInitialValue = Nothing
        Me.LibxCheckBox9.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox9.FindInitialValue = Nothing
        Me.LibxCheckBox9.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox9.IgnoreRequiered = False
        Me.LibxCheckBox9.KeepEnabled = False
        Me.LibxCheckBox9.Location = New System.Drawing.Point(96, 84)
        Me.LibxCheckBox9.Name = "LibxCheckBox9"
        Me.LibxCheckBox9.NewInitialValue = Nothing
        Me.LibxCheckBox9.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox9.ReadOnly = False
        Me.LibxCheckBox9.Requiered = False
        Me.LibxCheckBox9.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LibxCheckBox9.Size = New System.Drawing.Size(48, 16)
        Me.LibxCheckBox9.TabIndex = 9
        Me.LibxCheckBox9.Text = "Auto"
        Me.LibxCheckBox9.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.LibxCheckBox9.ThreeState = True
        Me.LibxCheckBox9.value = Nothing
        '
        'LibxCheckBox8
        '
        Me.LibxCheckBox8.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LibxCheckBox8.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "ivtypem.auto_imp_tar"))
        Me.LibxCheckBox8.EditInitialValue = Nothing
        Me.LibxCheckBox8.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox8.FindInitialValue = Nothing
        Me.LibxCheckBox8.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox8.IgnoreRequiered = False
        Me.LibxCheckBox8.KeepEnabled = False
        Me.LibxCheckBox8.Location = New System.Drawing.Point(96, 60)
        Me.LibxCheckBox8.Name = "LibxCheckBox8"
        Me.LibxCheckBox8.NewInitialValue = Nothing
        Me.LibxCheckBox8.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox8.ReadOnly = False
        Me.LibxCheckBox8.Requiered = False
        Me.LibxCheckBox8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LibxCheckBox8.Size = New System.Drawing.Size(48, 16)
        Me.LibxCheckBox8.TabIndex = 6
        Me.LibxCheckBox8.Text = "Auto"
        Me.LibxCheckBox8.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.LibxCheckBox8.ThreeState = True
        Me.LibxCheckBox8.value = Nothing
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label11.Location = New System.Drawing.Point(40, 132)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 16)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Domicilio"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label10.Location = New System.Drawing.Point(40, 110)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 16)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Credito"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.Location = New System.Drawing.Point(40, 84)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 16)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Cheque"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.Location = New System.Drawing.Point(40, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 16)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Tarjeta"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Location = New System.Drawing.Point(40, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 16)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Efectivo"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XTextBox4
        '
        Me.XTextBox4.AcceptsReturn = True
        Me.XTextBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.XTextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivtypem.no_copias_dom"))
        Me.XTextBox4.EditInitialValue = Nothing
        Me.XTextBox4.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox4.FieldDescription = ""
        Me.XTextBox4.FindInitialValue = Nothing
        Me.XTextBox4.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox4.IgnoreRequiered = False
        Me.XTextBox4.Location = New System.Drawing.Point(8, 130)
        Me.XTextBox4.Name = "XTextBox4"
        Me.XTextBox4.NewInitialValue = Nothing
        Me.XTextBox4.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox4.Requiered = False
        Me.XTextBox4.Size = New System.Drawing.Size(32, 20)
        Me.XTextBox4.StatusBarPanelDescripcion = Nothing
        Me.XTextBox4.TabIndex = 13
        Me.XTextBox4.Text = ""
        '
        'XTextBox3
        '
        Me.XTextBox3.AcceptsReturn = True
        Me.XTextBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.XTextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivtypem.no_copias_cxc"))
        Me.XTextBox3.EditInitialValue = Nothing
        Me.XTextBox3.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox3.FieldDescription = ""
        Me.XTextBox3.FindInitialValue = Nothing
        Me.XTextBox3.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox3.IgnoreRequiered = False
        Me.XTextBox3.Location = New System.Drawing.Point(8, 106)
        Me.XTextBox3.Name = "XTextBox3"
        Me.XTextBox3.NewInitialValue = Nothing
        Me.XTextBox3.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox3.Requiered = False
        Me.XTextBox3.Size = New System.Drawing.Size(32, 20)
        Me.XTextBox3.StatusBarPanelDescripcion = Nothing
        Me.XTextBox3.TabIndex = 10
        Me.XTextBox3.Text = ""
        '
        'XTextBox2
        '
        Me.XTextBox2.AcceptsReturn = True
        Me.XTextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.XTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivtypem.no_copias_chk"))
        Me.XTextBox2.EditInitialValue = Nothing
        Me.XTextBox2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.FieldDescription = ""
        Me.XTextBox2.FindInitialValue = Nothing
        Me.XTextBox2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.IgnoreRequiered = False
        Me.XTextBox2.Location = New System.Drawing.Point(8, 82)
        Me.XTextBox2.Name = "XTextBox2"
        Me.XTextBox2.NewInitialValue = Nothing
        Me.XTextBox2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.Requiered = False
        Me.XTextBox2.Size = New System.Drawing.Size(32, 20)
        Me.XTextBox2.StatusBarPanelDescripcion = Nothing
        Me.XTextBox2.TabIndex = 7
        Me.XTextBox2.Text = ""
        '
        'XTextBox1
        '
        Me.XTextBox1.AcceptsReturn = True
        Me.XTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.XTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivtypem.no_copias_tar"))
        Me.XTextBox1.EditInitialValue = Nothing
        Me.XTextBox1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.FieldDescription = ""
        Me.XTextBox1.FindInitialValue = Nothing
        Me.XTextBox1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.IgnoreRequiered = False
        Me.XTextBox1.Location = New System.Drawing.Point(8, 58)
        Me.XTextBox1.Name = "XTextBox1"
        Me.XTextBox1.NewInitialValue = Nothing
        Me.XTextBox1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.Requiered = False
        Me.XTextBox1.Size = New System.Drawing.Size(32, 20)
        Me.XTextBox1.StatusBarPanelDescripcion = Nothing
        Me.XTextBox1.TabIndex = 4
        Me.XTextBox1.Text = ""
        '
        'TextBox6
        '
        Me.TextBox6.AcceptsReturn = True
        Me.TextBox6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivtypem.no_copias"))
        Me.TextBox6.EditInitialValue = Nothing
        Me.TextBox6.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox6.FieldDescription = ""
        Me.TextBox6.FindInitialValue = Nothing
        Me.TextBox6.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox6.IgnoreRequiered = False
        Me.TextBox6.Location = New System.Drawing.Point(8, 34)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.NewInitialValue = Nothing
        Me.TextBox6.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox6.Requiered = False
        Me.TextBox6.Size = New System.Drawing.Size(32, 20)
        Me.TextBox6.StatusBarPanelDescripcion = Nothing
        Me.TextBox6.TabIndex = 1
        Me.TextBox6.Text = ""
        '
        'LibxCheckBox7
        '
        Me.LibxCheckBox7.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LibxCheckBox7.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "ivtypem.auto_imp_efe"))
        Me.LibxCheckBox7.EditInitialValue = Nothing
        Me.LibxCheckBox7.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox7.FindInitialValue = Nothing
        Me.LibxCheckBox7.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox7.IgnoreRequiered = False
        Me.LibxCheckBox7.KeepEnabled = False
        Me.LibxCheckBox7.Location = New System.Drawing.Point(96, 36)
        Me.LibxCheckBox7.Name = "LibxCheckBox7"
        Me.LibxCheckBox7.NewInitialValue = Nothing
        Me.LibxCheckBox7.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox7.ReadOnly = False
        Me.LibxCheckBox7.Requiered = False
        Me.LibxCheckBox7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LibxCheckBox7.Size = New System.Drawing.Size(48, 16)
        Me.LibxCheckBox7.TabIndex = 3
        Me.LibxCheckBox7.Text = "Auto"
        Me.LibxCheckBox7.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.LibxCheckBox7.ThreeState = True
        Me.LibxCheckBox7.value = Nothing
        '
        'LibxCheckBox6
        '
        Me.LibxCheckBox6.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LibxCheckBox6.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "ivtypem.auto_imprimir"))
        Me.LibxCheckBox6.EditInitialValue = Nothing
        Me.LibxCheckBox6.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox6.FindInitialValue = Nothing
        Me.LibxCheckBox6.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox6.IgnoreRequiered = False
        Me.LibxCheckBox6.KeepEnabled = False
        Me.LibxCheckBox6.Location = New System.Drawing.Point(16, 15)
        Me.LibxCheckBox6.Name = "LibxCheckBox6"
        Me.LibxCheckBox6.NewInitialValue = Nothing
        Me.LibxCheckBox6.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox6.ReadOnly = False
        Me.LibxCheckBox6.Requiered = False
        Me.LibxCheckBox6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LibxCheckBox6.Size = New System.Drawing.Size(128, 16)
        Me.LibxCheckBox6.TabIndex = 0
        Me.LibxCheckBox6.Text = "Imprimir Automático"
        Me.LibxCheckBox6.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.LibxCheckBox6.ThreeState = True
        Me.LibxCheckBox6.value = Nothing
        '
        'TextBox5
        '
        Me.TextBox5.AcceptsReturn = True
        Me.TextBox5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivtypem.type_ncf_unico"))
        Me.TextBox5.EditInitialValue = Nothing
        Me.TextBox5.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox5.FieldDescription = ""
        Me.TextBox5.FindInitialValue = Nothing
        Me.TextBox5.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox5.IgnoreRequiered = False
        Me.TextBox5.Location = New System.Drawing.Point(80, 115)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.NewInitialValue = Nothing
        Me.TextBox5.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox5.Requiered = False
        Me.TextBox5.Size = New System.Drawing.Size(392, 48)
        Me.TextBox5.StatusBarPanelDescripcion = Nothing
        Me.TextBox5.TabIndex = 4
        Me.TextBox5.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(8, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 16)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "NCF Unico:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_type_orden
        '
        Me.xtxt_type_orden.AcceptsReturn = True
        Me.xtxt_type_orden.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xtxt_type_orden.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivtypem.display_order"))
        Me.xtxt_type_orden.EditInitialValue = Nothing
        Me.xtxt_type_orden.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_type_orden.FieldDescription = ""
        Me.xtxt_type_orden.FindInitialValue = Nothing
        Me.xtxt_type_orden.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_type_orden.IgnoreRequiered = False
        Me.xtxt_type_orden.Location = New System.Drawing.Point(408, 24)
        Me.xtxt_type_orden.Name = "xtxt_type_orden"
        Me.xtxt_type_orden.NewInitialValue = Nothing
        Me.xtxt_type_orden.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_type_orden.Requiered = False
        Me.xtxt_type_orden.Size = New System.Drawing.Size(64, 20)
        Me.xtxt_type_orden.StatusBarPanelDescripcion = Nothing
        Me.xtxt_type_orden.TabIndex = 1
        Me.xtxt_type_orden.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 16)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Referencia:"
        '
        'LibXCombo1
        '
        Me.LibXCombo1.AllowDefaultSort = True
        Me.LibXCombo1.bound = True
        Me.LibXCombo1.currValue = Nothing
        Me.LibXCombo1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "ivtypem.progid"))
        Me.LibXCombo1.DefaultWhereString = Nothing
        Me.LibXCombo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LibXCombo1.EditInitialValue = Nothing
        Me.LibXCombo1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.FieldDescription = ""
        Me.LibXCombo1.FindInitialValue = Nothing
        Me.LibXCombo1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.IgnoreRequiered = False
        Me.LibXCombo1.Location = New System.Drawing.Point(80, 168)
        Me.LibXCombo1.LookupKeyDisplayFields = "descr"
        Me.LibXCombo1.LookupKeyField = "progid"
        Me.LibXCombo1.LookupTableName = "stmenud"
        Me.LibXCombo1.Name = "LibXCombo1"
        Me.LibXCombo1.NewInitialValue = Nothing
        Me.LibXCombo1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.Requiered = False
        Me.LibXCombo1.Required = False
        Me.LibXCombo1.Size = New System.Drawing.Size(176, 21)
        Me.LibXCombo1.SqlString = Nothing
        Me.LibXCombo1.StatusBarPanelDescripcion = Nothing
        Me.LibXCombo1.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(8, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Nota al Pie:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox4
        '
        Me.TextBox4.AcceptsReturn = True
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivtypem.type_note"))
        Me.TextBox4.EditInitialValue = Nothing
        Me.TextBox4.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox4.FieldDescription = ""
        Me.TextBox4.FindInitialValue = Nothing
        Me.TextBox4.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox4.IgnoreRequiered = False
        Me.TextBox4.Location = New System.Drawing.Point(80, 72)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.NewInitialValue = Nothing
        Me.TextBox4.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox4.Requiered = False
        Me.TextBox4.Size = New System.Drawing.Size(392, 40)
        Me.TextBox4.StatusBarPanelDescripcion = Nothing
        Me.TextBox4.TabIndex = 3
        Me.TextBox4.Text = ""
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.chk_afect_seg)
        Me.GroupBox4.Controls.Add(Me.chk_afect_pos)
        Me.GroupBox4.Controls.Add(Me.chk_afect_cxp)
        Me.GroupBox4.Controls.Add(Me.chk_afect_cxc)
        Me.GroupBox4.Controls.Add(Me.chk_afect_inv)
        Me.GroupBox4.Controls.Add(Me.chk_afect_ctg)
        Me.GroupBox4.Location = New System.Drawing.Point(488, 208)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(176, 120)
        Me.GroupBox4.TabIndex = 13
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Opciones"
        '
        'chk_afect_seg
        '
        Me.chk_afect_seg.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_afect_seg.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "ivtypem.afect_seguro"))
        Me.chk_afect_seg.EditInitialValue = Nothing
        Me.chk_afect_seg.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.chk_afect_seg.FindInitialValue = Nothing
        Me.chk_afect_seg.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.chk_afect_seg.IgnoreRequiered = False
        Me.chk_afect_seg.KeepEnabled = False
        Me.chk_afect_seg.Location = New System.Drawing.Point(16, 96)
        Me.chk_afect_seg.Name = "chk_afect_seg"
        Me.chk_afect_seg.NewInitialValue = Nothing
        Me.chk_afect_seg.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.chk_afect_seg.ReadOnly = False
        Me.chk_afect_seg.Requiered = False
        Me.chk_afect_seg.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chk_afect_seg.Size = New System.Drawing.Size(144, 16)
        Me.chk_afect_seg.TabIndex = 5
        Me.chk_afect_seg.Text = "Afecta Seguro Médico"
        Me.chk_afect_seg.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.chk_afect_seg.ThreeState = True
        Me.chk_afect_seg.value = Nothing
        '
        'chk_afect_pos
        '
        Me.chk_afect_pos.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_afect_pos.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "ivtypem.apply_pos"))
        Me.chk_afect_pos.EditInitialValue = Nothing
        Me.chk_afect_pos.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.chk_afect_pos.FindInitialValue = Nothing
        Me.chk_afect_pos.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.chk_afect_pos.IgnoreRequiered = False
        Me.chk_afect_pos.KeepEnabled = False
        Me.chk_afect_pos.Location = New System.Drawing.Point(16, 80)
        Me.chk_afect_pos.Name = "chk_afect_pos"
        Me.chk_afect_pos.NewInitialValue = Nothing
        Me.chk_afect_pos.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.chk_afect_pos.ReadOnly = False
        Me.chk_afect_pos.Requiered = False
        Me.chk_afect_pos.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chk_afect_pos.Size = New System.Drawing.Size(144, 16)
        Me.chk_afect_pos.TabIndex = 4
        Me.chk_afect_pos.Text = "Afecta Punto de Venta"
        Me.chk_afect_pos.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.chk_afect_pos.ThreeState = True
        Me.chk_afect_pos.value = Nothing
        '
        'chk_afect_cxp
        '
        Me.chk_afect_cxp.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_afect_cxp.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "ivtypem.apply_cxp"))
        Me.chk_afect_cxp.EditInitialValue = Nothing
        Me.chk_afect_cxp.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.chk_afect_cxp.FindInitialValue = Nothing
        Me.chk_afect_cxp.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.chk_afect_cxp.IgnoreRequiered = False
        Me.chk_afect_cxp.KeepEnabled = False
        Me.chk_afect_cxp.Location = New System.Drawing.Point(16, 16)
        Me.chk_afect_cxp.Name = "chk_afect_cxp"
        Me.chk_afect_cxp.NewInitialValue = Nothing
        Me.chk_afect_cxp.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.chk_afect_cxp.ReadOnly = False
        Me.chk_afect_cxp.Requiered = False
        Me.chk_afect_cxp.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chk_afect_cxp.Size = New System.Drawing.Size(144, 16)
        Me.chk_afect_cxp.TabIndex = 0
        Me.chk_afect_cxp.Text = "Afecta cuenta x pagar"
        Me.chk_afect_cxp.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.chk_afect_cxp.ThreeState = True
        Me.chk_afect_cxp.value = Nothing
        '
        'chk_afect_cxc
        '
        Me.chk_afect_cxc.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_afect_cxc.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "ivtypem.apply_cxc"))
        Me.chk_afect_cxc.EditInitialValue = Nothing
        Me.chk_afect_cxc.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.chk_afect_cxc.FindInitialValue = Nothing
        Me.chk_afect_cxc.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.chk_afect_cxc.IgnoreRequiered = False
        Me.chk_afect_cxc.KeepEnabled = False
        Me.chk_afect_cxc.Location = New System.Drawing.Point(16, 32)
        Me.chk_afect_cxc.Name = "chk_afect_cxc"
        Me.chk_afect_cxc.NewInitialValue = Nothing
        Me.chk_afect_cxc.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.chk_afect_cxc.ReadOnly = False
        Me.chk_afect_cxc.Requiered = False
        Me.chk_afect_cxc.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chk_afect_cxc.Size = New System.Drawing.Size(144, 16)
        Me.chk_afect_cxc.TabIndex = 1
        Me.chk_afect_cxc.Text = "Afecta cuenta x cobrar"
        Me.chk_afect_cxc.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.chk_afect_cxc.ThreeState = True
        Me.chk_afect_cxc.value = Nothing
        '
        'chk_afect_inv
        '
        Me.chk_afect_inv.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_afect_inv.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "ivtypem.apply_inv"))
        Me.chk_afect_inv.EditInitialValue = Nothing
        Me.chk_afect_inv.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.chk_afect_inv.FindInitialValue = Nothing
        Me.chk_afect_inv.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.chk_afect_inv.IgnoreRequiered = False
        Me.chk_afect_inv.KeepEnabled = False
        Me.chk_afect_inv.Location = New System.Drawing.Point(16, 48)
        Me.chk_afect_inv.Name = "chk_afect_inv"
        Me.chk_afect_inv.NewInitialValue = Nothing
        Me.chk_afect_inv.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.chk_afect_inv.ReadOnly = False
        Me.chk_afect_inv.Requiered = False
        Me.chk_afect_inv.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chk_afect_inv.Size = New System.Drawing.Size(144, 16)
        Me.chk_afect_inv.TabIndex = 2
        Me.chk_afect_inv.Text = "Afecta Inventario"
        Me.chk_afect_inv.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.chk_afect_inv.ThreeState = True
        Me.chk_afect_inv.value = Nothing
        '
        'chk_afect_ctg
        '
        Me.chk_afect_ctg.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_afect_ctg.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "ivtypem.apply_ctg"))
        Me.chk_afect_ctg.EditInitialValue = Nothing
        Me.chk_afect_ctg.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.chk_afect_ctg.FindInitialValue = Nothing
        Me.chk_afect_ctg.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.chk_afect_ctg.IgnoreRequiered = False
        Me.chk_afect_ctg.KeepEnabled = False
        Me.chk_afect_ctg.Location = New System.Drawing.Point(16, 64)
        Me.chk_afect_ctg.Name = "chk_afect_ctg"
        Me.chk_afect_ctg.NewInitialValue = Nothing
        Me.chk_afect_ctg.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.chk_afect_ctg.ReadOnly = False
        Me.chk_afect_ctg.Requiered = False
        Me.chk_afect_ctg.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chk_afect_ctg.Size = New System.Drawing.Size(144, 16)
        Me.chk_afect_ctg.TabIndex = 3
        Me.chk_afect_ctg.Text = "Afecta Contabilidad"
        Me.chk_afect_ctg.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.chk_afect_ctg.ThreeState = True
        Me.chk_afect_ctg.value = Nothing
        '
        'gbx_Origen
        '
        Me.gbx_Origen.Controls.Add(Me.rbg_debito)
        Me.gbx_Origen.Controls.Add(Me.rbg_credito)
        Me.gbx_Origen.Location = New System.Drawing.Point(488, 64)
        Me.gbx_Origen.Name = "gbx_Origen"
        Me.gbx_Origen.Size = New System.Drawing.Size(176, 40)
        Me.gbx_Origen.TabIndex = 10
        Me.gbx_Origen.TabStop = False
        Me.gbx_Origen.Text = "Origen"
        '
        'rbg_debito
        '
        Me.rbg_debito.Location = New System.Drawing.Point(8, 16)
        Me.rbg_debito.Name = "rbg_debito"
        Me.rbg_debito.Size = New System.Drawing.Size(56, 16)
        Me.rbg_debito.TabIndex = 0
        Me.rbg_debito.Text = "Débito"
        '
        'rbg_credito
        '
        Me.rbg_credito.Location = New System.Drawing.Point(80, 16)
        Me.rbg_credito.Name = "rbg_credito"
        Me.rbg_credito.Size = New System.Drawing.Size(64, 16)
        Me.rbg_credito.TabIndex = 1
        Me.rbg_credito.Text = "Crédito"
        '
        'xtxt_type_name
        '
        Me.xtxt_type_name.AcceptsReturn = True
        Me.xtxt_type_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xtxt_type_name.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivtypem.type_name"))
        Me.xtxt_type_name.EditInitialValue = Nothing
        Me.xtxt_type_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_type_name.FieldDescription = ""
        Me.xtxt_type_name.FindInitialValue = Nothing
        Me.xtxt_type_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_type_name.IgnoreRequiered = False
        Me.xtxt_type_name.Location = New System.Drawing.Point(80, 48)
        Me.xtxt_type_name.Name = "xtxt_type_name"
        Me.xtxt_type_name.NewInitialValue = Nothing
        Me.xtxt_type_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_type_name.Requiered = False
        Me.xtxt_type_name.Size = New System.Drawing.Size(392, 20)
        Me.xtxt_type_name.StatusBarPanelDescripcion = Nothing
        Me.xtxt_type_name.TabIndex = 2
        Me.xtxt_type_name.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(4, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Descripción:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_type_code
        '
        Me.xtxt_type_code.AcceptsReturn = True
        Me.xtxt_type_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xtxt_type_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivtypem.type_code"))
        Me.xtxt_type_code.EditInitialValue = Nothing
        Me.xtxt_type_code.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_type_code.FieldDescription = ""
        Me.xtxt_type_code.FindInitialValue = Nothing
        Me.xtxt_type_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_type_code.IgnoreRequiered = False
        Me.xtxt_type_code.Location = New System.Drawing.Point(80, 24)
        Me.xtxt_type_code.Name = "xtxt_type_code"
        Me.xtxt_type_code.NewInitialValue = Nothing
        Me.xtxt_type_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_type_code.Requiered = False
        Me.xtxt_type_code.Size = New System.Drawing.Size(64, 20)
        Me.xtxt_type_code.StatusBarPanelDescripcion = Nothing
        Me.xtxt_type_code.TabIndex = 0
        Me.xtxt_type_code.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(28, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(360, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Orden:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'gbx_Entrada
        '
        Me.gbx_Entrada.Controls.Add(Me.rbg_input)
        Me.gbx_Entrada.Controls.Add(Me.rbg_output)
        Me.gbx_Entrada.Location = New System.Drawing.Point(488, 112)
        Me.gbx_Entrada.Name = "gbx_Entrada"
        Me.gbx_Entrada.Size = New System.Drawing.Size(176, 40)
        Me.gbx_Entrada.TabIndex = 11
        Me.gbx_Entrada.TabStop = False
        Me.gbx_Entrada.Text = "Tipo"
        '
        'rbg_input
        '
        Me.rbg_input.Location = New System.Drawing.Point(8, 16)
        Me.rbg_input.Name = "rbg_input"
        Me.rbg_input.Size = New System.Drawing.Size(64, 16)
        Me.rbg_input.TabIndex = 0
        Me.rbg_input.Text = "Entrada"
        '
        'rbg_output
        '
        Me.rbg_output.Location = New System.Drawing.Point(80, 16)
        Me.rbg_output.Name = "rbg_output"
        Me.rbg_output.Size = New System.Drawing.Size(64, 16)
        Me.rbg_output.TabIndex = 1
        Me.rbg_output.Text = "Salida"
        '
        'gbx_valor
        '
        Me.gbx_valor.Controls.Add(Me.rbg_price)
        Me.gbx_valor.Controls.Add(Me.rbg_cost)
        Me.gbx_valor.Location = New System.Drawing.Point(488, 160)
        Me.gbx_valor.Name = "gbx_valor"
        Me.gbx_valor.Size = New System.Drawing.Size(176, 40)
        Me.gbx_valor.TabIndex = 12
        Me.gbx_valor.TabStop = False
        Me.gbx_valor.Text = "Valorización"
        '
        'rbg_price
        '
        Me.rbg_price.Location = New System.Drawing.Point(8, 16)
        Me.rbg_price.Name = "rbg_price"
        Me.rbg_price.Size = New System.Drawing.Size(64, 16)
        Me.rbg_price.TabIndex = 0
        Me.rbg_price.Text = "Precio"
        '
        'rbg_cost
        '
        Me.rbg_cost.Location = New System.Drawing.Point(80, 16)
        Me.rbg_cost.Name = "rbg_cost"
        Me.rbg_cost.Size = New System.Drawing.Size(64, 16)
        Me.rbg_cost.TabIndex = 1
        Me.rbg_cost.Text = "Costo"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.LibxCheckBox3)
        Me.GroupBox6.Controls.Add(Me.LibxCheckBox4)
        Me.GroupBox6.Controls.Add(Me.LibxCheckBox2)
        Me.GroupBox6.Controls.Add(Me.CheckBox5)
        Me.GroupBox6.Controls.Add(Me.CheckBox6)
        Me.GroupBox6.Controls.Add(Me.CheckBox7)
        Me.GroupBox6.Controls.Add(Me.CheckBox8)
        Me.GroupBox6.Controls.Add(Me.xck_pay_comm)
        Me.GroupBox6.Controls.Add(Me.LibxCheckBox5)
        Me.GroupBox6.Controls.Add(Me.xcbo_afect_domicilio)
        Me.GroupBox6.Controls.Add(Me.LibxCheckBox1)
        Me.GroupBox6.Location = New System.Drawing.Point(8, 192)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(320, 136)
        Me.GroupBox6.TabIndex = 6
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Opciones"
        '
        'LibxCheckBox3
        '
        Me.LibxCheckBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LibxCheckBox3.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "ivtypem.solo_domici"))
        Me.LibxCheckBox3.EditInitialValue = Nothing
        Me.LibxCheckBox3.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox3.FindInitialValue = Nothing
        Me.LibxCheckBox3.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox3.IgnoreRequiered = False
        Me.LibxCheckBox3.KeepEnabled = False
        Me.LibxCheckBox3.Location = New System.Drawing.Point(176, 81)
        Me.LibxCheckBox3.Name = "LibxCheckBox3"
        Me.LibxCheckBox3.NewInitialValue = Nothing
        Me.LibxCheckBox3.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox3.ReadOnly = False
        Me.LibxCheckBox3.Requiered = False
        Me.LibxCheckBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LibxCheckBox3.Size = New System.Drawing.Size(128, 16)
        Me.LibxCheckBox3.TabIndex = 10
        Me.LibxCheckBox3.Text = "Solo Domicilio"
        Me.LibxCheckBox3.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.LibxCheckBox3.ThreeState = True
        Me.LibxCheckBox3.value = Nothing
        '
        'LibxCheckBox4
        '
        Me.LibxCheckBox4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LibxCheckBox4.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "ivtypem.edit_price"))
        Me.LibxCheckBox4.EditInitialValue = Nothing
        Me.LibxCheckBox4.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox4.FindInitialValue = Nothing
        Me.LibxCheckBox4.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox4.IgnoreRequiered = False
        Me.LibxCheckBox4.KeepEnabled = False
        Me.LibxCheckBox4.Location = New System.Drawing.Point(177, 16)
        Me.LibxCheckBox4.Name = "LibxCheckBox4"
        Me.LibxCheckBox4.NewInitialValue = Nothing
        Me.LibxCheckBox4.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox4.ReadOnly = False
        Me.LibxCheckBox4.Requiered = False
        Me.LibxCheckBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LibxCheckBox4.Size = New System.Drawing.Size(128, 16)
        Me.LibxCheckBox4.TabIndex = 6
        Me.LibxCheckBox4.Text = "Editar Precio"
        Me.LibxCheckBox4.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.LibxCheckBox4.ThreeState = True
        Me.LibxCheckBox4.value = Nothing
        '
        'LibxCheckBox2
        '
        Me.LibxCheckBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LibxCheckBox2.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "ivtypem.afect_other"))
        Me.LibxCheckBox2.EditInitialValue = Nothing
        Me.LibxCheckBox2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox2.FindInitialValue = Nothing
        Me.LibxCheckBox2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox2.IgnoreRequiered = False
        Me.LibxCheckBox2.KeepEnabled = False
        Me.LibxCheckBox2.Location = New System.Drawing.Point(16, 96)
        Me.LibxCheckBox2.Name = "LibxCheckBox2"
        Me.LibxCheckBox2.NewInitialValue = Nothing
        Me.LibxCheckBox2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox2.ReadOnly = False
        Me.LibxCheckBox2.Requiered = False
        Me.LibxCheckBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LibxCheckBox2.Size = New System.Drawing.Size(152, 16)
        Me.LibxCheckBox2.TabIndex = 5
        Me.LibxCheckBox2.Text = "Afecta otros documentos"
        Me.LibxCheckBox2.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.LibxCheckBox2.ThreeState = True
        Me.LibxCheckBox2.value = Nothing
        '
        'CheckBox5
        '
        Me.CheckBox5.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox5.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "ivtypem.use_customer"))
        Me.CheckBox5.EditInitialValue = Nothing
        Me.CheckBox5.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.CheckBox5.FindInitialValue = Nothing
        Me.CheckBox5.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.CheckBox5.IgnoreRequiered = False
        Me.CheckBox5.KeepEnabled = False
        Me.CheckBox5.Location = New System.Drawing.Point(16, 16)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.NewInitialValue = Nothing
        Me.CheckBox5.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.CheckBox5.ReadOnly = False
        Me.CheckBox5.Requiered = False
        Me.CheckBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBox5.Size = New System.Drawing.Size(152, 16)
        Me.CheckBox5.TabIndex = 0
        Me.CheckBox5.Text = "Requiere Cliente"
        Me.CheckBox5.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.CheckBox5.ThreeState = True
        Me.CheckBox5.value = Nothing
        '
        'CheckBox6
        '
        Me.CheckBox6.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox6.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "ivtypem.use_salesman"))
        Me.CheckBox6.EditInitialValue = Nothing
        Me.CheckBox6.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.CheckBox6.FindInitialValue = Nothing
        Me.CheckBox6.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.CheckBox6.IgnoreRequiered = False
        Me.CheckBox6.KeepEnabled = False
        Me.CheckBox6.Location = New System.Drawing.Point(16, 32)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.NewInitialValue = Nothing
        Me.CheckBox6.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.CheckBox6.ReadOnly = False
        Me.CheckBox6.Requiered = False
        Me.CheckBox6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBox6.Size = New System.Drawing.Size(152, 16)
        Me.CheckBox6.TabIndex = 1
        Me.CheckBox6.Text = "Requiere Vendedor"
        Me.CheckBox6.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.CheckBox6.ThreeState = True
        Me.CheckBox6.value = Nothing
        '
        'CheckBox7
        '
        Me.CheckBox7.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox7.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "ivtypem.use_prov"))
        Me.CheckBox7.EditInitialValue = Nothing
        Me.CheckBox7.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.CheckBox7.FindInitialValue = Nothing
        Me.CheckBox7.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.CheckBox7.IgnoreRequiered = False
        Me.CheckBox7.KeepEnabled = False
        Me.CheckBox7.Location = New System.Drawing.Point(16, 48)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.NewInitialValue = Nothing
        Me.CheckBox7.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.CheckBox7.ReadOnly = False
        Me.CheckBox7.Requiered = False
        Me.CheckBox7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBox7.Size = New System.Drawing.Size(152, 16)
        Me.CheckBox7.TabIndex = 2
        Me.CheckBox7.Text = "Requiere Suplidor"
        Me.CheckBox7.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.CheckBox7.ThreeState = True
        Me.CheckBox7.value = Nothing
        '
        'CheckBox8
        '
        Me.CheckBox8.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox8.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "ivtypem.auto_number"))
        Me.CheckBox8.EditInitialValue = Nothing
        Me.CheckBox8.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.CheckBox8.FindInitialValue = Nothing
        Me.CheckBox8.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.CheckBox8.IgnoreRequiered = False
        Me.CheckBox8.KeepEnabled = False
        Me.CheckBox8.Location = New System.Drawing.Point(16, 64)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.NewInitialValue = Nothing
        Me.CheckBox8.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.CheckBox8.ReadOnly = False
        Me.CheckBox8.Requiered = False
        Me.CheckBox8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBox8.Size = New System.Drawing.Size(152, 16)
        Me.CheckBox8.TabIndex = 3
        Me.CheckBox8.Text = "Auto Numerable"
        Me.CheckBox8.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.CheckBox8.ThreeState = True
        Me.CheckBox8.value = Nothing
        '
        'xck_pay_comm
        '
        Me.xck_pay_comm.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.xck_pay_comm.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "ivtypem.pay_comm"))
        Me.xck_pay_comm.EditInitialValue = Nothing
        Me.xck_pay_comm.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xck_pay_comm.FindInitialValue = Nothing
        Me.xck_pay_comm.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xck_pay_comm.IgnoreRequiered = False
        Me.xck_pay_comm.KeepEnabled = False
        Me.xck_pay_comm.Location = New System.Drawing.Point(16, 80)
        Me.xck_pay_comm.Name = "xck_pay_comm"
        Me.xck_pay_comm.NewInitialValue = Nothing
        Me.xck_pay_comm.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xck_pay_comm.ReadOnly = False
        Me.xck_pay_comm.Requiered = False
        Me.xck_pay_comm.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.xck_pay_comm.Size = New System.Drawing.Size(152, 16)
        Me.xck_pay_comm.TabIndex = 4
        Me.xck_pay_comm.Text = "Paga Comisión"
        Me.xck_pay_comm.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.xck_pay_comm.ThreeState = True
        Me.xck_pay_comm.value = Nothing
        '
        'LibxCheckBox5
        '
        Me.LibxCheckBox5.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LibxCheckBox5.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "ivtypem.edit_costo"))
        Me.LibxCheckBox5.EditInitialValue = Nothing
        Me.LibxCheckBox5.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox5.FindInitialValue = Nothing
        Me.LibxCheckBox5.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox5.IgnoreRequiered = False
        Me.LibxCheckBox5.KeepEnabled = False
        Me.LibxCheckBox5.Location = New System.Drawing.Point(177, 32)
        Me.LibxCheckBox5.Name = "LibxCheckBox5"
        Me.LibxCheckBox5.NewInitialValue = Nothing
        Me.LibxCheckBox5.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox5.ReadOnly = False
        Me.LibxCheckBox5.Requiered = False
        Me.LibxCheckBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LibxCheckBox5.Size = New System.Drawing.Size(128, 16)
        Me.LibxCheckBox5.TabIndex = 7
        Me.LibxCheckBox5.Text = "Editar Costo"
        Me.LibxCheckBox5.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.LibxCheckBox5.ThreeState = True
        Me.LibxCheckBox5.value = Nothing
        '
        'xcbo_afect_domicilio
        '
        Me.xcbo_afect_domicilio.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.xcbo_afect_domicilio.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "ivtypem.afect_domicilio"))
        Me.xcbo_afect_domicilio.EditInitialValue = Nothing
        Me.xcbo_afect_domicilio.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_afect_domicilio.FindInitialValue = Nothing
        Me.xcbo_afect_domicilio.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_afect_domicilio.IgnoreRequiered = False
        Me.xcbo_afect_domicilio.KeepEnabled = False
        Me.xcbo_afect_domicilio.Location = New System.Drawing.Point(177, 48)
        Me.xcbo_afect_domicilio.Name = "xcbo_afect_domicilio"
        Me.xcbo_afect_domicilio.NewInitialValue = Nothing
        Me.xcbo_afect_domicilio.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_afect_domicilio.ReadOnly = False
        Me.xcbo_afect_domicilio.Requiered = False
        Me.xcbo_afect_domicilio.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.xcbo_afect_domicilio.Size = New System.Drawing.Size(128, 16)
        Me.xcbo_afect_domicilio.TabIndex = 8
        Me.xcbo_afect_domicilio.Text = "Acepta Domicilio"
        Me.xcbo_afect_domicilio.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.xcbo_afect_domicilio.ThreeState = True
        Me.xcbo_afect_domicilio.value = Nothing
        '
        'LibxCheckBox1
        '
        Me.LibxCheckBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LibxCheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "ivtypem.genera_ncf"))
        Me.LibxCheckBox1.EditInitialValue = Nothing
        Me.LibxCheckBox1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox1.FindInitialValue = Nothing
        Me.LibxCheckBox1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox1.IgnoreRequiered = False
        Me.LibxCheckBox1.KeepEnabled = False
        Me.LibxCheckBox1.Location = New System.Drawing.Point(177, 65)
        Me.LibxCheckBox1.Name = "LibxCheckBox1"
        Me.LibxCheckBox1.NewInitialValue = Nothing
        Me.LibxCheckBox1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox1.ReadOnly = False
        Me.LibxCheckBox1.Requiered = False
        Me.LibxCheckBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LibxCheckBox1.Size = New System.Drawing.Size(128, 16)
        Me.LibxCheckBox1.TabIndex = 9
        Me.LibxCheckBox1.Text = "Generar NCF"
        Me.LibxCheckBox1.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.LibxCheckBox1.ThreeState = True
        Me.LibxCheckBox1.value = Nothing
        '
        'gbx_Tipo
        '
        Me.gbx_Tipo.Controls.Add(Me.rdg_local)
        Me.gbx_Tipo.Controls.Add(Me.rbg_intern)
        Me.gbx_Tipo.Location = New System.Drawing.Point(488, 16)
        Me.gbx_Tipo.Name = "gbx_Tipo"
        Me.gbx_Tipo.Size = New System.Drawing.Size(176, 40)
        Me.gbx_Tipo.TabIndex = 8
        Me.gbx_Tipo.TabStop = False
        Me.gbx_Tipo.Text = "Tipo"
        '
        'rdg_local
        '
        Me.rdg_local.Location = New System.Drawing.Point(8, 16)
        Me.rdg_local.Name = "rdg_local"
        Me.rdg_local.Size = New System.Drawing.Size(56, 16)
        Me.rdg_local.TabIndex = 0
        Me.rdg_local.Text = "Local"
        '
        'rbg_intern
        '
        Me.rbg_intern.Location = New System.Drawing.Point(80, 16)
        Me.rbg_intern.Name = "rbg_intern"
        Me.rbg_intern.Size = New System.Drawing.Size(88, 16)
        Me.rbg_intern.TabIndex = 1
        Me.rbg_intern.Text = "Internacional"
        '
        'LibXLookup1
        '
        Me.LibXLookup1.AllowDrop = True
        Me.LibXLookup1.AlternateFieldSearch = Nothing
        Me.LibXLookup1.BeginCheck = False
        Me.LibXLookup1.CheckText = Nothing
        Me.LibXLookup1.ComboMode = False
        Me.LibXLookup1.DataMember = Nothing
        Me.LibXLookup1.DataSource = Me.LibXConnector1
        Me.LibXLookup1.DestParameters = New String() {"whse_code=whse_code", "whse_name=whse_name"}
        Me.LibXLookup1.FilterField = Nothing
        Me.LibXLookup1.IgnoreFindInBrowseMode = True
        Me.LibXLookup1.isCanceled = False
        Me.LibXLookup1.Location = New System.Drawing.Point(264, 248)
        Me.LibXLookup1.LookCaption = Nothing
        Me.LibXLookup1.Name = "LibXLookup1"
        Me.LibXLookup1.PopupSize = New System.Drawing.Size(0, 0)
        Me.LibXLookup1.ShowFilter = True
        Me.LibXLookup1.ShowMessageNotFound = True
        Me.LibXLookup1.ShowWarning = False
        Me.LibXLookup1.Size = New System.Drawing.Size(16, 20)
        Me.LibXLookup1.SizesColumns = Nothing
        Me.LibXLookup1.SizesColumnsTab = Nothing
        Me.LibXLookup1.SqlString = Nothing
        Me.LibXLookup1.SQLTab = Nothing
        Me.LibXLookup1.SrcParameters = New String() {"whse_code=whse_code"}
        Me.LibXLookup1.TabIndex = 12
        Me.LibXLookup1.TableName = "ivwhsem"
        Me.LibXLookup1.TabStop = False
        Me.LibXLookup1.UseCopyConnection = False
        Me.LibXLookup1.UseRowRetrieveEvents = False
        Me.LibXLookup1.UseTab = False
        Me.LibXLookup1.VisParameters = New String() {"Código=whse_code", "Almacen=whse_name"}
        Me.LibXLookup1.WhereCondition = Nothing
        Me.LibXLookup1.WhereParameters = Nothing
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
        Me.LibXConnector1.DataMember = Nothing
        Me.LibXConnector1.DataSource = Me.DataSet1
        Me.LibXConnector1.EOF = False
        Me.LibXConnector1.HandledRowsFill = False
        Me.LibXConnector1.HandledUpdates = False
        Me.LibXConnector1.HasRecords = False
        Me.LibXConnector1.IsEditing = False
        Me.LibXConnector1.IsHeaderOnGrid = False
        Me.LibXConnector1.ModuleName = Nothing
        Me.LibXConnector1.OwnerForm = Me
        Me.LibXConnector1.Parameters = Nothing
        Me.LibXConnector1.RecordCount = 0
        Me.LibXConnector1.ReportMode = False
        Me.LibXConnector1.ReportName = Nothing
        Me.LibXConnector1.ReportObject = Nothing
        Me.LibXConnector1.RequeryData = False
        Me.LibXConnector1.ShowWarningCancel = True
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.LibXDbSourceTable2, Me.LibXDbSourceTable1})
        Me.LibXConnector1.State = LibX.LibxConnectorState.none
        Me.LibXConnector1.UpdatePrimaryKeyColumns = False
        Me.LibXConnector1.UseTransactions = True
        '
        'LibXDbSourceTable2
        '
        Me.LibXDbSourceTable2.AllowDelete = True
        Me.LibXDbSourceTable2.AllowEdit = True
        Me.LibXDbSourceTable2.AllowNew = True
        Me.LibXDbSourceTable2.AutoIncrementSerial = False
        Me.LibXDbSourceTable2.CustomDbUpdate = False
        Me.LibXDbSourceTable2.DeleteOrder = 0
        Me.LibXDbSourceTable2.FillOnQuery = True
        Me.LibXDbSourceTable2.FillOnRowChange = False
        Me.LibXDbSourceTable2.HeaderIsOnGrid = False
        Me.LibXDbSourceTable2.InnerJon = True
        Me.LibXDbSourceTable2.InsertOrder = 0
        Me.LibXDbSourceTable2.IsDetail = False
        Me.LibXDbSourceTable2.KeyFields = Nothing
        Me.LibXDbSourceTable2.LineColName = Nothing
        Me.LibXDbSourceTable2.MasterDetailRelation = Nothing
        Me.LibXDbSourceTable2.MasterTableName = Nothing
        Me.LibXDbSourceTable2.SerialColumnName = Nothing
        Me.LibXDbSourceTable2.Sort = Nothing
        Me.LibXDbSourceTable2.Source = Nothing
        Me.LibXDbSourceTable2.TableName = "ivtypem"
        Me.LibXDbSourceTable2.UpdateOrder = 0
        Me.LibXDbSourceTable2.UseRowRetrieve = False
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
        Me.LibXDbSourceTable1.FillOnRowChange = True
        Me.LibXDbSourceTable1.HeaderIsOnGrid = False
        Me.LibXDbSourceTable1.InnerJon = True
        Me.LibXDbSourceTable1.InsertOrder = 0
        Me.LibXDbSourceTable1.IsDetail = True
        Me.LibXDbSourceTable1.KeyFields = ""
        Me.LibXDbSourceTable1.LineColName = Nothing
        Me.LibXDbSourceTable1.MasterDetailRelation = New String() {"type_code=type_code"}
        Me.LibXDbSourceTable1.MasterTableName = Nothing
        Me.LibXDbSourceTable1.SerialColumnName = Nothing
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = New String() {"select ivtypen.*,whse_name from ivtypen ", "inner join ivwhsem on ivwhsem.whse_code=ivtypen.whse_code"}
        Me.LibXDbSourceTable1.TableName = "ivtypen"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
        '
        'DataColumn46
        '
        Me.DataColumn46.AllowDBNull = False
        Me.DataColumn46.ColumnName = "suc_code"
        Me.DataColumn46.DataType = GetType(System.Int32)
        '
        'DataColumn47
        '
        Me.DataColumn47.ColumnName = "last_number_efe"
        Me.DataColumn47.DataType = GetType(System.Int32)
        '
        'DataColumn48
        '
        Me.DataColumn48.ColumnName = "last_number_cxc"
        Me.DataColumn48.DataType = GetType(System.Int32)
        '
        'LibXGrid1
        '
        Me.LibXGrid1.AutoAdjustLastColumn = True
        Me.LibXGrid1.AutoSearch = False
        Me.LibXGrid1.BackgroundColor = System.Drawing.Color.White
        Me.LibXGrid1.CaptionText = "Numeracion por Almacen"
        Me.LibXGrid1.DataMember = "ivtypen"
        Me.LibXGrid1.DataSource = Me.DataSet1
        Me.LibXGrid1.FullRowSelect = False
        Me.LibXGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGrid1.IsReadOnly = False
        Me.LibXGrid1.Location = New System.Drawing.Point(8, 376)
        Me.LibXGrid1.Name = "LibXGrid1"
        Me.LibXGrid1.ReadOnly = True
        Me.LibXGrid1.searchText = ""
        Me.LibXGrid1.showFooterBar = False
        Me.LibXGrid1.Size = New System.Drawing.Size(672, 120)
        Me.LibXGrid1.TabIndex = 2
        Me.LibXGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.XdataGridTableStyle1})
        Me.LibXGrid1.UseAutoFillLines = True
        Me.LibXGrid1.UseHandCursor = False
        '
        'XdataGridTableStyle1
        '
        Me.XdataGridTableStyle1.DataGrid = Me.LibXGrid1
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.XDataGridTextButtonColumn1, Me.XEditTextBoxColumn1, Me.gCollast_number})
        Me.XdataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle1.MappingName = "ivtypen"
        '
        'XDataGridTextButtonColumn1
        '
        Me.XDataGridTextButtonColumn1.ButtonType = LibX.XDataGridTextButtonColumn.XDataGridTextButtonColumnButtonTypes.SpinButton
        Me.XDataGridTextButtonColumn1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XDataGridTextButtonColumn1.executeFindDuringFill = False
        Me.XDataGridTextButtonColumn1.Format = ""
        Me.XDataGridTextButtonColumn1.FormatInfo = Nothing
        Me.XDataGridTextButtonColumn1.HeaderText = "Almacen"
        Me.XDataGridTextButtonColumn1.isReadOnly = False
        Me.XDataGridTextButtonColumn1.Lookup = Me.LibXLookup1
        Me.XDataGridTextButtonColumn1.MappingName = "whse_code"
        Me.XDataGridTextButtonColumn1.MaxLength = 32767
        Me.XDataGridTextButtonColumn1.TabStop = True
        Me.XDataGridTextButtonColumn1.UseCustomCellFormat = False
        Me.XDataGridTextButtonColumn1.Width = 70
        '
        'XEditTextBoxColumn1
        '
        Me.XEditTextBoxColumn1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn1.Format = ""
        Me.XEditTextBoxColumn1.FormatInfo = Nothing
        Me.XEditTextBoxColumn1.HeaderText = "Descripción"
        Me.XEditTextBoxColumn1.ImageList = Nothing
        Me.XEditTextBoxColumn1.isReadOnly = True
        Me.XEditTextBoxColumn1.MappingName = "whse_name"
        Me.XEditTextBoxColumn1.MaxLength = 32767
        Me.XEditTextBoxColumn1.ReadOnly = True
        Me.XEditTextBoxColumn1.TabStop = False
        Me.XEditTextBoxColumn1.UseCustomCellFormat = False
        Me.XEditTextBoxColumn1.Width = 425
        '
        'gCollast_number
        '
        Me.gCollast_number.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gCollast_number.Format = ""
        Me.gCollast_number.FormatInfo = Nothing
        Me.gCollast_number.HeaderText = "Ultimo Número"
        Me.gCollast_number.ImageList = Nothing
        Me.gCollast_number.isReadOnly = False
        Me.gCollast_number.MappingName = "last_number"
        Me.gCollast_number.MaxLength = 32767
        Me.gCollast_number.TabStop = False
        Me.gCollast_number.UseCustomCellFormat = False
        Me.gCollast_number.Width = 101
        '
        'LibXNavigator1
        '
        Me.LibXNavigator1.BuildMenu = True
        Me.LibXNavigator1.Connector = Me.LibXConnector1
        Me.LibXNavigator1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LibXNavigator1.FirstControlInEditMode = Me.xtxt_type_name
        Me.LibXNavigator1.FirstControlInFindMode = Me.xtxt_type_code
        Me.LibXNavigator1.FirstControlInNewMode = Me.xtxt_type_code
        Me.LibXNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.LibXNavigator1.Name = "LibXNavigator1"
        Me.LibXNavigator1.Size = New System.Drawing.Size(690, 24)
        Me.LibXNavigator1.TabIndex = 0
        '
        'i_ivtype01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(690, 544)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LibXGrid1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "i_ivtype01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Tipos de Documentos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox12.ResumeLayout(False)
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.gbx_Origen.ResumeLayout(False)
        Me.gbx_Entrada.ResumeLayout(False)
        Me.gbx_valor.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.gbx_Tipo.ResumeLayout(False)
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub LibXConnector1_InsertingRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatingEventArgs) Handles LibXConnector1.InsertingRow
        Try

            '// Valorización
            If rbg_cost.Checked = True Then
                e.UpdatingArgs.Row!apply_price = 0
            Else
                e.UpdatingArgs.Row!apply_price = 1
            End If

            '// Origen
            If rbg_debito.Checked = True Then
                e.UpdatingArgs.Row!origen = 1
            Else
                e.UpdatingArgs.Row!origen = -1
            End If

            '//Tipo
            If rbg_input.Checked = True Then
                e.UpdatingArgs.Row!doc_input = 1
            Else
                e.UpdatingArgs.Row!doc_input = 0
            End If

            '// internacionalizacion
            If rbg_intern.Checked = True Then
                e.UpdatingArgs.Row!type_local = 0
            Else
                e.UpdatingArgs.Row!type_local = 1
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub
    Private Sub LibXConnector1_AfterRowChange(ByVal sender As Object, ByVal e As LibX.XRowChangeEventArgs) Handles LibXConnector1.AfterRowChange
        Try
            If e.row Is Nothing Then
                Exit Sub
            End If

            '// Valorización
            If Val(e.row!apply_price.ToString) = 1 Then
                rbg_price.Checked = True
                rbg_cost.Checked = False
            Else
                rbg_cost.Checked = True
                rbg_price.Checked = False
            End If

            '// Origen
            If Val(e.row!origen.ToString) = 1 Then
                rbg_debito.Checked = True
                rbg_credito.Checked = False
            Else
                rbg_debito.Checked = False
                rbg_credito.Checked = True
            End If

            '//Tipo
            If Val(e.row!doc_input.ToString) = 1 Then
                rbg_input.Checked = True
                rbg_output.Checked = False
            Else
                rbg_input.Checked = False
                rbg_output.Checked = True
            End If

            '// internacionalizacion
            If Val(e.row!type_local.ToString) = 1 Then
                rdg_local.Checked = True
                rbg_intern.Checked = False
            Else
                rdg_local.Checked = False
                rbg_intern.Checked = True
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub
    Private Sub LibXConnector1_ExecutingAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutingAction
        Try
            If LibXConnector1.IsDataEditing = True Then
                ''If e.Action = LibX.LibxConnectionActions.Edit And LibXGrid1.SetValue(LibXGrid1.currentRowNum, gCollast_number) > 0 Then
                ''    LibXGrid1.Enabled = False
                ''Else
                ''    LibXGrid1.Enabled = True
                ''End If
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub
    Private Sub LibXConnector1_ChangeState(ByVal sender As Object, ByVal e As LibX.XChangeStateEventArgs) Handles LibXConnector1.ChangeState
        Me.gbx_Entrada.Enabled = e.isEditing
        Me.gbx_Origen.Enabled = e.isEditing
        Me.gbx_valor.Enabled = e.isEditing
        Me.gbx_Tipo.Enabled = e.isEditing

        If e.isEditing = True Then
            EnabledRadio()
        End If

    End Sub
    Private Sub EnabledRadio()

        Try
            If LibXConnector1.IsDataEditing = False Then
                Exit Sub
            End If

            '// Origen
            If Me.chk_afect_ctg.Checked _
            Or Me.chk_afect_cxc.Checked _
            Or Me.chk_afect_cxp.Checked Then
                Me.gbx_Origen.Enabled = True
            Else
                Me.rbg_credito.Checked = False
                Me.rbg_debito.Checked = False
                Me.gbx_Origen.Enabled = False
            End If

            '// Tipo
            If Me.chk_afect_inv.Checked _
            Or Me.chk_afect_pos.Checked _
            Or Me.chk_afect_seg.Checked Then
                Me.gbx_Entrada.Enabled = True
                Me.gbx_valor.Enabled = True
            Else
                Me.gbx_Entrada.Enabled = False
                Me.gbx_valor.Enabled = False

                Me.rbg_output.Checked = False
                Me.rbg_input.Checked = False

                Me.rbg_price.Checked = False
                Me.rbg_cost.Checked = False
            End If

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub chk_afect_cxp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
Handles chk_afect_cxp.CheckedChanged, _
        chk_afect_ctg.CheckedChanged, _
        chk_afect_cxc.CheckedChanged, _
        chk_afect_inv.CheckedChanged, _
        chk_afect_pos.CheckedChanged, _
        chk_afect_seg.CheckedChanged

        EnabledRadio()
    End Sub

    Private Sub LibXNavigator1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LibXNavigator1.Load

    End Sub

    Private Sub i_ivtype01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
