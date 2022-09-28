Imports SGT.PuntodeVenta.Entidades

Public Class i_ptvfact03
    Inherits System.Windows.Forms.Form

    Dim WithEvents Label1 As System.Windows.Forms.Label
    Dim WithEvents Label4 As System.Windows.Forms.Label
    Dim WithEvents Label5 As System.Windows.Forms.Label
    Dim WithEvents Label7 As System.Windows.Forms.Label
    Dim WithEvents xtxt_address As LibX.XTextBox
    Dim WithEvents xtxt_telefono1 As LibX.XTextBox
    Dim WithEvents Label13 As Label
    Dim WithEvents Label12 As Label
    Dim WithEvents lbl_Descuento As Label
    Dim WithEvents lbl_Cobertura As Label
    Dim WithEvents xlk_plan As LibX.LibXLookup
    Dim WithEvents xlk_compania As LibX.LibXLookup
    Dim WithEvents lbl_Compania As Label
    Dim WithEvents xtxt_plan As LibX.XTextBox
    Dim WithEvents xtxt_Compania As LibX.XTextBox
    Dim WithEvents Label10 As Label
    Dim WithEvents Label11 As Label
    Dim WithEvents lbl_Plan As Label
    Dim WithEvents Label9 As System.Windows.Forms.Label
    Dim WithEvents Label6 As System.Windows.Forms.Label
    Dim WithEvents XTextBox1 As LibX.XTextBox
    Dim WithEvents lbl_sector As System.Windows.Forms.Label
    Dim WithEvents Label8 As System.Windows.Forms.Label
    Dim WithEvents lbl_TipoDocumento As System.Windows.Forms.Label
    Dim WithEvents xlk_sector As LibX.LibXLookup
    Dim WithEvents xlk_ciudad As LibX.LibXLookup
    Dim WithEvents xtxt_sector As LibX.XTextBox
    Dim WithEvents xtxt_ciudad As LibX.XTextBox
    Dim WithEvents Label2 As System.Windows.Forms.Label
    Dim WithEvents Label3 As System.Windows.Forms.Label
    Dim WithEvents xlk_vend_code As LibX.LibXLookup
    Dim WithEvents lbl_mensajero As System.Windows.Forms.Label
    Dim WithEvents lbl_ult_domicilio As System.Windows.Forms.Label

    Dim oDevolucion As SGT.PuntodeVenta.Entidades.Devolucion

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
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents LBL_Title As System.Windows.Forms.Label
    Friend WithEvents LibXDbSourceTable5 As LibX.LibXDbSourceTable
    Friend WithEvents DataSet1 As System.Data.DataSet

    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents XTextBox2 As LibX.XTextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
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
    Friend WithEvents lbl_fact_total As System.Windows.Forms.Label
    Friend WithEvents xcbo_dev_type As LibX.LibXCombo
    Private WithEvents xlk_fact_number As LibX.LibXLookup
    Private WithEvents xcbo_type_code As LibX.LibXCombo
    Private WithEvents xtxt_fact_number As LibX.XMaskEdit
    Friend WithEvents xtxt_fact_nota As LibX.XTextBox
    Friend WithEvents xtxt_bus_name As LibX.XMaskEdit
    Friend WithEvents xdt_fact_date As LibX.LibxDateTimePicker
    Friend WithEvents lbl_ftserial_afect As System.Windows.Forms.Label
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents xlk_cust_code As LibX.LibXLookup
    Friend WithEvents xcbo_fact_cond As LibX.LibXCombo
    Friend WithEvents xtxt_cust_code As LibX.XMaskEdit
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents lbl_fact_seguro As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents xtxtAseg_poliza As LibX.XTextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
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
        Me.DataColumn13 = New System.Data.DataColumn
        Me.DataColumn14 = New System.Data.DataColumn
        Me.LibXDbSourceTable5 = New LibX.LibXDbSourceTable
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.xtxtAseg_poliza = New LibX.XTextBox
        Me.lbl_fact_seguro = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.xcbo_fact_cond = New LibX.LibXCombo
        Me.lbl_fact_total = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.xcbo_dev_type = New LibX.LibXCombo
        Me.xlk_fact_number = New LibX.LibXLookup
        Me.Label9 = New System.Windows.Forms.Label
        Me.xcbo_type_code = New LibX.LibXCombo
        Me.xtxt_fact_number = New LibX.XMaskEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.xtxt_fact_nota = New LibX.XTextBox
        Me.xtxt_bus_name = New LibX.XMaskEdit
        Me.xdt_fact_date = New LibX.LibxDateTimePicker
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.xtxt_cust_code = New LibX.XMaskEdit
        Me.xlk_cust_code = New LibX.LibXLookup
        Me.lbl_ftserial_afect = New System.Windows.Forms.Label
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.LBL_Title = New System.Windows.Forms.Label
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.xtxt_telefono1 = New LibX.XTextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.btnView = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.LibXConnector1.DataMember = "ftfactm"
        Me.LibXConnector1.DataSource = Me.DataSet1
        Me.LibXConnector1.EOF = False
        Me.LibXConnector1.HandledRowsFill = False
        Me.LibXConnector1.HandledUpdates = True
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
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.LibXDbSourceTable5})
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
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14})
        Me.DataTable1.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"ftserial_no"}, True)})
        Me.DataTable1.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn1}
        Me.DataTable1.TableName = "ftfactm"
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
        Me.DataColumn2.ColumnName = "ftserial_afect"
        Me.DataColumn2.DataType = GetType(System.Int32)
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "fact_nota"
        Me.DataColumn3.MaxLength = 80
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "bus_name"
        Me.DataColumn4.MaxLength = 100
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "dev_type"
        Me.DataColumn5.MaxLength = 3
        '
        'DataColumn6
        '
        Me.DataColumn6.AllowDBNull = False
        Me.DataColumn6.ColumnName = "fact_cond"
        Me.DataColumn6.DataType = GetType(System.Int16)
        '
        'DataColumn7
        '
        Me.DataColumn7.AllowDBNull = False
        Me.DataColumn7.ColumnName = "type_code"
        Me.DataColumn7.MaxLength = 3
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
        Me.DataColumn11.ColumnName = "cust_code"
        Me.DataColumn11.DataType = GetType(System.Int32)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "fact_inddomicilio"
        Me.DataColumn12.DataType = GetType(System.Int32)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "seg_amount"
        Me.DataColumn13.DataType = GetType(System.Decimal)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "aseg_poliza"
        Me.DataColumn14.MaxLength = 20
        '
        'LibXDbSourceTable5
        '
        Me.LibXDbSourceTable5.AllowDelete = True
        Me.LibXDbSourceTable5.AllowEdit = True
        Me.LibXDbSourceTable5.AllowNew = True
        Me.LibXDbSourceTable5.AutoIncrementSerial = False
        Me.LibXDbSourceTable5.CustomDbUpdate = False
        Me.LibXDbSourceTable5.DeleteOrder = 0
        Me.LibXDbSourceTable5.FillOnQuery = True
        Me.LibXDbSourceTable5.FillOnRowChange = False
        Me.LibXDbSourceTable5.HeaderIsOnGrid = False
        Me.LibXDbSourceTable5.InnerJon = True
        Me.LibXDbSourceTable5.InsertOrder = 0
        Me.LibXDbSourceTable5.IsDetail = False
        Me.LibXDbSourceTable5.KeyFields = Nothing
        Me.LibXDbSourceTable5.LineColName = Nothing
        Me.LibXDbSourceTable5.MasterDetailRelation = Nothing
        Me.LibXDbSourceTable5.MasterTableName = Nothing
        Me.LibXDbSourceTable5.SerialColumnName = Nothing
        Me.LibXDbSourceTable5.Sort = Nothing
        Me.LibXDbSourceTable5.Source = New String() {"select ftfactm.ftserial_no,", "" & Microsoft.VisualBasic.ChrW(9) & "ftfactm.cust_code,", "" & Microsoft.VisualBasic.ChrW(9) & "ftfactm.ftserial_afect,", "" & Microsoft.VisualBasic.ChrW(9) & "ftfactm.fact_nota,", "" & Microsoft.VisualBasic.ChrW(9) & "ftfactm.bus_name,", "" & Microsoft.VisualBasic.ChrW(9) & "ftfactm.dev_type,", "" & Microsoft.VisualBasic.ChrW(9) & "ftfactm.fact_cond,", "" & Microsoft.VisualBasic.ChrW(9) & "ftfactm.fact_inddomicilio,", "" & Microsoft.VisualBasic.ChrW(9) & "ftfactdv.type_code,", "" & Microsoft.VisualBasic.ChrW(9) & "ftfactdv.fact_number,", "" & Microsoft.VisualBasic.ChrW(9) & "ftfactdv.fact_date,", "" & Microsoft.VisualBasic.ChrW(9) & "ftfactdv.fact_total,", "" & Microsoft.VisualBasic.ChrW(9) & "ftfactdv.seg_amount,", "                ftsegrm.aseg_poliza", "from ftfactm ", "inner join ftfactm ftfactdv", "on ftfactdv.ftserial_no = ftfactm.ftserial_afect", "left outer join ftsegrm on ftsegrm.ftserial_no = ftfactm.ftserial_afect"}
        Me.LibXDbSourceTable5.TableName = "ftfactm"
        Me.LibXDbSourceTable5.UpdateOrder = 0
        Me.LibXDbSourceTable5.UseRowRetrieve = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.xtxtAseg_poliza)
        Me.GroupBox1.Controls.Add(Me.lbl_fact_seguro)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.xcbo_fact_cond)
        Me.GroupBox1.Controls.Add(Me.lbl_fact_total)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.xcbo_dev_type)
        Me.GroupBox1.Controls.Add(Me.xlk_fact_number)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.xcbo_type_code)
        Me.GroupBox1.Controls.Add(Me.xtxt_fact_number)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.xtxt_fact_nota)
        Me.GroupBox1.Controls.Add(Me.xtxt_bus_name)
        Me.GroupBox1.Controls.Add(Me.xdt_fact_date)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.xtxt_cust_code)
        Me.GroupBox1.Controls.Add(Me.xlk_cust_code)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(8, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(568, 224)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'xtxtAseg_poliza
        '
        Me.xtxtAseg_poliza.AcceptsReturn = True
        Me.xtxtAseg_poliza.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.aseg_poliza"))
        Me.xtxtAseg_poliza.EditInitialValue = Nothing
        Me.xtxtAseg_poliza.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxtAseg_poliza.FieldDescription = ""
        Me.xtxtAseg_poliza.FindInitialValue = Nothing
        Me.xtxtAseg_poliza.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxtAseg_poliza.IgnoreRequiered = False
        Me.xtxtAseg_poliza.Location = New System.Drawing.Point(232, 88)
        Me.xtxtAseg_poliza.Name = "xtxtAseg_poliza"
        Me.xtxtAseg_poliza.NewInitialValue = Nothing
        Me.xtxtAseg_poliza.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxtAseg_poliza.Requiered = False
        Me.xtxtAseg_poliza.Size = New System.Drawing.Size(136, 20)
        Me.xtxtAseg_poliza.StatusBarPanelDescripcion = Nothing
        Me.xtxtAseg_poliza.TabIndex = 4
        Me.xtxtAseg_poliza.Text = ""
        Me.xtxtAseg_poliza.Visible = False
        '
        'lbl_fact_seguro
        '
        Me.lbl_fact_seguro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_fact_seguro.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.seg_amount"))
        Me.lbl_fact_seguro.Location = New System.Drawing.Point(448, 64)
        Me.lbl_fact_seguro.Name = "lbl_fact_seguro"
        Me.lbl_fact_seguro.Size = New System.Drawing.Size(112, 20)
        Me.lbl_fact_seguro.TabIndex = 20
        Me.lbl_fact_seguro.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label20.Location = New System.Drawing.Point(400, 64)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(44, 16)
        Me.Label20.TabIndex = 19
        Me.Label20.Text = "Seguro:"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xcbo_fact_cond
        '
        Me.xcbo_fact_cond.AllowDefaultSort = True
        Me.xcbo_fact_cond.bound = True
        Me.xcbo_fact_cond.currValue = Nothing
        Me.xcbo_fact_cond.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "ftfactm.dev_type"))
        Me.xcbo_fact_cond.DefaultWhereString = Nothing
        Me.xcbo_fact_cond.DisplayMember = "coldescription"
        Me.xcbo_fact_cond.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_fact_cond.EditInitialValue = Nothing
        Me.xcbo_fact_cond.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_fact_cond.FieldDescription = ""
        Me.xcbo_fact_cond.FindInitialValue = Nothing
        Me.xcbo_fact_cond.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_fact_cond.IgnoreRequiered = False
        Me.xcbo_fact_cond.Items.AddRange(New Object() {"1-Efectivo", "2-Crédito", "3-Nota/Crédito"})
        Me.xcbo_fact_cond.Location = New System.Drawing.Point(448, 88)
        Me.xcbo_fact_cond.LookupKeyDisplayFields = ""
        Me.xcbo_fact_cond.LookupKeyField = ""
        Me.xcbo_fact_cond.LookupTableName = ""
        Me.xcbo_fact_cond.Name = "xcbo_fact_cond"
        Me.xcbo_fact_cond.NewInitialValue = "3"
        Me.xcbo_fact_cond.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_fact_cond.Requiered = False
        Me.xcbo_fact_cond.Required = False
        Me.xcbo_fact_cond.Size = New System.Drawing.Size(112, 21)
        Me.xcbo_fact_cond.SqlString = Nothing
        Me.xcbo_fact_cond.StatusBarPanelDescripcion = Nothing
        Me.xcbo_fact_cond.TabIndex = 4
        Me.xcbo_fact_cond.ValueMember = "colvalue"
        '
        'lbl_fact_total
        '
        Me.lbl_fact_total.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_fact_total.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.fact_total"))
        Me.lbl_fact_total.Location = New System.Drawing.Point(448, 40)
        Me.lbl_fact_total.Name = "lbl_fact_total"
        Me.lbl_fact_total.Size = New System.Drawing.Size(112, 20)
        Me.lbl_fact_total.TabIndex = 18
        Me.lbl_fact_total.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label15.Location = New System.Drawing.Point(20, 64)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(116, 16)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "Motivo de Devolución:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xcbo_dev_type
        '
        Me.xcbo_dev_type.AllowDefaultSort = True
        Me.xcbo_dev_type.bound = True
        Me.xcbo_dev_type.currValue = Nothing
        Me.xcbo_dev_type.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "ftfactm.dev_type"))
        Me.xcbo_dev_type.DefaultWhereString = Nothing
        Me.xcbo_dev_type.DisplayMember = "coldescription"
        Me.xcbo_dev_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_dev_type.EditInitialValue = Nothing
        Me.xcbo_dev_type.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_dev_type.FieldDescription = ""
        Me.xcbo_dev_type.FindInitialValue = Nothing
        Me.xcbo_dev_type.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_dev_type.IgnoreRequiered = False
        Me.xcbo_dev_type.Location = New System.Drawing.Point(152, 64)
        Me.xcbo_dev_type.LookupKeyDisplayFields = "dev_name"
        Me.xcbo_dev_type.LookupKeyField = "dev_type"
        Me.xcbo_dev_type.LookupTableName = "ftdevolt"
        Me.xcbo_dev_type.Name = "xcbo_dev_type"
        Me.xcbo_dev_type.NewInitialValue = "CAM"
        Me.xcbo_dev_type.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_dev_type.Requiered = False
        Me.xcbo_dev_type.Required = False
        Me.xcbo_dev_type.Size = New System.Drawing.Size(216, 21)
        Me.xcbo_dev_type.SqlString = Nothing
        Me.xcbo_dev_type.StatusBarPanelDescripcion = Nothing
        Me.xcbo_dev_type.TabIndex = 2
        Me.xcbo_dev_type.ValueMember = "colvalue"
        '
        'xlk_fact_number
        '
        Me.xlk_fact_number.AlternateFieldSearch = Nothing
        Me.xlk_fact_number.BeginCheck = False
        Me.xlk_fact_number.CheckText = Nothing
        Me.xlk_fact_number.ComboMode = False
        Me.xlk_fact_number.DataMember = "ftfactm"
        Me.xlk_fact_number.DataSource = Me.LibXConnector1
        Me.xlk_fact_number.DestParameters = New String() {"Tipo=type_code", "fact_number=fact_number", "ftserial_afect=ftserial_no", "fact_date=fact_date", "fact_total=fact_total", "seg_amount=seg_amount", "fact_inddomicilio=fact_inddomicilio", "xtxt_cust_code=cust_code", "xtxt_bus_name=bus_name", "aseg_poliza=aseg_poliza"}
        Me.xlk_fact_number.FilterField = "bus_name"
        Me.xlk_fact_number.IgnoreFindInBrowseMode = True
        Me.xlk_fact_number.isCanceled = False
        Me.xlk_fact_number.Location = New System.Drawing.Point(272, 40)
        Me.xlk_fact_number.LookCaption = "Documentos"
        Me.xlk_fact_number.Name = "xlk_fact_number"
        Me.xlk_fact_number.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_fact_number.ShowFilter = False
        Me.xlk_fact_number.ShowLookup = False
        Me.xlk_fact_number.ShowMessageNotFound = True
        Me.xlk_fact_number.ShowWarning = False
        Me.xlk_fact_number.Size = New System.Drawing.Size(16, 20)
        Me.xlk_fact_number.SizesColumns = Nothing
        Me.xlk_fact_number.SizesColumnsTab = Nothing
        Me.xlk_fact_number.SqlString = New String() {Nothing}
        Me.xlk_fact_number.SQLTab = Nothing
        Me.xlk_fact_number.SrcParameters = New String() {"fact_number=fact_number"}
        Me.xlk_fact_number.TabIndex = 15
        Me.xlk_fact_number.TableName = "ftfactdev"
        Me.xlk_fact_number.TabStop = False
        Me.xlk_fact_number.UseCopyConnection = False
        Me.xlk_fact_number.UseRowRetrieveEvents = False
        Me.xlk_fact_number.UseTab = False
        Me.xlk_fact_number.Visible = False
        Me.xlk_fact_number.VisParameters = New String() {"Tipo=type_code", "Numero=fact_number", "Fecha=fact_date", "Cliente=bus_name", "Monto=fact_total"}
        Me.xlk_fact_number.WhereCondition = ""
        Me.xlk_fact_number.WhereParameters = Nothing
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.Location = New System.Drawing.Point(30, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 16)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Tipo de Documento:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xcbo_type_code
        '
        Me.xcbo_type_code.AllowDefaultSort = True
        Me.xcbo_type_code.bound = True
        Me.xcbo_type_code.currValue = Nothing
        Me.xcbo_type_code.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "ftfactm.type_code"))
        Me.xcbo_type_code.DefaultWhereString = "type_code in('FPV','FSG')"
        Me.xcbo_type_code.DisplayMember = "coldescription"
        Me.xcbo_type_code.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_type_code.EditInitialValue = Nothing
        Me.xcbo_type_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_type_code.FieldDescription = ""
        Me.xcbo_type_code.FindInitialValue = Nothing
        Me.xcbo_type_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_type_code.IgnoreRequiered = False
        Me.xcbo_type_code.Location = New System.Drawing.Point(152, 16)
        Me.xcbo_type_code.LookupKeyDisplayFields = "type_name"
        Me.xcbo_type_code.LookupKeyField = "type_code"
        Me.xcbo_type_code.LookupTableName = "ivtypem"
        Me.xcbo_type_code.Name = "xcbo_type_code"
        Me.xcbo_type_code.NewInitialValue = "FPV"
        Me.xcbo_type_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_type_code.Requiered = False
        Me.xcbo_type_code.Required = False
        Me.xcbo_type_code.Size = New System.Drawing.Size(216, 21)
        Me.xcbo_type_code.SqlString = Nothing
        Me.xcbo_type_code.StatusBarPanelDescripcion = Nothing
        Me.xcbo_type_code.TabIndex = 1
        Me.xcbo_type_code.ValueMember = "colvalue"
        '
        'xtxt_fact_number
        '
        Me.xtxt_fact_number.AcceptsReturn = True
        Me.xtxt_fact_number.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.fact_number"))
        Me.xtxt_fact_number.EditInitialValue = Nothing
        Me.xtxt_fact_number.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_fact_number.FieldDescription = ""
        Me.xtxt_fact_number.FindInitialValue = Nothing
        Me.xtxt_fact_number.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_fact_number.IgnoreRequiered = False
        Me.xtxt_fact_number.Location = New System.Drawing.Point(152, 40)
        Me.xtxt_fact_number.Masked = MaskedTextBox.Mask.None
        Me.xtxt_fact_number.Name = "xtxt_fact_number"
        Me.xtxt_fact_number.NewInitialValue = Nothing
        Me.xtxt_fact_number.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_fact_number.Requiered = False
        Me.xtxt_fact_number.Size = New System.Drawing.Size(120, 20)
        Me.xtxt_fact_number.StatusBarPanelDescripcion = Nothing
        Me.xtxt_fact_number.TabIndex = 0
        Me.xtxt_fact_number.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(400, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Monto:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(400, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Fecha:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(88, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Nombre:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Location = New System.Drawing.Point(12, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Numero de Documento:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label16.Location = New System.Drawing.Point(65, 136)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(71, 16)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Observación:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_fact_nota
        '
        Me.xtxt_fact_nota.AcceptsReturn = True
        Me.xtxt_fact_nota.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xtxt_fact_nota.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.fact_nota"))
        Me.xtxt_fact_nota.EditInitialValue = Nothing
        Me.xtxt_fact_nota.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_fact_nota.FieldDescription = ""
        Me.xtxt_fact_nota.FindInitialValue = Nothing
        Me.xtxt_fact_nota.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_fact_nota.IgnoreRequiered = False
        Me.xtxt_fact_nota.Location = New System.Drawing.Point(152, 136)
        Me.xtxt_fact_nota.Multiline = True
        Me.xtxt_fact_nota.Name = "xtxt_fact_nota"
        Me.xtxt_fact_nota.NewInitialValue = Nothing
        Me.xtxt_fact_nota.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_fact_nota.Requiered = False
        Me.xtxt_fact_nota.Size = New System.Drawing.Size(408, 64)
        Me.xtxt_fact_nota.StatusBarPanelDescripcion = Nothing
        Me.xtxt_fact_nota.TabIndex = 6
        Me.xtxt_fact_nota.Text = ""
        '
        'xtxt_bus_name
        '
        Me.xtxt_bus_name.AcceptsReturn = True
        Me.xtxt_bus_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xtxt_bus_name.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.bus_name"))
        Me.xtxt_bus_name.EditInitialValue = Nothing
        Me.xtxt_bus_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_bus_name.FieldDescription = ""
        Me.xtxt_bus_name.FindInitialValue = Nothing
        Me.xtxt_bus_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_bus_name.IgnoreRequiered = False
        Me.xtxt_bus_name.Location = New System.Drawing.Point(152, 112)
        Me.xtxt_bus_name.Masked = MaskedTextBox.Mask.None
        Me.xtxt_bus_name.Name = "xtxt_bus_name"
        Me.xtxt_bus_name.NewInitialValue = Nothing
        Me.xtxt_bus_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_bus_name.Requiered = False
        Me.xtxt_bus_name.Size = New System.Drawing.Size(408, 20)
        Me.xtxt_bus_name.StatusBarPanelDescripcion = Nothing
        Me.xtxt_bus_name.TabIndex = 5
        Me.xtxt_bus_name.Text = ""
        '
        'xdt_fact_date
        '
        Me.xdt_fact_date.CustomFormat = "dd/MM/yyyy"
        Me.xdt_fact_date.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "ftfactm.fact_date"))
        Me.xdt_fact_date.EditInitialValue = Nothing
        Me.xdt_fact_date.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xdt_fact_date.FieldDescription = ""
        Me.xdt_fact_date.FindInitialValue = Nothing
        Me.xdt_fact_date.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_fact_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.xdt_fact_date.IgnoreRequiered = False
        Me.xdt_fact_date.Location = New System.Drawing.Point(448, 16)
        Me.xdt_fact_date.Name = "xdt_fact_date"
        Me.xdt_fact_date.NewInitialValue = Nothing
        Me.xdt_fact_date.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xdt_fact_date.Requiered = False
        Me.xdt_fact_date.Size = New System.Drawing.Size(112, 20)
        Me.xdt_fact_date.StatusBarPanelDescripcion = Nothing
        Me.xdt_fact_date.TabIndex = 4
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label17.Location = New System.Drawing.Point(387, 88)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(52, 16)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Devolver:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label18.Location = New System.Drawing.Point(93, 88)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(43, 16)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Cliente:"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_cust_code
        '
        Me.xtxt_cust_code.AcceptsReturn = True
        Me.xtxt_cust_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.cust_code"))
        Me.xtxt_cust_code.EditInitialValue = Nothing
        Me.xtxt_cust_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_cust_code.FieldDescription = ""
        Me.xtxt_cust_code.FindInitialValue = Nothing
        Me.xtxt_cust_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_cust_code.IgnoreRequiered = False
        Me.xtxt_cust_code.Location = New System.Drawing.Point(152, 88)
        Me.xtxt_cust_code.Masked = MaskedTextBox.Mask.None
        Me.xtxt_cust_code.Name = "xtxt_cust_code"
        Me.xtxt_cust_code.NewInitialValue = Nothing
        Me.xtxt_cust_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_cust_code.Requiered = False
        Me.xtxt_cust_code.Size = New System.Drawing.Size(56, 20)
        Me.xtxt_cust_code.StatusBarPanelDescripcion = Nothing
        Me.xtxt_cust_code.TabIndex = 3
        Me.xtxt_cust_code.Text = ""
        '
        'xlk_cust_code
        '
        Me.xlk_cust_code.AlternateFieldSearch = Nothing
        Me.xlk_cust_code.BeginCheck = False
        Me.xlk_cust_code.CheckText = Nothing
        Me.xlk_cust_code.ComboMode = False
        Me.xlk_cust_code.DataMember = "ftfactm"
        Me.xlk_cust_code.DataSource = Me.LibXConnector1
        Me.xlk_cust_code.DestParameters = New String() {"cust_code=cust_code", "bus_name=cust_name"}
        Me.xlk_cust_code.FilterField = "cust_name"
        Me.xlk_cust_code.IgnoreFindInBrowseMode = True
        Me.xlk_cust_code.isCanceled = False
        Me.xlk_cust_code.Location = New System.Drawing.Point(208, 88)
        Me.xlk_cust_code.LookCaption = "Clientes a Credito"
        Me.xlk_cust_code.Name = "xlk_cust_code"
        Me.xlk_cust_code.PopupSize = New System.Drawing.Size(600, 400)
        Me.xlk_cust_code.ShowFilter = True
        Me.xlk_cust_code.ShowLookup = False
        Me.xlk_cust_code.ShowMessageNotFound = False
        Me.xlk_cust_code.ShowWarning = False
        Me.xlk_cust_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_cust_code.SizesColumns = New String() {"cust_name=350"}
        Me.xlk_cust_code.SizesColumnsTab = Nothing
        Me.xlk_cust_code.SqlString = Nothing
        Me.xlk_cust_code.SQLTab = Nothing
        Me.xlk_cust_code.SrcParameters = New String() {"cust_code=cust_code"}
        Me.xlk_cust_code.TabIndex = 15
        Me.xlk_cust_code.TableName = "cccustm"
        Me.xlk_cust_code.TabStop = False
        Me.xlk_cust_code.UseCopyConnection = False
        Me.xlk_cust_code.UseRowRetrieveEvents = False
        Me.xlk_cust_code.UseTab = False
        Me.xlk_cust_code.Visible = False
        Me.xlk_cust_code.VisParameters = New String() {"Codigo=cust_code", "Nombre=cust_name", "Telefono=cust_phone"}
        Me.xlk_cust_code.WhereCondition = "csttype_code in (1,3,4,6,7)"
        Me.xlk_cust_code.WhereParameters = Nothing
        '
        'lbl_ftserial_afect
        '
        Me.lbl_ftserial_afect.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_ftserial_afect.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftfactm.ftserial_afect"))
        Me.lbl_ftserial_afect.Location = New System.Drawing.Point(120, 209)
        Me.lbl_ftserial_afect.Name = "lbl_ftserial_afect"
        Me.lbl_ftserial_afect.Size = New System.Drawing.Size(32, 20)
        Me.lbl_ftserial_afect.TabIndex = 18
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.CausesValidation = False
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnCancelar.Location = New System.Drawing.Point(504, 304)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(72, 23)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "Cancelar"
        Me.ToolTip1.SetToolTip(Me.btnCancelar, "Cancelar la operación y cerrar esta pantalla")
        '
        'LBL_Title
        '
        Me.LBL_Title.BackColor = System.Drawing.Color.White
        Me.LBL_Title.Dock = System.Windows.Forms.DockStyle.Top
        Me.LBL_Title.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.LBL_Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Title.ForeColor = System.Drawing.Color.Blue
        Me.LBL_Title.Location = New System.Drawing.Point(0, 0)
        Me.LBL_Title.Name = "LBL_Title"
        Me.LBL_Title.Size = New System.Drawing.Size(586, 56)
        Me.LBL_Title.TabIndex = 0
        Me.LBL_Title.Text = "DEVOLUCION DE FACTURAS"
        Me.LBL_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnAceptar.Location = New System.Drawing.Point(424, 304)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(72, 23)
        Me.btnAceptar.TabIndex = 1
        Me.btnAceptar.Text = "Aceptar(F5)"
        Me.ToolTip1.SetToolTip(Me.btnAceptar, "Terminar de procesar los datos de la devolución")
        '
        'xtxt_telefono1
        '
        Me.xtxt_telefono1.AcceptsReturn = True
        Me.xtxt_telefono1.EditInitialValue = Nothing
        Me.xtxt_telefono1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_telefono1.FieldDescription = ""
        Me.xtxt_telefono1.FindInitialValue = Nothing
        Me.xtxt_telefono1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_telefono1.IgnoreRequiered = False
        Me.xtxt_telefono1.Location = New System.Drawing.Point(0, 0)
        Me.xtxt_telefono1.Name = "xtxt_telefono1"
        Me.xtxt_telefono1.NewInitialValue = Nothing
        Me.xtxt_telefono1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_telefono1.Requiered = False
        Me.xtxt_telefono1.StatusBarPanelDescripcion = Nothing
        Me.xtxt_telefono1.TabIndex = 0
        Me.xtxt_telefono1.Text = ""
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(0, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.TabIndex = 0
        '
        'btnView
        '
        Me.btnView.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnView.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.btnView.Enabled = False
        Me.btnView.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnView.Location = New System.Drawing.Point(8, 304)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(72, 23)
        Me.btnView.TabIndex = 2
        Me.btnView.Text = "Visualizar"
        Me.btnView.Visible = False
        '
        'i_ptvfact03
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(586, 336)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.LBL_Title)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.lbl_ftserial_afect)
        Me.Controls.Add(Me.btnView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "i_ptvfact03"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Devolución de Facturas"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        If LibXConnector1.IsDataEditing = True Then
            LibXConnector1.Cancel()
        End If

        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub xlk_codigo_BeforeExecuteQuery(ByVal sender As System.Object, ByVal e As LibX.BeforeExecuteQueryEventArgs) Handles xlk_fact_number.BeforeExecuteQuery
        Try
            If xcbo_type_code.currValue.ToString.Trim <> "" Then
                e.aditionalWhere = "type_code = '" & Me.xcbo_type_code.currValue.trim & "'"
            End If
            ''e.SQL = e.SQL
        Catch ex As Exception
            Me.DialogResult = DialogResult.None
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Public Overloads Function ShowDialog(ByVal pDevolucion As Devolucion) As DialogResult
        oDevolucion = pDevolucion

        Return MyBase.ShowDialog()
    End Function

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            If Me.xcbo_fact_cond.SelectedValue = 2 _
            And Me.xtxt_cust_code.Text.Trim = "" Then
                Throw New ApplicationException("Para devolver a credito debe seleccionar el cliente!")
            End If
            If Me.xcbo_fact_cond.SelectedValue = 3 _
            And Me.xtxt_bus_name.Text.Trim = "" Then
                Throw New ApplicationException("Para devolver con nota de credito debe digitar el nombre del cliente!")
            End If

            Aceptar()

        Catch ex As Exception
            Me.DialogResult = DialogResult.None
            LibX.Log.Show(ex)
        End Try

    End Sub

    Private Sub Aceptar()
        With oDevolucion
            If Val(Me.xtxt_fact_number.Text.Trim) > 0 Then
                .TipoDocumento = Me.xcbo_type_code.currValue.ToString.Trim
                .NumeroDocumento = Val(Me.xtxt_fact_number.Text.Trim)
                .FechaDocumento = Me.xdt_fact_date.Value
                .Serial = lbl_ftserial_afect.Text
                .ValorDocumento = Me.lbl_fact_total.Text
                If Me.xcbo_type_code.currValue = "FSG" Then
                    .MontoSeguro = Me.lbl_fact_seguro.Text
                    .Poliza = Me.xtxtAseg_poliza.Text
                Else
                    .Poliza = ""
                End If
            End If

            .NombreMotivo = Me.xcbo_dev_type.Text
            .Motivo = Me.xcbo_dev_type.currValue
            .NombreCliente = xtxt_bus_name.Text
            If Me.xtxt_cust_code.Text.Trim <> "" Then .Cliente = Me.xtxt_cust_code.Text
            .Observacion = xtxt_fact_nota.Text
            .Condicion = Me.xcbo_fact_cond.currValue
        End With

        Me.DialogResult = DialogResult.OK

        LibXConnector1.ShowWarningCancel = False
        LibXConnector1.Cancel()
        Me.Close()

    End Sub
    Private Sub xlk_fact_number_AfterSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles xlk_fact_number.AfterSetValues
        btnView.Enabled = e.dataFound

        If e.dataFound = False Then
            Exit Sub
        End If

        Try
            Me.xdt_fact_date.Value = e.row!fact_date

            If LibX.IsNull(e.row!cust_code) = False Then
                Me.xtxt_cust_code.Text = e.row!cust_code.ToString.Trim
                Me.xtxt_bus_name.Text = e.row!bus_name.ToString.Trim
                oDevolucion.Cliente = Val(e.row!cust_code.ToString.Trim)
                oDevolucion.Poliza = e.row!aseg_poliza.ToString.Trim
                If Me.xtxt_bus_name.Text = "" And Me.xtxt_cust_code.Text <> "" Then
                    Me.xtxt_bus_name.Text = LibX.Data.Manager.GetScalar("select cust_name from cccustm where cust_code =" & Me.xtxt_cust_code.Text)
                    Me.xtxt_bus_name.Text = Me.xtxt_bus_name.Text & " " & LibX.Data.Manager.GetScalar("select cust_apellidos from cccustm where cust_code =" & Me.xtxt_cust_code.Text)
                End If

                If e.row!fact_cond = 1 Then
                    Me.xcbo_fact_cond.SelectedValue = 3
                Else
                    Me.xcbo_fact_cond.SelectedValue = 2
                End If
            End If

                Me.lbl_fact_total.Text = CDec(e.row!fact_total).ToString("###,###,##0.00")

        Catch ex As Exception
            Me.DialogResult = DialogResult.None
            LibX.Log.Show(ex)
        End Try

    End Sub

    Private Sub i_ptvfact03_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            If LibXConnector1.IsDataEditing = True Then
                If e.KeyCode = Keys.F5 Then
                    If Me.xcbo_fact_cond.SelectedValue = 2 And Me.xtxt_cust_code.Text.Trim = "" Then
                        Throw New ApplicationException("Para devolver a credito debe seleccionar el cliente!")
                    End If
                    If Me.xcbo_fact_cond.SelectedValue = 3 And Me.xtxt_bus_name.Text.Trim = "" Then
                        Throw New ApplicationException("Para devolver con nota de credito debe digitar el nombre del cliente!")
                    End If
                    Aceptar()
                End If
            End If

        Catch ex As Exception
            Me.DialogResult = DialogResult.None
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_SettingDefaultNewValues(ByVal sender As Object, ByVal e As LibX.SettingDefaultNewValues) Handles LibXConnector1.SettingDefaultNewValues
        With oDevolucion
            If Not .Motivo Is Nothing Then
                If Not .TipoDocumento Is Nothing Then Me.xcbo_type_code.currValue = .TipoDocumento
                If .NumeroDocumento > 0 Then Me.xtxt_fact_number.Text = .NumeroDocumento
                If .FechaDocumento <> #12:00:00 AM# Then Me.xdt_fact_date.Value = .FechaDocumento
                If .Serial > 0 Then lbl_ftserial_afect.Text = .Serial
                If .ValorDocumento > 0 Then Me.lbl_fact_total.Text = .ValorDocumento.ToString("###,###,##0.00")
                If .Cliente > 0 Then Me.xtxt_cust_code.Text = .Cliente
                If Not .Motivo Is Nothing Then Me.xcbo_dev_type.currValue = .Motivo
                If Not .NombreCliente Is Nothing Then xtxt_bus_name.Text = .NombreCliente
                If Not .Observacion Is Nothing Then xtxt_fact_nota.Text = .Observacion
                Me.xcbo_fact_cond.currValue = Val(.Condicion)
                If .MontoSeguro > 0 Then Me.lbl_fact_seguro.Text = .MontoSeguro.ToString("###,###,##0.00")
                .Poliza = e.row!aseg_poliza
            End If
        End With

    End Sub
    Private Sub xlk_fact_number_BeforeSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles xlk_fact_number.BeforeSetValues
        Dim Mensaje As String
        Try
            If e.dataFound = False Then
                Exit Sub
            End If

            '// Si es a crédito la factura a devolver y esta factura
            '// no esta saldada no permitir devolver efectivo
            '0-Anulada
            '1-Pendiente
            '2-Cobrada
            '3-en Espera
            '4-Domicilio Pendiente

            Select Case e.row!fact_status
                Case 0
                    Throw New ApplicationException("Este documento esta anulado, no puede ser devuelto!")
                Case 1, 4
                    Throw New ApplicationException("Este documento esta pendiente, no puede ser devuelvo!")
                Case 3
                    Throw New ApplicationException("Este documento esta en espera, no puede ser devuelvo!")
            End Select


        Catch ex As Exception
            xtxt_fact_number.Text = ""
            e.handled = True
            Me.DialogResult = DialogResult.None
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub xcbo_fact_cond_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xcbo_fact_cond.SelectedIndexChanged
        Try
            If LibX.IsNull(Me.xcbo_fact_cond.SelectedValue) = False Then
                ''If Me.xcbo_fact_cond.SelectedValue = 2 Then '// Credito
                ''    Me.xlk_cust_code.WhereCondition = "csttype_code in (3)"
                ''Else
                    Me.xlk_cust_code.WhereCondition = "csttype_code in (1,3,4,6,7)"
                ''End If
                Me.xlk_cust_code.ExecuteFind()
            End If
        Catch ex As Exception
            Me.DialogResult = DialogResult.None
            LibX.Log.Add(ex)
        End Try
    End Sub
End Class
