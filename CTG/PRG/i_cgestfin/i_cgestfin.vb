Public Class i_cgestfin
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LibXNavigator1 As LibX.LibXNavigator
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents LibXGrid1 As LibX.LibXGrid
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents LibXDbSourceTable2 As LibX.LibXDbSourceTable
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
    Friend WithEvents XTextBox1 As LibX.XTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents XTextBox2 As LibX.XTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents LibxCheckBox1 As LibX.LibxCheckBox
    Friend WithEvents LibxCheckBox2 As LibX.LibxCheckBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents LibxCheckBox3 As LibX.LibxCheckBox
    Friend WithEvents LibxCheckBox4 As LibX.LibxCheckBox
    Friend WithEvents LibxCheckBox5 As LibX.LibxCheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LibXLookup1 As LibX.LibXLookup
    Friend WithEvents XdataGridTableStyle1 As LibX.XdataGridTableStyle
    Friend WithEvents XEditTextBoxColumn1 As LibX.XEditTextBoxColumn
    Friend WithEvents XDataGridTextButtonColumn1 As LibX.XDataGridTextButtonColumn
    Friend WithEvents XEditTextBoxColumn2 As LibX.XEditTextBoxColumn
    Friend WithEvents XDataGridComboBoxColumn1 As LibX.XDataGridComboBoxColumn
    Friend WithEvents XDataGridBoolColumn1 As LibX.XDataGridBoolColumn
    Friend WithEvents XEditTextBoxColumn3 As LibX.XEditTextBoxColumn
    Friend WithEvents xlk_acct_no As LibX.LibXLookup
    Friend WithEvents lbltype_name1 As System.Windows.Forms.Label
    Friend WithEvents lbltype_name2 As System.Windows.Forms.Label
    Friend WithEvents LibXLookup2 As LibX.LibXLookup
    Friend WithEvents xcbo_estfn_code As LibX.LibXCombo
    Friend WithEvents txtNivel1 As LibX.XTextBox
    Friend WithEvents txtNivel2 As LibX.XTextBox
    Friend WithEvents txttype_code1 As LibX.XTextBox
    Friend WithEvents txttype_code2 As LibX.XTextBox
    Friend WithEvents DataColumn20 As System.Data.DataColumn
    Friend WithEvents DataTable2 As System.Data.DataTable
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents DataColumn17 As System.Data.DataColumn
    Friend WithEvents DataColumn18 As System.Data.DataColumn
    Friend WithEvents DataColumn19 As System.Data.DataColumn
    Friend WithEvents LibxCheckBox6 As LibX.LibxCheckBox
    Friend WithEvents DataColumn21 As System.Data.DataColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataColumn22 As System.Data.DataColumn
    Friend WithEvents XEditTextBoxColumn4 As LibX.XEditTextBoxColumn
    Friend WithEvents LibXCombo1 As LibX.LibXCombo
    Friend WithEvents DataColumn23 As System.Data.DataColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.LibXLookup1 = New LibX.LibXLookup
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
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
        Me.DataColumn20 = New System.Data.DataColumn
        Me.DataColumn21 = New System.Data.DataColumn
        Me.DataTable2 = New System.Data.DataTable
        Me.DataColumn13 = New System.Data.DataColumn
        Me.DataColumn14 = New System.Data.DataColumn
        Me.DataColumn15 = New System.Data.DataColumn
        Me.DataColumn16 = New System.Data.DataColumn
        Me.DataColumn17 = New System.Data.DataColumn
        Me.DataColumn18 = New System.Data.DataColumn
        Me.DataColumn19 = New System.Data.DataColumn
        Me.DataColumn22 = New System.Data.DataColumn
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.LibxCheckBox1 = New LibX.LibxCheckBox
        Me.LibxCheckBox2 = New LibX.LibxCheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.XTextBox1 = New LibX.XTextBox
        Me.XTextBox2 = New LibX.XTextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.LibxCheckBox6 = New LibX.LibxCheckBox
        Me.LibxCheckBox3 = New LibX.LibxCheckBox
        Me.LibxCheckBox4 = New LibX.LibxCheckBox
        Me.LibxCheckBox5 = New LibX.LibxCheckBox
        Me.txtNivel1 = New LibX.XTextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtNivel2 = New LibX.XTextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txttype_code1 = New LibX.XTextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txttype_code2 = New LibX.XTextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.lbltype_name1 = New System.Windows.Forms.Label
        Me.lbltype_name2 = New System.Windows.Forms.Label
        Me.LibXLookup2 = New LibX.LibXLookup
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.xlk_acct_no = New LibX.LibXLookup
        Me.LibXGrid1 = New LibX.LibXGrid
        Me.xcbo_estfn_code = New LibX.LibXCombo
        Me.XdataGridTableStyle1 = New LibX.XdataGridTableStyle
        Me.XEditTextBoxColumn1 = New LibX.XEditTextBoxColumn
        Me.XDataGridTextButtonColumn1 = New LibX.XDataGridTextButtonColumn
        Me.XEditTextBoxColumn2 = New LibX.XEditTextBoxColumn
        Me.XDataGridComboBoxColumn1 = New LibX.XDataGridComboBoxColumn
        Me.XDataGridBoolColumn1 = New LibX.XDataGridBoolColumn
        Me.XEditTextBoxColumn3 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn4 = New LibX.XEditTextBoxColumn
        Me.LibXNavigator1 = New LibX.LibXNavigator
        Me.LibXCombo1 = New LibX.LibXCombo
        Me.DataColumn23 = New System.Data.DataColumn
        Me.GroupBox1.SuspendLayout()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LibXGrid1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LibXCombo1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.LibXLookup1)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.XTextBox1)
        Me.GroupBox1.Controls.Add(Me.XTextBox2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.txtNivel1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtNivel2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txttype_code1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txttype_code2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lbltype_name1)
        Me.GroupBox1.Controls.Add(Me.lbltype_name2)
        Me.GroupBox1.Controls.Add(Me.LibXLookup2)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(816, 160)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Encabezado y Criterio:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(568, 128)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(32, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "|"
        '
        'LibXLookup1
        '
        Me.LibXLookup1.AlternateFieldSearch = Nothing
        Me.LibXLookup1.BeginCheck = False
        Me.LibXLookup1.CheckText = Nothing
        Me.LibXLookup1.ComboMode = False
        Me.LibXLookup1.DataMember = Nothing
        Me.LibXLookup1.DataSource = Me.LibXConnector1
        Me.LibXLookup1.DestParameters = New String() {"estfn_type1=acct_type", "lbltype_name1=type_descr"}
        Me.LibXLookup1.FilterField = Nothing
        Me.LibXLookup1.IgnoreFindInBrowseMode = False
        Me.LibXLookup1.isCanceled = False
        Me.LibXLookup1.Location = New System.Drawing.Point(536, 96)
        Me.LibXLookup1.LookCaption = "Grupos de Cuentas"
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
        Me.LibXLookup1.SrcParameters = New String() {"estfn_type1=acct_type"}
        Me.LibXLookup1.TabIndex = 3
        Me.LibXLookup1.TableName = "cgacctpm"
        Me.LibXLookup1.TabStop = False
        Me.LibXLookup1.UseCopyConnection = False
        Me.LibXLookup1.UseRowRetrieveEvents = False
        Me.LibXLookup1.UseTab = False
        Me.LibXLookup1.VisParameters = New String() {"Número=acct_type", "Nombre=type_descr"}
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
        Me.LibXConnector1.DataMember = "cgestfnm"
        Me.LibXConnector1.DataSource = Me.DataSet1
        Me.LibXConnector1.EOF = False
        Me.LibXConnector1.HandledRowsFill = False
        Me.LibXConnector1.HandledUpdates = False
        Me.LibXConnector1.HasRecords = False
        Me.LibXConnector1.IsEditing = False
        Me.LibXConnector1.IsHeaderOnGrid = False
        Me.LibXConnector1.ModuleName = ""
        Me.LibXConnector1.OwnerForm = Me
        Me.LibXConnector1.Parameters = Nothing
        Me.LibXConnector1.RecordCount = 0
        Me.LibXConnector1.ReportMode = False
        Me.LibXConnector1.ReportName = ""
        Me.LibXConnector1.ReportObject = Nothing
        Me.LibXConnector1.RequeryData = False
        Me.LibXConnector1.ShowWarningCancel = True
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.LibXDbSourceTable1, Me.LibXDbSourceTable2})
        Me.LibXConnector1.State = LibX.LibxConnectorState.none
        Me.LibXConnector1.UpdatePrimaryKeyColumns = False
        Me.LibXConnector1.UseTransactions = True
        '
        'DataSet1
        '
        Me.LibXConnector1.SetDataGenerator(Me.DataSet1, Me.LibXConnector1)
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, True)
        Me.DataSet1.EnforceConstraints = False
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1, Me.DataTable2})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn20, Me.DataColumn21, Me.DataColumn23})
        Me.DataTable1.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"estfn_code"}, True)})
        Me.DataTable1.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn1}
        Me.DataTable1.TableName = "cgestfnm"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.AutoIncrement = True
        Me.DataColumn1.ColumnName = "estfn_code"
        Me.DataColumn1.DataType = GetType(System.Int32)
        Me.DataColumn1.ReadOnly = True
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "estfn_name"
        Me.DataColumn2.MaxLength = 40
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "estfn_period"
        Me.DataColumn3.DataType = GetType(System.Int32)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "estfn_fecha"
        Me.DataColumn4.DataType = GetType(System.Int32)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "estfn_inicial"
        Me.DataColumn5.DataType = GetType(System.Int32)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "estfn_mov"
        Me.DataColumn6.DataType = GetType(System.Int32)
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "estfn_bce"
        Me.DataColumn7.DataType = GetType(System.Int32)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "estfn_nivel1"
        Me.DataColumn8.DataType = GetType(System.Int32)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "estfn_nivel2"
        Me.DataColumn9.DataType = GetType(System.Int32)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "estfn_type1"
        Me.DataColumn10.DataType = GetType(System.Int32)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "estfn_type2"
        Me.DataColumn11.DataType = GetType(System.Int32)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "estfn_groupby"
        Me.DataColumn12.DataType = GetType(System.Int32)
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "estfn_initial"
        Me.DataColumn20.DataType = GetType(System.Int32)
        '
        'DataColumn21
        '
        Me.DataColumn21.Caption = "estfn_cta"
        Me.DataColumn21.ColumnName = "estfn_cta"
        Me.DataColumn21.DataType = GetType(System.Int32)
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn22})
        Me.DataTable2.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"estfn_code", "line_no"}, True)})
        Me.DataTable2.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn13, Me.DataColumn14}
        Me.DataTable2.TableName = "cgestfnd"
        '
        'DataColumn13
        '
        Me.DataColumn13.AllowDBNull = False
        Me.DataColumn13.ColumnName = "estfn_code"
        Me.DataColumn13.DataType = GetType(System.Int32)
        '
        'DataColumn14
        '
        Me.DataColumn14.AllowDBNull = False
        Me.DataColumn14.AutoIncrementSeed = CType(1, Long)
        Me.DataColumn14.ColumnName = "line_no"
        Me.DataColumn14.DataType = GetType(System.Int32)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "acct_no"
        Me.DataColumn15.MaxLength = 20
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "acct_descr"
        Me.DataColumn16.MaxLength = 60
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "estfn_anexo"
        Me.DataColumn17.DataType = GetType(System.Int32)
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "estfn_sign"
        Me.DataColumn18.DataType = GetType(System.Int32)
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "estfn_groupid"
        Me.DataColumn19.DataType = GetType(System.Int32)
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "estfn_nivel"
        Me.DataColumn22.DataType = GetType(System.Int32)
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
        Me.LibXDbSourceTable1.SerialColumnName = "estfn_code"
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = Nothing
        Me.LibXDbSourceTable1.TableName = "cgestfnm"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
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
        Me.LibXDbSourceTable2.FillOnRowChange = True
        Me.LibXDbSourceTable2.HeaderIsOnGrid = False
        Me.LibXDbSourceTable2.InnerJon = True
        Me.LibXDbSourceTable2.InsertOrder = 0
        Me.LibXDbSourceTable2.IsDetail = True
        Me.LibXDbSourceTable2.KeyFields = Nothing
        Me.LibXDbSourceTable2.LineColName = Nothing
        Me.LibXDbSourceTable2.MasterDetailRelation = New String() {"estfn_code=estfn_code"}
        Me.LibXDbSourceTable2.MasterTableName = Nothing
        Me.LibXDbSourceTable2.SerialColumnName = Nothing
        Me.LibXDbSourceTable2.Sort = Nothing
        Me.LibXDbSourceTable2.Source = Nothing
        Me.LibXDbSourceTable2.TableName = "cgestfnd"
        Me.LibXDbSourceTable2.UpdateOrder = 0
        Me.LibXDbSourceTable2.UseRowRetrieve = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LibxCheckBox1)
        Me.GroupBox3.Controls.Add(Me.LibxCheckBox2)
        Me.GroupBox3.Location = New System.Drawing.Point(608, 96)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 56)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Criterio"
        '
        'LibxCheckBox1
        '
        Me.LibxCheckBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LibxCheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "cgestfnm.estfn_period"))
        Me.LibxCheckBox1.EditInitialValue = Nothing
        Me.LibxCheckBox1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox1.FindInitialValue = Nothing
        Me.LibxCheckBox1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox1.IgnoreRequiered = False
        Me.LibxCheckBox1.KeepEnabled = False
        Me.LibxCheckBox1.Location = New System.Drawing.Point(8, 16)
        Me.LibxCheckBox1.Name = "LibxCheckBox1"
        Me.LibxCheckBox1.NewInitialValue = Nothing
        Me.LibxCheckBox1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox1.ReadOnly = False
        Me.LibxCheckBox1.Requiered = False
        Me.LibxCheckBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LibxCheckBox1.Size = New System.Drawing.Size(184, 16)
        Me.LibxCheckBox1.TabIndex = 0
        Me.LibxCheckBox1.Text = "Imprimir Por Periodo"
        Me.LibxCheckBox1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LibxCheckBox1.ThreeState = True
        Me.LibxCheckBox1.value = Nothing
        '
        'LibxCheckBox2
        '
        Me.LibxCheckBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LibxCheckBox2.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "cgestfnm.estfn_fecha"))
        Me.LibxCheckBox2.EditInitialValue = Nothing
        Me.LibxCheckBox2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox2.FindInitialValue = Nothing
        Me.LibxCheckBox2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.LibxCheckBox2.IgnoreRequiered = False
        Me.LibxCheckBox2.KeepEnabled = False
        Me.LibxCheckBox2.Location = New System.Drawing.Point(8, 32)
        Me.LibxCheckBox2.Name = "LibxCheckBox2"
        Me.LibxCheckBox2.NewInitialValue = Nothing
        Me.LibxCheckBox2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox2.ReadOnly = False
        Me.LibxCheckBox2.Requiered = False
        Me.LibxCheckBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LibxCheckBox2.Size = New System.Drawing.Size(184, 16)
        Me.LibxCheckBox2.TabIndex = 0
        Me.LibxCheckBox2.Text = "Imprimir Por Fecha"
        Me.LibxCheckBox2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LibxCheckBox2.ThreeState = True
        Me.LibxCheckBox2.value = Nothing
        '
        'Label1
        '
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Estado No.:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XTextBox1
        '
        Me.XTextBox1.AcceptsReturn = True
        Me.XTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cgestfnm.estfn_code"))
        Me.XTextBox1.EditInitialValue = Nothing
        Me.XTextBox1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.FieldDescription = ""
        Me.XTextBox1.FindInitialValue = Nothing
        Me.XTextBox1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.IgnoreRequiered = False
        Me.XTextBox1.Location = New System.Drawing.Point(128, 24)
        Me.XTextBox1.Name = "XTextBox1"
        Me.XTextBox1.NewInitialValue = Nothing
        Me.XTextBox1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.Requiered = False
        Me.XTextBox1.StatusBarPanelDescripcion = Nothing
        Me.XTextBox1.TabIndex = 0
        Me.XTextBox1.Text = ""
        '
        'XTextBox2
        '
        Me.XTextBox2.AcceptsReturn = True
        Me.XTextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.XTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cgestfnm.estfn_name"))
        Me.XTextBox2.EditInitialValue = Nothing
        Me.XTextBox2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.FieldDescription = ""
        Me.XTextBox2.FindInitialValue = Nothing
        Me.XTextBox2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.IgnoreRequiered = False
        Me.XTextBox2.Location = New System.Drawing.Point(128, 48)
        Me.XTextBox2.Name = "XTextBox2"
        Me.XTextBox2.NewInitialValue = Nothing
        Me.XTextBox2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.Requiered = False
        Me.XTextBox2.Size = New System.Drawing.Size(424, 20)
        Me.XTextBox2.StatusBarPanelDescripcion = Nothing
        Me.XTextBox2.TabIndex = 0
        Me.XTextBox2.Text = ""
        '
        'Label2
        '
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(16, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descripción:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.LibxCheckBox6)
        Me.GroupBox4.Controls.Add(Me.LibxCheckBox3)
        Me.GroupBox4.Controls.Add(Me.LibxCheckBox4)
        Me.GroupBox4.Controls.Add(Me.LibxCheckBox5)
        Me.GroupBox4.Location = New System.Drawing.Point(608, 8)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(200, 88)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Presentación"
        '
        'LibxCheckBox6
        '
        Me.LibxCheckBox6.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LibxCheckBox6.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "cgestfnm.estfn_cta"))
        Me.LibxCheckBox6.EditInitialValue = Nothing
        Me.LibxCheckBox6.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox6.FindInitialValue = Nothing
        Me.LibxCheckBox6.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.LibxCheckBox6.IgnoreRequiered = False
        Me.LibxCheckBox6.KeepEnabled = False
        Me.LibxCheckBox6.Location = New System.Drawing.Point(8, 16)
        Me.LibxCheckBox6.Name = "LibxCheckBox6"
        Me.LibxCheckBox6.NewInitialValue = Nothing
        Me.LibxCheckBox6.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox6.ReadOnly = False
        Me.LibxCheckBox6.Requiered = False
        Me.LibxCheckBox6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LibxCheckBox6.Size = New System.Drawing.Size(184, 16)
        Me.LibxCheckBox6.TabIndex = 1
        Me.LibxCheckBox6.Text = "Incluir No. Cuenta"
        Me.LibxCheckBox6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LibxCheckBox6.ThreeState = True
        Me.LibxCheckBox6.value = Nothing
        '
        'LibxCheckBox3
        '
        Me.LibxCheckBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LibxCheckBox3.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "cgestfnm.estfn_inicial"))
        Me.LibxCheckBox3.EditInitialValue = Nothing
        Me.LibxCheckBox3.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox3.FindInitialValue = Nothing
        Me.LibxCheckBox3.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.LibxCheckBox3.IgnoreRequiered = False
        Me.LibxCheckBox3.KeepEnabled = False
        Me.LibxCheckBox3.Location = New System.Drawing.Point(8, 32)
        Me.LibxCheckBox3.Name = "LibxCheckBox3"
        Me.LibxCheckBox3.NewInitialValue = Nothing
        Me.LibxCheckBox3.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox3.ReadOnly = False
        Me.LibxCheckBox3.Requiered = False
        Me.LibxCheckBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LibxCheckBox3.Size = New System.Drawing.Size(184, 16)
        Me.LibxCheckBox3.TabIndex = 0
        Me.LibxCheckBox3.Text = "Incluir Balance inicial"
        Me.LibxCheckBox3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LibxCheckBox3.ThreeState = True
        Me.LibxCheckBox3.value = Nothing
        '
        'LibxCheckBox4
        '
        Me.LibxCheckBox4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LibxCheckBox4.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "cgestfnm.estfn_mov"))
        Me.LibxCheckBox4.EditInitialValue = Nothing
        Me.LibxCheckBox4.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox4.FindInitialValue = Nothing
        Me.LibxCheckBox4.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.LibxCheckBox4.IgnoreRequiered = False
        Me.LibxCheckBox4.KeepEnabled = False
        Me.LibxCheckBox4.Location = New System.Drawing.Point(8, 48)
        Me.LibxCheckBox4.Name = "LibxCheckBox4"
        Me.LibxCheckBox4.NewInitialValue = Nothing
        Me.LibxCheckBox4.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox4.ReadOnly = False
        Me.LibxCheckBox4.Requiered = False
        Me.LibxCheckBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LibxCheckBox4.Size = New System.Drawing.Size(184, 16)
        Me.LibxCheckBox4.TabIndex = 0
        Me.LibxCheckBox4.Text = "Incluir Movimientos"
        Me.LibxCheckBox4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LibxCheckBox4.ThreeState = True
        Me.LibxCheckBox4.value = Nothing
        '
        'LibxCheckBox5
        '
        Me.LibxCheckBox5.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LibxCheckBox5.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "cgestfnm.estfn_bce"))
        Me.LibxCheckBox5.EditInitialValue = Nothing
        Me.LibxCheckBox5.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox5.FindInitialValue = Nothing
        Me.LibxCheckBox5.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.LibxCheckBox5.IgnoreRequiered = False
        Me.LibxCheckBox5.KeepEnabled = False
        Me.LibxCheckBox5.Location = New System.Drawing.Point(8, 64)
        Me.LibxCheckBox5.Name = "LibxCheckBox5"
        Me.LibxCheckBox5.NewInitialValue = Nothing
        Me.LibxCheckBox5.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox5.ReadOnly = False
        Me.LibxCheckBox5.Requiered = False
        Me.LibxCheckBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LibxCheckBox5.Size = New System.Drawing.Size(184, 16)
        Me.LibxCheckBox5.TabIndex = 0
        Me.LibxCheckBox5.Text = "Incluir Balance Actual"
        Me.LibxCheckBox5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LibxCheckBox5.ThreeState = True
        Me.LibxCheckBox5.value = Nothing
        '
        'txtNivel1
        '
        Me.txtNivel1.AcceptsReturn = True
        Me.txtNivel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cgestfnm.estfn_nivel1"))
        Me.txtNivel1.EditInitialValue = Nothing
        Me.txtNivel1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtNivel1.FieldDescription = ""
        Me.txtNivel1.FindInitialValue = Nothing
        Me.txtNivel1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtNivel1.IgnoreRequiered = False
        Me.txtNivel1.Location = New System.Drawing.Point(128, 72)
        Me.txtNivel1.Name = "txtNivel1"
        Me.txtNivel1.NewInitialValue = Nothing
        Me.txtNivel1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtNivel1.Requiered = False
        Me.txtNivel1.StatusBarPanelDescripcion = Nothing
        Me.txtNivel1.TabIndex = 0
        Me.txtNivel1.Text = ""
        '
        'Label3
        '
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(16, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nivel Inicial:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtNivel2
        '
        Me.txtNivel2.AcceptsReturn = True
        Me.txtNivel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cgestfnm.estfn_nivel2"))
        Me.txtNivel2.EditInitialValue = Nothing
        Me.txtNivel2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtNivel2.FieldDescription = ""
        Me.txtNivel2.FindInitialValue = Nothing
        Me.txtNivel2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtNivel2.IgnoreRequiered = False
        Me.txtNivel2.Location = New System.Drawing.Point(452, 72)
        Me.txtNivel2.Name = "txtNivel2"
        Me.txtNivel2.NewInitialValue = Nothing
        Me.txtNivel2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtNivel2.Requiered = False
        Me.txtNivel2.StatusBarPanelDescripcion = Nothing
        Me.txtNivel2.TabIndex = 0
        Me.txtNivel2.Text = ""
        '
        'Label4
        '
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(344, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 16)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Nivel Final:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txttype_code1
        '
        Me.txttype_code1.AcceptsReturn = True
        Me.txttype_code1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cgestfnm.estfn_type1"))
        Me.txttype_code1.EditInitialValue = Nothing
        Me.txttype_code1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txttype_code1.FieldDescription = ""
        Me.txttype_code1.FindInitialValue = Nothing
        Me.txttype_code1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txttype_code1.IgnoreRequiered = False
        Me.txttype_code1.Location = New System.Drawing.Point(128, 96)
        Me.txttype_code1.Name = "txttype_code1"
        Me.txttype_code1.NewInitialValue = Nothing
        Me.txttype_code1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txttype_code1.Requiered = False
        Me.txttype_code1.StatusBarPanelDescripcion = Nothing
        Me.txttype_code1.TabIndex = 0
        Me.txttype_code1.Text = ""
        '
        'Label5
        '
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(16, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 16)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Grupo Inicial:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txttype_code2
        '
        Me.txttype_code2.AcceptsReturn = True
        Me.txttype_code2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cgestfnm.estfn_type2"))
        Me.txttype_code2.EditInitialValue = Nothing
        Me.txttype_code2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txttype_code2.FieldDescription = ""
        Me.txttype_code2.FindInitialValue = Nothing
        Me.txttype_code2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txttype_code2.IgnoreRequiered = False
        Me.txttype_code2.Location = New System.Drawing.Point(128, 120)
        Me.txttype_code2.Name = "txttype_code2"
        Me.txttype_code2.NewInitialValue = Nothing
        Me.txttype_code2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txttype_code2.Requiered = False
        Me.txttype_code2.StatusBarPanelDescripcion = Nothing
        Me.txttype_code2.TabIndex = 0
        Me.txttype_code2.Text = ""
        '
        'Label6
        '
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(16, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 16)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Grupo Final:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbltype_name1
        '
        Me.lbltype_name1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbltype_name1.Location = New System.Drawing.Point(232, 96)
        Me.lbltype_name1.Name = "lbltype_name1"
        Me.lbltype_name1.Size = New System.Drawing.Size(304, 20)
        Me.lbltype_name1.TabIndex = 1
        '
        'lbltype_name2
        '
        Me.lbltype_name2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbltype_name2.Location = New System.Drawing.Point(232, 120)
        Me.lbltype_name2.Name = "lbltype_name2"
        Me.lbltype_name2.Size = New System.Drawing.Size(304, 20)
        Me.lbltype_name2.TabIndex = 1
        '
        'LibXLookup2
        '
        Me.LibXLookup2.AlternateFieldSearch = Nothing
        Me.LibXLookup2.BeginCheck = False
        Me.LibXLookup2.CheckText = Nothing
        Me.LibXLookup2.ComboMode = False
        Me.LibXLookup2.DataMember = Nothing
        Me.LibXLookup2.DataSource = Me.LibXConnector1
        Me.LibXLookup2.DestParameters = New String() {"estfn_type2=acct_type", "lbltype_name2=type_descr"}
        Me.LibXLookup2.FilterField = Nothing
        Me.LibXLookup2.IgnoreFindInBrowseMode = False
        Me.LibXLookup2.isCanceled = False
        Me.LibXLookup2.Location = New System.Drawing.Point(536, 120)
        Me.LibXLookup2.LookCaption = "Grupos de Cuentas"
        Me.LibXLookup2.Name = "LibXLookup2"
        Me.LibXLookup2.PopupSize = New System.Drawing.Size(0, 0)
        Me.LibXLookup2.ShowFilter = True
        Me.LibXLookup2.ShowMessageNotFound = True
        Me.LibXLookup2.ShowWarning = False
        Me.LibXLookup2.Size = New System.Drawing.Size(16, 20)
        Me.LibXLookup2.SizesColumns = Nothing
        Me.LibXLookup2.SizesColumnsTab = Nothing
        Me.LibXLookup2.SqlString = Nothing
        Me.LibXLookup2.SQLTab = Nothing
        Me.LibXLookup2.SrcParameters = New String() {"estfn_type2=acct_type"}
        Me.LibXLookup2.TabIndex = 3
        Me.LibXLookup2.TableName = "cgacctpm"
        Me.LibXLookup2.TabStop = False
        Me.LibXLookup2.UseCopyConnection = False
        Me.LibXLookup2.UseRowRetrieveEvents = False
        Me.LibXLookup2.UseTab = False
        Me.LibXLookup2.VisParameters = New String() {"Número=acct_type", "Nombre=type_descr"}
        Me.LibXLookup2.WhereCondition = Nothing
        Me.LibXLookup2.WhereParameters = Nothing
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.xlk_acct_no)
        Me.GroupBox2.Controls.Add(Me.LibXGrid1)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 200)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(816, 328)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalle"
        '
        'xlk_acct_no
        '
        Me.xlk_acct_no.AlternateFieldSearch = Nothing
        Me.xlk_acct_no.BeginCheck = False
        Me.xlk_acct_no.CheckText = Nothing
        Me.xlk_acct_no.ComboMode = False
        Me.xlk_acct_no.DataMember = Nothing
        Me.xlk_acct_no.DataSource = Me.LibXConnector1
        Me.xlk_acct_no.DestParameters = New String() {"acct_no=acct_no", "acct_descr=acct_name"}
        Me.xlk_acct_no.FilterField = "acct_name"
        Me.xlk_acct_no.IgnoreFindInBrowseMode = True
        Me.xlk_acct_no.isCanceled = False
        Me.xlk_acct_no.Location = New System.Drawing.Point(456, 24)
        Me.xlk_acct_no.LookCaption = "Catalogo de Cuenta"
        Me.xlk_acct_no.Name = "xlk_acct_no"
        Me.xlk_acct_no.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_acct_no.ShowFilter = True
        Me.xlk_acct_no.ShowMessageNotFound = True
        Me.xlk_acct_no.ShowWarning = False
        Me.xlk_acct_no.Size = New System.Drawing.Size(16, 20)
        Me.xlk_acct_no.SizesColumns = Nothing
        Me.xlk_acct_no.SizesColumnsTab = Nothing
        Me.xlk_acct_no.SqlString = Nothing
        Me.xlk_acct_no.SQLTab = Nothing
        Me.xlk_acct_no.SrcParameters = New String() {"acct_no=acct_no"}
        Me.xlk_acct_no.TabIndex = 1
        Me.xlk_acct_no.TableName = "cgacctm"
        Me.xlk_acct_no.TabStop = False
        Me.xlk_acct_no.UseCopyConnection = False
        Me.xlk_acct_no.UseRowRetrieveEvents = False
        Me.xlk_acct_no.UseTab = False
        Me.xlk_acct_no.VisParameters = New String() {"No. Cuenta=acct_no", "Nombre Cuenta=acct_name"}
        Me.xlk_acct_no.WhereCondition = Nothing
        Me.xlk_acct_no.WhereParameters = Nothing
        '
        'LibXGrid1
        '
        Me.LibXGrid1.AutoAdjustLastColumn = True
        Me.LibXGrid1.AutoSearch = False
        Me.LibXGrid1.BackgroundColor = System.Drawing.Color.White
        Me.LibXGrid1.CaptionText = "Detalles de Cuentas"
        Me.LibXGrid1.Controls.Add(Me.xcbo_estfn_code)
        Me.LibXGrid1.DataMember = "cgestfnd"
        Me.LibXGrid1.DataSource = Me.DataSet1
        Me.LibXGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LibXGrid1.FullRowSelect = False
        Me.LibXGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGrid1.IsReadOnly = False
        Me.LibXGrid1.Location = New System.Drawing.Point(3, 16)
        Me.LibXGrid1.Name = "LibXGrid1"
        Me.LibXGrid1.ReadOnly = True
        Me.LibXGrid1.searchText = ""
        Me.LibXGrid1.showFooterBar = False
        Me.LibXGrid1.Size = New System.Drawing.Size(810, 309)
        Me.LibXGrid1.TabIndex = 0
        Me.LibXGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.XdataGridTableStyle1})
        Me.LibXGrid1.UseAutoFillLines = True
        Me.LibXGrid1.UseHandCursor = False
        '
        'xcbo_estfn_code
        '
        Me.xcbo_estfn_code.AllowDefaultSort = True
        Me.xcbo_estfn_code.bound = True
        Me.xcbo_estfn_code.currValue = Nothing
        Me.xcbo_estfn_code.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "cgestfnd.estfn_anexo"))
        Me.xcbo_estfn_code.DefaultWhereString = Nothing
        Me.xcbo_estfn_code.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_estfn_code.EditInitialValue = Nothing
        Me.xcbo_estfn_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_estfn_code.FieldDescription = ""
        Me.xcbo_estfn_code.FindInitialValue = Nothing
        Me.xcbo_estfn_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_estfn_code.IgnoreRequiered = False
        Me.xcbo_estfn_code.Location = New System.Drawing.Point(528, 32)
        Me.xcbo_estfn_code.LookupKeyDisplayFields = "estfn_name"
        Me.xcbo_estfn_code.LookupKeyField = "estfn_code"
        Me.xcbo_estfn_code.LookupTableName = "cgestfnm"
        Me.xcbo_estfn_code.Name = "xcbo_estfn_code"
        Me.xcbo_estfn_code.NewInitialValue = Nothing
        Me.xcbo_estfn_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_estfn_code.Requiered = False
        Me.xcbo_estfn_code.Required = False
        Me.xcbo_estfn_code.Size = New System.Drawing.Size(121, 21)
        Me.xcbo_estfn_code.SqlString = Nothing
        Me.xcbo_estfn_code.StatusBarPanelDescripcion = Nothing
        Me.xcbo_estfn_code.TabIndex = 2
        '
        'XdataGridTableStyle1
        '
        Me.XdataGridTableStyle1.DataGrid = Me.LibXGrid1
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.XEditTextBoxColumn1, Me.XDataGridTextButtonColumn1, Me.XEditTextBoxColumn2, Me.XDataGridComboBoxColumn1, Me.XDataGridBoolColumn1, Me.XEditTextBoxColumn3, Me.XEditTextBoxColumn4})
        Me.XdataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle1.MappingName = "cgestfnd"
        '
        'XEditTextBoxColumn1
        '
        Me.XEditTextBoxColumn1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn1.Format = ""
        Me.XEditTextBoxColumn1.FormatInfo = Nothing
        Me.XEditTextBoxColumn1.HeaderText = "No."
        Me.XEditTextBoxColumn1.ImageList = Nothing
        Me.XEditTextBoxColumn1.isReadOnly = False
        Me.XEditTextBoxColumn1.MappingName = "line_no"
        Me.XEditTextBoxColumn1.MaxLength = 32767
        Me.XEditTextBoxColumn1.TabStop = True
        Me.XEditTextBoxColumn1.UseCustomCellFormat = False
        Me.XEditTextBoxColumn1.Width = 40
        '
        'XDataGridTextButtonColumn1
        '
        Me.XDataGridTextButtonColumn1.ButtonType = LibX.XDataGridTextButtonColumn.XDataGridTextButtonColumnButtonTypes.SpinButton
        Me.XDataGridTextButtonColumn1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XDataGridTextButtonColumn1.executeFindDuringFill = False
        Me.XDataGridTextButtonColumn1.Format = ""
        Me.XDataGridTextButtonColumn1.FormatInfo = Nothing
        Me.XDataGridTextButtonColumn1.HeaderText = "No. Cuenta"
        Me.XDataGridTextButtonColumn1.isReadOnly = False
        Me.XDataGridTextButtonColumn1.Lookup = Me.xlk_acct_no
        Me.XDataGridTextButtonColumn1.MappingName = "acct_no"
        Me.XDataGridTextButtonColumn1.MaxLength = 32767
        Me.XDataGridTextButtonColumn1.TabStop = True
        Me.XDataGridTextButtonColumn1.UseCustomCellFormat = False
        Me.XDataGridTextButtonColumn1.Width = 130
        '
        'XEditTextBoxColumn2
        '
        Me.XEditTextBoxColumn2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn2.Format = ""
        Me.XEditTextBoxColumn2.FormatInfo = Nothing
        Me.XEditTextBoxColumn2.HeaderText = "Descripción"
        Me.XEditTextBoxColumn2.ImageList = Nothing
        Me.XEditTextBoxColumn2.isReadOnly = False
        Me.XEditTextBoxColumn2.MappingName = "acct_descr"
        Me.XEditTextBoxColumn2.MaxLength = 32767
        Me.XEditTextBoxColumn2.TabStop = True
        Me.XEditTextBoxColumn2.UseCustomCellFormat = False
        Me.XEditTextBoxColumn2.Width = 285
        '
        'XDataGridComboBoxColumn1
        '
        Me.XDataGridComboBoxColumn1.ComboBox = Me.xcbo_estfn_code
        Me.XDataGridComboBoxColumn1.Format = ""
        Me.XDataGridComboBoxColumn1.FormatInfo = Nothing
        Me.XDataGridComboBoxColumn1.HeaderText = "Anexo"
        Me.XDataGridComboBoxColumn1.isReadOnly = False
        Me.XDataGridComboBoxColumn1.MappingName = "estfn_anexo"
        Me.XDataGridComboBoxColumn1.Width = 101
        '
        'XDataGridBoolColumn1
        '
        Me.XDataGridBoolColumn1.FalseValue = CType(0, Short)
        Me.XDataGridBoolColumn1.HeaderText = "Invertir Signo"
        Me.XDataGridBoolColumn1.MappingName = "estfn_sign"
        Me.XDataGridBoolColumn1.NullValue = 0
        Me.XDataGridBoolColumn1.TrueValue = CType(1, Short)
        Me.XDataGridBoolColumn1.UseCustomCellFormat = False
        Me.XDataGridBoolColumn1.Width = 75
        '
        'XEditTextBoxColumn3
        '
        Me.XEditTextBoxColumn3.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn3.Format = ""
        Me.XEditTextBoxColumn3.FormatInfo = Nothing
        Me.XEditTextBoxColumn3.HeaderText = "Grupo ID"
        Me.XEditTextBoxColumn3.ImageList = Nothing
        Me.XEditTextBoxColumn3.isReadOnly = False
        Me.XEditTextBoxColumn3.MappingName = "estfn_groupid"
        Me.XEditTextBoxColumn3.MaxLength = 32767
        Me.XEditTextBoxColumn3.TabStop = True
        Me.XEditTextBoxColumn3.UseCustomCellFormat = False
        Me.XEditTextBoxColumn3.Width = 65
        '
        'XEditTextBoxColumn4
        '
        Me.XEditTextBoxColumn4.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn4.Format = ""
        Me.XEditTextBoxColumn4.FormatInfo = Nothing
        Me.XEditTextBoxColumn4.HeaderText = "Nivel ID"
        Me.XEditTextBoxColumn4.ImageList = Nothing
        Me.XEditTextBoxColumn4.isReadOnly = False
        Me.XEditTextBoxColumn4.MappingName = "estfn_nivel"
        Me.XEditTextBoxColumn4.MaxLength = 32767
        Me.XEditTextBoxColumn4.TabStop = True
        Me.XEditTextBoxColumn4.UseCustomCellFormat = False
        Me.XEditTextBoxColumn4.Width = 45
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
        Me.LibXNavigator1.Size = New System.Drawing.Size(864, 24)
        Me.LibXNavigator1.TabIndex = 2
        '
        'LibXCombo1
        '
        Me.LibXCombo1.AllowDefaultSort = True
        Me.LibXCombo1.bound = True
        Me.LibXCombo1.currValue = Nothing
        Me.LibXCombo1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "cgestfnm.estfn_tipo"))
        Me.LibXCombo1.DefaultWhereString = Nothing
        Me.LibXCombo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LibXCombo1.EditInitialValue = Nothing
        Me.LibXCombo1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.FieldDescription = ""
        Me.LibXCombo1.FindInitialValue = Nothing
        Me.LibXCombo1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.IgnoreRequiered = False
        Me.LibXCombo1.Items.AddRange(New Object() {"1-ESTADO DE RESULTADO", "2-BALANCE GENERAL"})
        Me.LibXCombo1.Location = New System.Drawing.Point(336, 24)
        Me.LibXCombo1.LookupKeyDisplayFields = Nothing
        Me.LibXCombo1.LookupKeyField = Nothing
        Me.LibXCombo1.LookupTableName = Nothing
        Me.LibXCombo1.Name = "LibXCombo1"
        Me.LibXCombo1.NewInitialValue = Nothing
        Me.LibXCombo1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.Requiered = False
        Me.LibXCombo1.Required = False
        Me.LibXCombo1.Size = New System.Drawing.Size(216, 21)
        Me.LibXCombo1.SqlString = Nothing
        Me.LibXCombo1.StatusBarPanelDescripcion = Nothing
        Me.LibXCombo1.TabIndex = 5
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "estfn_tipo"
        Me.DataColumn23.DataType = GetType(System.Int32)
        '
        'i_cgestfin
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(864, 566)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "i_cgestfin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Definición de Estados Financieros"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LibXGrid1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub xlk_acct_no_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.BeforeExecuteQueryEventArgs) Handles xlk_acct_no.BeforeExecuteQuery
        If Val(txttype_code1.Text.Trim) > 0 Then
            e.aditionalWhere = String.Concat("acct_type between ", txttype_code1.Text, " and ", txttype_code2.Text)
        End If

        If Val(txtNivel1.Text.Trim) > 0 Then
            If e.aditionalWhere.Trim.Length > 0 Then
                e.aditionalWhere = String.Concat(e.aditionalWhere, " and acct_nivel between ", txtNivel1.Text, " and ", txtNivel2.Text)
            Else
                e.aditionalWhere = String.Concat("acct_nivel between ", txtNivel1.Text, " and ", txtNivel2.Text)
            End If
        End If
    End Sub

    Private Sub LibXNavigator1_AfterClick(ByVal sender As Object, ByVal e As XMsaComponents.XMsaActionClickEventArgs) Handles LibXNavigator1.AfterClick
        Try
            If e.ButtonAction = XMsaComponents.XmsaButtons.Print Then

            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        LoadCuentas()
    End Sub

    Private Sub LoadCuentas()
        Dim SelectStmt As String
        Dim oTable As DataTable

        SelectStmt = "select * from cgacctm "

        If LibXConnector1.CurrentDataRow!estfn_nivel1.ToString.Trim <> "" Then
            SelectStmt = LibX.ConcatWherePart(SelectStmt.Trim, "acct_nivel >= " & LibXConnector1.CurrentDataRow!estfn_nivel1.ToString.Trim)
        End If

        If LibXConnector1.CurrentDataRow!estfn_nivel2.ToString.Trim <> "" Then
            SelectStmt = LibX.ConcatWherePart(SelectStmt.Trim, "acct_nivel <= " & LibXConnector1.CurrentDataRow!estfn_nivel2.ToString.Trim)
        End If

        If LibXConnector1.CurrentDataRow!estfn_type1.ToString.Trim <> "" Then
            SelectStmt = LibX.ConcatWherePart(SelectStmt.Trim, "acct_type >= " & LibXConnector1.CurrentDataRow!estfn_type1.ToString.Trim)
        End If

        If LibXConnector1.CurrentDataRow!estfn_type2.ToString.Trim <> "" Then
            SelectStmt = LibX.ConcatWherePart(SelectStmt.Trim, "acct_type <= " & LibXConnector1.CurrentDataRow!estfn_type2.ToString.Trim)
        End If

        oTable = LibX.Data.Manager.GetDataTable(SelectStmt)

        If oTable.Rows.Count <= 0 Then
            Exit Sub
        End If

        For Each oRow As DataRow In oTable.Rows
            Dim oRowEstf As DataRow = DataSet1.Tables("cgestfnd").NewRow

            With oRowEstf
                !acct_no = oRow!acct_no
                !acct_descr = oRow!acct_name
                !estfn_groupid = oRow!acct_type
            End With

            DataSet1.Tables("cgestfnd").Rows.Add(oRowEstf)
        Next
    End Sub

    Private Sub LibXConnector1_InsertingDetailRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatingEventArgs) Handles LibXConnector1.InsertingDetailRow
        If e.UpdatingArgs.StatementType = StatementType.Insert Then

        End If
    End Sub

    Private Sub DataTable2_RowChanging(ByVal sender As Object, ByVal e As System.Data.DataRowChangeEventArgs) Handles DataTable2.RowChanging

    End Sub

    Private Sub DataTable2_RowChanged(ByVal sender As Object, ByVal e As System.Data.DataRowChangeEventArgs) Handles DataTable2.RowChanged
        If e.Action = DataRowAction.Add Then
            e.Row!line_no = DataSet1.Tables("cgestfnd").Compute("count(line_no)", "") + 1
        End If
    End Sub

    Private Sub LibXGrid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles LibXGrid1.Navigate

    End Sub
End Class
