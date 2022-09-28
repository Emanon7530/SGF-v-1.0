Public Class i_ivserie01
    Inherits System.Windows.Forms.Form
    Dim mWhere As String
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
    Friend WithEvents LibXGrid1 As LibX.LibXGrid
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents XdataGridTableStyle1 As LibX.XdataGridTableStyle
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbt_Vencidos As System.Windows.Forms.RadioButton
    Friend WithEvents rbt_proximovencer As System.Windows.Forms.RadioButton
    Friend WithEvents rbt_novencidos As System.Windows.Forms.RadioButton
    Friend WithEvents xdt_prov_name As LibX.XEditTextBoxColumn
    Friend WithEvents xdt_existencia As LibX.XEditTextBoxColumn
    Friend WithEvents xdt_unit_name As LibX.XEditTextBoxColumn
    Friend WithEvents xdt_mes As LibX.XEditTextBoxColumn
    Friend WithEvents xdt_ano As LibX.XEditTextBoxColumn
    Friend WithEvents lblNOvencido As System.Windows.Forms.Label
    Friend WithEvents lblProximo As System.Windows.Forms.Label
    Friend WithEvents lblVencido As System.Windows.Forms.Label
    Friend WithEvents rbt_Todos As System.Windows.Forms.RadioButton
    Friend WithEvents xdt_dias As LibX.XEditTextBoxColumn
    Friend WithEvents DataView1 As System.Data.DataView
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.LibXGrid1 = New LibX.LibXGrid
        Me.DataView1 = New System.Data.DataView
        Me.XdataGridTableStyle1 = New LibX.XdataGridTableStyle
        Me.xdt_prov_name = New LibX.XEditTextBoxColumn
        Me.xdt_existencia = New LibX.XEditTextBoxColumn
        Me.xdt_unit_name = New LibX.XEditTextBoxColumn
        Me.xdt_mes = New LibX.XEditTextBoxColumn
        Me.xdt_ano = New LibX.XEditTextBoxColumn
        Me.xdt_dias = New LibX.XEditTextBoxColumn
        Me.DataSet1 = New System.Data.DataSet
        Me.DataTable1 = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.Button2 = New System.Windows.Forms.Button
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblNOvencido = New System.Windows.Forms.Label
        Me.lblProximo = New System.Windows.Forms.Label
        Me.lblVencido = New System.Windows.Forms.Label
        Me.rbt_Todos = New System.Windows.Forms.RadioButton
        Me.rbt_Vencidos = New System.Windows.Forms.RadioButton
        Me.rbt_proximovencer = New System.Windows.Forms.RadioButton
        Me.rbt_novencidos = New System.Windows.Forms.RadioButton
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LibXGrid1
        '
        Me.LibXGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LibXGrid1.AutoAdjustLastColumn = True
        Me.LibXGrid1.AutoSearch = False
        Me.LibXGrid1.BackgroundColor = System.Drawing.Color.White
        Me.LibXGrid1.CaptionText = "Vencimientos"
        Me.LibXGrid1.DataMember = ""
        Me.LibXGrid1.DataSource = Me.DataView1
        Me.LibXGrid1.FullRowSelect = True
        Me.LibXGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGrid1.IsReadOnly = False
        Me.LibXGrid1.Location = New System.Drawing.Point(8, 8)
        Me.LibXGrid1.Name = "LibXGrid1"
        Me.LibXGrid1.ReadOnly = True
        Me.LibXGrid1.searchText = ""
        Me.LibXGrid1.showFooterBar = False
        Me.LibXGrid1.Size = New System.Drawing.Size(672, 424)
        Me.LibXGrid1.TabIndex = 0
        Me.LibXGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.XdataGridTableStyle1})
        Me.LibXGrid1.UseAutoFillLines = True
        Me.LibXGrid1.UseHandCursor = False
        '
        'DataView1
        '
        Me.DataView1.AllowDelete = False
        Me.DataView1.AllowEdit = False
        Me.DataView1.AllowNew = False
        Me.DataView1.Table = Me.DataTable1
        '
        'XdataGridTableStyle1
        '
        Me.XdataGridTableStyle1.DataGrid = Me.LibXGrid1
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.xdt_prov_name, Me.xdt_existencia, Me.xdt_unit_name, Me.xdt_mes, Me.xdt_ano, Me.xdt_dias})
        Me.XdataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle1.MappingName = "ivvcmted"
        Me.XdataGridTableStyle1.ReadOnly = True
        '
        'xdt_prov_name
        '
        Me.xdt_prov_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.xdt_prov_name.Format = ""
        Me.xdt_prov_name.FormatInfo = Nothing
        Me.xdt_prov_name.HeaderText = "Suplidor"
        Me.xdt_prov_name.ImageList = Nothing
        Me.xdt_prov_name.isReadOnly = True
        Me.xdt_prov_name.MappingName = "prov_name"
        Me.xdt_prov_name.MaxLength = 32767
        Me.xdt_prov_name.TabStop = True
        Me.xdt_prov_name.UseCustomCellFormat = True
        Me.xdt_prov_name.Width = 250
        '
        'xdt_existencia
        '
        Me.xdt_existencia.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.xdt_existencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.xdt_existencia.Format = "###,##0.00"
        Me.xdt_existencia.FormatInfo = Nothing
        Me.xdt_existencia.HeaderText = "Cantidadi"
        Me.xdt_existencia.ImageList = Nothing
        Me.xdt_existencia.isReadOnly = True
        Me.xdt_existencia.MappingName = "existencia"
        Me.xdt_existencia.MaxLength = 32767
        Me.xdt_existencia.TabStop = True
        Me.xdt_existencia.UseCustomCellFormat = True
        Me.xdt_existencia.Width = 85
        '
        'xdt_unit_name
        '
        Me.xdt_unit_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.xdt_unit_name.Format = ""
        Me.xdt_unit_name.FormatInfo = Nothing
        Me.xdt_unit_name.HeaderText = "Unidad"
        Me.xdt_unit_name.ImageList = Nothing
        Me.xdt_unit_name.isReadOnly = True
        Me.xdt_unit_name.MappingName = "unit_name"
        Me.xdt_unit_name.MaxLength = 32767
        Me.xdt_unit_name.TabStop = True
        Me.xdt_unit_name.UseCustomCellFormat = True
        Me.xdt_unit_name.Width = 90
        '
        'xdt_mes
        '
        Me.xdt_mes.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.xdt_mes.Format = ""
        Me.xdt_mes.FormatInfo = Nothing
        Me.xdt_mes.HeaderText = "Mes"
        Me.xdt_mes.ImageList = Nothing
        Me.xdt_mes.isReadOnly = True
        Me.xdt_mes.MappingName = "Mes"
        Me.xdt_mes.MaxLength = 32767
        Me.xdt_mes.TabStop = True
        Me.xdt_mes.UseCustomCellFormat = True
        Me.xdt_mes.Width = 60
        '
        'xdt_ano
        '
        Me.xdt_ano.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.xdt_ano.Format = ""
        Me.xdt_ano.FormatInfo = Nothing
        Me.xdt_ano.HeaderText = "Año"
        Me.xdt_ano.ImageList = Nothing
        Me.xdt_ano.isReadOnly = False
        Me.xdt_ano.MappingName = "Ano"
        Me.xdt_ano.MaxLength = 32767
        Me.xdt_ano.TabStop = True
        Me.xdt_ano.UseCustomCellFormat = True
        Me.xdt_ano.Width = 60
        '
        'xdt_dias
        '
        Me.xdt_dias.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.xdt_dias.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.xdt_dias.Format = "#,###"
        Me.xdt_dias.FormatInfo = Nothing
        Me.xdt_dias.HeaderText = "Dias/Restantesi"
        Me.xdt_dias.ImageList = Nothing
        Me.xdt_dias.isReadOnly = False
        Me.xdt_dias.MappingName = "dias_restantes"
        Me.xdt_dias.MaxLength = 32767
        Me.xdt_dias.TabStop = True
        Me.xdt_dias.UseCustomCellFormat = True
        Me.xdt_dias.Width = 85
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
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6})
        Me.DataTable1.TableName = "ivvcmted"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "prov_name"
        Me.DataColumn1.MaxLength = 60
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "existencia"
        Me.DataColumn2.DataType = GetType(System.Decimal)
        '
        'DataColumn3
        '
        Me.DataColumn3.AllowDBNull = False
        Me.DataColumn3.ColumnName = "unit_name"
        Me.DataColumn3.MaxLength = 30
        '
        'DataColumn4
        '
        Me.DataColumn4.AllowDBNull = False
        Me.DataColumn4.ColumnName = "Mes"
        Me.DataColumn4.MaxLength = 2
        '
        'DataColumn5
        '
        Me.DataColumn5.AllowDBNull = False
        Me.DataColumn5.ColumnName = "Ano"
        Me.DataColumn5.MaxLength = 4
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "dias_restantes"
        Me.DataColumn6.DataType = GetType(System.Int32)
        Me.DataColumn6.ReadOnly = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(773, 443)
        Me.Button2.Name = "Button2"
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Cerrar"
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
        Me.LibXConnector1.DataMember = "ivvcmted"
        Me.LibXConnector1.DataSource = Me.DataSet1
        Me.LibXConnector1.EOF = False
        Me.LibXConnector1.HandledRowsFill = False
        Me.LibXConnector1.HandledUpdates = False
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
        Me.LibXDbSourceTable1.Source = New String() {"select prov_name, existencia,unit_name,Mes,Ano,", "datediff(""d"",getdate(),cast(ano as varchar(4))+'/'+cast(mes as varchar(02))+'/01'" & _
        ") dias_restantes", " from ivvcmted inner join cpprovm", "on ivvcmted.prov_code = cpprovm.prov_code", "inner join ivunitv ", "on ivvcmted.unit_code = ivunitv.unit_code", "and ivvcmted.item_code = ivunitv.item_code"}
        Me.LibXDbSourceTable1.TableName = "ivvcmted"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.lblNOvencido)
        Me.GroupBox1.Controls.Add(Me.lblProximo)
        Me.GroupBox1.Controls.Add(Me.lblVencido)
        Me.GroupBox1.Controls.Add(Me.rbt_Todos)
        Me.GroupBox1.Controls.Add(Me.rbt_Vencidos)
        Me.GroupBox1.Controls.Add(Me.rbt_proximovencer)
        Me.GroupBox1.Controls.Add(Me.rbt_novencidos)
        Me.GroupBox1.Location = New System.Drawing.Point(688, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(160, 427)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtrar"
        '
        'lblNOvencido
        '
        Me.lblNOvencido.BackColor = System.Drawing.Color.LightGreen
        Me.lblNOvencido.Location = New System.Drawing.Point(128, 72)
        Me.lblNOvencido.Name = "lblNOvencido"
        Me.lblNOvencido.Size = New System.Drawing.Size(24, 16)
        Me.lblNOvencido.TabIndex = 4
        '
        'lblProximo
        '
        Me.lblProximo.BackColor = System.Drawing.SystemColors.Info
        Me.lblProximo.Location = New System.Drawing.Point(128, 48)
        Me.lblProximo.Name = "lblProximo"
        Me.lblProximo.Size = New System.Drawing.Size(24, 16)
        Me.lblProximo.TabIndex = 3
        '
        'lblVencido
        '
        Me.lblVencido.BackColor = System.Drawing.Color.OrangeRed
        Me.lblVencido.Location = New System.Drawing.Point(128, 24)
        Me.lblVencido.Name = "lblVencido"
        Me.lblVencido.Size = New System.Drawing.Size(24, 16)
        Me.lblVencido.TabIndex = 2
        '
        'rbt_Todos
        '
        Me.rbt_Todos.Checked = True
        Me.rbt_Todos.Location = New System.Drawing.Point(8, 96)
        Me.rbt_Todos.Name = "rbt_Todos"
        Me.rbt_Todos.Size = New System.Drawing.Size(112, 16)
        Me.rbt_Todos.TabIndex = 1
        Me.rbt_Todos.TabStop = True
        Me.rbt_Todos.Text = "Todos"
        '
        'rbt_Vencidos
        '
        Me.rbt_Vencidos.Location = New System.Drawing.Point(8, 24)
        Me.rbt_Vencidos.Name = "rbt_Vencidos"
        Me.rbt_Vencidos.Size = New System.Drawing.Size(112, 16)
        Me.rbt_Vencidos.TabIndex = 0
        Me.rbt_Vencidos.Text = "Vencidos"
        '
        'rbt_proximovencer
        '
        Me.rbt_proximovencer.Location = New System.Drawing.Point(8, 48)
        Me.rbt_proximovencer.Name = "rbt_proximovencer"
        Me.rbt_proximovencer.Size = New System.Drawing.Size(112, 16)
        Me.rbt_proximovencer.TabIndex = 0
        Me.rbt_proximovencer.Text = "Proximo a Vencer"
        '
        'rbt_novencidos
        '
        Me.rbt_novencidos.Location = New System.Drawing.Point(8, 72)
        Me.rbt_novencidos.Name = "rbt_novencidos"
        Me.rbt_novencidos.Size = New System.Drawing.Size(112, 16)
        Me.rbt_novencidos.TabIndex = 0
        Me.rbt_novencidos.Text = "No Vencidos"
        '
        'i_ivserie01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(858, 480)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.LibXGrid1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "i_ivserie01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Vencimientos"
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub i_ivserie01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim WhereStmt As String
        Try
            If Not LibXConnector1.Parameters Is Nothing Then
                mWhere = LibXConnector1.Parameters.Datos("where") & " and ivvcmted.existencia > 0"
                LibXConnector1.ExecuteFind(mWhere)
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub rbt_disponibles_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbt_Vencidos.CheckedChanged
        Try
            If Not LibXConnector1.Parameters Is Nothing Then
                DataView1.RowFilter = "dias_restantes <=0"
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub

    Private Sub rbt_vendidas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbt_proximovencer.CheckedChanged
        Try
            If Not LibXConnector1.Parameters Is Nothing Then
                DataView1.RowFilter = "dias_restantes <= 30"
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub

    Private Sub rbt_Todas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbt_novencidos.CheckedChanged
        Try
            If Not LibXConnector1.Parameters Is Nothing Then
                DataView1.RowFilter = "dias_restantes > 30"
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub

    Private Sub XEditTextBoxColumn1_SetCellFormat(ByVal sender As System.Object, ByVal e As LibX.XDataGridFormatCellEventArgs) Handles xdt_existencia.SetCellFormat, xdt_ano.SetCellFormat, xdt_mes.SetCellFormat, xdt_prov_name.SetCellFormat, xdt_unit_name.SetCellFormat, xdt_dias.SetCellFormat
        Try
            If DateDiff(DateInterval.Day, DateTime.Now, DateSerial(LibXGrid1.GetValue(e.RowNumber, 4), LibXGrid1.GetValue(e.RowNumber, 3), 1)) <= 0 Then
                e.BackColor = lblVencido.BackColor
            ElseIf DateDiff(DateInterval.Day, DateTime.Now, DateSerial(LibXGrid1.GetValue(e.RowNumber, 4), LibXGrid1.GetValue(e.RowNumber, 3), 1)) <= 30 Then
                e.BackColor = lblProximo.BackColor
            Else
                e.BackColor = lblNOvencido.BackColor
            End If

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub rbt_Todos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbt_Todos.CheckedChanged
        Try

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub

End Class
