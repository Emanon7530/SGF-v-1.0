Imports SGT.Contabilidad.Entidades
Public Class p_acctpr02
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblInicio As System.Windows.Forms.Label
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents chk_descuadre As System.Windows.Forms.CheckBox
    Friend WithEvents lblthru_date As System.Windows.Forms.Label
    Friend WithEvents lblfrom_date As System.Windows.Forms.Label
    Friend WithEvents lblFin As System.Windows.Forms.Label
    Friend WithEvents txtperdr_newyear As System.Windows.Forms.TextBox
    Friend WithEvents txtperdr_year As System.Windows.Forms.TextBox
    Friend WithEvents btnIniciar As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents txtperdr_num As System.Windows.Forms.TextBox
    Friend WithEvents txtperdr_newnum As System.Windows.Forms.TextBox
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents Chk_Cerrear As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_reversar As System.Windows.Forms.CheckBox
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtperdr_num = New System.Windows.Forms.TextBox
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
        Me.chk_descuadre = New System.Windows.Forms.CheckBox
        Me.lblthru_date = New System.Windows.Forms.Label
        Me.lblfrom_date = New System.Windows.Forms.Label
        Me.lblFin = New System.Windows.Forms.Label
        Me.lblInicio = New System.Windows.Forms.Label
        Me.txtperdr_newyear = New System.Windows.Forms.TextBox
        Me.txtperdr_year = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtperdr_newnum = New System.Windows.Forms.TextBox
        Me.btnIniciar = New System.Windows.Forms.Button
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.DataColumn9 = New System.Data.DataColumn
        Me.btnRefresh = New System.Windows.Forms.Button
        Me.Chk_Cerrear = New System.Windows.Forms.CheckBox
        Me.Chk_reversar = New System.Windows.Forms.CheckBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Text = "CERRAR PERIODO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtperdr_num)
        Me.GroupBox1.Controls.Add(Me.chk_descuadre)
        Me.GroupBox1.Controls.Add(Me.lblthru_date)
        Me.GroupBox1.Controls.Add(Me.lblfrom_date)
        Me.GroupBox1.Controls.Add(Me.lblFin)
        Me.GroupBox1.Controls.Add(Me.lblInicio)
        Me.GroupBox1.Controls.Add(Me.txtperdr_newyear)
        Me.GroupBox1.Controls.Add(Me.txtperdr_year)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtperdr_newnum)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 80)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(432, 112)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'txtperdr_num
        '
        Me.txtperdr_num.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cgperdd.perdr_num"))
        Me.txtperdr_num.Location = New System.Drawing.Point(160, 24)
        Me.txtperdr_num.Name = "txtperdr_num"
        Me.txtperdr_num.ReadOnly = True
        Me.txtperdr_num.Size = New System.Drawing.Size(32, 20)
        Me.txtperdr_num.TabIndex = 13
        Me.txtperdr_num.Text = ""
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
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9})
        Me.DataTable1.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"perdr_year", "perdr_num"}, True)})
        Me.DataTable1.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2}
        Me.DataTable1.TableName = "cgperdd"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.ColumnName = "perdr_year"
        Me.DataColumn1.DataType = GetType(System.Int32)
        '
        'DataColumn2
        '
        Me.DataColumn2.AllowDBNull = False
        Me.DataColumn2.ColumnName = "perdr_num"
        Me.DataColumn2.DataType = GetType(System.Int32)
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "from_date"
        Me.DataColumn3.DataType = GetType(System.DateTime)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "thru_date"
        Me.DataColumn4.DataType = GetType(System.DateTime)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "perdr_status"
        Me.DataColumn5.MaxLength = 1
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "perdr_begin"
        Me.DataColumn6.DataType = GetType(System.Int32)
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "ic_balance"
        Me.DataColumn7.DataType = GetType(System.Decimal)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "result_balance"
        Me.DataColumn8.DataType = GetType(System.Decimal)
        '
        'chk_descuadre
        '
        Me.chk_descuadre.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chk_descuadre.Location = New System.Drawing.Point(104, 88)
        Me.chk_descuadre.Name = "chk_descuadre"
        Me.chk_descuadre.Size = New System.Drawing.Size(224, 16)
        Me.chk_descuadre.TabIndex = 11
        Me.chk_descuadre.Text = "Cerrar con entradas no balanceadas?"
        Me.chk_descuadre.Visible = False
        '
        'lblthru_date
        '
        Me.lblthru_date.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblthru_date.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblthru_date.Location = New System.Drawing.Point(320, 56)
        Me.lblthru_date.Name = "lblthru_date"
        Me.lblthru_date.Size = New System.Drawing.Size(100, 20)
        Me.lblthru_date.TabIndex = 9
        '
        'lblfrom_date
        '
        Me.lblfrom_date.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblfrom_date.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblfrom_date.Location = New System.Drawing.Point(200, 56)
        Me.lblfrom_date.Name = "lblfrom_date"
        Me.lblfrom_date.Size = New System.Drawing.Size(100, 20)
        Me.lblfrom_date.TabIndex = 8
        '
        'lblFin
        '
        Me.lblFin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFin.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblFin.Location = New System.Drawing.Point(320, 24)
        Me.lblFin.Name = "lblFin"
        Me.lblFin.Size = New System.Drawing.Size(100, 20)
        Me.lblFin.TabIndex = 7
        '
        'lblInicio
        '
        Me.lblInicio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblInicio.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblInicio.Location = New System.Drawing.Point(200, 24)
        Me.lblInicio.Name = "lblInicio"
        Me.lblInicio.Size = New System.Drawing.Size(100, 20)
        Me.lblInicio.TabIndex = 4
        '
        'txtperdr_newyear
        '
        Me.txtperdr_newyear.Location = New System.Drawing.Point(104, 56)
        Me.txtperdr_newyear.Name = "txtperdr_newyear"
        Me.txtperdr_newyear.ReadOnly = True
        Me.txtperdr_newyear.Size = New System.Drawing.Size(48, 20)
        Me.txtperdr_newyear.TabIndex = 3
        Me.txtperdr_newyear.Text = ""
        '
        'txtperdr_year
        '
        Me.txtperdr_year.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cgperdd.perdr_year"))
        Me.txtperdr_year.Location = New System.Drawing.Point(104, 24)
        Me.txtperdr_year.Name = "txtperdr_year"
        Me.txtperdr_year.ReadOnly = True
        Me.txtperdr_year.Size = New System.Drawing.Size(48, 20)
        Me.txtperdr_year.TabIndex = 2
        Me.txtperdr_year.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(16, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nuevo Periodo:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(16, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Periodo Actual:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtperdr_newnum
        '
        Me.txtperdr_newnum.Location = New System.Drawing.Point(160, 56)
        Me.txtperdr_newnum.Name = "txtperdr_newnum"
        Me.txtperdr_newnum.ReadOnly = True
        Me.txtperdr_newnum.Size = New System.Drawing.Size(32, 20)
        Me.txtperdr_newnum.TabIndex = 13
        Me.txtperdr_newnum.Text = ""
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
        Me.btnCerrar.Location = New System.Drawing.Point(448, 112)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.TabIndex = 2
        Me.btnCerrar.Text = "Cerrar"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 199)
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
        Me.LibXConnector1.DataMember = "cgperdd"
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
        Me.LibXDbSourceTable1.TableName = "cgperdd"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
        '
        'DataColumn9
        '
        Me.DataColumn9.AllowDBNull = False
        Me.DataColumn9.ColumnName = "suc_code"
        Me.DataColumn9.DataType = GetType(System.Int32)
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(448, 88)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.TabIndex = 2
        Me.btnRefresh.Text = "Refrescar"
        '
        'Chk_Cerrear
        '
        Me.Chk_Cerrear.Checked = True
        Me.Chk_Cerrear.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Chk_Cerrear.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Chk_Cerrear.Location = New System.Drawing.Point(112, 56)
        Me.Chk_Cerrear.Name = "Chk_Cerrear"
        Me.Chk_Cerrear.Size = New System.Drawing.Size(96, 24)
        Me.Chk_Cerrear.TabIndex = 14
        Me.Chk_Cerrear.Text = "Cerrar Periodo"
        '
        'Chk_reversar
        '
        Me.Chk_reversar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Chk_reversar.Location = New System.Drawing.Point(216, 56)
        Me.Chk_reversar.Name = "Chk_reversar"
        Me.Chk_reversar.TabIndex = 15
        Me.Chk_reversar.Text = "Reversar Periodo"
        '
        'p_acctpr02
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(528, 222)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnIniciar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.Chk_Cerrear)
        Me.Controls.Add(Me.Chk_reversar)
        Me.Name = "p_acctpr02"
        Me.Text = "Cierre Mensual"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim oPeriodo As Periodo
    Dim WithEvents oAnoFiscal As AnoFiscal

    Private Sub p_acctpr01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            LibXConnector1.Find()

            '// Actual
            Actual()

            '// Calcular el proximo
            If Proximo() = False Then

            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub Actual()
        Try
            oAnoFiscal = New AnoFiscal
            oPeriodo = oAnoFiscal.BuscarPeriodoActual

            txtperdr_num.Text = oPeriodo.Number.ToString
            txtperdr_year.Text = oPeriodo.year.ToString

            LibXConnector1.CurrentDataRow!perdr_year = oPeriodo.year.ToString
            LibXConnector1.CurrentDataRow!perdr_num = oPeriodo.Number.ToString

            lblInicio.Text = oPeriodo.From.ToShortDateString
            lblFin.Text = oPeriodo.Thru.ToShortDateString

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIniciar.Click
        Dim oParam As AnoFiscal.ParametrosCerrar

        Try
            oParam = New AnoFiscal.ParametrosCerrar

            With oParam
                .Year = Val(txtperdr_year.Text)
                .Number = Val(txtperdr_num.Text)
                .CerrarUnbalnced = chk_descuadre.Checked
            End With

            If Me.Chk_Cerrear.Checked = True Then
                If oAnoFiscal.CerrarPeriodo(oParam) Then
                    MessageBox.Show("Periodo Cerrado Existosamente!")
                End If
            End If

            If Me.Chk_reversar.Checked = True Then
                If oAnoFiscal.ReversarPeriodo(oParam) Then
                    MessageBox.Show("Periodo Reversado Existosamente!")
                End If
            End If

            '// btnIniciar.Enabled = False
            Refrescar()

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Function Proximo() As Boolean
        Dim oPeriodo As Periodo

        Try
            oPeriodo = oAnoFiscal.BuscarProximoPeriodo

            txtperdr_newyear.Text = oPeriodo.year.ToString
            txtperdr_newnum.Text = oPeriodo.Number.ToString
            lblfrom_date.Text = oPeriodo.From.ToShortDateString
            lblthru_date.Text = oPeriodo.Thru.ToShortDateString

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Private Function Anterior() As Boolean
        Dim oPeriodo As Periodo

        Try
            oPeriodo = oAnoFiscal.BuscarPeriodoAnterior

            txtperdr_newyear.Text = oPeriodo.year.ToString
            txtperdr_newnum.Text = oPeriodo.Number.ToString
            lblfrom_date.Text = oPeriodo.From.ToShortDateString
            lblthru_date.Text = oPeriodo.Thru.ToShortDateString

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()

    End Sub

    Private Sub oAnoFiscal_Iniciando(ByVal e As SGT.Contabilidad.Entidades.AnoFiscal.IniciarEventArgs) Handles oAnoFiscal.Iniciando
        ProgressBar1.Maximum = e.Cantidad
        ProgressBar1.Minimum = 1
        ProgressBar1.Value = e.PeriodoActualNo

    End Sub
    Private Sub Refrescar()
        '// Actual
        Actual()

        '// Proximo
        Proximo()

    End Sub
    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Try
            Refrescar()
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub Chk_Cerrear_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_Cerrear.CheckedChanged
        If Me.Chk_Cerrear.Checked = True Then
            Proximo()
            Me.Chk_reversar.Checked = False
            Label1.Text = "CERRAR PERIODO"
        End If

    End Sub

    Private Sub Chk_reversar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_reversar.CheckedChanged
        If Me.Chk_reversar.Checked = True Then
            Anterior()
            Me.Chk_Cerrear.Checked = False
            Label1.Text = "REVERSAR PERIODO"
        End If
    End Sub
End Class
