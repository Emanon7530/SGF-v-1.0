Imports SGT.Contabilidad.Entidades
Public Class r_acctrp01
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
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents txtPerdr_year As System.Windows.Forms.TextBox
    Friend WithEvents txtperdr_num As System.Windows.Forms.TextBox
    Friend WithEvents txtDept_code As System.Windows.Forms.TextBox
    Friend WithEvents lbldept_name As System.Windows.Forms.Label
    Friend WithEvents xlk_dept_code As LibX.LibXLookup
    Friend WithEvents xdt_FechaFinal As LibX.LibxDateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents xcbo_informes As LibX.LibXCombo
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.xdt_FechaFinal = New LibX.LibxDateTimePicker
        Me.xlk_dept_code = New LibX.LibXLookup
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
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.lbldept_name = New System.Windows.Forms.Label
        Me.txtPerdr_year = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtperdr_num = New System.Windows.Forms.TextBox
        Me.txtDept_code = New System.Windows.Forms.TextBox
        Me.btnIniciar = New System.Windows.Forms.Button
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.Label4 = New System.Windows.Forms.Label
        Me.xcbo_informes = New LibX.LibXCombo
        Me.DataColumn9 = New System.Data.DataColumn
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
        Me.Label1.Size = New System.Drawing.Size(560, 48)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "INFORMES FINANCIEROS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.xcbo_informes)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.xdt_FechaFinal)
        Me.GroupBox1.Controls.Add(Me.xlk_dept_code)
        Me.GroupBox1.Controls.Add(Me.lbldept_name)
        Me.GroupBox1.Controls.Add(Me.txtPerdr_year)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtperdr_num)
        Me.GroupBox1.Controls.Add(Me.txtDept_code)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(464, 128)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'xdt_FechaFinal
        '
        Me.xdt_FechaFinal.CustomFormat = "dd/MM/yyyy"
        Me.xdt_FechaFinal.EditInitialValue = Nothing
        Me.xdt_FechaFinal.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_FechaFinal.FindInitialValue = Nothing
        Me.xdt_FechaFinal.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_FechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.xdt_FechaFinal.IgnoreRequiered = False
        Me.xdt_FechaFinal.Location = New System.Drawing.Point(104, 96)
        Me.xdt_FechaFinal.Name = "xdt_FechaFinal"
        Me.xdt_FechaFinal.NewInitialValue = Nothing
        Me.xdt_FechaFinal.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_FechaFinal.Requiered = False
        Me.xdt_FechaFinal.Size = New System.Drawing.Size(104, 20)
        Me.xdt_FechaFinal.TabIndex = 20
        '
        'xlk_dept_code
        '
        Me.xlk_dept_code.CheckText = Nothing
        Me.xlk_dept_code.DataMember = Nothing
        Me.xlk_dept_code.DataSource = Me.LibXConnector1
        Me.xlk_dept_code.DestParameters = New String() {"txtDept_code=dept_code", "lbldept_name=dept_name"}
        Me.xlk_dept_code.FilterField = Nothing
        Me.xlk_dept_code.IgnoreFindInBrowseMode = False
        Me.xlk_dept_code.Location = New System.Drawing.Point(424, 72)
        Me.xlk_dept_code.LookCaption = Nothing
        Me.xlk_dept_code.Name = "xlk_dept_code"
        Me.xlk_dept_code.ShowMessageNotFound = True
        Me.xlk_dept_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_dept_code.SqlString = Nothing
        Me.xlk_dept_code.SQLTab = Nothing
        Me.xlk_dept_code.SrcParameters = New String() {"dept_code=txtDept_code"}
        Me.xlk_dept_code.TabIndex = 18
        Me.xlk_dept_code.TableName = "cgdeptm"
        Me.xlk_dept_code.UseCopyConnection = False
        Me.xlk_dept_code.UseRowRetrieveEvents = False
        Me.xlk_dept_code.UseTab = False
        Me.xlk_dept_code.VisParameters = New String() {"Código=dept_code", "Nombre=dept_name"}
        Me.xlk_dept_code.WhereCondition = Nothing
        Me.xlk_dept_code.WhereParameters = Nothing
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
        Me.LibXConnector1.OwnerForm = Me
        Me.LibXConnector1.Parameters = Nothing
        Me.LibXConnector1.RecordCount = 0
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
        Me.LibXDbSourceTable1.InsertOrder = 0
        Me.LibXDbSourceTable1.IsDetail = False
        Me.LibXDbSourceTable1.KeyFields = Nothing
        Me.LibXDbSourceTable1.MasterDetailRelation = Nothing
        Me.LibXDbSourceTable1.MasterTableName = Nothing
        Me.LibXDbSourceTable1.SerialColumnName = Nothing
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = Nothing
        Me.LibXDbSourceTable1.TableName = "cgperdd"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
        '
        'lbldept_name
        '
        Me.lbldept_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbldept_name.Location = New System.Drawing.Point(160, 72)
        Me.lbldept_name.Name = "lbldept_name"
        Me.lbldept_name.Size = New System.Drawing.Size(264, 20)
        Me.lbldept_name.TabIndex = 16
        '
        'txtPerdr_year
        '
        Me.txtPerdr_year.Location = New System.Drawing.Point(104, 48)
        Me.txtPerdr_year.Name = "txtPerdr_year"
        Me.txtPerdr_year.Size = New System.Drawing.Size(48, 20)
        Me.txtPerdr_year.TabIndex = 15
        Me.txtPerdr_year.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(16, 48)
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
        Me.Label3.Location = New System.Drawing.Point(18, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Departamento:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(27, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Fecha Corte:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtperdr_num
        '
        Me.txtperdr_num.Location = New System.Drawing.Point(160, 48)
        Me.txtperdr_num.Name = "txtperdr_num"
        Me.txtperdr_num.Size = New System.Drawing.Size(48, 20)
        Me.txtperdr_num.TabIndex = 15
        Me.txtperdr_num.Text = ""
        '
        'txtDept_code
        '
        Me.txtDept_code.Location = New System.Drawing.Point(104, 72)
        Me.txtDept_code.Name = "txtDept_code"
        Me.txtDept_code.Size = New System.Drawing.Size(48, 20)
        Me.txtDept_code.TabIndex = 15
        Me.txtDept_code.Text = ""
        '
        'btnIniciar
        '
        Me.btnIniciar.Location = New System.Drawing.Point(480, 64)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.TabIndex = 2
        Me.btnIniciar.Text = "Iniciar"
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(480, 88)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.TabIndex = 2
        Me.btnCerrar.Text = "Cerrar"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 191)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(560, 23)
        Me.ProgressBar1.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(51, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 16)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Informe:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xcbo_informes
        '
        Me.xcbo_informes.AllowDefaultSort = True
        Me.xcbo_informes.bound = True
        Me.xcbo_informes.currValue = Nothing
        Me.xcbo_informes.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "cgperdd.estfn_code"))
        Me.xcbo_informes.DefaultWhereString = Nothing
        Me.xcbo_informes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_informes.EditInitialValue = Nothing
        Me.xcbo_informes.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_informes.FindInitialValue = Nothing
        Me.xcbo_informes.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_informes.IgnoreRequiered = False
        Me.xcbo_informes.Location = New System.Drawing.Point(104, 24)
        Me.xcbo_informes.LookupKeyDisplayFields = "estfn_name"
        Me.xcbo_informes.LookupKeyField = "estfn_code"
        Me.xcbo_informes.LookupTableName = "cgestfnm"
        Me.xcbo_informes.Name = "xcbo_informes"
        Me.xcbo_informes.NewInitialValue = Nothing
        Me.xcbo_informes.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_informes.Requiered = False
        Me.xcbo_informes.Required = False
        Me.xcbo_informes.Size = New System.Drawing.Size(336, 21)
        Me.xcbo_informes.SqlString = Nothing
        Me.xcbo_informes.TabIndex = 22
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "estfn_code"
        Me.DataColumn9.DataType = GetType(System.Int16)
        '
        'r_acctrp01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(560, 214)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnIniciar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCerrar)
        Me.Name = "r_acctrp01"
        Me.Text = "Mayor General"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim oPeriodo As Periodo
    Dim WithEvents oAnoFiscal As AnoFiscal

    Private Sub p_acctpr01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            LibXConnector1.Find()

            oAnoFiscal = New AnoFiscal
            oPeriodo = oAnoFiscal.BuscarPeriodoActual

            txtperdr_num.Text = oPeriodo.Number.ToString
            txtPerdr_year.Text = oPeriodo.year.ToString

            LibXConnector1.CurrentDataRow!perdr_year = oPeriodo.year.ToString
            LibXConnector1.CurrentDataRow!perdr_num = oPeriodo.Number.ToString

            xdt_FechaFinal.Value = oPeriodo.Thru

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIniciar.Click
        Dim oReport As LibX.ReportLib
        Dim SQLString As String
        Dim WhereString As String
        Try

            If xcbo_informes.SelectedValue <= 0 Then
                Throw New ApplicationException("Debe seleccionar el informe a General")
            End If

            SQLString = String.Concat("SELECT ", _
                                        "cgestfnm.estfn_code, ", _
                                        "cgestfnm.estfn_name, ", _
                                        "cgestfnm.estfn_mov, ", _
                                        "cgestfnm.estfn_bce, ", _
                                        "cgestfnd.acct_no, ", _
                                        "cgestfnd.acct_descr, ", _
                                        "cgestfnd.estfn_anexo, ", _
                                        "cgestfnd.estfn_sign, ", _
                                        "cgestfnd.estfn_groupid, ", _
                                        "cgacctd.debit_amount, ", _
                                        "cgacctd.credit_amount, ", _
                                        "cgacctd.balance ", _
                                        "FROM ", _
                                        "cgestfnm INNER JOIN cgestfnd ON ", _
                                        "cgestfnm.estfn_code = cgestfnd.estfn_code ", _
                                        "LEFT OUTER JOIN cgacctd ON ", _
                                        "cgestfnd.acct_no = cgacctd.acct_no ", _
                                        "AND cgacctd.perdr_num = {0} ", _
                                        "AND cgacctd.perdr_year = {1} ", _
                                        "AND (cgacctd.dept_code = {2} OR {2} <=0)")

            SQLString = String.Format(SQLString, txtperdr_num.Text, txtPerdr_year.Text, Val(txtDept_code.Text.Trim))

            'WhereString = LibX.ConcatWherePart(WhereString, "cgacctd.perdr_num = " & txtperdr_num.Text)
            'WhereString = LibX.ConcatWherePart(WhereString, "cgacctd.perdr_year= " & txtPerdr_year.Text)
            'WhereString = LibX.ConcatWherePart(WhereString, "cgacctd.dept_code = " & txtDept_code.Text)
            'WhereString = LibX.ConcatWherePart(WhereString, "cgestfnm.estfn_code = " & xcbo_informes.SelectedValue.ToString)

            oReport = New LibX.ReportLib("CTG", "r_estfin01.rpt")

            oReport.RetrieveSQLQuery()
            'SQLString = oReport.SQLQuery
            SQLString = LibX.ConcatWherePart(SQLString, "cgestfnm.estfn_code = " & xcbo_informes.SelectedValue.ToString)
            oReport.SQLQuery = SQLString

            oReport.ParameterFields(5) = String.Concat("p_FechaCorte;", Trim(xdt_FechaFinal.Value), ";TRUE")

            oReport.Action = 1

            '  btnIniciar.Enabled = False
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        If MessageBox.Show("Seguro desea cerrar?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            Me.Close()
        End If

    End Sub

End Class
