Imports SGT.Contabilidad.Entidades
Public Class r_cgresul01
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents btnIniciar As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPerdr_year As System.Windows.Forms.TextBox
    Friend WithEvents txtperdr_num As System.Windows.Forms.TextBox
    Friend WithEvents txtDept_code As System.Windows.Forms.TextBox
    Friend WithEvents lbldept_name As System.Windows.Forms.Label
    Friend WithEvents xlk_dept_code As LibX.LibXLookup
    Friend WithEvents Chk_resumen As LibX.LibxCheckBox
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents DataTable2 As System.Data.DataTable
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents DataColumn17 As System.Data.DataColumn
    Friend WithEvents DataColumn18 As System.Data.DataColumn
    Friend WithEvents DataColumn19 As System.Data.DataColumn
    Friend WithEvents LibXDbSourceTable2 As LibX.LibXDbSourceTable
    Friend WithEvents cgestresulm As System.Data.DataTable
    Friend WithEvents DataColumn20 As System.Data.DataColumn
    Friend WithEvents DataColumn21 As System.Data.DataColumn
    Friend WithEvents DataColumn22 As System.Data.DataColumn
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents estado_name As System.Windows.Forms.Label
    Friend WithEvents xtxtestado As System.Windows.Forms.TextBox
    Friend WithEvents DataColumn23 As System.Data.DataColumn
    Friend WithEvents DataColumn24 As System.Data.DataColumn
    Friend WithEvents DataColumn25 As System.Data.DataColumn
    Friend WithEvents LibXLookup1 As LibX.LibXLookup
    Friend WithEvents DataColumn26 As System.Data.DataColumn
    Friend WithEvents DataColumn27 As System.Data.DataColumn
    Friend WithEvents DataColumn28 As System.Data.DataColumn
    Friend WithEvents LibXLookup2 As LibX.LibXLookup
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DataColumn29 As System.Data.DataColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LibXLookup2 = New LibX.LibXLookup
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.DataSet1 = New System.Data.DataSet
        Me.DataTable2 = New System.Data.DataTable
        Me.DataColumn9 = New System.Data.DataColumn
        Me.DataColumn10 = New System.Data.DataColumn
        Me.DataColumn11 = New System.Data.DataColumn
        Me.DataColumn12 = New System.Data.DataColumn
        Me.DataColumn13 = New System.Data.DataColumn
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn23 = New System.Data.DataColumn
        Me.DataColumn27 = New System.Data.DataColumn
        Me.cgestresulm = New System.Data.DataTable
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn7 = New System.Data.DataColumn
        Me.DataColumn8 = New System.Data.DataColumn
        Me.DataColumn14 = New System.Data.DataColumn
        Me.DataColumn15 = New System.Data.DataColumn
        Me.DataColumn16 = New System.Data.DataColumn
        Me.DataColumn17 = New System.Data.DataColumn
        Me.DataColumn18 = New System.Data.DataColumn
        Me.DataColumn19 = New System.Data.DataColumn
        Me.DataColumn20 = New System.Data.DataColumn
        Me.DataColumn21 = New System.Data.DataColumn
        Me.DataColumn22 = New System.Data.DataColumn
        Me.DataColumn24 = New System.Data.DataColumn
        Me.DataColumn25 = New System.Data.DataColumn
        Me.DataColumn26 = New System.Data.DataColumn
        Me.DataColumn28 = New System.Data.DataColumn
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.DataColumn29 = New System.Data.DataColumn
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.LibXLookup1 = New LibX.LibXLookup
        Me.estado_name = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.xtxtestado = New System.Windows.Forms.TextBox
        Me.Chk_resumen = New LibX.LibxCheckBox
        Me.xlk_dept_code = New LibX.LibXLookup
        Me.lbldept_name = New System.Windows.Forms.Label
        Me.txtPerdr_year = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtperdr_num = New System.Windows.Forms.TextBox
        Me.txtDept_code = New System.Windows.Forms.TextBox
        Me.btnIniciar = New System.Windows.Forms.Button
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.GroupBox1.SuspendLayout()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cgestresulm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(560, 48)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ESTADO DE RESULTADO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LibXLookup2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.LibXLookup1)
        Me.GroupBox1.Controls.Add(Me.estado_name)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.xtxtestado)
        Me.GroupBox1.Controls.Add(Me.Chk_resumen)
        Me.GroupBox1.Controls.Add(Me.xlk_dept_code)
        Me.GroupBox1.Controls.Add(Me.lbldept_name)
        Me.GroupBox1.Controls.Add(Me.txtPerdr_year)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtperdr_num)
        Me.GroupBox1.Controls.Add(Me.txtDept_code)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(464, 128)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'LibXLookup2
        '
        Me.LibXLookup2.AlternateFieldSearch = Nothing
        Me.LibXLookup2.BeginCheck = False
        Me.LibXLookup2.CheckText = Nothing
        Me.LibXLookup2.ComboMode = False
        Me.LibXLookup2.DataMember = Nothing
        Me.LibXLookup2.DataSource = Me.LibXConnector1
        Me.LibXLookup2.DestParameters = New String() {"suc_code=suc_code", "Label4=suc_name"}
        Me.LibXLookup2.FilterField = "suc_name"
        Me.LibXLookup2.IgnoreFindInBrowseMode = False
        Me.LibXLookup2.isCanceled = False
        Me.LibXLookup2.Location = New System.Drawing.Point(424, 63)
        Me.LibXLookup2.LookCaption = "Sucursales"
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
        Me.LibXLookup2.SrcParameters = New String() {"suc_code=suc_code"}
        Me.LibXLookup2.TabIndex = 29
        Me.LibXLookup2.TableName = "cgsucursal"
        Me.LibXLookup2.TabStop = False
        Me.LibXLookup2.UseCopyConnection = False
        Me.LibXLookup2.UseRowRetrieveEvents = False
        Me.LibXLookup2.UseTab = False
        Me.LibXLookup2.VisParameters = New String() {"Código=suc_code", "Nombre=suc_name"}
        Me.LibXLookup2.WhereCondition = Nothing
        Me.LibXLookup2.WhereParameters = Nothing
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
        Me.LibXConnector1.DataMember = "cgacctd"
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
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.LibXDbSourceTable1, Me.LibXDbSourceTable2})
        Me.LibXConnector1.State = LibX.LibxConnectorState.none
        Me.LibXConnector1.UpdatePrimaryKeyColumns = False
        Me.LibXConnector1.UseTransactions = False
        '
        'DataSet1
        '
        Me.LibXConnector1.SetDataGenerator(Me.DataSet1, Me.LibXConnector1)
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, True)
        Me.DataSet1.EnforceConstraints = False
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable2, Me.cgestresulm})
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn23, Me.DataColumn27})
        Me.DataTable2.TableName = "cgacctd"
        '
        'DataColumn9
        '
        Me.DataColumn9.AllowDBNull = False
        Me.DataColumn9.ColumnName = "acct_no"
        Me.DataColumn9.MaxLength = 20
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "acct_name"
        Me.DataColumn10.MaxLength = 60
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "debit_amount"
        Me.DataColumn11.DataType = GetType(System.Decimal)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "credit_amount"
        Me.DataColumn12.DataType = GetType(System.Decimal)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "balance"
        Me.DataColumn13.DataType = GetType(System.Decimal)
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.ColumnName = "perdr_num"
        Me.DataColumn1.DataType = GetType(System.Int32)
        '
        'DataColumn2
        '
        Me.DataColumn2.AllowDBNull = False
        Me.DataColumn2.ColumnName = "perdr_year"
        Me.DataColumn2.DataType = GetType(System.Int32)
        '
        'DataColumn3
        '
        Me.DataColumn3.AllowDBNull = False
        Me.DataColumn3.ColumnName = "dept_code"
        Me.DataColumn3.DataType = GetType(System.Int32)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "initial"
        Me.DataColumn4.DataType = GetType(System.Decimal)
        '
        'DataColumn23
        '
        Me.DataColumn23.Caption = "estado"
        Me.DataColumn23.ColumnName = "estado"
        Me.DataColumn23.DataType = GetType(System.Int32)
        '
        'DataColumn27
        '
        Me.DataColumn27.AllowDBNull = False
        Me.DataColumn27.ColumnName = "suc_code"
        Me.DataColumn27.DataType = GetType(System.Int32)
        '
        'cgestresulm
        '
        Me.cgestresulm.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn28, Me.DataColumn29})
        Me.cgestresulm.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"cgt_serial"}, True)})
        Me.cgestresulm.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn5}
        Me.cgestresulm.TableName = "cgestresulm"
        '
        'DataColumn5
        '
        Me.DataColumn5.AllowDBNull = False
        Me.DataColumn5.ColumnName = "cgt_serial"
        Me.DataColumn5.MaxLength = 10
        Me.DataColumn5.ReadOnly = True
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "perdr_year"
        Me.DataColumn6.DataType = GetType(System.Int32)
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "perdr_num"
        Me.DataColumn7.DataType = GetType(System.Int32)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "acct_type"
        Me.DataColumn8.DataType = GetType(System.Int32)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "acct_no"
        Me.DataColumn14.MaxLength = 20
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "acct_name"
        Me.DataColumn15.MaxLength = 50
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "balance"
        Me.DataColumn16.DataType = GetType(System.Decimal)
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "ic_balinit"
        Me.DataColumn17.DataType = GetType(System.Decimal)
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "ic_balfin"
        Me.DataColumn18.DataType = GetType(System.Decimal)
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "resultado"
        Me.DataColumn19.DataType = GetType(System.Decimal)
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "dept_code"
        Me.DataColumn20.DataType = GetType(System.Int32)
        '
        'DataColumn21
        '
        Me.DataColumn21.AllowDBNull = False
        Me.DataColumn21.ColumnName = "line_no"
        Me.DataColumn21.DataType = GetType(System.Int32)
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "result_date"
        Me.DataColumn22.DataType = GetType(System.DateTime)
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "grupo_id"
        Me.DataColumn24.DataType = GetType(System.Int32)
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "nivel_id"
        Me.DataColumn25.DataType = GetType(System.Int32)
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "tipo_result"
        Me.DataColumn26.DataType = GetType(System.Int32)
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "nivel_suma"
        Me.DataColumn28.DataType = GetType(System.Int32)
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
        Me.LibXDbSourceTable1.Source = New String() {"select cgacctd.*,cgacctm.acct_name from cgacctm", "INNER JOIN cgacctd on cgacctd.acct_no = cgacctm.acct_no "}
        Me.LibXDbSourceTable1.TableName = "cgacctd"
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
        Me.LibXDbSourceTable2.FillOnRowChange = False
        Me.LibXDbSourceTable2.HeaderIsOnGrid = False
        Me.LibXDbSourceTable2.InnerJon = True
        Me.LibXDbSourceTable2.InsertOrder = 0
        Me.LibXDbSourceTable2.IsDetail = False
        Me.LibXDbSourceTable2.KeyFields = Nothing
        Me.LibXDbSourceTable2.LineColName = Nothing
        Me.LibXDbSourceTable2.MasterDetailRelation = Nothing
        Me.LibXDbSourceTable2.MasterTableName = Nothing
        Me.LibXDbSourceTable2.SerialColumnName = "cgt_serial"
        Me.LibXDbSourceTable2.Sort = Nothing
        Me.LibXDbSourceTable2.Source = Nothing
        Me.LibXDbSourceTable2.TableName = "cgestresulm"
        Me.LibXDbSourceTable2.UpdateOrder = 0
        Me.LibXDbSourceTable2.UseRowRetrieve = False
        '
        'DataColumn29
        '
        Me.DataColumn29.AllowDBNull = False
        Me.DataColumn29.ColumnName = "suc_code"
        Me.DataColumn29.DataType = GetType(System.Int32)
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(160, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(264, 20)
        Me.Label4.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(48, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 16)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Sucursal:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cgestresulm.suc_code"))
        Me.TextBox1.Location = New System.Drawing.Point(104, 63)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(56, 20)
        Me.TextBox1.TabIndex = 27
        Me.TextBox1.Text = ""
        '
        'LibXLookup1
        '
        Me.LibXLookup1.AlternateFieldSearch = Nothing
        Me.LibXLookup1.BeginCheck = False
        Me.LibXLookup1.CheckText = Nothing
        Me.LibXLookup1.ComboMode = False
        Me.LibXLookup1.DataMember = Nothing
        Me.LibXLookup1.DataSource = Me.LibXConnector1
        Me.LibXLookup1.DestParameters = New String() {"xtxtesta=estfn_code", "estado_name=estfn_name"}
        Me.LibXLookup1.FilterField = "estfn_name"
        Me.LibXLookup1.IgnoreFindInBrowseMode = False
        Me.LibXLookup1.isCanceled = False
        Me.LibXLookup1.Location = New System.Drawing.Point(424, 16)
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
        Me.LibXLookup1.SrcParameters = New String() {"estfn_code=xtxtestado"}
        Me.LibXLookup1.TabIndex = 25
        Me.LibXLookup1.TableName = Nothing
        Me.LibXLookup1.TabStop = False
        Me.LibXLookup1.UseCopyConnection = False
        Me.LibXLookup1.UseRowRetrieveEvents = False
        Me.LibXLookup1.UseTab = False
        Me.LibXLookup1.VisParameters = New String() {"Código=estfn_code", "Nombre=estfn_name"}
        Me.LibXLookup1.WhereCondition = Nothing
        Me.LibXLookup1.WhereParameters = Nothing
        '
        'estado_name
        '
        Me.estado_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.estado_name.Location = New System.Drawing.Point(160, 16)
        Me.estado_name.Name = "estado_name"
        Me.estado_name.Size = New System.Drawing.Size(264, 20)
        Me.estado_name.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(16, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 16)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Modelo Estado:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxtestado
        '
        Me.xtxtestado.Location = New System.Drawing.Point(104, 16)
        Me.xtxtestado.Name = "xtxtestado"
        Me.xtxtestado.Size = New System.Drawing.Size(56, 20)
        Me.xtxtestado.TabIndex = 23
        Me.xtxtestado.Text = ""
        '
        'Chk_resumen
        '
        Me.Chk_resumen.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Chk_resumen.EditInitialValue = Nothing
        Me.Chk_resumen.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Chk_resumen.FindInitialValue = Nothing
        Me.Chk_resumen.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Chk_resumen.IgnoreRequiered = False
        Me.Chk_resumen.KeepEnabled = False
        Me.Chk_resumen.Location = New System.Drawing.Point(343, 36)
        Me.Chk_resumen.Name = "Chk_resumen"
        Me.Chk_resumen.NewInitialValue = Nothing
        Me.Chk_resumen.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Chk_resumen.ReadOnly = False
        Me.Chk_resumen.Requiered = False
        Me.Chk_resumen.Size = New System.Drawing.Size(80, 24)
        Me.Chk_resumen.TabIndex = 21
        Me.Chk_resumen.Text = "Resumido"
        Me.Chk_resumen.ThreeState = True
        Me.Chk_resumen.value = Nothing
        '
        'xlk_dept_code
        '
        Me.xlk_dept_code.AlternateFieldSearch = Nothing
        Me.xlk_dept_code.BeginCheck = False
        Me.xlk_dept_code.CheckText = Nothing
        Me.xlk_dept_code.ComboMode = False
        Me.xlk_dept_code.DataMember = Nothing
        Me.xlk_dept_code.DataSource = Me.LibXConnector1
        Me.xlk_dept_code.DestParameters = New String() {"txtDept_code=dept_code", "lbldept_name=dept_name"}
        Me.xlk_dept_code.FilterField = Nothing
        Me.xlk_dept_code.IgnoreFindInBrowseMode = False
        Me.xlk_dept_code.isCanceled = False
        Me.xlk_dept_code.Location = New System.Drawing.Point(424, 88)
        Me.xlk_dept_code.LookCaption = Nothing
        Me.xlk_dept_code.Name = "xlk_dept_code"
        Me.xlk_dept_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_dept_code.ShowFilter = True
        Me.xlk_dept_code.ShowMessageNotFound = True
        Me.xlk_dept_code.ShowWarning = False
        Me.xlk_dept_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_dept_code.SizesColumns = Nothing
        Me.xlk_dept_code.SizesColumnsTab = Nothing
        Me.xlk_dept_code.SqlString = Nothing
        Me.xlk_dept_code.SQLTab = Nothing
        Me.xlk_dept_code.SrcParameters = New String() {"dept_code=txtDept_code"}
        Me.xlk_dept_code.TabIndex = 18
        Me.xlk_dept_code.TableName = "cgdeptm"
        Me.xlk_dept_code.TabStop = False
        Me.xlk_dept_code.UseCopyConnection = False
        Me.xlk_dept_code.UseRowRetrieveEvents = False
        Me.xlk_dept_code.UseTab = False
        Me.xlk_dept_code.VisParameters = New String() {"Código=dept_code", "Nombre=dept_name"}
        Me.xlk_dept_code.WhereCondition = Nothing
        Me.xlk_dept_code.WhereParameters = Nothing
        '
        'lbldept_name
        '
        Me.lbldept_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbldept_name.Location = New System.Drawing.Point(160, 88)
        Me.lbldept_name.Name = "lbldept_name"
        Me.lbldept_name.Size = New System.Drawing.Size(264, 20)
        Me.lbldept_name.TabIndex = 16
        '
        'txtPerdr_year
        '
        Me.txtPerdr_year.Location = New System.Drawing.Point(104, 40)
        Me.txtPerdr_year.Name = "txtPerdr_year"
        Me.txtPerdr_year.Size = New System.Drawing.Size(56, 20)
        Me.txtPerdr_year.TabIndex = 15
        Me.txtPerdr_year.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(18, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Periodo Actual:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(20, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Departamento:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtperdr_num
        '
        Me.txtperdr_num.Location = New System.Drawing.Point(160, 40)
        Me.txtperdr_num.Name = "txtperdr_num"
        Me.txtperdr_num.Size = New System.Drawing.Size(48, 20)
        Me.txtperdr_num.TabIndex = 15
        Me.txtperdr_num.Text = ""
        '
        'txtDept_code
        '
        Me.txtDept_code.Location = New System.Drawing.Point(104, 88)
        Me.txtDept_code.Name = "txtDept_code"
        Me.txtDept_code.Size = New System.Drawing.Size(56, 20)
        Me.txtDept_code.TabIndex = 15
        Me.txtDept_code.Text = ""
        '
        'btnIniciar
        '
        Me.btnIniciar.Location = New System.Drawing.Point(480, 100)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.TabIndex = 2
        Me.btnIniciar.Text = "Iniciar"
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(480, 124)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.TabIndex = 2
        Me.btnCerrar.Text = "Cerrar"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 199)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(560, 23)
        Me.ProgressBar1.TabIndex = 13
        '
        'r_cgresul01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(560, 222)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnIniciar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCerrar)
        Me.Name = "r_cgresul01"
        Me.Text = "Reporte de Estado de Resultado"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cgestresulm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim oPeriodo As Periodo
    Dim WithEvents oAnoFiscal As AnoFiscal
    Dim Serial As String

    Private Sub r_cgbalcpr01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            LibXConnector1.Find()

            oAnoFiscal = New AnoFiscal
            oPeriodo = oAnoFiscal.BuscarPeriodoActual

            txtperdr_num.Text = oPeriodo.Number.ToString
            txtPerdr_year.Text = oPeriodo.year.ToString

            LibXConnector1.CurrentDataRow!perdr_year = oPeriodo.year.ToString
            LibXConnector1.CurrentDataRow!perdr_num = oPeriodo.Number.ToString

            'xdt_FechaInicial.Value = oPeriodo.From
            'xdt_FechaFinal.Value = oPeriodo.Thru

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIniciar.Click
        Me.LibXConnector1.AcceptFind()
        Me.LibXConnector1.Find()

        Try
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        If MessageBox.Show("Seguro desea cerrar?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            Me.Close()
        End If

    End Sub

    Private Sub Chk_resumen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_resumen.CheckedChanged
        ''If Me.Chk_resumen.Checked = True Then
        ''    Label1.Text = "ESTADO DE RESULTADO(Resumido)"
        ''Else
        Label1.Text = "ESTADO DE RESULTADO"
        ''End If
    End Sub

    Private Sub LibXConnector1_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.XBeforeExecuteQueryEventArgs) Handles LibXConnector1.BeforeExecuteQuery
        Dim oReport As LibX.ReportLib
        Dim SelecStmt, SelecStmt1, SelecStmt2 As String
        Dim sWhere As String
        Dim Periodo, Anio As Integer
        Dim xSelect As LibX.Data.XSelecStmt
        Dim xUpdate As LibX.Data.XUpdateStmt
        Dim xDelete As LibX.Data.XDeleteStmt
        Dim oEstado, oSucursal As DataTable
        Dim ID, ic_status, oSucur As Integer
        Dim iC_resulBal As Decimal
        Try

            If txtperdr_num.Text.Trim <> "" Then
                sWhere = LibX.ConcatWherePart(sWhere, " cgacctd.perdr_num = " & txtperdr_num.Text)
            End If

            If txtPerdr_year.Text.Trim <> "" Then
                sWhere = LibX.ConcatWherePart(sWhere, " cgacctd.perdr_year= " & txtPerdr_year.Text)
            End If

            If txtDept_code.Text.Trim <> "" Then
                sWhere = LibX.ConcatWherePart(sWhere, " cgacctd.dept_code = " & txtDept_code.Text)
            End If

            If Val(TextBox1.Text) > 0 Then
                sWhere = LibX.ConcatWherePart(sWhere, " cgacctd.suc_code = " & Val(TextBox1.Text))
                oSucur = Val(TextBox1.Text)
            End If

            sWhere = LibX.ConcatWherePart(sWhere, " cgacctd.balance <> 0 ")
            '//Buscar el Inventario del periodo anterior 

            Periodo = Val(txtperdr_num.Text) - 1
            If Periodo = 0 Then
                Periodo = 12
            End If

            If Periodo = 12 Then
                Anio = Val(txtPerdr_year.Text) - 1
            Else
                Anio = Val(txtPerdr_year.Text)
            End If

            SelecStmt = " select perdr_status from cgperdd  where cgperdd.perdr_year = " & txtPerdr_year.Text & " And cgperdd.perdr_num = " & txtperdr_num.Text
            ic_status = LibX.Data.Manager.GetScalar(SelecStmt)

            Serial = Val(txtperdr_num.Text).ToString("00") & "-" & Val(txtPerdr_year.Text)

            If ic_status = 1 Then

                xDelete = New LibX.Data.XDeleteStmt("cgestresulm")
                xDelete.Fields("cgt_serial") = Serial
                xDelete.Execute()

                If oSucur > 0 Then
                    SelecStmt = "select * from cgsucursal where suc_code = " & oSucur
                Else
                    SelecStmt = "select * from cgsucursal"
                End If
                oSucursal = LibX.Data.Manager.GetDataTable(SelecStmt)

                For Each oRow1 As DataRow In oSucursal.Rows

                    SelecStmt1 = " SELECT 1 estfn_tipo,5 type_code,2 estfn_groupid,2 estfn_nivel,0 acct_no,'INVENTARIO INICIAL' acct_name," & _
                                 " 0 dept_code,isnull(ic_balance,0)balance,cgperdd.thru_date,cgperdd.suc_code from cgperdd  " & _
                                 " where cgperdd.perdr_year = " & Anio & " and cgperdd.perdr_num = " & Periodo & _
                                 " and cgperdd.suc_code = " & oRow1!suc_code

                    SelecStmt = " UNION SELECT estfn_tipo,cgacctm.acct_type,cgestfnd.estfn_groupid,isnull(estfn_nivel,0),cgestfnd.acct_no ," & _
                                " cgestfnd.acct_descr,cgacctd.dept_code,cgacctd.balance,cgperdd.thru_date,cgacctd.suc_code " & _
                                " FROM  cgestfnd cgestfnd INNER JOIN cgacctd cgacctd " & _
                                " ON cgestfnd.acct_no = cgacctd.acct_no " & _
                                " INNER JOIN cgperdd on cgacctd.perdr_num = cgperdd.perdr_num " & _
                                " INNER JOIN cgacctm on cgacctd.acct_no = cgacctm.acct_no " & _
                                " INNER JOIN cgestfnm on cgestfnd.estfn_code = cgestfnm.estfn_code " & _
                                " and cgacctd.perdr_year = cgperdd.perdr_year and estfn_tipo = 1 " & _
                                " and cgacctd.suc_code = " & oRow1!suc_code

                    SelecStmt = SelecStmt1 & LibX.MdlUtil.ConcatWherePart(SelecStmt, sWhere)

                    SelecStmt2 = " UNION " & _
                                " SELECT 1 estfn_tipo,5 type_code,2 estfn_groupid,2 estfn_nivel,99999999 acct_no,'INVENTARIO FINAL' acct_name,0 " & _
                                " dept_code,isnull(ic_balance,0)* -1 balance,cgperdd.thru_date,cgperdd.suc_code from cgperdd " & _
                                " where cgperdd.perdr_year = " & txtPerdr_year.Text & " And cgperdd.perdr_num = " & txtperdr_num.Text & _
                                " and cgperdd.suc_code = " & oRow1!suc_code

                    SelecStmt = SelecStmt & SelecStmt2
                    SelecStmt = SelecStmt & " order by cgperdd.suc_code,cgestfnd.estfn_groupid ASC,estfn_nivel,cgestfnd.acct_no "
                    oEstado = LibX.Data.Manager.GetDataTable(SelecStmt)

                    ID = 1

                    If oEstado.Rows.Count() = 0 Then
                        GoTo Next_suctsal
                    End If

                    For Each oRow As DataRow In oEstado.Rows
                        Dim result As DataRow = cgestresulm.NewRow
                        result!cgt_serial = Serial
                        result!line_no = ID
                        result!tipo_result = oRow!estfn_tipo
                        result!acct_type = oRow!type_code
                        result!grupo_id = oRow!estfn_groupid
                        result!nivel_id = oRow!estfn_nivel
                        result!perdr_num = txtperdr_num.Text
                        result!perdr_year = txtPerdr_year.Text
                        result!acct_no = oRow!acct_no
                        result!acct_name = oRow!acct_name
                        result!dept_code = oRow!dept_code
                        result!balance = oRow!balance
                        result!result_date = oRow!thru_date
                        result!suc_code = oRow!suc_code

                        If result!balance <> 0 Then
                            cgestresulm.Rows.Add(result)
                        End If
                        ID = ID + 1
                        iC_resulBal = iC_resulBal + oRow!balance
                    Next

                    'LibX.Data.Manager.Connection.BeginTransaction()

                    LibX.Data.Manager.Save(cgestresulm)

                    xUpdate = New LibX.Data.XUpdateStmt("cgperdd")
                    xUpdate.FieldsSet("result_balance") = iC_resulBal
                    xUpdate.Fields("perdr_num") = txtperdr_num.Text
                    xUpdate.Fields("perdr_year") = txtPerdr_year.Text
                    xUpdate.Fields("suc_code") = oRow1!suc_code
                    xUpdate.Execute()
Next_suctsal:
                Next

                'If LibX.Data.Manager.Connection.IsIntransaction = True Then
                '    LibX.Data.Manager.Connection.CommitTransaction()
                'End If

                'If cgestresulm.Rows.Count > 0 Then
                'mprimir()
            End If
                'Else
                imprimir()
                'End If

        Catch ex As Exception
            LibX.Log.Show(ex)
            'If LibX.Data.Manager.Connection.IsIntransaction = True Then
            '    LibX.Data.Manager.Connection.RollBackTransaction()
            'End If
        End Try

    End Sub

    Private Sub imprimir()
        Dim oReport As LibX.ReportLib
        Dim SQLString As String
        Dim WhereString As String
        Dim InvInicial As Decimal
        Dim Periodo, Anio As Integer
        Try

            If txtperdr_num.Text.Trim <> "" Then
                WhereString = LibX.ConcatWherePart(WhereString, "cgestresulm.perdr_num = " & txtperdr_num.Text)
            End If

            If txtPerdr_year.Text.Trim <> "" Then
                WhereString = LibX.ConcatWherePart(WhereString, "cgestresulm.perdr_year= " & txtPerdr_year.Text)
            End If

            If txtDept_code.Text.Trim <> "" Then
                WhereString = LibX.ConcatWherePart(WhereString, "cgestresulm.dept_code = " & txtDept_code.Text)
            End If

            If Val(TextBox1.Text) > 0 Then
                WhereString = LibX.ConcatWherePart(WhereString, " cgestresulm.suc_code = " & Val(TextBox1.Text))
            End If

            WhereString = LibX.ConcatWherePart(WhereString, "cgestresulm.cgt_serial = '" & Serial & "' And cgestresulm.tipo_result = 1 ")

            '//Buscar el Inventario del periodo anterior 
            Periodo = Val(txtperdr_num.Text) - 1
            If Periodo = 0 Then
                Periodo = 12
            End If
            If Periodo = 12 Then
                Anio = Val(txtPerdr_year.Text) - 1
            Else
                Anio = Val(txtPerdr_year.Text)
            End If

            oReport = New LibX.ReportLib("CTG", "r_cgresul01.rpt")

            '''oReport.ParameterFields(1) = String.Concat("perdr_year;", Trim(txtPerdr_year.Text), ";TRUE")
            '''oReport.ParameterFields(0) = String.Concat("perdr_num;", Trim(txtperdr_num.Text), ";TRUE")

            oReport.RetrieveSQLQuery()
            SQLString = oReport.SQLQuery
            SQLString = LibX.ConcatWherePart(SQLString, WhereString)
            oReport.SQLQuery = SQLString

            oReport.Action = 1

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

End Class
