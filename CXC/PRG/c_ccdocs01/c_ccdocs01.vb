Public Class c_ccdocs01
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
    Friend WithEvents lblDevoluciones As System.Windows.Forms.Label
    Friend WithEvents chk_facturas As System.Windows.Forms.CheckBox
    Friend WithEvents lblFactura As System.Windows.Forms.Label
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents chk_debito As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Otros As System.Windows.Forms.CheckBox
    Friend WithEvents lblotros As System.Windows.Forms.Label
    Friend WithEvents lbldebito As System.Windows.Forms.Label
    Friend WithEvents chk_Recibo As System.Windows.Forms.CheckBox
    Friend WithEvents lblrecibo As System.Windows.Forms.Label
    Friend WithEvents chk_credito As System.Windows.Forms.CheckBox
    Friend WithEvents gcoltype_code As LibX.XEditTextBoxColumn
    Friend WithEvents gcolinvce_no As LibX.XDataGridLinkColumn
    Friend WithEvents gcolinvce_date As LibX.XEditTextBoxColumn
    Friend WithEvents gcoldue_date As LibX.XEditTextBoxColumn
    Friend WithEvents gcoltotal_amount As LibX.XEditTextBoxColumn
    Friend WithEvents gcolbf_balance As LibX.XEditTextBoxColumn
    Friend WithEvents chk_pend As System.Windows.Forms.CheckBox
    Friend WithEvents XDataGridLinkColumn1 As LibX.XDataGridLinkColumn
    Friend WithEvents gColserial_no As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnRecibos As System.Windows.Forms.Button
    Friend WithEvents gColAfectado As LibX.XEditTextBoxColumn
    Friend WithEvents vw_ccinvcemov As System.Data.DataTable
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents DataColumn17 As System.Data.DataColumn
    Friend WithEvents DataColumn18 As System.Data.DataColumn
    Friend WithEvents DataColumn19 As System.Data.DataColumn
    Friend WithEvents DataColumn20 As System.Data.DataColumn
    Friend WithEvents DataColumn21 As System.Data.DataColumn
    Friend WithEvents DataColumn22 As System.Data.DataColumn
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnView = New System.Windows.Forms.Button
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.DataSet1 = New System.Data.DataSet
        Me.vw_ccinvcemov = New System.Data.DataTable
        Me.DataColumn9 = New System.Data.DataColumn
        Me.DataColumn10 = New System.Data.DataColumn
        Me.DataColumn11 = New System.Data.DataColumn
        Me.DataColumn14 = New System.Data.DataColumn
        Me.DataColumn17 = New System.Data.DataColumn
        Me.DataColumn18 = New System.Data.DataColumn
        Me.DataColumn19 = New System.Data.DataColumn
        Me.DataColumn20 = New System.Data.DataColumn
        Me.DataColumn21 = New System.Data.DataColumn
        Me.DataColumn22 = New System.Data.DataColumn
        Me.DataColumn1 = New System.Data.DataColumn
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.LibXGrid1 = New LibX.LibXGrid
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.XdataGridTableStyle1 = New LibX.XdataGridTableStyle
        Me.gColserial_no = New System.Windows.Forms.DataGridTextBoxColumn
        Me.gcoltype_code = New LibX.XEditTextBoxColumn
        Me.gcolinvce_no = New LibX.XDataGridLinkColumn
        Me.gColAfectado = New LibX.XEditTextBoxColumn
        Me.XDataGridLinkColumn1 = New LibX.XDataGridLinkColumn
        Me.gcolinvce_date = New LibX.XEditTextBoxColumn
        Me.gcoldue_date = New LibX.XEditTextBoxColumn
        Me.gcoltotal_amount = New LibX.XEditTextBoxColumn
        Me.gcolbf_balance = New LibX.XEditTextBoxColumn
        Me.DataView1 = New System.Data.DataView
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.chk_pend = New System.Windows.Forms.CheckBox
        Me.chk_Recibo = New System.Windows.Forms.CheckBox
        Me.lblrecibo = New System.Windows.Forms.Label
        Me.chk_Otros = New System.Windows.Forms.CheckBox
        Me.lblotros = New System.Windows.Forms.Label
        Me.chk_debito = New System.Windows.Forms.CheckBox
        Me.lbldebito = New System.Windows.Forms.Label
        Me.chk_facturas = New System.Windows.Forms.CheckBox
        Me.lblFactura = New System.Windows.Forms.Label
        Me.chk_credito = New System.Windows.Forms.CheckBox
        Me.lblDevoluciones = New System.Windows.Forms.Label
        Me.btnRecibos = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vw_ccinvcemov, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupBox1.Location = New System.Drawing.Point(0, 448)
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
        Me.btnView.Location = New System.Drawing.Point(8, 458)
        Me.btnView.Name = "btnView"
        Me.btnView.TabIndex = 2
        Me.btnView.Text = "Visualizar"
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCerrar.Location = New System.Drawing.Point(623, 456)
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
        Me.LibXConnector1.DataMember = "vw_ccinvcemov"
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
        Me.LibXConnector1.UseTransactions = True
        '
        'DataSet1
        '
        Me.LibXConnector1.SetDataGenerator(Me.DataSet1, Me.LibXConnector1)
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, True)
        Me.DataSet1.EnforceConstraints = False
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.vw_ccinvcemov})
        '
        'vw_ccinvcemov
        '
        Me.vw_ccinvcemov.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn14, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn1})
        Me.vw_ccinvcemov.TableName = "vw_ccinvcemov"
        '
        'DataColumn9
        '
        Me.DataColumn9.AllowDBNull = False
        Me.DataColumn9.ColumnName = "invce_serial"
        Me.DataColumn9.DataType = GetType(System.Int32)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "type_code"
        Me.DataColumn10.MaxLength = 3
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "cust_code"
        Me.DataColumn11.DataType = GetType(System.Int32)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "invce_status"
        Me.DataColumn14.MaxLength = 12
        Me.DataColumn14.ReadOnly = True
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "invce_no"
        Me.DataColumn17.DataType = GetType(System.Int32)
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "afectado"
        Me.DataColumn18.DataType = GetType(System.Int32)
        Me.DataColumn18.ReadOnly = True
        '
        'DataColumn19
        '
        Me.DataColumn19.AllowDBNull = False
        Me.DataColumn19.ColumnName = "invce_date"
        Me.DataColumn19.DataType = GetType(System.DateTime)
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "due_date"
        Me.DataColumn20.DataType = GetType(System.DateTime)
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "total_amount"
        Me.DataColumn21.DataType = GetType(System.Decimal)
        Me.DataColumn21.ReadOnly = True
        '
        'DataColumn22
        '
        Me.DataColumn22.AllowDBNull = False
        Me.DataColumn22.ColumnName = "balance"
        Me.DataColumn22.DataType = GetType(System.Decimal)
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.ColumnName = "amount"
        Me.DataColumn1.DataType = GetType(System.Decimal)
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
        Me.LibXDbSourceTable1.Source = New String() {"select * from vw_ccinvcemov order by invce_date, invce_status"}
        Me.LibXDbSourceTable1.TableName = "vw_ccinvcemov"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
        '
        'LibXGrid1
        '
        Me.LibXGrid1.AllowSorting = False
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
        Me.LibXGrid1.Size = New System.Drawing.Size(656, 344)
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
        'XdataGridTableStyle1
        '
        Me.XdataGridTableStyle1.AlternatingBackColor = System.Drawing.SystemColors.Info
        Me.XdataGridTableStyle1.DataGrid = Me.LibXGrid1
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.gColserial_no, Me.gcoltype_code, Me.gcolinvce_no, Me.gColAfectado, Me.XDataGridLinkColumn1, Me.gcolinvce_date, Me.gcoldue_date, Me.gcoltotal_amount, Me.gcolbf_balance})
        Me.XdataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle1.MappingName = "vw_ccinvcemov"
        '
        'gColserial_no
        '
        Me.gColserial_no.Format = ""
        Me.gColserial_no.FormatInfo = Nothing
        Me.gColserial_no.MappingName = "invce_serial"
        Me.gColserial_no.Width = 0
        '
        'gcoltype_code
        '
        Me.gcoltype_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gcoltype_code.Format = ""
        Me.gcoltype_code.FormatInfo = Nothing
        Me.gcoltype_code.HeaderText = "Tipo"
        Me.gcoltype_code.ImageList = Nothing
        Me.gcoltype_code.isReadOnly = True
        Me.gcoltype_code.MappingName = "type_code"
        Me.gcoltype_code.MaxLength = 32767
        Me.gcoltype_code.TabStop = True
        Me.gcoltype_code.UseCustomCellFormat = True
        Me.gcoltype_code.Width = 40
        '
        'gcolinvce_no
        '
        Me.gcolinvce_no.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gcolinvce_no.Format = ""
        Me.gcolinvce_no.FormatInfo = Nothing
        Me.gcolinvce_no.HeaderText = "Número"
        Me.gcolinvce_no.ImageList = Nothing
        Me.gcolinvce_no.isReadOnly = False
        Me.gcolinvce_no.MappingName = "invce_no"
        Me.gcolinvce_no.MaxLength = 32767
        Me.gcolinvce_no.TabStop = True
        Me.gcolinvce_no.UseCustomCellFormat = True
        Me.gcolinvce_no.Width = 80
        '
        'gColAfectado
        '
        Me.gColAfectado.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColAfectado.Format = ""
        Me.gColAfectado.FormatInfo = Nothing
        Me.gColAfectado.HeaderText = "Doc. Afetado"
        Me.gColAfectado.ImageList = Nothing
        Me.gColAfectado.isReadOnly = False
        Me.gColAfectado.MappingName = "afectado"
        Me.gColAfectado.MaxLength = 32767
        Me.gColAfectado.TabStop = True
        Me.gColAfectado.UseCustomCellFormat = True
        Me.gColAfectado.Width = 75
        '
        'XDataGridLinkColumn1
        '
        Me.XDataGridLinkColumn1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XDataGridLinkColumn1.Format = ""
        Me.XDataGridLinkColumn1.FormatInfo = Nothing
        Me.XDataGridLinkColumn1.HeaderText = "Estado"
        Me.XDataGridLinkColumn1.ImageList = Nothing
        Me.XDataGridLinkColumn1.isReadOnly = True
        Me.XDataGridLinkColumn1.MappingName = "invce_status"
        Me.XDataGridLinkColumn1.MaxLength = 32767
        Me.XDataGridLinkColumn1.TabStop = True
        Me.XDataGridLinkColumn1.UseCustomCellFormat = True
        Me.XDataGridLinkColumn1.Width = 75
        '
        'gcolinvce_date
        '
        Me.gcolinvce_date.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gcolinvce_date.Format = ""
        Me.gcolinvce_date.FormatInfo = Nothing
        Me.gcolinvce_date.HeaderText = "Fecha"
        Me.gcolinvce_date.ImageList = Nothing
        Me.gcolinvce_date.isReadOnly = True
        Me.gcolinvce_date.MappingName = "invce_date"
        Me.gcolinvce_date.MaxLength = 32767
        Me.gcolinvce_date.TabStop = True
        Me.gcolinvce_date.UseCustomCellFormat = True
        Me.gcolinvce_date.Width = 80
        '
        'gcoldue_date
        '
        Me.gcoldue_date.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gcoldue_date.Format = ""
        Me.gcoldue_date.FormatInfo = Nothing
        Me.gcoldue_date.HeaderText = "Vencimiento"
        Me.gcoldue_date.ImageList = Nothing
        Me.gcoldue_date.isReadOnly = True
        Me.gcoldue_date.MappingName = "due_date"
        Me.gcoldue_date.MaxLength = 32767
        Me.gcoldue_date.TabStop = True
        Me.gcoldue_date.UseCustomCellFormat = True
        Me.gcoldue_date.Width = 80
        '
        'gcoltotal_amount
        '
        Me.gcoltotal_amount.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.gcoltotal_amount.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gcoltotal_amount.Format = "###,##0.00"
        Me.gcoltotal_amount.FormatInfo = Nothing
        Me.gcoltotal_amount.HeaderText = "Montoi"
        Me.gcoltotal_amount.ImageList = Nothing
        Me.gcoltotal_amount.isReadOnly = True
        Me.gcoltotal_amount.MappingName = "total_amount"
        Me.gcoltotal_amount.MaxLength = 32767
        Me.gcoltotal_amount.TabStop = True
        Me.gcoltotal_amount.UseCustomCellFormat = True
        Me.gcoltotal_amount.Width = 90
        '
        'gcolbf_balance
        '
        Me.gcolbf_balance.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.gcolbf_balance.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gcolbf_balance.Format = "#,###,##0.00"
        Me.gcolbf_balance.FormatInfo = Nothing
        Me.gcolbf_balance.HeaderText = "Balance i"
        Me.gcolbf_balance.ImageList = Nothing
        Me.gcolbf_balance.isReadOnly = True
        Me.gcolbf_balance.MappingName = "balance"
        Me.gcolbf_balance.MaxLength = 32767
        Me.gcolbf_balance.TabStop = True
        Me.gcolbf_balance.UseCustomCellFormat = True
        Me.gcolbf_balance.Width = 90
        '
        'DataView1
        '
        Me.DataView1.AllowDelete = False
        Me.DataView1.AllowEdit = False
        Me.DataView1.AllowNew = False
        Me.DataView1.Table = Me.vw_ccinvcemov
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.chk_pend)
        Me.GroupBox2.Controls.Add(Me.chk_Recibo)
        Me.GroupBox2.Controls.Add(Me.lblrecibo)
        Me.GroupBox2.Controls.Add(Me.chk_Otros)
        Me.GroupBox2.Controls.Add(Me.lblotros)
        Me.GroupBox2.Controls.Add(Me.chk_debito)
        Me.GroupBox2.Controls.Add(Me.lbldebito)
        Me.GroupBox2.Controls.Add(Me.chk_facturas)
        Me.GroupBox2.Controls.Add(Me.lblFactura)
        Me.GroupBox2.Controls.Add(Me.chk_credito)
        Me.GroupBox2.Controls.Add(Me.lblDevoluciones)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 392)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(568, 48)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtrar"
        '
        'chk_pend
        '
        Me.chk_pend.Checked = True
        Me.chk_pend.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_pend.Location = New System.Drawing.Point(464, 21)
        Me.chk_pend.Name = "chk_pend"
        Me.chk_pend.Size = New System.Drawing.Size(88, 16)
        Me.chk_pend.TabIndex = 21
        Me.chk_pend.Text = "Pendientes"
        '
        'chk_Recibo
        '
        Me.chk_Recibo.Location = New System.Drawing.Point(320, 16)
        Me.chk_Recibo.Name = "chk_Recibo"
        Me.chk_Recibo.Size = New System.Drawing.Size(64, 16)
        Me.chk_Recibo.TabIndex = 20
        Me.chk_Recibo.Text = "Recibo"
        '
        'lblrecibo
        '
        Me.lblrecibo.BackColor = System.Drawing.Color.Sienna
        Me.lblrecibo.Location = New System.Drawing.Point(320, 32)
        Me.lblrecibo.Name = "lblrecibo"
        Me.lblrecibo.Size = New System.Drawing.Size(56, 8)
        Me.lblrecibo.TabIndex = 19
        '
        'chk_Otros
        '
        Me.chk_Otros.Location = New System.Drawing.Point(392, 16)
        Me.chk_Otros.Name = "chk_Otros"
        Me.chk_Otros.Size = New System.Drawing.Size(56, 16)
        Me.chk_Otros.TabIndex = 16
        Me.chk_Otros.Text = "Otros"
        '
        'lblotros
        '
        Me.lblotros.BackColor = System.Drawing.Color.Cyan
        Me.lblotros.Location = New System.Drawing.Point(392, 32)
        Me.lblotros.Name = "lblotros"
        Me.lblotros.Size = New System.Drawing.Size(56, 8)
        Me.lblotros.TabIndex = 15
        '
        'chk_debito
        '
        Me.chk_debito.Location = New System.Drawing.Point(208, 16)
        Me.chk_debito.Name = "chk_debito"
        Me.chk_debito.Size = New System.Drawing.Size(104, 16)
        Me.chk_debito.TabIndex = 14
        Me.chk_debito.Text = "Nota de debito"
        '
        'lbldebito
        '
        Me.lbldebito.BackColor = System.Drawing.Color.DarkOrange
        Me.lbldebito.Location = New System.Drawing.Point(208, 32)
        Me.lbldebito.Name = "lbldebito"
        Me.lbldebito.Size = New System.Drawing.Size(56, 8)
        Me.lbldebito.TabIndex = 13
        '
        'chk_facturas
        '
        Me.chk_facturas.Location = New System.Drawing.Point(8, 16)
        Me.chk_facturas.Name = "chk_facturas"
        Me.chk_facturas.Size = New System.Drawing.Size(72, 16)
        Me.chk_facturas.TabIndex = 12
        Me.chk_facturas.Text = "Facturas"
        '
        'lblFactura
        '
        Me.lblFactura.BackColor = System.Drawing.Color.DarkTurquoise
        Me.lblFactura.Location = New System.Drawing.Point(8, 32)
        Me.lblFactura.Name = "lblFactura"
        Me.lblFactura.Size = New System.Drawing.Size(56, 8)
        Me.lblFactura.TabIndex = 11
        '
        'chk_credito
        '
        Me.chk_credito.Location = New System.Drawing.Point(96, 16)
        Me.chk_credito.Name = "chk_credito"
        Me.chk_credito.Size = New System.Drawing.Size(104, 16)
        Me.chk_credito.TabIndex = 10
        Me.chk_credito.Text = "Nota de credito"
        '
        'lblDevoluciones
        '
        Me.lblDevoluciones.BackColor = System.Drawing.Color.LightPink
        Me.lblDevoluciones.Location = New System.Drawing.Point(96, 32)
        Me.lblDevoluciones.Name = "lblDevoluciones"
        Me.lblDevoluciones.Size = New System.Drawing.Size(56, 8)
        Me.lblDevoluciones.TabIndex = 9
        '
        'btnRecibos
        '
        Me.btnRecibos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRecibos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRecibos.Location = New System.Drawing.Point(90, 457)
        Me.btnRecibos.Name = "btnRecibos"
        Me.btnRecibos.TabIndex = 7
        Me.btnRecibos.Text = "Recibo"
        Me.btnRecibos.Visible = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(176, 457)
        Me.Button1.Name = "Button1"
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Cobro"
        '
        'c_ccdocs01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.btnCerrar
        Me.ClientSize = New System.Drawing.Size(706, 488)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnRecibos)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.LibXGrid1)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "c_ccdocs01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Movimientos"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vw_ccinvcemov, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub TransferirFactura()
        Dim oParamPost As SGT.CXC.Posteos.PostDocument.ParametrosAplicar
        Dim oPost As SGT.CXC.Posteos.PostDocument

        Dim SelectStmt As String
        Dim oiventrdd As DataTable
        Dim oiventrdm As DataTable
        Dim OnHand As Int16

        Try
            If MessageBox.Show("Seguro desea Transferir las facturas Marcadas?", "Transferir Facturas", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                Throw New ApplicationException("Operación Abortada!")
            End If

            oParamPost = New SGT.CXC.Posteos.PostDocument.ParametrosAplicar
            oPost = New SGT.CXC.Posteos.PostDocument

            For Each oRow As DataRow In DataSet1.Tables("ccinvcem").Select("aplicar=1")
                '// Postear a inventario
                With oParamPost
                    .Serial = oRow!invce_serial
                    .Fecha = oRow!invce_date
                    .Numero = Val(oRow!invce_no.ToString)
                    '.Cliente = txtcust_code.Text
                    .ClienteOrigen = Val(oRow!cust_code.ToString)
                    .TipoDocumento = oRow!type_code.ToString
                    .Descuento = 0
                    .Impuesto = Val(oRow!itbis.ToString)
                    .Monto = Val(oRow!total_amount.ToString)
                    .PagoPorAdelantado = False
                    .Termino = oRow!term_code.ToString
                    .UseTransaction = False
                End With

                oPost.TransferirFacturas(oParamPost)
                DataSet1.Tables("ccinvcem").Rows.Remove(oRow)
            Next

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub

    Private Sub c_ccdocs01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            LibXGrid1.footerOperations.add("type_code", "count(type_code)")
            LibXGrid1.footerOperations.add("invce_no", "count(invce_no)")
            LibXGrid1.footerOperations.add("total_amount", "sum(total_amount)")
            LibXGrid1.footerOperations.add("amount", "sum(amount)")
            LibXGrid1.footerOperations.add("balance", "sum(balance)")

            LibXGrid1.getCurrentGridView.AllowDelete = False
            LibXGrid1.getCurrentGridView.AllowEdit = False
            LibXGrid1.getCurrentGridView.AllowNew = False
            LibXGrid1.refreshFooter()
            LibXGrid1.Enabled = True

        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub
    Private Sub ApplyFilter()
        Dim Filter As String = ""
        Try

            If chk_facturas.Checked = True Then
                Filter = "type_code in ('FCT','FPV','FSG','NCC','DEV')"
            End If

            If chk_credito.Checked = True Then
                If Filter.Length = 0 Then
                    Filter = "type_code in('NCC','DEV')"
                Else
                    Filter = Filter & " and type_code in('NCC','DEV')"
                End If
            End If

            If chk_debito.Checked = True Then
                If Filter.Length = 0 Then
                    Filter = "type_code = 'NDC'"
                Else
                    Filter = Filter & " and type_code = 'NDC'"
                End If
            End If

            If chk_Recibo.Checked = True Then
                If Filter.Length = 0 Then
                    Filter = "type_code = 'RCB'"
                Else
                    Filter = Filter & " and type_code = 'RCB'"
                End If
            End If

            If chk_Otros.Checked = True Then
                If Filter.Length = 0 Then
                    Filter = "type_code not in ('FCT','NCC','NDC','RCB','NCC','DEV')"
                Else
                    Filter = Filter & " and type_code not in ('FCT','NCC','NDC','RCB','FPV','FSG','DEV')"
                End If
            End If

            If chk_pend.Checked = True Then
                If Filter.Length = 0 Then
                    Filter = " balance > 0 "
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

    Private Sub chk_devoluc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_credito.CheckedChanged
        ApplyFilter()
    End Sub

    Private Sub XEditTextBoxColumn1_SetCellFormat(ByVal sender As System.Object, ByVal e As LibX.XDataGridFormatCellEventArgs) Handles gcoltype_code.SetCellFormat, gcolinvce_no.SetCellFormat, gcolinvce_date.SetCellFormat, gcoldue_date.SetCellFormat, gcoltotal_amount.SetCellFormat, XDataGridLinkColumn1.SetCellFormat, gcolbf_balance.SetCellFormat, gColAfectado.SetCellFormat

        Try
            If LibXGrid1.GetValue(e.RowNumber, 0) = "NCC" Or LibXGrid1.GetValue(e.RowNumber, 0) = "DEV" Then
                e.BackColor = lblDevoluciones.BackColor
            ElseIf LibXGrid1.GetValue(e.RowNumber, 0) = "FCT" Or LibXGrid1.GetValue(e.RowNumber, 0) = "FPV" Or LibXGrid1.GetValue(e.RowNumber, 0) = "FSG" Then
                e.BackColor = lblFactura.BackColor
            ElseIf LibXGrid1.GetValue(e.RowNumber, 0) = "NDC" Then
                e.BackColor = lbldebito.BackColor
            ElseIf LibXGrid1.GetValue(e.RowNumber, 0) <> "NCC" Then
                e.BackColor = lblotros.BackColor
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        ShowDocument(1)
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

    Private Sub XDataGridLinkColumn1_LinkeClicked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gcolinvce_no.LinkeClicked
        ShowDocument(1)
    End Sub
    Private Sub ShowDocument(ByVal Lnk As Integer)
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
            ftSerial = LibX.Data.Manager.GetScalar("select ftserial_no from ftfactm where fact_number =" & LibXGrid1.GetValue(LibXGrid1.currentRowNum, 2) & " and type_code ='" & LibXGrid1.GetValue(LibXGrid1.currentRowNum, 1) & "'")
            If ftSerial = 0 And (LibXGrid1.GetValue(LibXGrid1.currentRowNum, 1) = "FPV" Or LibXGrid1.GetValue(LibXGrid1.currentRowNum, 1) = "FSG" Or LibXGrid1.GetValue(LibXGrid1.currentRowNum, 1) = "DEV") Then
                Throw New ApplicationException("Esta factura es transferida")
            End If
            If (LibXGrid1.GetValue(LibXGrid1.currentRowNum, 1) = "FPV" Or LibXGrid1.GetValue(LibXGrid1.currentRowNum, 1) = "FSG" Or LibXGrid1.GetValue(LibXGrid1.currentRowNum, 1) = "DEV") Then
                xParam.WhereToExecute = "ftfactm.ftserial_no = " & ftSerial
                xParam.Datos.Add("ftserial_no", ftSerial)
                xParam.Datos.Add("type_code", vw_ccinvcemov.Rows(LibXGrid1.currentRowNum)!type_code.ToString)
                xParam.Value = ftSerial
                LibX.LibXRunner.Run("i_ptvfind", "PTV", True)
            End If
            If LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, 1) = "CDC" Or LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, 1) = "NCC" Or LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, 1) = "NDC" Then
                xParam.WhereToExecute = "ccinvcem.invce_serial = " & LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, 0)
                LibX.LibXRunner.Run("i_ccinvce01", "CXC", True)
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub


    Private Sub XDataGridLinkColumn2_LinkeClicked(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ShowDocument(2)
    End Sub

    Private Sub chk_debito_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_debito.CheckedChanged
        ApplyFilter()
    End Sub

    Private Sub chk_Recibo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Recibo.CheckedChanged
        ApplyFilter()
    End Sub

    Private Sub chk_trans_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ApplyFilter()
    End Sub

    Private Sub chk_Otros_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Otros.CheckedChanged
        ApplyFilter()
    End Sub

    Private Sub chk_pend_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_pend.CheckedChanged
        ApplyFilter()
    End Sub

    Private Sub btnRecibos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecibos.Click
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
            docSerial = LibX.Data.Manager.GetScalar("select paym_serial from ccpaymd where invce_serial = " & LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, gColserial_no).ToString)
            modType = LibX.Data.Manager.GetScalar("select mod_type from ccpaymd where invce_serial = " & LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, gColserial_no).ToString)
            If docSerial = 0 Then
                Throw New ApplicationException("Este Documento no tiene pago aplicado!")
            End If
            If modType = "CXC" Then
                oParam.WhereToExecute = "ccinvcem.invce_serial = " & docSerial
                LibX.App.CurrentPrgParams = oParam
                LibX.LibXRunner.Run("i_ccpaym02", "CXC", True)
            Else
                oParam.WhereToExecute = "ftfactm.ftserial_no = " & docSerial
                LibX.App.CurrentPrgParams = oParam
                LibX.LibXRunner.Run("i_ptvrecib01", "PTV", True)
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
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
            docSerial = LibX.Data.Manager.GetScalar("select paym_serial from ccpaymd where invce_serial = " & LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, gColserial_no).ToString)
            If docSerial = 0 Then
                Throw New ApplicationException("Este Documento no tiene pago aplicado!")
            End If
            LibX.Data.Manager.GetScalar("select paym_serial into #cc from ccpaymd where invce_serial = " & LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, gColserial_no).ToString)
            oParam.WhereToExecute = "ccrecibm.recib_serial in(select paym_serial from #cc)"
            LibX.App.CurrentPrgParams = oParam
            LibX.LibXRunner.Run("c_ccdocs04", "CXC", True)
            LibX.Data.Manager.GetScalar("drop table #cc")

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
End Class
