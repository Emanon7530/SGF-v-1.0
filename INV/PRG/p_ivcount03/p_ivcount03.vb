Imports LibX
Public Class p_ivcount03
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
    Friend WithEvents xivcounte As LibX.LibXDbSourceTable
    Friend WithEvents xivcountd As LibX.LibXDbSourceTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents ivcounte As System.Data.DataTable
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LibXLookup1 As LibX.LibXLookup
    Friend WithEvents XTextBox4 As LibX.XTextBox
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents DataColumn27 As System.Data.DataColumn
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblCountNo As System.Windows.Forms.Label
    Friend WithEvents whse_name As LibX.XTextBox
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents DataColumn21 As System.Data.DataColumn
    Friend WithEvents DataColumn22 As System.Data.DataColumn
    Friend WithEvents DataColumn23 As System.Data.DataColumn
    Friend WithEvents DataColumn24 As System.Data.DataColumn
    Friend WithEvents DataColumn31 As System.Data.DataColumn
    Friend WithEvents DataColumn32 As System.Data.DataColumn
    Friend WithEvents DataColumn33 As System.Data.DataColumn
    Friend WithEvents DataColumn34 As System.Data.DataColumn
    Friend WithEvents DataColumn35 As System.Data.DataColumn
    Friend WithEvents DataColumn36 As System.Data.DataColumn
    Friend WithEvents LibXLookup5 As LibX.LibXLookup
    Friend WithEvents XTextBox6 As LibX.XTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LibXLookup6 As LibX.LibXLookup
    Friend WithEvents XTextBox9 As LibX.XTextBox
    Friend WithEvents LibxCheckBox1 As LibX.LibxCheckBox
    Friend WithEvents prov_name As LibX.XTextBox
    Friend WithEvents item_name As LibX.XTextBox
    Friend WithEvents DataColumn25 As System.Data.DataColumn
    Friend WithEvents DataColumn26 As System.Data.DataColumn
    Friend WithEvents ivcountd As System.Data.DataTable
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.DataSet1 = New System.Data.DataSet
        Me.ivcounte = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn7 = New System.Data.DataColumn
        Me.DataColumn8 = New System.Data.DataColumn
        Me.DataColumn27 = New System.Data.DataColumn
        Me.DataTable1 = New System.Data.DataTable
        Me.DataColumn21 = New System.Data.DataColumn
        Me.DataColumn22 = New System.Data.DataColumn
        Me.DataColumn23 = New System.Data.DataColumn
        Me.DataColumn24 = New System.Data.DataColumn
        Me.DataColumn31 = New System.Data.DataColumn
        Me.DataColumn32 = New System.Data.DataColumn
        Me.DataColumn33 = New System.Data.DataColumn
        Me.DataColumn34 = New System.Data.DataColumn
        Me.DataColumn35 = New System.Data.DataColumn
        Me.DataColumn36 = New System.Data.DataColumn
        Me.DataColumn25 = New System.Data.DataColumn
        Me.DataColumn26 = New System.Data.DataColumn
        Me.xdbivitemd = New LibX.LibXDbSourceTable
        Me.xivcounte = New LibX.LibXDbSourceTable
        Me.xivcountd = New LibX.LibXDbSourceTable
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
        Me.XTextBox4 = New LibX.XTextBox
        Me.whse_name = New LibX.XTextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.lblCountNo = New System.Windows.Forms.Label
        Me.LibXLookup5 = New LibX.LibXLookup
        Me.XTextBox6 = New LibX.XTextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.prov_name = New LibX.XTextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.LibXLookup6 = New LibX.LibXLookup
        Me.XTextBox9 = New LibX.XTextBox
        Me.item_name = New LibX.XTextBox
        Me.LibxCheckBox1 = New LibX.LibxCheckBox
        Me.ivcountd = New System.Data.DataTable
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ivcounte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ivcountd, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.LibXConnector1.ModuleName = ""
        Me.LibXConnector1.OwnerForm = Me
        Me.LibXConnector1.Parameters = Nothing
        Me.LibXConnector1.RecordCount = 0
        Me.LibXConnector1.ReportMode = False
        Me.LibXConnector1.ReportName = ""
        Me.LibXConnector1.ReportObject = Nothing
        Me.LibXConnector1.RequeryData = False
        Me.LibXConnector1.ShowWarningCancel = True
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.xdbivitemd, Me.xivcounte, Me.xivcountd})
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
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.ivcounte, Me.DataTable1, Me.ivcountd})
        '
        'ivcounte
        '
        Me.ivcounte.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn27})
        Me.ivcounte.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"count_serial", "PageNo"}, True)})
        Me.ivcounte.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn3}
        Me.ivcounte.TableName = "ivcounte"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.AutoIncrement = True
        Me.DataColumn1.AutoIncrementSeed = CType(1, Long)
        Me.DataColumn1.ColumnName = "count_serial"
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
        Me.DataColumn3.AllowDBNull = False
        Me.DataColumn3.ColumnName = "PageNo"
        Me.DataColumn3.DataType = GetType(System.Int32)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "whse_code"
        Me.DataColumn4.DataType = GetType(System.Int32)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "count_date"
        Me.DataColumn5.DataType = GetType(System.DateTime)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "count_desc"
        Me.DataColumn6.MaxLength = 60
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "count_status"
        Me.DataColumn7.DataType = GetType(System.Int32)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "userid"
        Me.DataColumn8.MaxLength = 18
        '
        'DataColumn27
        '
        Me.DataColumn27.AllowDBNull = False
        Me.DataColumn27.ColumnName = "count_number"
        Me.DataColumn27.DataType = GetType(System.Int32)
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn25, Me.DataColumn26})
        Me.DataTable1.TableName = "ivitemm"
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
        Me.DataColumn32.DataType = GetType(System.Int32)
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "loc_col"
        Me.DataColumn33.DataType = GetType(System.Int32)
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "estante"
        Me.DataColumn34.MaxLength = 5
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
        "_code,", " ivitemd.loc_row,loc_col,estante,whse_code,existencia,frizado_inv", "from ivitemm inner join ivitemd ", "on ivitemm.item_code = ivitemd.item_code"}
        Me.xdbivitemd.TableName = "ivitemm"
        Me.xdbivitemd.UpdateOrder = 0
        Me.xdbivitemd.UseRowRetrieve = False
        '
        'xivcounte
        '
        Me.xivcounte.AllowDelete = True
        Me.xivcounte.AllowEdit = True
        Me.xivcounte.AllowNew = True
        Me.xivcounte.AutoIncrementSerial = False
        Me.xivcounte.CustomDbUpdate = False
        Me.xivcounte.DeleteOrder = 0
        Me.xivcounte.FillOnQuery = True
        Me.xivcounte.FillOnRowChange = False
        Me.xivcounte.HeaderIsOnGrid = False
        Me.xivcounte.InnerJon = True
        Me.xivcounte.InsertOrder = 0
        Me.xivcounte.IsDetail = False
        Me.xivcounte.KeyFields = Nothing
        Me.xivcounte.LineColName = Nothing
        Me.xivcounte.MasterDetailRelation = Nothing
        Me.xivcounte.MasterTableName = Nothing
        Me.xivcounte.SerialColumnName = Nothing
        Me.xivcounte.Sort = Nothing
        Me.xivcounte.Source = Nothing
        Me.xivcounte.TableName = "ivcounte"
        Me.xivcounte.UpdateOrder = 0
        Me.xivcounte.UseRowRetrieve = False
        '
        'xivcountd
        '
        Me.xivcountd.AllowDelete = True
        Me.xivcountd.AllowEdit = True
        Me.xivcountd.AllowNew = True
        Me.xivcountd.AutoIncrementSerial = False
        Me.xivcountd.CustomDbUpdate = False
        Me.xivcountd.DeleteOrder = 0
        Me.xivcountd.FillOnQuery = True
        Me.xivcountd.FillOnRowChange = False
        Me.xivcountd.HeaderIsOnGrid = False
        Me.xivcountd.InnerJon = True
        Me.xivcountd.InsertOrder = 0
        Me.xivcountd.IsDetail = False
        Me.xivcountd.KeyFields = Nothing
        Me.xivcountd.LineColName = Nothing
        Me.xivcountd.MasterDetailRelation = Nothing
        Me.xivcountd.MasterTableName = Nothing
        Me.xivcountd.SerialColumnName = Nothing
        Me.xivcountd.Sort = Nothing
        Me.xivcountd.Source = Nothing
        Me.xivcountd.TableName = "ivcountd"
        Me.xivcountd.UpdateOrder = 0
        Me.xivcountd.UseRowRetrieve = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Location = New System.Drawing.Point(40, 160)
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
        Me.GroupBox1.Size = New System.Drawing.Size(88, 232)
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
        Me.GroupBox2.Location = New System.Drawing.Point(8, 288)
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
        Me.Label1.Location = New System.Drawing.Point(296, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Ultimo Conteo:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblLastClose
        '
        Me.lblLastClose.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLastClose.Location = New System.Drawing.Point(384, 72)
        Me.lblLastClose.Name = "lblLastClose"
        Me.lblLastClose.Size = New System.Drawing.Size(96, 20)
        Me.lblLastClose.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Location = New System.Drawing.Point(56, 136)
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
        Me.Label4.Location = New System.Drawing.Point(56, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Marca:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'XTextBox3
        '
        Me.XTextBox3.AcceptsReturn = True
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
        Me.XTextBox3.TabIndex = 0
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
        Me.Label8.Location = New System.Drawing.Point(48, 208)
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
        'XTextBox4
        '
        Me.XTextBox4.AcceptsReturn = True
        Me.XTextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemm.whse_code"))
        Me.XTextBox4.EditInitialValue = Nothing
        Me.XTextBox4.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox4.FieldDescription = ""
        Me.XTextBox4.FindInitialValue = Nothing
        Me.XTextBox4.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox4.IgnoreRequiered = False
        Me.XTextBox4.Location = New System.Drawing.Point(104, 200)
        Me.XTextBox4.Name = "XTextBox4"
        Me.XTextBox4.NewInitialValue = Nothing
        Me.XTextBox4.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox4.Requiered = False
        Me.XTextBox4.Size = New System.Drawing.Size(48, 20)
        Me.XTextBox4.StatusBarPanelDescripcion = Nothing
        Me.XTextBox4.TabIndex = 4
        Me.XTextBox4.Text = ""
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
        Me.Label9.Location = New System.Drawing.Point(24, 72)
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
        Me.lblCountNo.Location = New System.Drawing.Point(120, 72)
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
        'XTextBox6
        '
        Me.XTextBox6.AcceptsReturn = True
        Me.XTextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ivitemm.prov_code"))
        Me.XTextBox6.EditInitialValue = Nothing
        Me.XTextBox6.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox6.FieldDescription = ""
        Me.XTextBox6.FindInitialValue = Nothing
        Me.XTextBox6.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox6.IgnoreRequiered = False
        Me.XTextBox6.Location = New System.Drawing.Point(104, 104)
        Me.XTextBox6.Name = "XTextBox6"
        Me.XTextBox6.NewInitialValue = Nothing
        Me.XTextBox6.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox6.Requiered = False
        Me.XTextBox6.Size = New System.Drawing.Size(48, 20)
        Me.XTextBox6.StatusBarPanelDescripcion = Nothing
        Me.XTextBox6.TabIndex = 15
        Me.XTextBox6.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label6.Location = New System.Drawing.Point(48, 112)
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
        Me.Label7.Location = New System.Drawing.Point(48, 232)
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
        Me.LibXLookup6.DestParameters = New String() {"item_code=item_code", "item_name=item_name"}
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
        Me.XTextBox9.TabIndex = 19
        Me.XTextBox9.Text = ""
        '
        'item_name
        '
        Me.item_name.AcceptsReturn = True
        Me.item_name.EditInitialValue = Nothing
        Me.item_name.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.item_name.FieldDescription = ""
        Me.item_name.FindInitialValue = Nothing
        Me.item_name.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.item_name.IgnoreRequiered = False
        Me.item_name.Location = New System.Drawing.Point(160, 224)
        Me.item_name.Name = "item_name"
        Me.item_name.NewInitialValue = Nothing
        Me.item_name.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.item_name.ReadOnly = True
        Me.item_name.Requiered = False
        Me.item_name.Size = New System.Drawing.Size(288, 20)
        Me.item_name.StatusBarPanelDescripcion = Nothing
        Me.item_name.TabIndex = 21
        Me.item_name.TabStop = False
        Me.item_name.Text = ""
        '
        'LibxCheckBox1
        '
        Me.LibxCheckBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LibxCheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("value", Me.DataSet1, "ivitemm.frizado_inv"))
        Me.LibxCheckBox1.EditInitialValue = Nothing
        Me.LibxCheckBox1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox1.FindInitialValue = Nothing
        Me.LibxCheckBox1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox1.IgnoreRequiered = False
        Me.LibxCheckBox1.KeepEnabled = False
        Me.LibxCheckBox1.Location = New System.Drawing.Point(72, 256)
        Me.LibxCheckBox1.Name = "LibxCheckBox1"
        Me.LibxCheckBox1.NewInitialValue = Nothing
        Me.LibxCheckBox1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxCheckBox1.ReadOnly = False
        Me.LibxCheckBox1.Requiered = False
        Me.LibxCheckBox1.Size = New System.Drawing.Size(120, 24)
        Me.LibxCheckBox1.TabIndex = 23
        Me.LibxCheckBox1.Text = "Frizar Existencia"
        Me.LibxCheckBox1.ThreeState = True
        Me.LibxCheckBox1.value = Nothing
        '
        'ivcountd
        '
        Me.ivcountd.TableName = "ivcountd"
        '
        'p_ivcount03
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(594, 344)
        Me.Controls.Add(Me.LibxCheckBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LibXLookup6)
        Me.Controls.Add(Me.XTextBox9)
        Me.Controls.Add(Me.item_name)
        Me.Controls.Add(Me.LibXLookup5)
        Me.Controls.Add(Me.XTextBox6)
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
        Me.Controls.Add(Me.XTextBox4)
        Me.Controls.Add(Me.whse_name)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblCountNo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "p_ivcount03"
        Me.Text = "Generar Hoja de Conteo"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ivcounte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.ivcountd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub LibXConnector1_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.XBeforeExecuteQueryEventArgs) Handles LibXConnector1.BeforeExecuteQuery
        Dim xSelect As LibX.Data.XSelecStmt
        Dim oTable As DataTable
        Dim oDoc As SGT.Inventario.Entidades.Documento
        Dim ConteoNo, PaginaNo, LineNo As Integer
        Dim Serial As Integer
        Try

            e.DoFill = False

            e.Where = e.Where.Replace("ivitemm.whse_code", "ivitemd.whse_code")
            xSelect = New LibX.Data.XSelecStmt("ivitemm", LibX.ConcatWherePart(e.Sql, e.Where))
            oTable = xSelect.GetTable(True)

            xSelect.Dispose()

            If oTable.Rows.Count <= 0 Then
                Throw New ApplicationException("No existen registros con esa condición!")
            End If

            If MessageBox.Show("Iniciar la generación?", "Generar Hoja de Conteo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                Exit Sub
            End If

            ProgressBar1.Maximum = oTable.Rows.Count + 1
            ProgressBar1.Minimum = 1
            If LibX.Data.Manager.Connection.IsIntransaction = False Then
                LibX.Data.Manager.Connection.BeginTransaction()
            End If
            oDoc = New SGT.Inventario.Entidades.Documento("INV")
            ConteoNo = oDoc.GenerateNumber("INV")

            lblCountNo.Text = ConteoNo.ToString
            PaginaNo = 0
            LineNo = 66
            Dim oNewRow1 As DataRow

            For Each oRow As DataRow In oTable.Rows
                Dim oNewRow As DataRow = ivcountd.NewRow

                If LineNo >= 66 Then
                    LineNo = 1
                    PaginaNo += 1

                    oNewRow1 = ivcounte.NewRow

                    oNewRow1!count_number = ConteoNo
                    oNewRow1!pageno = PaginaNo
                    oNewRow1!whse_code = oRow!whse_code
                    oNewRow1!count_date = LibX.Data.Manager.Connection.GetDate
                    oNewRow1!count_desc = "INVENTARIO FISICO AL " & LibX.Data.Manager.Connection.GetDate.ToShortDateString
                    oNewRow1!count_status = 2 'Pendiente de Aplicar
                    oNewRow1!userid = LibX.User.UserID

                    ivcounte.Rows.Add(oNewRow1)
                    LibX.Data.Manager.Save(ivcounte)
                End If

                oNewRow!count_number = ConteoNo
                oNewRow!PageNo = PaginaNo
                oNewRow!line_no = LineNo
                oNewRow!item_code = oRow!item_code
                oNewRow!whse_code = oRow!whse_code
                oNewRow!loc_row = oRow!loc_row
                oNewRow!loc_bin = oRow!loc_col
                oNewRow!estante = oRow!estante
                oNewRow!qty_on_hand = oRow!existencia

                ivcountd.Rows.Add(oNewRow)
                LibX.Data.Manager.Save(ivcountd)

                LineNo += 1
                ProgressBar1.Value += 1
            Next
            If LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.CommitTransaction()
            End If
            MessageBox.Show("Generación Exitosa!", "Generar hoja de conteo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            btnImprimir.Enabled = True

        Catch ex As Exception
            If LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.RollBackTransaction()
            End If
            Log.Show(ex)
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnEjecutar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEjecutar.Click
        Me.LibXConnector1.AcceptFind()
        Me.LibXConnector1.Find()
        '''Me.fecHasta.Value = LibX.Data.Manager.Connection.GetDate

    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LibXConnector1.Cancel()
        LibXConnector1.Find()
    End Sub

    Private Sub r_ftfact10_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.LibXConnector1.Find()
    End Sub

    Private Sub LibXConnector1_ExecutedAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutedAction
        Try
            If e.Action = LibxConnectionActions.Find Then
                ShowLastClose()
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

            lblLastClose.Text = CType(DateClose, Date).ToShortDateString

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
