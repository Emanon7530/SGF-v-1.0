Imports SGT.Contabilidad.Entidades
Imports SGT.Contabilidad.Operaciones
Public Class p_acctpr03
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
    Friend WithEvents txtperdr_year As System.Windows.Forms.TextBox
    Friend WithEvents btnIniciar As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents txtperdr_num As System.Windows.Forms.TextBox
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents xdt_Thru As LibX.LibxDateTimePicker
    Friend WithEvents xcbo_Tipo As LibX.LibXCombo
    Friend WithEvents cgtranrm As System.Data.DataTable
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
    Friend WithEvents txtReferencia As System.Windows.Forms.TextBox
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.xdt_Thru = New LibX.LibxDateTimePicker
        Me.DataSet1 = New System.Data.DataSet
        Me.cgtranrm = New System.Data.DataTable
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
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtReferencia = New System.Windows.Forms.TextBox
        Me.txtNumero = New System.Windows.Forms.TextBox
        Me.xcbo_Tipo = New LibX.LibXCombo
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtperdr_num = New System.Windows.Forms.TextBox
        Me.txtperdr_year = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnIniciar = New System.Windows.Forms.Button
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.DataColumn14 = New System.Data.DataColumn
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cgtranrm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Size = New System.Drawing.Size(528, 48)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "GENERAR ENTRADA FINAL"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.xdt_Thru)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtReferencia)
        Me.GroupBox1.Controls.Add(Me.txtNumero)
        Me.GroupBox1.Controls.Add(Me.xcbo_Tipo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtperdr_num)
        Me.GroupBox1.Controls.Add(Me.txtperdr_year)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(432, 160)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'xdt_Thru
        '
        Me.xdt_Thru.CustomFormat = "dd/MM/yyyy"
        Me.xdt_Thru.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "cgtranrm.tran_date"))
        Me.xdt_Thru.EditInitialValue = Nothing
        Me.xdt_Thru.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_Thru.FieldDescription = ""
        Me.xdt_Thru.FindInitialValue = Nothing
        Me.xdt_Thru.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_Thru.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.xdt_Thru.IgnoreRequiered = False
        Me.xdt_Thru.Location = New System.Drawing.Point(104, 48)
        Me.xdt_Thru.Name = "xdt_Thru"
        Me.xdt_Thru.NewInitialValue = Nothing
        Me.xdt_Thru.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_Thru.Requiered = False
        Me.xdt_Thru.Size = New System.Drawing.Size(104, 20)
        Me.xdt_Thru.StatusBarPanelDescripcion = Nothing
        Me.xdt_Thru.TabIndex = 21
        '
        'DataSet1
        '
        Me.LibXConnector1.SetDataGenerator(Me.DataSet1, Me.LibXConnector1)
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, True)
        Me.DataSet1.EnforceConstraints = False
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.cgtranrm})
        '
        'cgtranrm
        '
        Me.cgtranrm.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14})
        Me.cgtranrm.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"tranr_serial"}, True)})
        Me.cgtranrm.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn1}
        Me.cgtranrm.TableName = "cgtranrm"
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
        Me.DataColumn2.MaxLength = 3
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "perdr_year"
        Me.DataColumn3.DataType = GetType(System.Int32)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "perdr_num"
        Me.DataColumn4.DataType = GetType(System.Int32)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "orign_code"
        Me.DataColumn5.MaxLength = 3
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "tran_number"
        Me.DataColumn6.MaxLength = 10
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "tran_date"
        Me.DataColumn7.DataType = GetType(System.DateTime)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "date_created"
        Me.DataColumn8.DataType = GetType(System.DateTime)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "tran_descr"
        Me.DataColumn9.MaxLength = 80
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "tran_status"
        Me.DataColumn10.DataType = GetType(System.Int32)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "userid"
        Me.DataColumn11.MaxLength = 18
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "tran_reverse"
        Me.DataColumn12.DataType = GetType(System.Int32)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "tran_refer"
        Me.DataColumn13.MaxLength = 60
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(57, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 16)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Fecha:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(34, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 16)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Referencia:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(48, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Numero:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtReferencia
        '
        Me.txtReferencia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cgtranrm.tran_descr"))
        Me.txtReferencia.Location = New System.Drawing.Point(104, 120)
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.Size = New System.Drawing.Size(312, 20)
        Me.txtReferencia.TabIndex = 17
        Me.txtReferencia.Text = ""
        '
        'txtNumero
        '
        Me.txtNumero.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cgtranrm.tran_number"))
        Me.txtNumero.Location = New System.Drawing.Point(104, 96)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.TabIndex = 16
        Me.txtNumero.Text = ""
        '
        'xcbo_Tipo
        '
        Me.xcbo_Tipo.AllowDefaultSort = True
        Me.xcbo_Tipo.bound = True
        Me.xcbo_Tipo.currValue = Nothing
        Me.xcbo_Tipo.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "cgtranrm.tran_type"))
        Me.xcbo_Tipo.DefaultWhereString = Nothing
        Me.xcbo_Tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_Tipo.EditInitialValue = Nothing
        Me.xcbo_Tipo.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_Tipo.FieldDescription = ""
        Me.xcbo_Tipo.FindInitialValue = Nothing
        Me.xcbo_Tipo.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_Tipo.IgnoreRequiered = False
        Me.xcbo_Tipo.Location = New System.Drawing.Point(104, 72)
        Me.xcbo_Tipo.LookupKeyDisplayFields = "tran_descr"
        Me.xcbo_Tipo.LookupKeyField = "tran_type"
        Me.xcbo_Tipo.LookupTableName = "cgtrntpm"
        Me.xcbo_Tipo.Name = "xcbo_Tipo"
        Me.xcbo_Tipo.NewInitialValue = Nothing
        Me.xcbo_Tipo.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_Tipo.Requiered = False
        Me.xcbo_Tipo.Required = False
        Me.xcbo_Tipo.Size = New System.Drawing.Size(320, 21)
        Me.xcbo_Tipo.SqlString = Nothing
        Me.xcbo_Tipo.StatusBarPanelDescripcion = Nothing
        Me.xcbo_Tipo.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(6, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 16)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Tipo Documento:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtperdr_num
        '
        Me.txtperdr_num.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cgtranrm.perdr_num"))
        Me.txtperdr_num.Location = New System.Drawing.Point(160, 24)
        Me.txtperdr_num.Name = "txtperdr_num"
        Me.txtperdr_num.Size = New System.Drawing.Size(48, 20)
        Me.txtperdr_num.TabIndex = 13
        Me.txtperdr_num.Text = ""
        '
        'txtperdr_year
        '
        Me.txtperdr_year.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cgtranrm.perdr_year"))
        Me.txtperdr_year.Location = New System.Drawing.Point(104, 24)
        Me.txtperdr_year.Name = "txtperdr_year"
        Me.txtperdr_year.Size = New System.Drawing.Size(48, 20)
        Me.txtperdr_year.TabIndex = 2
        Me.txtperdr_year.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(15, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Periodo Actual:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnIniciar
        '
        Me.btnIniciar.Location = New System.Drawing.Point(448, 64)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.TabIndex = 2
        Me.btnIniciar.Text = "Iniciar"
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(448, 88)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.TabIndex = 2
        Me.btnCerrar.Text = "Cerrar"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 223)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(528, 23)
        Me.ProgressBar1.TabIndex = 13
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
        'p_acctpr03
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(528, 246)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnIniciar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCerrar)
        Me.Name = "p_acctpr03"
        Me.Text = "Generar Entrada Final"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cgtranrm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim oPeriodo As Periodo
    Dim oAnoFiscal As AnoFiscal
    Dim oEntrada As EntradaFinal

    Private Sub p_acctpr01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            LibXConnector1.Find()

            oAnoFiscal = New AnoFiscal
            oPeriodo = oAnoFiscal.BuscarPeriodoActual

            txtperdr_num.Text = oPeriodo.Number.ToString
            txtperdr_year.Text = oPeriodo.year.ToString

            LibXConnector1.CurrentDataRow!perdr_year = oPeriodo.year.ToString
            LibXConnector1.CurrentDataRow!perdr_num = oPeriodo.Number.ToString
            xdt_Thru.Value = oPeriodo.Thru

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIniciar.Click
        Dim oParam As ParametrosEntradaFinal

        Try
            oParam = New ParametrosEntradaFinal

            With oParam
                .Year = Val(txtperdr_year.Text)
                .Number = Val(txtperdr_num.Text)
                .Fecha = xdt_Thru.Value
                .TipoDocumento = xcbo_Tipo.SelectedValue
                .DocumentoNumero = Val(txtNumero.Text)
                .Referencia = txtReferencia.Text
            End With

            oEntrada = New EntradaFinal
            If oEntrada.Generar(oParam) Then
                MessageBox.Show("Entrada generada exitosamente, Entrada Numero = " & oParam.Number.ToString)
            End If

            btnIniciar.Enabled = False
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

 
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        If MessageBox.Show("Seguro desea cerrar?", "Entrada Final", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            Me.Close()
        End If

    End Sub

    Private Sub oAnoFiscal_Iniciando(ByVal e As SGT.Contabilidad.Entidades.AnoFiscal.IniciarEventArgs)
        ProgressBar1.Maximum = e.Cantidad
        ProgressBar1.Minimum = 1
        ProgressBar1.Value = e.PeriodoActualNo

    End Sub
End Class
