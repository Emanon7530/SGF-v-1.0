Imports LibX
Public Class r_ccpaym04
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
    Friend WithEvents LibXDbSourceTable2 As LibX.LibXDbSourceTable
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnEjecutar As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LibXCombo1 As LibX.LibXCombo
    Friend WithEvents LibXCombo2 As LibX.LibXCombo
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents TxtCust_name As System.Windows.Forms.TextBox
    Friend WithEvents TxtBalance As System.Windows.Forms.TextBox
    Friend WithEvents ChkCredito As System.Windows.Forms.CheckBox
    Friend WithEvents ChkResumido As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.DataSet1 = New System.Data.DataSet
        Me.DataTable1 = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnLimpiar = New System.Windows.Forms.Button
        Me.btnEjecutar = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.LibXCombo1 = New LibX.LibXCombo
        Me.LibXCombo2 = New LibX.LibXCombo
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.TxtCust_name = New System.Windows.Forms.TextBox
        Me.TxtBalance = New System.Windows.Forms.TextBox
        Me.ChkCredito = New System.Windows.Forms.CheckBox
        Me.ChkResumido = New System.Windows.Forms.CheckBox
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
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
        Me.LibXConnector1.DataMember = "cccustm"
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
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4})
        Me.DataTable1.TableName = "cccustm"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.ColumnName = "csttype_code"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "cust_status"
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
        Me.LibXDbSourceTable1.Source = New String() {"select ", "cccustm.csttype_code,cccustm.cust_status", "from cccustm "}
        Me.LibXDbSourceTable1.TableName = "cccustm"
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
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(Me.btnEjecutar)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(344, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(88, 138)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnClose.Location = New System.Drawing.Point(8, 83)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(72, 32)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Cerrar"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnLimpiar.Location = New System.Drawing.Point(8, 48)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(72, 32)
        Me.btnLimpiar.TabIndex = 1
        Me.btnLimpiar.Text = "Limpiar"
        '
        'btnEjecutar
        '
        Me.btnEjecutar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnEjecutar.Location = New System.Drawing.Point(8, 13)
        Me.btnEjecutar.Name = "btnEjecutar"
        Me.btnEjecutar.Size = New System.Drawing.Size(72, 32)
        Me.btnEjecutar.TabIndex = 0
        Me.btnEjecutar.Text = "Ejecutar"
        '
        'Label3
        '
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Location = New System.Drawing.Point(8, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Tipo Cliente:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(434, 48)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "LISTADO DE CLIENTES"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(27, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Estatus:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LibXCombo1
        '
        Me.LibXCombo1.AllowDefaultSort = True
        Me.LibXCombo1.bound = True
        Me.LibXCombo1.currValue = Nothing
        Me.LibXCombo1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "cccustm.csttype_code"))
        Me.LibXCombo1.DefaultWhereString = Nothing
        Me.LibXCombo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LibXCombo1.EditInitialValue = Nothing
        Me.LibXCombo1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.FieldDescription = ""
        Me.LibXCombo1.FindInitialValue = Nothing
        Me.LibXCombo1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.IgnoreRequiered = False
        Me.LibXCombo1.Location = New System.Drawing.Point(88, 80)
        Me.LibXCombo1.LookupKeyDisplayFields = "csttype_name"
        Me.LibXCombo1.LookupKeyField = "csttype_code"
        Me.LibXCombo1.LookupTableName = "cccsttpm"
        Me.LibXCombo1.Name = "LibXCombo1"
        Me.LibXCombo1.NewInitialValue = Nothing
        Me.LibXCombo1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.Requiered = False
        Me.LibXCombo1.Required = False
        Me.LibXCombo1.Size = New System.Drawing.Size(144, 21)
        Me.LibXCombo1.SqlString = Nothing
        Me.LibXCombo1.StatusBarPanelDescripcion = Nothing
        Me.LibXCombo1.TabIndex = 8
        '
        'LibXCombo2
        '
        Me.LibXCombo2.AllowDefaultSort = True
        Me.LibXCombo2.bound = True
        Me.LibXCombo2.currValue = Nothing
        Me.LibXCombo2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "cccustm.cust_status"))
        Me.LibXCombo2.DefaultWhereString = Nothing
        Me.LibXCombo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LibXCombo2.EditInitialValue = ""
        Me.LibXCombo2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo2.FieldDescription = ""
        Me.LibXCombo2.FindInitialValue = "1"
        Me.LibXCombo2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo2.IgnoreRequiered = False
        Me.LibXCombo2.Items.AddRange(New Object() {"0-Inactivo", "1-Activo", "2-Suspendido"})
        Me.LibXCombo2.Location = New System.Drawing.Point(88, 106)
        Me.LibXCombo2.LookupKeyDisplayFields = Nothing
        Me.LibXCombo2.LookupKeyField = Nothing
        Me.LibXCombo2.LookupTableName = Nothing
        Me.LibXCombo2.Name = "LibXCombo2"
        Me.LibXCombo2.NewInitialValue = Nothing
        Me.LibXCombo2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo2.Requiered = False
        Me.LibXCombo2.Required = False
        Me.LibXCombo2.Size = New System.Drawing.Size(104, 21)
        Me.LibXCombo2.SqlString = Nothing
        Me.LibXCombo2.StatusBarPanelDescripcion = Nothing
        Me.LibXCombo2.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(31, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Nombre:"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(30, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Balance:"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "cust_name"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "balance"
        '
        'TxtCust_name
        '
        Me.TxtCust_name.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cccustm.cust_name"))
        Me.TxtCust_name.Location = New System.Drawing.Point(88, 55)
        Me.TxtCust_name.Name = "TxtCust_name"
        Me.TxtCust_name.Size = New System.Drawing.Size(128, 20)
        Me.TxtCust_name.TabIndex = 15
        Me.TxtCust_name.Text = ""
        '
        'TxtBalance
        '
        Me.TxtBalance.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cccustm.balance"))
        Me.TxtBalance.Location = New System.Drawing.Point(88, 136)
        Me.TxtBalance.Name = "TxtBalance"
        Me.TxtBalance.Size = New System.Drawing.Size(88, 20)
        Me.TxtBalance.TabIndex = 16
        Me.TxtBalance.Text = ""
        '
        'ChkCredito
        '
        Me.ChkCredito.Checked = True
        Me.ChkCredito.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkCredito.Location = New System.Drawing.Point(256, 56)
        Me.ChkCredito.Name = "ChkCredito"
        Me.ChkCredito.Size = New System.Drawing.Size(64, 24)
        Me.ChkCredito.TabIndex = 17
        Me.ChkCredito.Text = "Credito"
        '
        'ChkResumido
        '
        Me.ChkResumido.Checked = True
        Me.ChkResumido.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkResumido.Location = New System.Drawing.Point(256, 80)
        Me.ChkResumido.Name = "ChkResumido"
        Me.ChkResumido.Size = New System.Drawing.Size(80, 24)
        Me.ChkResumido.TabIndex = 18
        Me.ChkResumido.Text = "Resumido"
        '
        'r_ccpaym04
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(434, 192)
        Me.Controls.Add(Me.ChkResumido)
        Me.Controls.Add(Me.ChkCredito)
        Me.Controls.Add(Me.TxtBalance)
        Me.Controls.Add(Me.TxtCust_name)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LibXCombo2)
        Me.Controls.Add(Me.LibXCombo1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "r_ccpaym04"
        Me.Text = "Listado de Clientes "
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub LibXConnector1_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.XBeforeExecuteQueryEventArgs) Handles LibXConnector1.BeforeExecuteQuery
        Dim AxCrystalReport1 As LibX.ReportLib
        Dim SelecStmt As String
        Dim sTipo As String
        Dim sStatus As String
        'Dim TxtCust_name As String
        Dim sBalance As String
        Dim sWhere As String

        Try

            e.DoFill = False

            'fecHasta.Refresh()

            'If Not IsNull(fecHasta.Value) Then
            '    sFechaHasta = CDate(fecHasta.Value).ToString(LibX.Data.Manager.GetSaveDateFormat)
            'End If

            If Not IsNull(e.row!csttype_code) Then
                sTipo = e.row!csttype_code.ToString
            End If

            If Not IsNull(e.row!cust_status) Then
                sStatus = e.row!cust_status.ToString
            End If

            'If Not IsNull(e.row!cust_name) Then
            '    XTBcust_name = e.row!cust_name.ToString
            'End If

            If Not IsNull(e.row!balance) Then
                sBalance = e.row!balance.ToString
            End If


            'sWhere = "ccopend.cust_code >=" & scliente
            'sWhere = sWhere.Concat(sWhere.Trim, " and ccopend.cust_code <=", scliente1)
            'sWhere = sWhere.Concat(sWhere.Trim, " and ccopend.due_date <='", sFechaHasta, "'")
            'sWhere = sWhere.Concat(sWhere.Trim, " and (ccinvcem.type_code = 'FCT' or ccinvcem.type_code = 'FTS')")
            If Me.ChkResumido.Checked = False Then
                AxCrystalReport1 = New ReportLib("CXC", "r_ccpaym04.rpt")
            Else
                AxCrystalReport1 = New ReportLib("CXC", "r_ccpaym4.rpt")
            End If

            With AxCrystalReport1
                sWhere = " 1=1 "

                If Me.ChkCredito.Checked = True Then
                    sWhere = String.Concat(sWhere, " and cccustm.cust_credito = 1")
                End If

                If Trim(sTipo) <> "" Then
                    sWhere = String.Concat(sWhere, " and cccustm.csttype_code = ", Trim(sTipo))
                End If

                If Trim(sStatus) <> "" Then
                    sWhere = String.Concat(sWhere, " and cccustm.cust_status = ", Trim(sStatus))
                End If

                If Trim(TxtCust_name.Text) <> "" Then
                    sWhere = String.Concat(sWhere, "and cccustm.cust_name like '", TxtCust_name.Text, "%'")
                End If

                If Trim(sBalance) <> "" Then
                    sWhere = String.Concat(sWhere, " and cccustm.balance ", Trim(sBalance))
                End If

                .RetrieveSQLQuery()
                SelecStmt = .SQLQuery
                SelecStmt = LibX.MdlUtil.ConcatWherePart(SelecStmt, sWhere)
                .SQLQuery = SelecStmt

                '// Ejecutar el reporte
                '.WindowState = Crystal.WindowStateConstants.crptMaximized
                .Action = 1

            End With


        Catch ex As Exception
            Log.Show(ex)
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnEjecutar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEjecutar.Click
        Me.LibXConnector1.AcceptFind()
        Me.LibXConnector1.Find()
        'Me.fecHasta.Value = LibX.Data.Manager.Connection.GetDate

    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        If Me.LibXConnector1.IsEditing Then
            Me.LibXConnector1.Cancel()
        End If
        Me.LibXConnector1.Find()
    End Sub

    Private Sub r_ftfact10_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.LibXConnector1.Find()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub
End Class
