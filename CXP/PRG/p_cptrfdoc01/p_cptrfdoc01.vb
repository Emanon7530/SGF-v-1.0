Imports SGT.Inventario.Common
Imports SGT.CXP.Posteos.PostDocument
Imports System.Configuration.ConfigurationSettings

Public Class p_cptrfdoc01
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
    'Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents XdataGridTableStyle1 As LibX.XdataGridTableStyle
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnDetail As System.Windows.Forms.Button
    Friend WithEvents btnUnmarkall As System.Windows.Forms.Button
    Friend WithEvents btnMarkAll As System.Windows.Forms.Button
    Friend WithEvents DataView1 As System.Data.DataView
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents gcolmonto As LibX.XEditTextBoxColumn
    Friend WithEvents LibXGrid1 As LibX.LibXGrid
    Friend WithEvents LibXDbSourceTable2 As LibX.LibXDbSourceTable
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents btnAplicar As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents XD_aplicar As LibX.XDataGridBoolColumn
    Friend WithEvents XEditTe_tipo As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTe_numero As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTe_fecha As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTe_usuario As LibX.XEditTextBoxColumn
    Friend WithEvents lblProv_name As System.Windows.Forms.Label
    Friend WithEvents xtxt_prov_code As LibX.XTextBox
    Friend WithEvents xtxt_prov_dest As LibX.XTextBox
    Friend WithEvents lblprov_dest As System.Windows.Forms.Label
    Friend WithEvents LibXDbSourceTable3 As LibX.LibXDbSourceTable
    Friend WithEvents XEdittipoNAme As LibX.XEditTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
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
    Friend WithEvents DataColumn21 As System.Data.DataColumn
    Friend WithEvents DataColumn22 As System.Data.DataColumn
    Friend WithEvents DataColumn23 As System.Data.DataColumn
    Friend WithEvents DataColumn24 As System.Data.DataColumn
    Friend WithEvents DataColumn25 As System.Data.DataColumn
    Friend WithEvents DataColumn26 As System.Data.DataColumn
    Friend WithEvents lkl_prov_origen As LibX.LibXLookup
    Friend WithEvents lkl_prov_destino As LibX.LibXLookup
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents DataColumn27 As System.Data.DataColumn
    Friend WithEvents XEditTextBoxColumn1 As LibX.XEditTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lkl_prov_destino = New LibX.LibXLookup
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
        Me.DataColumn21 = New System.Data.DataColumn
        Me.DataColumn22 = New System.Data.DataColumn
        Me.DataColumn23 = New System.Data.DataColumn
        Me.DataColumn24 = New System.Data.DataColumn
        Me.DataColumn25 = New System.Data.DataColumn
        Me.DataColumn26 = New System.Data.DataColumn
        Me.DataColumn9 = New System.Data.DataColumn
        Me.DataColumn10 = New System.Data.DataColumn
        Me.DataColumn27 = New System.Data.DataColumn
        Me.LibXDbSourceTable3 = New LibX.LibXDbSourceTable
        Me.lkl_prov_origen = New LibX.LibXLookup
        Me.Label5 = New System.Windows.Forms.Label
        Me.xtxt_prov_code = New LibX.XTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.xtxt_prov_dest = New LibX.XTextBox
        Me.lblProv_name = New System.Windows.Forms.Label
        Me.lblprov_dest = New System.Windows.Forms.Label
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.btnRefresh = New System.Windows.Forms.Button
        Me.btnDetail = New System.Windows.Forms.Button
        Me.btnUnmarkall = New System.Windows.Forms.Button
        Me.btnMarkAll = New System.Windows.Forms.Button
        Me.LibXGrid1 = New LibX.LibXGrid
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.XdataGridTableStyle1 = New LibX.XdataGridTableStyle
        Me.XD_aplicar = New LibX.XDataGridBoolColumn
        Me.XEditTe_tipo = New LibX.XEditTextBoxColumn
        Me.XEditTe_numero = New LibX.XEditTextBoxColumn
        Me.XEditTe_fecha = New LibX.XEditTextBoxColumn
        Me.gcolmonto = New LibX.XEditTextBoxColumn
        Me.XEdittipoNAme = New LibX.XEditTextBoxColumn
        Me.XEditTe_usuario = New LibX.XEditTextBoxColumn
        Me.DataView1 = New System.Data.DataView
        Me.btnAplicar = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.XEditTextBoxColumn1 = New LibX.XEditTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lkl_prov_destino)
        Me.GroupBox1.Controls.Add(Me.lkl_prov_origen)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.xtxt_prov_code)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.xtxt_prov_dest)
        Me.GroupBox1.Controls.Add(Me.lblProv_name)
        Me.GroupBox1.Controls.Add(Me.lblprov_dest)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(680, 80)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Criterio"
        '
        'lkl_prov_destino
        '
        Me.lkl_prov_destino.AlternateFieldSearch = Nothing
        Me.lkl_prov_destino.BeginCheck = False
        Me.lkl_prov_destino.CheckText = Nothing
        Me.lkl_prov_destino.ComboMode = False
        Me.lkl_prov_destino.DataMember = Nothing
        Me.lkl_prov_destino.DataSource = Me.LibXConnector1
        Me.lkl_prov_destino.DestParameters = New String() {"xtxt_prov_dest=prov_code", "lblprov_dest=prov_name"}
        Me.lkl_prov_destino.FilterField = Nothing
        Me.lkl_prov_destino.IgnoreFindInBrowseMode = False
        Me.lkl_prov_destino.isCanceled = False
        Me.lkl_prov_destino.Location = New System.Drawing.Point(632, 48)
        Me.lkl_prov_destino.LookCaption = "Suplidores Destino"
        Me.lkl_prov_destino.Name = "lkl_prov_destino"
        Me.lkl_prov_destino.PopupSize = New System.Drawing.Size(0, 0)
        Me.lkl_prov_destino.ShowFilter = True
        Me.lkl_prov_destino.ShowMessageNotFound = True
        Me.lkl_prov_destino.ShowWarning = False
        Me.lkl_prov_destino.Size = New System.Drawing.Size(16, 20)
        Me.lkl_prov_destino.SizesColumns = Nothing
        Me.lkl_prov_destino.SizesColumnsTab = Nothing
        Me.lkl_prov_destino.SqlString = Nothing
        Me.lkl_prov_destino.SQLTab = Nothing
        Me.lkl_prov_destino.SrcParameters = New String() {"xtxt_prov_dest=prov_code", ""}
        Me.lkl_prov_destino.TabIndex = 7
        Me.lkl_prov_destino.TableName = "cpprovm"
        Me.lkl_prov_destino.TabStop = False
        Me.lkl_prov_destino.UseCopyConnection = False
        Me.lkl_prov_destino.UseRowRetrieveEvents = False
        Me.lkl_prov_destino.UseTab = False
        Me.lkl_prov_destino.VisParameters = New String() {"Codigo=prov_code", "Nombre=prov_name", "Balance=balance"}
        Me.lkl_prov_destino.WhereCondition = ""
        Me.lkl_prov_destino.WhereParameters = Nothing
        '
        'LibXConnector1
        '
        Me.LibXConnector1.AllowDelete = False
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
        Me.LibXConnector1.HandledUpdates = True
        Me.LibXConnector1.HasRecords = False
        Me.LibXConnector1.IsEditing = False
        Me.LibXConnector1.IsHeaderOnGrid = True
        Me.LibXConnector1.ModuleName = ""
        Me.LibXConnector1.OwnerForm = Me
        Me.LibXConnector1.Parameters = Nothing
        Me.LibXConnector1.RecordCount = 0
        Me.LibXConnector1.ReportMode = False
        Me.LibXConnector1.ReportName = ""
        Me.LibXConnector1.ReportObject = Nothing
        Me.LibXConnector1.RequeryData = False
        Me.LibXConnector1.ShowWarningCancel = True
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.LibXDbSourceTable3})
        Me.LibXConnector1.State = LibX.LibxConnectorState.none
        Me.LibXConnector1.UpdatePrimaryKeyColumns = False
        Me.LibXConnector1.UseTransactions = True
        '
        'DataSet1
        '
        Me.LibXConnector1.SetDataGenerator(Me.DataSet1, Me.LibXConnector1)
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, True)
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn9, Me.DataColumn10, Me.DataColumn27})
        Me.DataTable1.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"invce_serial"}, True)})
        Me.DataTable1.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn1}
        Me.DataTable1.TableName = "cpinvcem"
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
        Me.DataColumn2.ColumnName = "doc_no"
        Me.DataColumn2.MaxLength = 20
        '
        'DataColumn3
        '
        Me.DataColumn3.AllowDBNull = False
        Me.DataColumn3.ColumnName = "amount"
        Me.DataColumn3.DataType = GetType(System.Decimal)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "userid"
        Me.DataColumn4.MaxLength = 20
        '
        'DataColumn5
        '
        Me.DataColumn5.AllowDBNull = False
        Me.DataColumn5.ColumnName = "type_code"
        Me.DataColumn5.MaxLength = 3
        '
        'DataColumn6
        '
        Me.DataColumn6.AllowDBNull = False
        Me.DataColumn6.ColumnName = "type_name"
        Me.DataColumn6.MaxLength = 30
        '
        'DataColumn7
        '
        Me.DataColumn7.AllowDBNull = False
        Me.DataColumn7.ColumnName = "prov_code"
        Me.DataColumn7.DataType = GetType(System.Int32)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "prov_name"
        Me.DataColumn8.MaxLength = 60
        '
        'DataColumn11
        '
        Me.DataColumn11.AllowDBNull = False
        Me.DataColumn11.ColumnName = "doc_date"
        Me.DataColumn11.DataType = GetType(System.DateTime)
        '
        'DataColumn12
        '
        Me.DataColumn12.AllowDBNull = False
        Me.DataColumn12.ColumnName = "term_code"
        Me.DataColumn12.MaxLength = 5
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "invce_desc"
        Me.DataColumn13.MaxLength = 60
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "disc_date"
        Me.DataColumn14.DataType = GetType(System.DateTime)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "disc_pct"
        Me.DataColumn15.DataType = GetType(System.Decimal)
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "due_date"
        Me.DataColumn16.DataType = GetType(System.DateTime)
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "disc_amount"
        Me.DataColumn17.DataType = GetType(System.Decimal)
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "isc_amount"
        Me.DataColumn18.DataType = GetType(System.Decimal)
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "itbis"
        Me.DataColumn19.DataType = GetType(System.Decimal)
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "excento"
        Me.DataColumn20.DataType = GetType(System.Decimal)
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "impto"
        Me.DataColumn21.DataType = GetType(System.Decimal)
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "invce_status"
        Me.DataColumn22.DataType = GetType(System.Int32)
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "date_created"
        Me.DataColumn23.DataType = GetType(System.DateTime)
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "invce_ncf"
        Me.DataColumn24.MaxLength = 20
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "dev_serial"
        Me.DataColumn25.DataType = GetType(System.Int32)
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "entr_serial"
        Me.DataColumn26.DataType = GetType(System.Int32)
        '
        'DataColumn9
        '
        Me.DataColumn9.Caption = "Aplicar"
        Me.DataColumn9.ColumnName = "Aplicar"
        Me.DataColumn9.DataType = GetType(System.Int16)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "Column1"
        Me.DataColumn10.MaxLength = 20
        Me.DataColumn10.ReadOnly = True
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "suc_code"
        Me.DataColumn27.DataType = GetType(System.Int32)
        '
        'LibXDbSourceTable3
        '
        Me.LibXDbSourceTable3.AllowDelete = False
        Me.LibXDbSourceTable3.AllowEdit = True
        Me.LibXDbSourceTable3.AllowNew = True
        Me.LibXDbSourceTable3.AutoIncrementSerial = False
        Me.LibXDbSourceTable3.CustomDbUpdate = False
        Me.LibXDbSourceTable3.DeleteOrder = 0
        Me.LibXDbSourceTable3.FillOnQuery = True
        Me.LibXDbSourceTable3.FillOnRowChange = False
        Me.LibXDbSourceTable3.HeaderIsOnGrid = False
        Me.LibXDbSourceTable3.InnerJon = True
        Me.LibXDbSourceTable3.InsertOrder = 0
        Me.LibXDbSourceTable3.IsDetail = False
        Me.LibXDbSourceTable3.KeyFields = Nothing
        Me.LibXDbSourceTable3.LineColName = Nothing
        Me.LibXDbSourceTable3.MasterDetailRelation = Nothing
        Me.LibXDbSourceTable3.MasterTableName = Nothing
        Me.LibXDbSourceTable3.SerialColumnName = "invce_serial"
        Me.LibXDbSourceTable3.Sort = Nothing
        Me.LibXDbSourceTable3.Source = New String() {"select cpinvcem.invce_serial, ", "       cpinvcem.doc_no,", "       cpinvcem.doc_date,", "       cpinvcem.amount,", "       cpinvcem.itbis,", "       cpinvcem.userid,", "       cpinvcem.type_code, ", "       ivtypem.[type_name], ", "       cpinvcem.prov_code,", "       cpprovm.prov_name,", "       cpinvcem.suc_code", "       from cpinvcem  ", "       inner join ivtypem  ", "       on cpinvcem.type_code = ivtypem.type_code  ", "       inner join cpprovm ", "       on cpinvcem.prov_code = cpprovm.prov_code ", "       where invce_status = 1 "}
        Me.LibXDbSourceTable3.TableName = "cpinvcem"
        Me.LibXDbSourceTable3.UpdateOrder = 0
        Me.LibXDbSourceTable3.UseRowRetrieve = False
        '
        'lkl_prov_origen
        '
        Me.lkl_prov_origen.AlternateFieldSearch = Nothing
        Me.lkl_prov_origen.BeginCheck = False
        Me.lkl_prov_origen.CheckText = Nothing
        Me.lkl_prov_origen.ComboMode = False
        Me.lkl_prov_origen.DataMember = Nothing
        Me.lkl_prov_origen.DataSource = Me.LibXConnector1
        Me.lkl_prov_origen.DestParameters = New String() {"xtxt_prov_code=prov_code", "lblProv_name=prov_name"}
        Me.lkl_prov_origen.FilterField = Nothing
        Me.lkl_prov_origen.IgnoreFindInBrowseMode = False
        Me.lkl_prov_origen.isCanceled = False
        Me.lkl_prov_origen.Location = New System.Drawing.Point(632, 24)
        Me.lkl_prov_origen.LookCaption = "Suplidores Origen"
        Me.lkl_prov_origen.Name = "lkl_prov_origen"
        Me.lkl_prov_origen.PopupSize = New System.Drawing.Size(0, 0)
        Me.lkl_prov_origen.ShowFilter = True
        Me.lkl_prov_origen.ShowMessageNotFound = True
        Me.lkl_prov_origen.ShowWarning = False
        Me.lkl_prov_origen.Size = New System.Drawing.Size(16, 20)
        Me.lkl_prov_origen.SizesColumns = Nothing
        Me.lkl_prov_origen.SizesColumnsTab = Nothing
        Me.lkl_prov_origen.SqlString = Nothing
        Me.lkl_prov_origen.SQLTab = Nothing
        Me.lkl_prov_origen.SrcParameters = New String() {"xtxt_prov_code=prov_code"}
        Me.lkl_prov_origen.TabIndex = 6
        Me.lkl_prov_origen.TableName = "cpprovm"
        Me.lkl_prov_origen.TabStop = False
        Me.lkl_prov_origen.UseCopyConnection = False
        Me.lkl_prov_origen.UseRowRetrieveEvents = False
        Me.lkl_prov_origen.UseTab = False
        Me.lkl_prov_origen.VisParameters = New String() {"Codigo=prov_code", "Nombre=prov_name", "Balance=balance"}
        Me.lkl_prov_origen.WhereCondition = "balance <>0"
        Me.lkl_prov_origen.WhereParameters = Nothing
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 16)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Suplidor Origen:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_prov_code
        '
        Me.xtxt_prov_code.AcceptsReturn = True
        Me.xtxt_prov_code.EditInitialValue = Nothing
        Me.xtxt_prov_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_prov_code.FieldDescription = ""
        Me.xtxt_prov_code.FindInitialValue = Nothing
        Me.xtxt_prov_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_prov_code.IgnoreRequiered = False
        Me.xtxt_prov_code.Location = New System.Drawing.Point(104, 24)
        Me.xtxt_prov_code.Name = "xtxt_prov_code"
        Me.xtxt_prov_code.NewInitialValue = Nothing
        Me.xtxt_prov_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_prov_code.Requiered = False
        Me.xtxt_prov_code.Size = New System.Drawing.Size(56, 20)
        Me.xtxt_prov_code.StatusBarPanelDescripcion = Nothing
        Me.xtxt_prov_code.TabIndex = 4
        Me.xtxt_prov_code.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Suplidor Destino:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_prov_dest
        '
        Me.xtxt_prov_dest.AcceptsReturn = True
        Me.xtxt_prov_dest.EditInitialValue = Nothing
        Me.xtxt_prov_dest.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_prov_dest.FieldDescription = ""
        Me.xtxt_prov_dest.FindInitialValue = Nothing
        Me.xtxt_prov_dest.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_prov_dest.IgnoreRequiered = False
        Me.xtxt_prov_dest.Location = New System.Drawing.Point(104, 48)
        Me.xtxt_prov_dest.Name = "xtxt_prov_dest"
        Me.xtxt_prov_dest.NewInitialValue = Nothing
        Me.xtxt_prov_dest.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_prov_dest.Requiered = False
        Me.xtxt_prov_dest.Size = New System.Drawing.Size(56, 20)
        Me.xtxt_prov_dest.StatusBarPanelDescripcion = Nothing
        Me.xtxt_prov_dest.TabIndex = 4
        Me.xtxt_prov_dest.Text = ""
        '
        'lblProv_name
        '
        Me.lblProv_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblProv_name.Location = New System.Drawing.Point(168, 24)
        Me.lblProv_name.Name = "lblProv_name"
        Me.lblProv_name.Size = New System.Drawing.Size(464, 20)
        Me.lblProv_name.TabIndex = 5
        '
        'lblprov_dest
        '
        Me.lblprov_dest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblprov_dest.Location = New System.Drawing.Point(168, 48)
        Me.lblprov_dest.Name = "lblprov_dest"
        Me.lblprov_dest.Size = New System.Drawing.Size(464, 20)
        Me.lblprov_dest.TabIndex = 5
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
        Me.LibXDbSourceTable2.SerialColumnName = "invce_serial"
        Me.LibXDbSourceTable2.Sort = Nothing
        Me.LibXDbSourceTable2.Source = New String() {"select 0 as Aplicar,cpinvcem.invce_serial, ", "                       cpinvcem.type_code, ", "                      ivtypem.[type_name], ", "                       cpinvcem.invce_no,  ", "                       cpinvcem.doc_date, ", "                       cpinvcem.prov_code,  ", "                       cccustm.cust_name, ", "                       cpinvcem.total_amount  ", "                       from cpinvcem  ", "                       inner join ivtypem  ", "                       on cpinvcem.type_code = ivtypem.type_code  ", "                       inner join cccustm ", "                       on cpinvcem.prov_code = cccustm.prov_code "}
        Me.LibXDbSourceTable2.TableName = "cpinvcem"
        Me.LibXDbSourceTable2.UpdateOrder = 0
        Me.LibXDbSourceTable2.UseRowRetrieve = False
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
        Me.LibXDbSourceTable1.LineColName = Nothing
        Me.LibXDbSourceTable1.MasterDetailRelation = Nothing
        Me.LibXDbSourceTable1.MasterTableName = Nothing
        Me.LibXDbSourceTable1.SerialColumnName = "invce_serial"
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = New String() {"select cpinvcem.invce_serial,", "" & Microsoft.VisualBasic.ChrW(9) & "cpinvcem.type_code,", "" & Microsoft.VisualBasic.ChrW(9) & "ivtypem.[type_name],", "" & Microsoft.VisualBasic.ChrW(9) & "cpinvcem.invce_no,", "" & Microsoft.VisualBasic.ChrW(9) & "cpinvcem.doc_date,", "" & Microsoft.VisualBasic.ChrW(9) & "cpinvcem.prov_code,", "" & Microsoft.VisualBasic.ChrW(9) & "cccustm.cust_name,", "" & Microsoft.VisualBasic.ChrW(9) & "cpinvcem.total_amount" & Microsoft.VisualBasic.ChrW(9), "from cpinvcem ", "inner join ivtypem", "on cpinvcem.type_code = ivtypem.type_code", "inner join cccustm", "on cpinvcem.prov_code = cccustm.prov_code", "" & Microsoft.VisualBasic.ChrW(9), "" & Microsoft.VisualBasic.ChrW(9), "" & Microsoft.VisualBasic.ChrW(9)}
        Me.LibXDbSourceTable1.TableName = "cpinvcem"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRefresh.Location = New System.Drawing.Point(696, 24)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(80, 24)
        Me.btnRefresh.TabIndex = 10
        Me.btnRefresh.Text = "Buscar"
        '
        'btnDetail
        '
        Me.btnDetail.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDetail.Enabled = False
        Me.btnDetail.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDetail.Location = New System.Drawing.Point(168, 520)
        Me.btnDetail.Name = "btnDetail"
        Me.btnDetail.Size = New System.Drawing.Size(80, 32)
        Me.btnDetail.TabIndex = 9
        Me.btnDetail.Text = "Visualizar"
        '
        'btnUnmarkall
        '
        Me.btnUnmarkall.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnUnmarkall.Enabled = False
        Me.btnUnmarkall.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUnmarkall.Location = New System.Drawing.Point(88, 520)
        Me.btnUnmarkall.Name = "btnUnmarkall"
        Me.btnUnmarkall.Size = New System.Drawing.Size(80, 32)
        Me.btnUnmarkall.TabIndex = 8
        Me.btnUnmarkall.Text = "Desmarcar Todos"
        '
        'btnMarkAll
        '
        Me.btnMarkAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnMarkAll.Enabled = False
        Me.btnMarkAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMarkAll.Location = New System.Drawing.Point(8, 520)
        Me.btnMarkAll.Name = "btnMarkAll"
        Me.btnMarkAll.Size = New System.Drawing.Size(80, 32)
        Me.btnMarkAll.TabIndex = 7
        Me.btnMarkAll.Text = "Marcar Todos"
        '
        'LibXGrid1
        '
        Me.LibXGrid1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LibXGrid1.AutoAdjustLastColumn = True
        Me.LibXGrid1.AutoSearch = True
        Me.LibXGrid1.BackgroundColor = System.Drawing.Color.White
        Me.LibXGrid1.CaptionText = "Documentos pendientes por Aplicar"
        Me.LibXGrid1.ContextMenu = Me.ContextMenu1
        Me.LibXGrid1.DataMember = "cpinvcem"
        Me.LibXGrid1.DataSource = Me.DataSet1
        Me.LibXGrid1.FullRowSelect = True
        Me.LibXGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGrid1.IsReadOnly = False
        Me.LibXGrid1.Location = New System.Drawing.Point(0, 88)
        Me.LibXGrid1.Name = "LibXGrid1"
        Me.LibXGrid1.ReadOnly = True
        Me.LibXGrid1.searchText = ""
        Me.LibXGrid1.showFooterBar = True
        Me.LibXGrid1.Size = New System.Drawing.Size(768, 360)
        Me.LibXGrid1.TabIndex = 15
        Me.LibXGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.XdataGridTableStyle1})
        Me.LibXGrid1.UseAutoFillLines = True
        Me.LibXGrid1.UseHandCursor = False
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem5, Me.MenuItem6, Me.MenuItem7})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "Marcar Todos"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Text = "Desmarcar Todos"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.Text = "-"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 3
        Me.MenuItem4.Text = "Visualizar"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 4
        Me.MenuItem5.Text = "Refrescar"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 5
        Me.MenuItem6.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 6
        Me.MenuItem7.Text = "Transferir"
        '
        'XdataGridTableStyle1
        '
        Me.XdataGridTableStyle1.AlternatingBackColor = System.Drawing.SystemColors.Info
        Me.XdataGridTableStyle1.DataGrid = Me.LibXGrid1
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.XD_aplicar, Me.XEditTe_tipo, Me.XEditTe_numero, Me.XEditTextBoxColumn1, Me.XEditTe_fecha, Me.gcolmonto, Me.XEdittipoNAme, Me.XEditTe_usuario})
        Me.XdataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle1.MappingName = "cpinvcem"
        '
        'XD_aplicar
        '
        Me.XD_aplicar.FalseValue = CType(0, Short)
        Me.XD_aplicar.HeaderText = "Aplicar"
        Me.XD_aplicar.MappingName = "Aplicar"
        Me.XD_aplicar.NullValue = 0
        Me.XD_aplicar.TrueValue = CType(1, Short)
        Me.XD_aplicar.UseCustomCellFormat = False
        Me.XD_aplicar.Width = 45
        '
        'XEditTe_tipo
        '
        Me.XEditTe_tipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTe_tipo.Format = ""
        Me.XEditTe_tipo.FormatInfo = Nothing
        Me.XEditTe_tipo.HeaderText = " Documento"
        Me.XEditTe_tipo.ImageList = Nothing
        Me.XEditTe_tipo.isReadOnly = True
        Me.XEditTe_tipo.MappingName = "type_name"
        Me.XEditTe_tipo.MaxLength = 32767
        Me.XEditTe_tipo.TabStop = True
        Me.XEditTe_tipo.UseCustomCellFormat = False
        Me.XEditTe_tipo.Width = 200
        '
        'XEditTe_numero
        '
        Me.XEditTe_numero.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTe_numero.Format = ""
        Me.XEditTe_numero.FormatInfo = Nothing
        Me.XEditTe_numero.HeaderText = "Número"
        Me.XEditTe_numero.ImageList = Nothing
        Me.XEditTe_numero.isReadOnly = True
        Me.XEditTe_numero.MappingName = "doc_no"
        Me.XEditTe_numero.MaxLength = 32767
        Me.XEditTe_numero.TabStop = True
        Me.XEditTe_numero.UseCustomCellFormat = False
        Me.XEditTe_numero.Width = 80
        '
        'XEditTe_fecha
        '
        Me.XEditTe_fecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTe_fecha.Format = ""
        Me.XEditTe_fecha.FormatInfo = Nothing
        Me.XEditTe_fecha.HeaderText = "Fecha"
        Me.XEditTe_fecha.ImageList = Nothing
        Me.XEditTe_fecha.isReadOnly = True
        Me.XEditTe_fecha.MappingName = "doc_date"
        Me.XEditTe_fecha.MaxLength = 32767
        Me.XEditTe_fecha.TabStop = True
        Me.XEditTe_fecha.UseCustomCellFormat = False
        Me.XEditTe_fecha.Width = 80
        '
        'gcolmonto
        '
        Me.gcolmonto.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.gcolmonto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gcolmonto.Format = "#,###,###.00"
        Me.gcolmonto.FormatInfo = Nothing
        Me.gcolmonto.HeaderText = "Montoi"
        Me.gcolmonto.ImageList = Nothing
        Me.gcolmonto.isReadOnly = True
        Me.gcolmonto.MappingName = "amount"
        Me.gcolmonto.MaxLength = 32767
        Me.gcolmonto.TabStop = True
        Me.gcolmonto.UseCustomCellFormat = False
        Me.gcolmonto.Width = 85
        '
        'XEdittipoNAme
        '
        Me.XEdittipoNAme.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEdittipoNAme.Format = ""
        Me.XEdittipoNAme.FormatInfo = Nothing
        Me.XEdittipoNAme.HeaderText = "Suplidor"
        Me.XEdittipoNAme.ImageList = Nothing
        Me.XEdittipoNAme.isReadOnly = True
        Me.XEdittipoNAme.MappingName = "prov_name"
        Me.XEdittipoNAme.MaxLength = 32767
        Me.XEdittipoNAme.TabStop = True
        Me.XEdittipoNAme.UseCustomCellFormat = False
        Me.XEdittipoNAme.Width = 250
        '
        'XEditTe_usuario
        '
        Me.XEditTe_usuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTe_usuario.Format = ""
        Me.XEditTe_usuario.FormatInfo = Nothing
        Me.XEditTe_usuario.HeaderText = "Usuario"
        Me.XEditTe_usuario.ImageList = Nothing
        Me.XEditTe_usuario.isReadOnly = True
        Me.XEditTe_usuario.MappingName = "userid"
        Me.XEditTe_usuario.MaxLength = 32767
        Me.XEditTe_usuario.TabStop = True
        Me.XEditTe_usuario.UseCustomCellFormat = False
        Me.XEditTe_usuario.Width = 75
        '
        'DataView1
        '
        Me.DataView1.AllowDelete = False
        Me.DataView1.AllowNew = False
        '
        'btnAplicar
        '
        Me.btnAplicar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAplicar.Enabled = False
        Me.btnAplicar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAplicar.Location = New System.Drawing.Point(696, 520)
        Me.btnAplicar.Name = "btnAplicar"
        Me.btnAplicar.Size = New System.Drawing.Size(80, 32)
        Me.btnAplicar.TabIndex = 10
        Me.btnAplicar.Text = "Transferir"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(696, 56)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 24)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Cerrar"
        '
        'XEditTextBoxColumn1
        '
        Me.XEditTextBoxColumn1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn1.Format = ""
        Me.XEditTextBoxColumn1.FormatInfo = Nothing
        Me.XEditTextBoxColumn1.HeaderText = "Sucursal"
        Me.XEditTextBoxColumn1.ImageList = Nothing
        Me.XEditTextBoxColumn1.isReadOnly = False
        Me.XEditTextBoxColumn1.MappingName = "suc_code"
        Me.XEditTextBoxColumn1.MaxLength = 32767
        Me.XEditTextBoxColumn1.TabStop = True
        Me.XEditTextBoxColumn1.UseCustomCellFormat = False
        Me.XEditTextBoxColumn1.Width = 75
        '
        'p_cptrfdoc01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(794, 560)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LibXGrid1)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnDetail)
        Me.Controls.Add(Me.btnUnmarkall)
        Me.Controls.Add(Me.btnMarkAll)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnAplicar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "p_cptrfdoc01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Transferencia de Documentos Aplicado"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub MarcarTodos(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMarkAll.Click
        For Each oRow As DataRow In DataSet1.Tables("cpinvcem").Rows
            oRow!Aplicar = 1
        Next
    End Sub
    Private Sub DesmarcarTodos(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnmarkall.Click
        For Each oRow As DataRow In DataSet1.Tables("cpinvcem").Rows
            oRow!Aplicar = 0
        Next
    End Sub

    Private Sub Postear()
        Dim oParamPost As SGT.CXP.Posteos.PostDocument.ParametrosTransferir
        Dim oPost As SGT.CXP.Posteos.PostDocument
        Dim SelectStmt As String
        Dim oiventrdd As DataTable
        Dim oiventrdm As DataTable
        Dim OnHand As Int16
        Dim XUpdate As LibX.Data.XUpdateStmt
        Dim Oserial As DataRow
        Dim serial As Integer
        Try
            If MessageBox.Show("Seguro desea Transferir?", "Transferir documentos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                Throw New ApplicationException("Operación Abortada!")
            End If

            oParamPost = New SGT.CXP.Posteos.PostDocument.ParametrosTransferir
            oPost = New SGT.CXP.Posteos.PostDocument
            If Me.xtxt_prov_dest.Text = "" Then
                Throw New ApplicationException("Debe indicar el suplidor de destino antes de transferir!")
            End If

            For Each oRow As DataRow In DataSet1.Tables("cpinvcem").Select("aplicar=1")
                '// Postear a inventario
                With oParamPost
                    .Serial = oRow!invce_serial
                    .ProveedorOrigen = oRow!prov_code
                    .ProveedorDestino = Me.xtxt_prov_dest.Text
                    .MontoBalance = oRow!amount
                    .MontoItbis = oRow!itbis
                    .UseTransaction = False
                End With

                oPost.TransferirFacturas(oParamPost)
                DataSet1.Tables("cpinvcem").Rows.Remove(oRow)
            Next

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub

    Private Sub p_iventr01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            LibXConnector1.Find()
            Me.LibXGrid1.footerOperations.add("Aplicar", "count(Aplicar)", "1=1")
            Me.LibXGrid1.footerOperations.add("type_code", "count(type_code)", "Aplicar=1")

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click

        If LibXConnector1.HasRecords = True Then
            LibXConnector1.Edit()
        Else
            LibXConnector1.Find()
        End If
    End Sub

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        DesmarcarTodos(sender, e)
    End Sub
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        MarcarTodos(sender, e)
    End Sub

    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        btnRefresh_Click(sender, e)
    End Sub

    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DataSet1.Tables("cpinvcem").Rows(LibXGrid1.CurrentRowIndex)!Aplicar = 1
        Postear()
    End Sub

    Private Sub LibXConnector1_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.XBeforeExecuteQueryEventArgs) Handles LibXConnector1.BeforeExecuteQuery
        Try
            If LibXConnector1.State = LibX.LibxConnectorState.Query Then
                e.Sql = e.Sql.ToString.Trim.Replace("ccinvcem.Aplicar = 0", "1=1")
                e.AditionalWhere = " 1=1 "

                '// Proveedor
                If Not LibX.IsNull(Me.xtxt_prov_code.Text.Trim) Then
                    e.AditionalWhere &= " and cpinvcem.prov_code =" & Me.xtxt_prov_code.Text.Trim
                End If

                e.AditionalWhere &= " and cpinvcem.type_code in ('CRD','DVI','NCR')"
            End If
        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub
    Private Sub LibXConnector1_ExecutingAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutingAction
        If e.Action = LibX.LibxConnectionActions.Find _
        Or e.AcceptedAction = LibX.LibxConnectionActions.Find Then
            DataSet1.Tables(0).Rows.Clear()
            LibXGrid1.ReadOnly = True
        End If

        If e.Action = LibX.LibxConnectionActions.Edit Then
            LibXGrid1.ReadOnly = False
        End If

        If e.AcceptedAction = LibX.LibxConnectionActions.Edit And DataSet1.Tables("cpinvcem").Select("Aplicar=1").Length > 0 Then
            Postear()
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            btnRefresh_Click(sender, e)
        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub
    Private Sub btnAplicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAplicar.Click
        Try
            DataSet1.Tables("cpinvcem").Rows(LibXGrid1.CurrentRowIndex)!Aplicar = 1
            Postear()
        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub LibXConnector1_AfterRowChange(ByVal sender As Object, ByVal e As LibX.XRowChangeEventArgs) Handles LibXConnector1.AfterRowChange
        Me.btnMarkAll.Enabled = LibXConnector1.HasRecords = True
        Me.btnUnmarkall.Enabled = LibXConnector1.HasRecords = True
        Me.btnDetail.Enabled = LibXConnector1.HasRecords = True
        Me.btnAplicar.Enabled = LibXConnector1.HasRecords = True

    End Sub

    Private Sub lkl_prov_origen_AfterSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles lkl_prov_origen.AfterSetValues
        Try
            If e.dataFound = False Then
                Exit Sub
            End If
            If LibXConnector1.State = LibX.LibxConnectorState.Query Then
                LibXConnector1.AcceptFind()
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Sub
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub lkl_prov_destino_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.BeforeExecuteQueryEventArgs) Handles lkl_prov_destino.BeforeExecuteQuery
        If LibXConnector1.State = LibX.LibxConnectorState.Edit Then
            e.aditionalWhere = " 1=1 and prov_code <> " & Me.xtxt_prov_code.Text.Trim
        End If
    End Sub
End Class
