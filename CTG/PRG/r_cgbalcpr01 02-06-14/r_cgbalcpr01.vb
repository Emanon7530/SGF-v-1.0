Imports SGT.Contabilidad.Entidades
Public Class r_cgbalcpr01
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
    Friend WithEvents LibXLookup1 As LibX.LibXLookup
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents xtxsuc_code As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Chk_resumen = New LibX.LibxCheckBox
        Me.xlk_dept_code = New LibX.LibXLookup
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
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.DataColumn5 = New System.Data.DataColumn
        Me.lbldept_name = New System.Windows.Forms.Label
        Me.txtPerdr_year = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtperdr_num = New System.Windows.Forms.TextBox
        Me.txtDept_code = New System.Windows.Forms.TextBox
        Me.btnIniciar = New System.Windows.Forms.Button
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.LibXLookup1 = New LibX.LibXLookup
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.xtxsuc_code = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Text = "BALANCE DE COMPROBACION"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LibXLookup1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.xtxsuc_code)
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
        Me.GroupBox1.Size = New System.Drawing.Size(464, 104)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
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
        Me.Chk_resumen.Location = New System.Drawing.Point(360, 16)
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
        Me.xlk_dept_code.Location = New System.Drawing.Point(424, 72)
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
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable2})
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5})
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
        'DataColumn5
        '
        Me.DataColumn5.AllowDBNull = False
        Me.DataColumn5.ColumnName = "suc_code"
        Me.DataColumn5.DataType = GetType(System.Int32)
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
        Me.txtPerdr_year.Location = New System.Drawing.Point(104, 24)
        Me.txtPerdr_year.Name = "txtPerdr_year"
        Me.txtPerdr_year.Size = New System.Drawing.Size(48, 20)
        Me.txtPerdr_year.TabIndex = 15
        Me.txtPerdr_year.Text = ""
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
        'txtperdr_num
        '
        Me.txtperdr_num.Location = New System.Drawing.Point(160, 24)
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
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 167)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(560, 23)
        Me.ProgressBar1.TabIndex = 13
        '
        'LibXLookup1
        '
        Me.LibXLookup1.AlternateFieldSearch = Nothing
        Me.LibXLookup1.BeginCheck = False
        Me.LibXLookup1.CheckText = Nothing
        Me.LibXLookup1.ComboMode = False
        Me.LibXLookup1.DataMember = Nothing
        Me.LibXLookup1.DataSource = Me.LibXConnector1
        Me.LibXLookup1.DestParameters = New String() {"suc_code=suc_code", "Label4=suc_name"}
        Me.LibXLookup1.FilterField = Nothing
        Me.LibXLookup1.IgnoreFindInBrowseMode = False
        Me.LibXLookup1.isCanceled = False
        Me.LibXLookup1.Location = New System.Drawing.Point(424, 48)
        Me.LibXLookup1.LookCaption = Nothing
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
        Me.LibXLookup1.SrcParameters = New String() {"suc_code=suc_code"}
        Me.LibXLookup1.TabIndex = 25
        Me.LibXLookup1.TableName = "cgsucursal"
        Me.LibXLookup1.TabStop = False
        Me.LibXLookup1.UseCopyConnection = False
        Me.LibXLookup1.UseRowRetrieveEvents = False
        Me.LibXLookup1.UseTab = False
        Me.LibXLookup1.VisParameters = New String() {"Código=suc_code", "Nombre=suc_name"}
        Me.LibXLookup1.WhereCondition = Nothing
        Me.LibXLookup1.WhereParameters = Nothing
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(160, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(264, 20)
        Me.Label4.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(40, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 16)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Sucursal:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxsuc_code
        '
        Me.xtxsuc_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cgacctd.suc_code"))
        Me.xtxsuc_code.Location = New System.Drawing.Point(104, 48)
        Me.xtxsuc_code.Name = "xtxsuc_code"
        Me.xtxsuc_code.Size = New System.Drawing.Size(48, 20)
        Me.xtxsuc_code.TabIndex = 23
        Me.xtxsuc_code.Text = ""
        '
        'r_cgbalcpr01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(560, 190)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnIniciar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCerrar)
        Me.Name = "r_cgbalcpr01"
        Me.Text = "Listado Balanza de Comprobacion"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim oPeriodo As Periodo
    Dim WithEvents oAnoFiscal As AnoFiscal

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
        Dim oReport As LibX.ReportLib
        Dim SQLString As String
        Dim WhereString As String
        Try

            If txtperdr_num.Text.Trim <> "" Then
                WhereString = LibX.ConcatWherePart(WhereString, "cgacctd.perdr_num = " & txtperdr_num.Text)
            End If

            If txtPerdr_year.Text.Trim <> "" Then
                WhereString = LibX.ConcatWherePart(WhereString, "cgacctd.perdr_year= " & txtPerdr_year.Text)
            End If

            If txtDept_code.Text.Trim <> "" Then
                WhereString = LibX.ConcatWherePart(WhereString, "cgacctd.dept_code = " & txtDept_code.Text)
            End If

            If Val(xtxsuc_code.Text) > 0 Then
                WhereString = LibX.ConcatWherePart(WhereString, "cgacctd.suc_code = " & Val(xtxsuc_code.Text))
            End If

            If Me.Chk_resumen.Checked = False Then
                oReport = New LibX.ReportLib("CTG", "r_cgbalcpr01.rpt")
            Else
                oReport = New LibX.ReportLib("CTG", "r_cgbalcpr02.rpt")
            End If

            oReport.ParameterFields(0) = String.Concat("perdr_num;", Trim(txtperdr_num.Text.Trim), ";TRUE")
            oReport.ParameterFields(1) = String.Concat("perdr_year;", Trim(txtPerdr_year.Text.Trim), ";TRUE")

            oReport.RetrieveSQLQuery()
            SQLString = oReport.SQLQuery
            SQLString = LibX.ConcatWherePart(SQLString, WhereString)
            oReport.SQLQuery = SQLString

            oReport.Action = 1

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
        If Me.Chk_resumen.Checked = True Then
            Label1.Text = "BALANCE DE COMPROBACION(Resumido)"
        Else
            Label1.Text = "BALANCE DE COMPROBACION"
        End If
    End Sub
End Class
