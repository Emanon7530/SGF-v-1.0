Imports LibX
Public Class i_cjdesglosm01
    Inherits System.Windows.Forms.Form
    Dim oDoc As SGT.Inventario.Entidades.Documento
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
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents lkMoneda As LibX.LibXLookup
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LibXGridDetalle As LibX.LibXGrid
    Friend WithEvents XdataGridTableStyle1 As LibX.XdataGridTableStyle
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    'Friend WithEvents btnProduct As System.Windows.Forms.Button
    'Friend WithEvents btnCostos As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents xcbo_doc_status As LibX.LibXCombo
    'Friend WithEvents ButtonVencimientos As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents LibXShortNavigator1 As LibX.LibXShortNavigator
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents LibXDbSourceTable2 As LibX.LibXDbSourceTable
    Friend WithEvents Txt_init_serial As LibX.XTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents caja As System.Windows.Forms.Label
    Friend WithEvents Txt_caja_code As LibX.XTextBox
    Friend WithEvents LibXLookup1 As LibX.LibXLookup
    Friend WithEvents LibxDateTimePicker1 As LibX.LibxDateTimePicker
    Friend WithEvents cjdesglosd As System.Data.DataTable
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents gColmoneda_tipo As LibX.XEditTextBoxColumn
    Friend WithEvents gColCantidad As LibX.XEditTextBoxColumn
    Friend WithEvents gColImporte As LibX.XEditTextBoxColumn
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents DataColumn17 As System.Data.DataColumn
    Friend WithEvents DataColumn18 As System.Data.DataColumn
    Friend WithEvents cjinitm As System.Data.DataTable
    Friend WithEvents XTextBox1 As LibX.XTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents xlk_vend_code As LibX.LibXLookup
    Friend WithEvents lblvend_name As System.Windows.Forms.Label
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents XTextBox3 As LibX.XTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents xtxCheque As LibX.XTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents XTextBox2 As LibX.XTextBox
    Friend WithEvents DataColumn19 As System.Data.DataColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.DataSet1 = New System.Data.DataSet
        Me.cjdesglosd = New System.Data.DataTable
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn7 = New System.Data.DataColumn
        Me.DataColumn8 = New System.Data.DataColumn
        Me.DataColumn9 = New System.Data.DataColumn
        Me.DataColumn10 = New System.Data.DataColumn
        Me.DataColumn11 = New System.Data.DataColumn
        Me.DataColumn12 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn19 = New System.Data.DataColumn
        Me.cjinitm = New System.Data.DataTable
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn13 = New System.Data.DataColumn
        Me.DataColumn14 = New System.Data.DataColumn
        Me.DataColumn15 = New System.Data.DataColumn
        Me.DataColumn16 = New System.Data.DataColumn
        Me.DataColumn17 = New System.Data.DataColumn
        Me.DataColumn18 = New System.Data.DataColumn
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.lkMoneda = New LibX.LibXLookup
        Me.Label8 = New System.Windows.Forms.Label
        Me.LibXGridDetalle = New LibX.LibXGrid
        Me.XdataGridTableStyle1 = New LibX.XdataGridTableStyle
        Me.gColmoneda_tipo = New LibX.XEditTextBoxColumn
        Me.gColCantidad = New LibX.XEditTextBoxColumn
        Me.gColImporte = New LibX.XEditTextBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.XTextBox2 = New LibX.XTextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.XTextBox3 = New LibX.XTextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.xtxCheque = New LibX.XTextBox
        Me.xlk_vend_code = New LibX.LibXLookup
        Me.XTextBox1 = New LibX.XTextBox
        Me.lblvend_name = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.LibxDateTimePicker1 = New LibX.LibxDateTimePicker
        Me.LibXLookup1 = New LibX.LibXLookup
        Me.Txt_caja_code = New LibX.XTextBox
        Me.caja = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Txt_init_serial = New LibX.XTextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.LibXShortNavigator1 = New LibX.LibXShortNavigator
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cjdesglosd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cjinitm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXGridDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LibXConnector1
        '
        Me.LibXConnector1.AllowDelete = True
        Me.LibXConnector1.AllowEdit = True
        Me.LibXConnector1.AllowNew = False
        Me.LibXConnector1.AllowPrint = True
        Me.LibXConnector1.AllowQuery = True
        Me.LibXConnector1.BOF = False
        Me.LibXConnector1.CanExecuteFind = True
        Me.LibXConnector1.DataMember = "cjinitm"
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
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.cjdesglosd, Me.cjinitm})
        '
        'cjdesglosd
        '
        Me.cjdesglosd.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn3, Me.DataColumn4, Me.DataColumn19})
        Me.cjdesglosd.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"init_serial", "line_no"}, True)})
        Me.cjdesglosd.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn12, Me.DataColumn6}
        Me.cjdesglosd.TableName = "cjdesglosd"
        '
        'DataColumn6
        '
        Me.DataColumn6.AllowDBNull = False
        Me.DataColumn6.ColumnName = "line_no"
        Me.DataColumn6.DataType = GetType(System.Int32)
        '
        'DataColumn7
        '
        Me.DataColumn7.AllowDBNull = False
        Me.DataColumn7.ColumnName = "moneda_serial"
        Me.DataColumn7.DataType = GetType(System.Int32)
        '
        'DataColumn8
        '
        Me.DataColumn8.AllowDBNull = False
        Me.DataColumn8.ColumnName = "moneda_tipo"
        Me.DataColumn8.MaxLength = 20
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "moneda_valor"
        Me.DataColumn9.DataType = GetType(System.Decimal)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "cantidad"
        Me.DataColumn10.DataType = GetType(System.Int32)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "Importe"
        Me.DataColumn11.DataType = GetType(System.Decimal)
        '
        'DataColumn12
        '
        Me.DataColumn12.AllowDBNull = False
        Me.DataColumn12.ColumnName = "init_serial"
        Me.DataColumn12.DataType = GetType(System.Int32)
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "cheque"
        Me.DataColumn3.DataType = GetType(System.Decimal)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "tarjeta"
        Me.DataColumn4.DataType = GetType(System.Decimal)
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "credito"
        Me.DataColumn19.DataType = GetType(System.Decimal)
        '
        'cjinitm
        '
        Me.cjinitm.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn5, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn1, Me.DataColumn2})
        Me.cjinitm.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"init_serial"}, True)})
        Me.cjinitm.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn5}
        Me.cjinitm.TableName = "cjinitm"
        '
        'DataColumn5
        '
        Me.DataColumn5.AllowDBNull = False
        Me.DataColumn5.AutoIncrement = True
        Me.DataColumn5.ColumnName = "init_serial"
        Me.DataColumn5.DataType = GetType(System.Int32)
        Me.DataColumn5.ReadOnly = True
        '
        'DataColumn13
        '
        Me.DataColumn13.AllowDBNull = False
        Me.DataColumn13.ColumnName = "vend_code"
        Me.DataColumn13.DataType = GetType(System.Int32)
        '
        'DataColumn14
        '
        Me.DataColumn14.AllowDBNull = False
        Me.DataColumn14.ColumnName = "caja_code"
        Me.DataColumn14.DataType = GetType(System.Int32)
        '
        'DataColumn15
        '
        Me.DataColumn15.AllowDBNull = False
        Me.DataColumn15.ColumnName = "init_date"
        Me.DataColumn15.DataType = GetType(System.DateTime)
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "cash_amount"
        Me.DataColumn16.DataType = GetType(System.Decimal)
        '
        'DataColumn17
        '
        Me.DataColumn17.AllowDBNull = False
        Me.DataColumn17.ColumnName = "init_status"
        Me.DataColumn17.DataType = GetType(System.Int32)
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "close_date"
        Me.DataColumn18.DataType = GetType(System.DateTime)
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "no_cierre"
        Me.DataColumn1.DataType = GetType(System.Int32)
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "ncf"
        Me.DataColumn2.MaxLength = 19
        '
        'LibXDbSourceTable1
        '
        Me.LibXDbSourceTable1.AllowDelete = True
        Me.LibXDbSourceTable1.AllowEdit = True
        Me.LibXDbSourceTable1.AllowNew = True
        Me.LibXDbSourceTable1.AutoIncrementSerial = False
        Me.LibXDbSourceTable1.CustomDbUpdate = True
        Me.LibXDbSourceTable1.DeleteOrder = 0
        Me.LibXDbSourceTable1.FillOnQuery = True
        Me.LibXDbSourceTable1.FillOnRowChange = False
        Me.LibXDbSourceTable1.HeaderIsOnGrid = False
        Me.LibXDbSourceTable1.InnerJon = True
        Me.LibXDbSourceTable1.InsertOrder = 0
        Me.LibXDbSourceTable1.IsDetail = False
        Me.LibXDbSourceTable1.KeyFields = Nothing
        Me.LibXDbSourceTable1.LineColName = ""
        Me.LibXDbSourceTable1.MasterDetailRelation = Nothing
        Me.LibXDbSourceTable1.MasterTableName = Nothing
        Me.LibXDbSourceTable1.SerialColumnName = "init_serial"
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = Nothing
        Me.LibXDbSourceTable1.TableName = "cjinitm"
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
        Me.LibXDbSourceTable2.MasterDetailRelation = New String() {"init_serial=init_serial"}
        Me.LibXDbSourceTable2.MasterTableName = Nothing
        Me.LibXDbSourceTable2.SerialColumnName = Nothing
        Me.LibXDbSourceTable2.Sort = Nothing
        Me.LibXDbSourceTable2.Source = New String() {"select cjdesglosd.*, cjmoneda.moneda_tipo", "from cjdesglosd inner join cjmoneda", "on cjmoneda.moneda_serial = cjdesglosd.moneda_serial"}
        Me.LibXDbSourceTable2.TableName = "cjdesglosd"
        Me.LibXDbSourceTable2.UpdateOrder = 0
        Me.LibXDbSourceTable2.UseRowRetrieve = False
        '
        'lkMoneda
        '
        Me.lkMoneda.AlternateFieldSearch = Nothing
        Me.lkMoneda.BeginCheck = False
        Me.lkMoneda.CheckText = Nothing
        Me.lkMoneda.ComboMode = False
        Me.lkMoneda.DataMember = "cjdesglosd"
        Me.lkMoneda.DataSource = Me.LibXConnector1
        Me.lkMoneda.DestParameters = New String() {"moneda_serial=moneda_serial", "moneda_tipo=moneda_tipo", "moneda_valor=moneda_valor"}
        Me.lkMoneda.FilterField = "moneda_tipo"
        Me.lkMoneda.IgnoreFindInBrowseMode = True
        Me.lkMoneda.isCanceled = False
        Me.lkMoneda.Location = New System.Drawing.Point(608, 80)
        Me.lkMoneda.LookCaption = Nothing
        Me.lkMoneda.Name = "lkMoneda"
        Me.lkMoneda.PopupSize = New System.Drawing.Size(0, 0)
        Me.lkMoneda.ShowFilter = True
        Me.lkMoneda.ShowMessageNotFound = True
        Me.lkMoneda.ShowWarning = False
        Me.lkMoneda.Size = New System.Drawing.Size(16, 20)
        Me.lkMoneda.SizesColumns = New String() {"moneda_tipo=300"}
        Me.lkMoneda.SizesColumnsTab = Nothing
        Me.lkMoneda.SqlString = New String() {"select * from cjmoneda", "order by moneda_serial"}
        Me.lkMoneda.SQLTab = Nothing
        Me.lkMoneda.SrcParameters = New String() {"moneda_serial=moneda_serial"}
        Me.lkMoneda.TabIndex = 6
        Me.lkMoneda.TableName = "cjmoneda"
        Me.lkMoneda.TabStop = False
        Me.lkMoneda.UseCopyConnection = False
        Me.lkMoneda.UseRowRetrieveEvents = False
        Me.lkMoneda.UseTab = False
        Me.lkMoneda.VisParameters = New String() {"Codigo=moneda_serial", "Moneda=moneda_tipo", "Valor=moneda_valor"}
        Me.lkMoneda.WhereCondition = Nothing
        Me.lkMoneda.WhereParameters = Nothing
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.Location = New System.Drawing.Point(248, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 16)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Fecha Inicio:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LibXGridDetalle
        '
        Me.LibXGridDetalle.AllowSorting = False
        Me.LibXGridDetalle.AutoAdjustLastColumn = True
        Me.LibXGridDetalle.AutoSearch = False
        Me.LibXGridDetalle.BackgroundColor = System.Drawing.Color.White
        Me.LibXGridDetalle.CaptionText = "Monedas"
        Me.LibXGridDetalle.DataMember = "cjdesglosd"
        Me.LibXGridDetalle.DataSource = Me.DataSet1
        Me.LibXGridDetalle.FullRowSelect = False
        Me.LibXGridDetalle.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGridDetalle.IsReadOnly = False
        Me.LibXGridDetalle.Location = New System.Drawing.Point(8, 160)
        Me.LibXGridDetalle.Name = "LibXGridDetalle"
        Me.LibXGridDetalle.ReadOnly = True
        Me.LibXGridDetalle.RowHeaderWidth = 15
        Me.LibXGridDetalle.searchText = ""
        Me.LibXGridDetalle.showFooterBar = True
        Me.LibXGridDetalle.Size = New System.Drawing.Size(432, 296)
        Me.LibXGridDetalle.TabIndex = 2
        Me.LibXGridDetalle.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.XdataGridTableStyle1})
        Me.LibXGridDetalle.UseAutoFillLines = True
        Me.LibXGridDetalle.UseHandCursor = False
        '
        'XdataGridTableStyle1
        '
        Me.XdataGridTableStyle1.AllowSorting = False
        Me.XdataGridTableStyle1.AlternatingBackColor = System.Drawing.SystemColors.Info
        Me.XdataGridTableStyle1.DataGrid = Me.LibXGridDetalle
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.gColmoneda_tipo, Me.gColCantidad, Me.gColImporte})
        Me.XdataGridTableStyle1.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XdataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle1.MappingName = "cjdesglosd"
        Me.XdataGridTableStyle1.RowHeaderWidth = 15
        '
        'gColmoneda_tipo
        '
        Me.gColmoneda_tipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColmoneda_tipo.Format = ""
        Me.gColmoneda_tipo.FormatInfo = Nothing
        Me.gColmoneda_tipo.HeaderText = "Moneda"
        Me.gColmoneda_tipo.ImageList = Nothing
        Me.gColmoneda_tipo.isReadOnly = True
        Me.gColmoneda_tipo.MappingName = "moneda_tipo"
        Me.gColmoneda_tipo.MaxLength = 32767
        Me.gColmoneda_tipo.ReadOnly = True
        Me.gColmoneda_tipo.TabStop = True
        Me.gColmoneda_tipo.UseCustomCellFormat = False
        Me.gColmoneda_tipo.Width = 200
        '
        'gColCantidad
        '
        Me.gColCantidad.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.gColCantidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColCantidad.Format = "##,###"
        Me.gColCantidad.FormatInfo = Nothing
        Me.gColCantidad.HeaderText = "Cantidad"
        Me.gColCantidad.ImageList = Nothing
        Me.gColCantidad.isReadOnly = False
        Me.gColCantidad.MappingName = "cantidad"
        Me.gColCantidad.MaxLength = 32767
        Me.gColCantidad.TabStop = True
        Me.gColCantidad.UseCustomCellFormat = False
        Me.gColCantidad.Width = 95
        '
        'gColImporte
        '
        Me.gColImporte.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.gColImporte.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColImporte.Format = "##,###.##"
        Me.gColImporte.FormatInfo = Nothing
        Me.gColImporte.HeaderText = "Total"
        Me.gColImporte.ImageList = Nothing
        Me.gColImporte.isReadOnly = True
        Me.gColImporte.MappingName = "Importe"
        Me.gColImporte.MaxLength = 32767
        Me.gColImporte.ReadOnly = True
        Me.gColImporte.TabStop = False
        Me.gColImporte.UseCustomCellFormat = False
        Me.gColImporte.Width = 95
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(39, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 16)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Caja:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.XTextBox2)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.XTextBox3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.xtxCheque)
        Me.GroupBox1.Controls.Add(Me.xlk_vend_code)
        Me.GroupBox1.Controls.Add(Me.XTextBox1)
        Me.GroupBox1.Controls.Add(Me.lblvend_name)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.LibxDateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.LibXLookup1)
        Me.GroupBox1.Controls.Add(Me.Txt_caja_code)
        Me.GroupBox1.Controls.Add(Me.caja)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Txt_init_serial)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(432, 136)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.Location = New System.Drawing.Point(327, 89)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 16)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "Credito:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XTextBox2
        '
        Me.XTextBox2.AcceptsReturn = True
        Me.XTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cjdesglosd.credito"))
        Me.XTextBox2.EditInitialValue = Nothing
        Me.XTextBox2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.FieldDescription = ""
        Me.XTextBox2.FindInitialValue = Nothing
        Me.XTextBox2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.IgnoreRequiered = False
        Me.XTextBox2.Location = New System.Drawing.Point(301, 112)
        Me.XTextBox2.Name = "XTextBox2"
        Me.XTextBox2.NewInitialValue = Nothing
        Me.XTextBox2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.Requiered = False
        Me.XTextBox2.Size = New System.Drawing.Size(120, 20)
        Me.XTextBox2.StatusBarPanelDescripcion = Nothing
        Me.XTextBox2.TabIndex = 47
        Me.XTextBox2.Text = ""
        Me.XTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Location = New System.Drawing.Point(211, 90)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 16)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "Tarjeta:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XTextBox3
        '
        Me.XTextBox3.AcceptsReturn = True
        Me.XTextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cjdesglosd.tarjeta"))
        Me.XTextBox3.EditInitialValue = Nothing
        Me.XTextBox3.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox3.FieldDescription = ""
        Me.XTextBox3.FindInitialValue = Nothing
        Me.XTextBox3.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox3.IgnoreRequiered = False
        Me.XTextBox3.Location = New System.Drawing.Point(177, 112)
        Me.XTextBox3.Name = "XTextBox3"
        Me.XTextBox3.NewInitialValue = Nothing
        Me.XTextBox3.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox3.Requiered = False
        Me.XTextBox3.Size = New System.Drawing.Size(120, 20)
        Me.XTextBox3.StatusBarPanelDescripcion = Nothing
        Me.XTextBox3.TabIndex = 45
        Me.XTextBox3.Text = ""
        Me.XTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(95, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 16)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Cheque:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxCheque
        '
        Me.xtxCheque.AcceptsReturn = True
        Me.xtxCheque.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cjdesglosd.cheque"))
        Me.xtxCheque.EditInitialValue = Nothing
        Me.xtxCheque.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxCheque.FieldDescription = ""
        Me.xtxCheque.FindInitialValue = Nothing
        Me.xtxCheque.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxCheque.IgnoreRequiered = False
        Me.xtxCheque.Location = New System.Drawing.Point(61, 112)
        Me.xtxCheque.Name = "xtxCheque"
        Me.xtxCheque.NewInitialValue = Nothing
        Me.xtxCheque.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxCheque.Requiered = False
        Me.xtxCheque.Size = New System.Drawing.Size(112, 20)
        Me.xtxCheque.StatusBarPanelDescripcion = Nothing
        Me.xtxCheque.TabIndex = 43
        Me.xtxCheque.Text = ""
        Me.xtxCheque.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'xlk_vend_code
        '
        Me.xlk_vend_code.AlternateFieldSearch = Nothing
        Me.xlk_vend_code.BeginCheck = False
        Me.xlk_vend_code.CheckText = Nothing
        Me.xlk_vend_code.ComboMode = False
        Me.xlk_vend_code.DataMember = Nothing
        Me.xlk_vend_code.DataSource = Me.LibXConnector1
        Me.xlk_vend_code.DestParameters = New String() {"vend_code=vend_code", "lblvend_name=vend_name"}
        Me.xlk_vend_code.FilterField = "vend_name"
        Me.xlk_vend_code.IgnoreFindInBrowseMode = False
        Me.xlk_vend_code.isCanceled = False
        Me.xlk_vend_code.Location = New System.Drawing.Point(408, 64)
        Me.xlk_vend_code.LookCaption = ""
        Me.xlk_vend_code.Name = "xlk_vend_code"
        Me.xlk_vend_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_vend_code.ShowFilter = True
        Me.xlk_vend_code.ShowMessageNotFound = True
        Me.xlk_vend_code.ShowWarning = False
        Me.xlk_vend_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_vend_code.SizesColumns = Nothing
        Me.xlk_vend_code.SizesColumnsTab = Nothing
        Me.xlk_vend_code.SqlString = Nothing
        Me.xlk_vend_code.SQLTab = Nothing
        Me.xlk_vend_code.SrcParameters = New String() {"vend_code=vend_code"}
        Me.xlk_vend_code.TabIndex = 37
        Me.xlk_vend_code.TableName = "ftvendm"
        Me.xlk_vend_code.TabStop = False
        Me.xlk_vend_code.UseCopyConnection = False
        Me.xlk_vend_code.UseRowRetrieveEvents = False
        Me.xlk_vend_code.UseTab = False
        Me.xlk_vend_code.VisParameters = New String() {"Codigo=vend_code", "Nomnre=vend_name"}
        Me.xlk_vend_code.WhereCondition = Nothing
        Me.xlk_vend_code.WhereParameters = Nothing
        '
        'XTextBox1
        '
        Me.XTextBox1.AcceptsReturn = True
        Me.XTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cjinitm.vend_code"))
        Me.XTextBox1.EditInitialValue = Nothing
        Me.XTextBox1.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.XTextBox1.FieldDescription = ""
        Me.XTextBox1.FindInitialValue = Nothing
        Me.XTextBox1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.IgnoreRequiered = False
        Me.XTextBox1.Location = New System.Drawing.Point(88, 64)
        Me.XTextBox1.Name = "XTextBox1"
        Me.XTextBox1.NewInitialValue = Nothing
        Me.XTextBox1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.Requiered = False
        Me.XTextBox1.Size = New System.Drawing.Size(48, 20)
        Me.XTextBox1.StatusBarPanelDescripcion = Nothing
        Me.XTextBox1.TabIndex = 36
        Me.XTextBox1.Text = ""
        '
        'lblvend_name
        '
        Me.lblvend_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblvend_name.Location = New System.Drawing.Point(144, 64)
        Me.lblvend_name.Name = "lblvend_name"
        Me.lblvend_name.Size = New System.Drawing.Size(264, 20)
        Me.lblvend_name.TabIndex = 35
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(29, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 16)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Cajera:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LibxDateTimePicker1
        '
        Me.LibxDateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.LibxDateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "cjinitm.init_date"))
        Me.LibxDateTimePicker1.EditInitialValue = Nothing
        Me.LibxDateTimePicker1.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.LibxDateTimePicker1.Enabled = False
        Me.LibxDateTimePicker1.FieldDescription = ""
        Me.LibxDateTimePicker1.FindInitialValue = Nothing
        Me.LibxDateTimePicker1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.LibxDateTimePicker1.IgnoreRequiered = False
        Me.LibxDateTimePicker1.Location = New System.Drawing.Point(328, 16)
        Me.LibxDateTimePicker1.Name = "LibxDateTimePicker1"
        Me.LibxDateTimePicker1.NewInitialValue = Nothing
        Me.LibxDateTimePicker1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxDateTimePicker1.Requiered = False
        Me.LibxDateTimePicker1.Size = New System.Drawing.Size(96, 20)
        Me.LibxDateTimePicker1.StatusBarPanelDescripcion = Nothing
        Me.LibxDateTimePicker1.TabIndex = 33
        '
        'LibXLookup1
        '
        Me.LibXLookup1.AlternateFieldSearch = Nothing
        Me.LibXLookup1.BeginCheck = False
        Me.LibXLookup1.CheckText = Nothing
        Me.LibXLookup1.ComboMode = False
        Me.LibXLookup1.DataMember = Nothing
        Me.LibXLookup1.DataSource = Me.LibXConnector1
        Me.LibXLookup1.DestParameters = New String() {"caja_code=caja_code", "caja=caja_name"}
        Me.LibXLookup1.FilterField = "caja_name"
        Me.LibXLookup1.IgnoreFindInBrowseMode = False
        Me.LibXLookup1.isCanceled = False
        Me.LibXLookup1.Location = New System.Drawing.Point(408, 40)
        Me.LibXLookup1.LookCaption = ""
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
        Me.LibXLookup1.SrcParameters = New String() {"caja_code=caja_code"}
        Me.LibXLookup1.TabIndex = 32
        Me.LibXLookup1.TableName = "cjcajam"
        Me.LibXLookup1.TabStop = False
        Me.LibXLookup1.UseCopyConnection = False
        Me.LibXLookup1.UseRowRetrieveEvents = False
        Me.LibXLookup1.UseTab = False
        Me.LibXLookup1.VisParameters = New String() {"Codigo=caja_code", "Nomnre=caja_name"}
        Me.LibXLookup1.WhereCondition = Nothing
        Me.LibXLookup1.WhereParameters = Nothing
        '
        'Txt_caja_code
        '
        Me.Txt_caja_code.AcceptsReturn = True
        Me.Txt_caja_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cjinitm.caja_code"))
        Me.Txt_caja_code.EditInitialValue = Nothing
        Me.Txt_caja_code.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.Txt_caja_code.FieldDescription = ""
        Me.Txt_caja_code.FindInitialValue = Nothing
        Me.Txt_caja_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Txt_caja_code.IgnoreRequiered = False
        Me.Txt_caja_code.Location = New System.Drawing.Point(88, 40)
        Me.Txt_caja_code.Name = "Txt_caja_code"
        Me.Txt_caja_code.NewInitialValue = Nothing
        Me.Txt_caja_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Txt_caja_code.Requiered = False
        Me.Txt_caja_code.Size = New System.Drawing.Size(48, 20)
        Me.Txt_caja_code.StatusBarPanelDescripcion = Nothing
        Me.Txt_caja_code.TabIndex = 31
        Me.Txt_caja_code.Text = ""
        '
        'caja
        '
        Me.caja.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.caja.Location = New System.Drawing.Point(144, 40)
        Me.caja.Name = "caja"
        Me.caja.Size = New System.Drawing.Size(264, 20)
        Me.caja.TabIndex = 30
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(32, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 16)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Cierre:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Txt_init_serial
        '
        Me.Txt_init_serial.AcceptsReturn = True
        Me.Txt_init_serial.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cjinitm.init_serial"))
        Me.Txt_init_serial.EditInitialValue = Nothing
        Me.Txt_init_serial.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.Txt_init_serial.FieldDescription = ""
        Me.Txt_init_serial.FindInitialValue = Nothing
        Me.Txt_init_serial.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Txt_init_serial.IgnoreRequiered = False
        Me.Txt_init_serial.Location = New System.Drawing.Point(88, 16)
        Me.Txt_init_serial.Name = "Txt_init_serial"
        Me.Txt_init_serial.NewInitialValue = Nothing
        Me.Txt_init_serial.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Txt_init_serial.Requiered = False
        Me.Txt_init_serial.Size = New System.Drawing.Size(48, 20)
        Me.Txt_init_serial.StatusBarPanelDescripcion = Nothing
        Me.Txt_init_serial.TabIndex = 27
        Me.Txt_init_serial.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.TabIndex = 39
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.TabIndex = 38
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(0, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.TabIndex = 37
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(0, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.TabIndex = 36
        '
        'LibXShortNavigator1
        '
        Me.LibXShortNavigator1.BuildMenu = True
        Me.LibXShortNavigator1.Connector = Me.LibXConnector1
        Me.LibXShortNavigator1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LibXShortNavigator1.FirstControlInEditMode = Nothing
        Me.LibXShortNavigator1.FirstControlInFindMode = Nothing
        Me.LibXShortNavigator1.FirstControlInNewMode = Nothing
        Me.LibXShortNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.LibXShortNavigator1.Name = "LibXShortNavigator1"
        Me.LibXShortNavigator1.Size = New System.Drawing.Size(450, 24)
        Me.LibXShortNavigator1.TabIndex = 35
        '
        'i_cjdesglosm01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(450, 504)
        Me.Controls.Add(Me.LibXShortNavigator1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LibXGridDetalle)
        Me.Controls.Add(Me.lkMoneda)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "i_cjdesglosm01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Desglose de Monedas"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cjdesglosd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cjinitm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXGridDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    'Private Sub FillItem()
    '    'Dim oRow As DataRow
    '    Try
    '        If Not LibXConnector1.Parameters Is Nothing Then
    '            If Not LibXConnector1.Parameters.Value Is Nothing Then
    '                If CType(LibXConnector1.Parameters.Value, String).Trim.Length > 0 Then
    '                    Txt_init_serial.Text = LibXConnector1.Parameters.Value
    '                    'lk_item_code.ExecuteFind()
    '                End If
    '            End If
    '            If LibXConnector1.Parameters.Datos.Count > 0 Then
    '                If LibXConnector1.Parameters.Datos.Contains("caja_code") Then
    '                    Txt_caja_code.Text = LibXConnector1.Parameters.Datos.Item("caja_code")
    '                End If
    '            End If
    '            If LibXConnector1.Parameters.Datos.Count > 0 Then
    '                If LibXConnector1.Parameters.Datos.Contains("init_date") Then
    '                    LibxDateTimePicker1.Text = LibXConnector1.Parameters.Datos.Item("init_date")
    '                End If
    '            End If
    '        End If

    '    Catch ex As Exception
    '        LibX.Log.Show(ex)
    '    End Try
    'End Sub

    Private Sub LoadMonedas()
        Dim SelectStmt As String
        Dim oTable As DataTable

        SelectStmt = "select * from cjmoneda order by moneda_valor desc"

        oTable = LibX.Data.Manager.GetDataTable(SelectStmt)

        '//
        '// cjdesglosd.Rows.Clear()
        For Each oRow As DataRow In oTable.Rows
            If cjdesglosd.Select("moneda_serial = " & oRow!moneda_serial.ToString.Trim).Length <= 0 Then
                Dim oRow1 As DataRow = cjdesglosd.NewRow

                oRow1.BeginEdit()
                oRow1!moneda_serial = oRow!moneda_serial
                oRow1!moneda_tipo = oRow!moneda_tipo
                oRow1!moneda_valor = oRow!moneda_valor
                oRow1.EndEdit()

                cjdesglosd.Rows.Add(oRow1)
            End If
        Next

    End Sub

    Private Sub i_ivadjus01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.DataSet1.Tables("cjdesglosd").Columns("importe").Expression = "isnull(cantidad,0)*isnull(moneda_valor,0)"
            Me.LibXGridDetalle.footerOperations.add("importe", "sum(importe)")
            Me.LibXGridDetalle.footerOperations.add("moneda_serial", "count(moneda_serial)")

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_SettingDefaulteditValues(ByVal sender As Object, ByVal e As LibX.SettingDefaultEditValues) Handles LibXConnector1.SettingDefaulteditValues
        Try
            LoadMonedas()
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub

    Private Sub LibXConnector1_InsertingDetailRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatingEventArgs) Handles LibXConnector1.InsertingDetailRow
        Try

            '// si se esta insertando o actualizando y el registro
            '// que se va a actualizar no tiene cantidad especificada
            '// no insertarlo

            If e.UpdatingArgs.StatementType = StatementType.Insert _
            Or e.UpdatingArgs.StatementType = StatementType.Update Then
                If LibX.IsNull(e.UpdatingArgs.Row!cantidad) _
                Or Val(e.UpdatingArgs.Row!cantidad.ToString.Trim) <= 0 Then
                    e.UpdatingArgs.Status = UpdateStatus.SkipCurrentRow
                End If
            End If

        Catch ex As Exception
            e.UpdatingArgs.Status = UpdateStatus.ErrorsOccurred
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub LibXGridDetalle_CellValidate(ByVal sender As Object, ByVal e As LibX.LibXGrid.LibXGridCellValidateEventArgs) Handles LibXGridDetalle.CellValidate
        Try
            If LibXConnector1.IsDataEditing = True Then
                '// si es la cantidad no aceptar valores invalidos
                If gColCantidad.Column = e.cell Then
                    If Val(e.value.ToString.Trim) < 0 Then
                        Throw New ApplicationException("Debe especificar una cantidad valida, mayor que 0")
                    End If
                End If
            End If

        Catch ex As Exception
            e.hasErrors = True
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXGridDetalle_CurrentRowChanged(ByVal sender As Object, ByVal e As LibX.LibXGrid.XDataGridCurrentRowChangedEventArgs) Handles LibXGridDetalle.CurrentRowChanged
        Try
            If LibXConnector1.IsDataEditing = True Then
                Me.LibXGridDetalle.refreshFooter()
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

End Class
