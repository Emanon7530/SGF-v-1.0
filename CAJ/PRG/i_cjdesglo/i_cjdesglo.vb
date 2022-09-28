Imports LibX
Public Class i_cjdesglo
    Inherits System.Windows.Forms.Form
    Dim oDoc As SGT.Inventario.Entidades.Documento
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
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents lkMoneda As LibX.LibXLookup
    Friend WithEvents LibXGridDetalle As LibX.LibXGrid
    Friend WithEvents XdataGridTableStyle1 As LibX.XdataGridTableStyle
    'Friend WithEvents btnProduct As System.Windows.Forms.Button
    'Friend WithEvents btnCostos As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents xcbo_doc_status As LibX.LibXCombo
    'Friend WithEvents ButtonVencimientos As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents LibXShortNavigator1 As LibX.LibXShortNavigator
    Friend WithEvents LibXDbSourceTable2 As LibX.LibXDbSourceTable
    Friend WithEvents gColmoneda_tipo As LibX.XEditTextBoxColumn
    Friend WithEvents gColCantidad As LibX.XEditTextBoxColumn
    Friend WithEvents gColImporte As LibX.XEditTextBoxColumn
    Friend WithEvents DataColumn20 As System.Data.DataColumn
    Friend WithEvents DataColumn22 As System.Data.DataColumn
    Friend WithEvents DataColumn23 As System.Data.DataColumn
    Friend WithEvents DataColumn24 As System.Data.DataColumn
    Friend WithEvents DataColumn25 As System.Data.DataColumn
    Friend WithEvents DataColumn26 As System.Data.DataColumn
    Friend WithEvents DataColumn27 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents cjdesglosh As System.Data.DataTable
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.DataSet1 = New System.Data.DataSet
        Me.cjdesglosh = New System.Data.DataTable
        Me.DataColumn20 = New System.Data.DataColumn
        Me.DataColumn22 = New System.Data.DataColumn
        Me.DataColumn23 = New System.Data.DataColumn
        Me.DataColumn24 = New System.Data.DataColumn
        Me.DataColumn25 = New System.Data.DataColumn
        Me.DataColumn26 = New System.Data.DataColumn
        Me.DataColumn27 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.lkMoneda = New LibX.LibXLookup
        Me.LibXGridDetalle = New LibX.LibXGrid
        Me.XdataGridTableStyle1 = New LibX.XdataGridTableStyle
        Me.gColmoneda_tipo = New LibX.XEditTextBoxColumn
        Me.gColCantidad = New LibX.XEditTextBoxColumn
        Me.gColImporte = New LibX.XEditTextBoxColumn
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.LibXShortNavigator1 = New LibX.LibXShortNavigator
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cjdesglosh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXGridDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.LibXConnector1.DataMember = "cjdesglosh"
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
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.LibXDbSourceTable2})
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
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.cjdesglosh})
        '
        'cjdesglosh
        '
        Me.cjdesglosh.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn20, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn3})
        Me.cjdesglosh.TableName = "cjdesglosh"
        '
        'DataColumn20
        '
        Me.DataColumn20.AllowDBNull = False
        Me.DataColumn20.ColumnName = "init_serial"
        Me.DataColumn20.DataType = GetType(System.Int32)
        '
        'DataColumn22
        '
        Me.DataColumn22.AllowDBNull = False
        Me.DataColumn22.ColumnName = "moneda_serial"
        Me.DataColumn22.DataType = GetType(System.Int32)
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "moneda_valor"
        Me.DataColumn23.DataType = GetType(System.Decimal)
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "cantidad"
        Me.DataColumn24.DataType = GetType(System.Int32)
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "tarjeta"
        Me.DataColumn25.DataType = GetType(System.Decimal)
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "cheque"
        Me.DataColumn26.DataType = GetType(System.Decimal)
        '
        'DataColumn27
        '
        Me.DataColumn27.AllowDBNull = False
        Me.DataColumn27.ColumnName = "moneda_tipo"
        Me.DataColumn27.MaxLength = 20
        '
        'DataColumn3
        '
        Me.DataColumn3.Caption = "importe"
        Me.DataColumn3.ColumnName = "importe"
        Me.DataColumn3.DataType = GetType(System.Decimal)
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
        Me.LibXDbSourceTable2.FillOnRowChange = True
        Me.LibXDbSourceTable2.HeaderIsOnGrid = False
        Me.LibXDbSourceTable2.InnerJon = True
        Me.LibXDbSourceTable2.InsertOrder = 0
        Me.LibXDbSourceTable2.IsDetail = True
        Me.LibXDbSourceTable2.KeyFields = Nothing
        Me.LibXDbSourceTable2.LineColName = "moneda_serial"
        Me.LibXDbSourceTable2.MasterDetailRelation = New String() {Nothing}
        Me.LibXDbSourceTable2.MasterTableName = Nothing
        Me.LibXDbSourceTable2.SerialColumnName = Nothing
        Me.LibXDbSourceTable2.Sort = Nothing
        Me.LibXDbSourceTable2.Source = New String() {"select cjdesglosh.*, cjmoneda.moneda_tipo", "from cjdesglosh inner join cjmoneda", "on cjmoneda.moneda_serial = cjdesglosh.moneda_serial"}
        Me.LibXDbSourceTable2.TableName = "cjdesglosh"
        Me.LibXDbSourceTable2.UpdateOrder = 0
        Me.LibXDbSourceTable2.UseRowRetrieve = False
        '
        'lkMoneda
        '
        Me.lkMoneda.AlternateFieldSearch = Nothing
        Me.lkMoneda.BeginCheck = False
        Me.lkMoneda.CheckText = Nothing
        Me.lkMoneda.ComboMode = False
        Me.lkMoneda.DataMember = "cjdesglosh"
        Me.lkMoneda.DataSource = Me.LibXConnector1
        Me.lkMoneda.DestParameters = New String() {"moneda_serial=moneda_serial", "moneda_tipo=moneda_tipo", "moneda_valor=moneda_valor"}
        Me.lkMoneda.FilterField = "moneda_tipo"
        Me.lkMoneda.IgnoreFindInBrowseMode = True
        Me.lkMoneda.isCanceled = False
        Me.lkMoneda.Location = New System.Drawing.Point(608, 80)
        Me.lkMoneda.LookCaption = Nothing
        Me.lkMoneda.Name = "lkMoneda"
        Me.lkMoneda.PopupSize = New System.Drawing.Size(0, 0)
        Me.lkMoneda.ShowFilter = True
        Me.lkMoneda.ShowMessageNotFound = True
        Me.lkMoneda.ShowWarning = False
        Me.lkMoneda.Size = New System.Drawing.Size(16, 20)
        Me.lkMoneda.SizesColumns = New String() {"moneda_tipo=300"}
        Me.lkMoneda.SizesColumnsTab = Nothing
        Me.lkMoneda.SqlString = New String() {"select * from cjmoneda", "order by moneda_serial"}
        Me.lkMoneda.SQLTab = Nothing
        Me.lkMoneda.SrcParameters = New String() {"moneda_serial=moneda_serial"}
        Me.lkMoneda.TabIndex = 6
        Me.lkMoneda.TableName = "cjmoneda"
        Me.lkMoneda.TabStop = False
        Me.lkMoneda.UseCopyConnection = False
        Me.lkMoneda.UseRowRetrieveEvents = False
        Me.lkMoneda.UseTab = False
        Me.lkMoneda.VisParameters = New String() {"Codigo=moneda_serial", "Moneda=moneda_tipo", "Valor=moneda_valor"}
        Me.lkMoneda.WhereCondition = Nothing
        Me.lkMoneda.WhereParameters = Nothing
        '
        'LibXGridDetalle
        '
        Me.LibXGridDetalle.AllowSorting = False
        Me.LibXGridDetalle.AutoAdjustLastColumn = True
        Me.LibXGridDetalle.AutoSearch = False
        Me.LibXGridDetalle.BackgroundColor = System.Drawing.Color.White
        Me.LibXGridDetalle.CaptionText = "Monedas"
        Me.LibXGridDetalle.DataMember = "cjdesglosh"
        Me.LibXGridDetalle.DataSource = Me.DataSet1
        Me.LibXGridDetalle.FullRowSelect = False
        Me.LibXGridDetalle.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibXGridDetalle.IsReadOnly = False
        Me.LibXGridDetalle.Location = New System.Drawing.Point(0, 32)
        Me.LibXGridDetalle.Name = "LibXGridDetalle"
        Me.LibXGridDetalle.ReadOnly = True
        Me.LibXGridDetalle.RowHeaderWidth = 30
        Me.LibXGridDetalle.searchText = ""
        Me.LibXGridDetalle.showFooterBar = True
        Me.LibXGridDetalle.Size = New System.Drawing.Size(320, 248)
        Me.LibXGridDetalle.TabIndex = 2
        Me.LibXGridDetalle.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.XdataGridTableStyle1})
        Me.LibXGridDetalle.UseAutoFillLines = False
        Me.LibXGridDetalle.UseHandCursor = False
        '
        'XdataGridTableStyle1
        '
        Me.XdataGridTableStyle1.AllowSorting = False
        Me.XdataGridTableStyle1.AlternatingBackColor = System.Drawing.SystemColors.Info
        Me.XdataGridTableStyle1.DataGrid = Me.LibXGridDetalle
        Me.XdataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.gColmoneda_tipo, Me.gColCantidad, Me.gColImporte})
        Me.XdataGridTableStyle1.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XdataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle1.MappingName = "cjdesglosh"
        Me.XdataGridTableStyle1.RowHeaderWidth = 30
        '
        'gColmoneda_tipo
        '
        Me.gColmoneda_tipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColmoneda_tipo.Format = ""
        Me.gColmoneda_tipo.FormatInfo = Nothing
        Me.gColmoneda_tipo.HeaderText = "Moneda"
        Me.gColmoneda_tipo.ImageList = Nothing
        Me.gColmoneda_tipo.isReadOnly = True
        Me.gColmoneda_tipo.MappingName = "moneda_tipo"
        Me.gColmoneda_tipo.MaxLength = 32767
        Me.gColmoneda_tipo.ReadOnly = True
        Me.gColmoneda_tipo.TabStop = True
        Me.gColmoneda_tipo.UseCustomCellFormat = False
        Me.gColmoneda_tipo.Width = 90
        '
        'gColCantidad
        '
        Me.gColCantidad.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.gColCantidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColCantidad.Format = "##,###"
        Me.gColCantidad.FormatInfo = Nothing
        Me.gColCantidad.HeaderText = "Cantidad ."
        Me.gColCantidad.ImageList = Nothing
        Me.gColCantidad.isReadOnly = False
        Me.gColCantidad.MappingName = "cantidad"
        Me.gColCantidad.MaxLength = 32767
        Me.gColCantidad.TabStop = True
        Me.gColCantidad.UseCustomCellFormat = False
        Me.gColCantidad.Width = 95
        '
        'gColImporte
        '
        Me.gColImporte.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.gColImporte.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColImporte.Format = "##,###.##"
        Me.gColImporte.FormatInfo = Nothing
        Me.gColImporte.HeaderText = "Total ."
        Me.gColImporte.ImageList = Nothing
        Me.gColImporte.isReadOnly = True
        Me.gColImporte.MappingName = "importe"
        Me.gColImporte.MaxLength = 32767
        Me.gColImporte.ReadOnly = True
        Me.gColImporte.TabStop = False
        Me.gColImporte.UseCustomCellFormat = False
        Me.gColImporte.Width = 95
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.TabIndex = 39
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.TabIndex = 38
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(0, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.TabIndex = 37
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(0, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.TabIndex = 36
        '
        'LibXShortNavigator1
        '
        Me.LibXShortNavigator1.BuildMenu = True
        Me.LibXShortNavigator1.Connector = Me.LibXConnector1
        Me.LibXShortNavigator1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LibXShortNavigator1.FirstControlInEditMode = Nothing
        Me.LibXShortNavigator1.FirstControlInFindMode = Nothing
        Me.LibXShortNavigator1.FirstControlInNewMode = Nothing
        Me.LibXShortNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.LibXShortNavigator1.Name = "LibXShortNavigator1"
        Me.LibXShortNavigator1.Size = New System.Drawing.Size(330, 24)
        Me.LibXShortNavigator1.TabIndex = 35
        '
        'i_cjdesglo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(330, 376)
        Me.Controls.Add(Me.LibXShortNavigator1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LibXGridDetalle)
        Me.Controls.Add(Me.lkMoneda)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "i_cjdesglo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Desglose de Monedas"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cjdesglosh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXGridDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub LibXConnector1_ExecutedAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutedAction
        Try
            If e.Action = LibxConnectionActions.Add Then
                LoadMonedas()
            End If
        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub


    Private Sub LoadMonedas()
        Dim SelectStmt As String
        Dim oTable As DataTable

        SelectStmt = "truncate table cjdesglosh"
        LibX.Data.Manager.GetDataTable(SelectStmt)

        SelectStmt = "select * from cjmoneda order by moneda_valor desc"
        oTable = LibX.Data.Manager.GetDataTable(SelectStmt)

        '//
        cjdesglosh.Rows.Clear()
        ''Dim line As Integer = 1
        Dim serial = LibX.Data.Manager.GetScalar("select max(init_serial) from cjinitm")

        For Each oRow As DataRow In oTable.Rows
            If cjdesglosh.Select("moneda_serial = " & oRow!moneda_serial.ToString.Trim).Length <= 0 Then
                Dim oRow1 As DataRow = cjdesglosh.NewRow

                oRow1.BeginEdit()
                oRow1!init_serial = serial
                ''oRow1!line_no = line
                oRow1!moneda_serial = oRow!moneda_serial
                oRow1!moneda_tipo = oRow!moneda_tipo
                oRow1!moneda_valor = oRow!moneda_valor
                oRow1.EndEdit()

                cjdesglosh.Rows.Add(oRow1)
                ''line = line + 1
            End If
        Next
    End Sub

    Private Sub i_ivadjus01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If Not LibXConnector1.Parameters Is Nothing Then
                If Not LibXConnector1.Parameters.Value Is Nothing Then
                    If CType(LibXConnector1.Parameters.Value, String).Trim.Length > 0 Then
                        ''txtitem_code.Text = LibXConnector1.Parameters.Value
                        ''lk_item_code.ExecuteFind()
                    End If
                End If
            End If

            Me.DataSet1.Tables("cjdesglosh").Columns("importe").Expression = "isnull(cantidad,0)*isnull(moneda_valor,0)"
            Me.LibXGridDetalle.footerOperations.add("importe", "sum(importe)")
            Me.LibXGridDetalle.footerOperations.add("moneda_serial", "count(moneda_serial)")

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub


    Private Sub LibXConnector1_SettingDefaulteditValues(ByVal sender As Object, ByVal e As LibX.SettingDefaultEditValues) Handles LibXConnector1.SettingDefaulteditValues
        Try
            LoadMonedas()
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub
    ''Private Sub LibXConnector1_BeforeSaveDetail(ByVal sender As Object, ByVal e As LibX.XBeforeSaveDetailEventArgs) Handles LibXConnector1.BeforeSaveDetail

    ''    Try
    ''        If LibXConnector1.CurrentAction = LibxConnectionActions.Edit _
    ''        Or LibXConnector1.CurrentAction = LibxConnectionActions.Add Then
    ''            For i As Integer = 0 To cjdesglosh.Rows.Count - 1
    ''                If cjdesglosh.Rows(i).RowState <> DataRowState.Deleted AndAlso LibX.IsNull(cjdesglosh.Rows(i)!cantidad) Then
    ''                    cjdesglosh.Rows(i).Delete()
    ''                End If
    ''            Next
    ''        End If

    ''    Catch ex As Exception
    ''        LibX.Log.Add(ex, True)
    ''    End Try
    ''End Sub
    Private Sub LibXConnector1_InsertingDetailRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatingEventArgs) Handles LibXConnector1.InsertingDetailRow
        Try

            '// si se esta insertando o actualizando y el registro
            '// que se va a actualizar no tiene cantidad especificada
            '// no insertarlo

            If e.UpdatingArgs.StatementType = StatementType.Insert _
            Or e.UpdatingArgs.StatementType = StatementType.Update Then
                ''    If LibX.IsNull(e.UpdatingArgs.Row!cantidad) _
                ''    Or Val(e.UpdatingArgs.Row!cantidad.ToString.Trim) <= 0 Then
                ''e.UpdatingArgs.Status = UpdateStatus.SkipCurrentRow
                e.UpdatingArgs.Status = UpdateStatus.SkipAllRemainingRows
                Me.Close()
            End If
            ''End If

        Catch ex As Exception
            e.UpdatingArgs.Status = UpdateStatus.ErrorsOccurred
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub LibXGridDetalle_CellValidate(ByVal sender As Object, ByVal e As LibX.LibXGrid.LibXGridCellValidateEventArgs) Handles LibXGridDetalle.CellValidate
        Try
            If LibXConnector1.IsDataEditing = True Then
                '// si es la cantidad no aceptar valores invalidos
                If gColCantidad.Column = e.cell Then
                    If Val(e.value.ToString.Trim) < 0 Then
                        Throw New ApplicationException("Debe especificar una cantidad valida, mayor que 0")
                    End If
                End If
            End If

        Catch ex As Exception
            e.hasErrors = True
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXGridDetalle_CurrentRowChanged(ByVal sender As Object, ByVal e As LibX.LibXGrid.XDataGridCurrentRowChangedEventArgs) Handles LibXGridDetalle.CurrentRowChanged
        Try
            If LibXConnector1.IsDataEditing = True Then
                Me.LibXGridDetalle.refreshFooter()
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_InsertedDetailRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatedEventArgs) Handles LibXConnector1.InsertedDetailRow
        If e.UpdatingArgs.StatementType = StatementType.Insert _
                    Or e.UpdatingArgs.StatementType = StatementType.Update Then
            e.UpdatingArgs.Status = UpdateStatus.SkipAllRemainingRows
            Me.Close()
        End If


    End Sub

    ''Private Sub LibXConnector1_InsertingRow(ByVal sender As Object, ByVal e As LibX.Data.AdpaterRowUpdatingEventArgs) Handles LibXConnector1.InsertingRow
    ''    ''If e.UpdatingArgs.StatementType = StatementType.Insert _
    ''    ''                 Or e.UpdatingArgs.StatementType = StatementType.Update Then
    ''    e.UpdatingArgs.Status = UpdateStatus.SkipAllRemainingRows
    ''    ''End If

    ''End Sub
End Class
