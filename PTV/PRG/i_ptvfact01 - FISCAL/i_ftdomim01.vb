Imports SGT.Caja.Entidades
Public Class i_ftdomim01
    Inherits System.Windows.Forms.Form
    Dim oParamValidar As SGT.Administracion.Entidades.Permission.ParametrosValidar
    Dim oAutorizar As SGT.Administracion.Entidades.Permission
    Dim oDomicilio As SGT.PuntodeVenta.Entidades.MontoFactura
    Dim oBloqueoDocumento As SGT.PuntodeVenta.Entidades.BloqueoFactua
    Dim oCajaAbierta As CajaAbierta

    Public Class Factura
        Public Serial As Integer
        Public Type As String
        Public mInitSerial As Integer
    End Class

    Dim mFactura As Factura

    Public Property FacturaSelected() As Factura
        Get
            Return mFactura
        End Get
        Set(ByVal Value As Factura)
            mFactura = Value
        End Set
    End Property
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents xcbo_caje_code As LibX.LibXCombo
    Friend WithEvents xcbo_caja_code As LibX.LibXCombo
    Friend WithEvents xcbo_vend_code As LibX.LibXCombo
    Friend WithEvents txt_fact_nota As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents btnAccept As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents LibxGrid1 As LibX.LibXGrid
    Friend WithEvents XdataGridTableStyle3 As LibX.XdataGridTableStyle
    Friend WithEvents XEditTextBoxColumn7 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn16 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn17 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn18 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn19 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn20 As LibX.XEditTextBoxColumn
    Friend WithEvents xdt_fact_date As LibX.LibxDateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents gColftserial_no As LibX.XEditTextBoxColumn
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents gColTipo As LibX.XEditTextBoxColumn
    Friend WithEvents btnAnular As System.Windows.Forms.Button
    Friend WithEvents XEditTextBoxColumn1 As LibX.XEditTextBoxColumn
    Friend WithEvents XEditTextBoxColumn2 As LibX.XEditTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(i_ftdomim01))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.xdt_fact_date = New LibX.LibxDateTimePicker
        Me.xcbo_caje_code = New LibX.LibXCombo
        Me.xcbo_caja_code = New LibX.LibXCombo
        Me.xcbo_vend_code = New LibX.LibXCombo
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt_fact_nota = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnAccept = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.LibxGrid1 = New LibX.LibXGrid
        Me.XdataGridTableStyle3 = New LibX.XdataGridTableStyle
        Me.gColTipo = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn7 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn16 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn18 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn1 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn17 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn19 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn2 = New LibX.XEditTextBoxColumn
        Me.XEditTextBoxColumn20 = New LibX.XEditTextBoxColumn
        Me.gColftserial_no = New LibX.XEditTextBoxColumn
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnAnular = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibxGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.xdt_fact_date)
        Me.GroupBox1.Controls.Add(Me.xcbo_caje_code)
        Me.GroupBox1.Controls.Add(Me.xcbo_caja_code)
        Me.GroupBox1.Controls.Add(Me.xcbo_vend_code)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_fact_nota)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(936, 72)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'xdt_fact_date
        '
        Me.xdt_fact_date.CustomFormat = "dd/MM/yyyy"
        Me.xdt_fact_date.EditInitialValue = Nothing
        Me.xdt_fact_date.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_fact_date.FieldDescription = ""
        Me.xdt_fact_date.FindInitialValue = Nothing
        Me.xdt_fact_date.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_fact_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.xdt_fact_date.IgnoreRequiered = False
        Me.xdt_fact_date.Location = New System.Drawing.Point(336, 40)
        Me.xdt_fact_date.Name = "xdt_fact_date"
        Me.xdt_fact_date.NewInitialValue = Nothing
        Me.xdt_fact_date.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xdt_fact_date.Requiered = False
        Me.xdt_fact_date.Size = New System.Drawing.Size(88, 20)
        Me.xdt_fact_date.StatusBarPanelDescripcion = Nothing
        Me.xdt_fact_date.TabIndex = 13
        '
        'xcbo_caje_code
        '
        Me.xcbo_caje_code.AllowDefaultSort = True
        Me.xcbo_caje_code.bound = True
        Me.xcbo_caje_code.currValue = Nothing
        Me.xcbo_caje_code.DefaultWhereString = "(vend_indcajera = 1)"
        Me.xcbo_caje_code.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_caje_code.EditInitialValue = Nothing
        Me.xcbo_caje_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_caje_code.FieldDescription = ""
        Me.xcbo_caje_code.FindInitialValue = Nothing
        Me.xcbo_caje_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_caje_code.IgnoreRequiered = False
        Me.xcbo_caje_code.Location = New System.Drawing.Point(536, 40)
        Me.xcbo_caje_code.LookupKeyDisplayFields = "vend_name"
        Me.xcbo_caje_code.LookupKeyField = "vend_code"
        Me.xcbo_caje_code.LookupTableName = "ftvendm"
        Me.xcbo_caje_code.Name = "xcbo_caje_code"
        Me.xcbo_caje_code.NewInitialValue = Nothing
        Me.xcbo_caje_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_caje_code.Requiered = False
        Me.xcbo_caje_code.Required = False
        Me.xcbo_caje_code.Size = New System.Drawing.Size(328, 21)
        Me.xcbo_caje_code.SqlString = Nothing
        Me.xcbo_caje_code.StatusBarPanelDescripcion = Nothing
        Me.xcbo_caje_code.TabIndex = 12
        '
        'xcbo_caja_code
        '
        Me.xcbo_caja_code.AllowDefaultSort = True
        Me.xcbo_caja_code.bound = True
        Me.xcbo_caja_code.currValue = Nothing
        Me.xcbo_caja_code.DefaultWhereString = Nothing
        Me.xcbo_caja_code.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_caja_code.EditInitialValue = Nothing
        Me.xcbo_caja_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_caja_code.FieldDescription = ""
        Me.xcbo_caja_code.FindInitialValue = Nothing
        Me.xcbo_caja_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_caja_code.IgnoreRequiered = False
        Me.xcbo_caja_code.Location = New System.Drawing.Point(536, 16)
        Me.xcbo_caja_code.LookupKeyDisplayFields = "caja_name"
        Me.xcbo_caja_code.LookupKeyField = "caja_code"
        Me.xcbo_caja_code.LookupTableName = "cjcajam"
        Me.xcbo_caja_code.Name = "xcbo_caja_code"
        Me.xcbo_caja_code.NewInitialValue = Nothing
        Me.xcbo_caja_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_caja_code.Requiered = False
        Me.xcbo_caja_code.Required = False
        Me.xcbo_caja_code.Size = New System.Drawing.Size(328, 21)
        Me.xcbo_caja_code.SqlString = Nothing
        Me.xcbo_caja_code.StatusBarPanelDescripcion = Nothing
        Me.xcbo_caja_code.TabIndex = 11
        '
        'xcbo_vend_code
        '
        Me.xcbo_vend_code.AllowDefaultSort = True
        Me.xcbo_vend_code.bound = True
        Me.xcbo_vend_code.currValue = Nothing
        Me.xcbo_vend_code.DefaultWhereString = "(vend_indcajera = 0 OR vend_indcajera is null)"
        Me.xcbo_vend_code.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_vend_code.EditInitialValue = Nothing
        Me.xcbo_vend_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_vend_code.FieldDescription = ""
        Me.xcbo_vend_code.FindInitialValue = Nothing
        Me.xcbo_vend_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_vend_code.IgnoreRequiered = False
        Me.xcbo_vend_code.Location = New System.Drawing.Point(88, 16)
        Me.xcbo_vend_code.LookupKeyDisplayFields = "vend_name"
        Me.xcbo_vend_code.LookupKeyField = "vend_code"
        Me.xcbo_vend_code.LookupTableName = "ftvendm"
        Me.xcbo_vend_code.Name = "xcbo_vend_code"
        Me.xcbo_vend_code.NewInitialValue = Nothing
        Me.xcbo_vend_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_vend_code.Requiered = False
        Me.xcbo_vend_code.Required = False
        Me.xcbo_vend_code.Size = New System.Drawing.Size(336, 21)
        Me.xcbo_vend_code.SqlString = Nothing
        Me.xcbo_vend_code.StatusBarPanelDescripcion = Nothing
        Me.xcbo_vend_code.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Location = New System.Drawing.Point(480, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 16)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Cajera:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(490, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 16)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Caja:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(25, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Numero:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(16, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Mensajero"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txt_fact_nota
        '
        Me.txt_fact_nota.Location = New System.Drawing.Point(88, 40)
        Me.txt_fact_nota.Name = "txt_fact_nota"
        Me.txt_fact_nota.Size = New System.Drawing.Size(104, 20)
        Me.txt_fact_nota.TabIndex = 0
        Me.txt_fact_nota.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(288, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Fecha:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnAccept
        '
        Me.btnAccept.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAccept.Location = New System.Drawing.Point(808, 472)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.TabIndex = 2
        Me.btnAccept.Text = "Aceptar(F5)"
        Me.ToolTip1.SetToolTip(Me.btnAccept, "Elegir el documento seleccionado")
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Location = New System.Drawing.Point(888, 472)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancelar"
        Me.ToolTip1.SetToolTip(Me.btnCancel, "Cancelar la operación y cerrar esta pantalla")
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
        Me.LibXConnector1.DataMember = "ftdomim"
        Me.LibXConnector1.EOF = False
        Me.LibXConnector1.HandledRowsFill = False
        Me.LibXConnector1.HandledUpdates = False
        Me.LibXConnector1.HasRecords = False
        Me.LibXConnector1.IsEditing = False
        Me.LibXConnector1.IsHeaderOnGrid = True
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
        Me.LibXDbSourceTable1.InnerJon = False
        Me.LibXDbSourceTable1.InsertOrder = 0
        Me.LibXDbSourceTable1.IsDetail = False
        Me.LibXDbSourceTable1.KeyFields = Nothing
        Me.LibXDbSourceTable1.LineColName = Nothing
        Me.LibXDbSourceTable1.MasterDetailRelation = Nothing
        Me.LibXDbSourceTable1.MasterTableName = Nothing
        Me.LibXDbSourceTable1.SerialColumnName = ""
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = New String() {"select ftfactm.ftserial_no,", "" & Microsoft.VisualBasic.ChrW(9) & "ftfactm.type_code,", "" & Microsoft.VisualBasic.ChrW(9) & "ftfactm.caja_code,", "" & Microsoft.VisualBasic.ChrW(9) & "ftfactm.caje_code,", "" & Microsoft.VisualBasic.ChrW(9) & "ftfactm.fact_number,", "" & Microsoft.VisualBasic.ChrW(9) & "ftfactm.fact_date,", "" & Microsoft.VisualBasic.ChrW(9) & "ftdomim.vend_mensaj,", "" & Microsoft.VisualBasic.ChrW(9) & "ftvendm.vend_name,", "" & Microsoft.VisualBasic.ChrW(9) & "ftfactm.bus_name,", "" & Microsoft.VisualBasic.ChrW(9) & "sctorcity.sector_name,", "" & Microsoft.VisualBasic.ChrW(9) & "(((isnull(ftfactm.fact_total,0)  - ", "" & Microsoft.VisualBasic.ChrW(9) & "isnull(ftfactm.descto,0)) + ", "" & Microsoft.VisualBasic.ChrW(9) & "isnull(ftfactm.itbis,0)) - ", "" & Microsoft.VisualBasic.ChrW(9) & "isnull(ftfactm.seg_amount,0)) net_amount,", "" & Microsoft.VisualBasic.ChrW(9) & "ftdomim.domi_cambio,", "case WHEN ftdomim.domi_pago = 'EFE' then 'EFECTIVO'  ", "     when ftdomim.domi_pago = 'TAR' then 'TARJETA' ", "     when ftdomim.domi_pago = 'CXC' then 'CREDITO' ", "     end 'Formapago',ftdomim.domi_date", "from ftfactm", "left join ftdomim", "on ftdomim.ftserial_no = ftfactm.ftserial_no", "and ftfactm.fact_number is not null", "and ftfactm.fact_inddomicilio = 1", "left outer join ftvendm", "on ftdomim.vend_mensaj = ftvendm.vend_code", "left outer join sctorcity", "on ftdomim.cust_code = sctorcity.cust_code", ""}
        Me.LibXDbSourceTable1.TableName = "ftdomim"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Location = New System.Drawing.Point(947, 56)
        Me.Button4.Name = "Button4"
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Refrescar"
        Me.ToolTip1.SetToolTip(Me.Button4, "Refrescar los domicilios en pantalla")
        '
        'Button5
        '
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Location = New System.Drawing.Point(947, 32)
        Me.Button5.Name = "Button5"
        Me.Button5.TabIndex = 3
        Me.Button5.Text = "Todos"
        Me.ToolTip1.SetToolTip(Me.Button5, "Visualizar los domicilios pendientes por cobrar de todas las cajas")
        '
        'Button6
        '
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button6.Location = New System.Drawing.Point(947, 8)
        Me.Button6.Name = "Button6"
        Me.Button6.TabIndex = 3
        Me.Button6.Text = "Caja"
        Me.ToolTip1.SetToolTip(Me.Button6, "Visualizar los domicilios pendientes por cobrar de esta caja")
        '
        'LibxGrid1
        '
        Me.LibxGrid1.AutoAdjustLastColumn = True
        Me.LibxGrid1.AutoSearch = False
        Me.LibxGrid1.BackgroundColor = System.Drawing.Color.White
        Me.LibxGrid1.CaptionVisible = False
        Me.LibxGrid1.DataMember = "ftdomim"
        Me.LibxGrid1.DataSource = Me.LibXConnector1
        Me.LibxGrid1.FullRowSelect = True
        Me.LibxGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LibxGrid1.IsReadOnly = False
        Me.LibxGrid1.Location = New System.Drawing.Point(0, 80)
        Me.LibxGrid1.Name = "LibxGrid1"
        Me.LibxGrid1.ReadOnly = True
        Me.LibxGrid1.searchText = ""
        Me.LibxGrid1.showFooterBar = True
        Me.LibxGrid1.Size = New System.Drawing.Size(1024, 360)
        Me.LibxGrid1.TabIndex = 0
        Me.LibxGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.XdataGridTableStyle3})
        Me.LibxGrid1.UseAutoFillLines = True
        Me.LibxGrid1.UseHandCursor = False
        '
        'XdataGridTableStyle3
        '
        Me.XdataGridTableStyle3.AlternatingBackColor = System.Drawing.SystemColors.Info
        Me.XdataGridTableStyle3.DataGrid = Me.LibxGrid1
        Me.XdataGridTableStyle3.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.gColTipo, Me.XEditTextBoxColumn7, Me.XEditTextBoxColumn16, Me.XEditTextBoxColumn18, Me.XEditTextBoxColumn1, Me.XEditTextBoxColumn17, Me.XEditTextBoxColumn19, Me.XEditTextBoxColumn2, Me.XEditTextBoxColumn20, Me.gColftserial_no})
        Me.XdataGridTableStyle3.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XdataGridTableStyle3.MappingName = "ftdomim"
        '
        'gColTipo
        '
        Me.gColTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColTipo.Format = ""
        Me.gColTipo.FormatInfo = Nothing
        Me.gColTipo.HeaderText = "Tipo"
        Me.gColTipo.ImageList = Nothing
        Me.gColTipo.isReadOnly = False
        Me.gColTipo.MappingName = "type_code"
        Me.gColTipo.MaxLength = 32767
        Me.gColTipo.TabStop = True
        Me.gColTipo.UseCustomCellFormat = False
        Me.gColTipo.Width = 30
        '
        'XEditTextBoxColumn7
        '
        Me.XEditTextBoxColumn7.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn7.Format = ""
        Me.XEditTextBoxColumn7.FormatInfo = Nothing
        Me.XEditTextBoxColumn7.HeaderText = "Número"
        Me.XEditTextBoxColumn7.ImageList = Nothing
        Me.XEditTextBoxColumn7.isReadOnly = False
        Me.XEditTextBoxColumn7.MappingName = "fact_number"
        Me.XEditTextBoxColumn7.MaxLength = 32767
        Me.XEditTextBoxColumn7.TabStop = True
        Me.XEditTextBoxColumn7.UseCustomCellFormat = False
        Me.XEditTextBoxColumn7.Width = 75
        '
        'XEditTextBoxColumn16
        '
        Me.XEditTextBoxColumn16.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn16.Format = ""
        Me.XEditTextBoxColumn16.FormatInfo = Nothing
        Me.XEditTextBoxColumn16.HeaderText = "Fecha"
        Me.XEditTextBoxColumn16.ImageList = Nothing
        Me.XEditTextBoxColumn16.isReadOnly = False
        Me.XEditTextBoxColumn16.MappingName = "fact_date"
        Me.XEditTextBoxColumn16.MaxLength = 32767
        Me.XEditTextBoxColumn16.TabStop = True
        Me.XEditTextBoxColumn16.UseCustomCellFormat = False
        Me.XEditTextBoxColumn16.Width = 75
        '
        'XEditTextBoxColumn18
        '
        Me.XEditTextBoxColumn18.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn18.Format = ""
        Me.XEditTextBoxColumn18.FormatInfo = Nothing
        Me.XEditTextBoxColumn18.HeaderText = "Cliente"
        Me.XEditTextBoxColumn18.ImageList = Nothing
        Me.XEditTextBoxColumn18.isReadOnly = False
        Me.XEditTextBoxColumn18.MappingName = "bus_name"
        Me.XEditTextBoxColumn18.MaxLength = 32767
        Me.XEditTextBoxColumn18.TabStop = True
        Me.XEditTextBoxColumn18.UseCustomCellFormat = False
        Me.XEditTextBoxColumn18.Width = 200
        '
        'XEditTextBoxColumn1
        '
        Me.XEditTextBoxColumn1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn1.Format = ""
        Me.XEditTextBoxColumn1.FormatInfo = Nothing
        Me.XEditTextBoxColumn1.HeaderText = "Sector"
        Me.XEditTextBoxColumn1.ImageList = Nothing
        Me.XEditTextBoxColumn1.isReadOnly = False
        Me.XEditTextBoxColumn1.MappingName = "sector_name"
        Me.XEditTextBoxColumn1.MaxLength = 32767
        Me.XEditTextBoxColumn1.TabStop = True
        Me.XEditTextBoxColumn1.UseCustomCellFormat = False
        Me.XEditTextBoxColumn1.Width = 145
        '
        'XEditTextBoxColumn17
        '
        Me.XEditTextBoxColumn17.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn17.Format = ""
        Me.XEditTextBoxColumn17.FormatInfo = Nothing
        Me.XEditTextBoxColumn17.HeaderText = "Mensajero"
        Me.XEditTextBoxColumn17.ImageList = Nothing
        Me.XEditTextBoxColumn17.isReadOnly = False
        Me.XEditTextBoxColumn17.MappingName = "vend_name"
        Me.XEditTextBoxColumn17.MaxLength = 32767
        Me.XEditTextBoxColumn17.TabStop = True
        Me.XEditTextBoxColumn17.UseCustomCellFormat = False
        Me.XEditTextBoxColumn17.Width = 195
        '
        'XEditTextBoxColumn19
        '
        Me.XEditTextBoxColumn19.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.XEditTextBoxColumn19.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn19.Format = "###,##0.00"
        Me.XEditTextBoxColumn19.FormatInfo = Nothing
        Me.XEditTextBoxColumn19.HeaderText = "Montoi"
        Me.XEditTextBoxColumn19.ImageList = Nothing
        Me.XEditTextBoxColumn19.isReadOnly = False
        Me.XEditTextBoxColumn19.MappingName = "net_amount"
        Me.XEditTextBoxColumn19.MaxLength = 32767
        Me.XEditTextBoxColumn19.TabStop = True
        Me.XEditTextBoxColumn19.UseCustomCellFormat = False
        Me.XEditTextBoxColumn19.Width = 95
        '
        'XEditTextBoxColumn2
        '
        Me.XEditTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.XEditTextBoxColumn2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn2.Format = ""
        Me.XEditTextBoxColumn2.FormatInfo = Nothing
        Me.XEditTextBoxColumn2.HeaderText = "Forma Pago"
        Me.XEditTextBoxColumn2.ImageList = Nothing
        Me.XEditTextBoxColumn2.isReadOnly = False
        Me.XEditTextBoxColumn2.MappingName = "Formapago"
        Me.XEditTextBoxColumn2.MaxLength = 32767
        Me.XEditTextBoxColumn2.TabStop = True
        Me.XEditTextBoxColumn2.UseCustomCellFormat = False
        Me.XEditTextBoxColumn2.Width = 75
        '
        'XEditTextBoxColumn20
        '
        Me.XEditTextBoxColumn20.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.XEditTextBoxColumn20.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.XEditTextBoxColumn20.Format = "###,##0.00"
        Me.XEditTextBoxColumn20.FormatInfo = Nothing
        Me.XEditTextBoxColumn20.HeaderText = "Cambioi"
        Me.XEditTextBoxColumn20.ImageList = Nothing
        Me.XEditTextBoxColumn20.isReadOnly = False
        Me.XEditTextBoxColumn20.MappingName = "domi_cambio"
        Me.XEditTextBoxColumn20.MaxLength = 32767
        Me.XEditTextBoxColumn20.TabStop = True
        Me.XEditTextBoxColumn20.UseCustomCellFormat = False
        Me.XEditTextBoxColumn20.Width = 90
        '
        'gColftserial_no
        '
        Me.gColftserial_no.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.gColftserial_no.Format = ""
        Me.gColftserial_no.FormatInfo = Nothing
        Me.gColftserial_no.ImageList = Nothing
        Me.gColftserial_no.isReadOnly = False
        Me.gColftserial_no.MappingName = "ftserial_no"
        Me.gColftserial_no.MaxLength = 32767
        Me.gColftserial_no.TabStop = True
        Me.gColftserial_no.UseCustomCellFormat = False
        Me.gColftserial_no.Width = 0
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'btnAnular
        '
        Me.btnAnular.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAnular.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAnular.Location = New System.Drawing.Point(8, 472)
        Me.btnAnular.Name = "btnAnular"
        Me.btnAnular.Size = New System.Drawing.Size(80, 24)
        Me.btnAnular.TabIndex = 34
        Me.btnAnular.Text = "Anular"
        Me.ToolTip1.SetToolTip(Me.btnAnular, "Anular Domicilio")
        '
        'i_ftdomim01
        '
        Me.AcceptButton = Me.btnAccept
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(1050, 502)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnAnular)
        Me.Controls.Add(Me.LibxGrid1)
        Me.Controls.Add(Me.btnAccept)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "i_ftdomim01"
        Me.Text = "Domicilios pendientes de Cobro"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibxGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub i_fthold01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim mFactura As New Factura
            oCajaAbierta = New CajaAbierta

            oParamValidar = New SGT.Administracion.Entidades.Permission.ParametrosValidar
            oAutorizar = New SGT.Administracion.Entidades.Permission
            oBloqueoDocumento = New SGT.PuntodeVenta.Entidades.BloqueoFactua

            Me.xdt_fact_date.Value = DBNull.Value

            Me.xcbo_caja_code.LoadDbItems(True)
            Me.xcbo_caje_code.LoadDbItems(True)
            Me.xcbo_vend_code.LoadDbItems(True)
            If Not LibXConnector1.Parameters Is Nothing Then
                If LibXConnector1.Parameters.Datos.Count > 0 Then
                    LibXConnector1.Find()
                    If LibXConnector1.Parameters.Datos.Contains("caja_code") Then
                        Me.xcbo_caja_code.currValue = LibXConnector1.Parameters.Datos.Item("caja_code")
                    End If

                    If LibXConnector1.Parameters.Datos.Contains("caje_code") Then
                        Me.xcbo_caje_code.currValue = LibXConnector1.Parameters.Datos.Item("caje_code")
                    End If

                    'If LibXConnector1.Parameters.Datos.Contains("vend_code") Then
                    '    Me.xcbo_vend_code.currValue = LibXConnector1.Parameters.Datos.Item("vend_code")
                    'End If
                End If
            End If

            Me.LibxGrid1.footerOperations.add("fact_number", "count(fact_number)")
            '// Ejecuta 
            LibxGrid1.getCurrentGridView.AllowNew = False
            LibxGrid1.getCurrentGridView.AllowEdit = False
            LibxGrid1.getCurrentGridView.AllowDelete = False

            LibXConnector1.AcceptFind()
            LibxGrid1.Focus()

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub


    Private Sub LibXConnector1_ExecutedAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutedAction
        Try
            If e.AcceptedAction = LibX.LibxConnectionActions.Find Then
                Me.xcbo_vend_code.Enabled = True
                Me.xcbo_caje_code.Enabled = True
                Me.xcbo_caja_code.Enabled = True
                Me.txt_fact_nota.Enabled = True
            End If

            btnAccept.Enabled = LibXConnector1.HasRecords

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub xcbo_vend_code_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xcbo_vend_code.SelectedIndexChanged
        Try
            SetFilter()
        Finally
        End Try
    End Sub

    Private Sub SetFilter()
        Dim Filter As String = "1=1"

        If Not TypeOf xcbo_vend_code.currValue Is DataRowView AndAlso _
             Not xcbo_vend_code.currValue Is DBNull.Value AndAlso _
            xcbo_vend_code.currValue > 0 Then
            Filter &= " and vend_mensaj = " & xcbo_vend_code.currValue.ToString.Trim
        End If

        If Not TypeOf Me.xcbo_caja_code.currValue Is DataRowView AndAlso _
             Not xcbo_caja_code.currValue Is DBNull.Value AndAlso _
            xcbo_caja_code.currValue > 0 Then
            Filter &= " and caja_code= " & xcbo_caja_code.currValue.ToString.Trim
        End If

        If Me.txt_fact_nota.Text.Trim <> "" Then
            Filter &= " and fact_number = '" & Me.txt_fact_nota.Text.Trim & "'"
        End If

        If LibX.IsNull(Me.xdt_fact_date.Value) = False Then
            Filter &= " and fact_date = #" & CDate(Me.xdt_fact_date.Value).ToString(LibX.Data.Manager.GetSaveDateFormat) & "#"
        End If

        If Not TypeOf Me.xcbo_caje_code.currValue Is DataRowView AndAlso _
             Not xcbo_caje_code.currValue Is DBNull.Value AndAlso _
            xcbo_caje_code.currValue > 0 Then
            Filter &= "and caje_code= " & xcbo_caje_code.currValue.ToString.Trim
        End If

        LibxGrid1.getCurrentGridView.RowFilter = Filter
    End Sub
    Private Sub RefreshGridHeader()
        '// Ejecuta 
        LibXConnector1.ExecuteFind("fact_status = 4")
        SelectRow()
        LibxGrid1.Focus()
    End Sub
    Private Sub xcbo_caje_code_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles xcbo_caje_code.SelectedIndexChanged
        Try
            SetFilter()
        Finally
        End Try
    End Sub

    Private Sub xcbo_caja_code_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles xcbo_caja_code.SelectedIndexChanged
        Try
            SetFilter()
        Finally
        End Try
    End Sub

    Private Sub txt_fact_nota_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_fact_nota.TextChanged
        SetFilter()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccept.Click
        Try

            oDomicilio = New SGT.PuntodeVenta.Entidades.MontoFactura(mFactura.Serial)
            SelectRow()
            oBloqueoDocumento.BorrarBloqueo(mFactura.Serial, mFactura.Type)
            If oDomicilio.FindDomicilio(mFactura.Serial) = False Then
                Throw New ApplicationException("Este Domicilio tiene errores y no se puede cobrar")
            End If
            Me.DialogResult = DialogResult.Yes
            Me.Close()

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub SelectRow()
        If LibxGrid1.CurrentRowIndex > -1 Then
            mFactura.Serial = Me.LibxGrid1.GetValue(LibxGrid1.CurrentRowIndex, gColftserial_no)
            mFactura.Type = Me.LibxGrid1.GetValue(LibxGrid1.CurrentRowIndex, gColTipo)
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        Me.SetFilter()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.xcbo_caja_code.currValue = -1
        Me.xcbo_caje_code.currValue = -1
        Me.xcbo_vend_code.currValue = -1
        Me.txt_fact_nota.Text = ""
        Me.xdt_fact_date.Value = DBNull.Value
        SetFilter()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        SetFilter()
    End Sub

    Private Sub LibXGrid1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LibxGrid1.DoubleClick
        Try
            oDomicilio = New SGT.PuntodeVenta.Entidades.MontoFactura(mFactura.Serial)
            SelectRow()
            oBloqueoDocumento.BorrarBloqueo(mFactura.Serial, mFactura.Type)
            If oDomicilio.FindDomicilio(mFactura.Serial) = False Then
                Throw New ApplicationException("Este Domicilio tiene errores y no se puede cobrar")
            End If
            Me.DialogResult = DialogResult.Yes
            Me.Close()

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.XBeforeExecuteQueryEventArgs) Handles LibXConnector1.BeforeExecuteQuery
        Try
            e.AditionalWhere = "ftfactm.fact_status = " & Val(SGT.PuntodeVenta.Entidades.EstatusDocumentosEnum.DomicilioPendiente).ToString   '// Domicilio

        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try
    End Sub

    Private Sub i_ftdomim01_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            oDomicilio = New SGT.PuntodeVenta.Entidades.MontoFactura(mFactura.Serial)
            If LibXConnector1.HasRecords = True Then
                If e.KeyCode = Keys.F5 Then
                    SelectRow()
                    oBloqueoDocumento.BorrarBloqueo(mFactura.Serial, mFactura.Type)
                    If oDomicilio.FindDomicilio(mFactura.Serial) = False Then
                        Throw New ApplicationException("Este Domicilio tiene errores y no se puede cobrar")
                    End If
                    Me.DialogResult = DialogResult.Yes
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibxGrid1_CellKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LibxGrid1.CellKeyPress
        Try
            If LibXConnector1.HasRecords = True Then
                oDomicilio = New SGT.PuntodeVenta.Entidades.MontoFactura(mFactura.Serial)
                If e.KeyCode = Keys.F5 Or e.KeyCode = Keys.Enter Then
                    SelectRow()
                    oBloqueoDocumento.BorrarBloqueo(mFactura.Serial, mFactura.Type)
                    If oDomicilio.FindDomicilio(mFactura.Serial) = False Then
                        Throw New ApplicationException("Este Domicilio tiene errores y no se puede cobrar")
                    End If
                    Me.DialogResult = DialogResult.Yes
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnular.Click
        Try
            oParamValidar.AccessKey = "AN"
            oAutorizar.PermisosAutorizados.Remove("AN")

            If oAutorizar.isAutorization(oParamValidar) = False Then
                Throw New ApplicationException("Autorización Invalida")
            End If
            AnularDocumento()
            RefreshGridHeader()

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub AnularDocumento()
        Dim oPost As SGT.Facturacion.Operaciones.PosteoDocumento
        Dim oParam As SGT.Facturacion.Operaciones.PosteoDocumento.Parametros
        Dim Xdelete As LibX.Data.XDeleteStmt

        Dim SelecStmt As String
        Dim WhereStmt As String
        Dim AxCrystalReport1 As LibX.ReportLib

        Try
            oPost = New SGT.Facturacion.Operaciones.PosteoDocumento
            oParam = New SGT.Facturacion.Operaciones.PosteoDocumento.Parametros

            SelectRow()
            With oParam
                .SerialNumero = mFactura.Serial
                .ApliarComision = True
                .AplicarCXC = True
                .AplicarInventario = True
                .Completo = True
                .UseTransaction = False
                .initCaja = oCajaAbierta.CajaCode
                .initCaja = oCajaAbierta.CajeraCode
                .InitSerial = oCajaAbierta.Serial
            End With

            oPost.Anular(oParam)

            AxCrystalReport1 = New LibX.ReportLib("PTV", "r_pvfact01.2.rpt")
            WhereStmt = String.Concat("ftfactm.ftserial_no = " & mFactura.Serial)

            With AxCrystalReport1
                .RetrieveSQLQuery()
                SelecStmt = .SQLQuery
                SelecStmt = LibX.MdlUtil.ReplaceWherePart(SelecStmt, WhereStmt)
                .SQLQuery = SelecStmt
                .Destination = Crystal.DestinationConstants.crptToPrinter
                .Action = 1
            End With

            LibXConnector1.ExecuteFind("ftfactm.ftserial_no = " & LibXConnector1.CurrentDataRow!ftserial_no.ToString.Trim)

            Xdelete = New LibX.Data.XDeleteStmt("ftdomim")
            Xdelete.Fields("ftserial_no") = mFactura.Serial
            Xdelete.Execute()

        Catch ex As Exception
            Throw

        End Try
    End Sub
End Class
