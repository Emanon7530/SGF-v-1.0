Public Class c_cpdocs05
    Inherits System.Windows.Forms.Form
    Dim mValor As Decimal
    Dim mSerial As Integer
    Dim mMonto As Decimal
    Dim mNcdoc As String
    Dim ItbisRet As Decimal
    Dim IsrRet As Decimal

    Public Class FacturaCK
        Public sMonto As Decimal
        Public sValor As Decimal
        Public sConcepto As String
        Public AcctNo As String
        Public Beneficiario As String
        Public mRetIbtis As Decimal
        Public acct_Itbis As String
        Public mRestIsr As Decimal
        Public acct_Isr As String
    End Class
    Dim MontoCK As FacturaCK

    Dim detalle As String

    Public Property FacturaSelected() As FacturaCK
        Get
            Return MontoCK
        End Get
        Set(ByVal Value As FacturaCK)
            MontoCK = Value
        End Set
    End Property

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
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents LibXGrid1 As LibX.LibXGrid
    Friend WithEvents XdataGridTableStyle1 As LibX.XdataGridTableStyle
    Friend WithEvents XEditTextBoxColumn1 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn3 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn6 As LibX.XEditTextBoxColumn
    Friend WithEvents DataView1 As System.Data.DataView
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents XEditTextBoxColumn8 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn9 As LibX.XEditTextBoxColumn
    Friend WithEvents XDataGridLinkColumn1 As LibX.XDataGridLinkColumn
    Friend WithEvents cpinvcem As System.Data.DataTable
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents DataColumn17 As System.Data.DataColumn
    Friend WithEvents DataColumn23 As System.Data.DataColumn
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnMarkAll As System.Windows.Forms.Button
    Friend WithEvents btnUnmarkall As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents gColAplicar As LibX.XDataGridBoolColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents xtxmonto As LibX.XTextBox
    Friend WithEvents xtxnc As LibX.XTextBox
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents gColBalance As LibX.XEditTextBoxColumn
    Friend WithEvents gColAmt As LibX.XEditTextBoxColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents gColretitbis As LibX.XEditTextBoxColumn
    Friend WithEvents gColIsrRet As LibX.XEditTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.DataSet1 = New System.Data.DataSet
        Me.cpinvcem = New System.Data.DataTable
        Me.DataColumn13 = New System.Data.DataColumn
        Me.DataColumn14 = New System.Data.DataColumn
        Me.DataColumn15 = New System.Data.DataColumn
        Me.DataColumn17 = New System.Data.DataColumn
        Me.DataColumn23 = New System.Data.DataColumn
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn8 = New System.Data.DataColumn
        Me.DataColumn7 = New System.Data.DataColumn
        Me.DataColumn9 = New System.Data.DataColumn
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.LibXGrid1 = New LibX.LibXGrid
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.XdataGridTableStyle1 = New LibX.XdataGridTableStyle
        Me.gColAplicar = New LibX.XDataGridBoolColumn
        Me.XEditTextBoxColumn1 = New LibX.XEditTextBoxColumn
        Me.XDataGridLinkColumn1 = New LibX.XDataGridLinkColumn
        Me.XEditTextBoxColumn3 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn6 = New LibX.XEditTextBoxColumn
        Me.gColretitbis = New LibX.XEditTextBoxColumn
        Me.gColIsrRet = New LibX.XEditTextBoxColumn
        Me.gColBalance = New LibX.XEditTextBoxColumn
        Me.gColAmt = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn8 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn9 = New LibX.XEditTextBoxColumn
        Me.DataView1 = New System.Data.DataView
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnMarkAll = New System.Windows.Forms.Button
        Me.btnUnmarkall = New System.Windows.Forms.Button
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.xtxmonto = New LibX.XTextBox
        Me.xtxnc = New LibX.XTextBox
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cpinvcem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(0, 371)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(320, 8)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
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
        Me.cpinvcem.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn17, Me.DataColumn23, Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn8, Me.DataColumn7, Me.DataColumn9})
        Me.cpinvcem.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"invce_serial"}, True)})
        Me.cpinvcem.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn1}
        Me.cpinvcem.TableName = "cpinvcem"
        '
        'DataColumn13
        '
        Me.DataColumn13.AllowDBNull = False
        Me.DataColumn13.ColumnName = "type_code"
        Me.DataColumn13.MaxLength = 3
        '
        'DataColumn14
        '
        Me.DataColumn14.AllowDBNull = False
        Me.DataColumn14.ColumnName = "doc_no"
        Me.DataColumn14.MaxLength = 20
        '
        'DataColumn15
        '
        Me.DataColumn15.AllowDBNull = False
        Me.DataColumn15.ColumnName = "doc_date"
        Me.DataColumn15.DataType = GetType(System.DateTime)
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "amount"
        Me.DataColumn17.DataType = GetType(System.Decimal)
        Me.DataColumn17.ReadOnly = True
        '
        'DataColumn23
        '
        Me.DataColumn23.AllowDBNull = False
        Me.DataColumn23.ColumnName = "prov_code"
        Me.DataColumn23.DataType = GetType(System.Int32)
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
        Me.DataColumn2.ColumnName = "dev_serial"
        Me.DataColumn2.DataType = GetType(System.Int32)
        '
        'DataColumn3
        '
        Me.DataColumn3.Caption = "Aplicar"
        Me.DataColumn3.ColumnName = "Aplicar"
        Me.DataColumn3.DataType = GetType(System.Int16)
        Me.DataColumn3.DefaultValue = CType(0, Short)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "cbm_serial"
        Me.DataColumn4.DataType = GetType(System.Int32)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "acct_no"
        Me.DataColumn5.MaxLength = 15
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "balance"
        Me.DataColumn6.DataType = GetType(System.Decimal)
        Me.DataColumn6.ReadOnly = True
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "amt"
        Me.DataColumn8.DataType = GetType(System.Decimal)
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "itbis_retenido"
        Me.DataColumn7.DataType = GetType(System.Decimal)
        Me.DataColumn7.ReadOnly = True
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "isr_retenido"
        Me.DataColumn9.DataType = GetType(System.Decimal)
        Me.DataColumn9.ReadOnly = True
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
        Me.LibXDbSourceTable1.Source = New String() {"select invce_serial,prov_code,type_code,doc_no,doc_date,acct_no,", "case type_code when 'CUS' then ((isnull(amount,0)+isnull(itbis,0))* tasaUS ) else" & _
        " (isnull(amount,0)+isnull(itbis,0)) end amount,", "isnull(itbis_retenido,0) itbis_retenido,isnull(isr_retenido,0)isr_retenido,", "case type_code when 'CUS' then (isnull(balance,0) * tasaUS) else balance end bala" & _
        "nce ,0 amt,cbm_serial", " from cpinvcem where invce_status = 4 and invce_status <> 3", " and balance  > 0", "order by prov_code,doc_date"}
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
        Me.LibXGrid1.CaptionText = "Facturas de Gastos"
        Me.LibXGrid1.ContextMenu = Me.ContextMenu1
        Me.LibXGrid1.DataMember = "cpinvcem"
        Me.LibXGrid1.DataSource = Me.DataSet1
        Me.LibXGrid1.FullRowSelect = True
        Me.LibXGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGrid1.IsReadOnly = False
        Me.LibXGrid1.Location = New System.Drawing.Point(8, 32)
        Me.LibXGrid1.Name = "LibXGrid1"
        Me.LibXGrid1.ReadOnly = True
        Me.LibXGrid1.searchText = ""
        Me.LibXGrid1.showFooterBar = True
        Me.LibXGrid1.Size = New System.Drawing.Size(664, 272)
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
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.gColAplicar, Me.XEditTextBoxColumn1, Me.XDataGridLinkColumn1, Me.XEditTextBoxColumn3, Me.XEditTextBoxColumn6, Me.gColretitbis, Me.gColIsrRet, Me.gColBalance, Me.gColAmt, Me.XEditTextBoxColumn8, Me.XEditTextBoxColumn9})
        Me.XdataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle1.MappingName = "cpinvcem"
        '
        'gColAplicar
        '
        Me.gColAplicar.FalseValue = CType(0, Short)
        Me.gColAplicar.HeaderText = "Marcar"
        Me.gColAplicar.MappingName = "aplicar"
        Me.gColAplicar.NullValue = 0
        Me.gColAplicar.TrueValue = CType(1, Short)
        Me.gColAplicar.UseCustomCellFormat = False
        Me.gColAplicar.Width = 40
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
        'gColretitbis
        '
        Me.gColretitbis.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColretitbis.Format = "##,###,##0.00"
        Me.gColretitbis.FormatInfo = Nothing
        Me.gColretitbis.HeaderText = "Itbis Retenido"
        Me.gColretitbis.ImageList = Nothing
        Me.gColretitbis.isReadOnly = False
        Me.gColretitbis.MappingName = "itbis_retenido"
        Me.gColretitbis.MaxLength = 32767
        Me.gColretitbis.TabStop = True
        Me.gColretitbis.UseCustomCellFormat = False
        Me.gColretitbis.Width = 75
        '
        'gColIsrRet
        '
        Me.gColIsrRet.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColIsrRet.Format = "##,###,##0.00"
        Me.gColIsrRet.FormatInfo = Nothing
        Me.gColIsrRet.HeaderText = "Isr Retenido"
        Me.gColIsrRet.ImageList = Nothing
        Me.gColIsrRet.isReadOnly = False
        Me.gColIsrRet.MappingName = "isr_retenido"
        Me.gColIsrRet.MaxLength = 32767
        Me.gColIsrRet.TabStop = True
        Me.gColIsrRet.UseCustomCellFormat = False
        Me.gColIsrRet.Width = 75
        '
        'gColBalance
        '
        Me.gColBalance.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.gColBalance.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColBalance.Format = "##,###,##0.00"
        Me.gColBalance.FormatInfo = Nothing
        Me.gColBalance.HeaderText = "Balance"
        Me.gColBalance.ImageList = Nothing
        Me.gColBalance.isReadOnly = False
        Me.gColBalance.MappingName = "balance"
        Me.gColBalance.MaxLength = 32767
        Me.gColBalance.TabStop = True
        Me.gColBalance.UseCustomCellFormat = False
        Me.gColBalance.Width = 75
        '
        'gColAmt
        '
        Me.gColAmt.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.gColAmt.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColAmt.Format = "##,###,##0.00"
        Me.gColAmt.FormatInfo = Nothing
        Me.gColAmt.HeaderText = "Aplicado"
        Me.gColAmt.ImageList = Nothing
        Me.gColAmt.isReadOnly = False
        Me.gColAmt.MappingName = "amt"
        Me.gColAmt.MaxLength = 32767
        Me.gColAmt.TabStop = True
        Me.gColAmt.UseCustomCellFormat = False
        Me.gColAmt.Width = 75
        '
        'XEditTextBoxColumn8
        '
        Me.XEditTextBoxColumn8.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.XEditTextBoxColumn8.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn8.Format = ""
        Me.XEditTextBoxColumn8.FormatInfo = Nothing
        Me.XEditTextBoxColumn8.ImageList = Nothing
        Me.XEditTextBoxColumn8.isReadOnly = False
        Me.XEditTextBoxColumn8.MappingName = "invce_serial"
        Me.XEditTextBoxColumn8.MaxLength = 32767
        Me.XEditTextBoxColumn8.TabStop = True
        Me.XEditTextBoxColumn8.UseCustomCellFormat = False
        Me.XEditTextBoxColumn8.Width = 0
        '
        'XEditTextBoxColumn9
        '
        Me.XEditTextBoxColumn9.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.XEditTextBoxColumn9.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn9.Format = ""
        Me.XEditTextBoxColumn9.FormatInfo = Nothing
        Me.XEditTextBoxColumn9.ImageList = Nothing
        Me.XEditTextBoxColumn9.isReadOnly = False
        Me.XEditTextBoxColumn9.MappingName = "dev_serial"
        Me.XEditTextBoxColumn9.MaxLength = 32767
        Me.XEditTextBoxColumn9.TabStop = True
        Me.XEditTextBoxColumn9.UseCustomCellFormat = False
        Me.XEditTextBoxColumn9.Width = 0
        '
        'DataView1
        '
        Me.DataView1.AllowDelete = False
        Me.DataView1.AllowEdit = False
        Me.DataView1.AllowNew = False
        Me.DataView1.Table = Me.cpinvcem
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(502, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Monto Nc:"
        Me.Label2.Visible = False
        '
        'btnMarkAll
        '
        Me.btnMarkAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnMarkAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMarkAll.Location = New System.Drawing.Point(8, 374)
        Me.btnMarkAll.Name = "btnMarkAll"
        Me.btnMarkAll.Size = New System.Drawing.Size(80, 32)
        Me.btnMarkAll.TabIndex = 11
        Me.btnMarkAll.Text = "Marcar Todos"
        '
        'btnUnmarkall
        '
        Me.btnUnmarkall.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnUnmarkall.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUnmarkall.Location = New System.Drawing.Point(88, 374)
        Me.btnUnmarkall.Name = "btnUnmarkall"
        Me.btnUnmarkall.Size = New System.Drawing.Size(80, 32)
        Me.btnUnmarkall.TabIndex = 12
        Me.btnUnmarkall.Text = "Desmarcar Todos"
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAceptar.Location = New System.Drawing.Point(218, 374)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(80, 32)
        Me.btnAceptar.TabIndex = 13
        Me.btnAceptar.Text = "Aceptar"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Location = New System.Drawing.Point(306, 374)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 32)
        Me.btnCancel.TabIndex = 14
        Me.btnCancel.Text = "Cancelar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(470, 333)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 16)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Monto Aplicado:"
        '
        'xtxmonto
        '
        Me.xtxmonto.AcceptsReturn = True
        Me.xtxmonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xtxmonto.EditInitialValue = Nothing
        Me.xtxmonto.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxmonto.FieldDescription = ""
        Me.xtxmonto.FindInitialValue = Nothing
        Me.xtxmonto.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxmonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xtxmonto.ForeColor = System.Drawing.Color.Blue
        Me.xtxmonto.IgnoreRequiered = False
        Me.xtxmonto.Location = New System.Drawing.Point(561, 328)
        Me.xtxmonto.Name = "xtxmonto"
        Me.xtxmonto.NewInitialValue = Nothing
        Me.xtxmonto.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxmonto.Requiered = False
        Me.xtxmonto.Size = New System.Drawing.Size(112, 26)
        Me.xtxmonto.StatusBarPanelDescripcion = Nothing
        Me.xtxmonto.TabIndex = 15
        Me.xtxmonto.Text = ""
        Me.xtxmonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'xtxnc
        '
        Me.xtxnc.AcceptsReturn = True
        Me.xtxnc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xtxnc.EditInitialValue = Nothing
        Me.xtxnc.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxnc.FieldDescription = ""
        Me.xtxnc.FindInitialValue = Nothing
        Me.xtxnc.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxnc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xtxnc.ForeColor = System.Drawing.Color.Blue
        Me.xtxnc.IgnoreRequiered = False
        Me.xtxnc.Location = New System.Drawing.Point(559, 6)
        Me.xtxnc.Name = "xtxnc"
        Me.xtxnc.NewInitialValue = Nothing
        Me.xtxnc.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxnc.Requiered = False
        Me.xtxnc.Size = New System.Drawing.Size(112, 22)
        Me.xtxnc.StatusBarPanelDescripcion = Nothing
        Me.xtxnc.TabIndex = 7
        Me.xtxnc.Text = ""
        Me.xtxnc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'c_cpdocs05
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(722, 416)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.xtxmonto)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnMarkAll)
        Me.Controls.Add(Me.btnUnmarkall)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.xtxnc)
        Me.Controls.Add(Me.LibXGrid1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "c_cpdocs05"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Facturas"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cpinvcem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub c_ccdocs01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            LibXGrid1.footerOperations.add("type_code", "count(type_code)")
            LibXGrid1.footerOperations.add("amount", "sum(amount)")
            mSerial = LibXConnector1.Parameters.Datos.Item("serial")

        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub
    Private Sub ApplyFilter()
        Dim Filter As String = ""
        Try
            If Filter.Length = 0 Then
                Filter = "type_code = 'DVI'"
            Else
                Filter = Filter & " and type_code = 'DVI'"
            End If

            DataView1.RowFilter = Filter
        Catch ex As Exception
            LibX.Log.Add(ex)

        End Try
    End Sub
    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
            xParam.AllowEdit = True
            xParam.AllowNew = False
            xParam.AllowPrint = False
            xParam.AllowQuery = False
            xParam.Value = ""

            Select Case cpinvcem.Rows(LibXGrid1.CurrentRowIndex)!type_code.ToString.Trim
                Case "CUS"
                Case "CRD"
                    xParam.WhereToExecute = "iventrdm.entr_number = '" & cpinvcem.Rows(LibXGrid1.CurrentRowIndex)!doc_no.ToString.Trim & "'" & _
                                        " and iventrdm.type_code = '" & cpinvcem.Rows(LibXGrid1.CurrentRowIndex)!type_code.ToString.Trim & "'"
                Case "CCH"
                    xParam.WhereToExecute = "iventrdm.entr_number = '" & cpinvcem.Rows(LibXGrid1.CurrentRowIndex)!doc_no.ToString.Trim & "'" & _
                                       " and iventrdm.type_code = '" & cpinvcem.Rows(LibXGrid1.CurrentRowIndex)!type_code.ToString.Trim & "'"
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
    Public Overloads Function ShowDialog(ByVal serial As Integer) As DialogResult
        mSerial = serial
        Return MyBase.ShowDialog()
    End Function
    Private Sub gCol_Aplicar_BoolValueChanged(ByVal sender As System.Object, ByVal e As LibX.BoolValueChangedEventArgs) Handles gColAplicar.BoolValueChanged
        Try
            If LibXGrid1.EndEdit(gColAplicar, LibXGrid1.CurrentRowIndex, True) = False Then
                cpinvcem.Rows(LibXGrid1.CurrentRowIndex).BeginEdit()
                cpinvcem.Rows(LibXGrid1.CurrentRowIndex)!Aplicar = IIf(e.BoolValue, 1, 0)
                cpinvcem.Rows(LibXGrid1.CurrentRowIndex).EndEdit()
                If cpinvcem.Rows(LibXGrid1.CurrentRowIndex)!Aplicar = 0 Then
                    mValor = mValor - cpinvcem.Rows(LibXGrid1.CurrentRowIndex)!balance
                    mMonto = mMonto - cpinvcem.Rows(LibXGrid1.CurrentRowIndex)!amount
                    xtxmonto.Text = mValor.ToString("###,###,##0.00")
                    LibXGrid1.SetValue(LibXGrid1.CurrentRowIndex, Me.gColAmt, 0)
                Else
                    mValor = mValor + Val(cpinvcem.Rows(LibXGrid1.CurrentRowIndex)!balance)
                    mMonto = mMonto + cpinvcem.Rows(LibXGrid1.CurrentRowIndex)!amount
                    xtxmonto.Text = mValor.ToString("###,###,##0.00")
                    LibXGrid1.SetValue(LibXGrid1.CurrentRowIndex, Me.gColAmt, Val(LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, Me.gColBalance).ToString))
                End If
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub LibXConnector1_RowChange(ByVal sender As Object, ByVal e As LibX.XRowChangeEventArgs) Handles LibXConnector1.RowChange
        Try
            If LibXConnector1.HasRecords = True Then
                If Not e.row Is Nothing Then
                    LibXConnector1.AllowDelete = False
                    LibXConnector1.AllowNew = False
                    LibXConnector1.AllowPrint = False
                    LibXConnector1.AllowEdit = True
                    If LibXConnector1.Parameters.Value > 0 Then
                        Me.xtxnc.Text = LibXConnector1.Parameters.Datos("xtxnc")
                        mSerial = LibXConnector1.Parameters.Value
                    End If
                End If
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try

    End Sub
    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMarkAll.Click
        Try
            Me.xtxmonto.Text = 0
            mValor = 0
            mMonto = 0
            For Each oRow As DataRow In DataSet1.Tables("cpinvcem").Rows
                oRow!Aplicar = 1
                If oRow!Aplicar = 1 Then
                    mValor = mValor + oRow!balance
                    mMonto = mMonto + oRow!amount
                    Me.xtxmonto.Text = mValor.ToString("###,###,##0.00")
                    If Val(Me.xtxmonto.Text) > 0 Then
                        Label2.Visible = True
                        Me.xtxmonto.Visible = True
                    Else
                        Label2.Visible = False
                        Me.xtxmonto.Visible = False
                    End If
                End If
            Next

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnmarkall.Click
        Try
            Me.xtxmonto.Text = 0
            mValor = 0
            mMonto = 0
            For Each oRow As DataRow In DataSet1.Tables("cpinvcem").Rows
                oRow!Aplicar = 0
                If oRow!Aplicar = 0 Then
                    mValor = mValor - oRow!balance
                    mMonto = mMonto - oRow!amount
                    Me.xtxmonto.Text = mValor.ToString("###,###,##0.00")
                    If Val(Me.xtxmonto.Text) > 0 Then
                        Label2.Visible = True
                        Me.xtxmonto.Visible = True
                    Else
                        Label2.Visible = False
                        Me.xtxmonto.Visible = False
                    End If
                End If
            Next

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try

    End Sub
    Private Sub c_cpdocs05(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Dim xUpdate As LibX.Data.XUpdateStmt
        Dim xDelete As LibX.Data.XDeleteStmt
        Dim ncdv As Integer

        Try
            If LibXConnector1.IsDataEditing = True Then
                If e.KeyCode = Keys.F5 Then
                    LibXConnector1.Accept()
                    MontoCK = New FacturaCK
                    If mSerial = 0 Then
                        mSerial = 99999
                    End If
                    For Each oRow As DataRow In DataSet1.Tables("cpinvcem").Rows
                        If oRow!Aplicar = 1 Then
                            xUpdate = New LibX.Data.XUpdateStmt("cpinvcem")
                            xUpdate.FieldsSet("amt") = oRow!amt
                            xUpdate.FieldsSet("balance") = oRow!balance - oRow!amt
                            xUpdate.FieldsSet("invce_status") = 3
                            xUpdate.FieldsSet("cbm_serial") = mSerial
                            xUpdate.Fields("invce_serial") = oRow!invce_serial
                            xUpdate.Execute()
                            xUpdate.Dispose()
                            If Len(detalle) > 1 Then
                                detalle = detalle & ";" & oRow!doc_no
                            Else
                                detalle = oRow!doc_no
                            End If
                            If Not LibX.IsNull(oRow!acct_no) Then
                                MontoCK.AcctNo = oRow!acct_no
                            End If
                            MontoCK.Beneficiario = LibX.Data.Manager.GetScalar("select prov_name from cpprovm where prov_code =" & oRow!prov_code)
                        End If
                        If Val(oRow!itbis_retenido) > 0 Then
                            ItbisRet = ItbisRet + oRow!itbis_retenido
                        End If
                        If Val(oRow!isr_retenido) > 0 Then
                            IsrRet = IsrRet + oRow!isr_retenido
                        End If
                    Next
                    If ItbisRet > 0 Then
                        MontoCK.mRetIbtis = ItbisRet
                        MontoCK.acct_Itbis = "200303"
                    End If
                    If IsrRet > 0 Then
                        MontoCK.mRestIsr = IsrRet
                        MontoCK.acct_Isr = "200302"
                    End If
                    MontoCK.sValor = mMonto
                    MontoCK.sMonto = CDec(xtxmonto.Text)
                    MontoCK.sConcepto = "PAGO DE REPOSICION FACTURA/S #  " & detalle

                    Me.DialogResult = DialogResult.OK
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim xUpdate As LibX.Data.XUpdateStmt
        Try
            If mSerial = 0 Then
                mSerial = 99999
            End If
            ''LibXConnector1.Accept()
            For Each oRow As DataRow In DataSet1.Tables("cpinvcem").Rows
                If oRow!Aplicar = 1 Then
                    xUpdate = New LibX.Data.XUpdateStmt("cpinvcem")
                    xUpdate.FieldsSet("invce_status") = 3
                    xUpdate.FieldsSet("amt") = oRow!amt
                    xUpdate.FieldsSet("balance") = oRow!balance - oRow!amt
                    xUpdate.FieldsSet("cbm_serial") = mSerial
                    xUpdate.Fields("invce_serial") = oRow!invce_serial
                    xUpdate.Execute()
                    xUpdate.Dispose()

                    If Len(detalle) > 1 Then
                        detalle = detalle & ";" & oRow!type_code & "-" & oRow!doc_no
                    Else
                        detalle = oRow!type_code & "-" & oRow!doc_no
                    End If
                    ''If Not LibX.IsNull(oRow!acct_no) Then
                    ''    MontoCK.AcctNo = oRow!acct_no
                    ''End If
                    If Val(oRow!itbis_retenido) > 0 Then
                        ItbisRet = ItbisRet + oRow!itbis_retenido
                    End If
                    If Val(oRow!isr_retenido) > 0 Then
                        IsrRet = IsrRet + oRow!isr_retenido
                    End If
                    MontoCK.Beneficiario = LibX.Data.Manager.GetScalar("select prov_name from cpprovm where prov_code =" & oRow!prov_code)
                End If
            Next
            CodificarImpuesto()

            'If LibX.IsNull(MontoCK.AcctNo) Then
            '    MontoCK.AcctNo = "200303"
            'End If
            'If ItbisRet > 0 Then
            '    MontoCK.mRetIbtis = ItbisRet
            '    MontoCK.acct_Itbis = "200301"
            'End If
            'If IsrRet > 0 Then
            '    MontoCK.mRestIsr = IsrRet
            '    MontoCK.acct_Isr = "200302"
            'End If

            '''''

            ''''''''

            MontoCK.sConcepto = detalle
            MontoCK.sValor = mMonto
            MontoCK.sMonto = CDec(xtxmonto.Text)
            MontoCK.sConcepto = "PAGO DE REPOSICION FACTURA/S #  " & detalle

            Me.DialogResult = DialogResult.Yes
            Me.Close()

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
    Private Sub xtxnc_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles xtxnc.Validating
        Try
            cpinvcem.Rows(LibXGrid1.CurrentRowIndex).BeginEdit()
            cpinvcem.Rows(LibXGrid1.CurrentRowIndex)!amt = Me.xtxnc.Text
            cpinvcem.Rows(LibXGrid1.CurrentRowIndex).EndEdit()
            mValor = 0
            For Each oRow As DataRow In DataSet1.Tables("cpinvcem").Rows
                mValor = mValor + oRow!amt
                Me.xtxmonto.Text = mValor.ToString("###,###,##0.00")
            Next
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try

    End Sub
    Private Sub CodificarImpuesto()
        Dim oCuentas As DataTable
        Dim oTable As DataTable

        Dim debito As Decimal
        Dim credito As Decimal

        Dim m_nombreCuenta As String = String.Empty

        If cpinvcem.Rows(LibXGrid1.CurrentRowIndex)!type_code.ToString.Trim <> String.Empty Then
            oCuentas = LibX.Data.Manager.GetDataTable("select * from cuentascodificacion where type_code = '" & cpinvcem.Rows(LibXGrid1.CurrentRowIndex)!type_code.ToString.Trim & "'")

        End If

        Dim cuentasRows As DataRow

        For Each cuentasRows In oCuentas.Rows

            Select Case cuentasRows!orig_valor

                Case SGT.Contabilidad.Entidades.Codificacion.OrigenValorEnum.RetItbis

                    oTable = LibX.Data.Manager.GetDataTable("select * from cgacctm where acct_no ='" & cuentasRows!acct_no & "'")

                    MontoCK.mRetIbtis = ItbisRet
                    MontoCK.acct_Itbis = oTable.Rows(0)!acct_no


                Case SGT.Contabilidad.Entidades.Codificacion.OrigenValorEnum.RetIsr

                    oTable = LibX.Data.Manager.GetDataTable("select * from cgacctm where acct_no ='" & cuentasRows!acct_no & "'")

                    MontoCK.mRestIsr = IsrRet
                    MontoCK.acct_Isr = oTable.Rows(0)!acct_no



            End Select
        Next

    End Sub
End Class

