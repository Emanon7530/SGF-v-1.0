Public Class i_ptvfact02
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
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents xlk_aseg_poliza As LibX.LibXLookup
    Friend WithEvents xlk_plan_serial As LibX.LibXLookup
    Friend WithEvents xlk_cia_serial As LibX.LibXLookup
    Friend WithEvents lblnet_amount As System.Windows.Forms.Label
    Friend WithEvents lbltotal_amount As System.Windows.Forms.Label
    Friend WithEvents lblplan_cobertura As System.Windows.Forms.Label
    Friend WithEvents lblaseg_name As System.Windows.Forms.Label
    Friend WithEvents xtxt_aseg_poliza As LibX.XTextBox
    Friend WithEvents lblplan_name As System.Windows.Forms.Label
    Friend WithEvents lblcia_name As System.Windows.Forms.Label
    Friend WithEvents xtxt_cia_serial As LibX.XTextBox
    Friend WithEvents xtxt_plan_serial As LibX.XTextBox
    Friend WithEvents xtxt_seg_amount As LibX.XMaskEdit
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents ftsegrm As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents xtxt_autorizacion As LibX.XTextBox
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents lbl_descuento As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lblaseg_apellidos As System.Windows.Forms.Label
    Friend WithEvents xtxdisp As System.Windows.Forms.Label
    Friend WithEvents xtmdisp As System.Windows.Forms.Label
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.DataSet1 = New System.Data.DataSet
        Me.ftsegrm = New System.Data.DataTable
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
        Me.xtmdisp = New System.Windows.Forms.Label
        Me.xtxdisp = New System.Windows.Forms.Label
        Me.lblaseg_apellidos = New System.Windows.Forms.Label
        Me.lbl_descuento = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.xlk_aseg_poliza = New LibX.LibXLookup
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.xlk_plan_serial = New LibX.LibXLookup
        Me.xlk_cia_serial = New LibX.LibXLookup
        Me.lblnet_amount = New System.Windows.Forms.Label
        Me.lbltotal_amount = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblplan_cobertura = New System.Windows.Forms.Label
        Me.lblaseg_name = New System.Windows.Forms.Label
        Me.xtxt_aseg_poliza = New LibX.XTextBox
        Me.lblplan_name = New System.Windows.Forms.Label
        Me.lblcia_name = New System.Windows.Forms.Label
        Me.xtxt_cia_serial = New LibX.XTextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.xtxt_plan_serial = New LibX.XTextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.xtxt_autorizacion = New LibX.XTextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.xtxt_seg_amount = New LibX.XMaskEdit
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.lblMessage = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ftsegrm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.xtmdisp)
        Me.GroupBox3.Controls.Add(Me.xtxdisp)
        Me.GroupBox3.Controls.Add(Me.lblaseg_apellidos)
        Me.GroupBox3.Controls.Add(Me.lbl_descuento)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.xlk_aseg_poliza)
        Me.GroupBox3.Controls.Add(Me.xlk_plan_serial)
        Me.GroupBox3.Controls.Add(Me.xlk_cia_serial)
        Me.GroupBox3.Controls.Add(Me.lblnet_amount)
        Me.GroupBox3.Controls.Add(Me.lbltotal_amount)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.lblplan_cobertura)
        Me.GroupBox3.Controls.Add(Me.lblaseg_name)
        Me.GroupBox3.Controls.Add(Me.xtxt_aseg_poliza)
        Me.GroupBox3.Controls.Add(Me.lblplan_name)
        Me.GroupBox3.Controls.Add(Me.lblcia_name)
        Me.GroupBox3.Controls.Add(Me.xtxt_cia_serial)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.xtxt_plan_serial)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.xtxt_autorizacion)
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.Controls.Add(Me.xtxt_seg_amount)
        Me.GroupBox3.Controls.Add(Me.Label26)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 64)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(624, 288)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        '
        'DataSet1
        '
        Me.LibXConnector1.SetDataGenerator(Me.DataSet1, Me.LibXConnector1)
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, True)
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.ftsegrm})
        '
        'ftsegrm
        '
        Me.ftsegrm.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10})
        Me.ftsegrm.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"ftserial_no", "aseg_poliza"}, True)})
        Me.ftsegrm.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn3, Me.DataColumn4}
        Me.ftsegrm.TableName = "ftsegrm"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.ColumnName = "cia_serial"
        Me.DataColumn1.DataType = GetType(System.Int32)
        '
        'DataColumn2
        '
        Me.DataColumn2.AllowDBNull = False
        Me.DataColumn2.ColumnName = "plan_serial"
        Me.DataColumn2.DataType = GetType(System.Int32)
        '
        'DataColumn3
        '
        Me.DataColumn3.AllowDBNull = False
        Me.DataColumn3.ColumnName = "ftserial_no"
        Me.DataColumn3.DataType = GetType(System.Int32)
        '
        'DataColumn4
        '
        Me.DataColumn4.AllowDBNull = False
        Me.DataColumn4.ColumnName = "aseg_poliza"
        Me.DataColumn4.MaxLength = 20
        '
        'DataColumn5
        '
        Me.DataColumn5.AllowDBNull = False
        Me.DataColumn5.ColumnName = "segr_autorizacion"
        Me.DataColumn5.MaxLength = 40
        '
        'DataColumn6
        '
        Me.DataColumn6.AllowDBNull = False
        Me.DataColumn6.ColumnName = "empl_amount"
        Me.DataColumn6.DataType = GetType(System.Decimal)
        '
        'DataColumn7
        '
        Me.DataColumn7.AllowDBNull = False
        Me.DataColumn7.ColumnName = "cia_amount"
        Me.DataColumn7.DataType = GetType(System.Decimal)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "total_amount"
        Me.DataColumn8.DataType = GetType(System.Decimal)
        Me.DataColumn8.ReadOnly = True
        '
        'DataColumn9
        '
        Me.DataColumn9.AllowDBNull = False
        Me.DataColumn9.ColumnName = "segr_recetaunica"
        Me.DataColumn9.DataType = GetType(System.Int32)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "ind_usocontinuo"
        Me.DataColumn10.DataType = GetType(System.Int32)
        '
        'xtmdisp
        '
        Me.xtmdisp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xtmdisp.ForeColor = System.Drawing.Color.Red
        Me.xtmdisp.Location = New System.Drawing.Point(432, 207)
        Me.xtmdisp.Name = "xtmdisp"
        Me.xtmdisp.Size = New System.Drawing.Size(112, 23)
        Me.xtmdisp.TabIndex = 38
        Me.xtmdisp.Visible = False
        '
        'xtxdisp
        '
        Me.xtxdisp.AutoSize = True
        Me.xtxdisp.Location = New System.Drawing.Point(352, 208)
        Me.xtxdisp.Name = "xtxdisp"
        Me.xtxdisp.Size = New System.Drawing.Size(60, 16)
        Me.xtxdisp.TabIndex = 37
        Me.xtxdisp.Text = "Disponible:"
        Me.xtxdisp.Visible = False
        '
        'lblaseg_apellidos
        '
        Me.lblaseg_apellidos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblaseg_apellidos.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblaseg_apellidos.Location = New System.Drawing.Point(392, 24)
        Me.lblaseg_apellidos.Name = "lblaseg_apellidos"
        Me.lblaseg_apellidos.Size = New System.Drawing.Size(192, 20)
        Me.lblaseg_apellidos.TabIndex = 36
        '
        'lbl_descuento
        '
        Me.lbl_descuento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_descuento.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lbl_descuento.Location = New System.Drawing.Point(552, 96)
        Me.lbl_descuento.Name = "lbl_descuento"
        Me.lbl_descuento.Size = New System.Drawing.Size(48, 20)
        Me.lbl_descuento.TabIndex = 35
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(468, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 16)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "% Descuento:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xlk_aseg_poliza
        '
        Me.xlk_aseg_poliza.AlternateFieldSearch = Nothing
        Me.xlk_aseg_poliza.BeginCheck = False
        Me.xlk_aseg_poliza.CheckText = Nothing
        Me.xlk_aseg_poliza.ComboMode = False
        Me.xlk_aseg_poliza.DataMember = Nothing
        Me.xlk_aseg_poliza.DataSource = Me.LibXConnector1
        Me.xlk_aseg_poliza.DestParameters = New String() {"aseg_poliza=aseg_poliza", "lblaseg_name=aseg_nombre", "lblaseg_apellidos=aseg_apellidos", "cia_serial=cia_serial", "plan_serial=plan_serial"}
        Me.xlk_aseg_poliza.FilterField = "aseg_nombre"
        Me.xlk_aseg_poliza.IgnoreFindInBrowseMode = False
        Me.xlk_aseg_poliza.isCanceled = False
        Me.xlk_aseg_poliza.Location = New System.Drawing.Point(584, 24)
        Me.xlk_aseg_poliza.LookCaption = Nothing
        Me.xlk_aseg_poliza.Name = "xlk_aseg_poliza"
        Me.xlk_aseg_poliza.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_aseg_poliza.ShowFilter = True
        Me.xlk_aseg_poliza.ShowMessageNotFound = True
        Me.xlk_aseg_poliza.ShowWarning = False
        Me.xlk_aseg_poliza.Size = New System.Drawing.Size(16, 20)
        Me.xlk_aseg_poliza.SizesColumns = Nothing
        Me.xlk_aseg_poliza.SizesColumnsTab = Nothing
        Me.xlk_aseg_poliza.SqlString = New String() {"select top 1 * from sgasegm"}
        Me.xlk_aseg_poliza.SQLTab = Nothing
        Me.xlk_aseg_poliza.SrcParameters = New String() {"aseg_poliza=aseg_poliza"}
        Me.xlk_aseg_poliza.TabIndex = 33
        Me.xlk_aseg_poliza.TableName = "sgasegm"
        Me.xlk_aseg_poliza.TabStop = False
        Me.xlk_aseg_poliza.UseCopyConnection = False
        Me.xlk_aseg_poliza.UseRowRetrieveEvents = False
        Me.xlk_aseg_poliza.UseTab = False
        Me.xlk_aseg_poliza.VisParameters = New String() {"Poliza=aseg_poliza", "Nombre=aseg_nombre", "Apellidos=aseg_apellidos"}
        Me.xlk_aseg_poliza.WhereCondition = Nothing
        Me.xlk_aseg_poliza.WhereParameters = Nothing
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
        Me.LibXConnector1.DataMember = "ftsegrm"
        Me.LibXConnector1.DataSource = Me.DataSet1
        Me.LibXConnector1.EOF = False
        Me.LibXConnector1.HandledRowsFill = False
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
        Me.LibXConnector1.UseTransactions = False
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
        Me.LibXDbSourceTable1.Source = New String() {"select ftsegrm.cia_serial, ftsegrm.plan_serial,ftsegrm.ftserial_no, segr_recetaun" & _
        "ica,", "ftsegrm.aseg_poliza, segr_autorizacion, empl_amount,cia_amount,", "(isnull(fact_total,0) - isnull(descto,0) + isnull(itbis,0)) total_amount", "from ftsegrm inner join ftfactm", "on ftsegrm.ftserial_no = ftfactm.ftserial_no"}
        Me.LibXDbSourceTable1.TableName = "ftsegrm"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
        '
        'xlk_plan_serial
        '
        Me.xlk_plan_serial.AlternateFieldSearch = Nothing
        Me.xlk_plan_serial.BeginCheck = False
        Me.xlk_plan_serial.CheckText = Nothing
        Me.xlk_plan_serial.ComboMode = False
        Me.xlk_plan_serial.DataMember = Nothing
        Me.xlk_plan_serial.DataSource = Me.LibXConnector1
        Me.xlk_plan_serial.DestParameters = New String() {"plan_serial=plan_serial", "lblplan_name=plan_name", "lblplan_cobertura=plan_cobertura", "lbl_descuento=plan_descto"}
        Me.xlk_plan_serial.FilterField = Nothing
        Me.xlk_plan_serial.IgnoreFindInBrowseMode = False
        Me.xlk_plan_serial.isCanceled = False
        Me.xlk_plan_serial.Location = New System.Drawing.Point(584, 72)
        Me.xlk_plan_serial.LookCaption = Nothing
        Me.xlk_plan_serial.Name = "xlk_plan_serial"
        Me.xlk_plan_serial.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_plan_serial.ShowFilter = True
        Me.xlk_plan_serial.ShowMessageNotFound = True
        Me.xlk_plan_serial.ShowWarning = False
        Me.xlk_plan_serial.Size = New System.Drawing.Size(16, 20)
        Me.xlk_plan_serial.SizesColumns = Nothing
        Me.xlk_plan_serial.SizesColumnsTab = Nothing
        Me.xlk_plan_serial.SqlString = Nothing
        Me.xlk_plan_serial.SQLTab = Nothing
        Me.xlk_plan_serial.SrcParameters = New String() {"plan_serial=plan_serial"}
        Me.xlk_plan_serial.TabIndex = 32
        Me.xlk_plan_serial.TableName = "sgplanm"
        Me.xlk_plan_serial.TabStop = False
        Me.xlk_plan_serial.UseCopyConnection = False
        Me.xlk_plan_serial.UseRowRetrieveEvents = False
        Me.xlk_plan_serial.UseTab = False
        Me.xlk_plan_serial.VisParameters = New String() {"Codigo=plan_serial", "Nombre=plan_name"}
        Me.xlk_plan_serial.WhereCondition = Nothing
        Me.xlk_plan_serial.WhereParameters = Nothing
        '
        'xlk_cia_serial
        '
        Me.xlk_cia_serial.AlternateFieldSearch = Nothing
        Me.xlk_cia_serial.BeginCheck = False
        Me.xlk_cia_serial.CheckText = Nothing
        Me.xlk_cia_serial.ComboMode = False
        Me.xlk_cia_serial.DataMember = Nothing
        Me.xlk_cia_serial.DataSource = Me.LibXConnector1
        Me.xlk_cia_serial.DestParameters = New String() {"cia_serial=cia_serial", "lblcia_name=cia_name"}
        Me.xlk_cia_serial.FilterField = Nothing
        Me.xlk_cia_serial.IgnoreFindInBrowseMode = False
        Me.xlk_cia_serial.isCanceled = False
        Me.xlk_cia_serial.Location = New System.Drawing.Point(584, 48)
        Me.xlk_cia_serial.LookCaption = Nothing
        Me.xlk_cia_serial.Name = "xlk_cia_serial"
        Me.xlk_cia_serial.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_cia_serial.ShowFilter = True
        Me.xlk_cia_serial.ShowMessageNotFound = True
        Me.xlk_cia_serial.ShowWarning = False
        Me.xlk_cia_serial.Size = New System.Drawing.Size(16, 20)
        Me.xlk_cia_serial.SizesColumns = Nothing
        Me.xlk_cia_serial.SizesColumnsTab = Nothing
        Me.xlk_cia_serial.SqlString = Nothing
        Me.xlk_cia_serial.SQLTab = Nothing
        Me.xlk_cia_serial.SrcParameters = New String() {"cia_serial=cia_serial"}
        Me.xlk_cia_serial.TabIndex = 31
        Me.xlk_cia_serial.TableName = "sgciasm"
        Me.xlk_cia_serial.TabStop = False
        Me.xlk_cia_serial.UseCopyConnection = False
        Me.xlk_cia_serial.UseRowRetrieveEvents = False
        Me.xlk_cia_serial.UseTab = False
        Me.xlk_cia_serial.VisParameters = New String() {"Codigo=cia_serial", "Nombre=cia_name"}
        Me.xlk_cia_serial.WhereCondition = Nothing
        Me.xlk_cia_serial.WhereParameters = Nothing
        '
        'lblnet_amount
        '
        Me.lblnet_amount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblnet_amount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftsegrm.empl_amount"))
        Me.lblnet_amount.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblnet_amount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnet_amount.ForeColor = System.Drawing.Color.Blue
        Me.lblnet_amount.Location = New System.Drawing.Point(112, 248)
        Me.lblnet_amount.Name = "lblnet_amount"
        Me.lblnet_amount.Size = New System.Drawing.Size(152, 32)
        Me.lblnet_amount.TabIndex = 6
        Me.lblnet_amount.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbltotal_amount
        '
        Me.lbltotal_amount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbltotal_amount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftsegrm.total_amount"))
        Me.lbltotal_amount.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lbltotal_amount.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal_amount.Location = New System.Drawing.Point(112, 160)
        Me.lbltotal_amount.Name = "lbltotal_amount"
        Me.lbltotal_amount.Size = New System.Drawing.Size(152, 40)
        Me.lbltotal_amount.TabIndex = 4
        Me.lbltotal_amount.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.Location = New System.Drawing.Point(10, 168)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 16)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Total Facturado:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(41, 248)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 22)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Pagar:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblplan_cobertura
        '
        Me.lblplan_cobertura.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblplan_cobertura.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblplan_cobertura.Location = New System.Drawing.Point(112, 96)
        Me.lblplan_cobertura.Name = "lblplan_cobertura"
        Me.lblplan_cobertura.Size = New System.Drawing.Size(48, 20)
        Me.lblplan_cobertura.TabIndex = 25
        '
        'lblaseg_name
        '
        Me.lblaseg_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblaseg_name.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblaseg_name.Location = New System.Drawing.Point(232, 24)
        Me.lblaseg_name.Name = "lblaseg_name"
        Me.lblaseg_name.Size = New System.Drawing.Size(160, 20)
        Me.lblaseg_name.TabIndex = 24
        '
        'xtxt_aseg_poliza
        '
        Me.xtxt_aseg_poliza.AcceptsReturn = True
        Me.xtxt_aseg_poliza.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftsegrm.aseg_poliza"))
        Me.xtxt_aseg_poliza.EditInitialValue = Nothing
        Me.xtxt_aseg_poliza.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_aseg_poliza.FieldDescription = ""
        Me.xtxt_aseg_poliza.FindInitialValue = Nothing
        Me.xtxt_aseg_poliza.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_aseg_poliza.IgnoreRequiered = False
        Me.xtxt_aseg_poliza.Location = New System.Drawing.Point(112, 24)
        Me.xtxt_aseg_poliza.Name = "xtxt_aseg_poliza"
        Me.xtxt_aseg_poliza.NewInitialValue = Nothing
        Me.xtxt_aseg_poliza.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_aseg_poliza.ReadOnly = True
        Me.xtxt_aseg_poliza.Requiered = False
        Me.xtxt_aseg_poliza.Size = New System.Drawing.Size(120, 20)
        Me.xtxt_aseg_poliza.StatusBarPanelDescripcion = Nothing
        Me.xtxt_aseg_poliza.TabIndex = 0
        Me.xtxt_aseg_poliza.TabStop = False
        Me.xtxt_aseg_poliza.Text = ""
        '
        'lblplan_name
        '
        Me.lblplan_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblplan_name.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblplan_name.Location = New System.Drawing.Point(168, 72)
        Me.lblplan_name.Name = "lblplan_name"
        Me.lblplan_name.Size = New System.Drawing.Size(416, 20)
        Me.lblplan_name.TabIndex = 22
        '
        'lblcia_name
        '
        Me.lblcia_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblcia_name.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblcia_name.Location = New System.Drawing.Point(168, 48)
        Me.lblcia_name.Name = "lblcia_name"
        Me.lblcia_name.Size = New System.Drawing.Size(416, 20)
        Me.lblcia_name.TabIndex = 21
        '
        'xtxt_cia_serial
        '
        Me.xtxt_cia_serial.AcceptsReturn = True
        Me.xtxt_cia_serial.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftsegrm.cia_serial"))
        Me.xtxt_cia_serial.EditInitialValue = Nothing
        Me.xtxt_cia_serial.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_cia_serial.FieldDescription = ""
        Me.xtxt_cia_serial.FindInitialValue = Nothing
        Me.xtxt_cia_serial.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_cia_serial.IgnoreRequiered = False
        Me.xtxt_cia_serial.Location = New System.Drawing.Point(112, 48)
        Me.xtxt_cia_serial.Name = "xtxt_cia_serial"
        Me.xtxt_cia_serial.NewInitialValue = Nothing
        Me.xtxt_cia_serial.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_cia_serial.ReadOnly = True
        Me.xtxt_cia_serial.Requiered = False
        Me.xtxt_cia_serial.Size = New System.Drawing.Size(48, 20)
        Me.xtxt_cia_serial.StatusBarPanelDescripcion = Nothing
        Me.xtxt_cia_serial.TabIndex = 1
        Me.xtxt_cia_serial.TabStop = False
        Me.xtxt_cia_serial.Text = ""
        Me.xtxt_cia_serial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label21.Location = New System.Drawing.Point(12, 48)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(85, 16)
        Me.Label21.TabIndex = 19
        Me.Label21.Text = "Compañia ARS:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label22.Location = New System.Drawing.Point(40, 24)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(57, 16)
        Me.Label22.TabIndex = 19
        Me.Label22.Text = "Pasciente:"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_plan_serial
        '
        Me.xtxt_plan_serial.AcceptsReturn = True
        Me.xtxt_plan_serial.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftsegrm.plan_serial"))
        Me.xtxt_plan_serial.EditInitialValue = Nothing
        Me.xtxt_plan_serial.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_plan_serial.FieldDescription = ""
        Me.xtxt_plan_serial.FindInitialValue = Nothing
        Me.xtxt_plan_serial.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_plan_serial.IgnoreRequiered = False
        Me.xtxt_plan_serial.Location = New System.Drawing.Point(112, 72)
        Me.xtxt_plan_serial.Name = "xtxt_plan_serial"
        Me.xtxt_plan_serial.NewInitialValue = Nothing
        Me.xtxt_plan_serial.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_plan_serial.ReadOnly = True
        Me.xtxt_plan_serial.Requiered = False
        Me.xtxt_plan_serial.Size = New System.Drawing.Size(48, 20)
        Me.xtxt_plan_serial.StatusBarPanelDescripcion = Nothing
        Me.xtxt_plan_serial.TabIndex = 2
        Me.xtxt_plan_serial.TabStop = False
        Me.xtxt_plan_serial.Text = ""
        Me.xtxt_plan_serial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label23.Location = New System.Drawing.Point(67, 72)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(30, 16)
        Me.Label23.TabIndex = 19
        Me.Label23.Text = "Plan:"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label24.Location = New System.Drawing.Point(26, 96)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(71, 16)
        Me.Label24.TabIndex = 19
        Me.Label24.Text = "% Cobertura:"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_autorizacion
        '
        Me.xtxt_autorizacion.AcceptsReturn = True
        Me.xtxt_autorizacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftsegrm.segr_autorizacion"))
        Me.xtxt_autorizacion.EditInitialValue = Nothing
        Me.xtxt_autorizacion.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_autorizacion.FieldDescription = ""
        Me.xtxt_autorizacion.FindInitialValue = Nothing
        Me.xtxt_autorizacion.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_autorizacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xtxt_autorizacion.IgnoreRequiered = False
        Me.xtxt_autorizacion.Location = New System.Drawing.Point(112, 120)
        Me.xtxt_autorizacion.Name = "xtxt_autorizacion"
        Me.xtxt_autorizacion.NewInitialValue = Nothing
        Me.xtxt_autorizacion.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_autorizacion.Requiered = True
        Me.xtxt_autorizacion.Size = New System.Drawing.Size(152, 32)
        Me.xtxt_autorizacion.StatusBarPanelDescripcion = Nothing
        Me.xtxt_autorizacion.TabIndex = 0
        Me.xtxt_autorizacion.Text = ""
        Me.xtxt_autorizacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label25.Location = New System.Drawing.Point(18, 120)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(79, 16)
        Me.Label25.TabIndex = 19
        Me.Label25.Text = "# Autorización:"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_seg_amount
        '
        Me.xtxt_seg_amount.AcceptsReturn = True
        Me.xtxt_seg_amount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftsegrm.cia_amount"))
        Me.xtxt_seg_amount.EditInitialValue = Nothing
        Me.xtxt_seg_amount.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_seg_amount.FieldDescription = ""
        Me.xtxt_seg_amount.FindInitialValue = Nothing
        Me.xtxt_seg_amount.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_seg_amount.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xtxt_seg_amount.IgnoreRequiered = False
        Me.xtxt_seg_amount.Location = New System.Drawing.Point(112, 208)
        Me.xtxt_seg_amount.Masked = MaskedTextBox.Mask.Decimal
        Me.xtxt_seg_amount.Name = "xtxt_seg_amount"
        Me.xtxt_seg_amount.NewInitialValue = Nothing
        Me.xtxt_seg_amount.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_seg_amount.Requiered = False
        Me.xtxt_seg_amount.Size = New System.Drawing.Size(152, 32)
        Me.xtxt_seg_amount.StatusBarPanelDescripcion = Nothing
        Me.xtxt_seg_amount.TabIndex = 2
        Me.xtxt_seg_amount.Text = ""
        Me.xtxt_seg_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label26.Location = New System.Drawing.Point(39, 216)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(58, 16)
        Me.Label26.TabIndex = 19
        Me.Label26.Text = "Cobertura:"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(640, 56)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CAPTURA DE AUTORIZACION"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnAceptar.Location = New System.Drawing.Point(472, 360)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.TabIndex = 2
        Me.btnAceptar.Text = "Aceptar(F5)"
        Me.ToolTip1.SetToolTip(Me.btnAceptar, "Terminar de procesar el seguro medico")
        Me.btnAceptar.Visible = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(552, 360)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "Cancelar"
        Me.ToolTip1.SetToolTip(Me.btnCancelar, "Cancelar la operación y cerrar esta pantalla")
        '
        'lblMessage
        '
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.ForeColor = System.Drawing.Color.Red
        Me.lblMessage.Location = New System.Drawing.Point(8, 360)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(448, 23)
        Me.lblMessage.TabIndex = 4
        '
        'i_ptvfact02
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(640, 392)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnCancelar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "i_ptvfact02"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Captura de Autorización"
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ftsegrm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim mAutorizacion As SGT.PuntodeVenta.Entidades.AutorizacionSeguro
    Dim oCliente As SGT.PuntodeVenta.Entidades.clsCompararAsegurado

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        If LibXConnector1.IsDataEditing = True Then
            LibXConnector1.Cancel()
        End If
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim Sqlstring As String
        Dim oTable As DataTable
        Try
            oCliente = New SGT.PuntodeVenta.Entidades.clsCompararAsegurado
            '// Validar Monto Cobertura
            If ValidarMonto() = False Then
                Me.lblMessage.Text = "Valor de la Cobertura no puede ser mayor al monto facturado!"
                Exit Sub
            End If

            If oCliente.ValidacionAsegurado(xtxt_aseg_poliza.Text, xtxt_seg_amount.Text) = False Then
                Me.xtmdisp.Visible = True
                Me.xtxdisp.Visible = True
                Me.xtmdisp.Text = Val(oCliente.CoverturaDisponible(xtxt_aseg_poliza.Text))
                xtxt_seg_amount.Focus()
                Me.lblMessage.Text = "Lo facturado sobrepasa el limite permitido del asegurado"
                Exit Sub
            End If

            '// Asignar Valores al parametro
            SetPropertyValue()

            '// guardar registro
            LibXConnector1.Accept()
            Me.DialogResult = DialogResult.OK

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub SetPropertyValue()
        Try
            mAutorizacion.MontoCobertura = CDbl(Me.xtxt_seg_amount.Text)
            mAutorizacion.Autorizacion = Me.xtxt_autorizacion.Text
            Me.mAutorizacion.TotalFacturado = CDbl(Me.lbltotal_amount.Text)
            Me.mAutorizacion.MontoPagar = CDbl(Me.lblnet_amount.Text)
            'If xtxt_segr_recetaUnica.Text.Trim <> "" Then
            '    Me.mAutorizacion.RecetaUnica = xtxt_segr_recetaUnica.Text
            'End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub
    Private Sub LibXConnector1_SettingDefaultNewValues(ByVal sender As Object, ByVal e As LibX.SettingDefaultNewValues) Handles LibXConnector1.SettingDefaultNewValues
        EditarValores()
    End Sub
    Private Sub EditarValores()
        Try
            Me.xtxt_aseg_poliza.Text = mAutorizacion.Poliza
            If mAutorizacion.Poliza.Trim <> "" Then
                Me.xlk_aseg_poliza.ExecuteFind()
            End If

            Me.xtxt_plan_serial.Text = mAutorizacion.Plan
            If mAutorizacion.Plan > 0 Then
                Me.xlk_plan_serial.ExecuteFind()
            End If

            Me.xtxt_cia_serial.Text = mAutorizacion.Compania
            If mAutorizacion.Compania > 0 Then
                Me.xlk_cia_serial.ExecuteFind()
            End If

            Me.xtxt_autorizacion.Text = mAutorizacion.Autorizacion.ToString.Trim
            Me.lbltotal_amount.Text = mAutorizacion.TotalFacturado.ToString("#,###,##0.00")

            Me.xtxt_seg_amount.Text = mAutorizacion.MontoCobertura.ToString("#,###,##0.00")
            'Me.xtxt_segr_recetaUnica.Text = 0
            Me.xlk_aseg_poliza.ExecuteFind()
            xtxt_autorizacion.Focus()

            'Me.xlk_cia_serial.ExecuteFind()
            'Me.xlk_plan_serial.ExecuteFind()

            Calculos()
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
    Private Sub Calculos()
        Dim Total As Decimal
        Dim Cobertura As Decimal
        Dim Pagar As Decimal

        Try

            Total = CDec(lbltotal_amount.Text)
            Cobertura = CDec(xtxt_seg_amount.Text)
            Pagar = Total - Cobertura

            Me.lblnet_amount.Text = Pagar.ToString("#,###,##0.00")


        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub xtxt_seg_amount_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles xtxt_seg_amount.Validating
        Try
            Calculos()
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_ExecutedAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutedAction
        Try
            If e.Action = LibX.LibxConnectionActions.Add _
            Or e.Action = LibX.LibxConnectionActions.Edit Then
                Me.btnAceptar.Visible = True
                Me.xtxt_autorizacion.Focus()
            End If
            If e.Action = LibX.LibxConnectionActions.Accept Then
                If ValidarMonto() = False Then
                    Me.lblMessage.Text = "Valor de la Cobertura no puede ser mayor al monto facturado!"
                    Exit Sub
                End If
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Public Overloads Function ShowDialog(ByVal oAutorizacion As SGT.PuntodeVenta.Entidades.AutorizacionSeguro) As DialogResult
        mAutorizacion = oAutorizacion

        Return MyBase.ShowDialog
    End Function

    Private Sub xlk_aseg_poliza_AfterSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles xlk_aseg_poliza.AfterSetValues
        Try

            Me.xlk_cia_serial.ExecuteFind()
            Me.xlk_plan_serial.ExecuteFind()

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub i_ptvfact02_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub i_ptvfact02_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            If LibXConnector1.IsDataEditing = True Then
                If e.KeyCode = Keys.F5 Then
                    '// Validar Cobertura no sea mayor que monto facturado
                    ValidarMonto()

                    '// Asignar Valor
                    SetPropertyValue()

                    LibXConnector1.AcceptNew()
                    Me.DialogResult = DialogResult.OK
                    Me.Close()
                End If
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Function ValidarMonto() As Boolean
        If Me.lbltotal_amount.Text.Trim <> String.Empty AndAlso Me.xtxt_seg_amount.Text.Trim <> String.Empty Then
            If CDbl(Me.lbltotal_amount.Text) < CDbl(Me.xtxt_seg_amount.Text) Then
                Return False
            Else
                Return True
            End If
        End If

    End Function

    Private Sub LibXConnector1_SettingDefaulteditValues(ByVal sender As Object, ByVal e As LibX.SettingDefaultEditValues) Handles LibXConnector1.SettingDefaulteditValues
        EditarValores()

    End Sub
End Class
