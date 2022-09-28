Public Class i_sgplanm01
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
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LibXNavigator1 As LibX.LibXNavigator
    'Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents LibXLookup1 As LibX.LibXLookup
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents LibXDbSourceTable2 As LibX.LibXDbSourceTable
    Friend WithEvents DataColumn28 As System.Data.DataColumn
    Friend WithEvents DataColumn29 As System.Data.DataColumn
    Friend WithEvents DataColumn30 As System.Data.DataColumn
    Friend WithEvents DataColumn31 As System.Data.DataColumn
    Friend WithEvents DataColumn32 As System.Data.DataColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents lblcia_name As System.Windows.Forms.Label
    Friend WithEvents xlk_cia_code As LibX.LibXLookup
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LibXCombo1 As LibX.LibXCombo
    Friend WithEvents LibXGrid1 As LibX.LibXGrid
    Friend WithEvents XdataGridTableStyle1 As LibX.XdataGridTableStyle
    Friend WithEvents XEditTextBoxColumn1 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn2 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn3 As LibX.XEditTextBoxColumn
    Friend WithEvents xlk_group_code As LibX.LibXLookup
    Friend WithEvents xlk_sgroup_code As LibX.LibXLookup
    Friend WithEvents xlk_item_code As LibX.LibXLookup
    Friend WithEvents gColgroup_code As LibX.XDataGridTextButtonColumn
    Friend WithEvents gColsgroup_code As LibX.XDataGridTextButtonColumn
    Friend WithEvents gcolitem_code As LibX.XDataGridTextButtonColumn
    Friend WithEvents xcbo_status As LibX.LibXCombo
    Friend WithEvents gGcolStatus As LibX.XDataGridComboBoxColumn
    Friend WithEvents sgplanm As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents sgcobrm As System.Data.DataTable
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents xtxt_plan_descuento As System.Windows.Forms.TextBox
    Friend WithEvents xtxt_plan_cobertura As System.Windows.Forms.TextBox
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents xlk_cust_code As LibX.LibXLookup
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cust_name As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.xtxt_plan_descuento = New System.Windows.Forms.TextBox
        Me.DataSet1 = New System.Data.DataSet
        Me.sgplanm = New System.Data.DataTable
        Me.DataColumn28 = New System.Data.DataColumn
        Me.DataColumn29 = New System.Data.DataColumn
        Me.DataColumn30 = New System.Data.DataColumn
        Me.DataColumn31 = New System.Data.DataColumn
        Me.DataColumn32 = New System.Data.DataColumn
        Me.DataColumn10 = New System.Data.DataColumn
        Me.DataColumn11 = New System.Data.DataColumn
        Me.sgcobrm = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn7 = New System.Data.DataColumn
        Me.DataColumn8 = New System.Data.DataColumn
        Me.DataColumn9 = New System.Data.DataColumn
        Me.Label4 = New System.Windows.Forms.Label
        Me.xcbo_status = New LibX.LibXCombo
        Me.xlk_item_code = New LibX.LibXLookup
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.xlk_sgroup_code = New LibX.LibXLookup
        Me.xlk_group_code = New LibX.LibXLookup
        Me.LibXCombo1 = New LibX.LibXCombo
        Me.Label6 = New System.Windows.Forms.Label
        Me.xtxt_plan_cobertura = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.xlk_cia_code = New LibX.LibXLookup
        Me.lblcia_name = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.LibXLookup1 = New LibX.LibXLookup
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.xlk_cust_code = New LibX.LibXLookup
        Me.Label7 = New System.Windows.Forms.Label
        Me.cust_name = New System.Windows.Forms.Label
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.LibXNavigator1 = New LibX.LibXNavigator
        Me.LibXGrid1 = New LibX.LibXGrid
        Me.XdataGridTableStyle1 = New LibX.XdataGridTableStyle
        Me.gColgroup_code = New LibX.XDataGridTextButtonColumn
        Me.XEditTextBoxColumn1 = New LibX.XEditTextBoxColumn
        Me.gColsgroup_code = New LibX.XDataGridTextButtonColumn
        Me.XEditTextBoxColumn2 = New LibX.XEditTextBoxColumn
        Me.gcolitem_code = New LibX.XDataGridTextButtonColumn
        Me.XEditTextBoxColumn3 = New LibX.XEditTextBoxColumn
        Me.gGcolStatus = New LibX.XDataGridComboBoxColumn
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sgplanm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sgcobrm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.xtxt_plan_descuento)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.xlk_item_code)
        Me.GroupBox1.Controls.Add(Me.xcbo_status)
        Me.GroupBox1.Controls.Add(Me.xlk_sgroup_code)
        Me.GroupBox1.Controls.Add(Me.xlk_group_code)
        Me.GroupBox1.Controls.Add(Me.LibXCombo1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.xtxt_plan_cobertura)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.xlk_cia_code)
        Me.GroupBox1.Controls.Add(Me.lblcia_name)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.LibXLookup1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.xlk_cust_code)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cust_name)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(784, 128)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'xtxt_plan_descuento
        '
        Me.xtxt_plan_descuento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xtxt_plan_descuento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "sgplanm.plan_descto"))
        Me.xtxt_plan_descuento.Location = New System.Drawing.Point(608, 72)
        Me.xtxt_plan_descuento.Name = "xtxt_plan_descuento"
        Me.xtxt_plan_descuento.Size = New System.Drawing.Size(64, 20)
        Me.xtxt_plan_descuento.TabIndex = 6
        Me.xtxt_plan_descuento.Text = ""
        '
        'DataSet1
        '
        Me.LibXConnector1.SetDataGenerator(Me.DataSet1, Me.LibXConnector1)
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, True)
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.sgplanm, Me.sgcobrm})
        '
        'sgplanm
        '
        Me.sgplanm.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn10, Me.DataColumn11})
        Me.sgplanm.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"plan_serial"}, True)})
        Me.sgplanm.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn28}
        Me.sgplanm.TableName = "sgplanm"
        '
        'DataColumn28
        '
        Me.DataColumn28.AllowDBNull = False
        Me.DataColumn28.AutoIncrement = True
        Me.DataColumn28.ColumnName = "plan_serial"
        Me.DataColumn28.DataType = GetType(System.Int32)
        Me.DataColumn28.ReadOnly = True
        '
        'DataColumn29
        '
        Me.DataColumn29.AllowDBNull = False
        Me.DataColumn29.ColumnName = "cia_serial"
        Me.DataColumn29.DataType = GetType(System.Int32)
        '
        'DataColumn30
        '
        Me.DataColumn30.AllowDBNull = False
        Me.DataColumn30.ColumnName = "plan_name"
        Me.DataColumn30.MaxLength = 80
        '
        'DataColumn31
        '
        Me.DataColumn31.AllowDBNull = False
        Me.DataColumn31.ColumnName = "plan_cobertura"
        Me.DataColumn31.DataType = GetType(System.Int32)
        '
        'DataColumn32
        '
        Me.DataColumn32.AllowDBNull = False
        Me.DataColumn32.ColumnName = "plan_status"
        Me.DataColumn32.DataType = GetType(System.Int32)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "plan_descto"
        Me.DataColumn10.DataType = GetType(System.Int32)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "cust_code"
        Me.DataColumn11.DataType = GetType(System.Int32)
        '
        'sgcobrm
        '
        Me.sgcobrm.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9})
        Me.sgcobrm.TableName = "sgcobrm"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.ColumnName = "plan_serial"
        Me.DataColumn1.DataType = GetType(System.Int32)
        '
        'DataColumn2
        '
        Me.DataColumn2.AllowDBNull = False
        Me.DataColumn2.ColumnName = "line_no"
        Me.DataColumn2.DataType = GetType(System.Int32)
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "group_code"
        Me.DataColumn3.DataType = GetType(System.Int32)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "sgroup_code"
        Me.DataColumn4.DataType = GetType(System.Int32)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "item_code"
        Me.DataColumn5.MaxLength = 10
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "plan_status"
        Me.DataColumn6.DataType = GetType(System.Int32)
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "group_name"
        Me.DataColumn7.MaxLength = 30
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "sgroup_name"
        Me.DataColumn8.MaxLength = 30
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "item_name"
        Me.DataColumn9.MaxLength = 100
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(520, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 16)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "% Descuento:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xcbo_status
        '
        Me.xcbo_status.AllowDefaultSort = True
        Me.xcbo_status.bound = True
        Me.xcbo_status.currValue = Nothing
        Me.xcbo_status.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "sgcobrm.plan_status"))
        Me.xcbo_status.DefaultWhereString = Nothing
        Me.xcbo_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_status.EditInitialValue = Nothing
        Me.xcbo_status.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_status.FieldDescription = ""
        Me.xcbo_status.FindInitialValue = Nothing
        Me.xcbo_status.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_status.IgnoreRequiered = False
        Me.xcbo_status.Items.AddRange(New Object() {"1-Incluido", "0-Excluido"})
        Me.xcbo_status.Location = New System.Drawing.Point(608, 16)
        Me.xcbo_status.LookupKeyDisplayFields = Nothing
        Me.xcbo_status.LookupKeyField = Nothing
        Me.xcbo_status.LookupTableName = Nothing
        Me.xcbo_status.Name = "xcbo_status"
        Me.xcbo_status.NewInitialValue = "1"
        Me.xcbo_status.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_status.Requiered = False
        Me.xcbo_status.Required = False
        Me.xcbo_status.Size = New System.Drawing.Size(121, 21)
        Me.xcbo_status.SqlString = Nothing
        Me.xcbo_status.StatusBarPanelDescripcion = Nothing
        Me.xcbo_status.TabIndex = 24
        '
        'xlk_item_code
        '
        Me.xlk_item_code.AlternateFieldSearch = Nothing
        Me.xlk_item_code.CheckText = Nothing
        Me.xlk_item_code.ComboMode = False
        Me.xlk_item_code.DataMember = Nothing
        Me.xlk_item_code.DataSource = Me.LibXConnector1
        Me.xlk_item_code.DestParameters = New String() {"item_code=item_code", "item_name=item_name", "group_code=group_code", "group_name=group_name", "sgroup_code=sgroup_code", "sgroup_name=sgroup_name"}
        Me.xlk_item_code.FilterField = "item_name"
        Me.xlk_item_code.IgnoreFindInBrowseMode = True
        Me.xlk_item_code.isCanceled = False
        Me.xlk_item_code.Location = New System.Drawing.Point(688, 88)
        Me.xlk_item_code.LookCaption = "Productos"
        Me.xlk_item_code.Name = "xlk_item_code"
        Me.xlk_item_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_item_code.ShowFilter = True
        Me.xlk_item_code.ShowMessageNotFound = True
        Me.xlk_item_code.ShowWarning = False
        Me.xlk_item_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_item_code.SizesColumns = New String() {"item_name=350", "group_name=250"}
        Me.xlk_item_code.SizesColumnsTab = Nothing
        Me.xlk_item_code.SqlString = New String() {"select item_name,item_code,ivitemm.sgroup_code, sgroup_name,ivitemm.group_code,gr" & _
        "oup_name ", "from ivitemm left join ivsgroupm  on ivsgroupm.sgroup_code = ivitemm.sgroup_code " & _
        "", "inner join ivgroupm on ivgroupm.group_code = ivitemm.group_code ", "order by ivitemm.group_code,ivitemm.sgroup_code,ivitemm.item_code"}
        Me.xlk_item_code.SQLTab = Nothing
        Me.xlk_item_code.SrcParameters = New String() {"item_code=item_code"}
        Me.xlk_item_code.TabIndex = 23
        Me.xlk_item_code.TableName = "ivitemm"
        Me.xlk_item_code.TabStop = False
        Me.xlk_item_code.UseCopyConnection = False
        Me.xlk_item_code.UseRowRetrieveEvents = False
        Me.xlk_item_code.UseTab = False
        Me.xlk_item_code.VisParameters = New String() {"Codigo=item_code", "Descripción=item_name", "Grupo=group_name", "Subgrupo=sgroup_name"}
        Me.xlk_item_code.WhereCondition = Nothing
        Me.xlk_item_code.WhereParameters = Nothing
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
        Me.LibXConnector1.DataMember = "sgplanm"
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
        Me.LibXConnector1.ReportName = "r_sgplanm01.rpt"
        Me.LibXConnector1.RequeryData = False
        Me.LibXConnector1.ShowWarningCancel = True
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.LibXDbSourceTable1, Me.LibXDbSourceTable2})
        Me.LibXConnector1.State = LibX.LibxConnectorState.none
        Me.LibXConnector1.UpdatePrimaryKeyColumns = False
        Me.LibXConnector1.UseTransactions = False
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
        Me.LibXDbSourceTable1.SerialColumnName = "plan_serial"
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = Nothing
        Me.LibXDbSourceTable1.TableName = "sgplanm"
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
        Me.LibXDbSourceTable2.LineColName = "line_no"
        Me.LibXDbSourceTable2.MasterDetailRelation = New String() {"plan_serial=plan_serial"}
        Me.LibXDbSourceTable2.MasterTableName = Nothing
        Me.LibXDbSourceTable2.SerialColumnName = ""
        Me.LibXDbSourceTable2.Sort = Nothing
        Me.LibXDbSourceTable2.Source = New String() {"select sgcobrm.*, ivgroupm.group_name, ", "ivsgroupm.sgroup_name,ivitemm.item_name", "from sgcobrm ", "left outer join ivgroupm", "on sgcobrm.group_code = ivgroupm.group_code", "left outer join ivsgroupm", "on sgcobrm.sgroup_code = ivsgroupm.sgroup_code", "left outer join ivitemm", "on sgcobrm.item_code = ivitemm.item_code"}
        Me.LibXDbSourceTable2.TableName = "sgcobrm"
        Me.LibXDbSourceTable2.UpdateOrder = 0
        Me.LibXDbSourceTable2.UseRowRetrieve = False
        '
        'xlk_sgroup_code
        '
        Me.xlk_sgroup_code.AlternateFieldSearch = Nothing
        Me.xlk_sgroup_code.CheckText = Nothing
        Me.xlk_sgroup_code.ComboMode = False
        Me.xlk_sgroup_code.DataMember = Nothing
        Me.xlk_sgroup_code.DataSource = Me.LibXConnector1
        Me.xlk_sgroup_code.DestParameters = New String() {"sgroup_code=sgroup_code", "sgroup_name=sgroup_name", "group_code=group_code", "group_name=group_name"}
        Me.xlk_sgroup_code.FilterField = "sgroup_code"
        Me.xlk_sgroup_code.IgnoreFindInBrowseMode = True
        Me.xlk_sgroup_code.isCanceled = False
        Me.xlk_sgroup_code.Location = New System.Drawing.Point(648, 88)
        Me.xlk_sgroup_code.LookCaption = "Subgrupo de Productos"
        Me.xlk_sgroup_code.Name = "xlk_sgroup_code"
        Me.xlk_sgroup_code.PopupSize = New System.Drawing.Size(450, 300)
        Me.xlk_sgroup_code.ShowFilter = True
        Me.xlk_sgroup_code.ShowMessageNotFound = True
        Me.xlk_sgroup_code.ShowWarning = False
        Me.xlk_sgroup_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_sgroup_code.SizesColumns = Nothing
        Me.xlk_sgroup_code.SizesColumnsTab = Nothing
        Me.xlk_sgroup_code.SqlString = New String() {"select sgroup_code,sgroup_name,ivsgroupm.group_code,group_name", "from ivsgroupm inner join ivgroupm", "on ivsgroupm.group_code = ivgroupm.group_code"}
        Me.xlk_sgroup_code.SQLTab = Nothing
        Me.xlk_sgroup_code.SrcParameters = New String() {"sgroup_code=sgroup_code"}
        Me.xlk_sgroup_code.TabIndex = 22
        Me.xlk_sgroup_code.TableName = "ivsgroupm"
        Me.xlk_sgroup_code.TabStop = False
        Me.xlk_sgroup_code.UseCopyConnection = False
        Me.xlk_sgroup_code.UseRowRetrieveEvents = False
        Me.xlk_sgroup_code.UseTab = False
        Me.xlk_sgroup_code.VisParameters = New String() {"Codigo=sgroup_code", "Descripción=sgroup_name", "Grupo=group_name"}
        Me.xlk_sgroup_code.WhereCondition = Nothing
        Me.xlk_sgroup_code.WhereParameters = Nothing
        '
        'xlk_group_code
        '
        Me.xlk_group_code.AlternateFieldSearch = Nothing
        Me.xlk_group_code.CheckText = Nothing
        Me.xlk_group_code.ComboMode = False
        Me.xlk_group_code.DataMember = Nothing
        Me.xlk_group_code.DataSource = Me.LibXConnector1
        Me.xlk_group_code.DestParameters = New String() {"group_code=group_code", "group_name=group_name"}
        Me.xlk_group_code.FilterField = "group_name"
        Me.xlk_group_code.IgnoreFindInBrowseMode = True
        Me.xlk_group_code.isCanceled = False
        Me.xlk_group_code.Location = New System.Drawing.Point(608, 88)
        Me.xlk_group_code.LookCaption = "Grupos de Productos"
        Me.xlk_group_code.Name = "xlk_group_code"
        Me.xlk_group_code.PopupSize = New System.Drawing.Size(450, 300)
        Me.xlk_group_code.ShowFilter = True
        Me.xlk_group_code.ShowMessageNotFound = True
        Me.xlk_group_code.ShowWarning = False
        Me.xlk_group_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_group_code.SizesColumns = Nothing
        Me.xlk_group_code.SizesColumnsTab = Nothing
        Me.xlk_group_code.SqlString = Nothing
        Me.xlk_group_code.SQLTab = Nothing
        Me.xlk_group_code.SrcParameters = New String() {"group_code=group_code"}
        Me.xlk_group_code.TabIndex = 21
        Me.xlk_group_code.TableName = "ivgroupm"
        Me.xlk_group_code.TabStop = False
        Me.xlk_group_code.UseCopyConnection = False
        Me.xlk_group_code.UseRowRetrieveEvents = False
        Me.xlk_group_code.UseTab = False
        Me.xlk_group_code.VisParameters = New String() {"Codigo=group_code", "Descripción=group_name"}
        Me.xlk_group_code.WhereCondition = Nothing
        Me.xlk_group_code.WhereParameters = Nothing
        '
        'LibXCombo1
        '
        Me.LibXCombo1.AllowDefaultSort = True
        Me.LibXCombo1.bound = True
        Me.LibXCombo1.currValue = Nothing
        Me.LibXCombo1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "sgplanm.plan_status"))
        Me.LibXCombo1.DefaultWhereString = Nothing
        Me.LibXCombo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LibXCombo1.EditInitialValue = Nothing
        Me.LibXCombo1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.FieldDescription = ""
        Me.LibXCombo1.FindInitialValue = "1"
        Me.LibXCombo1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.IgnoreRequiered = False
        Me.LibXCombo1.Items.AddRange(New Object() {"0-Inactivo", "1-Activo"})
        Me.LibXCombo1.Location = New System.Drawing.Point(608, 24)
        Me.LibXCombo1.LookupKeyDisplayFields = Nothing
        Me.LibXCombo1.LookupKeyField = Nothing
        Me.LibXCombo1.LookupTableName = Nothing
        Me.LibXCombo1.Name = "LibXCombo1"
        Me.LibXCombo1.NewInitialValue = "1"
        Me.LibXCombo1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.Requiered = False
        Me.LibXCombo1.Required = False
        Me.LibXCombo1.Size = New System.Drawing.Size(121, 21)
        Me.LibXCombo1.SqlString = Nothing
        Me.LibXCombo1.StatusBarPanelDescripcion = Nothing
        Me.LibXCombo1.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(550, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 16)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Estatus:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_plan_cobertura
        '
        Me.xtxt_plan_cobertura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xtxt_plan_cobertura.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "sgplanm.plan_cobertura"))
        Me.xtxt_plan_cobertura.Location = New System.Drawing.Point(608, 48)
        Me.xtxt_plan_cobertura.Name = "xtxt_plan_cobertura"
        Me.xtxt_plan_cobertura.Size = New System.Drawing.Size(64, 20)
        Me.xtxt_plan_cobertura.TabIndex = 5
        Me.xtxt_plan_cobertura.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(524, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 16)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "% Cobertura:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xlk_cia_code
        '
        Me.xlk_cia_code.AlternateFieldSearch = Nothing
        Me.xlk_cia_code.CheckText = Nothing
        Me.xlk_cia_code.ComboMode = False
        Me.xlk_cia_code.DataMember = Nothing
        Me.xlk_cia_code.DataSource = Me.LibXConnector1
        Me.xlk_cia_code.DestParameters = New String() {"cia_serial=cia_serial", "lblcia_name=cia_name"}
        Me.xlk_cia_code.FilterField = Nothing
        Me.xlk_cia_code.IgnoreFindInBrowseMode = False
        Me.xlk_cia_code.isCanceled = False
        Me.xlk_cia_code.Location = New System.Drawing.Point(488, 48)
        Me.xlk_cia_code.LookCaption = "Compañias"
        Me.xlk_cia_code.Name = "xlk_cia_code"
        Me.xlk_cia_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_cia_code.ShowFilter = True
        Me.xlk_cia_code.ShowMessageNotFound = True
        Me.xlk_cia_code.ShowWarning = False
        Me.xlk_cia_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_cia_code.SizesColumns = Nothing
        Me.xlk_cia_code.SizesColumnsTab = Nothing
        Me.xlk_cia_code.SqlString = Nothing
        Me.xlk_cia_code.SQLTab = Nothing
        Me.xlk_cia_code.SrcParameters = New String() {"cia_serial=cia_serial"}
        Me.xlk_cia_code.TabIndex = 16
        Me.xlk_cia_code.TableName = "sgciasm"
        Me.xlk_cia_code.TabStop = False
        Me.xlk_cia_code.UseCopyConnection = False
        Me.xlk_cia_code.UseRowRetrieveEvents = False
        Me.xlk_cia_code.UseTab = False
        Me.xlk_cia_code.VisParameters = New String() {"Código=cia_serial", "Nombre=cia_name"}
        Me.xlk_cia_code.WhereCondition = Nothing
        Me.xlk_cia_code.WhereParameters = Nothing
        '
        'lblcia_name
        '
        Me.lblcia_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblcia_name.Location = New System.Drawing.Point(184, 48)
        Me.lblcia_name.Name = "lblcia_name"
        Me.lblcia_name.Size = New System.Drawing.Size(304, 20)
        Me.lblcia_name.TabIndex = 15
        '
        'TextBox3
        '
        Me.TextBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "sgplanm.cia_serial"))
        Me.TextBox3.Location = New System.Drawing.Point(112, 48)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(64, 20)
        Me.TextBox3.TabIndex = 1
        Me.TextBox3.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(40, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 16)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Compañía:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LibXLookup1
        '
        Me.LibXLookup1.AllowDrop = True
        Me.LibXLookup1.AlternateFieldSearch = Nothing
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
        'TextBox2
        '
        Me.TextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "sgplanm.plan_name"))
        Me.TextBox2.Location = New System.Drawing.Point(112, 72)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(392, 20)
        Me.TextBox2.TabIndex = 2
        Me.TextBox2.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(32, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Descripción:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox1
        '
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "sgplanm.plan_serial"))
        Me.TextBox1.Location = New System.Drawing.Point(112, 24)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(64, 20)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(56, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xlk_cust_code
        '
        Me.xlk_cust_code.AlternateFieldSearch = Nothing
        Me.xlk_cust_code.CheckText = Nothing
        Me.xlk_cust_code.ComboMode = False
        Me.xlk_cust_code.DataMember = Nothing
        Me.xlk_cust_code.DataSource = Me.LibXConnector1
        Me.xlk_cust_code.DestParameters = New String() {"cust_code=cust_code", "cust_name=cust_name"}
        Me.xlk_cust_code.FilterField = Nothing
        Me.xlk_cust_code.IgnoreFindInBrowseMode = False
        Me.xlk_cust_code.isCanceled = False
        Me.xlk_cust_code.Location = New System.Drawing.Point(488, 96)
        Me.xlk_cust_code.LookCaption = "Cuentas a Credito"
        Me.xlk_cust_code.Name = "xlk_cust_code"
        Me.xlk_cust_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_cust_code.ShowFilter = True
        Me.xlk_cust_code.ShowMessageNotFound = True
        Me.xlk_cust_code.ShowWarning = False
        Me.xlk_cust_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_cust_code.SizesColumns = Nothing
        Me.xlk_cust_code.SizesColumnsTab = Nothing
        Me.xlk_cust_code.SqlString = Nothing
        Me.xlk_cust_code.SQLTab = Nothing
        Me.xlk_cust_code.SrcParameters = New String() {"cust_code=cust_code"}
        Me.xlk_cust_code.TabIndex = 16
        Me.xlk_cust_code.TableName = "cccustm"
        Me.xlk_cust_code.TabStop = False
        Me.xlk_cust_code.UseCopyConnection = False
        Me.xlk_cust_code.UseRowRetrieveEvents = False
        Me.xlk_cust_code.UseTab = False
        Me.xlk_cust_code.VisParameters = New String() {"Código=cust_code", "Nombre=cust_name"}
        Me.xlk_cust_code.WhereCondition = Nothing
        Me.xlk_cust_code.WhereParameters = Nothing
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Location = New System.Drawing.Point(16, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 16)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Cuenta Crédito:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cust_name
        '
        Me.cust_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.cust_name.Location = New System.Drawing.Point(184, 96)
        Me.cust_name.Name = "cust_name"
        Me.cust_name.Size = New System.Drawing.Size(304, 20)
        Me.cust_name.TabIndex = 15
        '
        'TextBox4
        '
        Me.TextBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "sgplanm.cust_code"))
        Me.TextBox4.Location = New System.Drawing.Point(112, 96)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(64, 20)
        Me.TextBox4.TabIndex = 3
        Me.TextBox4.Text = ""
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
        Me.LibXNavigator1.Size = New System.Drawing.Size(802, 24)
        Me.LibXNavigator1.TabIndex = 0
        '
        'LibXGrid1
        '
        Me.LibXGrid1.AutoAdjustLastColumn = True
        Me.LibXGrid1.AutoSearch = False
        Me.LibXGrid1.BackgroundColor = System.Drawing.Color.White
        Me.LibXGrid1.CaptionText = "Productos "
        Me.LibXGrid1.DataMember = "sgcobrm"
        Me.LibXGrid1.DataSource = Me.DataSet1
        Me.LibXGrid1.FullRowSelect = False
        Me.LibXGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGrid1.IsReadOnly = False
        Me.LibXGrid1.Location = New System.Drawing.Point(8, 168)
        Me.LibXGrid1.Name = "LibXGrid1"
        Me.LibXGrid1.ReadOnly = True
        Me.LibXGrid1.searchText = ""
        Me.LibXGrid1.showFooterBar = False
        Me.LibXGrid1.Size = New System.Drawing.Size(784, 360)
        Me.LibXGrid1.TabIndex = 2
        Me.LibXGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.XdataGridTableStyle1})
        Me.LibXGrid1.UseAutoFillLines = True
        Me.LibXGrid1.UseHandCursor = False
        '
        'XdataGridTableStyle1
        '
        Me.XdataGridTableStyle1.DataGrid = Me.LibXGrid1
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.gColgroup_code, Me.XEditTextBoxColumn1, Me.gColsgroup_code, Me.XEditTextBoxColumn2, Me.gcolitem_code, Me.XEditTextBoxColumn3, Me.gGcolStatus})
        Me.XdataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle1.MappingName = "sgcobrm"
        '
        'gColgroup_code
        '
        Me.gColgroup_code.ButtonType = LibX.XDataGridTextButtonColumn.XDataGridTextButtonColumnButtonTypes.SpinButton
        Me.gColgroup_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColgroup_code.executeFindDuringFill = False
        Me.gColgroup_code.Format = ""
        Me.gColgroup_code.FormatInfo = Nothing
        Me.gColgroup_code.HeaderText = "Grupo"
        Me.gColgroup_code.isReadOnly = False
        Me.gColgroup_code.Lookup = Me.xlk_group_code
        Me.gColgroup_code.MappingName = "group_code"
        Me.gColgroup_code.MaxLength = 32767
        Me.gColgroup_code.TabStop = True
        Me.gColgroup_code.UseCustomCellFormat = False
        Me.gColgroup_code.Width = 45
        '
        'XEditTextBoxColumn1
        '
        Me.XEditTextBoxColumn1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn1.Format = ""
        Me.XEditTextBoxColumn1.FormatInfo = Nothing
        Me.XEditTextBoxColumn1.HeaderText = "Descripción"
        Me.XEditTextBoxColumn1.ImageList = Nothing
        Me.XEditTextBoxColumn1.isReadOnly = True
        Me.XEditTextBoxColumn1.MappingName = "group_name"
        Me.XEditTextBoxColumn1.MaxLength = 32767
        Me.XEditTextBoxColumn1.ReadOnly = True
        Me.XEditTextBoxColumn1.TabStop = True
        Me.XEditTextBoxColumn1.UseCustomCellFormat = False
        Me.XEditTextBoxColumn1.Width = 150
        '
        'gColsgroup_code
        '
        Me.gColsgroup_code.ButtonType = LibX.XDataGridTextButtonColumn.XDataGridTextButtonColumnButtonTypes.SpinButton
        Me.gColsgroup_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColsgroup_code.executeFindDuringFill = False
        Me.gColsgroup_code.Format = ""
        Me.gColsgroup_code.FormatInfo = Nothing
        Me.gColsgroup_code.HeaderText = "Subgrupo"
        Me.gColsgroup_code.isReadOnly = False
        Me.gColsgroup_code.Lookup = Me.xlk_sgroup_code
        Me.gColsgroup_code.MappingName = "sgroup_code"
        Me.gColsgroup_code.MaxLength = 32767
        Me.gColsgroup_code.TabStop = True
        Me.gColsgroup_code.UseCustomCellFormat = False
        Me.gColsgroup_code.Width = 55
        '
        'XEditTextBoxColumn2
        '
        Me.XEditTextBoxColumn2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn2.Format = ""
        Me.XEditTextBoxColumn2.FormatInfo = Nothing
        Me.XEditTextBoxColumn2.HeaderText = "Descripción"
        Me.XEditTextBoxColumn2.ImageList = Nothing
        Me.XEditTextBoxColumn2.isReadOnly = True
        Me.XEditTextBoxColumn2.MappingName = "sgroup_name"
        Me.XEditTextBoxColumn2.MaxLength = 32767
        Me.XEditTextBoxColumn2.ReadOnly = True
        Me.XEditTextBoxColumn2.TabStop = True
        Me.XEditTextBoxColumn2.UseCustomCellFormat = False
        Me.XEditTextBoxColumn2.Width = 150
        '
        'gcolitem_code
        '
        Me.gcolitem_code.ButtonType = LibX.XDataGridTextButtonColumn.XDataGridTextButtonColumnButtonTypes.SpinButton
        Me.gcolitem_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gcolitem_code.executeFindDuringFill = False
        Me.gcolitem_code.Format = ""
        Me.gcolitem_code.FormatInfo = Nothing
        Me.gcolitem_code.HeaderText = "Producto"
        Me.gcolitem_code.isReadOnly = False
        Me.gcolitem_code.Lookup = Me.xlk_item_code
        Me.gcolitem_code.MappingName = "item_code"
        Me.gcolitem_code.MaxLength = 32767
        Me.gcolitem_code.TabStop = True
        Me.gcolitem_code.UseCustomCellFormat = False
        Me.gcolitem_code.Width = 55
        '
        'XEditTextBoxColumn3
        '
        Me.XEditTextBoxColumn3.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn3.Format = ""
        Me.XEditTextBoxColumn3.FormatInfo = Nothing
        Me.XEditTextBoxColumn3.HeaderText = "Descripción"
        Me.XEditTextBoxColumn3.ImageList = Nothing
        Me.XEditTextBoxColumn3.isReadOnly = True
        Me.XEditTextBoxColumn3.MappingName = "item_name"
        Me.XEditTextBoxColumn3.MaxLength = 32767
        Me.XEditTextBoxColumn3.ReadOnly = True
        Me.XEditTextBoxColumn3.TabStop = True
        Me.XEditTextBoxColumn3.UseCustomCellFormat = False
        Me.XEditTextBoxColumn3.Width = 225
        '
        'gGcolStatus
        '
        Me.gGcolStatus.ComboBox = Me.xcbo_status
        Me.gGcolStatus.Format = ""
        Me.gGcolStatus.FormatInfo = Nothing
        Me.gGcolStatus.HeaderText = "Cobertura"
        Me.gGcolStatus.isReadOnly = False
        Me.gGcolStatus.MappingName = "plan_status"
        Me.gGcolStatus.Width = 60
        '
        'i_sgplanm01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(802, 584)
        Me.Controls.Add(Me.LibXGrid1)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "i_sgplanm01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Planes de Seguro"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sgplanm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sgcobrm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub xlk_sgroup_code_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.BeforeExecuteQueryEventArgs) Handles xlk_sgroup_code.BeforeExecuteQuery
        Try
            If LibXConnector1.IsDataEditing = True Then
                If Me.LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, gColgroup_code).Trim <> "" Then
                    e.aditionalWhere = "ivsgroupm.group_code = " & Me.LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, gColgroup_code)
                End If
            End If
        Catch ex As Exception
            e.handled = True
            LibX.Log.Add(ex, True)
        End Try

    End Sub

    Private Sub xlk_item_code_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.BeforeExecuteQueryEventArgs) Handles xlk_item_code.BeforeExecuteQuery
        Dim sqlplay As String
        Try
            sqlplay = e.SQL
            If LibXConnector1.IsDataEditing = True Then
                If Me.LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, gColgroup_code).Trim <> "" Then
                    e.aditionalWhere = "ivitemm.group_code = " & Me.LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, gColgroup_code)
                End If
                If Me.LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, gColsgroup_code).Trim <> "" Then
                    e.aditionalWhere = e.aditionalWhere & " and ivitemm.sgroup_code = " & Me.LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, gColsgroup_code)
                End If

            End If

        Catch ex As Exception
            e.handled = True
            LibX.Log.Add(ex, True)
        End Try

    End Sub

    Private Sub xlk_item_code_BeforeSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles xlk_item_code.BeforeSetValues
        Try
            If e.dataFound = False Then
                Exit Sub
            End If

            'If sgcobrm.Select("item_code ='" & e.row!item_code & "'").Length > 0 Then
            '    Throw New ApplicationException("Este producto ya esta digitado en este plan!")
            'End If

            'If sgcobrm.Select("sgroup_code =" & e.row!sgroup_code & " and item_code is null").Length > 0 Then
            '    Throw New ApplicationException("El SubGrupo al que pertenece este producto ya esta digitado en este plan!")
            'End If

            'If sgcobrm.Select("group_code =" & e.row!group_code & " and sgroup_code is null and item_code is null").Length > 0 Then
            '    Throw New ApplicationException("El Grupo al que pertenece este producto ya esta digitado en este plan!")
            'End If

        Catch ex As Exception
            e.handled = True
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub xlk_sgroup_code_BeforeSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles xlk_sgroup_code.BeforeSetValues
        Try
            If e.dataFound = False Then
                Exit Sub
            End If
            'If sgcobrm.Select("group_code =" & e.row!group_code & " and sgroup_code is null and item_code is null").Length > 0 Then
            '    Throw New ApplicationException("El Grupo al que pertenece este subgrupo ya esta digitado en este plan!")
            'End If

            'If sgcobrm.Select("sgroup_code =" & e.row!sgroup_code & " and item_code is null").Length > 0 Then
            '    Throw New ApplicationException("El SubGrupo al que pertenece este producto ya esta digitado en este plan!")
            'End If

        Catch ex As Exception
            e.handled = True
            LibX.Log.Add(ex, True)
        End Try

    End Sub

    Private Sub xlk_group_code_BeforeSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles xlk_group_code.BeforeSetValues
        Try
            If e.dataFound = False Then
                Exit Sub
            End If
            'If sgcobrm.Select("group_code =" & e.row!group_code & " and sgroup_code is null and item_code is null").Length > 0 Then
            '    Throw New ApplicationException("Este Grupo ya esta digitado en este plan!")
            'End If

        Catch ex As Exception
            e.handled = True
            LibX.Log.Add(ex, True)
        End Try

    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xtxt_plan_cobertura.TextChanged

    End Sub

    Private Sub TextBox4_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles xtxt_plan_cobertura.Validating
        Try
            If Val(xtxt_plan_cobertura.Text.Trim) > 100 Then
                Throw New ApplicationException("% de cobertura no puede ser mayor que 100")
            End If

            If (Val(xtxt_plan_cobertura.Text.Trim) + Val(xtxt_plan_descuento.Text.Trim)) > 100 Then
                Throw New ApplicationException("% de descuento + % cobertura no puede ser mayor que 100")
            End If

        Catch ex As Exception
            e.Cancel = True
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xtxt_plan_descuento.TextChanged

    End Sub

    Private Sub TextBox5_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles xtxt_plan_descuento.Validating
        Try
            If Val(Me.xtxt_plan_descuento.Text.Trim) > 100 Then
                Throw New ApplicationException("% de descuento no puede ser mayor que 100")
            End If

            If (Val(Me.xtxt_plan_cobertura.Text.Trim) + Val(xtxt_plan_descuento.Text.Trim)) > 100 Then
                Throw New ApplicationException("% de descuento + % cobertura no puede ser mayor que 100")
            End If

        Catch ex As Exception
            e.Cancel = True
            LibX.Log.Show(ex)
        End Try

    End Sub

End Class
