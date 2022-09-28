Imports SGT.Contabilidad
Imports SGT.Contabilidad.Entidades
Imports SGT.Contabilidad.Operaciones
Public Class p_postpr01
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
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents btnIniciar As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txttype_name As System.Windows.Forms.TextBox
    Friend WithEvents LibXLookup1 As LibX.LibXLookup
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents txtperdr_year As System.Windows.Forms.TextBox
    Friend WithEvents txtperdr_num As System.Windows.Forms.TextBox
    Friend WithEvents xtxtype_code As System.Windows.Forms.TextBox
    Friend WithEvents Chk_mayor As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_mov As System.Windows.Forms.CheckBox
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents LibXLookup2 As LibX.LibXLookup
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Chk_mov = New System.Windows.Forms.CheckBox
        Me.Chk_mayor = New System.Windows.Forms.CheckBox
        Me.LibXLookup1 = New LibX.LibXLookup
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
        Me.DataColumn9 = New System.Data.DataColumn
        Me.DataColumn10 = New System.Data.DataColumn
        Me.DataColumn11 = New System.Data.DataColumn
        Me.DataColumn12 = New System.Data.DataColumn
        Me.DataColumn13 = New System.Data.DataColumn
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.DataColumn14 = New System.Data.DataColumn
        Me.txttype_name = New System.Windows.Forms.TextBox
        Me.xtxtype_code = New System.Windows.Forms.TextBox
        Me.txtperdr_year = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtperdr_num = New System.Windows.Forms.TextBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.btnIniciar = New System.Windows.Forms.Button
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.LibXLookup2 = New LibX.LibXLookup
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Size = New System.Drawing.Size(544, 48)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PASE  AL MAYOR GENERAL"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LibXLookup2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Chk_mov)
        Me.GroupBox1.Controls.Add(Me.Chk_mayor)
        Me.GroupBox1.Controls.Add(Me.LibXLookup1)
        Me.GroupBox1.Controls.Add(Me.txttype_name)
        Me.GroupBox1.Controls.Add(Me.xtxtype_code)
        Me.GroupBox1.Controls.Add(Me.txtperdr_year)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ProgressBar1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtperdr_num)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(440, 184)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Chk_mov
        '
        Me.Chk_mov.Location = New System.Drawing.Point(296, 16)
        Me.Chk_mov.Name = "Chk_mov"
        Me.Chk_mov.Size = New System.Drawing.Size(136, 24)
        Me.Chk_mov.TabIndex = 21
        Me.Chk_mov.Text = "Reversar Movimiento"
        '
        'Chk_mayor
        '
        Me.Chk_mayor.Checked = True
        Me.Chk_mayor.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Chk_mayor.Location = New System.Drawing.Point(184, 16)
        Me.Chk_mayor.Name = "Chk_mayor"
        Me.Chk_mayor.TabIndex = 20
        Me.Chk_mayor.Text = "Pasar al Mayor"
        '
        'LibXLookup1
        '
        Me.LibXLookup1.AlternateFieldSearch = Nothing
        Me.LibXLookup1.BeginCheck = False
        Me.LibXLookup1.CheckText = Nothing
        Me.LibXLookup1.ComboMode = False
        Me.LibXLookup1.DataMember = Nothing
        Me.LibXLookup1.DataSource = Me.LibXConnector1
        Me.LibXLookup1.DestParameters = New String() {"tran_type=tran_type", "txttype_name=tran_descr"}
        Me.LibXLookup1.FilterField = Nothing
        Me.LibXLookup1.IgnoreFindInBrowseMode = False
        Me.LibXLookup1.isCanceled = False
        Me.LibXLookup1.Location = New System.Drawing.Point(408, 88)
        Me.LibXLookup1.LookCaption = "Tipos de Documentos"
        Me.LibXLookup1.Name = "LibXLookup1"
        Me.LibXLookup1.PopupSize = New System.Drawing.Size(0, 0)
        Me.LibXLookup1.ShowFilter = True
        Me.LibXLookup1.ShowMessageNotFound = True
        Me.LibXLookup1.ShowWarning = False
        Me.LibXLookup1.Size = New System.Drawing.Size(16, 20)
        Me.LibXLookup1.SizesColumns = Nothing
        Me.LibXLookup1.SizesColumnsTab = Nothing
        Me.LibXLookup1.SqlString = New String() {"select distinct tran_type,tran_descr from cgtrntpm order by tran_type"}
        Me.LibXLookup1.SQLTab = Nothing
        Me.LibXLookup1.SrcParameters = New String() {"tran_type=tran_type"}
        Me.LibXLookup1.TabIndex = 19
        Me.LibXLookup1.TableName = "cgtrntpm"
        Me.LibXLookup1.TabStop = False
        Me.LibXLookup1.UseCopyConnection = False
        Me.LibXLookup1.UseRowRetrieveEvents = False
        Me.LibXLookup1.UseTab = False
        Me.LibXLookup1.VisParameters = New String() {"Tipo=tran_type", "Descripción=tran_descr"}
        Me.LibXLookup1.WhereCondition = Nothing
        Me.LibXLookup1.WhereParameters = Nothing
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
        Me.LibXConnector1.DataMember = "cgtranrm"
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
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14})
        Me.DataTable1.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"tranr_serial"}, True)})
        Me.DataTable1.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn1}
        Me.DataTable1.TableName = "cgtranrm"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.AutoIncrement = True
        Me.DataColumn1.ColumnName = "tranr_serial"
        Me.DataColumn1.DataType = GetType(System.Int32)
        Me.DataColumn1.ReadOnly = True
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "tran_type"
        Me.DataColumn2.MaxLength = 2
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "tran_number"
        Me.DataColumn3.MaxLength = 10
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "tran_date"
        Me.DataColumn4.DataType = GetType(System.DateTime)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "date_created"
        Me.DataColumn5.DataType = GetType(System.DateTime)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "tran_descr"
        Me.DataColumn6.MaxLength = 60
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "tran_status"
        Me.DataColumn7.DataType = GetType(System.Int32)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "orign_code"
        Me.DataColumn8.MaxLength = 3
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "userid"
        Me.DataColumn9.MaxLength = 18
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "tran_reverse"
        Me.DataColumn10.DataType = GetType(System.Int32)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "perdr_year"
        Me.DataColumn11.DataType = GetType(System.Int32)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "perdr_num"
        Me.DataColumn12.DataType = GetType(System.Int32)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "tran_refer"
        Me.DataColumn13.MaxLength = 18
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
        Me.LibXDbSourceTable1.TableName = "cgtranrm"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
        '
        'DataColumn14
        '
        Me.DataColumn14.AllowDBNull = False
        Me.DataColumn14.ColumnName = "suc_code"
        Me.DataColumn14.DataType = GetType(System.Int32)
        '
        'txttype_name
        '
        Me.txttype_name.Location = New System.Drawing.Point(176, 88)
        Me.txttype_name.Name = "txttype_name"
        Me.txttype_name.ReadOnly = True
        Me.txttype_name.Size = New System.Drawing.Size(232, 20)
        Me.txttype_name.TabIndex = 18
        Me.txttype_name.Text = ""
        '
        'xtxtype_code
        '
        Me.xtxtype_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cgtranrm.tran_type"))
        Me.xtxtype_code.Location = New System.Drawing.Point(112, 88)
        Me.xtxtype_code.Name = "xtxtype_code"
        Me.xtxtype_code.Size = New System.Drawing.Size(64, 20)
        Me.xtxtype_code.TabIndex = 17
        Me.xtxtype_code.Text = ""
        '
        'txtperdr_year
        '
        Me.txtperdr_year.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cgtranrm.perdr_year"))
        Me.txtperdr_year.Location = New System.Drawing.Point(112, 16)
        Me.txtperdr_year.Name = "txtperdr_year"
        Me.txtperdr_year.ReadOnly = True
        Me.txtperdr_year.Size = New System.Drawing.Size(64, 20)
        Me.txtperdr_year.TabIndex = 15
        Me.txtperdr_year.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(17, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 16)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Tipo Documento:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(80, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 16)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Año:"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(8, 147)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(424, 23)
        Me.ProgressBar1.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(61, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 16)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Periodo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(16, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 16)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Numero  Entrada:"
        '
        'txtperdr_num
        '
        Me.txtperdr_num.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cgtranrm.perdr_num"))
        Me.txtperdr_num.Location = New System.Drawing.Point(112, 40)
        Me.txtperdr_num.Name = "txtperdr_num"
        Me.txtperdr_num.ReadOnly = True
        Me.txtperdr_num.Size = New System.Drawing.Size(64, 20)
        Me.txtperdr_num.TabIndex = 15
        Me.txtperdr_num.Text = ""
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cgtranrm.tran_number"))
        Me.TextBox5.Location = New System.Drawing.Point(112, 112)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(88, 20)
        Me.TextBox5.TabIndex = 17
        Me.TextBox5.Text = ""
        '
        'btnIniciar
        '
        Me.btnIniciar.Location = New System.Drawing.Point(456, 64)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.TabIndex = 2
        Me.btnIniciar.Text = "Iniciar"
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(456, 88)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.TabIndex = 2
        Me.btnCerrar.Text = "Cerrar"
        '
        'LibXLookup2
        '
        Me.LibXLookup2.AlternateFieldSearch = Nothing
        Me.LibXLookup2.BeginCheck = False
        Me.LibXLookup2.CheckText = Nothing
        Me.LibXLookup2.ComboMode = False
        Me.LibXLookup2.DataMember = Nothing
        Me.LibXLookup2.DataSource = Me.LibXConnector1
        Me.LibXLookup2.DestParameters = New String() {"suc_code=suc_code", "TextBox1=suc_name"}
        Me.LibXLookup2.FilterField = Nothing
        Me.LibXLookup2.IgnoreFindInBrowseMode = False
        Me.LibXLookup2.isCanceled = False
        Me.LibXLookup2.Location = New System.Drawing.Point(408, 64)
        Me.LibXLookup2.LookCaption = "Tipos de Documentos"
        Me.LibXLookup2.Name = "LibXLookup2"
        Me.LibXLookup2.PopupSize = New System.Drawing.Size(0, 0)
        Me.LibXLookup2.ShowFilter = True
        Me.LibXLookup2.ShowMessageNotFound = True
        Me.LibXLookup2.ShowWarning = False
        Me.LibXLookup2.Size = New System.Drawing.Size(16, 20)
        Me.LibXLookup2.SizesColumns = Nothing
        Me.LibXLookup2.SizesColumnsTab = Nothing
        Me.LibXLookup2.SqlString = New String(-1) {}
        Me.LibXLookup2.SQLTab = Nothing
        Me.LibXLookup2.SrcParameters = New String() {"suc_code=suc_code"}
        Me.LibXLookup2.TabIndex = 25
        Me.LibXLookup2.TableName = "cgsucursal"
        Me.LibXLookup2.TabStop = False
        Me.LibXLookup2.UseCopyConnection = False
        Me.LibXLookup2.UseRowRetrieveEvents = False
        Me.LibXLookup2.UseTab = False
        Me.LibXLookup2.VisParameters = New String() {"Código=suc_code", "Descripción=suc_name"}
        Me.LibXLookup2.WhereCondition = Nothing
        Me.LibXLookup2.WhereParameters = Nothing
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(176, 64)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(232, 20)
        Me.TextBox1.TabIndex = 24
        Me.TextBox1.Text = ""
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cgtranrm.suc_code"))
        Me.TextBox2.Location = New System.Drawing.Point(112, 64)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(64, 20)
        Me.TextBox2.TabIndex = 23
        Me.TextBox2.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(56, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 16)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Sucursal:"
        '
        'p_postpr01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(544, 246)
        Me.Controls.Add(Me.btnIniciar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCerrar)
        Me.Name = "p_postpr01"
        Me.Text = "Iniciar periodo Contable o Reversar Movimiento"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim oPeriodo As Periodo
    Dim oAnoFiscal As AnoFiscal
    Dim WithEvents oPase As PasealMayor
    Dim oReversar As ReversarED
    Private Sub p_acctpr01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            LibXConnector1.Find()
            oAnoFiscal = New AnoFiscal
            oPeriodo = oAnoFiscal.BuscarPeriodoActual

            LibXConnector1.CurrentDataRow!perdr_year = oPeriodo.year
            LibXConnector1.CurrentDataRow!perdr_num = oPeriodo.Number

            txtperdr_year.Text = oPeriodo.year.ToString
            txtperdr_num.Text = oPeriodo.Number.ToString
            
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIniciar.Click
        Dim oParam As ParametrosPase
        Dim oParamr As ParametrosReversarED
        Dim XUpdate As LibX.Data.XUpdateStmt
        Try
            If Me.Chk_mayor.Checked = True Then
                If MessageBox.Show("Desea iniciar el pase al mayor", "Pase al Mayor General", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                    Exit Sub
                End If
            End If
            If Me.Chk_mov.Checked = True Then
                If MessageBox.Show("Seguro que desea reversar los movimintos", "Pase al Mayor General", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                    Exit Sub
                End If
            End If

            oPase = New PasealMayor
            oParam = New ParametrosPase
            oReversar = New ReversarED
            oParamr = New ParametrosReversarED

            oPeriodo.year = Val(LibXConnector1.CurrentDataRow!perdr_year.ToString)
            oPeriodo.Number = Val(LibXConnector1.CurrentDataRow!perdr_num.ToString)

            oParamr.Ano = Val(LibXConnector1.CurrentDataRow!perdr_year.ToString)
            oParamr.PeriodoNo = Val(LibXConnector1.CurrentDataRow!perdr_num.ToString)

            oParam.Periodo = oPeriodo

            If LibXConnector1.CurrentDataRow!tran_type.ToString.Trim <> "" Then
                oParam.Documento = LibXConnector1.CurrentDataRow!tran_type.ToString.Trim
                oParamr.Tipo = LibXConnector1.CurrentDataRow!tran_type.ToString.Trim
            End If

            If LibXConnector1.CurrentDataRow!tran_number.ToString.Trim <> "" Then
                oParam.Numero = LibXConnector1.CurrentDataRow!tran_number.ToString.Trim
                oParamr.Numero = LibXConnector1.CurrentDataRow!tran_number.ToString.Trim
            End If

            If Val(LibXConnector1.CurrentDataRow!suc_code.ToString.Trim) > 0 Then
                oParam.Sucursal = Val(LibXConnector1.CurrentDataRow!suc_code.ToString.Trim)
                oParamr.Sucursal = Val(LibXConnector1.CurrentDataRow!suc_code.ToString.Trim)
            End If
            If LibXConnector1.CurrentDataRow!tran_date.ToString.Trim <> "" Then
                oParam.Fecha = CType(LibXConnector1.CurrentDataRow!tran_date.ToString.Trim, Date)
                oParamr.Fecha = CType(LibXConnector1.CurrentDataRow!tran_date.ToString.Trim, Date)
            End If

            If Me.Chk_mov.Checked = True Then
                If oReversar.Aplicar(oParamr) Then
                    MessageBox.Show("Proceso reversado exitosamente!")
                Else
                    MessageBox.Show("Este periodo no ha sido Posteado!")
                End If
            End If

            If Me.Chk_mayor.Checked = True Then
                If oPase.Aplicar(oParam) = True Then
                    XUpdate = New LibX.Data.XUpdateStmt("cgtranrm")
                    XUpdate.FieldsSet("tran_status") = 1
                    XUpdate.Fields("perdr_year") = oPeriodo.year
                    XUpdate.Fields("perdr_num") = oPeriodo.Number
                    XUpdate.Execute()
                    MessageBox.Show("Proceso terminado existiosamente!", "Pase al Mayor")
                Else
                    MessageBox.Show("Este periodo ya esta posteado!", "Pase al Mayor")
                End If
            End If

            btnIniciar.Enabled = False
Next_Nivel:
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub
    Private Function FindEstadoPeriodo(ByVal p_perdr As Integer, ByVal p_year As Integer) As Boolean
        Dim SelselectStmt As String
        Dim pEstatus As Integer
        SelselectStmt = "select perdr_status from cgperdd where perdr_num =" & p_perdr.ToString.Trim & " and perdr_year = " & p_year.ToString.Trim
        pEstatus = LibX.Data.Manager.GetScalar(SelselectStmt)
        If pEstatus = 0 Then
            Return False
        Else
            Return True
        End If

    End Function
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        If MessageBox.Show("Seguro desea cerrar?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            Me.Close()
        End If

    End Sub

    Private Sub oPase_Procesando(ByVal e As SGT.Contabilidad.Operaciones.PasealMayor.PaseEventArgs) Handles oPase.Procesando
        ProgressBar1.Maximum = e.TotalRow
        ProgressBar1.Minimum = 1
        ProgressBar1.Value = e.CurrentRowNo

    End Sub

    Private Sub xdtfecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'oPeriodo = oAnoFiscal.BuscarPeriodoPorFecha(Me.xdtfecha.Text)
        LibXConnector1.CurrentDataRow!perdr_year = oPeriodo.year
        LibXConnector1.CurrentDataRow!perdr_num = oPeriodo.Number.ToString.Trim("00")

        txtperdr_year.Text = oPeriodo.year.ToString
        txtperdr_num.Text = oPeriodo.Number.ToString.Trim("00")

    End Sub
    Private Sub LibXLookup1_AfterSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles LibXLookup1.AfterSetValues
        Me.xtxtype_code.Text = e.row!tran_type
        Me.txttype_name.Text = e.row!tran_descr
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_mayor.CheckedChanged
        If Me.Chk_mayor.Checked = True Then
            btnIniciar.Enabled = True
            Me.Chk_mov.Checked = False
            Label1.Text = "PASE  AL MAYOR GENERAL"
        End If
    End Sub

    Private Sub Chk_mov_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_mov.CheckedChanged
        If Me.Chk_mov.Checked = True Then
            If FindEstadoPeriodo(oPeriodo.Number.ToString.Trim, oPeriodo.year.ToString) = False Then
                btnIniciar.Enabled = False
                MessageBox.Show("Este Periodo esta cerrada, primero debe reversar el periodo")
            Else
                btnIniciar.Enabled = True
            End If
            Me.Chk_mayor.Checked = False
            Label1.Text = "REVERSAR MOVIMIENTOS"
        End If
    End Sub
End Class
