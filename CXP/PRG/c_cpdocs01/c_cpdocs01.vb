Public Class c_cpdocs01
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
    Friend WithEvents XEditTextBoxColumn1 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn3 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn5 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn6 As LibX.XEditTextBoxColumn
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
    Friend WithEvents XEditTextBoxColumn4 As LibX.XEditTextBoxColumn
    Friend WithEvents XDataGridLinkColumn1 As LibX.XDataGridLinkColumn
    Friend WithEvents XEditTextBoxColumn2 As LibX.XEditTextBoxColumn
    Friend WithEvents chk_bal As System.Windows.Forms.CheckBox
    Friend WithEvents DataGridBoolColumn1 As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents btnpagos As System.Windows.Forms.Button
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents cpinvcem As System.Data.DataTable
    Friend WithEvents gColserial_no As LibX.XEditTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(c_cpdocs01))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnView = New System.Windows.Forms.Button
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.DataSet1 = New System.Data.DataSet
        Me.cpinvcem = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn7 = New System.Data.DataColumn
        Me.DataColumn8 = New System.Data.DataColumn
        Me.DataColumn9 = New System.Data.DataColumn
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.LibXGrid1 = New LibX.LibXGrid
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.DataView1 = New System.Data.DataView
        Me.XdataGridTableStyle1 = New LibX.XdataGridTableStyle
        Me.gColserial_no = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn1 = New LibX.XEditTextBoxColumn
        Me.DataGridBoolColumn1 = New System.Windows.Forms.DataGridBoolColumn
        Me.XDataGridLinkColumn1 = New LibX.XDataGridLinkColumn
        Me.XEditTextBoxColumn2 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn3 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn5 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn6 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn4 = New LibX.XEditTextBoxColumn
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.chk_bal = New System.Windows.Forms.CheckBox
        Me.chk_facturas = New System.Windows.Forms.CheckBox
        Me.lblFactura = New System.Windows.Forms.Label
        Me.chk_devoluc = New System.Windows.Forms.CheckBox
        Me.lblDevoluciones = New System.Windows.Forms.Label
        Me.btnpagos = New System.Windows.Forms.Button
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cpinvcem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(0, 341)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(712, 8)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'btnView
        '
        Me.btnView.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnView.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnView.Location = New System.Drawing.Point(8, 357)
        Me.btnView.Name = "btnView"
        Me.btnView.TabIndex = 2
        Me.btnView.Text = "Visualizar"
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCerrar.Location = New System.Drawing.Point(632, 352)
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
        Me.LibXConnector1.DataMember = "cpinvcem"
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
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.LibXDbSourceTable1})
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
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.cpinvcem})
        '
        'cpinvcem
        '
        Me.cpinvcem.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9})
        Me.cpinvcem.TableName = "cpinvcem"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.AutoIncrement = True
        Me.DataColumn1.ColumnName = "invce_serial"
        Me.DataColumn1.DataType = GetType(System.Int32)
        Me.DataColumn1.ReadOnly = True
        '
        'DataColumn2
        '
        Me.DataColumn2.AllowDBNull = False
        Me.DataColumn2.ColumnName = "type_code"
        Me.DataColumn2.MaxLength = 3
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "invce_status"
        Me.DataColumn3.MaxLength = 9
        Me.DataColumn3.ReadOnly = True
        '
        'DataColumn4
        '
        Me.DataColumn4.AllowDBNull = False
        Me.DataColumn4.ColumnName = "suc_code"
        Me.DataColumn4.DataType = GetType(System.Int32)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "doc_no"
        Me.DataColumn5.MaxLength = 20
        '
        'DataColumn6
        '
        Me.DataColumn6.AllowDBNull = False
        Me.DataColumn6.ColumnName = "doc_date"
        Me.DataColumn6.DataType = GetType(System.DateTime)
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "due_date"
        Me.DataColumn7.DataType = GetType(System.DateTime)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "amount"
        Me.DataColumn8.DataType = GetType(System.Decimal)
        Me.DataColumn8.ReadOnly = True
        '
        'DataColumn9
        '
        Me.DataColumn9.AllowDBNull = False
        Me.DataColumn9.ColumnName = "balance"
        Me.DataColumn9.DataType = GetType(System.Decimal)
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
        Me.LibXDbSourceTable1.Source = New String() {"select cpinvcem.invce_serial,cpinvcem.type_code,case when invce_status = 1 then '" & _
        "Aplicado'", "                               when invce_status = 2 then 'Pendiente'", "                               when invce_status = 3 then 'Saldado'", "                               when invce_status = 0 then 'Anulado' end invce_sta" & _
        "tus,", "cpinvcem.suc_code,cpinvcem.doc_no,cpinvcem.doc_date,", "cpopend.due_date,abs(cpopend.amount) amount,cpopend.balance", "from cpinvcem inner join cpopend", "on cpinvcem.invce_serial = cpopend.invce_serial", "order by cpopend.balance desc,cpinvcem.doc_date"}
        Me.LibXDbSourceTable1.TableName = "cpinvcem"
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
        Me.LibXGrid1.FullRowSelect = True
        Me.LibXGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGrid1.IsReadOnly = False
        Me.LibXGrid1.Location = New System.Drawing.Point(8, 8)
        Me.LibXGrid1.Name = "LibXGrid1"
        Me.LibXGrid1.ReadOnly = True
        Me.LibXGrid1.searchText = ""
        Me.LibXGrid1.showFooterBar = True
        Me.LibXGrid1.Size = New System.Drawing.Size(680, 304)
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
        Me.DataView1.Table = Me.cpinvcem
        '
        'XdataGridTableStyle1
        '
        Me.XdataGridTableStyle1.AlternatingBackColor = System.Drawing.SystemColors.Info
        Me.XdataGridTableStyle1.DataGrid = Me.LibXGrid1
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.gColserial_no, Me.XEditTextBoxColumn1, Me.DataGridBoolColumn1, Me.XDataGridLinkColumn1, Me.XEditTextBoxColumn2, Me.XEditTextBoxColumn3, Me.XEditTextBoxColumn5, Me.XEditTextBoxColumn6, Me.XEditTextBoxColumn4})
        Me.XdataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle1.MappingName = "cpinvcem"
        '
        'gColserial_no
        '
        Me.gColserial_no.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColserial_no.Format = ""
        Me.gColserial_no.FormatInfo = Nothing
        Me.gColserial_no.ImageList = Nothing
        Me.gColserial_no.isReadOnly = False
        Me.gColserial_no.MappingName = "invce_serial"
        Me.gColserial_no.MaxLength = 32767
        Me.gColserial_no.TabStop = True
        Me.gColserial_no.UseCustomCellFormat = False
        Me.gColserial_no.Width = 0
        '
        'XEditTextBoxColumn1
        '
        Me.XEditTextBoxColumn1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn1.Format = ""
        Me.XEditTextBoxColumn1.FormatInfo = Nothing
        Me.XEditTextBoxColumn1.HeaderText = "Tipo"
        Me.XEditTextBoxColumn1.ImageList = Nothing
        Me.XEditTextBoxColumn1.isReadOnly = True
        Me.XEditTextBoxColumn1.MappingName = "type_code"
        Me.XEditTextBoxColumn1.MaxLength = 32767
        Me.XEditTextBoxColumn1.TabStop = True
        Me.XEditTextBoxColumn1.UseCustomCellFormat = True
        Me.XEditTextBoxColumn1.Width = 40
        '
        'DataGridBoolColumn1
        '
        Me.DataGridBoolColumn1.FalseValue = False
        Me.DataGridBoolColumn1.HeaderText = "Estado"
        Me.DataGridBoolColumn1.MappingName = "invce_status"
        Me.DataGridBoolColumn1.NullValue = CType(resources.GetObject("DataGridBoolColumn1.NullValue"), Object)
        Me.DataGridBoolColumn1.TrueValue = True
        Me.DataGridBoolColumn1.Width = 75
        '
        'XDataGridLinkColumn1
        '
        Me.XDataGridLinkColumn1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XDataGridLinkColumn1.Format = ""
        Me.XDataGridLinkColumn1.FormatInfo = Nothing
        Me.XDataGridLinkColumn1.HeaderText = "Número"
        Me.XDataGridLinkColumn1.ImageList = Nothing
        Me.XDataGridLinkColumn1.isReadOnly = False
        Me.XDataGridLinkColumn1.MappingName = "doc_no"
        Me.XDataGridLinkColumn1.MaxLength = 32767
        Me.XDataGridLinkColumn1.TabStop = True
        Me.XDataGridLinkColumn1.UseCustomCellFormat = False
        Me.XDataGridLinkColumn1.Width = 80
        '
        'XEditTextBoxColumn2
        '
        Me.XEditTextBoxColumn2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn2.Format = ""
        Me.XEditTextBoxColumn2.FormatInfo = Nothing
        Me.XEditTextBoxColumn2.HeaderText = "Sucursal"
        Me.XEditTextBoxColumn2.ImageList = Nothing
        Me.XEditTextBoxColumn2.isReadOnly = False
        Me.XEditTextBoxColumn2.MappingName = "suc_code"
        Me.XEditTextBoxColumn2.MaxLength = 32767
        Me.XEditTextBoxColumn2.TabStop = True
        Me.XEditTextBoxColumn2.UseCustomCellFormat = False
        Me.XEditTextBoxColumn2.Width = 75
        '
        'XEditTextBoxColumn3
        '
        Me.XEditTextBoxColumn3.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn3.Format = ""
        Me.XEditTextBoxColumn3.FormatInfo = Nothing
        Me.XEditTextBoxColumn3.HeaderText = "Fecha"
        Me.XEditTextBoxColumn3.ImageList = Nothing
        Me.XEditTextBoxColumn3.isReadOnly = True
        Me.XEditTextBoxColumn3.MappingName = "doc_date"
        Me.XEditTextBoxColumn3.MaxLength = 32767
        Me.XEditTextBoxColumn3.TabStop = True
        Me.XEditTextBoxColumn3.UseCustomCellFormat = True
        Me.XEditTextBoxColumn3.Width = 80
        '
        'XEditTextBoxColumn5
        '
        Me.XEditTextBoxColumn5.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn5.Format = ""
        Me.XEditTextBoxColumn5.FormatInfo = Nothing
        Me.XEditTextBoxColumn5.HeaderText = "Vencimiento"
        Me.XEditTextBoxColumn5.ImageList = Nothing
        Me.XEditTextBoxColumn5.isReadOnly = True
        Me.XEditTextBoxColumn5.MappingName = "due_date"
        Me.XEditTextBoxColumn5.MaxLength = 32767
        Me.XEditTextBoxColumn5.TabStop = True
        Me.XEditTextBoxColumn5.UseCustomCellFormat = True
        Me.XEditTextBoxColumn5.Width = 80
        '
        'XEditTextBoxColumn6
        '
        Me.XEditTextBoxColumn6.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.XEditTextBoxColumn6.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn6.Format = "###,##0.00"
        Me.XEditTextBoxColumn6.FormatInfo = Nothing
        Me.XEditTextBoxColumn6.HeaderText = "Montoi"
        Me.XEditTextBoxColumn6.ImageList = Nothing
        Me.XEditTextBoxColumn6.isReadOnly = True
        Me.XEditTextBoxColumn6.MappingName = "amount"
        Me.XEditTextBoxColumn6.MaxLength = 32767
        Me.XEditTextBoxColumn6.TabStop = True
        Me.XEditTextBoxColumn6.UseCustomCellFormat = True
        Me.XEditTextBoxColumn6.Width = 80
        '
        'XEditTextBoxColumn4
        '
        Me.XEditTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.XEditTextBoxColumn4.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn4.Format = "###,##0.00"
        Me.XEditTextBoxColumn4.FormatInfo = Nothing
        Me.XEditTextBoxColumn4.HeaderText = "Balancei"
        Me.XEditTextBoxColumn4.ImageList = Nothing
        Me.XEditTextBoxColumn4.isReadOnly = False
        Me.XEditTextBoxColumn4.MappingName = "balance"
        Me.XEditTextBoxColumn4.MaxLength = 32767
        Me.XEditTextBoxColumn4.TabStop = True
        Me.XEditTextBoxColumn4.UseCustomCellFormat = False
        Me.XEditTextBoxColumn4.Width = 80
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.chk_bal)
        Me.GroupBox2.Controls.Add(Me.chk_facturas)
        Me.GroupBox2.Controls.Add(Me.lblFactura)
        Me.GroupBox2.Controls.Add(Me.chk_devoluc)
        Me.GroupBox2.Controls.Add(Me.lblDevoluciones)
        Me.GroupBox2.Location = New System.Drawing.Point(712, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(96, 373)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtrar"
        '
        'chk_bal
        '
        Me.chk_bal.Checked = True
        Me.chk_bal.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_bal.Location = New System.Drawing.Point(8, 88)
        Me.chk_bal.Name = "chk_bal"
        Me.chk_bal.Size = New System.Drawing.Size(80, 16)
        Me.chk_bal.TabIndex = 13
        Me.chk_bal.Text = "Balance"
        '
        'chk_facturas
        '
        Me.chk_facturas.Location = New System.Drawing.Point(8, 16)
        Me.chk_facturas.Name = "chk_facturas"
        Me.chk_facturas.Size = New System.Drawing.Size(80, 16)
        Me.chk_facturas.TabIndex = 12
        Me.chk_facturas.Text = "Facturas"
        '
        'lblFactura
        '
        Me.lblFactura.BackColor = System.Drawing.Color.Cyan
        Me.lblFactura.Location = New System.Drawing.Point(8, 32)
        Me.lblFactura.Name = "lblFactura"
        Me.lblFactura.Size = New System.Drawing.Size(56, 8)
        Me.lblFactura.TabIndex = 11
        '
        'chk_devoluc
        '
        Me.chk_devoluc.Location = New System.Drawing.Point(8, 56)
        Me.chk_devoluc.Name = "chk_devoluc"
        Me.chk_devoluc.Size = New System.Drawing.Size(80, 16)
        Me.chk_devoluc.TabIndex = 10
        Me.chk_devoluc.Text = "Devoluciones"
        '
        'lblDevoluciones
        '
        Me.lblDevoluciones.BackColor = System.Drawing.Color.LightPink
        Me.lblDevoluciones.Location = New System.Drawing.Point(8, 72)
        Me.lblDevoluciones.Name = "lblDevoluciones"
        Me.lblDevoluciones.Size = New System.Drawing.Size(56, 8)
        Me.lblDevoluciones.TabIndex = 9
        '
        'btnpagos
        '
        Me.btnpagos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnpagos.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnpagos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnpagos.Location = New System.Drawing.Point(96, 358)
        Me.btnpagos.Name = "btnpagos"
        Me.btnpagos.TabIndex = 6
        Me.btnpagos.Text = "Pagos"
        '
        'c_cpdocs01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.btnCerrar
        Me.ClientSize = New System.Drawing.Size(818, 386)
        Me.Controls.Add(Me.btnpagos)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.LibXGrid1)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "c_cpdocs01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Movimientos"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cpinvcem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub c_ccdocs01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            LibXGrid1.footerOperations.add("type_code", "count(type_code)")
            LibXGrid1.footerOperations.add("amount", "sum(amount)")
            LibXGrid1.footerOperations.add("balance", "sum(balance)")

            'LibXConnector1.AcceptFind()
            'LibXGrid1.refreshFooter()

        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub
    Private Sub ApplyFilter()
        Dim Filter As String = ""
        Try

            If chk_facturas.Checked = True Then
                Filter = "type_code in ('CUS','CRD')"
            End If

            If chk_devoluc.Checked = True Then
                If Filter.Length = 0 Then
                    Filter = "type_code = 'DVI'"
                Else
                    Filter = Filter & " and type_code = 'DVI'"
                End If
            End If
            If chk_bal.Checked = True Then
                Filter = "balance <> 0"
            End If

            DataView1.RowFilter = Filter
        Catch ex As Exception
            LibX.Log.Add(ex)

        End Try
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub LibXGrid1_FooterColumnCreating(ByVal sender As Object, ByVal e As LibX.LibXGrid.XDataGridFooterColumnCreatingEventArgs) Handles LibXGrid1.FooterColumnCreating

    End Sub

    Private Sub LibXGrid1_FooterColumnGridStyleCreating(ByVal sender As Object, ByVal e As LibX.LibXGrid.XDataGridFooterColumnGridStyleCreatingEventArgs) Handles LibXGrid1.FooterColumnGridStyleCreating
    End Sub

    Private Sub chk_facturas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_facturas.CheckedChanged
        ApplyFilter()
    End Sub

    Private Sub chk_bal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_bal.CheckedChanged
        ApplyFilter()
    End Sub

    Private Sub chk_devoluc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_devoluc.CheckedChanged
        ApplyFilter()
    End Sub

    Private Sub XEditTextBoxColumn1_SetCellFormat(ByVal sender As System.Object, ByVal e As LibX.XDataGridFormatCellEventArgs) Handles XEditTextBoxColumn1.SetCellFormat, XEditTextBoxColumn3.SetCellFormat, XEditTextBoxColumn5.SetCellFormat, XEditTextBoxColumn6.SetCellFormat

        Try
            If LibXGrid1.GetValue(e.RowNumber, 0) = "DVF" Then
                e.BackColor = lblDevoluciones.BackColor
            Else
                e.BackColor = lblFactura.BackColor
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub
    ''Dim xParam As LibX.LibxPrgParams
    ''Dim oProgram As SGT.Administracion.Entidades.Program
    ''Dim oParamProgram As SGT.Administracion.Entidades.Program.ParametrosVizualizar

    ''Dim TypeCode As String
    ''    Try
    ''        xParam = New LibX.LibxPrgParams
    ''        oProgram = New SGT.Administracion.Entidades.Program
    ''        oParamProgram = New SGT.Administracion.Entidades.Program.ParametrosVizualizar

    ''        xParam.AllowDelete = False
    ''        xParam.AllowEdit = False
    ''        xParam.AllowNew = False
    ''        xParam.AllowPrint = False
    ''        xParam.AllowQuery = False
    ''        xParam.Value = ""

    ''        Select Case cpinvcem.Rows(LibXGrid1.CurrentRowIndex)!type_code.ToString.Trim
    ''            Case "CUS"
    ''            Case "CRD"
    ''                xParam.WhereToExecute = "iventrdm.entr_number = '" & cpinvcem.Rows(LibXGrid1.CurrentRowIndex)!doc_no.ToString.Trim & "'" & _
    ''                                    " and iventrdm.type_code = '" & cpinvcem.Rows(LibXGrid1.CurrentRowIndex)!type_code.ToString.Trim & "'"
    ''            Case "DVI"
    ''            Case "NCR"
    ''            Case "NDB"
    ''        End Select

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        ''ShowDocument(1)
        Dim oParam As LibX.LibxPrgParams

        Dim WhereStmt As String
        Try
            oParam = New LibX.LibxPrgParams
            oParam.AllowDelete = False
            oParam.AllowEdit = False
            oParam.AllowNew = False
            oParam.AllowPrint = True
            oParam.AllowQuery = False
            oParam.Value = ""
            Select Case cpinvcem.Rows(LibXGrid1.CurrentRowIndex)!type_code.ToString.Trim
                Case "CUS"
                    oParam.WhereToExecute = "iventrdm.entr_number = '" & cpinvcem.Rows(LibXGrid1.CurrentRowIndex)!doc_no.ToString.Trim & "'" & _
                                       " and iventrdm.type_code = '" & cpinvcem.Rows(LibXGrid1.CurrentRowIndex)!type_code.ToString.Trim & "'"
                    LibX.App.CurrentPrgParams = oParam
                    LibX.LibXRunner.Run("i_iventr02", "INV", True)
                Case "CRD"
                    oParam.WhereToExecute = "iventrdm.entr_number = '" & cpinvcem.Rows(LibXGrid1.CurrentRowIndex)!doc_no.ToString.Trim & "'" & _
                                        " and iventrdm.type_code = '" & cpinvcem.Rows(LibXGrid1.CurrentRowIndex)!type_code.ToString.Trim & "'"
                    LibX.App.CurrentPrgParams = oParam
                    LibX.LibXRunner.Run("i_iventr02", "INV", True)
                Case "DVI"
                    oParam.WhereToExecute = "ivdevolm.dev_number = '" & cpinvcem.Rows(LibXGrid1.CurrentRowIndex)!doc_no.ToString.Trim & "'" & _
                                        " and iventrdm.type_code = '" & cpinvcem.Rows(LibXGrid1.CurrentRowIndex)!type_code.ToString.Trim & "'"
                    LibX.App.CurrentPrgParams = oParam
                    LibX.LibXRunner.Run("i_ivdevm01", "INV", True)
                Case "NCR"
                    oParam.WhereToExecute = "ivdevolm.dev_number = '" & cpinvcem.Rows(LibXGrid1.CurrentRowIndex)!doc_no.ToString.Trim & "'" & _
                                        " and iventrdm.type_code = '" & cpinvcem.Rows(LibXGrid1.CurrentRowIndex)!type_code.ToString.Trim & "'"
                    LibX.App.CurrentPrgParams = oParam
                    LibX.LibXRunner.Run("i_cpinvce01", "CXP", True)
                Case "NDB"
                    oParam.WhereToExecute = "ivdevolm.dev_number = '" & cpinvcem.Rows(LibXGrid1.CurrentRowIndex)!doc_no.ToString.Trim & "'" & _
                                        " and iventrdm.type_code = '" & cpinvcem.Rows(LibXGrid1.CurrentRowIndex)!type_code.ToString.Trim & "'"
                    LibX.App.CurrentPrgParams = oParam
                    LibX.LibXRunner.Run("i_cpinvce01", "CXP", True)
            End Select

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

    Private Sub LibXConnector1_ExecutedAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutedAction
        LibXGrid1.refreshFooter()

    End Sub

    Private Sub XDataGridLinkColumn1_LinkeClicked(ByVal sender As Object, ByVal e As System.EventArgs) Handles XDataGridLinkColumn1.LinkeClicked
        ShowDocument(1)
    End Sub
    Private Sub ShowDocument(ByVal Lnk As Integer)
        Dim xParam As LibX.LibxPrgParams
        Dim oProgram As SGT.Administracion.Entidades.Program
        Dim oParamProgram As SGT.Administracion.Entidades.Program.ParametrosVizualizar

        Dim TypeCode As String
        Try
            xParam = New LibX.LibxPrgParams
            oProgram = New SGT.Administracion.Entidades.Program
            oParamProgram = New SGT.Administracion.Entidades.Program.ParametrosVizualizar

            xParam.AllowDelete = False
            xParam.AllowEdit = False
            xParam.AllowNew = False
            xParam.AllowPrint = False
            xParam.AllowQuery = False
            xParam.Value = ""

            Select Case cpinvcem.Rows(LibXGrid1.CurrentRowIndex)!type_code.ToString.Trim
                Case "CUS"
                Case "CRD"
                    xParam.WhereToExecute = "iventrdm.entr_number = '" & cpinvcem.Rows(LibXGrid1.CurrentRowIndex)!doc_no.ToString.Trim & "'" & _
                                        " and iventrdm.type_code = '" & cpinvcem.Rows(LibXGrid1.CurrentRowIndex)!type_code.ToString.Trim & "'"
                    LibX.LibXRunner.Run("c_cpdocs01", "CXP", True)
                Case "DVI"
                Case "NCR"
                Case "NDB"
            End Select

            With oParamProgram
                .Parametros = xParam
                .TipoDocumento = cpinvcem.Rows(LibXGrid1.CurrentRowIndex)!type_code.ToString.Trim
            End With

            oProgram.Visualizar(oParamProgram)

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub XDataGridLinkColumn2_LinkeClicked(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ShowDocument(2)
    End Sub

    Private Sub btnpagos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpagos.Click
        Dim oParam As LibX.LibxPrgParams
        Dim WhereStmt As String
        Dim docSerial As Integer
        Dim modType As String
        Try
            oParam = New LibX.LibxPrgParams
            oParam.AllowDelete = False
            oParam.AllowEdit = False
            oParam.AllowNew = False
            oParam.AllowPrint = True
            oParam.AllowQuery = False
            docSerial = LibX.Data.Manager.GetScalar("select paym_serial from cppaymd where invce_serial = " & LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, gColserial_no).ToString)
            If docSerial = 0 Then
                Throw New ApplicationException("Este Documento no tiene pago aplicado!")
            End If
            LibX.Data.Manager.GetScalar("select paym_serial into #cp from cppaymd where invce_serial = " & LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, gColserial_no).ToString)
            oParam.WhereToExecute = "cppaymm.paym_serial in(select paym_serial from #cp)"
            LibX.App.CurrentPrgParams = oParam
            LibX.LibXRunner.Run("c_cpdocs04", "CXP", True)
            LibX.Data.Manager.GetScalar("drop table #cp")

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
End Class
