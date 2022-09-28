Imports LibX
Public Class g_ivcount03
    Inherits System.Windows.Forms.Form
    Dim WhDefault As Integer

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
    Friend WithEvents XTextBox1 As LibX.XTextBox
    Friend WithEvents XTextBox2 As LibX.XTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LibXDbSourceTable2 As LibX.LibXDbSourceTable
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnEjecutar As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents xdbivitemd As LibX.LibXDbSourceTable
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblLastClose As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents XTextBox3 As LibX.XTextBox
    Friend WithEvents LibXLookup2 As LibX.LibXLookup
    Friend WithEvents XTextBox5 As LibX.XTextBox
    Friend WithEvents LibXLookup3 As LibX.LibXLookup
    Friend WithEvents LibXLookup4 As LibX.LibXLookup
    Friend WithEvents XTextBox7 As LibX.XTextBox
    Friend WithEvents group_name As LibX.XTextBox
    Friend WithEvents sgroup_name As LibX.XTextBox
    Friend WithEvents brand_name As LibX.XTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LibXLookup1 As LibX.LibXLookup
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblCountNo As System.Windows.Forms.Label
    Friend WithEvents whse_name As LibX.XTextBox
    Friend WithEvents DataColumn21 As System.Data.DataColumn
    Friend WithEvents DataColumn22 As System.Data.DataColumn
    Friend WithEvents DataColumn23 As System.Data.DataColumn
    Friend WithEvents DataColumn24 As System.Data.DataColumn
    Friend WithEvents DataColumn31 As System.Data.DataColumn
    Friend WithEvents DataColumn32 As System.Data.DataColumn
    Friend WithEvents DataColumn33 As System.Data.DataColumn
    Friend WithEvents DataColumn35 As System.Data.DataColumn
    Friend WithEvents DataColumn36 As System.Data.DataColumn
    Friend WithEvents LibXLookup5 As LibX.LibXLookup
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LibXLookup6 As LibX.LibXLookup
    Friend WithEvents XTextBox9 As LibX.XTextBox
    Friend WithEvents prov_name As LibX.XTextBox
    Friend WithEvents DataColumn25 As System.Data.DataColumn
    Friend WithEvents DataColumn26 As System.Data.DataColumn
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents XTextBox8 As LibX.XTextBox
    Friend WithEvents ivitemm As System.Data.DataTable
    Friend WithEvents DataColumn29 As System.Data.DataColumn
    Friend WithEvents xdbivcounte As LibX.LibXDbSourceTable
    Friend WithEvents xdbivcountd As LibX.LibXDbSourceTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
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
    Friend WithEvents ivcounte As System.Data.DataTable
    Friend WithEvents ivcountd As System.Data.DataTable
    Friend WithEvents DataColumn27 As System.Data.DataColumn
    Friend WithEvents txtitem_name As LibX.XTextBox
    Friend WithEvents xtxtprov_code As LibX.XTextBox
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents chk_incluir_descontinuados As System.Windows.Forms.CheckBox
    Friend WithEvents DataColumn28 As System.Data.DataColumn
    Friend WithEvents xtxt_whse_code As LibX.XTextBox
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents xtxt_onhand As LibX.XTextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Chk_mov As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.DataSet1 = New System.Data.DataSet
        Me.ivitemm = New System.Data.DataTable
        Me.DataColumn21 = New System.Data.DataColumn
        Me.DataColumn22 = New System.Data.DataColumn
        Me.DataColumn23 = New System.Data.DataColumn
        Me.DataColumn24 = New System.Data.DataColumn
        Me.DataColumn31 = New System.Data.DataColumn
        Me.DataColumn32 = New System.Data.DataColumn
        Me.DataColumn33 = New System.Data.DataColumn
        Me.DataColumn35 = New System.Data.DataColumn
        Me.DataColumn36 = New System.Data.DataColumn
        Me.DataColumn25 = New System.Data.DataColumn
        Me.DataColumn26 = New System.Data.DataColumn
        Me.DataColumn29 = New System.Data.DataColumn
        Me.DataColumn27 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.ivcounte = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn8 = New System.Data.DataColumn
        Me.ivcountd = New System.Data.DataTable
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
        Me.DataColumn28 = New System.Data.DataColumn
        Me.xdbivitemd = New LibX.LibXDbSourceTable
        Me.xdbivcounte = New LibX.LibXDbSourceTable
        Me.xdbivcountd = New LibX.LibXDbSourceTable
        Me.Label2 = New System.Windows.Forms.Label
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnEjecutar = New System.Windows.Forms.Button
        Me.btnImprimir = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblLastClose = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.XTextBox3 = New LibX.XTextBox
        Me.group_name = New LibX.XTextBox
        Me.LibXLookup2 = New LibX.LibXLookup
        Me.XTextBox5 = New LibX.XTextBox
        Me.sgroup_name = New LibX.XTextBox
        Me.LibXLookup3 = New LibX.LibXLookup
        Me.LibXLookup4 = New LibX.LibXLookup
        Me.XTextBox7 = New LibX.XTextBox
        Me.brand_name = New LibX.XTextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.LibXLookup1 = New LibX.LibXLookup
        Me.xtxt_whse_code = New LibX.XTextBox
        Me.whse_name = New LibX.XTextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.lblCountNo = New System.Windows.Forms.Label
        Me.LibXLookup5 = New LibX.LibXLookup
        Me.xtxtprov_code = New LibX.XTextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.prov_name = New LibX.XTextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.LibXLookup6 = New LibX.LibXLookup
        Me.XTextBox9 = New LibX.XTextBox
        Me.txtitem_name = New LibX.XTextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.XTextBox8 = New LibX.XTextBox
        Me.chk_incluir_descontinuados = New System.Windows.Forms.CheckBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.xtxt_onhand = New LibX.XTextBox
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Chk_mov = New System.Windows.Forms.CheckBox
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ivitemm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ivcounte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ivcountd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'LibXConnector1
        '
        Me.LibXConnector1.AllowDelete = False
        Me.LibXConnector1.AllowEdit = False
        Me.LibXConnector1.AllowNew = False
        Me.LibXConnector1.AllowPrint = True
        Me.LibXConnector1.AllowQuery = True
        Me.LibXConnector1.BOF = False
        Me.LibXConnector1.CanExecuteFind = True
        Me.LibXConnector1.DataMember = "ivitemm"
        Me.LibXConnector1.DataSource = Me.DataSet1
        Me.LibXConnector1.EOF = False
        Me.LibXConnector1.HandledRowsFill = True
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
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.xdbivitemd, Me.xdbivcounte, Me.xdbivcountd})
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
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.ivitemm, Me.ivcounte, Me.ivcountd})
        '
        'ivitemm
        '
        Me.ivitemm.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn35, Me.DataColumn36, Me.DataColumn25, Me.DataColumn26, Me.DataColumn29, Me.DataColumn27, Me.DataColumn6})
        Me.ivitemm.TableName = "ivitemm"
        '
        'DataColumn21
        '
        Me.DataColumn21.AllowDBNull = False
        Me.DataColumn21.ColumnName = "item_code"
        Me.DataColumn21.MaxLength = 10
        '
        'DataColumn22
        '
        Me.DataColumn22.AllowDBNull = False
        Me.DataColumn22.ColumnName = "item_name"
        Me.DataColumn22.MaxLength = 100
        '
        'DataColumn23
        '
        Me.DataColumn23.AllowDBNull = False
        Me.DataColumn23.ColumnName = "group_code"
        Me.DataColumn23.DataType = GetType(System.Int32)
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "sgroup_code"
        Me.DataColumn24.DataType = GetType(System.Int32)
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "brand_code"
        Me.DataColumn31.DataType = GetType(System.Int32)
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "loc_row"
        Me.DataColumn32.MaxLength = 20
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "loc_col"
        Me.DataColumn33.MaxLength = 20
        '
        'DataColumn35
        '
        Me.DataColumn35.AllowDBNull = False
        Me.DataColumn35.ColumnName = "whse_code"
        Me.DataColumn35.DataType = GetType(System.Int32)
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "existencia"
        Me.DataColumn36.DataType = GetType(System.Int32)
        '
        'DataColumn25
        '
        Me.DataColumn25.AllowDBNull = False
        Me.DataColumn25.ColumnName = "prov_code"
        Me.DataColumn25.DataType = GetType(System.Int32)
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "frizado_inv"
        Me.DataColumn26.DataType = GetType(System.Int16)
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "estante"
        Me.DataColumn29.MaxLength = 20
        '
        'DataColumn27
        '
        Me.DataColumn27.AllowDBNull = False
        Me.DataColumn27.ColumnName = "unit_code"
        Me.DataColumn27.MaxLength = 4
        '
        'DataColumn6
        '
        Me.DataColumn6.AllowDBNull = False
        Me.DataColumn6.ColumnName = "factor"
        Me.DataColumn6.DataType = GetType(System.Decimal)
        '
        'ivcounte
        '
        Me.ivcounte.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn8})
        Me.ivcounte.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"count_number"}, True)})
        Me.ivcounte.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn1}
        Me.ivcounte.TableName = "ivcounte"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.AutoIncrement = True
        Me.DataColumn1.ColumnName = "count_number"
        Me.DataColumn1.DataType = GetType(System.Int32)
        Me.DataColumn1.ReadOnly = True
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "prov_code"
        Me.DataColumn2.DataType = GetType(System.Int32)
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "whse_code"
        Me.DataColumn3.DataType = GetType(System.Int32)
        '
        'DataColumn4
        '
        Me.DataColumn4.AllowDBNull = False
        Me.DataColumn4.ColumnName = "count_date"
        Me.DataColumn4.DataType = GetType(System.DateTime)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "count_desc"
        Me.DataColumn5.MaxLength = 60
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "userid"
        Me.DataColumn8.MaxLength = 20
        '
        'ivcountd
        '
        Me.ivcountd.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn28})
        Me.ivcountd.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"count_number", "PageNo", "line_no"}, True)})
        Me.ivcountd.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn9, Me.DataColumn19, Me.DataColumn20}
        Me.ivcountd.TableName = "ivcountd"
        '
        'DataColumn9
        '
        Me.DataColumn9.AllowDBNull = False
        Me.DataColumn9.ColumnName = "count_number"
        Me.DataColumn9.DataType = GetType(System.Int32)
        '
        'DataColumn10
        '
        Me.DataColumn10.AllowDBNull = False
        Me.DataColumn10.ColumnName = "unit_code"
        Me.DataColumn10.MaxLength = 5
        '
        'DataColumn11
        '
        Me.DataColumn11.AllowDBNull = False
        Me.DataColumn11.ColumnName = "item_code"
        Me.DataColumn11.MaxLength = 10
        '
        'DataColumn12
        '
        Me.DataColumn12.AllowDBNull = False
        Me.DataColumn12.ColumnName = "whse_code"
        Me.DataColumn12.DataType = GetType(System.Int32)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "count_qty"
        Me.DataColumn13.DataType = GetType(System.Int32)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "loc_row"
        Me.DataColumn14.MaxLength = 20
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "loc_bin"
        Me.DataColumn15.MaxLength = 20
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "estante"
        Me.DataColumn16.MaxLength = 20
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "qty_on_hand"
        Me.DataColumn17.MaxLength = 18
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "factor"
        Me.DataColumn18.DataType = GetType(System.Decimal)
        '
        'DataColumn19
        '
        Me.DataColumn19.AllowDBNull = False
        Me.DataColumn19.ColumnName = "PageNo"
        Me.DataColumn19.DataType = GetType(System.Int32)
        '
        'DataColumn20
        '
        Me.DataColumn20.AllowDBNull = False
        Me.DataColumn20.ColumnName = "line_no"
        Me.DataColumn20.DataType = GetType(System.Int32)
        '
        'DataColumn28
        '
        Me.DataColumn28.AllowDBNull = False
        Me.DataColumn28.ColumnName = "count_status"
        Me.DataColumn28.DataType = GetType(System.Int32)
        '
        'xdbivitemd
        '
        Me.xdbivitemd.AllowDelete = True
        Me.xdbivitemd.AllowEdit = True
        Me.xdbivitemd.AllowNew = True
        Me.xdbivitemd.AutoIncrementSerial = False
        Me.xdbivitemd.CustomDbUpdate = False
        Me.xdbivitemd.DeleteOrder = 0
        Me.xdbivitemd.FillOnQuery = True
        Me.xdbivitemd.FillOnRowChange = False
        Me.xdbivitemd.HeaderIsOnGrid = False
        Me.xdbivitemd.InnerJon = True
        Me.xdbivitemd.InsertOrder = 0
        Me.xdbivitemd.IsDetail = False
        Me.xdbivitemd.KeyFields = Nothing
        Me.xdbivitemd.LineColName = Nothing
        Me.xdbivitemd.MasterDetailRelation = Nothing
        Me.xdbivitemd.MasterTableName = Nothing
        Me.xdbivitemd.SerialColumnName = Nothing
        Me.xdbivitemd.Sort = Nothing
        Me.xdbivitemd.Source = New String() {"select ivitemm.prov_code,ivitemm.item_code,item_name,group_code,sgroup_code,brand" & _
        "_code,", " ivitemd.loc_row,loc_col,estante,whse_code,existencia,frizado_inv,ivitemm.unit_co" & _
        "de,ivunitv.factor", "from ivitemm inner join ivitemd ", "          on ivitemm.item_code = ivitemd.item_code", "       inner join ivunitv", "          on ivitemm.item_code = ivunitv.item_code", "       and ivitemm.unit_code = ivunitv.unit_code", "order by ivitemm.item_name"}
        Me.xdbivitemd.TableName = "ivitemm"
        Me.xdbivitemd.UpdateOrder = 0
        Me.xdbivitemd.UseRowRetrieve = False
        '
        'xdbivcounte
        '
        Me.xdbivcounte.AllowDelete = True
        Me.xdbivcounte.AllowEdit = True
        Me.xdbivcounte.AllowNew = True
        Me.xdbivcounte.AutoIncrementSerial = False
        Me.xdbivcounte.CustomDbUpdate = False
        Me.xdbivcounte.DeleteOrder = 0
        Me.xdbivcounte.FillOnQuery = True
        Me.xdbivcounte.FillOnRowChange = False
        Me.xdbivcounte.HeaderIsOnGrid = False
        Me.xdbivcounte.InnerJon = True
        Me.xdbivcounte.InsertOrder = 0
        Me.xdbivcounte.IsDetail = False
        Me.xdbivcounte.KeyFields = Nothing
        Me.xdbivcounte.LineColName = Nothing
        Me.xdbivcounte.MasterDetailRelation = Nothing
        Me.xdbivcounte.MasterTableName = Nothing
        Me.xdbivcounte.SerialColumnName = "count_number"
        Me.xdbivcounte.Sort = Nothing
        Me.xdbivcounte.Source = Nothing
        Me.xdbivcounte.TableName = "ivcounte"
        Me.xdbivcounte.UpdateOrder = 0
        Me.xdbivcounte.UseRowRetrieve = False
        '
        'xdbivcountd
        '
        Me.xdbivcountd.AllowDelete = True
        Me.xdbivcountd.AllowEdit = True
        Me.xdbivcountd.AllowNew = True
        Me.xdbivcountd.AutoIncrementSerial = False
        Me.xdbivcountd.CustomDbUpdate = False
        Me.xdbivcountd.DeleteOrder = 0
        Me.xdbivcountd.FillOnQuery = True
        Me.xdbivcountd.FillOnRowChange = False
        Me.xdbivcountd.HeaderIsOnGrid = False
        Me.xdbivcountd.InnerJon = True
        Me.xdbivcountd.InsertOrder = 0
        Me.xdbivcountd.IsDetail = False
        Me.xdbivcountd.KeyFields = Nothing
        Me.xdbivcountd.LineColName = Nothing
        Me.xdbivcountd.MasterDetailRelation = Nothing
        Me.xdbivcountd.MasterTableName = Nothing
        Me.xdbivcountd.SerialColumnName = Nothing
        Me.xdbivcountd.Sort = Nothing
        Me.xdbivcountd.Source = Nothing
        Me.xdbivcountd.TableName = "ivcountd"
        Me.xdbivcountd.UpdateOrder = 0
        Me.xdbivcountd.UseRowRetrieve = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Location = New System.Drawing.Point(33, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Sub-grupo:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.LibXDbSourceTable2.Source = Nothing
        Me.LibXDbSourceTable2.TableName = Nothing
        Me.LibXDbSourceTable2.UpdateOrder = 0
        Me.LibXDbSourceTable2.UseRowRetrieve = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Controls.Add(Me.btnEjecutar)
        Me.GroupBox1.Controls.Add(Me.btnImprimir)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(496, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(88, 240)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnClose.Location = New System.Drawing.Point(8, 80)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(72, 32)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Cerrar"
        '
        'btnEjecutar
        '
        Me.btnEjecutar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnEjecutar.Location = New System.Drawing.Point(8, 14)
        Me.btnEjecutar.Name = "btnEjecutar"
        Me.btnEjecutar.Size = New System.Drawing.Size(72, 32)
        Me.btnEjecutar.TabIndex = 0
        Me.btnEjecutar.Text = "Generar"
        '
        'btnImprimir
        '
        Me.btnImprimir.Enabled = False
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnImprimir.Location = New System.Drawing.Point(8, 48)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(72, 32)
        Me.btnImprimir.TabIndex = 1
        Me.btnImprimir.Text = "Imprimir"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(594, 48)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "GENERAR HOJA DE CONTEO FISICO"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.ProgressBar1)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox2.Location = New System.Drawing.Point(8, 296)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(576, 48)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Progreso"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(8, 16)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(560, 23)
        Me.ProgressBar1.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(280, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Ultimo Conteo:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblLastClose
        '
        Me.lblLastClose.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLastClose.Location = New System.Drawing.Point(368, 80)
        Me.lblLastClose.Name = "lblLastClose"
        Me.lblLastClose.Size = New System.Drawing.Size(96, 20)
        Me.lblLastClose.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Location = New System.Drawing.Point(54, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Grupo:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Location = New System.Drawing.Point(54, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Marca:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'XTextBox3
        '
        Me.XTextBox3.AcceptsReturn = True
        Me.XTextBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.XTextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemm.group_code"))
        Me.XTextBox3.EditInitialValue = Nothing
        Me.XTextBox3.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox3.FieldDescription = ""
        Me.XTextBox3.FindInitialValue = Nothing
        Me.XTextBox3.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox3.IgnoreRequiered = False
        Me.XTextBox3.Location = New System.Drawing.Point(104, 128)
        Me.XTextBox3.Name = "XTextBox3"
        Me.XTextBox3.NewInitialValue = Nothing
        Me.XTextBox3.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox3.Requiered = False
        Me.XTextBox3.Size = New System.Drawing.Size(48, 20)
        Me.XTextBox3.StatusBarPanelDescripcion = Nothing
        Me.XTextBox3.TabIndex = 1
        Me.XTextBox3.Text = ""
        '
        'group_name
        '
        Me.group_name.AcceptsReturn = True
        Me.group_name.EditInitialValue = Nothing
        Me.group_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.group_name.FieldDescription = ""
        Me.group_name.FindInitialValue = Nothing
        Me.group_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.group_name.IgnoreRequiered = False
        Me.group_name.Location = New System.Drawing.Point(160, 128)
        Me.group_name.Name = "group_name"
        Me.group_name.NewInitialValue = Nothing
        Me.group_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.group_name.ReadOnly = True
        Me.group_name.Requiered = False
        Me.group_name.Size = New System.Drawing.Size(288, 20)
        Me.group_name.StatusBarPanelDescripcion = Nothing
        Me.group_name.TabIndex = 1
        Me.group_name.TabStop = False
        Me.group_name.Text = ""
        '
        'LibXLookup2
        '
        Me.LibXLookup2.AlternateFieldSearch = Nothing
        Me.LibXLookup2.BeginCheck = False
        Me.LibXLookup2.CheckText = Nothing
        Me.LibXLookup2.ComboMode = False
        Me.LibXLookup2.DataMember = Nothing
        Me.LibXLookup2.DataSource = Me.LibXConnector1
        Me.LibXLookup2.DestParameters = New String() {"group_code=group_code", "group_name=group_name"}
        Me.LibXLookup2.FilterField = Nothing
        Me.LibXLookup2.IgnoreFindInBrowseMode = False
        Me.LibXLookup2.isCanceled = False
        Me.LibXLookup2.Location = New System.Drawing.Point(448, 128)
        Me.LibXLookup2.LookCaption = "Grupos"
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
        Me.LibXLookup2.SrcParameters = New String() {"group_code=group_code"}
        Me.LibXLookup2.TabIndex = 14
        Me.LibXLookup2.TableName = "ivgroupm"
        Me.LibXLookup2.TabStop = False
        Me.LibXLookup2.UseCopyConnection = False
        Me.LibXLookup2.UseRowRetrieveEvents = False
        Me.LibXLookup2.UseTab = False
        Me.LibXLookup2.VisParameters = New String() {"Código=group_code", "Descripción=group_name"}
        Me.LibXLookup2.WhereCondition = Nothing
        Me.LibXLookup2.WhereParameters = Nothing
        '
        'XTextBox5
        '
        Me.XTextBox5.AcceptsReturn = True
        Me.XTextBox5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.XTextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemm.sgroup_code"))
        Me.XTextBox5.EditInitialValue = Nothing
        Me.XTextBox5.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox5.FieldDescription = ""
        Me.XTextBox5.FindInitialValue = Nothing
        Me.XTextBox5.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox5.IgnoreRequiered = False
        Me.XTextBox5.Location = New System.Drawing.Point(104, 152)
        Me.XTextBox5.Name = "XTextBox5"
        Me.XTextBox5.NewInitialValue = Nothing
        Me.XTextBox5.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox5.Requiered = False
        Me.XTextBox5.Size = New System.Drawing.Size(48, 20)
        Me.XTextBox5.StatusBarPanelDescripcion = Nothing
        Me.XTextBox5.TabIndex = 2
        Me.XTextBox5.Text = ""
        '
        'sgroup_name
        '
        Me.sgroup_name.AcceptsReturn = True
        Me.sgroup_name.EditInitialValue = Nothing
        Me.sgroup_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.sgroup_name.FieldDescription = ""
        Me.sgroup_name.FindInitialValue = Nothing
        Me.sgroup_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.sgroup_name.IgnoreRequiered = False
        Me.sgroup_name.Location = New System.Drawing.Point(160, 152)
        Me.sgroup_name.Name = "sgroup_name"
        Me.sgroup_name.NewInitialValue = Nothing
        Me.sgroup_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.sgroup_name.ReadOnly = True
        Me.sgroup_name.Requiered = False
        Me.sgroup_name.Size = New System.Drawing.Size(288, 20)
        Me.sgroup_name.StatusBarPanelDescripcion = Nothing
        Me.sgroup_name.TabIndex = 12
        Me.sgroup_name.TabStop = False
        Me.sgroup_name.Text = ""
        '
        'LibXLookup3
        '
        Me.LibXLookup3.AlternateFieldSearch = Nothing
        Me.LibXLookup3.BeginCheck = False
        Me.LibXLookup3.CheckText = Nothing
        Me.LibXLookup3.ComboMode = False
        Me.LibXLookup3.DataMember = Nothing
        Me.LibXLookup3.DataSource = Me.LibXConnector1
        Me.LibXLookup3.DestParameters = New String() {"sgroup_code=sgroup_code", "sgroup_name=sgroup_name"}
        Me.LibXLookup3.FilterField = Nothing
        Me.LibXLookup3.IgnoreFindInBrowseMode = False
        Me.LibXLookup3.isCanceled = False
        Me.LibXLookup3.Location = New System.Drawing.Point(448, 152)
        Me.LibXLookup3.LookCaption = "Sub Grupos"
        Me.LibXLookup3.Name = "LibXLookup3"
        Me.LibXLookup3.PopupSize = New System.Drawing.Size(0, 0)
        Me.LibXLookup3.ShowFilter = True
        Me.LibXLookup3.ShowMessageNotFound = True
        Me.LibXLookup3.ShowWarning = False
        Me.LibXLookup3.Size = New System.Drawing.Size(16, 20)
        Me.LibXLookup3.SizesColumns = Nothing
        Me.LibXLookup3.SizesColumnsTab = Nothing
        Me.LibXLookup3.SqlString = Nothing
        Me.LibXLookup3.SQLTab = Nothing
        Me.LibXLookup3.SrcParameters = New String() {"sgroup_code=sgroup_code"}
        Me.LibXLookup3.TabIndex = 14
        Me.LibXLookup3.TableName = "ivsgroupm"
        Me.LibXLookup3.TabStop = False
        Me.LibXLookup3.UseCopyConnection = False
        Me.LibXLookup3.UseRowRetrieveEvents = False
        Me.LibXLookup3.UseTab = False
        Me.LibXLookup3.VisParameters = New String() {"Código=sgroup_code", "Descripción=sgroup_name"}
        Me.LibXLookup3.WhereCondition = Nothing
        Me.LibXLookup3.WhereParameters = Nothing
        '
        'LibXLookup4
        '
        Me.LibXLookup4.AlternateFieldSearch = Nothing
        Me.LibXLookup4.BeginCheck = False
        Me.LibXLookup4.CheckText = Nothing
        Me.LibXLookup4.ComboMode = False
        Me.LibXLookup4.DataMember = Nothing
        Me.LibXLookup4.DataSource = Me.LibXConnector1
        Me.LibXLookup4.DestParameters = New String() {"brand_code=brand_code", "brand_name=brand_name"}
        Me.LibXLookup4.FilterField = Nothing
        Me.LibXLookup4.IgnoreFindInBrowseMode = False
        Me.LibXLookup4.isCanceled = False
        Me.LibXLookup4.Location = New System.Drawing.Point(448, 176)
        Me.LibXLookup4.LookCaption = "Marcas"
        Me.LibXLookup4.Name = "LibXLookup4"
        Me.LibXLookup4.PopupSize = New System.Drawing.Size(0, 0)
        Me.LibXLookup4.ShowFilter = True
        Me.LibXLookup4.ShowMessageNotFound = True
        Me.LibXLookup4.ShowWarning = False
        Me.LibXLookup4.Size = New System.Drawing.Size(16, 20)
        Me.LibXLookup4.SizesColumns = Nothing
        Me.LibXLookup4.SizesColumnsTab = Nothing
        Me.LibXLookup4.SqlString = Nothing
        Me.LibXLookup4.SQLTab = Nothing
        Me.LibXLookup4.SrcParameters = New String() {"brand_code=brand_code"}
        Me.LibXLookup4.TabIndex = 14
        Me.LibXLookup4.TableName = "ivbrandm"
        Me.LibXLookup4.TabStop = False
        Me.LibXLookup4.UseCopyConnection = False
        Me.LibXLookup4.UseRowRetrieveEvents = False
        Me.LibXLookup4.UseTab = False
        Me.LibXLookup4.VisParameters = New String() {"Código=brand_code", "Descripción=brand_name"}
        Me.LibXLookup4.WhereCondition = Nothing
        Me.LibXLookup4.WhereParameters = Nothing
        '
        'XTextBox7
        '
        Me.XTextBox7.AcceptsReturn = True
        Me.XTextBox7.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.XTextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemm.brand_code"))
        Me.XTextBox7.EditInitialValue = Nothing
        Me.XTextBox7.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox7.FieldDescription = ""
        Me.XTextBox7.FindInitialValue = Nothing
        Me.XTextBox7.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox7.IgnoreRequiered = False
        Me.XTextBox7.Location = New System.Drawing.Point(104, 176)
        Me.XTextBox7.Name = "XTextBox7"
        Me.XTextBox7.NewInitialValue = Nothing
        Me.XTextBox7.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox7.Requiered = False
        Me.XTextBox7.Size = New System.Drawing.Size(48, 20)
        Me.XTextBox7.StatusBarPanelDescripcion = Nothing
        Me.XTextBox7.TabIndex = 3
        Me.XTextBox7.Text = ""
        '
        'brand_name
        '
        Me.brand_name.AcceptsReturn = True
        Me.brand_name.EditInitialValue = Nothing
        Me.brand_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.brand_name.FieldDescription = ""
        Me.brand_name.FindInitialValue = Nothing
        Me.brand_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.brand_name.IgnoreRequiered = False
        Me.brand_name.Location = New System.Drawing.Point(160, 176)
        Me.brand_name.Name = "brand_name"
        Me.brand_name.NewInitialValue = Nothing
        Me.brand_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.brand_name.ReadOnly = True
        Me.brand_name.Requiered = False
        Me.brand_name.Size = New System.Drawing.Size(288, 20)
        Me.brand_name.StatusBarPanelDescripcion = Nothing
        Me.brand_name.TabIndex = 12
        Me.brand_name.TabStop = False
        Me.brand_name.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label8.Location = New System.Drawing.Point(42, 200)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 16)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Almacén:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LibXLookup1
        '
        Me.LibXLookup1.AlternateFieldSearch = Nothing
        Me.LibXLookup1.BeginCheck = False
        Me.LibXLookup1.CheckText = Nothing
        Me.LibXLookup1.ComboMode = False
        Me.LibXLookup1.DataMember = Nothing
        Me.LibXLookup1.DataSource = Me.LibXConnector1
        Me.LibXLookup1.DestParameters = New String() {"whse_code=whse_code", "whse_name=whse_name"}
        Me.LibXLookup1.FilterField = Nothing
        Me.LibXLookup1.IgnoreFindInBrowseMode = False
        Me.LibXLookup1.isCanceled = False
        Me.LibXLookup1.Location = New System.Drawing.Point(448, 200)
        Me.LibXLookup1.LookCaption = "Almacenes"
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
        Me.LibXLookup1.TabIndex = 14
        Me.LibXLookup1.TableName = "ivwhsem"
        Me.LibXLookup1.TabStop = False
        Me.LibXLookup1.UseCopyConnection = False
        Me.LibXLookup1.UseRowRetrieveEvents = False
        Me.LibXLookup1.UseTab = False
        Me.LibXLookup1.VisParameters = New String() {"Código=whse_code", "Descripción=whse_name"}
        Me.LibXLookup1.WhereCondition = Nothing
        Me.LibXLookup1.WhereParameters = Nothing
        '
        'xtxt_whse_code
        '
        Me.xtxt_whse_code.AcceptsReturn = True
        Me.xtxt_whse_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xtxt_whse_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemm.whse_code"))
        Me.xtxt_whse_code.EditInitialValue = Nothing
        Me.xtxt_whse_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_whse_code.FieldDescription = ""
        Me.xtxt_whse_code.FindInitialValue = ""
        Me.xtxt_whse_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_whse_code.IgnoreRequiered = False
        Me.xtxt_whse_code.Location = New System.Drawing.Point(104, 200)
        Me.xtxt_whse_code.Name = "xtxt_whse_code"
        Me.xtxt_whse_code.NewInitialValue = Nothing
        Me.xtxt_whse_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_whse_code.Requiered = False
        Me.xtxt_whse_code.Size = New System.Drawing.Size(48, 20)
        Me.xtxt_whse_code.StatusBarPanelDescripcion = Nothing
        Me.xtxt_whse_code.TabIndex = 4
        Me.xtxt_whse_code.Text = ""
        '
        'whse_name
        '
        Me.whse_name.AcceptsReturn = True
        Me.whse_name.EditInitialValue = Nothing
        Me.whse_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.whse_name.FieldDescription = ""
        Me.whse_name.FindInitialValue = Nothing
        Me.whse_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.whse_name.IgnoreRequiered = False
        Me.whse_name.Location = New System.Drawing.Point(160, 200)
        Me.whse_name.Name = "whse_name"
        Me.whse_name.NewInitialValue = Nothing
        Me.whse_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.whse_name.ReadOnly = True
        Me.whse_name.Requiered = False
        Me.whse_name.Size = New System.Drawing.Size(288, 20)
        Me.whse_name.StatusBarPanelDescripcion = Nothing
        Me.whse_name.TabIndex = 12
        Me.whse_name.TabStop = False
        Me.whse_name.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label9.Location = New System.Drawing.Point(6, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 16)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Conteo Número:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCountNo
        '
        Me.lblCountNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCountNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountNo.Location = New System.Drawing.Point(104, 80)
        Me.lblCountNo.Name = "lblCountNo"
        Me.lblCountNo.Size = New System.Drawing.Size(96, 20)
        Me.lblCountNo.TabIndex = 11
        '
        'LibXLookup5
        '
        Me.LibXLookup5.AlternateFieldSearch = Nothing
        Me.LibXLookup5.BeginCheck = False
        Me.LibXLookup5.CheckText = Nothing
        Me.LibXLookup5.ComboMode = False
        Me.LibXLookup5.DataMember = Nothing
        Me.LibXLookup5.DataSource = Me.LibXConnector1
        Me.LibXLookup5.DestParameters = New String() {"prov_code=prov_code", "prov_name=prov_name"}
        Me.LibXLookup5.FilterField = Nothing
        Me.LibXLookup5.IgnoreFindInBrowseMode = False
        Me.LibXLookup5.isCanceled = False
        Me.LibXLookup5.Location = New System.Drawing.Point(448, 104)
        Me.LibXLookup5.LookCaption = "Grupos"
        Me.LibXLookup5.Name = "LibXLookup5"
        Me.LibXLookup5.PopupSize = New System.Drawing.Size(0, 0)
        Me.LibXLookup5.ShowFilter = True
        Me.LibXLookup5.ShowMessageNotFound = True
        Me.LibXLookup5.ShowWarning = False
        Me.LibXLookup5.Size = New System.Drawing.Size(16, 20)
        Me.LibXLookup5.SizesColumns = Nothing
        Me.LibXLookup5.SizesColumnsTab = Nothing
        Me.LibXLookup5.SqlString = Nothing
        Me.LibXLookup5.SQLTab = Nothing
        Me.LibXLookup5.SrcParameters = New String() {"prov_code=prov_code"}
        Me.LibXLookup5.TabIndex = 18
        Me.LibXLookup5.TableName = "cpprovm"
        Me.LibXLookup5.TabStop = False
        Me.LibXLookup5.UseCopyConnection = False
        Me.LibXLookup5.UseRowRetrieveEvents = False
        Me.LibXLookup5.UseTab = False
        Me.LibXLookup5.VisParameters = New String() {"Código=prov_code", "Nombre=prov_name"}
        Me.LibXLookup5.WhereCondition = Nothing
        Me.LibXLookup5.WhereParameters = Nothing
        '
        'xtxtprov_code
        '
        Me.xtxtprov_code.AcceptsReturn = True
        Me.xtxtprov_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xtxtprov_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemm.prov_code"))
        Me.xtxtprov_code.EditInitialValue = Nothing
        Me.xtxtprov_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxtprov_code.FieldDescription = ""
        Me.xtxtprov_code.FindInitialValue = Nothing
        Me.xtxtprov_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxtprov_code.IgnoreRequiered = False
        Me.xtxtprov_code.Location = New System.Drawing.Point(104, 104)
        Me.xtxtprov_code.Name = "xtxtprov_code"
        Me.xtxtprov_code.NewInitialValue = Nothing
        Me.xtxtprov_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxtprov_code.Requiered = False
        Me.xtxtprov_code.Size = New System.Drawing.Size(48, 20)
        Me.xtxtprov_code.StatusBarPanelDescripcion = Nothing
        Me.xtxtprov_code.TabIndex = 0
        Me.xtxtprov_code.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label6.Location = New System.Drawing.Point(44, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 16)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Suplidor:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'prov_name
        '
        Me.prov_name.AcceptsReturn = True
        Me.prov_name.EditInitialValue = Nothing
        Me.prov_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.prov_name.FieldDescription = ""
        Me.prov_name.FindInitialValue = Nothing
        Me.prov_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.prov_name.IgnoreRequiered = False
        Me.prov_name.Location = New System.Drawing.Point(160, 104)
        Me.prov_name.Name = "prov_name"
        Me.prov_name.NewInitialValue = Nothing
        Me.prov_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.prov_name.ReadOnly = True
        Me.prov_name.Requiered = False
        Me.prov_name.Size = New System.Drawing.Size(288, 20)
        Me.prov_name.StatusBarPanelDescripcion = Nothing
        Me.prov_name.TabIndex = 16
        Me.prov_name.TabStop = False
        Me.prov_name.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label7.Location = New System.Drawing.Point(40, 224)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 16)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Producto:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LibXLookup6
        '
        Me.LibXLookup6.AlternateFieldSearch = Nothing
        Me.LibXLookup6.BeginCheck = False
        Me.LibXLookup6.CheckText = Nothing
        Me.LibXLookup6.ComboMode = False
        Me.LibXLookup6.DataMember = Nothing
        Me.LibXLookup6.DataSource = Me.LibXConnector1
        Me.LibXLookup6.DestParameters = New String() {"item_code=item_code", "txtitem_name=item_name"}
        Me.LibXLookup6.FilterField = Nothing
        Me.LibXLookup6.IgnoreFindInBrowseMode = False
        Me.LibXLookup6.isCanceled = False
        Me.LibXLookup6.Location = New System.Drawing.Point(448, 224)
        Me.LibXLookup6.LookCaption = "ivitemm"
        Me.LibXLookup6.Name = "LibXLookup6"
        Me.LibXLookup6.PopupSize = New System.Drawing.Size(0, 0)
        Me.LibXLookup6.ShowFilter = True
        Me.LibXLookup6.ShowMessageNotFound = True
        Me.LibXLookup6.ShowWarning = False
        Me.LibXLookup6.Size = New System.Drawing.Size(16, 20)
        Me.LibXLookup6.SizesColumns = Nothing
        Me.LibXLookup6.SizesColumnsTab = Nothing
        Me.LibXLookup6.SqlString = Nothing
        Me.LibXLookup6.SQLTab = Nothing
        Me.LibXLookup6.SrcParameters = New String() {"item_code=item_code"}
        Me.LibXLookup6.TabIndex = 22
        Me.LibXLookup6.TableName = "ivitemm"
        Me.LibXLookup6.TabStop = False
        Me.LibXLookup6.UseCopyConnection = False
        Me.LibXLookup6.UseRowRetrieveEvents = False
        Me.LibXLookup6.UseTab = False
        Me.LibXLookup6.VisParameters = New String() {"Código=item_code", "Descripción=item_name"}
        Me.LibXLookup6.WhereCondition = Nothing
        Me.LibXLookup6.WhereParameters = Nothing
        '
        'XTextBox9
        '
        Me.XTextBox9.AcceptsReturn = True
        Me.XTextBox9.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.XTextBox9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemm.item_code"))
        Me.XTextBox9.EditInitialValue = Nothing
        Me.XTextBox9.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox9.FieldDescription = ""
        Me.XTextBox9.FindInitialValue = Nothing
        Me.XTextBox9.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox9.IgnoreRequiered = False
        Me.XTextBox9.Location = New System.Drawing.Point(104, 224)
        Me.XTextBox9.Name = "XTextBox9"
        Me.XTextBox9.NewInitialValue = Nothing
        Me.XTextBox9.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox9.Requiered = False
        Me.XTextBox9.Size = New System.Drawing.Size(48, 20)
        Me.XTextBox9.StatusBarPanelDescripcion = Nothing
        Me.XTextBox9.TabIndex = 5
        Me.XTextBox9.Text = ""
        '
        'txtitem_name
        '
        Me.txtitem_name.AcceptsReturn = True
        Me.txtitem_name.EditInitialValue = Nothing
        Me.txtitem_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtitem_name.FieldDescription = ""
        Me.txtitem_name.FindInitialValue = Nothing
        Me.txtitem_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtitem_name.IgnoreRequiered = False
        Me.txtitem_name.Location = New System.Drawing.Point(160, 224)
        Me.txtitem_name.Name = "txtitem_name"
        Me.txtitem_name.NewInitialValue = Nothing
        Me.txtitem_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtitem_name.ReadOnly = True
        Me.txtitem_name.Requiered = False
        Me.txtitem_name.Size = New System.Drawing.Size(288, 20)
        Me.txtitem_name.StatusBarPanelDescripcion = Nothing
        Me.txtitem_name.TabIndex = 21
        Me.txtitem_name.TabStop = False
        Me.txtitem_name.Text = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label10.Location = New System.Drawing.Point(26, 248)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 16)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Descripción:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'XTextBox8
        '
        Me.XTextBox8.AcceptsReturn = True
        Me.XTextBox8.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.XTextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemm.item_name"))
        Me.XTextBox8.EditInitialValue = Nothing
        Me.XTextBox8.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox8.FieldDescription = ""
        Me.XTextBox8.FindInitialValue = Nothing
        Me.XTextBox8.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox8.IgnoreRequiered = False
        Me.XTextBox8.Location = New System.Drawing.Point(104, 248)
        Me.XTextBox8.Name = "XTextBox8"
        Me.XTextBox8.NewInitialValue = Nothing
        Me.XTextBox8.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox8.Requiered = False
        Me.XTextBox8.Size = New System.Drawing.Size(352, 20)
        Me.XTextBox8.StatusBarPanelDescripcion = Nothing
        Me.XTextBox8.TabIndex = 6
        Me.XTextBox8.Text = ""
        '
        'chk_incluir_descontinuados
        '
        Me.chk_incluir_descontinuados.Location = New System.Drawing.Point(160, 272)
        Me.chk_incluir_descontinuados.Name = "chk_incluir_descontinuados"
        Me.chk_incluir_descontinuados.Size = New System.Drawing.Size(192, 16)
        Me.chk_incluir_descontinuados.TabIndex = 7
        Me.chk_incluir_descontinuados.Text = "Incluir Productos Descontinuados"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label11.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label11.Location = New System.Drawing.Point(32, 272)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 16)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Existencia:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'xtxt_onhand
        '
        Me.xtxt_onhand.AcceptsReturn = True
        Me.xtxt_onhand.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xtxt_onhand.EditInitialValue = Nothing
        Me.xtxt_onhand.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_onhand.FieldDescription = ""
        Me.xtxt_onhand.FindInitialValue = Nothing
        Me.xtxt_onhand.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_onhand.IgnoreRequiered = False
        Me.xtxt_onhand.Location = New System.Drawing.Point(104, 272)
        Me.xtxt_onhand.Name = "xtxt_onhand"
        Me.xtxt_onhand.NewInitialValue = Nothing
        Me.xtxt_onhand.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_onhand.Requiered = False
        Me.xtxt_onhand.Size = New System.Drawing.Size(48, 20)
        Me.xtxt_onhand.StatusBarPanelDescripcion = Nothing
        Me.xtxt_onhand.TabIndex = 26
        Me.xtxt_onhand.Text = ""
        Me.ToolTip1.SetToolTip(Me.xtxt_onhand, "Indicar criterio para la existencia >0, <0, =0  <> 0 etc")
        '
        'Chk_mov
        '
        Me.Chk_mov.Location = New System.Drawing.Point(346, 272)
        Me.Chk_mov.Name = "Chk_mov"
        Me.Chk_mov.Size = New System.Drawing.Size(141, 16)
        Me.Chk_mov.TabIndex = 27
        Me.Chk_mov.Text = "Productos Movimientos"
        '
        'g_ivcount03
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(594, 352)
        Me.Controls.Add(Me.Chk_mov)
        Me.Controls.Add(Me.xtxt_onhand)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.chk_incluir_descontinuados)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.XTextBox8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LibXLookup6)
        Me.Controls.Add(Me.XTextBox9)
        Me.Controls.Add(Me.txtitem_name)
        Me.Controls.Add(Me.LibXLookup5)
        Me.Controls.Add(Me.xtxtprov_code)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.prov_name)
        Me.Controls.Add(Me.LibXLookup2)
        Me.Controls.Add(Me.XTextBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.group_name)
        Me.Controls.Add(Me.XTextBox5)
        Me.Controls.Add(Me.sgroup_name)
        Me.Controls.Add(Me.XTextBox7)
        Me.Controls.Add(Me.brand_name)
        Me.Controls.Add(Me.lblLastClose)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LibXLookup3)
        Me.Controls.Add(Me.LibXLookup4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LibXLookup1)
        Me.Controls.Add(Me.xtxt_whse_code)
        Me.Controls.Add(Me.whse_name)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblCountNo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "g_ivcount03"
        Me.Text = "Generar Hoja de Conteo"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ivitemm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ivcounte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ivcountd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub LibXConnector1_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.XBeforeExecuteQueryEventArgs) Handles LibXConnector1.BeforeExecuteQuery
        Dim xSelect As LibX.Data.XSelecStmt
        Dim xUpdate As LibX.Data.XUpdateStmt
        Dim oTable As DataTable
        Dim oDoc As SGT.Inventario.Entidades.Documento
        Dim ConteoNo, PaginaNo, LineNo As Integer
        Dim Serial As Integer
        Dim HojaTitulo As String

        Try

            e.DoFill = False

            If e.Where Is Nothing Then
                e.Where = "1=1"
            Else
                e.Where = e.Where.Replace("ivitemm.whse_code", "ivitemd.whse_code")
            End If

            If chk_incluir_descontinuados.Checked = False Then
                e.Sql = LibX.ConcatWherePart(e.Sql, "ivitemm.item_status = 1")
            End If

            e.Sql = LibX.ConcatWherePart(e.Sql, "(ivitemd.frizado_inv = 0 OR ivitemd.frizado_inv IS NULL)")

            If xtxt_onhand.Text <> "" Then
                e.Sql = LibX.ConcatWherePart(e.Sql, "ivitemd.existencia " & Me.xtxt_onhand.Text)
            End If
            If Me.xtxt_whse_code.Text = "" Then
                e.Sql = LibX.ConcatWherePart(e.Sql, "ivitemd.whse_code = " & LibX.User.WhDefault)
            End If
            If Me.Chk_mov.Checked = True Then
                e.Sql = LibX.ConcatWherePart(e.Sql, "ivitemm.item_code in(select item_code from ivtranrd)")
            End If

            xSelect = New LibX.Data.XSelecStmt("ivitemm", LibX.ConcatWherePart(e.Sql, e.Where))

            oTable = xSelect.GetTable(True)

            xSelect.Dispose()

            If oTable.Rows.Count <= 0 Then
                Throw New ApplicationException("No existen registros con esa condición!")
            End If

            If MessageBox.Show("Iniciar la generación?", "Generar Hoja de Conteo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                Exit Sub
            End If

            HojaTitulo = InputBox("Digite el Titulo de esta hoja de conteo", "Titulo de la Hoja", "INVENTARIO FISICO AL " & LibX.Data.Manager.Connection.GetDate.ToString("dd/MM/yyyy"))
            If HojaTitulo.Trim = "" Then
                Throw New ApplicationException("Debe especificar el titulo de la hoja de conteo!")
            End If

            ProgressBar1.Maximum = oTable.Rows.Count + 1
            ProgressBar1.Minimum = 1
            If LibX.Data.Manager.Connection.IsIntransaction = False Then
                LibX.Data.Manager.Connection.BeginTransaction()
            End If

            ''oDoc = New SGT.Inventario.Entidades.Documento("INV")
            ''ConteoNo = oDoc.GenerateNumber("INV", 1)

            PaginaNo = 0
            LineNo = 66
            Dim oNewRow1 As DataRow

            oNewRow1 = ivcounte.NewRow

            If xtxt_whse_code.Text.Trim <> "" Then
                oNewRow1!whse_code = xtxt_whse_code.Text
            End If

            oNewRow1!count_date = LibX.Data.Manager.Connection.GetDate
            oNewRow1!count_desc = HojaTitulo

            If Me.xtxtprov_code.Text.Trim <> "" Then
                oNewRow1!prov_code = Me.xtxtprov_code.Text
            End If

            ivcounte.Rows.Add(oNewRow1)

            LibX.Data.Manager.Save(ivcounte, "count_number")
            ConteoNo = LibX.Data.Manager.LastSerialValue

            lblCountNo.Text = ConteoNo.ToString

            xUpdate = New LibX.Data.XUpdateStmt("ivitemd")
            xUpdate.FieldsSet("frizado_inv") = 1 '// En conteo
            xUpdate.FieldsSet("fecha_frizado") = LibX.Data.Manager.Connection.GetDate  '// En conteo
            xUpdate.Fields("item_code") = "11"
            xUpdate.Fields("whse_code") = 0

            For Each oRow As DataRow In oTable.Rows
                Dim oNewRow As DataRow = ivcountd.NewRow

                If LineNo >= 47 Then
                    LineNo = 1
                    PaginaNo += 1
                End If

                oNewRow!count_number = ConteoNo
                oNewRow!PageNo = PaginaNo
                oNewRow!line_no = LineNo
                oNewRow!item_code = oRow!item_code
                oNewRow!unit_code = oRow!unit_code
                oNewRow!factor = oRow!factor
                oNewRow!whse_code = oRow!whse_code
                oNewRow!loc_row = oRow!loc_row
                oNewRow!loc_bin = oRow!loc_col
                oNewRow!estante = oRow!estante
                oNewRow!qty_on_hand = oRow!existencia
                oNewRow!count_status = Val(SGT.Inventario.Entidades.Documento.EstatusHojaConteoEnum.Generada) 'Generada

                ivcountd.Rows.Add(oNewRow)

                LineNo += 1
                ProgressBar1.Value += 1

                xUpdate.Fields("item_code") = oRow!item_code
                xUpdate.Fields("whse_code") = oRow!whse_code
                xUpdate.Execute()
            Next

            LibX.Data.Manager.Save(ivcountd)
            If LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.CommitTransaction()
            End If

            MessageBox.Show("Generación Exitosa " & oTable.Rows.Count.ToString.Trim & " Producto(s)", "Generar hoja de conteo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            btnImprimir.Enabled = True

        Catch ex As Exception
            Log.Show(ex)
            If LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.RollBackTransaction()
            End If
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnEjecutar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEjecutar.Click

        Me.LibXConnector1.AcceptFind()
        Me.LibXConnector1.Find()
        ProgressBar1.Maximum = 1
        ProgressBar1.Minimum = 1
        '''Me.fecHasta.Value = LibX.Data.Manager.Connection.GetDate

    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LibXConnector1.Cancel()
        LibXConnector1.Find()
    End Sub

    Private Sub r_ftfact10_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        WhDefault = Val(Configuration.ConfigurationSettings.AppSettings.Get("LibXWhDefault").ToString)
        Me.LibXConnector1.Find()
        If xtxt_whse_code.Text <> "" Then
            Me.LibXLookup1.ExecuteFind()
        End If
    End Sub

    Private Sub LibXConnector1_ExecutedAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutedAction
        Try
            If e.Action = LibxConnectionActions.Find Then
                ''ShowLastClose()
                xtxt_whse_code.Text = LibX.User.WhDefault
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
    Private Sub ShowLastClose()
        Dim SelectStmt As String
        Dim DateClose As String
        Try

            SelectStmt = "select max(cierr_date) from ivcierrm"

            DateClose = LibX.Data.Manager.GetScalar(SelectStmt).ToString

            ' lblLastClose.Text = CType(DateClose, Date).ToShortDateString

        Catch ex As Exception
            LibX.Log.Add(ex)

        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Dim oRep As LibX.ReportLib
        Dim SelectStmt As String
        Try
            oRep = New LibX.ReportLib("INV", "r_ivcount01.rpt")
            With oRep
                .RetrieveSQLQuery()
                SelectStmt = .SQLQuery
                SelectStmt = LibX.ConcatWherePart(SelectStmt, "ivcounte.count_number = " & lblCountNo.Text)
                .SQLQuery = SelectStmt
                '''.ParameterFields(1) = "FechaCierre;" & Me.fecHasta.Value & ";TRUE"
                .Action = 1
            End With
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

End Class
