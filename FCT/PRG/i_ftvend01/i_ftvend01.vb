Public Class i_ftvend01
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LibXNavigator1 As LibX.LibXNavigator
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
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
    Friend WithEvents DataColumn17 As System.Data.DataColumn
    Friend WithEvents DataColumn18 As System.Data.DataColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As LibX.XTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents LibXCombo1 As LibX.LibXCombo
    Friend WithEvents LibXCombo2 As LibX.LibXCombo
    Friend WithEvents xtxt_codigo As LibX.XMaskEdit
    Friend WithEvents xtxt_Nombre As LibX.XTextBox
    Friend WithEvents xtxt_Comision As LibX.XMaskEdit
    Friend WithEvents xtxt_Descuento As LibX.XMaskEdit
    Friend WithEvents xtxt_Celular As LibX.XMaskEdit
    Friend WithEvents xtxt_Telefono As LibX.XMaskEdit
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents XTextBox1 As LibX.XTextBox
    Friend WithEvents DataColumn19 As System.Data.DataColumn
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents XTextBox2 As LibX.XTextBox
    Friend WithEvents txtxefeini As LibX.XMaskEdit
    Friend WithEvents xtxefeini As System.Windows.Forms.Label
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
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
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
        Me.DataColumn17 = New System.Data.DataColumn
        Me.DataColumn18 = New System.Data.DataColumn
        Me.DataColumn19 = New System.Data.DataColumn
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.XTextBox2 = New LibX.XTextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.XTextBox1 = New LibX.XTextBox
        Me.LibXCombo1 = New LibX.LibXCombo
        Me.xtxt_codigo = New LibX.XMaskEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.xtxt_Nombre = New LibX.XTextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.xtxt_Comision = New LibX.XMaskEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.xtxt_Descuento = New LibX.XMaskEdit
        Me.Label6 = New System.Windows.Forms.Label
        Me.TextBox6 = New LibX.XTextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.xtxt_Celular = New LibX.XMaskEdit
        Me.xtxt_Telefono = New LibX.XMaskEdit
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.LibXCombo2 = New LibX.LibXCombo
        Me.LibXNavigator1 = New LibX.LibXNavigator
        Me.txtxefeini = New LibX.XMaskEdit
        Me.xtxefeini = New System.Windows.Forms.Label
        Me.DataColumn20 = New System.Data.DataColumn
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
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
        Me.LibXConnector1.DataMember = "ftvendm"
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
        Me.LibXConnector1.UseTransactions = False
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
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20})
        Me.DataTable1.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"vend_code"}, True)})
        Me.DataTable1.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn1}
        Me.DataTable1.TableName = "ftvendm"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.AutoIncrement = True
        Me.DataColumn1.ColumnName = "vend_code"
        Me.DataColumn1.DataType = GetType(System.Int32)
        Me.DataColumn1.ReadOnly = True
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "Cedula"
        Me.DataColumn2.MaxLength = 20
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "vend_name"
        Me.DataColumn3.MaxLength = 60
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "Direccion"
        Me.DataColumn4.MaxLength = 80
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "Telefono"
        Me.DataColumn5.MaxLength = 20
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "Celular"
        Me.DataColumn6.MaxLength = 20
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "porc_comision"
        Me.DataColumn7.DataType = GetType(System.Decimal)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "vend_default"
        Me.DataColumn8.DataType = GetType(System.Int16)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "vend_indcajera"
        Me.DataColumn9.DataType = GetType(System.Int16)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "porc_descto"
        Me.DataColumn10.DataType = GetType(System.Int32)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "vend_inddescto"
        Me.DataColumn11.DataType = GetType(System.Int16)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "vend_indcostos"
        Me.DataColumn12.DataType = GetType(System.Int16)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "vend_indanular"
        Me.DataColumn13.DataType = GetType(System.Int16)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "vend_vencido"
        Me.DataColumn14.DataType = GetType(System.Int32)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "vend_indvender"
        Me.DataColumn15.DataType = GetType(System.Int32)
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "vend_indmensj"
        Me.DataColumn16.DataType = GetType(System.Int32)
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "vend_estatus"
        Me.DataColumn17.DataType = GetType(System.Int32)
        '
        'DataColumn18
        '
        Me.DataColumn18.AllowDBNull = False
        Me.DataColumn18.ColumnName = "vend_cargo"
        Me.DataColumn18.DataType = GetType(System.Int32)
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "autoriza"
        Me.DataColumn19.MaxLength = 20
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
        Me.LibXDbSourceTable1.SerialColumnName = "vend_code"
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = Nothing
        Me.LibXDbSourceTable1.TableName = "ftvendm"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtxefeini)
        Me.GroupBox1.Controls.Add(Me.xtxefeini)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.XTextBox2)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.XTextBox1)
        Me.GroupBox1.Controls.Add(Me.LibXCombo1)
        Me.GroupBox1.Controls.Add(Me.xtxt_codigo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.xtxt_Nombre)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.xtxt_Comision)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.xtxt_Descuento)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.xtxt_Celular)
        Me.GroupBox1.Controls.Add(Me.xtxt_Telefono)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.LibXCombo2)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(672, 192)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(154, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Cedula:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XTextBox2
        '
        Me.XTextBox2.AcceptsReturn = True
        Me.XTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftvendm.Cedula"))
        Me.XTextBox2.EditInitialValue = Nothing
        Me.XTextBox2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.FieldDescription = ""
        Me.XTextBox2.FindInitialValue = Nothing
        Me.XTextBox2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.IgnoreRequiered = False
        Me.XTextBox2.Location = New System.Drawing.Point(202, 16)
        Me.XTextBox2.Name = "XTextBox2"
        Me.XTextBox2.NewInitialValue = Nothing
        Me.XTextBox2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox2.Requiered = False
        Me.XTextBox2.Size = New System.Drawing.Size(136, 20)
        Me.XTextBox2.StatusBarPanelDescripcion = Nothing
        Me.XTextBox2.TabIndex = 6
        Me.XTextBox2.Text = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label11.Location = New System.Drawing.Point(344, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(27, 16)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Aut.:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XTextBox1
        '
        Me.XTextBox1.AcceptsReturn = True
        Me.XTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftvendm.autoriza"))
        Me.XTextBox1.EditInitialValue = Nothing
        Me.XTextBox1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.FieldDescription = ""
        Me.XTextBox1.FindInitialValue = Nothing
        Me.XTextBox1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.IgnoreRequiered = False
        Me.XTextBox1.Location = New System.Drawing.Point(376, 16)
        Me.XTextBox1.Name = "XTextBox1"
        Me.XTextBox1.NewInitialValue = Nothing
        Me.XTextBox1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.XTextBox1.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.XTextBox1.Requiered = False
        Me.XTextBox1.Size = New System.Drawing.Size(136, 20)
        Me.XTextBox1.StatusBarPanelDescripcion = Nothing
        Me.XTextBox1.TabIndex = 7
        Me.XTextBox1.Text = ""
        '
        'LibXCombo1
        '
        Me.LibXCombo1.AllowDefaultSort = True
        Me.LibXCombo1.bound = True
        Me.LibXCombo1.currValue = Nothing
        Me.LibXCombo1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "ftvendm.vend_cargo"))
        Me.LibXCombo1.DefaultWhereString = Nothing
        Me.LibXCombo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LibXCombo1.EditInitialValue = Nothing
        Me.LibXCombo1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.FieldDescription = ""
        Me.LibXCombo1.FindInitialValue = Nothing
        Me.LibXCombo1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.IgnoreRequiered = False
        Me.LibXCombo1.Items.AddRange(New Object() {"1-CAJERA", "2-VENDEDOR", "3-MENSAJERO", "4-SUPERVISOR"})
        Me.LibXCombo1.Location = New System.Drawing.Point(91, 136)
        Me.LibXCombo1.LookupKeyDisplayFields = Nothing
        Me.LibXCombo1.LookupKeyField = Nothing
        Me.LibXCombo1.LookupTableName = Nothing
        Me.LibXCombo1.Name = "LibXCombo1"
        Me.LibXCombo1.NewInitialValue = Nothing
        Me.LibXCombo1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo1.Requiered = False
        Me.LibXCombo1.Required = False
        Me.LibXCombo1.Size = New System.Drawing.Size(128, 21)
        Me.LibXCombo1.SqlString = Nothing
        Me.LibXCombo1.StatusBarPanelDescripcion = Nothing
        Me.LibXCombo1.TabIndex = 5
        '
        'xtxt_codigo
        '
        Me.xtxt_codigo.AcceptsReturn = True
        Me.xtxt_codigo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftvendm.vend_code"))
        Me.xtxt_codigo.EditInitialValue = Nothing
        Me.xtxt_codigo.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.xtxt_codigo.FieldDescription = ""
        Me.xtxt_codigo.FindInitialValue = Nothing
        Me.xtxt_codigo.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_codigo.IgnoreRequiered = False
        Me.xtxt_codigo.Location = New System.Drawing.Point(91, 16)
        Me.xtxt_codigo.Masked = MaskedTextBox.Mask.Decimal
        Me.xtxt_codigo.Name = "xtxt_codigo"
        Me.xtxt_codigo.NewInitialValue = Nothing
        Me.xtxt_codigo.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_codigo.Requiered = False
        Me.xtxt_codigo.Size = New System.Drawing.Size(56, 20)
        Me.xtxt_codigo.StatusBarPanelDescripcion = Nothing
        Me.xtxt_codigo.TabIndex = 0
        Me.xtxt_codigo.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(35, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_Nombre
        '
        Me.xtxt_Nombre.AcceptsReturn = True
        Me.xtxt_Nombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftvendm.vend_name"))
        Me.xtxt_Nombre.EditInitialValue = Nothing
        Me.xtxt_Nombre.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_Nombre.FieldDescription = ""
        Me.xtxt_Nombre.FindInitialValue = Nothing
        Me.xtxt_Nombre.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_Nombre.IgnoreRequiered = False
        Me.xtxt_Nombre.Location = New System.Drawing.Point(91, 40)
        Me.xtxt_Nombre.Name = "xtxt_Nombre"
        Me.xtxt_Nombre.NewInitialValue = Nothing
        Me.xtxt_Nombre.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_Nombre.Requiered = False
        Me.xtxt_Nombre.Size = New System.Drawing.Size(421, 20)
        Me.xtxt_Nombre.StatusBarPanelDescripcion = Nothing
        Me.xtxt_Nombre.TabIndex = 1
        Me.xtxt_Nombre.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(30, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombre:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_Comision
        '
        Me.xtxt_Comision.AcceptsReturn = True
        Me.xtxt_Comision.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftvendm.porc_comision"))
        Me.xtxt_Comision.EditInitialValue = Nothing
        Me.xtxt_Comision.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_Comision.FieldDescription = ""
        Me.xtxt_Comision.FindInitialValue = Nothing
        Me.xtxt_Comision.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_Comision.IgnoreRequiered = False
        Me.xtxt_Comision.Location = New System.Drawing.Point(91, 112)
        Me.xtxt_Comision.Masked = MaskedTextBox.Mask.Decimal
        Me.xtxt_Comision.Name = "xtxt_Comision"
        Me.xtxt_Comision.NewInitialValue = Nothing
        Me.xtxt_Comision.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_Comision.Requiered = False
        Me.xtxt_Comision.Size = New System.Drawing.Size(128, 20)
        Me.xtxt_Comision.StatusBarPanelDescripcion = Nothing
        Me.xtxt_Comision.TabIndex = 4
        Me.xtxt_Comision.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(-5, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "% de Comisión:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(276, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "% de Descuento:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_Descuento
        '
        Me.xtxt_Descuento.AcceptsReturn = True
        Me.xtxt_Descuento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftvendm.porc_descto"))
        Me.xtxt_Descuento.EditInitialValue = Nothing
        Me.xtxt_Descuento.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_Descuento.FieldDescription = ""
        Me.xtxt_Descuento.FindInitialValue = Nothing
        Me.xtxt_Descuento.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_Descuento.IgnoreRequiered = False
        Me.xtxt_Descuento.Location = New System.Drawing.Point(376, 112)
        Me.xtxt_Descuento.Masked = MaskedTextBox.Mask.Decimal
        Me.xtxt_Descuento.Name = "xtxt_Descuento"
        Me.xtxt_Descuento.NewInitialValue = Nothing
        Me.xtxt_Descuento.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_Descuento.Requiered = False
        Me.xtxt_Descuento.Size = New System.Drawing.Size(136, 20)
        Me.xtxt_Descuento.StatusBarPanelDescripcion = Nothing
        Me.xtxt_Descuento.TabIndex = 9
        Me.xtxt_Descuento.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(23, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Dirección:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox6
        '
        Me.TextBox6.AcceptsReturn = True
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftvendm.Direccion"))
        Me.TextBox6.EditInitialValue = Nothing
        Me.TextBox6.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox6.FieldDescription = ""
        Me.TextBox6.FindInitialValue = Nothing
        Me.TextBox6.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox6.IgnoreRequiered = False
        Me.TextBox6.Location = New System.Drawing.Point(91, 64)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.NewInitialValue = Nothing
        Me.TextBox6.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox6.Requiered = False
        Me.TextBox6.Size = New System.Drawing.Size(421, 20)
        Me.TextBox6.StatusBarPanelDescripcion = Nothing
        Me.TextBox6.TabIndex = 2
        Me.TextBox6.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Location = New System.Drawing.Point(323, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Celular:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.Location = New System.Drawing.Point(27, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 16)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Telefono:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtxt_Celular
        '
        Me.xtxt_Celular.AcceptsReturn = True
        Me.xtxt_Celular.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftvendm.Celular"))
        Me.xtxt_Celular.EditInitialValue = Nothing
        Me.xtxt_Celular.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_Celular.FieldDescription = ""
        Me.xtxt_Celular.FindInitialValue = Nothing
        Me.xtxt_Celular.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_Celular.IgnoreRequiered = False
        Me.xtxt_Celular.Location = New System.Drawing.Point(376, 88)
        Me.xtxt_Celular.Masked = MaskedTextBox.Mask.PhoneWithArea
        Me.xtxt_Celular.Name = "xtxt_Celular"
        Me.xtxt_Celular.NewInitialValue = Nothing
        Me.xtxt_Celular.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_Celular.Requiered = False
        Me.xtxt_Celular.Size = New System.Drawing.Size(136, 20)
        Me.xtxt_Celular.StatusBarPanelDescripcion = Nothing
        Me.xtxt_Celular.TabIndex = 8
        Me.xtxt_Celular.Text = ""
        '
        'xtxt_Telefono
        '
        Me.xtxt_Telefono.AcceptsReturn = True
        Me.xtxt_Telefono.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftvendm.Telefono"))
        Me.xtxt_Telefono.EditInitialValue = Nothing
        Me.xtxt_Telefono.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_Telefono.FieldDescription = ""
        Me.xtxt_Telefono.FindInitialValue = Nothing
        Me.xtxt_Telefono.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_Telefono.IgnoreRequiered = False
        Me.xtxt_Telefono.Location = New System.Drawing.Point(91, 88)
        Me.xtxt_Telefono.Masked = MaskedTextBox.Mask.PhoneWithArea
        Me.xtxt_Telefono.Name = "xtxt_Telefono"
        Me.xtxt_Telefono.NewInitialValue = Nothing
        Me.xtxt_Telefono.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_Telefono.Requiered = False
        Me.xtxt_Telefono.Size = New System.Drawing.Size(128, 20)
        Me.xtxt_Telefono.StatusBarPanelDescripcion = Nothing
        Me.xtxt_Telefono.TabIndex = 3
        Me.xtxt_Telefono.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.Location = New System.Drawing.Point(321, 136)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 16)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Estatus:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label10.Location = New System.Drawing.Point(40, 136)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 16)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Cargo:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LibXCombo2
        '
        Me.LibXCombo2.AllowDefaultSort = True
        Me.LibXCombo2.bound = True
        Me.LibXCombo2.currValue = Nothing
        Me.LibXCombo2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "ftvendm.vend_estatus"))
        Me.LibXCombo2.DefaultWhereString = Nothing
        Me.LibXCombo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LibXCombo2.EditInitialValue = Nothing
        Me.LibXCombo2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo2.FieldDescription = ""
        Me.LibXCombo2.FindInitialValue = Nothing
        Me.LibXCombo2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo2.IgnoreRequiered = False
        Me.LibXCombo2.Items.AddRange(New Object() {"1-ACTIVO", "0-INACTIVO"})
        Me.LibXCombo2.Location = New System.Drawing.Point(376, 136)
        Me.LibXCombo2.LookupKeyDisplayFields = Nothing
        Me.LibXCombo2.LookupKeyField = Nothing
        Me.LibXCombo2.LookupTableName = Nothing
        Me.LibXCombo2.Name = "LibXCombo2"
        Me.LibXCombo2.NewInitialValue = Nothing
        Me.LibXCombo2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibXCombo2.Requiered = False
        Me.LibXCombo2.Required = False
        Me.LibXCombo2.Size = New System.Drawing.Size(136, 21)
        Me.LibXCombo2.SqlString = Nothing
        Me.LibXCombo2.StatusBarPanelDescripcion = Nothing
        Me.LibXCombo2.TabIndex = 10
        '
        'LibXNavigator1
        '
        Me.LibXNavigator1.BuildMenu = True
        Me.LibXNavigator1.Connector = Me.LibXConnector1
        Me.LibXNavigator1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LibXNavigator1.FirstControlInEditMode = Me.xtxt_Nombre
        Me.LibXNavigator1.FirstControlInFindMode = Nothing
        Me.LibXNavigator1.FirstControlInNewMode = Nothing
        Me.LibXNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.LibXNavigator1.Name = "LibXNavigator1"
        Me.LibXNavigator1.Size = New System.Drawing.Size(690, 24)
        Me.LibXNavigator1.TabIndex = 0
        '
        'txtxefeini
        '
        Me.txtxefeini.AcceptsReturn = True
        Me.txtxefeini.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "ftvendm.efe_ini"))
        Me.txtxefeini.EditInitialValue = Nothing
        Me.txtxefeini.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtxefeini.FieldDescription = ""
        Me.txtxefeini.FindInitialValue = Nothing
        Me.txtxefeini.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtxefeini.IgnoreRequiered = False
        Me.txtxefeini.Location = New System.Drawing.Point(91, 160)
        Me.txtxefeini.Masked = MaskedTextBox.Mask.Decimal
        Me.txtxefeini.Name = "txtxefeini"
        Me.txtxefeini.NewInitialValue = Nothing
        Me.txtxefeini.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtxefeini.Requiered = False
        Me.txtxefeini.Size = New System.Drawing.Size(128, 20)
        Me.txtxefeini.StatusBarPanelDescripcion = Nothing
        Me.txtxefeini.TabIndex = 14
        Me.txtxefeini.Text = ""
        Me.txtxefeini.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtxefeini.Visible = False
        '
        'xtxefeini
        '
        Me.xtxefeini.AutoSize = True
        Me.xtxefeini.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.xtxefeini.Location = New System.Drawing.Point(8, 160)
        Me.xtxefeini.Name = "xtxefeini"
        Me.xtxefeini.Size = New System.Drawing.Size(74, 16)
        Me.xtxefeini.TabIndex = 13
        Me.xtxefeini.Text = "Efetivo Inicial:"
        Me.xtxefeini.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.xtxefeini.Visible = False
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "efe_ini"
        Me.DataColumn20.DataType = GetType(System.Decimal)
        '
        'i_ftvend01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(690, 256)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "i_ftvend01"
        Me.Text = "Mantenimiento de Personal"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub LibXCombo1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LibXCombo1.SelectedIndexChanged
        If LibXConnector1.IsDataEditing = True Then
            If Me.LibXCombo1.SelectedValue = 1 Then
                Me.txtxefeini.Visible = True
                Me.xtxefeini.Visible = True

            End If
        End If

    End Sub
    Private Sub LibXConnector1_ChangeState(ByVal sender As Object, ByVal e As LibX.XChangeStateEventArgs) Handles LibXConnector1.ChangeState
        Try
            If (LibXConnector1.HasRecords) = True Then
                If LibXConnector1.CurrentDataRow!vend_cargo = 1 Then
                    Me.xtxefeini.Visible = True
                    Me.txtxefeini.Visible = True
                Else
                    Me.xtxefeini.Visible = False
                    Me.txtxefeini.Visible = False
                End If
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub LibXCombo1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LibXCombo1.TextChanged
        If (LibXConnector1.HasRecords) = True Then
            If Me.LibXCombo1.SelectedValue = 1 Then
                Me.txtxefeini.Visible = True
                Me.xtxefeini.Visible = True
            Else
                Me.xtxefeini.Visible = False
                Me.txtxefeini.Visible = False
            End If
        End If
    End Sub
End Class
