Imports LibX
Public Class r_ptvfact03
    Inherits System.Windows.Forms.Form
    Dim WhDefault As Integer
    Dim oDoc As SGT.Facturacion.Entidades.Documento
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents LibXDbSourceTable2 As LibX.LibXDbSourceTable
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnEjecutar As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtwhse_code As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LibXLookup1 As LibX.LibXLookup
    Friend WithEvents lblwhse_name As System.Windows.Forms.Label
    Friend WithEvents Txt_almacen As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Fecha_Fin As LibX.LibxDateTimePicker
    Friend WithEvents Fecha_Ini As LibX.LibxDateTimePicker
    Friend WithEvents LibXLookup2 As LibX.LibXLookup
    Friend WithEvents LibXLookup4 As LibX.LibXLookup
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents LibXLookup5 As LibX.LibXLookup
    Friend WithEvents caja_name As System.Windows.Forms.Label
    Friend WithEvents cajera_name As System.Windows.Forms.Label
    Friend WithEvents mensaj_name As System.Windows.Forms.Label
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents mend_code As System.Windows.Forms.TextBox
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents xtcaja As System.Windows.Forms.TextBox
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents ftdomim As System.Data.DataTable
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn17 As System.Data.DataColumn
    Friend WithEvents DataColumn18 As System.Data.DataColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RdBMesaje As System.Windows.Forms.RadioButton
    Friend WithEvents RdBPendiente As System.Windows.Forms.RadioButton
    Friend WithEvents RdBTotal As System.Windows.Forms.RadioButton
    Friend WithEvents DataColumn19 As System.Data.DataColumn
    Friend WithEvents DataColumn20 As System.Data.DataColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.DataSet1 = New System.Data.DataSet
        Me.DataTable1 = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn7 = New System.Data.DataColumn
        Me.DataColumn8 = New System.Data.DataColumn
        Me.DataColumn9 = New System.Data.DataColumn
        Me.DataColumn10 = New System.Data.DataColumn
        Me.DataColumn11 = New System.Data.DataColumn
        Me.DataColumn12 = New System.Data.DataColumn
        Me.DataColumn13 = New System.Data.DataColumn
        Me.DataColumn14 = New System.Data.DataColumn
        Me.DataColumn15 = New System.Data.DataColumn
        Me.DataColumn16 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn17 = New System.Data.DataColumn
        Me.DataColumn18 = New System.Data.DataColumn
        Me.DataColumn19 = New System.Data.DataColumn
        Me.DataColumn20 = New System.Data.DataColumn
        Me.ftdomim = New System.Data.DataTable
        Me.DataColumn6 = New System.Data.DataColumn
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnLimpiar = New System.Windows.Forms.Button
        Me.btnEjecutar = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtwhse_code = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.LibXLookup1 = New LibX.LibXLookup
        Me.lblwhse_name = New System.Windows.Forms.Label
        Me.Txt_almacen = New System.Windows.Forms.TextBox
        Me.Fecha_Fin = New LibX.LibxDateTimePicker
        Me.Fecha_Ini = New LibX.LibxDateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.LibXLookup2 = New LibX.LibXLookup
        Me.mensaj_name = New System.Windows.Forms.Label
        Me.xtcaja = New System.Windows.Forms.TextBox
        Me.LibXLookup4 = New LibX.LibXLookup
        Me.caja_name = New System.Windows.Forms.Label
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.LibXLookup5 = New LibX.LibXLookup
        Me.cajera_name = New System.Windows.Forms.Label
        Me.mend_code = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.RdBTotal = New System.Windows.Forms.RadioButton
        Me.RdBPendiente = New System.Windows.Forms.RadioButton
        Me.RdBMesaje = New System.Windows.Forms.RadioButton
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ftdomim, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
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
        Me.LibXConnector1.DataMember = Nothing
        Me.LibXConnector1.DataSource = Me.DataSet1
        Me.LibXConnector1.EOF = False
        Me.LibXConnector1.HandledRowsFill = True
        Me.LibXConnector1.HandledUpdates = True
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
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, False)
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1, Me.ftdomim})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn5, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20})
        Me.DataTable1.TableName = "repventav"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.ColumnName = "fact_date"
        Me.DataColumn1.DataType = GetType(System.DateTime)
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "whse_code"
        Me.DataColumn2.DataType = GetType(System.Int32)
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "caja_code"
        Me.DataColumn3.DataType = GetType(System.Int32)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "caje_code"
        Me.DataColumn4.DataType = GetType(System.Int32)
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "fact_inddomicilio"
        Me.DataColumn7.DataType = GetType(System.Int32)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "fact_total"
        Me.DataColumn8.DataType = GetType(System.Decimal)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "dscto"
        Me.DataColumn9.DataType = GetType(System.Decimal)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "itbis"
        Me.DataColumn10.DataType = GetType(System.Decimal)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "efectivo"
        Me.DataColumn11.DataType = GetType(System.Decimal)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "tarjeta"
        Me.DataColumn12.DataType = GetType(System.Decimal)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "credito"
        Me.DataColumn13.DataType = GetType(System.Decimal)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "notacredito"
        Me.DataColumn14.DataType = GetType(System.Decimal)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "cheque"
        Me.DataColumn15.DataType = GetType(System.Decimal)
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "seguro"
        Me.DataColumn16.DataType = GetType(System.Decimal)
        '
        'DataColumn5
        '
        Me.DataColumn5.AllowDBNull = False
        Me.DataColumn5.ColumnName = "vend_mensaj"
        Me.DataColumn5.MaxLength = 3
        '
        'DataColumn17
        '
        Me.DataColumn17.AllowDBNull = False
        Me.DataColumn17.ColumnName = "type_code"
        Me.DataColumn17.MaxLength = 3
        '
        'DataColumn18
        '
        Me.DataColumn18.AllowDBNull = False
        Me.DataColumn18.ColumnName = "ftserial_no"
        Me.DataColumn18.DataType = GetType(System.Int32)
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "fecha_ini"
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "fecha_fin"
        '
        'ftdomim
        '
        Me.ftdomim.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn6})
        Me.ftdomim.TableName = "ftdomim"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "vend_mensaj"
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
        Me.LibXDbSourceTable1.TableName = "repventav"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(4, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Fecha inicial:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Location = New System.Drawing.Point(11, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Fecha final:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(Me.btnEjecutar)
        Me.GroupBox1.Location = New System.Drawing.Point(432, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(88, 152)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnClose.Location = New System.Drawing.Point(8, 104)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(72, 32)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Cerrar"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnLimpiar.Location = New System.Drawing.Point(8, 56)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(72, 32)
        Me.btnLimpiar.TabIndex = 1
        Me.btnLimpiar.Text = "Limpiar"
        '
        'btnEjecutar
        '
        Me.btnEjecutar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnEjecutar.Location = New System.Drawing.Point(9, 16)
        Me.btnEjecutar.Name = "btnEjecutar"
        Me.btnEjecutar.Size = New System.Drawing.Size(72, 32)
        Me.btnEjecutar.TabIndex = 0
        Me.btnEjecutar.Text = "Ejecutar"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(538, 48)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "RESUMEN DE DOMICILIO"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtwhse_code
        '
        Me.txtwhse_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "repventav.whse_code"))
        Me.txtwhse_code.Location = New System.Drawing.Point(88, 112)
        Me.txtwhse_code.Name = "txtwhse_code"
        Me.txtwhse_code.Size = New System.Drawing.Size(56, 20)
        Me.txtwhse_code.TabIndex = 2
        Me.txtwhse_code.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Location = New System.Drawing.Point(23, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 16)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Almacen:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LibXLookup1
        '
        Me.LibXLookup1.AlternateFieldSearch = Nothing
        Me.LibXLookup1.BeginCheck = False
        Me.LibXLookup1.CheckText = Nothing
        Me.LibXLookup1.ComboMode = False
        Me.LibXLookup1.DataMember = Nothing
        Me.LibXLookup1.DataSource = Me.LibXConnector1
        Me.LibXLookup1.DestParameters = New String() {"whse_code=whse_code", "lblwhse_name=whse_name"}
        Me.LibXLookup1.FilterField = Nothing
        Me.LibXLookup1.IgnoreFindInBrowseMode = False
        Me.LibXLookup1.isCanceled = False
        Me.LibXLookup1.Location = New System.Drawing.Point(384, 112)
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
        Me.LibXLookup1.SrcParameters = New String() {"whse_code=whse_code"}
        Me.LibXLookup1.TabIndex = 3
        Me.LibXLookup1.TableName = "ivwhsem"
        Me.LibXLookup1.TabStop = False
        Me.LibXLookup1.UseCopyConnection = False
        Me.LibXLookup1.UseRowRetrieveEvents = False
        Me.LibXLookup1.UseTab = False
        Me.LibXLookup1.VisParameters = New String() {"Código=whse_code", "Descripción=whse_name"}
        Me.LibXLookup1.WhereCondition = Nothing
        Me.LibXLookup1.WhereParameters = Nothing
        '
        'lblwhse_name
        '
        Me.lblwhse_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblwhse_name.Location = New System.Drawing.Point(144, 112)
        Me.lblwhse_name.Name = "lblwhse_name"
        Me.lblwhse_name.Size = New System.Drawing.Size(240, 20)
        Me.lblwhse_name.TabIndex = 19
        '
        'Txt_almacen
        '
        Me.Txt_almacen.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "repventav.whse_code"))
        Me.Txt_almacen.Location = New System.Drawing.Point(88, 112)
        Me.Txt_almacen.Name = "Txt_almacen"
        Me.Txt_almacen.Size = New System.Drawing.Size(56, 20)
        Me.Txt_almacen.TabIndex = 38
        Me.Txt_almacen.Text = ""
        '
        'Fecha_Fin
        '
        Me.Fecha_Fin.CustomFormat = "dd/MM/yyyy"
        Me.Fecha_Fin.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "repventav.fecha_fin"))
        Me.Fecha_Fin.EditInitialValue = Nothing
        Me.Fecha_Fin.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Fecha_Fin.FieldDescription = ""
        Me.Fecha_Fin.FindInitialValue = ""
        Me.Fecha_Fin.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Fecha_Fin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Fecha_Fin.IgnoreRequiered = False
        Me.Fecha_Fin.Location = New System.Drawing.Point(88, 88)
        Me.Fecha_Fin.Name = "Fecha_Fin"
        Me.Fecha_Fin.NewInitialValue = Nothing
        Me.Fecha_Fin.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Fecha_Fin.Requiered = False
        Me.Fecha_Fin.Size = New System.Drawing.Size(128, 20)
        Me.Fecha_Fin.StatusBarPanelDescripcion = Nothing
        Me.Fecha_Fin.TabIndex = 1
        '
        'Fecha_Ini
        '
        Me.Fecha_Ini.CustomFormat = "dd/MM/yyyy"
        Me.Fecha_Ini.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "repventav.fecha_ini"))
        Me.Fecha_Ini.EditInitialValue = Nothing
        Me.Fecha_Ini.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Fecha_Ini.FieldDescription = ""
        Me.Fecha_Ini.FindInitialValue = ""
        Me.Fecha_Ini.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Fecha_Ini.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Fecha_Ini.IgnoreRequiered = False
        Me.Fecha_Ini.Location = New System.Drawing.Point(88, 64)
        Me.Fecha_Ini.Name = "Fecha_Ini"
        Me.Fecha_Ini.NewInitialValue = Nothing
        Me.Fecha_Ini.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.Fecha_Ini.Requiered = False
        Me.Fecha_Ini.Size = New System.Drawing.Size(128, 20)
        Me.Fecha_Ini.StatusBarPanelDescripcion = Nothing
        Me.Fecha_Ini.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label7.Location = New System.Drawing.Point(40, 136)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 16)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Caja.:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label6.Location = New System.Drawing.Point(8, 184)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 16)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Mensajero.:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label8.Location = New System.Drawing.Point(24, 160)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 16)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Cajero.:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LibXLookup2
        '
        Me.LibXLookup2.AlternateFieldSearch = Nothing
        Me.LibXLookup2.BeginCheck = False
        Me.LibXLookup2.CheckText = Nothing
        Me.LibXLookup2.ComboMode = False
        Me.LibXLookup2.DataMember = Nothing
        Me.LibXLookup2.DataSource = Me.LibXConnector1
        Me.LibXLookup2.DestParameters = New String() {"mend_code=vend_code", "mensaj_name=vend_name"}
        Me.LibXLookup2.FilterField = Nothing
        Me.LibXLookup2.IgnoreFindInBrowseMode = False
        Me.LibXLookup2.isCanceled = False
        Me.LibXLookup2.Location = New System.Drawing.Point(384, 184)
        Me.LibXLookup2.LookCaption = Nothing
        Me.LibXLookup2.Name = "LibXLookup2"
        Me.LibXLookup2.PopupSize = New System.Drawing.Size(0, 0)
        Me.LibXLookup2.ShowFilter = True
        Me.LibXLookup2.ShowMessageNotFound = True
        Me.LibXLookup2.ShowWarning = False
        Me.LibXLookup2.Size = New System.Drawing.Size(16, 20)
        Me.LibXLookup2.SizesColumns = Nothing
        Me.LibXLookup2.SizesColumnsTab = Nothing
        Me.LibXLookup2.SqlString = Nothing
        Me.LibXLookup2.SQLTab = Nothing
        Me.LibXLookup2.SrcParameters = New String() {"vend_mensaj=vend_code"}
        Me.LibXLookup2.TabIndex = 41
        Me.LibXLookup2.TableName = "ftvendm"
        Me.LibXLookup2.TabStop = False
        Me.LibXLookup2.UseCopyConnection = False
        Me.LibXLookup2.UseRowRetrieveEvents = False
        Me.LibXLookup2.UseTab = False
        Me.LibXLookup2.VisParameters = New String() {"Código=vend_code", "Descripción=vend_name"}
        Me.LibXLookup2.WhereCondition = "vend_cargo = 3"
        Me.LibXLookup2.WhereParameters = Nothing
        '
        'mensaj_name
        '
        Me.mensaj_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.mensaj_name.Location = New System.Drawing.Point(144, 184)
        Me.mensaj_name.Name = "mensaj_name"
        Me.mensaj_name.Size = New System.Drawing.Size(240, 20)
        Me.mensaj_name.TabIndex = 42
        '
        'xtcaja
        '
        Me.xtcaja.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "repventav.caja_code"))
        Me.xtcaja.Location = New System.Drawing.Point(88, 136)
        Me.xtcaja.Name = "xtcaja"
        Me.xtcaja.Size = New System.Drawing.Size(56, 20)
        Me.xtcaja.TabIndex = 49
        Me.xtcaja.Text = ""
        '
        'LibXLookup4
        '
        Me.LibXLookup4.AlternateFieldSearch = Nothing
        Me.LibXLookup4.BeginCheck = False
        Me.LibXLookup4.CheckText = Nothing
        Me.LibXLookup4.ComboMode = False
        Me.LibXLookup4.DataMember = Nothing
        Me.LibXLookup4.DataSource = Me.LibXConnector1
        Me.LibXLookup4.DestParameters = New String() {"caja_code=caja_code", "caja_name=caja_name"}
        Me.LibXLookup4.FilterField = Nothing
        Me.LibXLookup4.IgnoreFindInBrowseMode = False
        Me.LibXLookup4.isCanceled = False
        Me.LibXLookup4.Location = New System.Drawing.Point(384, 136)
        Me.LibXLookup4.LookCaption = "Caja"
        Me.LibXLookup4.Name = "LibXLookup4"
        Me.LibXLookup4.PopupSize = New System.Drawing.Size(0, 0)
        Me.LibXLookup4.ShowFilter = True
        Me.LibXLookup4.ShowMessageNotFound = True
        Me.LibXLookup4.ShowWarning = False
        Me.LibXLookup4.Size = New System.Drawing.Size(16, 20)
        Me.LibXLookup4.SizesColumns = Nothing
        Me.LibXLookup4.SizesColumnsTab = Nothing
        Me.LibXLookup4.SqlString = Nothing
        Me.LibXLookup4.SQLTab = Nothing
        Me.LibXLookup4.SrcParameters = New String() {"caja_code=caja_code"}
        Me.LibXLookup4.TabIndex = 47
        Me.LibXLookup4.TableName = "cjcajam"
        Me.LibXLookup4.TabStop = False
        Me.LibXLookup4.UseCopyConnection = False
        Me.LibXLookup4.UseRowRetrieveEvents = False
        Me.LibXLookup4.UseTab = False
        Me.LibXLookup4.VisParameters = New String() {"Código=caja_code", "Descripción=caja_name"}
        Me.LibXLookup4.WhereCondition = Nothing
        Me.LibXLookup4.WhereParameters = Nothing
        '
        'caja_name
        '
        Me.caja_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.caja_name.Location = New System.Drawing.Point(144, 136)
        Me.caja_name.Name = "caja_name"
        Me.caja_name.Size = New System.Drawing.Size(240, 20)
        Me.caja_name.TabIndex = 48
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "repventav.caje_code"))
        Me.TextBox4.Location = New System.Drawing.Point(88, 160)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(56, 20)
        Me.TextBox4.TabIndex = 52
        Me.TextBox4.Text = ""
        '
        'LibXLookup5
        '
        Me.LibXLookup5.AlternateFieldSearch = Nothing
        Me.LibXLookup5.BeginCheck = False
        Me.LibXLookup5.CheckText = Nothing
        Me.LibXLookup5.ComboMode = False
        Me.LibXLookup5.DataMember = Nothing
        Me.LibXLookup5.DataSource = Me.LibXConnector1
        Me.LibXLookup5.DestParameters = New String() {"caje_code=vend_code", "cajera_name=vend_name"}
        Me.LibXLookup5.FilterField = Nothing
        Me.LibXLookup5.IgnoreFindInBrowseMode = False
        Me.LibXLookup5.isCanceled = False
        Me.LibXLookup5.Location = New System.Drawing.Point(384, 160)
        Me.LibXLookup5.LookCaption = Nothing
        Me.LibXLookup5.Name = "LibXLookup5"
        Me.LibXLookup5.PopupSize = New System.Drawing.Size(0, 0)
        Me.LibXLookup5.ShowFilter = True
        Me.LibXLookup5.ShowMessageNotFound = True
        Me.LibXLookup5.ShowWarning = False
        Me.LibXLookup5.Size = New System.Drawing.Size(16, 20)
        Me.LibXLookup5.SizesColumns = Nothing
        Me.LibXLookup5.SizesColumnsTab = Nothing
        Me.LibXLookup5.SqlString = Nothing
        Me.LibXLookup5.SQLTab = Nothing
        Me.LibXLookup5.SrcParameters = New String() {"caje_code=vend_code"}
        Me.LibXLookup5.TabIndex = 50
        Me.LibXLookup5.TableName = "ftvendm"
        Me.LibXLookup5.TabStop = False
        Me.LibXLookup5.UseCopyConnection = False
        Me.LibXLookup5.UseRowRetrieveEvents = False
        Me.LibXLookup5.UseTab = False
        Me.LibXLookup5.VisParameters = New String() {"Código=vend_code", "Descripción=vend_name"}
        Me.LibXLookup5.WhereCondition = "vend_cargo = 1"
        Me.LibXLookup5.WhereParameters = Nothing
        '
        'cajera_name
        '
        Me.cajera_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.cajera_name.Location = New System.Drawing.Point(144, 160)
        Me.cajera_name.Name = "cajera_name"
        Me.cajera_name.Size = New System.Drawing.Size(240, 20)
        Me.cajera_name.TabIndex = 51
        '
        'mend_code
        '
        Me.mend_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "repventav.vend_mensaj"))
        Me.mend_code.Location = New System.Drawing.Point(88, 184)
        Me.mend_code.Name = "mend_code"
        Me.mend_code.Size = New System.Drawing.Size(56, 20)
        Me.mend_code.TabIndex = 53
        Me.mend_code.Text = ""
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RdBTotal)
        Me.GroupBox2.Controls.Add(Me.RdBPendiente)
        Me.GroupBox2.Controls.Add(Me.RdBMesaje)
        Me.GroupBox2.Location = New System.Drawing.Point(225, 51)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(119, 56)
        Me.GroupBox2.TabIndex = 54
        Me.GroupBox2.TabStop = False
        '
        'RdBTotal
        '
        Me.RdBTotal.Location = New System.Drawing.Point(9, 36)
        Me.RdBTotal.Name = "RdBTotal"
        Me.RdBTotal.Size = New System.Drawing.Size(104, 18)
        Me.RdBTotal.TabIndex = 2
        Me.RdBTotal.Text = "Domicilio x Mes"
        '
        'RdBPendiente
        '
        Me.RdBPendiente.Location = New System.Drawing.Point(9, 22)
        Me.RdBPendiente.Name = "RdBPendiente"
        Me.RdBPendiente.Size = New System.Drawing.Size(104, 16)
        Me.RdBPendiente.TabIndex = 1
        Me.RdBPendiente.Text = "Domicilio Pend."
        '
        'RdBMesaje
        '
        Me.RdBMesaje.Checked = True
        Me.RdBMesaje.Location = New System.Drawing.Point(9, 8)
        Me.RdBMesaje.Name = "RdBMesaje"
        Me.RdBMesaje.Size = New System.Drawing.Size(104, 16)
        Me.RdBMesaje.TabIndex = 0
        Me.RdBMesaje.TabStop = True
        Me.RdBMesaje.Text = "Mensajeria"
        '
        'r_ptvfact03
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(538, 234)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.mend_code)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.LibXLookup5)
        Me.Controls.Add(Me.cajera_name)
        Me.Controls.Add(Me.xtcaja)
        Me.Controls.Add(Me.LibXLookup4)
        Me.Controls.Add(Me.caja_name)
        Me.Controls.Add(Me.LibXLookup2)
        Me.Controls.Add(Me.mensaj_name)
        Me.Controls.Add(Me.Txt_almacen)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LibXLookup1)
        Me.Controls.Add(Me.lblwhse_name)
        Me.Controls.Add(Me.txtwhse_code)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Fecha_Fin)
        Me.Controls.Add(Me.Fecha_Ini)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "r_ptvfact03"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resumen de Domicilio"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ftdomim, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub LibXConnector1_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.XBeforeExecuteQueryEventArgs) Handles LibXConnector1.BeforeExecuteQuery
        Dim AxCrystalReport1 As LibX.ReportLib
        Try
            Dim SelecStmt As String
            Dim sFechaDesde As String
            Dim sFechaHasta As String
            Dim sCond As String
            Dim sAlmac As String
            Dim sCaja As String
            Dim sCajero As String
            Dim sMensajero As String
            Dim sWhere As String

            If Not IsNull(Fecha_Ini.Value) Then
                sFechaDesde = CDate(Fecha_Ini.Value).ToString(LibX.Data.Manager.GetSaveDateFormat)
            End If

            If Not IsNull(Fecha_Fin.Value) Then
                sFechaHasta = CDate(Fecha_Fin.Value).ToString(LibX.Data.Manager.GetSaveDateFormat)
            End If

            'e.Sql = e.Sql

            If Not IsNull(e.row!caja_code) Then
                sCaja = e.row!caja_code.ToString
            End If
            If Not IsNull(e.row!caje_code) Then
                sCajero = e.row!caje_code.ToString
            End If

            If mend_code.Text <> "" Then
                sMensajero = e.row!vend_mensaj.ToString
            Else
                sMensajero = ""
            End If

            'If Trim(mend_code.Text) <> "" Then
            '    sMensajero = mend_code.Text
            'End If

            If Me.RdBMesaje.Checked = True Then
                AxCrystalReport1 = New ReportLib("PTV", "r_pvdomic.rpt")
            End If
            If Me.RdBPendiente.Checked = True Then
                AxCrystalReport1 = New ReportLib("PTV", "r_pvdomir.rpt")
            End If
            If Me.RdBTotal.Checked = True Then
                AxCrystalReport1 = New ReportLib("PTV", "r_pvdomicant.rpt")
            End If


            With AxCrystalReport1
                sWhere = " 1=1 "
                If Me.RdBPendiente.Checked = True Then
                    If Trim(sFechaDesde) <> "" And Trim(sFechaHasta) <> "" Then
                        sWhere = String.Concat(sWhere, " and pvdomiv.fact_date between '", Trim(sFechaDesde), "' and '", Trim(sFechaHasta), "'")
                    ElseIf Trim(sFechaDesde) <> "" Then
                        sWhere = String.Concat(sWhere, " and pvdomiv.fact_date = '", Trim(sFechaDesde), "'")
                    ElseIf Trim(sFechaHasta) <> "" Then
                        sWhere = String.Concat(sWhere, " and pvdomiv.fact_date = '", Trim(sFechaHasta), "'")
                    End If

                    If e.row!whse_code.ToString.Trim <> "" Then
                        sWhere = String.Concat(sWhere, " and pvdomiv.whse_code = ", e.row!whse_code.ToString)
                    End If

                    If e.row!caja_code.ToString.Trim <> "" Then
                        sWhere = String.Concat(sWhere, " and pvdomiv.caja_code = '", e.row!caja_code.ToString & "'")
                    End If

                    If e.row!caje_code.ToString.Trim <> "" Then
                        sWhere = String.Concat(sWhere, " and pvdomiv.caje_code = '", e.row!caje_code.ToString & "'")
                    End If

                    If sMensajero.ToString.Trim <> "" Then
                        sWhere = String.Concat(sWhere, " and pvdomiv.vend_mensaj = '", sMensajero.ToString & "'")
                    End If
                    'If sMensajero.ToString.Trim <> "" Then
                    '    sWhere = String.Concat(sWhere, " and ftdomim.vend_mensaj = '", e.row!vend_mensaj.ToString & "'")
                    'End If
                Else
                    If Me.RdBMesaje.Checked = True Then
                        If Trim(sFechaDesde) <> "" And Trim(sFechaHasta) <> "" Then
                            sWhere = String.Concat(sWhere, " and pvdomivc.fact_date between '", Trim(sFechaDesde), "' and '", Trim(sFechaHasta), "'")
                        ElseIf Trim(sFechaDesde) <> "" Then
                            sWhere = String.Concat(sWhere, " and pvdomivc.fact_date = '", Trim(sFechaDesde), "'")
                        ElseIf Trim(sFechaHasta) <> "" Then
                            sWhere = String.Concat(sWhere, " and pvdomivc.fact_date = '", Trim(sFechaHasta), "'")
                        End If

                        If e.row!whse_code.ToString.Trim <> "" Then
                            sWhere = String.Concat(sWhere, " and pvdomivc.whse_code = ", e.row!whse_code.ToString)
                        End If

                        If sMensajero.ToString.Trim <> "" Then
                        End If

                        If e.row!caja_code.ToString.Trim <> "" Then
                            sWhere = String.Concat(sWhere, " and pvdomivc.caja_code = '", e.row!caja_code.ToString & "'")
                        End If

                        If e.row!caje_code.ToString.Trim <> "" Then
                            sWhere = String.Concat(sWhere, " and pvdomivc.caje_code = '", e.row!caje_code.ToString & "'")
                        End If
                    Else
                        If Me.RdBTotal.Checked = True Then
                            If Trim(sFechaDesde) <> "" And Trim(sFechaHasta) <> "" Then
                                sWhere = String.Concat(sWhere, " and pvdomivc.fact_date between '", Trim(sFechaDesde), "' and '", Trim(sFechaHasta), "'")
                            ElseIf Trim(sFechaDesde) <> "" Then
                                sWhere = String.Concat(sWhere, " and pvdomivc.fact_date = '", Trim(sFechaDesde), "'")
                            ElseIf Trim(sFechaHasta) <> "" Then
                                sWhere = String.Concat(sWhere, " and pvdomivc.fact_date = '", Trim(sFechaHasta), "'")
                            End If

                            If e.row!whse_code.ToString.Trim <> "" Then
                                sWhere = String.Concat(sWhere, " and pvdomivc.whse_code = ", e.row!whse_code.ToString)
                            End If

                            If sMensajero.ToString.Trim <> "" Then
                                sWhere = String.Concat(sWhere, " and pvdomivc.mensa_name = '", e.row!vend_mensaj.ToString & "'")
                            End If

                            If e.row!caja_code.ToString.Trim <> "" Then
                                sWhere = String.Concat(sWhere, " and pvdomivc.caja_code = '", e.row!caja_code.ToString & "'")
                            End If

                            If e.row!caje_code.ToString.Trim <> "" Then
                                sWhere = String.Concat(sWhere, " and pvdomivc.caje_code = '", e.row!caje_code.ToString & "'")
                            End If
                        End If
                    End If
                End If

                .ParameterFields(0) = String.Concat("Fecha_Ini;", Trim(sFechaDesde), ";TRUE")
                .ParameterFields(1) = String.Concat("Fecha_Fin;", Trim(sFechaHasta), ";TRUE")

                '// Recibir el SQL Query
                .RetrieveSQLQuery()
                SelecStmt = .SQLQuery
                SelecStmt = LibX.MdlUtil.ReplaceWherePart(SelecStmt, sWhere)
                'SelecStmt = oDoc.PrepareSelectStmt(SelecStmt)

                .SQLQuery = SelecStmt

                '// Ejecutar el reporte
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
    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        If Me.LibXConnector1.IsEditing Then
            Me.LibXConnector1.Cancel()
        End If
        Me.LibXConnector1.Find()
    End Sub

    Private Sub r_ftfact10_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.LibXConnector1.Find()
        oDoc = New SGT.Facturacion.Entidades.Documento

        WhDefault = System.Configuration.ConfigurationSettings.AppSettings.Get("LibxWhDefault")

    End Sub


End Class
