Public Class c_ivdocs02
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
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents LibXGrid1 As LibX.LibXGrid
    Friend WithEvents XdataGridTableStyle1 As LibX.XdataGridTableStyle
    Friend WithEvents DataView1 As System.Data.DataView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chk_devoluc As System.Windows.Forms.CheckBox
    Friend WithEvents lblDevoluciones As System.Windows.Forms.Label
    Friend WithEvents chk_facturas As System.Windows.Forms.CheckBox
    Friend WithEvents lblFactura As System.Windows.Forms.Label
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents DataColumn17 As System.Data.DataColumn
    Friend WithEvents XEditTextBoxColumn8 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn9 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn10 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn11 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn12 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn13 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn14 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn16 As LibX.XEditTextBoxColumn
    Friend WithEvents ivtranrm As System.Data.DataTable
    Friend WithEvents chk_entradas As System.Windows.Forms.CheckBox
    Friend WithEvents lblEntradas As System.Windows.Forms.Label
    Friend WithEvents chk_salida As System.Windows.Forms.CheckBox
    Friend WithEvents lblSalida As System.Windows.Forms.Label
    Friend WithEvents chk_ajuste As System.Windows.Forms.CheckBox
    Friend WithEvents lblAjuste As System.Windows.Forms.Label
    Friend WithEvents XEditTextBoxColumn1 As LibX.XEditTextBoxColumn
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents chk_devfacturas As System.Windows.Forms.CheckBox
    Friend WithEvents lbldevfacturas As System.Windows.Forms.Label
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents LibXDbSourceTable2 As LibX.LibXDbSourceTable
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents XEditTextBoxColumn2 As LibX.XEditTextBoxColumn
    Friend WithEvents DataColumn18 As System.Data.DataColumn
    Friend WithEvents DataColumn19 As System.Data.DataColumn
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtitem_code As System.Windows.Forms.TextBox
    Friend WithEvents item_name As System.Windows.Forms.Label
    Friend WithEvents LibXLookup1 As LibX.LibXLookup
    Friend WithEvents DataColumn20 As System.Data.DataColumn
    Friend WithEvents xdt_FechaInicial As LibX.LibxDateTimePicker
    Friend WithEvents xdt_FechaFinal As LibX.LibxDateTimePicker
    Friend WithEvents existencia As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnView = New System.Windows.Forms.Button
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.DataSet1 = New System.Data.DataSet
        Me.ivtranrm = New System.Data.DataTable
        Me.DataColumn9 = New System.Data.DataColumn
        Me.DataColumn10 = New System.Data.DataColumn
        Me.DataColumn11 = New System.Data.DataColumn
        Me.DataColumn12 = New System.Data.DataColumn
        Me.DataColumn13 = New System.Data.DataColumn
        Me.DataColumn14 = New System.Data.DataColumn
        Me.DataColumn15 = New System.Data.DataColumn
        Me.DataColumn16 = New System.Data.DataColumn
        Me.DataColumn17 = New System.Data.DataColumn
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn7 = New System.Data.DataColumn
        Me.DataColumn8 = New System.Data.DataColumn
        Me.DataColumn18 = New System.Data.DataColumn
        Me.DataColumn19 = New System.Data.DataColumn
        Me.DataColumn20 = New System.Data.DataColumn
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.LibXGrid1 = New LibX.LibXGrid
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.DataView1 = New System.Data.DataView
        Me.XdataGridTableStyle1 = New LibX.XdataGridTableStyle
        Me.XEditTextBoxColumn8 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn9 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn10 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn11 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn12 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn2 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn13 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn14 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn16 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn1 = New LibX.XEditTextBoxColumn
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.chk_devfacturas = New System.Windows.Forms.CheckBox
        Me.lbldevfacturas = New System.Windows.Forms.Label
        Me.chk_ajuste = New System.Windows.Forms.CheckBox
        Me.lblAjuste = New System.Windows.Forms.Label
        Me.chk_facturas = New System.Windows.Forms.CheckBox
        Me.lblFactura = New System.Windows.Forms.Label
        Me.chk_devoluc = New System.Windows.Forms.CheckBox
        Me.lblDevoluciones = New System.Windows.Forms.Label
        Me.chk_entradas = New System.Windows.Forms.CheckBox
        Me.lblEntradas = New System.Windows.Forms.Label
        Me.chk_salida = New System.Windows.Forms.CheckBox
        Me.lblSalida = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.existencia = New System.Windows.Forms.Label
        Me.LibXLookup1 = New LibX.LibXLookup
        Me.xdt_FechaInicial = New LibX.LibxDateTimePicker
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.item_name = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtitem_code = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.xdt_FechaFinal = New LibX.LibxDateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ivtranrm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(0, 521)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1016, 8)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'btnView
        '
        Me.btnView.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnView.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnView.Location = New System.Drawing.Point(8, 537)
        Me.btnView.Name = "btnView"
        Me.btnView.TabIndex = 2
        Me.btnView.Text = "Visualizar"
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCerrar.Location = New System.Drawing.Point(936, 536)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.TabIndex = 3
        Me.btnCerrar.Text = "Cerrar"
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
        Me.LibXConnector1.DataMember = "ivtranrm"
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
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.LibXDbSourceTable2})
        Me.LibXConnector1.State = LibX.LibxConnectorState.none
        Me.LibXConnector1.UpdatePrimaryKeyColumns = False
        Me.LibXConnector1.UseTransactions = True
        '
        'DataSet1
        '
        Me.LibXConnector1.SetDataGenerator(Me.DataSet1, Me.LibXConnector1)
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, False)
        Me.DataSet1.EnforceConstraints = False
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.ivtranrm})
        '
        'ivtranrm
        '
        Me.ivtranrm.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20})
        Me.ivtranrm.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"trane_number"}, True)})
        Me.ivtranrm.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn4}
        Me.ivtranrm.TableName = "ivtranrm"
        '
        'DataColumn9
        '
        Me.DataColumn9.AllowDBNull = False
        Me.DataColumn9.ColumnName = "type_code"
        Me.DataColumn9.MaxLength = 3
        '
        'DataColumn10
        '
        Me.DataColumn10.AllowDBNull = False
        Me.DataColumn10.ColumnName = "type_name"
        Me.DataColumn10.MaxLength = 100
        Me.DataColumn10.ReadOnly = True
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "doc_number"
        Me.DataColumn11.MaxLength = 20
        '
        'DataColumn12
        '
        Me.DataColumn12.AllowDBNull = False
        Me.DataColumn12.ColumnName = "doc_date"
        Me.DataColumn12.DataType = GetType(System.DateTime)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "qty"
        Me.DataColumn13.DataType = GetType(System.Int32)
        Me.DataColumn13.ReadOnly = True
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "Tasa"
        Me.DataColumn14.DataType = GetType(System.Decimal)
        '
        'DataColumn15
        '
        Me.DataColumn15.AllowDBNull = False
        Me.DataColumn15.ColumnName = "costo"
        Me.DataColumn15.DataType = GetType(System.Decimal)
        Me.DataColumn15.ReadOnly = True
        '
        'DataColumn16
        '
        Me.DataColumn16.AllowDBNull = False
        Me.DataColumn16.ColumnName = "price"
        Me.DataColumn16.DataType = GetType(System.Decimal)
        Me.DataColumn16.ReadOnly = True
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "bf_onhand"
        Me.DataColumn17.DataType = GetType(System.Int32)
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "rs_onhand"
        Me.DataColumn1.DataType = GetType(System.Int32)
        Me.DataColumn1.ReadOnly = True
        '
        'DataColumn2
        '
        Me.DataColumn2.AllowDBNull = False
        Me.DataColumn2.ColumnName = "doc_serial"
        Me.DataColumn2.DataType = GetType(System.Int32)
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "nqty"
        Me.DataColumn3.DataType = GetType(System.Decimal)
        Me.DataColumn3.ReadOnly = True
        '
        'DataColumn4
        '
        Me.DataColumn4.AllowDBNull = False
        Me.DataColumn4.AutoIncrement = True
        Me.DataColumn4.ColumnName = "trane_number"
        Me.DataColumn4.DataType = GetType(System.Int32)
        Me.DataColumn4.ReadOnly = True
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "reference"
        Me.DataColumn5.MaxLength = 40
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "tranr_status"
        Me.DataColumn6.DataType = GetType(System.Int32)
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "origen"
        Me.DataColumn7.DataType = GetType(System.Int32)
        '
        'DataColumn8
        '
        Me.DataColumn8.AllowDBNull = False
        Me.DataColumn8.ColumnName = "unit_code"
        Me.DataColumn8.MaxLength = 4
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "costo1"
        Me.DataColumn18.DataType = GetType(System.Decimal)
        Me.DataColumn18.ReadOnly = True
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "price1"
        Me.DataColumn19.DataType = GetType(System.Decimal)
        Me.DataColumn19.ReadOnly = True
        '
        'DataColumn20
        '
        Me.DataColumn20.AllowDBNull = False
        Me.DataColumn20.ColumnName = "item_code"
        Me.DataColumn20.MaxLength = 10
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
        Me.LibXDbSourceTable2.Source = New String() {"select origen,ivtranrm.trane_number,ivtranrm.type_code,", "" & Microsoft.VisualBasic.ChrW(9) & "case ivtranrm.type_code when 'FPV' then isnull(cccustm.cust_name,[type_name])", "" & Microsoft.VisualBasic.ChrW(9) & "when 'DEV' then isnull(cccustm.cust_name,[type_name])", "" & Microsoft.VisualBasic.ChrW(9) & "when 'FSG' then isnull(ftfactm.bus_name,[type_name])", "" & Microsoft.VisualBasic.ChrW(9) & "when 'CRD' then  isnull(cpprovm.prov_name,[type_name]) ", "" & Microsoft.VisualBasic.ChrW(9) & "when 'DVI' then  isnull(cpprovm.prov_name,[type_name]) ", "" & Microsoft.VisualBasic.ChrW(9) & "when 'ADJ' then  isnull(ivdocsm.nota,[type_name])", "" & Microsoft.VisualBasic.ChrW(9) & "else [type_name] end [type_name],", "" & Microsoft.VisualBasic.ChrW(9) & "ivtranrm.doc_number,ivtranrm.doc_serial,ivtranrm.doc_date,", "" & Microsoft.VisualBasic.ChrW(9) & "case ivtypem.type_code when 'ADJ'", "" & Microsoft.VisualBasic.ChrW(9) & "then (ivtranrd.qty) else ", "" & Microsoft.VisualBasic.ChrW(9) & "(case doc_input when 1 then (ivtranrd.qty) else (ivtranrd.qty)*-1 end) end qty,", "         ivtranrd.unit_code,", "         case ivtranrm.type_code when 'DVI'", "" & Microsoft.VisualBasic.ChrW(9) & "    then (case factor when 1 then (ivtranrd.costo/factor)*factor else (ivtranrd." & _
        "costo/factor)* factor end) ", "            else (case factor when 1 then  ivtranrd.costo*factor else (case ivtra" & _
        "nrm.type_code when 'CRD' then", "                 ivtranrd.costo*factor else (case ivtranrm.type_code when 'FPV' t" & _
        "hen ivtranrd.costo*factor ", "            else (case ivtranrm.type_code when 'FSG' then ivtranrd.costo*factor e" & _
        "lse (case ivtranrm.type_code when 'DEV' ", "            then ivtranrd.costo*factor else(ivtranrd.costo/factor)*factor  end)en" & _
        "d)end)end)end)end costo,", "" & Microsoft.VisualBasic.ChrW(9) & " case ivtranrm.type_code when 'DVI'", "            then (case factor when 1 then (ivtranrd.price/factor)*factor else (iv" & _
        "tranrd.price/factor)* factor end) ", "            else (case factor when 1 then ivtranrd.price*factor else (case ivtran" & _
        "rm.type_code when 'FPV' then", "                 (ivtranrd.price/factor)* factor else (case ivtranrm.type_code wh" & _
        "en 'FSG' then (ivtranrd.price/factor)*factor ", "             else (case ivtranrm.type_code when 'DEV' then (ivtranrd.price/factor" & _
        ")*factor ", "             else ivtranrd.price*factor end)end)end)end)end price,", "" & Microsoft.VisualBasic.ChrW(9) & " case ivtypem.type_code when 'ADJ'", "" & Microsoft.VisualBasic.ChrW(9) & "then isnull(bf_onhand,0)+((isnull(qty,0)*factor)) ", "" & Microsoft.VisualBasic.ChrW(9) & "else isnull(bf_onhand,0)+((isnull(qty,0)*factor)* (case doc_input when 1 then 1 " & _
        "else -1 end)) end rs_onhand,ivtranrd.bf_onhand,", "         ivtranrd.item_code", "" & Microsoft.VisualBasic.ChrW(9) & "from ivtranrm inner join ivtranrd on ivtranrm.trane_number = ivtranrd.trane_numb" & _
        "er", "" & Microsoft.VisualBasic.ChrW(9) & "inner join ivtypem on ivtranrm.type_code = ivtypem.type_code", "" & Microsoft.VisualBasic.ChrW(9) & "left join cccustm on cccustm.cust_code = ivtranrm.reference", "" & Microsoft.VisualBasic.ChrW(9) & "left join cpprovm on cpprovm.prov_code = ivtranrm.reference", "" & Microsoft.VisualBasic.ChrW(9) & "left join ftfactm on ftfactm.ftserial_no = ivtranrm.doc_serial", "" & Microsoft.VisualBasic.ChrW(9) & "left join ivdocsm on ivdocsm.doc_serial = ivtranrm.doc_serial", "order by ivtranrm.trane_number"}
        Me.LibXDbSourceTable2.TableName = "ivtranrm"
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
        Me.LibXDbSourceTable1.Source = New String() {"select ivtranrm.type_code,[type_name],doc_number,doc_serial,", "doc_date", ",case ivtypem.type_code when 'ADJ' ", " then (ivtranrd.qty*factor) ", "else (ivtranrd.qty*factor) * origen end qty", ",ivtranrd.costo,ivtranrd.price,", "case ivtypem.type_code when 'ADJ' ", "then isnull(bf_onhand,0)+((isnull(qty,0)*factor)) ", "else isnull(bf_onhand,0)+((isnull(qty,0)*factor)*origen) end rs_onhand", ",ivtranrd.bf_onhand", "from ivtranrm ", "inner join ivtranrd", "on ivtranrm.trane_number = ivtranrd.trane_number", "inner join ivtypem ", "on ivtranrm.type_code = ivtypem.type_code", "inner join ivunitd", "on ivunitd.item_code = ivtranrd.item_code", "and ivunitd.unit_code = ivtranrd.unit_code"}
        Me.LibXDbSourceTable1.TableName = "ivtranrm"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
        '
        'LibXGrid1
        '
        Me.LibXGrid1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LibXGrid1.AutoAdjustLastColumn = True
        Me.LibXGrid1.AutoSearch = True
        Me.LibXGrid1.BackgroundColor = System.Drawing.Color.White
        Me.LibXGrid1.CaptionText = "Movimientos"
        Me.LibXGrid1.ContextMenu = Me.ContextMenu1
        Me.LibXGrid1.DataMember = ""
        Me.LibXGrid1.DataSource = Me.DataView1
        Me.LibXGrid1.FullRowSelect = False
        Me.LibXGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGrid1.IsReadOnly = False
        Me.LibXGrid1.Location = New System.Drawing.Point(16, 104)
        Me.LibXGrid1.Name = "LibXGrid1"
        Me.LibXGrid1.ReadOnly = True
        Me.LibXGrid1.searchText = ""
        Me.LibXGrid1.showFooterBar = True
        Me.LibXGrid1.Size = New System.Drawing.Size(888, 376)
        Me.LibXGrid1.TabIndex = 4
        Me.LibXGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.XdataGridTableStyle1})
        Me.LibXGrid1.UseAutoFillLines = True
        Me.LibXGrid1.UseHandCursor = False
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem3})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "Visualizar"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Text = "-"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.Text = "Cerrar"
        '
        'DataView1
        '
        Me.DataView1.AllowDelete = False
        Me.DataView1.AllowEdit = False
        Me.DataView1.AllowNew = False
        Me.DataView1.Table = Me.ivtranrm
        '
        'XdataGridTableStyle1
        '
        Me.XdataGridTableStyle1.AlternatingBackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.XdataGridTableStyle1.DataGrid = Me.LibXGrid1
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.XEditTextBoxColumn8, Me.XEditTextBoxColumn9, Me.XEditTextBoxColumn10, Me.XEditTextBoxColumn11, Me.XEditTextBoxColumn12, Me.XEditTextBoxColumn2, Me.XEditTextBoxColumn13, Me.XEditTextBoxColumn14, Me.XEditTextBoxColumn16, Me.XEditTextBoxColumn1})
        Me.XdataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle1.MappingName = "ivtranrm"
        '
        'XEditTextBoxColumn8
        '
        Me.XEditTextBoxColumn8.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn8.Format = ""
        Me.XEditTextBoxColumn8.FormatInfo = Nothing
        Me.XEditTextBoxColumn8.HeaderText = "Tipo"
        Me.XEditTextBoxColumn8.ImageList = Nothing
        Me.XEditTextBoxColumn8.isReadOnly = False
        Me.XEditTextBoxColumn8.MappingName = "type_code"
        Me.XEditTextBoxColumn8.MaxLength = 32767
        Me.XEditTextBoxColumn8.TabStop = True
        Me.XEditTextBoxColumn8.UseCustomCellFormat = True
        Me.XEditTextBoxColumn8.Width = 35
        '
        'XEditTextBoxColumn9
        '
        Me.XEditTextBoxColumn9.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn9.Format = ""
        Me.XEditTextBoxColumn9.FormatInfo = Nothing
        Me.XEditTextBoxColumn9.HeaderText = "Descripción"
        Me.XEditTextBoxColumn9.ImageList = Nothing
        Me.XEditTextBoxColumn9.isReadOnly = False
        Me.XEditTextBoxColumn9.MappingName = "type_name"
        Me.XEditTextBoxColumn9.MaxLength = 32767
        Me.XEditTextBoxColumn9.TabStop = True
        Me.XEditTextBoxColumn9.UseCustomCellFormat = True
        Me.XEditTextBoxColumn9.Width = 200
        '
        'XEditTextBoxColumn10
        '
        Me.XEditTextBoxColumn10.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn10.Format = ""
        Me.XEditTextBoxColumn10.FormatInfo = Nothing
        Me.XEditTextBoxColumn10.HeaderText = "Número"
        Me.XEditTextBoxColumn10.ImageList = Nothing
        Me.XEditTextBoxColumn10.isReadOnly = False
        Me.XEditTextBoxColumn10.MappingName = "doc_number"
        Me.XEditTextBoxColumn10.MaxLength = 32767
        Me.XEditTextBoxColumn10.TabStop = True
        Me.XEditTextBoxColumn10.UseCustomCellFormat = True
        Me.XEditTextBoxColumn10.Width = 80
        '
        'XEditTextBoxColumn11
        '
        Me.XEditTextBoxColumn11.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.XEditTextBoxColumn11.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn11.Format = ""
        Me.XEditTextBoxColumn11.FormatInfo = Nothing
        Me.XEditTextBoxColumn11.HeaderText = "Fecha"
        Me.XEditTextBoxColumn11.ImageList = Nothing
        Me.XEditTextBoxColumn11.isReadOnly = False
        Me.XEditTextBoxColumn11.MappingName = "doc_date"
        Me.XEditTextBoxColumn11.MaxLength = 32767
        Me.XEditTextBoxColumn11.TabStop = True
        Me.XEditTextBoxColumn11.UseCustomCellFormat = True
        Me.XEditTextBoxColumn11.Width = 83
        '
        'XEditTextBoxColumn12
        '
        Me.XEditTextBoxColumn12.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.XEditTextBoxColumn12.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn12.Format = "###,###"
        Me.XEditTextBoxColumn12.FormatInfo = Nothing
        Me.XEditTextBoxColumn12.HeaderText = "Cantidadi"
        Me.XEditTextBoxColumn12.ImageList = Nothing
        Me.XEditTextBoxColumn12.isReadOnly = False
        Me.XEditTextBoxColumn12.MappingName = "qty"
        Me.XEditTextBoxColumn12.MaxLength = 32767
        Me.XEditTextBoxColumn12.TabStop = True
        Me.XEditTextBoxColumn12.UseCustomCellFormat = True
        Me.XEditTextBoxColumn12.Width = 60
        '
        'XEditTextBoxColumn2
        '
        Me.XEditTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.XEditTextBoxColumn2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn2.Format = ""
        Me.XEditTextBoxColumn2.FormatInfo = Nothing
        Me.XEditTextBoxColumn2.HeaderText = "Unidad"
        Me.XEditTextBoxColumn2.ImageList = Nothing
        Me.XEditTextBoxColumn2.isReadOnly = False
        Me.XEditTextBoxColumn2.MappingName = "unit_code"
        Me.XEditTextBoxColumn2.MaxLength = 32767
        Me.XEditTextBoxColumn2.TabStop = True
        Me.XEditTextBoxColumn2.UseCustomCellFormat = True
        Me.XEditTextBoxColumn2.Width = 48
        '
        'XEditTextBoxColumn13
        '
        Me.XEditTextBoxColumn13.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.XEditTextBoxColumn13.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn13.Format = "###,###,##0.00"
        Me.XEditTextBoxColumn13.FormatInfo = Nothing
        Me.XEditTextBoxColumn13.HeaderText = "Costoi"
        Me.XEditTextBoxColumn13.ImageList = Nothing
        Me.XEditTextBoxColumn13.isReadOnly = False
        Me.XEditTextBoxColumn13.MappingName = "costo"
        Me.XEditTextBoxColumn13.MaxLength = 32767
        Me.XEditTextBoxColumn13.TabStop = True
        Me.XEditTextBoxColumn13.UseCustomCellFormat = True
        Me.XEditTextBoxColumn13.Width = 80
        '
        'XEditTextBoxColumn14
        '
        Me.XEditTextBoxColumn14.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.XEditTextBoxColumn14.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn14.Format = "###,###,##0.00"
        Me.XEditTextBoxColumn14.FormatInfo = Nothing
        Me.XEditTextBoxColumn14.HeaderText = "Precioi"
        Me.XEditTextBoxColumn14.ImageList = Nothing
        Me.XEditTextBoxColumn14.isReadOnly = False
        Me.XEditTextBoxColumn14.MappingName = "price"
        Me.XEditTextBoxColumn14.MaxLength = 32767
        Me.XEditTextBoxColumn14.TabStop = True
        Me.XEditTextBoxColumn14.UseCustomCellFormat = True
        Me.XEditTextBoxColumn14.Width = 80
        '
        'XEditTextBoxColumn16
        '
        Me.XEditTextBoxColumn16.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.XEditTextBoxColumn16.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn16.Format = "###,###"
        Me.XEditTextBoxColumn16.FormatInfo = Nothing
        Me.XEditTextBoxColumn16.HeaderText = "Exist. Anteriori"
        Me.XEditTextBoxColumn16.ImageList = Nothing
        Me.XEditTextBoxColumn16.isReadOnly = False
        Me.XEditTextBoxColumn16.MappingName = "bf_onhand"
        Me.XEditTextBoxColumn16.MaxLength = 32767
        Me.XEditTextBoxColumn16.TabStop = True
        Me.XEditTextBoxColumn16.UseCustomCellFormat = True
        Me.XEditTextBoxColumn16.Width = 85
        '
        'XEditTextBoxColumn1
        '
        Me.XEditTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.XEditTextBoxColumn1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn1.Format = "###,##0.00"
        Me.XEditTextBoxColumn1.FormatInfo = Nothing
        Me.XEditTextBoxColumn1.HeaderText = "Exist. Resultantei"
        Me.XEditTextBoxColumn1.ImageList = Nothing
        Me.XEditTextBoxColumn1.isReadOnly = False
        Me.XEditTextBoxColumn1.MappingName = "rs_onhand"
        Me.XEditTextBoxColumn1.MaxLength = 32767
        Me.XEditTextBoxColumn1.TabStop = True
        Me.XEditTextBoxColumn1.UseCustomCellFormat = True
        Me.XEditTextBoxColumn1.Width = 90
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.chk_devfacturas)
        Me.GroupBox2.Controls.Add(Me.lbldevfacturas)
        Me.GroupBox2.Controls.Add(Me.chk_ajuste)
        Me.GroupBox2.Controls.Add(Me.lblAjuste)
        Me.GroupBox2.Controls.Add(Me.chk_facturas)
        Me.GroupBox2.Controls.Add(Me.lblFactura)
        Me.GroupBox2.Controls.Add(Me.chk_devoluc)
        Me.GroupBox2.Controls.Add(Me.lblDevoluciones)
        Me.GroupBox2.Controls.Add(Me.chk_entradas)
        Me.GroupBox2.Controls.Add(Me.lblEntradas)
        Me.GroupBox2.Controls.Add(Me.chk_salida)
        Me.GroupBox2.Controls.Add(Me.lblSalida)
        Me.GroupBox2.Location = New System.Drawing.Point(908, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(112, 512)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtrar"
        '
        'chk_devfacturas
        '
        Me.chk_devfacturas.Location = New System.Drawing.Point(8, 48)
        Me.chk_devfacturas.Name = "chk_devfacturas"
        Me.chk_devfacturas.Size = New System.Drawing.Size(96, 16)
        Me.chk_devfacturas.TabIndex = 16
        Me.chk_devfacturas.Text = "Dev. Facturas"
        '
        'lbldevfacturas
        '
        Me.lbldevfacturas.BackColor = System.Drawing.Color.DarkCyan
        Me.lbldevfacturas.Location = New System.Drawing.Point(8, 64)
        Me.lbldevfacturas.Name = "lbldevfacturas"
        Me.lbldevfacturas.Size = New System.Drawing.Size(96, 8)
        Me.lbldevfacturas.TabIndex = 15
        '
        'chk_ajuste
        '
        Me.chk_ajuste.Location = New System.Drawing.Point(8, 208)
        Me.chk_ajuste.Name = "chk_ajuste"
        Me.chk_ajuste.Size = New System.Drawing.Size(96, 16)
        Me.chk_ajuste.TabIndex = 14
        Me.chk_ajuste.Text = "Ajuste Inv."
        '
        'lblAjuste
        '
        Me.lblAjuste.BackColor = System.Drawing.Color.RosyBrown
        Me.lblAjuste.Location = New System.Drawing.Point(8, 224)
        Me.lblAjuste.Name = "lblAjuste"
        Me.lblAjuste.Size = New System.Drawing.Size(96, 8)
        Me.lblAjuste.TabIndex = 13
        '
        'chk_facturas
        '
        Me.chk_facturas.Location = New System.Drawing.Point(8, 16)
        Me.chk_facturas.Name = "chk_facturas"
        Me.chk_facturas.Size = New System.Drawing.Size(96, 16)
        Me.chk_facturas.TabIndex = 12
        Me.chk_facturas.Text = "Facturas"
        '
        'lblFactura
        '
        Me.lblFactura.BackColor = System.Drawing.Color.Cyan
        Me.lblFactura.Location = New System.Drawing.Point(8, 32)
        Me.lblFactura.Name = "lblFactura"
        Me.lblFactura.Size = New System.Drawing.Size(96, 8)
        Me.lblFactura.TabIndex = 11
        '
        'chk_devoluc
        '
        Me.chk_devoluc.Location = New System.Drawing.Point(8, 88)
        Me.chk_devoluc.Name = "chk_devoluc"
        Me.chk_devoluc.Size = New System.Drawing.Size(96, 16)
        Me.chk_devoluc.TabIndex = 10
        Me.chk_devoluc.Text = "Dev. Inv."
        '
        'lblDevoluciones
        '
        Me.lblDevoluciones.BackColor = System.Drawing.Color.LightPink
        Me.lblDevoluciones.Location = New System.Drawing.Point(8, 104)
        Me.lblDevoluciones.Name = "lblDevoluciones"
        Me.lblDevoluciones.Size = New System.Drawing.Size(96, 8)
        Me.lblDevoluciones.TabIndex = 9
        '
        'chk_entradas
        '
        Me.chk_entradas.Location = New System.Drawing.Point(8, 128)
        Me.chk_entradas.Name = "chk_entradas"
        Me.chk_entradas.Size = New System.Drawing.Size(96, 16)
        Me.chk_entradas.TabIndex = 10
        Me.chk_entradas.Text = "Compras"
        '
        'lblEntradas
        '
        Me.lblEntradas.BackColor = System.Drawing.Color.Khaki
        Me.lblEntradas.Location = New System.Drawing.Point(8, 144)
        Me.lblEntradas.Name = "lblEntradas"
        Me.lblEntradas.Size = New System.Drawing.Size(96, 8)
        Me.lblEntradas.TabIndex = 9
        '
        'chk_salida
        '
        Me.chk_salida.Location = New System.Drawing.Point(8, 168)
        Me.chk_salida.Name = "chk_salida"
        Me.chk_salida.Size = New System.Drawing.Size(112, 16)
        Me.chk_salida.TabIndex = 10
        Me.chk_salida.Text = "Salida Inv."
        '
        'lblSalida
        '
        Me.lblSalida.BackColor = System.Drawing.Color.LightGray
        Me.lblSalida.Location = New System.Drawing.Point(8, 184)
        Me.lblSalida.Name = "lblSalida"
        Me.lblSalida.Size = New System.Drawing.Size(96, 8)
        Me.lblSalida.TabIndex = 9
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.existencia)
        Me.GroupBox3.Controls.Add(Me.LibXLookup1)
        Me.GroupBox3.Controls.Add(Me.xdt_FechaInicial)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.item_name)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.txtitem_code)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.xdt_FechaFinal)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(888, 88)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Criterio"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(560, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 23)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Existencia:"
        '
        'existencia
        '
        Me.existencia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.existencia.Location = New System.Drawing.Point(624, 24)
        Me.existencia.Name = "existencia"
        Me.existencia.Size = New System.Drawing.Size(104, 23)
        Me.existencia.TabIndex = 7
        '
        'LibXLookup1
        '
        Me.LibXLookup1.AlternateFieldSearch = Nothing
        Me.LibXLookup1.BeginCheck = False
        Me.LibXLookup1.CheckText = Nothing
        Me.LibXLookup1.ComboMode = False
        Me.LibXLookup1.DataMember = Nothing
        Me.LibXLookup1.DataSource = Me.LibXConnector1
        Me.LibXLookup1.DestParameters = New String() {"item_code=item_code", "item_name=item_name", "existencia=existencia"}
        Me.LibXLookup1.FilterField = "item_name"
        Me.LibXLookup1.IgnoreFindInBrowseMode = False
        Me.LibXLookup1.isCanceled = False
        Me.LibXLookup1.Location = New System.Drawing.Point(728, 24)
        Me.LibXLookup1.LookCaption = "Productos"
        Me.LibXLookup1.Name = "LibXLookup1"
        Me.LibXLookup1.PopupSize = New System.Drawing.Size(0, 0)
        Me.LibXLookup1.ShowFilter = True
        Me.LibXLookup1.ShowMessageNotFound = True
        Me.LibXLookup1.ShowWarning = True
        Me.LibXLookup1.Size = New System.Drawing.Size(16, 20)
        Me.LibXLookup1.SizesColumns = New String() {"item_code=100", "item_name=350"}
        Me.LibXLookup1.SizesColumnsTab = Nothing
        Me.LibXLookup1.SqlString = Nothing
        Me.LibXLookup1.SQLTab = Nothing
        Me.LibXLookup1.SrcParameters = New String() {"item_code=item_code"}
        Me.LibXLookup1.TabIndex = 6
        Me.LibXLookup1.TableName = "ivitemv1"
        Me.LibXLookup1.TabStop = False
        Me.LibXLookup1.UseCopyConnection = False
        Me.LibXLookup1.UseRowRetrieveEvents = False
        Me.LibXLookup1.UseTab = False
        Me.LibXLookup1.VisParameters = New String() {"Codigo=item_code", "Descripcion=item_name", "Unidad=purch_unit", "Costo=purch_cost", "Precio=price", "Preico+Itbis=precioitbis", "Existencia=existencia"}
        Me.LibXLookup1.WhereCondition = Nothing
        Me.LibXLookup1.WhereParameters = Nothing
        '
        'xdt_FechaInicial
        '
        Me.xdt_FechaInicial.CustomFormat = "dd/MM/yyyy"
        Me.xdt_FechaInicial.EditInitialValue = Nothing
        Me.xdt_FechaInicial.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_FechaInicial.FieldDescription = ""
        Me.xdt_FechaInicial.FindInitialValue = Nothing
        Me.xdt_FechaInicial.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_FechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.xdt_FechaInicial.IgnoreRequiered = False
        Me.xdt_FechaInicial.Location = New System.Drawing.Point(112, 56)
        Me.xdt_FechaInicial.Name = "xdt_FechaInicial"
        Me.xdt_FechaInicial.NewInitialValue = "Now"
        Me.xdt_FechaInicial.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_FechaInicial.Requiered = False
        Me.xdt_FechaInicial.Size = New System.Drawing.Size(121, 20)
        Me.xdt_FechaInicial.StatusBarPanelDescripcion = Nothing
        Me.xdt_FechaInicial.TabIndex = 5
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(800, 48)
        Me.Button2.Name = "Button2"
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Limpiar"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(800, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Buscar"
        '
        'item_name
        '
        Me.item_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.item_name.Location = New System.Drawing.Point(240, 24)
        Me.item_name.Name = "item_name"
        Me.item_name.Size = New System.Drawing.Size(312, 23)
        Me.item_name.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Producto:"
        '
        'txtitem_code
        '
        Me.txtitem_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivtranrm.item_code"))
        Me.txtitem_code.Location = New System.Drawing.Point(112, 24)
        Me.txtitem_code.Name = "txtitem_code"
        Me.txtitem_code.Size = New System.Drawing.Size(120, 20)
        Me.txtitem_code.TabIndex = 0
        Me.txtitem_code.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Fecha Inicial:"
        '
        'xdt_FechaFinal
        '
        Me.xdt_FechaFinal.CustomFormat = "dd/MM/yyyy"
        Me.xdt_FechaFinal.EditInitialValue = Nothing
        Me.xdt_FechaFinal.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_FechaFinal.FieldDescription = ""
        Me.xdt_FechaFinal.FindInitialValue = Nothing
        Me.xdt_FechaFinal.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_FechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.xdt_FechaFinal.IgnoreRequiered = False
        Me.xdt_FechaFinal.Location = New System.Drawing.Point(432, 56)
        Me.xdt_FechaFinal.Name = "xdt_FechaFinal"
        Me.xdt_FechaFinal.NewInitialValue = "Now"
        Me.xdt_FechaFinal.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_FechaFinal.Requiered = False
        Me.xdt_FechaFinal.Size = New System.Drawing.Size(121, 20)
        Me.xdt_FechaFinal.StatusBarPanelDescripcion = Nothing
        Me.xdt_FechaFinal.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(328, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Fecha Final:"
        '
        'c_ivdocs02
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.btnCerrar
        Me.ClientSize = New System.Drawing.Size(1024, 566)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.LibXGrid1)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "c_ivdocs02"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Movimientos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ivtranrm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub c_ccdocs01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            LibXGrid1.footerOperations.add("qty", "sum(qty)", "1=1")
            LibXGrid1.footerOperations.add("bf_onhand", "sum(qty)", "qty>0")
            LibXGrid1.footerOperations.add("rs_onhand", "sum(qty)", "qty<0")

            LibXConnector1.Find() '// Inicializar en fin mode
            'If Not LibXConnector1.Parameters Is Nothing Then
            '    If Not LibX.IsNull(LibXConnector1.Parameters.Datos("where")) Then
            '        LibXConnector1.ExecuteFind(LibXConnector1.Parameters.Datos("where"))
            '    End If
            'End If
            'LibXGrid1.refreshFooter()

        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub
    Private Sub ApplyFilter()
        Dim Filter As String = ""
        Try

            If chk_facturas.Checked = True Then
                Filter = "type_code ='FCT' or type_code ='FPV'"
            End If

            If chk_devoluc.Checked = True Then
                If Filter.Length = 0 Then
                    Filter = "type_code = 'DVI'"
                Else
                    Filter = Filter & " and type_code = 'DVI'"
                End If
            End If

            If Me.chk_devfacturas.Checked = True Then
                If Filter.Length = 0 Then
                    Filter = "type_code ='DVF' or type_code = 'DEV'"
                Else
                    Filter = Filter & " and (type_code = 'DVF' or type_code = 'DEV')"
                End If
            End If

            If chk_entradas.Checked = True Then
                If Filter.Length = 0 Then
                    Filter = "type_code = 'CRD'"
                Else
                    Filter = Filter & " and type_code = 'CRD'"
                End If
            End If

            If chk_salida.Checked = True Then
                If Filter.Length = 0 Then
                    Filter = "type_code = 'SAL'"
                Else
                    Filter = Filter & " and type_code = 'SAL'"
                End If
            End If

            If chk_ajuste.Checked = True Then
                If Filter.Length = 0 Then
                    Filter = "type_code = 'ADJ'"
                Else
                    Filter = Filter & " and type_code = 'ADJ'"
                End If
            End If
            DataView1.RowFilter = Filter
        Catch ex As Exception
            LibX.Log.Add(ex)

        End Try

    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub chk_facturas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_facturas.CheckedChanged
        ApplyFilter()
    End Sub

    Private Sub chk_devoluc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_devoluc.CheckedChanged
        ApplyFilter()
    End Sub

    Private Sub XEditTextBoxColumn1_SetCellFormat(ByVal sender As System.Object, ByVal e As LibX.XDataGridFormatCellEventArgs) Handles XEditTextBoxColumn8.SetCellFormat, XEditTextBoxColumn9.SetCellFormat, XEditTextBoxColumn10.SetCellFormat, XEditTextBoxColumn11.SetCellFormat, XEditTextBoxColumn12.SetCellFormat, XEditTextBoxColumn2.SetCellFormat, XEditTextBoxColumn13.SetCellFormat, XEditTextBoxColumn14.SetCellFormat, XEditTextBoxColumn16.SetCellFormat, XEditTextBoxColumn1.SetCellFormat
        Try
            If LibXGrid1.GetValue(e.RowNumber, 0) = "DEV" Then
                e.BackColor = lbldevfacturas.BackColor
            End If

            If LibXGrid1.GetValue(e.RowNumber, 0) = "DVI" Then
                e.BackColor = lblDevoluciones.BackColor
            End If

            If LibXGrid1.GetValue(e.RowNumber, 0) = "FCT" _
            Or LibXGrid1.GetValue(e.RowNumber, 0) = "FPV" Then
                e.BackColor = lblFactura.BackColor
            End If

            If LibXGrid1.GetValue(e.RowNumber, 0) = "CRD" Then
                e.BackColor = lblEntradas.BackColor
            End If

            If LibXGrid1.GetValue(e.RowNumber, 0) = "SAL" Then
                e.BackColor = lblSalida.BackColor
            End If

            If LibXGrid1.GetValue(e.RowNumber, 0) = "ADJ" Then
                e.BackColor = lblAjuste.BackColor
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        Dim xParam As LibX.LibxPrgParams
        Dim ftSerial As Integer
        Try
            xParam = New LibX.LibxPrgParams
            xParam.AllowDelete = False
            xParam.AllowEdit = False
            xParam.AllowNew = False
            xParam.AllowPrint = False
            xParam.AllowQuery = False
            xParam.initMode = LibX.LibxInitModes.none

            LibX.App.CurrentPrgParams = xParam

            ''If LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, 0) = "FPV" Or LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, 0) = "FSG" Or LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, 0) = "DEV" Then
            ''    xParam.WhereToExecute = "ftfactm.fact_number = " & ivtranrm.Rows(LibXGrid1.CurrentRowIndex)!doc_serial.ToString
            ''    LibX.LibXRunner.Run("i_ptvfind", "FPV", True)
            ''End If
            If (LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, 0) = "FPV" Or LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, 0) = "FSG" Or LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, 0) = "DEV") Then
                ftSerial = ivtranrm.Rows(LibXGrid1.CurrentRowIndex)!doc_serial.ToString
                xParam.WhereToExecute = "ftfactm.ftserial_no = " & ftSerial
                xParam.Datos.Add("ftserial_no", ftSerial)
                xParam.Datos.Add("type_code", ivtranrm.Rows(LibXGrid1.CurrentRowIndex)!type_code.ToString)
                xParam.Value = ftSerial
                LibX.LibXRunner.Run("i_ptvfind", "PTV", True)
            End If

            ''If LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, 0) = "DEV" Then
            ''    xParam.WhereToExecute = "fact_number = " & ivtranrm.Rows(LibXGrid1.CurrentRowIndex)!doc_serial.ToString
            ''    LibX.LibXRunner.Run("i_ptvfind", "FPV", True)
            ''End If

            If LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, 0) = "DVI" Then
                xParam.WhereToExecute = "dev_serial = " & ivtranrm.Rows(LibXGrid1.CurrentRowIndex)!doc_serial.ToString
                LibX.LibXRunner.Run("i_ivdevm01", "INV", True)
            End If

            If LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, 0) = "CRD" Then
                xParam.WhereToExecute = "entr_serial = " & ivtranrm.Rows(LibXGrid1.CurrentRowIndex)!doc_serial.ToString
                LibX.LibXRunner.Run("i_iventr02", "INV", True)
            End If

            If LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, 0) = "ADJ" Then
                xParam.WhereToExecute = "doc_serial = " & ivtranrm.Rows(LibXGrid1.CurrentRowIndex)!doc_serial.ToString
                LibX.LibXRunner.Run("i_ivadjus01", "INV", True)
            End If

            If LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, 0) = "SAL" Then
                xParam.WhereToExecute = "doc_serial = " & ivtranrm.Rows(LibXGrid1.CurrentRowIndex)!doc_serial.ToString
                LibX.LibXRunner.Run("i_ivsalid01", "INV", True)
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        btnView_Click(sender, e)
    End Sub

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        btnCerrar_Click(sender, e)
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_entradas.CheckedChanged
        ApplyFilter()
    End Sub

    Private Sub chk_CompLocal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_salida.CheckedChanged
        ApplyFilter()
    End Sub

    Private Sub chk_ajuste_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_ajuste.CheckedChanged
        ApplyFilter()
    End Sub

    Private Sub chk_devfacturas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_devfacturas.CheckedChanged
        ApplyFilter()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        LibXConnector1.AcceptFind() '// ejecutar find

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        LibXConnector1.Cancel()
        LibXConnector1.Find()
    End Sub

    Private Sub LibXConnector1_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.XBeforeExecuteQueryEventArgs) Handles LibXConnector1.BeforeExecuteQuery
        e.AditionalWhere = "ivtranrm.doc_date between '" & CDate(xdt_FechaInicial.Value).ToString("yyyy/MM/dd") & "' and '" & CDate(xdt_FechaFinal.Value).ToString("yyyy/MM/dd") & "'"
    End Sub
End Class
