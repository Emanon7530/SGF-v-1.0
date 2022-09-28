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
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents XEditTextBoxColumn9 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn10 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn11 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn12 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn13 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn14 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn16 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn1 As LibX.XEditTextBoxColumn
    Friend WithEvents ivstadism As System.Data.DataTable
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
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
    Friend WithEvents XEditTextBoxColumn2 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn3 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn4 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn5 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn6 As LibX.XEditTextBoxColumn
    Friend WithEvents DataColumn29 As System.Data.DataColumn
    Friend WithEvents gcoltype_code As LibX.XEditTextBoxColumn
    Friend WithEvents gColitem_code As LibX.XEditTextBoxColumn
    Friend WithEvents gcolwhse_code As LibX.XEditTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents xcbo_Ano As System.Windows.Forms.ComboBox
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnView = New System.Windows.Forms.Button
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.DataSet1 = New System.Data.DataSet
        Me.ivstadism = New System.Data.DataTable
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn7 = New System.Data.DataColumn
        Me.DataColumn8 = New System.Data.DataColumn
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
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.LibXGrid1 = New LibX.LibXGrid
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.DataView1 = New System.Data.DataView
        Me.XdataGridTableStyle1 = New LibX.XdataGridTableStyle
        Me.gcoltype_code = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn9 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn10 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn11 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn12 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn13 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn14 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn16 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn1 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn2 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn3 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn4 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn5 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn6 = New LibX.XEditTextBoxColumn
        Me.gColitem_code = New LibX.XEditTextBoxColumn
        Me.gcolwhse_code = New LibX.XEditTextBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.xcbo_Ano = New System.Windows.Forms.ComboBox
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ivstadism, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(0, 521)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1168, 8)
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
        Me.btnCerrar.Location = New System.Drawing.Point(1088, 536)
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
        Me.LibXConnector1.DataMember = "ivstadism"
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
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, False)
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.ivstadism})
        '
        'ivstadism
        '
        Me.ivstadism.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn1})
        Me.ivstadism.TableName = "ivstadism"
        '
        'DataColumn4
        '
        Me.DataColumn4.AllowDBNull = False
        Me.DataColumn4.ColumnName = "item_code"
        Me.DataColumn4.MaxLength = 10
        '
        'DataColumn5
        '
        Me.DataColumn5.AllowDBNull = False
        Me.DataColumn5.ColumnName = "item_name"
        Me.DataColumn5.MaxLength = 100
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "type_code"
        Me.DataColumn6.MaxLength = 3
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "type_name"
        Me.DataColumn7.MaxLength = 30
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "Enero"
        Me.DataColumn8.DataType = GetType(System.Int32)
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "Febrero"
        Me.DataColumn18.DataType = GetType(System.Int32)
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "Marzo"
        Me.DataColumn19.DataType = GetType(System.Int32)
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "Abril"
        Me.DataColumn20.DataType = GetType(System.Int32)
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "Mayo"
        Me.DataColumn21.DataType = GetType(System.Int32)
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "Junio"
        Me.DataColumn22.DataType = GetType(System.Int32)
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "Julio"
        Me.DataColumn23.DataType = GetType(System.Int32)
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "Agosto"
        Me.DataColumn24.DataType = GetType(System.Int32)
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "Septiembre"
        Me.DataColumn25.DataType = GetType(System.Int32)
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "Octubre"
        Me.DataColumn26.DataType = GetType(System.Int32)
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "Noviembre"
        Me.DataColumn27.DataType = GetType(System.Int32)
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "Diciembre"
        Me.DataColumn28.DataType = GetType(System.Int32)
        '
        'DataColumn29
        '
        Me.DataColumn29.AllowDBNull = False
        Me.DataColumn29.ColumnName = "whse_code"
        Me.DataColumn29.DataType = GetType(System.Int32)
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
        Me.LibXDbSourceTable1.Source = Nothing
        Me.LibXDbSourceTable1.TableName = "ivstadism"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "Ano"
        Me.DataColumn1.DataType = GetType(System.Int32)
        '
        'LibXGrid1
        '
        Me.LibXGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LibXGrid1.AutoAdjustLastColumn = True
        Me.LibXGrid1.AutoSearch = True
        Me.LibXGrid1.BackgroundColor = System.Drawing.Color.White
        Me.LibXGrid1.CaptionText = "Movimientos"
        Me.LibXGrid1.ContextMenu = Me.ContextMenu1
        Me.LibXGrid1.DataMember = "ivstadism"
        Me.LibXGrid1.DataSource = Me.DataSet1
        Me.LibXGrid1.FullRowSelect = True
        Me.LibXGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGrid1.IsReadOnly = False
        Me.LibXGrid1.Location = New System.Drawing.Point(8, 32)
        Me.LibXGrid1.Name = "LibXGrid1"
        Me.LibXGrid1.ReadOnly = True
        Me.LibXGrid1.searchText = ""
        Me.LibXGrid1.showFooterBar = True
        Me.LibXGrid1.Size = New System.Drawing.Size(1160, 464)
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
        Me.DataView1.Table = Me.ivstadism
        '
        'XdataGridTableStyle1
        '
        Me.XdataGridTableStyle1.AlternatingBackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.XdataGridTableStyle1.DataGrid = Me.LibXGrid1
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.gcoltype_code, Me.XEditTextBoxColumn9, Me.XEditTextBoxColumn10, Me.XEditTextBoxColumn11, Me.XEditTextBoxColumn12, Me.XEditTextBoxColumn13, Me.XEditTextBoxColumn14, Me.XEditTextBoxColumn16, Me.XEditTextBoxColumn1, Me.XEditTextBoxColumn2, Me.XEditTextBoxColumn3, Me.XEditTextBoxColumn4, Me.XEditTextBoxColumn5, Me.XEditTextBoxColumn6, Me.gColitem_code, Me.gcolwhse_code})
        Me.XdataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle1.MappingName = "ivstadism"
        '
        'gcoltype_code
        '
        Me.gcoltype_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gcoltype_code.Format = ""
        Me.gcoltype_code.FormatInfo = Nothing
        Me.gcoltype_code.ImageList = Nothing
        Me.gcoltype_code.isReadOnly = False
        Me.gcoltype_code.MappingName = "type_code"
        Me.gcoltype_code.MaxLength = 32767
        Me.gcoltype_code.TabStop = True
        Me.gcoltype_code.UseCustomCellFormat = False
        Me.gcoltype_code.Width = 0
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
        Me.XEditTextBoxColumn9.UseCustomCellFormat = False
        Me.XEditTextBoxColumn9.Width = 200
        '
        'XEditTextBoxColumn10
        '
        Me.XEditTextBoxColumn10.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.XEditTextBoxColumn10.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn10.Format = "###,###"
        Me.XEditTextBoxColumn10.FormatInfo = Nothing
        Me.XEditTextBoxColumn10.HeaderText = "ENERO"
        Me.XEditTextBoxColumn10.ImageList = Nothing
        Me.XEditTextBoxColumn10.isReadOnly = False
        Me.XEditTextBoxColumn10.MappingName = "Enero"
        Me.XEditTextBoxColumn10.MaxLength = 32767
        Me.XEditTextBoxColumn10.TabStop = True
        Me.XEditTextBoxColumn10.UseCustomCellFormat = False
        Me.XEditTextBoxColumn10.Width = 75
        '
        'XEditTextBoxColumn11
        '
        Me.XEditTextBoxColumn11.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.XEditTextBoxColumn11.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn11.Format = "###,###"
        Me.XEditTextBoxColumn11.FormatInfo = Nothing
        Me.XEditTextBoxColumn11.HeaderText = "FEBRERO"
        Me.XEditTextBoxColumn11.ImageList = Nothing
        Me.XEditTextBoxColumn11.isReadOnly = False
        Me.XEditTextBoxColumn11.MappingName = "Febrero"
        Me.XEditTextBoxColumn11.MaxLength = 32767
        Me.XEditTextBoxColumn11.TabStop = True
        Me.XEditTextBoxColumn11.UseCustomCellFormat = False
        Me.XEditTextBoxColumn11.Width = 75
        '
        'XEditTextBoxColumn12
        '
        Me.XEditTextBoxColumn12.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.XEditTextBoxColumn12.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn12.Format = "###,###"
        Me.XEditTextBoxColumn12.FormatInfo = Nothing
        Me.XEditTextBoxColumn12.HeaderText = "MARZO"
        Me.XEditTextBoxColumn12.ImageList = Nothing
        Me.XEditTextBoxColumn12.isReadOnly = False
        Me.XEditTextBoxColumn12.MappingName = "Marzo"
        Me.XEditTextBoxColumn12.MaxLength = 32767
        Me.XEditTextBoxColumn12.TabStop = True
        Me.XEditTextBoxColumn12.UseCustomCellFormat = False
        Me.XEditTextBoxColumn12.Width = 75
        '
        'XEditTextBoxColumn13
        '
        Me.XEditTextBoxColumn13.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.XEditTextBoxColumn13.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn13.Format = "###,###"
        Me.XEditTextBoxColumn13.FormatInfo = Nothing
        Me.XEditTextBoxColumn13.HeaderText = "ABRIL"
        Me.XEditTextBoxColumn13.ImageList = Nothing
        Me.XEditTextBoxColumn13.isReadOnly = False
        Me.XEditTextBoxColumn13.MappingName = "Abril"
        Me.XEditTextBoxColumn13.MaxLength = 32767
        Me.XEditTextBoxColumn13.TabStop = True
        Me.XEditTextBoxColumn13.UseCustomCellFormat = False
        Me.XEditTextBoxColumn13.Width = 75
        '
        'XEditTextBoxColumn14
        '
        Me.XEditTextBoxColumn14.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.XEditTextBoxColumn14.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn14.Format = "###,###"
        Me.XEditTextBoxColumn14.FormatInfo = Nothing
        Me.XEditTextBoxColumn14.HeaderText = "MAYO"
        Me.XEditTextBoxColumn14.ImageList = Nothing
        Me.XEditTextBoxColumn14.isReadOnly = False
        Me.XEditTextBoxColumn14.MappingName = "Mayo"
        Me.XEditTextBoxColumn14.MaxLength = 32767
        Me.XEditTextBoxColumn14.TabStop = True
        Me.XEditTextBoxColumn14.UseCustomCellFormat = False
        Me.XEditTextBoxColumn14.Width = 75
        '
        'XEditTextBoxColumn16
        '
        Me.XEditTextBoxColumn16.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.XEditTextBoxColumn16.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn16.Format = "###,###"
        Me.XEditTextBoxColumn16.FormatInfo = Nothing
        Me.XEditTextBoxColumn16.HeaderText = "JUNIO"
        Me.XEditTextBoxColumn16.ImageList = Nothing
        Me.XEditTextBoxColumn16.isReadOnly = False
        Me.XEditTextBoxColumn16.MappingName = "Junio"
        Me.XEditTextBoxColumn16.MaxLength = 32767
        Me.XEditTextBoxColumn16.TabStop = True
        Me.XEditTextBoxColumn16.UseCustomCellFormat = False
        Me.XEditTextBoxColumn16.Width = 75
        '
        'XEditTextBoxColumn1
        '
        Me.XEditTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.XEditTextBoxColumn1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn1.Format = "###,###"
        Me.XEditTextBoxColumn1.FormatInfo = Nothing
        Me.XEditTextBoxColumn1.HeaderText = "JULIO"
        Me.XEditTextBoxColumn1.ImageList = Nothing
        Me.XEditTextBoxColumn1.isReadOnly = False
        Me.XEditTextBoxColumn1.MappingName = "Julio"
        Me.XEditTextBoxColumn1.MaxLength = 32767
        Me.XEditTextBoxColumn1.TabStop = True
        Me.XEditTextBoxColumn1.UseCustomCellFormat = False
        Me.XEditTextBoxColumn1.Width = 75
        '
        'XEditTextBoxColumn2
        '
        Me.XEditTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.XEditTextBoxColumn2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn2.Format = "###,###"
        Me.XEditTextBoxColumn2.FormatInfo = Nothing
        Me.XEditTextBoxColumn2.HeaderText = "AGOSTO"
        Me.XEditTextBoxColumn2.ImageList = Nothing
        Me.XEditTextBoxColumn2.isReadOnly = False
        Me.XEditTextBoxColumn2.MappingName = "agosto"
        Me.XEditTextBoxColumn2.MaxLength = 32767
        Me.XEditTextBoxColumn2.TabStop = True
        Me.XEditTextBoxColumn2.UseCustomCellFormat = False
        Me.XEditTextBoxColumn2.Width = 75
        '
        'XEditTextBoxColumn3
        '
        Me.XEditTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.XEditTextBoxColumn3.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn3.Format = "###,###"
        Me.XEditTextBoxColumn3.FormatInfo = Nothing
        Me.XEditTextBoxColumn3.HeaderText = "SEPTIEMBREi"
        Me.XEditTextBoxColumn3.ImageList = Nothing
        Me.XEditTextBoxColumn3.isReadOnly = False
        Me.XEditTextBoxColumn3.MappingName = "septiembre"
        Me.XEditTextBoxColumn3.MaxLength = 32767
        Me.XEditTextBoxColumn3.TabStop = True
        Me.XEditTextBoxColumn3.UseCustomCellFormat = False
        Me.XEditTextBoxColumn3.Width = 75
        '
        'XEditTextBoxColumn4
        '
        Me.XEditTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.XEditTextBoxColumn4.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn4.Format = "###,###"
        Me.XEditTextBoxColumn4.FormatInfo = Nothing
        Me.XEditTextBoxColumn4.HeaderText = "OCTUBRE"
        Me.XEditTextBoxColumn4.ImageList = Nothing
        Me.XEditTextBoxColumn4.isReadOnly = False
        Me.XEditTextBoxColumn4.MappingName = "Octubre"
        Me.XEditTextBoxColumn4.MaxLength = 32767
        Me.XEditTextBoxColumn4.TabStop = True
        Me.XEditTextBoxColumn4.UseCustomCellFormat = False
        Me.XEditTextBoxColumn4.Width = 75
        '
        'XEditTextBoxColumn5
        '
        Me.XEditTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.XEditTextBoxColumn5.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn5.Format = "###,###"
        Me.XEditTextBoxColumn5.FormatInfo = Nothing
        Me.XEditTextBoxColumn5.HeaderText = "NOVIEMBRE"
        Me.XEditTextBoxColumn5.ImageList = Nothing
        Me.XEditTextBoxColumn5.isReadOnly = False
        Me.XEditTextBoxColumn5.MappingName = "Noviembre"
        Me.XEditTextBoxColumn5.MaxLength = 32767
        Me.XEditTextBoxColumn5.TabStop = True
        Me.XEditTextBoxColumn5.UseCustomCellFormat = False
        Me.XEditTextBoxColumn5.Width = 75
        '
        'XEditTextBoxColumn6
        '
        Me.XEditTextBoxColumn6.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.XEditTextBoxColumn6.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn6.Format = "###,###"
        Me.XEditTextBoxColumn6.FormatInfo = Nothing
        Me.XEditTextBoxColumn6.HeaderText = "DICIEMBRE"
        Me.XEditTextBoxColumn6.ImageList = Nothing
        Me.XEditTextBoxColumn6.isReadOnly = False
        Me.XEditTextBoxColumn6.MappingName = "Diciembre"
        Me.XEditTextBoxColumn6.MaxLength = 32767
        Me.XEditTextBoxColumn6.TabStop = True
        Me.XEditTextBoxColumn6.UseCustomCellFormat = False
        Me.XEditTextBoxColumn6.Width = 75
        '
        'gColitem_code
        '
        Me.gColitem_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColitem_code.Format = ""
        Me.gColitem_code.FormatInfo = Nothing
        Me.gColitem_code.ImageList = Nothing
        Me.gColitem_code.isReadOnly = False
        Me.gColitem_code.MappingName = "item_code"
        Me.gColitem_code.MaxLength = 32767
        Me.gColitem_code.TabStop = True
        Me.gColitem_code.UseCustomCellFormat = False
        Me.gColitem_code.Width = 0
        '
        'gcolwhse_code
        '
        Me.gcolwhse_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gcolwhse_code.Format = ""
        Me.gcolwhse_code.FormatInfo = Nothing
        Me.gcolwhse_code.ImageList = Nothing
        Me.gcolwhse_code.isReadOnly = False
        Me.gcolwhse_code.MappingName = "whse_code"
        Me.gcolwhse_code.MaxLength = 32767
        Me.gcolwhse_code.TabStop = True
        Me.gcolwhse_code.UseCustomCellFormat = False
        Me.gcolwhse_code.Width = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Año:"
        '
        'xcbo_Ano
        '
        Me.xcbo_Ano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_Ano.Location = New System.Drawing.Point(40, 8)
        Me.xcbo_Ano.Name = "xcbo_Ano"
        Me.xcbo_Ano.Size = New System.Drawing.Size(121, 21)
        Me.xcbo_Ano.TabIndex = 6
        '
        'c_ivdocs02
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.btnCerrar
        Me.ClientSize = New System.Drawing.Size(1176, 566)
        Me.Controls.Add(Me.xcbo_Ano)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LibXGrid1)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "c_ivdocs02"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Movimientos"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ivstadism, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub c_ccdocs01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            With xcbo_Ano
                .Items.Clear()

                For i As Integer = 6 To 0 Step -1
                    .Items.Add((LibX.Data.Manager.Connection.GetDate.Year - i).ToString.Trim)
                Next
                .SelectedIndex = .Items.Count - 1
            End With

            LibXGrid1.footerOperations.add("Enero", "sum(Enero)", "1=1")
            LibXGrid1.footerOperations.add("Febrero", "sum(Febrero)", "1=1")
            LibXGrid1.footerOperations.add("Marzo", "sum(Marzo)", "1=1")
            LibXGrid1.footerOperations.add("Abril", "sum(Abril)", "1=1")
            LibXGrid1.footerOperations.add("Mayo", "sum(Mayo)", "1=1")
            LibXGrid1.footerOperations.add("Junio", "sum(Junio)", "1=1")
            LibXGrid1.footerOperations.add("Julio", "sum(Julio)", "1=1")
            LibXGrid1.footerOperations.add("Agosto", "sum(Agosto)", "1=1")
            LibXGrid1.footerOperations.add("Septiembre", "sum(Septiembre)", "1=1")
            LibXGrid1.footerOperations.add("Octubre", "sum(Octubre)", "1=1")
            LibXGrid1.footerOperations.add("Noviembre", "sum(Noviembre)", "1=1")
            LibXGrid1.footerOperations.add("Diciembre", "sum(Diciembre)", "1=1")

            If Not LibXConnector1.Parameters Is Nothing Then
                If Not LibX.IsNull(LibXConnector1.Parameters.Datos("where")) Then
                    LibXConnector1.ExecuteFind(LibXConnector1.Parameters.Datos("where"))
                End If
            End If

            LibXGrid1.getCurrentGridView.AllowDelete = False
            LibXGrid1.getCurrentGridView.AllowEdit = False
            LibXGrid1.getCurrentGridView.AllowNew = False

            LibXGrid1.refreshFooter()

        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub
    Private Sub ApplyFilter()
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub chk_facturas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ApplyFilter()
    End Sub

    Private Sub chk_devoluc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ApplyFilter()
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        Dim oParam As LibX.LibxPrgParams
        Dim WhereStmt As String
        Dim c_ivdocs As c_ivdocs01
        Try
            oParam = New LibX.LibxPrgParams
            c_ivdocs = New c_ivdocs01
            WhereStmt = "ivtranrd.item_code = '" & LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, gColitem_code) & _
                        "' and ivtranrd.whse_code = " & LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, gcolwhse_code) & _
                        " and ivtranrm.type_code = '" & LibXGrid1.GetValue(LibXGrid1.CurrentRowIndex, gcoltype_code) & "'"

            oParam.Datos.Add("where", WhereStmt)

            LibX.App.CurrentPrgParams = oParam

            c_ivdocs.ShowDialog()

            c_ivdocs = Nothing

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

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ApplyFilter()
    End Sub

    Private Sub chk_CompLocal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ApplyFilter()
    End Sub

    Private Sub chk_ajuste_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ApplyFilter()
    End Sub

    Private Sub chk_devfacturas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ApplyFilter()
    End Sub

    Private Sub LibXConnector1_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.XBeforeExecuteQueryEventArgs) Handles LibXConnector1.BeforeExecuteQuery
        Try
            If Me.xcbo_Ano.SelectedText.Trim <> "" Then
                e.AditionalWhere = "Ano = " & Me.xcbo_Ano.SelectedText.Trim
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub
End Class
