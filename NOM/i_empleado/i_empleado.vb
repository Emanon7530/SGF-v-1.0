Imports System.Configuration.ConfigurationSettings
Imports SGT


Public Class i_empleado
    Inherits System.Windows.Forms.Form
    Dim WhereStmt As String

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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents XTextBox2 As LibX.XTextBox
    Friend WithEvents xlk_purch_unit As LibX.LibXLookup
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents XTextBox1 As LibX.XTextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents LibxDateTimePicker1 As LibX.LibxDateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents XTextBox3 As LibX.XTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents XTextBox4 As LibX.XTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents XTextBox5 As LibX.XTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents XTextBox6 As LibX.XTextBox
    Friend WithEvents LibXLookup1 As LibX.LibXLookup
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents LibxDateTimePicker3 As LibX.LibxDateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents LibxDateTimePicker4 As LibX.LibxDateTimePicker
    Friend WithEvents txtemplcode As LibX.XTextBox
    Friend WithEvents Lblcity As LibX.XTextBox
    Friend WithEvents lbldepto As LibX.XTextBox
    Friend WithEvents Lkp_depto As LibX.LibXLookup
    Friend WithEvents XTextBox7 As LibX.XTextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents XTextBox8 As LibX.XTextBox
    Friend WithEvents LibXLookup2 As LibX.LibXLookup
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents LibXCombo2 As LibX.LibXCombo
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents LibXCombo4 As LibX.LibXCombo
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents LibXCombo5 As LibX.LibXCombo
    Friend WithEvents XTextBox10 As LibX.XTextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents XTextBox11 As LibX.XTextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents XTextBox12 As LibX.XTextBox
    Friend WithEvents LibXLookup3 As LibX.LibXLookup
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents XTextBox14 As LibX.XTextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents LibXCombo3 As LibX.LibXCombo
    Friend WithEvents XTextBox16 As LibX.XTextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents LibxCheckBox1 As LibX.LibxCheckBox
    Friend WithEvents LibxCheckBox2 As LibX.LibxCheckBox
    Friend WithEvents LibxCheckBox3 As LibX.LibxCheckBox
    Friend WithEvents nomemplrm As System.Data.DataTable
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
    Friend WithEvents lblnomina As LibX.XTextBox
    Friend WithEvents lblcargo As LibX.XTextBox
    Friend WithEvents txtnombre As LibX.XTextBox
    Friend WithEvents txtdepto As LibX.XTextBox
    Friend WithEvents txtcedula As LibX.XTextBox
    Friend WithEvents xtb_empl_status As LibX.LibXCombo
    Friend WithEvents XTextBox9 As LibX.XTextBox
    Friend WithEvents lblcxc As LibX.XTextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents LibXLookup4 As LibX.LibXLookup
    Friend WithEvents LibXNavigator1 As LibX.LibXNavigator
    Private WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents txtsexo As LibX.LibXCombo
    Friend WithEvents XTextBox13 As LibX.XTextBox
    Friend WithEvents XTextBox15 As LibX.XTextBox
    Friend WithEvents txtFechaIngreso As LibX.XTextBox
    Friend WithEvents BtnCargo As System.Windows.Forms.Button
    Friend WithEvents BtnNomina As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.DataSet1 = New System.Data.DataSet
        Me.nomemplrm = New System.Data.DataTable
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
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.lbldepto = New LibX.XTextBox
        Me.txtemplcode = New LibX.XTextBox
        Me.txtnombre = New LibX.XTextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtFechaIngreso = New LibX.XTextBox
        Me.XTextBox15 = New LibX.XTextBox
        Me.XTextBox13 = New LibX.XTextBox
        Me.LibXLookup4 = New LibX.LibXLookup
        Me.XTextBox9 = New LibX.XTextBox
        Me.lblcxc = New LibX.XTextBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.LibxCheckBox3 = New LibX.LibxCheckBox
        Me.LibxCheckBox2 = New LibX.LibxCheckBox
        Me.LibxCheckBox1 = New LibX.LibxCheckBox
        Me.XTextBox16 = New LibX.XTextBox
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.LibXCombo3 = New LibX.LibXCombo
        Me.XTextBox14 = New LibX.XTextBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.XTextBox12 = New LibX.XTextBox
        Me.lblnomina = New LibX.XTextBox
        Me.LibXLookup3 = New LibX.LibXLookup
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.XTextBox11 = New LibX.XTextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.XTextBox10 = New LibX.XTextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.LibXCombo5 = New LibX.LibXCombo
        Me.Label20 = New System.Windows.Forms.Label
        Me.LibXCombo4 = New LibX.LibXCombo
        Me.Label19 = New System.Windows.Forms.Label
        Me.LibXCombo2 = New LibX.LibXCombo
        Me.XTextBox8 = New LibX.XTextBox
        Me.lblcargo = New LibX.XTextBox
        Me.LibXLookup2 = New LibX.LibXLookup
        Me.XTextBox7 = New LibX.XTextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.XTextBox6 = New LibX.XTextBox
        Me.Lblcity = New LibX.XTextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.XTextBox5 = New LibX.XTextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.XTextBox4 = New LibX.XTextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.XTextBox3 = New LibX.XTextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.XTextBox1 = New LibX.XTextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.XTextBox2 = New LibX.XTextBox
        Me.txtdepto = New LibX.XTextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtcedula = New LibX.XTextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.LibxDateTimePicker4 = New LibX.LibxDateTimePicker
        Me.LibxDateTimePicker3 = New LibX.LibxDateTimePicker
        Me.LibXLookup1 = New LibX.LibXLookup
        Me.txtsexo = New LibX.LibXCombo
        Me.LibxDateTimePicker1 = New LibX.LibxDateTimePicker
        Me.Lkp_depto = New LibX.LibXLookup
        Me.xtb_empl_status = New LibX.LibXCombo
        Me.LibXNavigator1 = New LibX.LibXNavigator
        Me.BtnCargo = New System.Windows.Forms.Button
        Me.BtnNomina = New System.Windows.Forms.Button
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nomemplrm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.LibXConnector1.DataMember = "nomemplrm"
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
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.LibXDbSourceTable1})
        Me.LibXConnector1.State = LibX.LibxConnectorState.none
        Me.LibXConnector1.UpdatePrimaryKeyColumns = False
        Me.LibXConnector1.UseTransactions = False
        '
        'DataSet1
        '
        Me.LibXConnector1.SetDataGenerator(Me.DataSet1, Me.LibXConnector1)
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, False)
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.nomemplrm})
        '
        'nomemplrm
        '
        Me.nomemplrm.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34})
        Me.nomemplrm.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"empl_code"}, True)})
        Me.nomemplrm.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn1}
        Me.nomemplrm.TableName = "nomemplrm"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.AutoIncrement = True
        Me.DataColumn1.ColumnName = "empl_code"
        Me.DataColumn1.DataType = GetType(System.Int32)
        Me.DataColumn1.ReadOnly = True
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "empl_name"
        Me.DataColumn2.MaxLength = 30
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "cedula"
        Me.DataColumn3.MaxLength = 13
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "direccion"
        Me.DataColumn4.MaxLength = 50
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "telefono"
        Me.DataColumn5.MaxLength = 13
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "sexo"
        Me.DataColumn6.DataType = GetType(System.Int32)
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "fecha_nacimiento"
        Me.DataColumn7.DataType = GetType(System.DateTime)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "fecha_ingreso"
        Me.DataColumn8.DataType = GetType(System.DateTime)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "dept_code"
        Me.DataColumn9.DataType = GetType(System.Int32)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "cargo"
        Me.DataColumn10.DataType = GetType(System.Int32)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "cardnet"
        Me.DataColumn11.MaxLength = 20
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "salario_actual"
        Me.DataColumn12.DataType = GetType(System.Decimal)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "salario_anterior"
        Me.DataColumn13.DataType = GetType(System.Decimal)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "nacionalidad"
        Me.DataColumn14.MaxLength = 20
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "city_code"
        Me.DataColumn15.DataType = GetType(System.Int32)
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "fecha_cancelacion"
        Me.DataColumn16.DataType = GetType(System.DateTime)
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "fecha_vacaciones"
        Me.DataColumn17.DataType = GetType(System.DateTime)
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "tipo_pago"
        Me.DataColumn18.DataType = GetType(System.Int32)
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "empl_status"
        Me.DataColumn19.DataType = GetType(System.Int32)
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "periodo_pago"
        Me.DataColumn20.DataType = GetType(System.Int32)
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "estado_civil"
        Me.DataColumn21.DataType = GetType(System.Int32)
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "dias_vacaciones"
        Me.DataColumn22.DataType = GetType(System.Int32)
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "dias_usado"
        Me.DataColumn23.DataType = GetType(System.Int32)
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "fecha_cambiosalario"
        Me.DataColumn24.DataType = GetType(System.DateTime)
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "fecha_ultpago"
        Me.DataColumn25.DataType = GetType(System.DateTime)
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "retener_pago"
        Me.DataColumn26.DataType = GetType(System.Int32)
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "Column1"
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "seguro_medico"
        Me.DataColumn28.DataType = GetType(System.Int32)
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "poliza_seguro"
        Me.DataColumn29.MaxLength = 20
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "cust_code"
        Me.DataColumn30.DataType = GetType(System.Int32)
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "clase_nomina"
        Me.DataColumn31.DataType = GetType(System.Int32)
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "forma_pago"
        Me.DataColumn32.DataType = GetType(System.Int32)
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "notarjeta"
        Me.DataColumn33.MaxLength = 20
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "afp"
        Me.DataColumn34.DataType = GetType(System.Int32)
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
        Me.LibXDbSourceTable1.SerialColumnName = "empl_code"
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = Nothing
        Me.LibXDbSourceTable1.TableName = "nomemplrm"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
        '
        'lbldepto
        '
        Me.lbldepto.AcceptsReturn = True
        Me.lbldepto.EditInitialValue = Nothing
        Me.lbldepto.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.lbldepto.FieldDescription = ""
        Me.lbldepto.FindInitialValue = Nothing
        Me.lbldepto.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.lbldepto.IgnoreRequiered = False
        Me.lbldepto.Location = New System.Drawing.Point(176, 200)
        Me.lbldepto.Name = "lbldepto"
        Me.lbldepto.NewInitialValue = Nothing
        Me.lbldepto.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.lbldepto.ReadOnly = True
        Me.lbldepto.Requiered = False
        Me.lbldepto.Size = New System.Drawing.Size(296, 20)
        Me.lbldepto.StatusBarPanelDescripcion = Nothing
        Me.lbldepto.TabIndex = 10
        Me.lbldepto.TabStop = False
        Me.lbldepto.Text = ""
        '
        'txtemplcode
        '
        Me.txtemplcode.AcceptsReturn = True
        Me.txtemplcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtemplcode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "nomemplrm.empl_code"))
        Me.txtemplcode.EditInitialValue = Nothing
        Me.txtemplcode.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtemplcode.FieldDescription = ""
        Me.txtemplcode.FindInitialValue = Nothing
        Me.txtemplcode.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtemplcode.IgnoreRequiered = False
        Me.txtemplcode.Location = New System.Drawing.Point(120, 16)
        Me.txtemplcode.Name = "txtemplcode"
        Me.txtemplcode.NewInitialValue = Nothing
        Me.txtemplcode.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtemplcode.Requiered = False
        Me.txtemplcode.Size = New System.Drawing.Size(56, 20)
        Me.txtemplcode.StatusBarPanelDescripcion = Nothing
        Me.txtemplcode.TabIndex = 0
        Me.txtemplcode.Text = ""
        '
        'txtnombre
        '
        Me.txtnombre.AcceptsReturn = True
        Me.txtnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "nomemplrm.empl_name"))
        Me.txtnombre.EditInitialValue = Nothing
        Me.txtnombre.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtnombre.FieldDescription = ""
        Me.txtnombre.FindInitialValue = Nothing
        Me.txtnombre.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtnombre.IgnoreRequiered = False
        Me.txtnombre.Location = New System.Drawing.Point(120, 40)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.NewInitialValue = Nothing
        Me.txtnombre.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtnombre.Requiered = False
        Me.txtnombre.Size = New System.Drawing.Size(368, 20)
        Me.txtnombre.StatusBarPanelDescripcion = Nothing
        Me.txtnombre.TabIndex = 1
        Me.txtnombre.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtFechaIngreso)
        Me.GroupBox1.Controls.Add(Me.XTextBox15)
        Me.GroupBox1.Controls.Add(Me.XTextBox13)
        Me.GroupBox1.Controls.Add(Me.LibXLookup4)
        Me.GroupBox1.Controls.Add(Me.XTextBox9)
        Me.GroupBox1.Controls.Add(Me.lblcxc)
        Me.GroupBox1.Controls.Add(Me.Label28)
        Me.GroupBox1.Controls.Add(Me.LibxCheckBox3)
        Me.GroupBox1.Controls.Add(Me.LibxCheckBox2)
        Me.GroupBox1.Controls.Add(Me.LibxCheckBox1)
        Me.GroupBox1.Controls.Add(Me.XTextBox16)
        Me.GroupBox1.Controls.Add(Me.Label30)
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Controls.Add(Me.LibXCombo3)
        Me.GroupBox1.Controls.Add(Me.XTextBox14)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.XTextBox12)
        Me.GroupBox1.Controls.Add(Me.lblnomina)
        Me.GroupBox1.Controls.Add(Me.LibXLookup3)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.XTextBox11)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.XTextBox10)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.LibXCombo5)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.LibXCombo4)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.LibXCombo2)
        Me.GroupBox1.Controls.Add(Me.XTextBox8)
        Me.GroupBox1.Controls.Add(Me.lblcargo)
        Me.GroupBox1.Controls.Add(Me.LibXLookup2)
        Me.GroupBox1.Controls.Add(Me.XTextBox7)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.XTextBox6)
        Me.GroupBox1.Controls.Add(Me.Lblcity)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.XTextBox5)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.XTextBox4)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.XTextBox3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.XTextBox1)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.XTextBox2)
        Me.GroupBox1.Controls.Add(Me.txtdepto)
        Me.GroupBox1.Controls.Add(Me.lbldepto)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtcedula)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtemplcode)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.LibxDateTimePicker4)
        Me.GroupBox1.Controls.Add(Me.LibxDateTimePicker3)
        Me.GroupBox1.Controls.Add(Me.LibXLookup1)
        Me.GroupBox1.Controls.Add(Me.txtsexo)
        Me.GroupBox1.Controls.Add(Me.LibxDateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Lkp_depto)
        Me.GroupBox1.Controls.Add(Me.xtb_empl_status)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(744, 432)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'txtFechaIngreso
        '
        Me.txtFechaIngreso.AcceptsReturn = True
        Me.txtFechaIngreso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFechaIngreso.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "nomemplrm.fecha_ingreso"))
        Me.txtFechaIngreso.EditInitialValue = Nothing
        Me.txtFechaIngreso.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtFechaIngreso.FieldDescription = ""
        Me.txtFechaIngreso.FindInitialValue = Nothing
        Me.txtFechaIngreso.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtFechaIngreso.IgnoreRequiered = False
        Me.txtFechaIngreso.Location = New System.Drawing.Point(608, 112)
        Me.txtFechaIngreso.Name = "txtFechaIngreso"
        Me.txtFechaIngreso.NewInitialValue = Nothing
        Me.txtFechaIngreso.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtFechaIngreso.Requiered = False
        Me.txtFechaIngreso.Size = New System.Drawing.Size(112, 20)
        Me.txtFechaIngreso.StatusBarPanelDescripcion = Nothing
        Me.txtFechaIngreso.TabIndex = 30
        Me.txtFechaIngreso.Text = ""
        '
        'XTextBox15
        '
        Me.XTextBox15.AcceptsReturn = True
        Me.XTextBox15.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.XTextBox15.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "nomemplrm.fecha_ultpago"))
        Me.XTextBox15.EditInitialValue = Nothing
        Me.XTextBox15.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox15.FieldDescription = ""
        Me.XTextBox15.FindInitialValue = Nothing
        Me.XTextBox15.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox15.IgnoreRequiered = False
        Me.XTextBox15.Location = New System.Drawing.Point(120, 344)
        Me.XTextBox15.Name = "XTextBox15"
        Me.XTextBox15.NewInitialValue = Nothing
        Me.XTextBox15.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox15.Requiered = False
        Me.XTextBox15.Size = New System.Drawing.Size(136, 20)
        Me.XTextBox15.StatusBarPanelDescripcion = Nothing
        Me.XTextBox15.TabIndex = 21
        Me.XTextBox15.Text = ""
        '
        'XTextBox13
        '
        Me.XTextBox13.AcceptsReturn = True
        Me.XTextBox13.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.XTextBox13.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "nomemplrm.fecha_cambiosalario"))
        Me.XTextBox13.EditInitialValue = Nothing
        Me.XTextBox13.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox13.FieldDescription = ""
        Me.XTextBox13.FindInitialValue = Nothing
        Me.XTextBox13.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox13.IgnoreRequiered = False
        Me.XTextBox13.Location = New System.Drawing.Point(120, 296)
        Me.XTextBox13.Name = "XTextBox13"
        Me.XTextBox13.NewInitialValue = Nothing
        Me.XTextBox13.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox13.Requiered = False
        Me.XTextBox13.Size = New System.Drawing.Size(136, 20)
        Me.XTextBox13.StatusBarPanelDescripcion = Nothing
        Me.XTextBox13.TabIndex = 17
        Me.XTextBox13.Text = ""
        '
        'LibXLookup4
        '
        Me.LibXLookup4.AlternateFieldSearch = Nothing
        Me.LibXLookup4.CheckText = Nothing
        Me.LibXLookup4.ComboMode = False
        Me.LibXLookup4.DataMember = ""
        Me.LibXLookup4.DataSource = Me.LibXConnector1
        Me.LibXLookup4.DestParameters = New String() {"cust_code=cust_code", "lblcxc=cust_name"}
        Me.LibXLookup4.FilterField = "cust_name"
        Me.LibXLookup4.IgnoreFindInBrowseMode = False
        Me.LibXLookup4.isCanceled = False
        Me.LibXLookup4.Location = New System.Drawing.Point(472, 392)
        Me.LibXLookup4.LookCaption = "Cuenta cxc"
        Me.LibXLookup4.Name = "LibXLookup4"
        Me.LibXLookup4.PopupSize = New System.Drawing.Size(400, 300)
        Me.LibXLookup4.ShowFilter = True
        Me.LibXLookup4.ShowMessageNotFound = True
        Me.LibXLookup4.ShowWarning = False
        Me.LibXLookup4.Size = New System.Drawing.Size(16, 20)
        Me.LibXLookup4.SizesColumns = Nothing
        Me.LibXLookup4.SizesColumnsTab = Nothing
        Me.LibXLookup4.SqlString = Nothing
        Me.LibXLookup4.SQLTab = Nothing
        Me.LibXLookup4.SrcParameters = New String() {"cust_code=cust_code"}
        Me.LibXLookup4.TabIndex = 26
        Me.LibXLookup4.TableName = "cccustm"
        Me.LibXLookup4.TabStop = False
        Me.LibXLookup4.UseCopyConnection = False
        Me.LibXLookup4.UseRowRetrieveEvents = False
        Me.LibXLookup4.UseTab = False
        Me.LibXLookup4.VisParameters = New String() {"Código=cust_code", "Descripción=cust_name"}
        Me.LibXLookup4.WhereCondition = "csttype_code = 3"
        Me.LibXLookup4.WhereParameters = Nothing
        '
        'XTextBox9
        '
        Me.XTextBox9.AcceptsReturn = True
        Me.XTextBox9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "nomemplrm.cust_code"))
        Me.XTextBox9.EditInitialValue = Nothing
        Me.XTextBox9.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox9.FieldDescription = ""
        Me.XTextBox9.FindInitialValue = Nothing
        Me.XTextBox9.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox9.IgnoreRequiered = False
        Me.XTextBox9.Location = New System.Drawing.Point(120, 392)
        Me.XTextBox9.Name = "XTextBox9"
        Me.XTextBox9.NewInitialValue = Nothing
        Me.XTextBox9.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox9.Requiered = False
        Me.XTextBox9.Size = New System.Drawing.Size(56, 20)
        Me.XTextBox9.StatusBarPanelDescripcion = Nothing
        Me.XTextBox9.TabIndex = 25
        Me.XTextBox9.Text = ""
        '
        'lblcxc
        '
        Me.lblcxc.AcceptsReturn = True
        Me.lblcxc.EditInitialValue = Nothing
        Me.lblcxc.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.lblcxc.FieldDescription = ""
        Me.lblcxc.FindInitialValue = Nothing
        Me.lblcxc.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.lblcxc.IgnoreRequiered = False
        Me.lblcxc.Location = New System.Drawing.Point(176, 392)
        Me.lblcxc.Name = "lblcxc"
        Me.lblcxc.NewInitialValue = Nothing
        Me.lblcxc.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.lblcxc.ReadOnly = True
        Me.lblcxc.Requiered = False
        Me.lblcxc.Size = New System.Drawing.Size(296, 20)
        Me.lblcxc.StatusBarPanelDescripcion = Nothing
        Me.lblcxc.TabIndex = 95
        Me.lblcxc.TabStop = False
        Me.lblcxc.Text = ""
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label28.Location = New System.Drawing.Point(40, 400)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(66, 16)
        Me.Label28.TabIndex = 93
        Me.Label28.Text = "Cuenta Cxc:"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LibxCheckBox3
        '
        Me.LibxCheckBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LibxCheckBox3.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "nomemplrm.retener_pago"))
        Me.LibxCheckBox3.EditInitialValue = Nothing
        Me.LibxCheckBox3.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox3.FindInitialValue = Nothing
        Me.LibxCheckBox3.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox3.IgnoreRequiered = False
        Me.LibxCheckBox3.KeepEnabled = False
        Me.LibxCheckBox3.Location = New System.Drawing.Point(608, 296)
        Me.LibxCheckBox3.Name = "LibxCheckBox3"
        Me.LibxCheckBox3.NewInitialValue = Nothing
        Me.LibxCheckBox3.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox3.ReadOnly = False
        Me.LibxCheckBox3.Requiered = False
        Me.LibxCheckBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LibxCheckBox3.Size = New System.Drawing.Size(112, 16)
        Me.LibxCheckBox3.TabIndex = 38
        Me.LibxCheckBox3.Text = "Retener pago"
        Me.LibxCheckBox3.ThreeState = True
        Me.LibxCheckBox3.value = Nothing
        '
        'LibxCheckBox2
        '
        Me.LibxCheckBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LibxCheckBox2.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "nomemplrm.afp"))
        Me.LibxCheckBox2.EditInitialValue = Nothing
        Me.LibxCheckBox2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox2.FindInitialValue = Nothing
        Me.LibxCheckBox2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox2.IgnoreRequiered = False
        Me.LibxCheckBox2.KeepEnabled = False
        Me.LibxCheckBox2.Location = New System.Drawing.Point(608, 280)
        Me.LibxCheckBox2.Name = "LibxCheckBox2"
        Me.LibxCheckBox2.NewInitialValue = Nothing
        Me.LibxCheckBox2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox2.ReadOnly = False
        Me.LibxCheckBox2.Requiered = False
        Me.LibxCheckBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LibxCheckBox2.Size = New System.Drawing.Size(112, 16)
        Me.LibxCheckBox2.TabIndex = 37
        Me.LibxCheckBox2.Text = "Fondo Pension"
        Me.LibxCheckBox2.ThreeState = True
        Me.LibxCheckBox2.value = Nothing
        '
        'LibxCheckBox1
        '
        Me.LibxCheckBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LibxCheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "nomemplrm.seguro_medico"))
        Me.LibxCheckBox1.EditInitialValue = Nothing
        Me.LibxCheckBox1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox1.FindInitialValue = Nothing
        Me.LibxCheckBox1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox1.IgnoreRequiered = False
        Me.LibxCheckBox1.KeepEnabled = False
        Me.LibxCheckBox1.Location = New System.Drawing.Point(608, 232)
        Me.LibxCheckBox1.Name = "LibxCheckBox1"
        Me.LibxCheckBox1.NewInitialValue = Nothing
        Me.LibxCheckBox1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox1.ReadOnly = False
        Me.LibxCheckBox1.Requiered = False
        Me.LibxCheckBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LibxCheckBox1.Size = New System.Drawing.Size(112, 16)
        Me.LibxCheckBox1.TabIndex = 35
        Me.LibxCheckBox1.Text = "Seguro Medico"
        Me.LibxCheckBox1.ThreeState = True
        Me.LibxCheckBox1.value = Nothing
        '
        'XTextBox16
        '
        Me.XTextBox16.AcceptsReturn = True
        Me.XTextBox16.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.XTextBox16.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "nomemplrm.poliza_seguro"))
        Me.XTextBox16.EditInitialValue = Nothing
        Me.XTextBox16.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox16.FieldDescription = ""
        Me.XTextBox16.FindInitialValue = Nothing
        Me.XTextBox16.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox16.IgnoreRequiered = False
        Me.XTextBox16.Location = New System.Drawing.Point(608, 256)
        Me.XTextBox16.Name = "XTextBox16"
        Me.XTextBox16.NewInitialValue = Nothing
        Me.XTextBox16.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox16.Requiered = False
        Me.XTextBox16.Size = New System.Drawing.Size(112, 20)
        Me.XTextBox16.StatusBarPanelDescripcion = Nothing
        Me.XTextBox16.TabIndex = 36
        Me.XTextBox16.Text = ""
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label30.Location = New System.Drawing.Point(547, 264)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(56, 16)
        Me.Label30.TabIndex = 89
        Me.Label30.Text = "No. Poliza"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label29.Location = New System.Drawing.Point(50, 328)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(59, 16)
        Me.Label29.TabIndex = 86
        Me.Label29.Text = "Tipo Pago:"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LibXCombo3
        '
        Me.LibXCombo3.AllowDefaultSort = True
        Me.LibXCombo3.bound = True
        Me.LibXCombo3.currValue = Nothing
        Me.LibXCombo3.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "nomemplrm.tipo_pago"))
        Me.LibXCombo3.DefaultWhereString = Nothing
        Me.LibXCombo3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LibXCombo3.EditInitialValue = Nothing
        Me.LibXCombo3.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo3.FieldDescription = ""
        Me.LibXCombo3.FindInitialValue = Nothing
        Me.LibXCombo3.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo3.IgnoreRequiered = False
        Me.LibXCombo3.Items.AddRange(New Object() {"1-SalarioFIjo", "2-PorHora", "3-PorAjuste"})
        Me.LibXCombo3.Location = New System.Drawing.Point(120, 320)
        Me.LibXCombo3.LookupKeyDisplayFields = Nothing
        Me.LibXCombo3.LookupKeyField = Nothing
        Me.LibXCombo3.LookupTableName = Nothing
        Me.LibXCombo3.Name = "LibXCombo3"
        Me.LibXCombo3.NewInitialValue = Nothing
        Me.LibXCombo3.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo3.Requiered = False
        Me.LibXCombo3.Required = False
        Me.LibXCombo3.Size = New System.Drawing.Size(136, 21)
        Me.LibXCombo3.SqlString = Nothing
        Me.LibXCombo3.StatusBarPanelDescripcion = Nothing
        Me.LibXCombo3.TabIndex = 19
        '
        'XTextBox14
        '
        Me.XTextBox14.AcceptsReturn = True
        Me.XTextBox14.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.XTextBox14.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "nomemplrm.notarjeta"))
        Me.XTextBox14.EditInitialValue = Nothing
        Me.XTextBox14.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox14.FieldDescription = ""
        Me.XTextBox14.FindInitialValue = Nothing
        Me.XTextBox14.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox14.IgnoreRequiered = False
        Me.XTextBox14.Location = New System.Drawing.Point(360, 344)
        Me.XTextBox14.Name = "XTextBox14"
        Me.XTextBox14.NewInitialValue = Nothing
        Me.XTextBox14.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox14.Requiered = False
        Me.XTextBox14.Size = New System.Drawing.Size(128, 20)
        Me.XTextBox14.StatusBarPanelDescripcion = Nothing
        Me.XTextBox14.TabIndex = 23
        Me.XTextBox14.Text = ""
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label27.Location = New System.Drawing.Point(294, 352)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(63, 16)
        Me.Label27.TabIndex = 80
        Me.Label27.Text = "No. Tarjeta:"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label26.Location = New System.Drawing.Point(40, 352)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(69, 16)
        Me.Label26.TabIndex = 78
        Me.Label26.Text = "Ultimo Pago:"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XTextBox12
        '
        Me.XTextBox12.AcceptsReturn = True
        Me.XTextBox12.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "nomemplrm.clase_nomina"))
        Me.XTextBox12.EditInitialValue = Nothing
        Me.XTextBox12.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox12.FieldDescription = ""
        Me.XTextBox12.FindInitialValue = Nothing
        Me.XTextBox12.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox12.IgnoreRequiered = False
        Me.XTextBox12.Location = New System.Drawing.Point(120, 248)
        Me.XTextBox12.Name = "XTextBox12"
        Me.XTextBox12.NewInitialValue = Nothing
        Me.XTextBox12.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox12.Requiered = False
        Me.XTextBox12.Size = New System.Drawing.Size(56, 20)
        Me.XTextBox12.StatusBarPanelDescripcion = Nothing
        Me.XTextBox12.TabIndex = 12
        Me.XTextBox12.Text = ""
        '
        'lblnomina
        '
        Me.lblnomina.AcceptsReturn = True
        Me.lblnomina.EditInitialValue = Nothing
        Me.lblnomina.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.lblnomina.FieldDescription = ""
        Me.lblnomina.FindInitialValue = Nothing
        Me.lblnomina.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.lblnomina.IgnoreRequiered = False
        Me.lblnomina.Location = New System.Drawing.Point(176, 248)
        Me.lblnomina.Name = "lblnomina"
        Me.lblnomina.NewInitialValue = Nothing
        Me.lblnomina.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.lblnomina.ReadOnly = True
        Me.lblnomina.Requiered = False
        Me.lblnomina.Size = New System.Drawing.Size(296, 20)
        Me.lblnomina.StatusBarPanelDescripcion = Nothing
        Me.lblnomina.TabIndex = 75
        Me.lblnomina.TabStop = False
        Me.lblnomina.Text = ""
        '
        'LibXLookup3
        '
        Me.LibXLookup3.AlternateFieldSearch = Nothing
        Me.LibXLookup3.CheckText = Nothing
        Me.LibXLookup3.ComboMode = False
        Me.LibXLookup3.DataMember = ""
        Me.LibXLookup3.DataSource = Me.LibXConnector1
        Me.LibXLookup3.DestParameters = New String() {"clase_nomina=clase_nomina", "lblnomina=nomina_desc"}
        Me.LibXLookup3.FilterField = "nomina_desc"
        Me.LibXLookup3.IgnoreFindInBrowseMode = False
        Me.LibXLookup3.isCanceled = False
        Me.LibXLookup3.Location = New System.Drawing.Point(472, 248)
        Me.LibXLookup3.LookCaption = "Clase Nomina"
        Me.LibXLookup3.Name = "LibXLookup3"
        Me.LibXLookup3.PopupSize = New System.Drawing.Size(400, 300)
        Me.LibXLookup3.ShowFilter = True
        Me.LibXLookup3.ShowMessageNotFound = True
        Me.LibXLookup3.ShowWarning = False
        Me.LibXLookup3.Size = New System.Drawing.Size(16, 20)
        Me.LibXLookup3.SizesColumns = Nothing
        Me.LibXLookup3.SizesColumnsTab = Nothing
        Me.LibXLookup3.SqlString = Nothing
        Me.LibXLookup3.SQLTab = Nothing
        Me.LibXLookup3.SrcParameters = New String() {"clase_nomina=clase_nomina"}
        Me.LibXLookup3.TabIndex = 13
        Me.LibXLookup3.TableName = "nomclasem"
        Me.LibXLookup3.TabStop = False
        Me.LibXLookup3.UseCopyConnection = False
        Me.LibXLookup3.UseRowRetrieveEvents = False
        Me.LibXLookup3.UseTab = False
        Me.LibXLookup3.VisParameters = New String() {"Código=clase_nomina", "Descripción=nomina_desc"}
        Me.LibXLookup3.WhereCondition = Nothing
        Me.LibXLookup3.WhereParameters = Nothing
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label25.Location = New System.Drawing.Point(63, 256)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(46, 16)
        Me.Label25.TabIndex = 73
        Me.Label25.Text = "Nomina:"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label21.Location = New System.Drawing.Point(24, 304)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(85, 16)
        Me.Label21.TabIndex = 72
        Me.Label21.Text = "Cambio Salario:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XTextBox11
        '
        Me.XTextBox11.AcceptsReturn = True
        Me.XTextBox11.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.XTextBox11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "nomemplrm.dias_usado"))
        Me.XTextBox11.EditInitialValue = Nothing
        Me.XTextBox11.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox11.FieldDescription = ""
        Me.XTextBox11.FindInitialValue = Nothing
        Me.XTextBox11.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox11.IgnoreRequiered = False
        Me.XTextBox11.Location = New System.Drawing.Point(608, 184)
        Me.XTextBox11.Name = "XTextBox11"
        Me.XTextBox11.NewInitialValue = Nothing
        Me.XTextBox11.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox11.Requiered = False
        Me.XTextBox11.Size = New System.Drawing.Size(112, 20)
        Me.XTextBox11.StatusBarPanelDescripcion = Nothing
        Me.XTextBox11.TabIndex = 33
        Me.XTextBox11.Text = ""
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label24.Location = New System.Drawing.Point(537, 192)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(66, 16)
        Me.Label24.TabIndex = 70
        Me.Label24.Text = "Dias Usado:"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XTextBox10
        '
        Me.XTextBox10.AcceptsReturn = True
        Me.XTextBox10.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.XTextBox10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "nomemplrm.dias_vacaciones"))
        Me.XTextBox10.EditInitialValue = Nothing
        Me.XTextBox10.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox10.FieldDescription = ""
        Me.XTextBox10.FindInitialValue = Nothing
        Me.XTextBox10.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox10.IgnoreRequiered = False
        Me.XTextBox10.Location = New System.Drawing.Point(608, 160)
        Me.XTextBox10.Name = "XTextBox10"
        Me.XTextBox10.NewInitialValue = Nothing
        Me.XTextBox10.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox10.Requiered = False
        Me.XTextBox10.Size = New System.Drawing.Size(112, 20)
        Me.XTextBox10.StatusBarPanelDescripcion = Nothing
        Me.XTextBox10.TabIndex = 32
        Me.XTextBox10.Text = ""
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label23.Location = New System.Drawing.Point(511, 168)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(92, 16)
        Me.Label23.TabIndex = 68
        Me.Label23.Text = "Dias Vacaciones:"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label22.Location = New System.Drawing.Point(287, 304)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(70, 16)
        Me.Label22.TabIndex = 66
        Me.Label22.Text = "Forma Pago:"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LibXCombo5
        '
        Me.LibXCombo5.AllowDefaultSort = True
        Me.LibXCombo5.bound = True
        Me.LibXCombo5.currValue = Nothing
        Me.LibXCombo5.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "nomemplrm.forma_pago"))
        Me.LibXCombo5.DefaultWhereString = Nothing
        Me.LibXCombo5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LibXCombo5.EditInitialValue = Nothing
        Me.LibXCombo5.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo5.FieldDescription = ""
        Me.LibXCombo5.FindInitialValue = Nothing
        Me.LibXCombo5.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo5.IgnoreRequiered = False
        Me.LibXCombo5.Items.AddRange(New Object() {"1-Efectivo", "2-Cheque", "3-Tarjeta"})
        Me.LibXCombo5.Location = New System.Drawing.Point(360, 296)
        Me.LibXCombo5.LookupKeyDisplayFields = Nothing
        Me.LibXCombo5.LookupKeyField = Nothing
        Me.LibXCombo5.LookupTableName = Nothing
        Me.LibXCombo5.Name = "LibXCombo5"
        Me.LibXCombo5.NewInitialValue = Nothing
        Me.LibXCombo5.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo5.Requiered = False
        Me.LibXCombo5.Required = False
        Me.LibXCombo5.Size = New System.Drawing.Size(128, 21)
        Me.LibXCombo5.SqlString = Nothing
        Me.LibXCombo5.StatusBarPanelDescripcion = Nothing
        Me.LibXCombo5.TabIndex = 18
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label20.Location = New System.Drawing.Point(281, 328)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(76, 16)
        Me.Label20.TabIndex = 64
        Me.Label20.Text = "Periodo Pago:"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LibXCombo4
        '
        Me.LibXCombo4.AllowDefaultSort = True
        Me.LibXCombo4.bound = True
        Me.LibXCombo4.currValue = Nothing
        Me.LibXCombo4.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "nomemplrm.periodo_pago"))
        Me.LibXCombo4.DefaultWhereString = Nothing
        Me.LibXCombo4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LibXCombo4.EditInitialValue = Nothing
        Me.LibXCombo4.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo4.FieldDescription = ""
        Me.LibXCombo4.FindInitialValue = Nothing
        Me.LibXCombo4.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo4.IgnoreRequiered = False
        Me.LibXCombo4.Items.AddRange(New Object() {"1-Mensual", "2-Quincenal", "3-Semanal"})
        Me.LibXCombo4.Location = New System.Drawing.Point(360, 320)
        Me.LibXCombo4.LookupKeyDisplayFields = Nothing
        Me.LibXCombo4.LookupKeyField = Nothing
        Me.LibXCombo4.LookupTableName = Nothing
        Me.LibXCombo4.Name = "LibXCombo4"
        Me.LibXCombo4.NewInitialValue = Nothing
        Me.LibXCombo4.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo4.Requiered = False
        Me.LibXCombo4.Required = False
        Me.LibXCombo4.Size = New System.Drawing.Size(128, 21)
        Me.LibXCombo4.SqlString = Nothing
        Me.LibXCombo4.StatusBarPanelDescripcion = Nothing
        Me.LibXCombo4.TabIndex = 20
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label19.Location = New System.Drawing.Point(536, 72)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(67, 16)
        Me.Label19.TabIndex = 59
        Me.Label19.Text = "Estado Civil:"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LibXCombo2
        '
        Me.LibXCombo2.AllowDefaultSort = True
        Me.LibXCombo2.bound = True
        Me.LibXCombo2.currValue = Nothing
        Me.LibXCombo2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "nomemplrm.estado_civil"))
        Me.LibXCombo2.DefaultWhereString = Nothing
        Me.LibXCombo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LibXCombo2.EditInitialValue = Nothing
        Me.LibXCombo2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo2.FieldDescription = ""
        Me.LibXCombo2.FindInitialValue = Nothing
        Me.LibXCombo2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo2.IgnoreRequiered = False
        Me.LibXCombo2.Items.AddRange(New Object() {"1-Soltero", "2-Casado"})
        Me.LibXCombo2.Location = New System.Drawing.Point(608, 64)
        Me.LibXCombo2.LookupKeyDisplayFields = Nothing
        Me.LibXCombo2.LookupKeyField = Nothing
        Me.LibXCombo2.LookupTableName = Nothing
        Me.LibXCombo2.Name = "LibXCombo2"
        Me.LibXCombo2.NewInitialValue = Nothing
        Me.LibXCombo2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo2.Requiered = False
        Me.LibXCombo2.Required = False
        Me.LibXCombo2.Size = New System.Drawing.Size(112, 21)
        Me.LibXCombo2.SqlString = Nothing
        Me.LibXCombo2.StatusBarPanelDescripcion = Nothing
        Me.LibXCombo2.TabIndex = 28
        '
        'XTextBox8
        '
        Me.XTextBox8.AcceptsReturn = True
        Me.XTextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "nomemplrm.cargo"))
        Me.XTextBox8.EditInitialValue = Nothing
        Me.XTextBox8.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox8.FieldDescription = ""
        Me.XTextBox8.FindInitialValue = Nothing
        Me.XTextBox8.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox8.IgnoreRequiered = False
        Me.XTextBox8.Location = New System.Drawing.Point(120, 224)
        Me.XTextBox8.Name = "XTextBox8"
        Me.XTextBox8.NewInitialValue = Nothing
        Me.XTextBox8.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox8.Requiered = False
        Me.XTextBox8.Size = New System.Drawing.Size(56, 20)
        Me.XTextBox8.StatusBarPanelDescripcion = Nothing
        Me.XTextBox8.TabIndex = 10
        Me.XTextBox8.Text = ""
        '
        'lblcargo
        '
        Me.lblcargo.AcceptsReturn = True
        Me.lblcargo.EditInitialValue = Nothing
        Me.lblcargo.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.lblcargo.FieldDescription = ""
        Me.lblcargo.FindInitialValue = Nothing
        Me.lblcargo.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.lblcargo.IgnoreRequiered = False
        Me.lblcargo.Location = New System.Drawing.Point(176, 224)
        Me.lblcargo.Name = "lblcargo"
        Me.lblcargo.NewInitialValue = Nothing
        Me.lblcargo.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.lblcargo.ReadOnly = True
        Me.lblcargo.Requiered = False
        Me.lblcargo.Size = New System.Drawing.Size(296, 20)
        Me.lblcargo.StatusBarPanelDescripcion = Nothing
        Me.lblcargo.TabIndex = 56
        Me.lblcargo.TabStop = False
        Me.lblcargo.Text = ""
        '
        'LibXLookup2
        '
        Me.LibXLookup2.AlternateFieldSearch = Nothing
        Me.LibXLookup2.CheckText = Nothing
        Me.LibXLookup2.ComboMode = False
        Me.LibXLookup2.DataMember = ""
        Me.LibXLookup2.DataSource = Me.LibXConnector1
        Me.LibXLookup2.DestParameters = New String() {"cargo=cargo_code", "lblcargo=cargo_name"}
        Me.LibXLookup2.FilterField = "cargo_name"
        Me.LibXLookup2.IgnoreFindInBrowseMode = False
        Me.LibXLookup2.isCanceled = False
        Me.LibXLookup2.Location = New System.Drawing.Point(472, 224)
        Me.LibXLookup2.LookCaption = "Cargos"
        Me.LibXLookup2.Name = "LibXLookup2"
        Me.LibXLookup2.PopupSize = New System.Drawing.Size(400, 300)
        Me.LibXLookup2.ShowFilter = True
        Me.LibXLookup2.ShowMessageNotFound = True
        Me.LibXLookup2.ShowWarning = False
        Me.LibXLookup2.Size = New System.Drawing.Size(16, 20)
        Me.LibXLookup2.SizesColumns = Nothing
        Me.LibXLookup2.SizesColumnsTab = Nothing
        Me.LibXLookup2.SqlString = Nothing
        Me.LibXLookup2.SQLTab = Nothing
        Me.LibXLookup2.SrcParameters = New String() {"cargo=cargo_code"}
        Me.LibXLookup2.TabIndex = 11
        Me.LibXLookup2.TableName = "nomcargom"
        Me.LibXLookup2.TabStop = False
        Me.LibXLookup2.UseCopyConnection = False
        Me.LibXLookup2.UseRowRetrieveEvents = False
        Me.LibXLookup2.UseTab = False
        Me.LibXLookup2.VisParameters = New String() {"Código=cargo_code", "Descripción=cargo_name"}
        Me.LibXLookup2.WhereCondition = Nothing
        Me.LibXLookup2.WhereParameters = Nothing
        '
        'XTextBox7
        '
        Me.XTextBox7.AcceptsReturn = True
        Me.XTextBox7.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.XTextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "nomemplrm.salario_anterior"))
        Me.XTextBox7.EditInitialValue = Nothing
        Me.XTextBox7.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox7.FieldDescription = ""
        Me.XTextBox7.FindInitialValue = Nothing
        Me.XTextBox7.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox7.IgnoreRequiered = False
        Me.XTextBox7.Location = New System.Drawing.Point(360, 272)
        Me.XTextBox7.Name = "XTextBox7"
        Me.XTextBox7.NewInitialValue = Nothing
        Me.XTextBox7.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox7.Requiered = False
        Me.XTextBox7.Size = New System.Drawing.Size(128, 20)
        Me.XTextBox7.StatusBarPanelDescripcion = Nothing
        Me.XTextBox7.TabIndex = 15
        Me.XTextBox7.Text = ""
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label18.Location = New System.Drawing.Point(272, 280)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(85, 16)
        Me.Label18.TabIndex = 54
        Me.Label18.Text = "Salario Anterior:"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label14.Location = New System.Drawing.Point(499, 216)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(104, 16)
        Me.Label14.TabIndex = 52
        Me.Label14.Text = "Fecha Cancelacion:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.Location = New System.Drawing.Point(502, 144)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 16)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "Ultima Vacaciones:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XTextBox6
        '
        Me.XTextBox6.AcceptsReturn = True
        Me.XTextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "nomemplrm.city_code"))
        Me.XTextBox6.EditInitialValue = Nothing
        Me.XTextBox6.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox6.FieldDescription = ""
        Me.XTextBox6.FindInitialValue = Nothing
        Me.XTextBox6.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox6.IgnoreRequiered = False
        Me.XTextBox6.Location = New System.Drawing.Point(120, 149)
        Me.XTextBox6.Name = "XTextBox6"
        Me.XTextBox6.NewInitialValue = Nothing
        Me.XTextBox6.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox6.Requiered = False
        Me.XTextBox6.Size = New System.Drawing.Size(56, 20)
        Me.XTextBox6.StatusBarPanelDescripcion = Nothing
        Me.XTextBox6.TabIndex = 4
        Me.XTextBox6.Text = ""
        '
        'Lblcity
        '
        Me.Lblcity.AcceptsReturn = True
        Me.Lblcity.EditInitialValue = Nothing
        Me.Lblcity.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Lblcity.FieldDescription = ""
        Me.Lblcity.FindInitialValue = Nothing
        Me.Lblcity.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Lblcity.IgnoreRequiered = False
        Me.Lblcity.Location = New System.Drawing.Point(176, 149)
        Me.Lblcity.Name = "Lblcity"
        Me.Lblcity.NewInitialValue = Nothing
        Me.Lblcity.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Lblcity.ReadOnly = True
        Me.Lblcity.Requiered = False
        Me.Lblcity.Size = New System.Drawing.Size(296, 20)
        Me.Lblcity.StatusBarPanelDescripcion = Nothing
        Me.Lblcity.TabIndex = 47
        Me.Lblcity.TabStop = False
        Me.Lblcity.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.Location = New System.Drawing.Point(66, 157)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 16)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "Ciudad:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XTextBox5
        '
        Me.XTextBox5.AcceptsReturn = True
        Me.XTextBox5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.XTextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "nomemplrm.nacionalidad"))
        Me.XTextBox5.EditInitialValue = Nothing
        Me.XTextBox5.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox5.FieldDescription = ""
        Me.XTextBox5.FindInitialValue = Nothing
        Me.XTextBox5.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox5.IgnoreRequiered = False
        Me.XTextBox5.Location = New System.Drawing.Point(312, 176)
        Me.XTextBox5.Name = "XTextBox5"
        Me.XTextBox5.NewInitialValue = Nothing
        Me.XTextBox5.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox5.Requiered = False
        Me.XTextBox5.Size = New System.Drawing.Size(176, 20)
        Me.XTextBox5.StatusBarPanelDescripcion = Nothing
        Me.XTextBox5.TabIndex = 7
        Me.XTextBox5.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Location = New System.Drawing.Point(232, 176)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 16)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "Nacionalidad:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XTextBox4
        '
        Me.XTextBox4.AcceptsReturn = True
        Me.XTextBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.XTextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "nomemplrm.cardnet"))
        Me.XTextBox4.EditInitialValue = Nothing
        Me.XTextBox4.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox4.FieldDescription = ""
        Me.XTextBox4.FindInitialValue = Nothing
        Me.XTextBox4.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox4.IgnoreRequiered = False
        Me.XTextBox4.Location = New System.Drawing.Point(120, 368)
        Me.XTextBox4.Name = "XTextBox4"
        Me.XTextBox4.NewInitialValue = Nothing
        Me.XTextBox4.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox4.Requiered = False
        Me.XTextBox4.Size = New System.Drawing.Size(136, 20)
        Me.XTextBox4.StatusBarPanelDescripcion = Nothing
        Me.XTextBox4.TabIndex = 24
        Me.XTextBox4.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(41, 376)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 16)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "No. Cardnet:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XTextBox3
        '
        Me.XTextBox3.AcceptsReturn = True
        Me.XTextBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.XTextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "nomemplrm.salario_actual"))
        Me.XTextBox3.EditInitialValue = Nothing
        Me.XTextBox3.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox3.FieldDescription = ""
        Me.XTextBox3.FindInitialValue = Nothing
        Me.XTextBox3.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox3.IgnoreRequiered = False
        Me.XTextBox3.Location = New System.Drawing.Point(120, 272)
        Me.XTextBox3.Name = "XTextBox3"
        Me.XTextBox3.NewInitialValue = Nothing
        Me.XTextBox3.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox3.Requiered = False
        Me.XTextBox3.Size = New System.Drawing.Size(136, 20)
        Me.XTextBox3.StatusBarPanelDescripcion = Nothing
        Me.XTextBox3.TabIndex = 14
        Me.XTextBox3.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(32, 280)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 16)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Salario Actual:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label17.Location = New System.Drawing.Point(71, 232)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(38, 16)
        Me.Label17.TabIndex = 38
        Me.Label17.Text = "Cargo:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label16.Location = New System.Drawing.Point(570, 48)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(33, 16)
        Me.Label16.TabIndex = 36
        Me.Label16.Text = "Sexo:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label15.Location = New System.Drawing.Point(523, 120)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 16)
        Me.Label15.TabIndex = 34
        Me.Label15.Text = "Fecha Ingreso:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label12.Location = New System.Drawing.Point(504, 96)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(99, 16)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "Fecha Nacimiento:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label11.Location = New System.Drawing.Point(58, 184)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 16)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Telefono:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XTextBox1
        '
        Me.XTextBox1.AcceptsReturn = True
        Me.XTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.XTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "nomemplrm.telefono"))
        Me.XTextBox1.EditInitialValue = Nothing
        Me.XTextBox1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.FieldDescription = ""
        Me.XTextBox1.FindInitialValue = Nothing
        Me.XTextBox1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.IgnoreRequiered = False
        Me.XTextBox1.Location = New System.Drawing.Point(120, 176)
        Me.XTextBox1.Name = "XTextBox1"
        Me.XTextBox1.NewInitialValue = Nothing
        Me.XTextBox1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.Requiered = False
        Me.XTextBox1.Size = New System.Drawing.Size(96, 20)
        Me.XTextBox1.StatusBarPanelDescripcion = Nothing
        Me.XTextBox1.TabIndex = 6
        Me.XTextBox1.Text = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label10.Location = New System.Drawing.Point(54, 120)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 16)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Direccion:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XTextBox2
        '
        Me.XTextBox2.AcceptsReturn = True
        Me.XTextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.XTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "nomemplrm.direccion"))
        Me.XTextBox2.EditInitialValue = Nothing
        Me.XTextBox2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.FieldDescription = ""
        Me.XTextBox2.FindInitialValue = Nothing
        Me.XTextBox2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.IgnoreRequiered = False
        Me.XTextBox2.Location = New System.Drawing.Point(120, 88)
        Me.XTextBox2.Multiline = True
        Me.XTextBox2.Name = "XTextBox2"
        Me.XTextBox2.NewInitialValue = Nothing
        Me.XTextBox2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.Requiered = False
        Me.XTextBox2.Size = New System.Drawing.Size(368, 56)
        Me.XTextBox2.StatusBarPanelDescripcion = Nothing
        Me.XTextBox2.TabIndex = 3
        Me.XTextBox2.Text = ""
        '
        'txtdepto
        '
        Me.txtdepto.AcceptsReturn = True
        Me.txtdepto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "nomemplrm.dept_code"))
        Me.txtdepto.EditInitialValue = Nothing
        Me.txtdepto.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtdepto.FieldDescription = ""
        Me.txtdepto.FindInitialValue = Nothing
        Me.txtdepto.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtdepto.IgnoreRequiered = False
        Me.txtdepto.Location = New System.Drawing.Point(120, 200)
        Me.txtdepto.Name = "txtdepto"
        Me.txtdepto.NewInitialValue = Nothing
        Me.txtdepto.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtdepto.Requiered = False
        Me.txtdepto.Size = New System.Drawing.Size(56, 20)
        Me.txtdepto.StatusBarPanelDescripcion = Nothing
        Me.txtdepto.TabIndex = 8
        Me.txtdepto.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(30, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Departamento:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtcedula
        '
        Me.txtcedula.AcceptsReturn = True
        Me.txtcedula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcedula.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "nomemplrm.cedula"))
        Me.txtcedula.EditInitialValue = Nothing
        Me.txtcedula.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtcedula.FieldDescription = ""
        Me.txtcedula.FindInitialValue = Nothing
        Me.txtcedula.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtcedula.IgnoreRequiered = False
        Me.txtcedula.Location = New System.Drawing.Point(120, 64)
        Me.txtcedula.Name = "txtcedula"
        Me.txtcedula.NewInitialValue = Nothing
        Me.txtcedula.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtcedula.Requiered = False
        Me.txtcedula.Size = New System.Drawing.Size(216, 20)
        Me.txtcedula.StatusBarPanelDescripcion = Nothing
        Me.txtcedula.TabIndex = 2
        Me.txtcedula.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(66, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Cedula:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(61, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(66, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label13.Location = New System.Drawing.Point(558, 320)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 16)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Estado:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LibxDateTimePicker4
        '
        Me.LibxDateTimePicker4.CustomFormat = "dd/MM/yyyy"
        Me.LibxDateTimePicker4.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "nomemplrm.fecha_cancelacion"))
        Me.LibxDateTimePicker4.EditInitialValue = Nothing
        Me.LibxDateTimePicker4.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.LibxDateTimePicker4.FieldDescription = ""
        Me.LibxDateTimePicker4.FindInitialValue = Nothing
        Me.LibxDateTimePicker4.FindState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.LibxDateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.LibxDateTimePicker4.IgnoreRequiered = False
        Me.LibxDateTimePicker4.Location = New System.Drawing.Point(608, 208)
        Me.LibxDateTimePicker4.Name = "LibxDateTimePicker4"
        Me.LibxDateTimePicker4.NewInitialValue = Nothing
        Me.LibxDateTimePicker4.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.LibxDateTimePicker4.Requiered = False
        Me.LibxDateTimePicker4.Size = New System.Drawing.Size(112, 20)
        Me.LibxDateTimePicker4.StatusBarPanelDescripcion = Nothing
        Me.LibxDateTimePicker4.TabIndex = 34
        '
        'LibxDateTimePicker3
        '
        Me.LibxDateTimePicker3.CustomFormat = "dd/MM/yyyy"
        Me.LibxDateTimePicker3.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "nomemplrm.fecha_vacaciones"))
        Me.LibxDateTimePicker3.EditInitialValue = Nothing
        Me.LibxDateTimePicker3.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.LibxDateTimePicker3.FieldDescription = ""
        Me.LibxDateTimePicker3.FindInitialValue = Nothing
        Me.LibxDateTimePicker3.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxDateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.LibxDateTimePicker3.IgnoreRequiered = False
        Me.LibxDateTimePicker3.Location = New System.Drawing.Point(608, 136)
        Me.LibxDateTimePicker3.Name = "LibxDateTimePicker3"
        Me.LibxDateTimePicker3.NewInitialValue = Nothing
        Me.LibxDateTimePicker3.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.LibxDateTimePicker3.Requiered = False
        Me.LibxDateTimePicker3.Size = New System.Drawing.Size(112, 20)
        Me.LibxDateTimePicker3.StatusBarPanelDescripcion = Nothing
        Me.LibxDateTimePicker3.TabIndex = 31
        '
        'LibXLookup1
        '
        Me.LibXLookup1.AlternateFieldSearch = Nothing
        Me.LibXLookup1.CheckText = Nothing
        Me.LibXLookup1.ComboMode = False
        Me.LibXLookup1.DataMember = ""
        Me.LibXLookup1.DataSource = Me.LibXConnector1
        Me.LibXLookup1.DestParameters = New String() {"city_code=city_code", "lblcity=city_name"}
        Me.LibXLookup1.FilterField = "city_name"
        Me.LibXLookup1.IgnoreFindInBrowseMode = False
        Me.LibXLookup1.isCanceled = False
        Me.LibXLookup1.Location = New System.Drawing.Point(472, 149)
        Me.LibXLookup1.LookCaption = "Ciudades"
        Me.LibXLookup1.Name = "LibXLookup1"
        Me.LibXLookup1.PopupSize = New System.Drawing.Size(400, 300)
        Me.LibXLookup1.ShowFilter = True
        Me.LibXLookup1.ShowMessageNotFound = True
        Me.LibXLookup1.ShowWarning = False
        Me.LibXLookup1.Size = New System.Drawing.Size(16, 20)
        Me.LibXLookup1.SizesColumns = Nothing
        Me.LibXLookup1.SizesColumnsTab = Nothing
        Me.LibXLookup1.SqlString = Nothing
        Me.LibXLookup1.SQLTab = Nothing
        Me.LibXLookup1.SrcParameters = New String() {"city_code=city_code"}
        Me.LibXLookup1.TabIndex = 5
        Me.LibXLookup1.TableName = "cccity"
        Me.LibXLookup1.TabStop = False
        Me.LibXLookup1.UseCopyConnection = False
        Me.LibXLookup1.UseRowRetrieveEvents = False
        Me.LibXLookup1.UseTab = False
        Me.LibXLookup1.VisParameters = New String() {"Código=city_code", "Descripción=city_name"}
        Me.LibXLookup1.WhereCondition = Nothing
        Me.LibXLookup1.WhereParameters = Nothing
        '
        'txtsexo
        '
        Me.txtsexo.AllowDefaultSort = True
        Me.txtsexo.bound = True
        Me.txtsexo.currValue = Nothing
        Me.txtsexo.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "nomemplrm.sexo"))
        Me.txtsexo.DefaultWhereString = Nothing
        Me.txtsexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtsexo.EditInitialValue = Nothing
        Me.txtsexo.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtsexo.FieldDescription = ""
        Me.txtsexo.FindInitialValue = Nothing
        Me.txtsexo.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtsexo.IgnoreRequiered = False
        Me.txtsexo.Items.AddRange(New Object() {"1-Masculino", "2-Femenino"})
        Me.txtsexo.Location = New System.Drawing.Point(608, 40)
        Me.txtsexo.LookupKeyDisplayFields = Nothing
        Me.txtsexo.LookupKeyField = Nothing
        Me.txtsexo.LookupTableName = Nothing
        Me.txtsexo.Name = "txtsexo"
        Me.txtsexo.NewInitialValue = Nothing
        Me.txtsexo.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtsexo.Requiered = False
        Me.txtsexo.Required = False
        Me.txtsexo.Size = New System.Drawing.Size(112, 21)
        Me.txtsexo.SqlString = Nothing
        Me.txtsexo.StatusBarPanelDescripcion = Nothing
        Me.txtsexo.TabIndex = 27
        '
        'LibxDateTimePicker1
        '
        Me.LibxDateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.LibxDateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "nomemplrm.fecha_nacimiento"))
        Me.LibxDateTimePicker1.EditInitialValue = Nothing
        Me.LibxDateTimePicker1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxDateTimePicker1.FieldDescription = ""
        Me.LibxDateTimePicker1.FindInitialValue = Nothing
        Me.LibxDateTimePicker1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.LibxDateTimePicker1.IgnoreRequiered = False
        Me.LibxDateTimePicker1.Location = New System.Drawing.Point(608, 88)
        Me.LibxDateTimePicker1.Name = "LibxDateTimePicker1"
        Me.LibxDateTimePicker1.NewInitialValue = Nothing
        Me.LibxDateTimePicker1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxDateTimePicker1.Requiered = False
        Me.LibxDateTimePicker1.Size = New System.Drawing.Size(112, 20)
        Me.LibxDateTimePicker1.StatusBarPanelDescripcion = Nothing
        Me.LibxDateTimePicker1.TabIndex = 29
        '
        'Lkp_depto
        '
        Me.Lkp_depto.AlternateFieldSearch = Nothing
        Me.Lkp_depto.CheckText = Nothing
        Me.Lkp_depto.ComboMode = False
        Me.Lkp_depto.DataMember = ""
        Me.Lkp_depto.DataSource = Me.LibXConnector1
        Me.Lkp_depto.DestParameters = New String() {"dept_code=dept_code", "lbldepto=dept_name"}
        Me.Lkp_depto.FilterField = "dept_name"
        Me.Lkp_depto.IgnoreFindInBrowseMode = False
        Me.Lkp_depto.isCanceled = False
        Me.Lkp_depto.Location = New System.Drawing.Point(472, 200)
        Me.Lkp_depto.LookCaption = "Departamentos"
        Me.Lkp_depto.Name = "Lkp_depto"
        Me.Lkp_depto.PopupSize = New System.Drawing.Size(400, 300)
        Me.Lkp_depto.ShowFilter = True
        Me.Lkp_depto.ShowMessageNotFound = True
        Me.Lkp_depto.ShowWarning = False
        Me.Lkp_depto.Size = New System.Drawing.Size(16, 20)
        Me.Lkp_depto.SizesColumns = Nothing
        Me.Lkp_depto.SizesColumnsTab = Nothing
        Me.Lkp_depto.SqlString = Nothing
        Me.Lkp_depto.SQLTab = Nothing
        Me.Lkp_depto.SrcParameters = New String() {"dept_code=dept_code"}
        Me.Lkp_depto.TabIndex = 9
        Me.Lkp_depto.TableName = "cgdeptm"
        Me.Lkp_depto.TabStop = False
        Me.Lkp_depto.UseCopyConnection = False
        Me.Lkp_depto.UseRowRetrieveEvents = False
        Me.Lkp_depto.UseTab = False
        Me.Lkp_depto.VisParameters = New String() {"Código=dept_code", "Descripción=dept_name"}
        Me.Lkp_depto.WhereCondition = Nothing
        Me.Lkp_depto.WhereParameters = Nothing
        '
        'xtb_empl_status
        '
        Me.xtb_empl_status.AllowDefaultSort = True
        Me.xtb_empl_status.bound = True
        Me.xtb_empl_status.currValue = Nothing
        Me.xtb_empl_status.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "nomemplrm.empl_status"))
        Me.xtb_empl_status.DefaultWhereString = Nothing
        Me.xtb_empl_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xtb_empl_status.EditInitialValue = Nothing
        Me.xtb_empl_status.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtb_empl_status.FieldDescription = ""
        Me.xtb_empl_status.FindInitialValue = Nothing
        Me.xtb_empl_status.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtb_empl_status.IgnoreRequiered = False
        Me.xtb_empl_status.Items.AddRange(New Object() {"1-Activo", "2-Vacaciones", "3-Licencia", "4-Cancelado"})
        Me.xtb_empl_status.Location = New System.Drawing.Point(608, 312)
        Me.xtb_empl_status.LookupKeyDisplayFields = Nothing
        Me.xtb_empl_status.LookupKeyField = Nothing
        Me.xtb_empl_status.LookupTableName = Nothing
        Me.xtb_empl_status.Name = "xtb_empl_status"
        Me.xtb_empl_status.NewInitialValue = Nothing
        Me.xtb_empl_status.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtb_empl_status.Requiered = False
        Me.xtb_empl_status.Required = False
        Me.xtb_empl_status.Size = New System.Drawing.Size(112, 21)
        Me.xtb_empl_status.SqlString = Nothing
        Me.xtb_empl_status.StatusBarPanelDescripcion = Nothing
        Me.xtb_empl_status.TabIndex = 39
        '
        'LibXNavigator1
        '
        Me.LibXNavigator1.BuildMenu = True
        Me.LibXNavigator1.Connector = Me.LibXConnector1
        Me.LibXNavigator1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LibXNavigator1.FirstControlInEditMode = Nothing
        Me.LibXNavigator1.FirstControlInFindMode = Nothing
        Me.LibXNavigator1.FirstControlInNewMode = Nothing
        Me.LibXNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.LibXNavigator1.Name = "LibXNavigator1"
        Me.LibXNavigator1.Size = New System.Drawing.Size(762, 24)
        Me.LibXNavigator1.TabIndex = 2
        '
        'BtnCargo
        '
        Me.BtnCargo.Location = New System.Drawing.Point(112, 472)
        Me.BtnCargo.Name = "BtnCargo"
        Me.BtnCargo.Size = New System.Drawing.Size(96, 32)
        Me.BtnCargo.TabIndex = 3
        Me.BtnCargo.Text = "Cargo"
        '
        'BtnNomina
        '
        Me.BtnNomina.Location = New System.Drawing.Point(248, 472)
        Me.BtnNomina.Name = "BtnNomina"
        Me.BtnNomina.Size = New System.Drawing.Size(96, 32)
        Me.BtnNomina.TabIndex = 4
        Me.BtnNomina.Text = "Clase Nomina"
        '
        'i_empleado
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(762, 544)
        Me.Controls.Add(Me.BtnNomina)
        Me.Controls.Add(Me.BtnCargo)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "i_empleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Mantenimiento de Empleados:"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nomemplrm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub LibXConnector1_ExecutedAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutedAction
        Try
            If e.Action = LibX.LibxConnectionActions.Add Then
                xtb_empl_status.currValue = 1
                Me.txtFechaIngreso.Text = LibX.Data.Manager.Connection.GetDate
            End If

            'If e.AcceptedAction = LibX.LibxConnectionActions.Add And _
            'e.Action = LibX.LibxConnectionActions.Accept Then
            '    ShowCosto(LibX.LibxConnectorState.Insert)
            'End If

            If e.AcceptedAction = LibX.LibxConnectionActions.Edit And _
            e.Action = LibX.LibxConnectionActions.Accept Then
                LibXConnector1.LoadDetail()
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub
    Private Sub BtnCargo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCargo.Click
        Dim oParamProg As LibX.LibxPrgParams
        Try
            If Not Me.LibXConnector1.Parameters Is Nothing Then
                oParamProg = New LibX.LibxPrgParams
                oParamProg.AllowDelete = Me.LibXConnector1.Parameters.AllowDelete
                oParamProg.AllowEdit = Me.LibXConnector1.Parameters.AllowEdit
                oParamProg.AllowNew = Me.LibXConnector1.Parameters.AllowNew
                oParamProg.AllowQuery = Me.LibXConnector1.Parameters.AllowQuery
                oParamProg.AllowPrint = Me.LibXConnector1.Parameters.AllowPrint
                oParamProg.IsFromOther = True

                LibX.App.CurrentPrgParams = oParamProg
            End If

            LibX.LibXRunner.Run("i_empcargo", "NOM", True)

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub BtnNomina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNomina.Click
        Dim oParamProg As LibX.LibxPrgParams
        Try
            If Not Me.LibXConnector1.Parameters Is Nothing Then
                oParamProg = New LibX.LibxPrgParams
                oParamProg.AllowDelete = Me.LibXConnector1.Parameters.AllowDelete
                oParamProg.AllowEdit = Me.LibXConnector1.Parameters.AllowEdit
                oParamProg.AllowNew = Me.LibXConnector1.Parameters.AllowNew
                oParamProg.AllowQuery = Me.LibXConnector1.Parameters.AllowQuery
                oParamProg.AllowPrint = Me.LibXConnector1.Parameters.AllowPrint
                oParamProg.IsFromOther = True

                LibX.App.CurrentPrgParams = oParamProg
            End If

            LibX.LibXRunner.Run("i_clasenomina", "NOM", True)

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
End Class

    