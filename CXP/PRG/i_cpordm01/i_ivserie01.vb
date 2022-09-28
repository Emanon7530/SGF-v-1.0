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
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbt_Vencidos As System.Windows.Forms.RadioButton
    Friend WithEvents rbt_proximovencer As System.Windows.Forms.RadioButton
    Friend WithEvents rbt_novencidos As System.Windows.Forms.RadioButton
    Friend WithEvents lblNOvencido As System.Windows.Forms.Label
    Friend WithEvents lblProximo As System.Windows.Forms.Label
    Friend WithEvents lblVencido As System.Windows.Forms.Label
    Friend WithEvents rbt_Todos As System.Windows.Forms.RadioButton
    Friend WithEvents DataView1 As System.Data.DataView
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents ivitemv1 As System.Data.DataTable
    Friend WithEvents XdataGridTableStyle1 As LibX.XdataGridTableStyle
    Friend WithEvents Xwhse_code As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents xitem_name As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents xexistencia As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents xcostoRD As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents xCostoUS As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents xwhse_name As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.LibXGrid1 = New LibX.LibXGrid
        Me.DataView1 = New System.Data.DataView
        Me.ivitemv1 = New System.Data.DataTable
        Me.DataColumn7 = New System.Data.DataColumn
        Me.DataColumn8 = New System.Data.DataColumn
        Me.DataColumn9 = New System.Data.DataColumn
        Me.DataColumn10 = New System.Data.DataColumn
        Me.DataColumn11 = New System.Data.DataColumn
        Me.DataColumn12 = New System.Data.DataColumn
        Me.DataColumn13 = New System.Data.DataColumn
        Me.DataSet1 = New System.Data.DataSet
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
        Me.XdataGridTableStyle1 = New LibX.XdataGridTableStyle
        Me.Xwhse_code = New System.Windows.Forms.DataGridTextBoxColumn
        Me.xitem_name = New System.Windows.Forms.DataGridTextBoxColumn
        Me.xexistencia = New System.Windows.Forms.DataGridTextBoxColumn
        Me.xcostoRD = New System.Windows.Forms.DataGridTextBoxColumn
        Me.xCostoUS = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataColumn1 = New System.Data.DataColumn
        Me.xwhse_name = New System.Windows.Forms.DataGridTextBoxColumn
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ivitemv1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.LibXGrid1.DataMember = "ivitemv1"
        Me.LibXGrid1.DataSource = Me.DataSet1
        Me.LibXGrid1.FullRowSelect = True
        Me.LibXGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGrid1.IsReadOnly = False
        Me.LibXGrid1.Location = New System.Drawing.Point(8, 8)
        Me.LibXGrid1.Name = "LibXGrid1"
        Me.LibXGrid1.ReadOnly = True
        Me.LibXGrid1.searchText = ""
        Me.LibXGrid1.showFooterBar = False
        Me.LibXGrid1.Size = New System.Drawing.Size(816, 224)
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
        Me.DataView1.Table = Me.ivitemv1
        '
        'ivitemv1
        '
        Me.ivitemv1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn1})
        Me.ivitemv1.TableName = "ivitemv1"
        '
        'DataColumn7
        '
        Me.DataColumn7.AllowDBNull = False
        Me.DataColumn7.ColumnName = "whse_code"
        Me.DataColumn7.DataType = GetType(System.Int32)
        '
        'DataColumn8
        '
        Me.DataColumn8.AllowDBNull = False
        Me.DataColumn8.ColumnName = "item_code"
        Me.DataColumn8.MaxLength = 10
        '
        'DataColumn9
        '
        Me.DataColumn9.AllowDBNull = False
        Me.DataColumn9.ColumnName = "item_name"
        Me.DataColumn9.MaxLength = 100
        '
        'DataColumn10
        '
        Me.DataColumn10.AllowDBNull = False
        Me.DataColumn10.ColumnName = "purch_unit"
        Me.DataColumn10.MaxLength = 5
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "existencia"
        Me.DataColumn11.DataType = GetType(System.Int32)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "costus"
        Me.DataColumn12.DataType = GetType(System.Decimal)
        '
        'DataColumn13
        '
        Me.DataColumn13.AllowDBNull = False
        Me.DataColumn13.ColumnName = "costord"
        Me.DataColumn13.DataType = GetType(System.Decimal)
        '
        'DataSet1
        '
        Me.LibXConnector1.SetDataGenerator(Me.DataSet1, Me.LibXConnector1)
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, True)
        Me.DataSet1.EnforceConstraints = False
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.ivitemv1})
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(773, 251)
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
        Me.LibXConnector1.DataMember = "ivitemv1"
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
        Me.LibXDbSourceTable1.Source = New String() {"select ivitemv1.whse_code,whse_name,item_code,item_name,purch_unit,existencia,cos" & _
        "tus,costord from ivitemv1", "inner join ivwhsem on ivitemv1.whse_code=ivwhsem.whse_code"}
        Me.LibXDbSourceTable1.TableName = "ivitemv1"
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
        Me.GroupBox1.Location = New System.Drawing.Point(840, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(8, 235)
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
        'XdataGridTableStyle1
        '
        Me.XdataGridTableStyle1.DataGrid = Me.LibXGrid1
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.Xwhse_code, Me.xwhse_name, Me.xitem_name, Me.xexistencia, Me.xcostoRD, Me.xCostoUS})
        Me.XdataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle1.MappingName = "ivitemv1"
        '
        'Xwhse_code
        '
        Me.Xwhse_code.Format = ""
        Me.Xwhse_code.FormatInfo = Nothing
        Me.Xwhse_code.HeaderText = "Almacen"
        Me.Xwhse_code.MappingName = "whse_code"
        Me.Xwhse_code.Width = 75
        '
        'xitem_name
        '
        Me.xitem_name.Format = ""
        Me.xitem_name.FormatInfo = Nothing
        Me.xitem_name.HeaderText = "Producto"
        Me.xitem_name.MappingName = "item_name"
        Me.xitem_name.Width = 230
        '
        'xexistencia
        '
        Me.xexistencia.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.xexistencia.Format = ""
        Me.xexistencia.FormatInfo = Nothing
        Me.xexistencia.HeaderText = "Existencia"
        Me.xexistencia.MappingName = "existencia"
        Me.xexistencia.Width = 75
        '
        'xcostoRD
        '
        Me.xcostoRD.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.xcostoRD.Format = ""
        Me.xcostoRD.FormatInfo = Nothing
        Me.xcostoRD.HeaderText = "Costo RD"
        Me.xcostoRD.MappingName = "costord"
        Me.xcostoRD.Width = 75
        '
        'xCostoUS
        '
        Me.xCostoUS.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.xCostoUS.Format = ""
        Me.xCostoUS.FormatInfo = Nothing
        Me.xCostoUS.HeaderText = "Costo US"
        Me.xCostoUS.MappingName = "costus"
        Me.xCostoUS.Width = 75
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "whse_name"
        Me.DataColumn1.MaxLength = 60
        '
        'xwhse_name
        '
        Me.xwhse_name.Format = ""
        Me.xwhse_name.FormatInfo = Nothing
        Me.xwhse_name.HeaderText = "Descripcion"
        Me.xwhse_name.MappingName = "whse_name"
        Me.xwhse_name.Width = 240
        '
        'i_ivserie01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(858, 288)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.LibXGrid1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "i_ivserie01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Vencimientos"
        CType(Me.LibXGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ivitemv1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub i_ivserie01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim WhereStmt As String
        Try
            If Not LibXConnector1.Parameters Is Nothing Then
                mWhere = LibXConnector1.Parameters.Datos("where") ''& " and ivvcmted.existencia > 0"
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

    Private Sub XEditTextBoxColumn1_SetCellFormat(ByVal sender As System.Object, ByVal e As LibX.XDataGridFormatCellEventArgs)
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
