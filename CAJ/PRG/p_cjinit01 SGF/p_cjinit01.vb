Imports SGT.Caja.Entidades
Imports SGT.Inventario.Entidades
Imports SGT.PuntodeVenta.Entidades
Imports SGT.Administracion.Entidades

Public Class p_cjinit01
    Inherits System.Windows.Forms.Form
    Dim mPrint As Boolean
    Dim nCfunico As Boolean
    Dim WhDefault As Integer
    Dim ScDefault As Integer
    Dim mCaja As String
    Dim oProgram As SGT.Administracion.Entidades.Program
    Dim mMachine As SGT.Administracion.Entidades.Program.Autentication

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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents LibXLookup1 As LibX.LibXLookup
    Friend WithEvents LibXLookup2 As LibX.LibXLookup
    Friend WithEvents caja_name As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LibxDateTimePicker2 As LibX.LibxDateTimePicker
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents vend_name As System.Windows.Forms.TextBox
    Friend WithEvents vend_code1 As System.Windows.Forms.TextBox
    Friend WithEvents LibXShortNavigator1 As LibX.LibXShortNavigator
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtcaja_code As LibX.XTextBox
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents LibXDbSourceTable3 As LibX.LibXDbSourceTable
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents xcob_init_status As LibX.LibXCombo
    Friend WithEvents DataTable2 As System.Data.DataTable
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents xlk_init_serial As LibX.LibXLookup
    Friend WithEvents btndesglo As System.Windows.Forms.Button
    Friend WithEvents LibxDateTimePicker1 As LibX.LibxDateTimePicker
    Friend WithEvents cjcierrm As System.Data.DataTable
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents DataColumn17 As System.Data.DataColumn
    Friend WithEvents DataColumn18 As System.Data.DataColumn
    Friend WithEvents DataColumn19 As System.Data.DataColumn
    Friend WithEvents txtcierre As LibX.XMaskEdit
    Friend WithEvents DataColumn20 As System.Data.DataColumn
    Friend WithEvents DataColumn21 As System.Data.DataColumn
    Friend WithEvents succode As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.succode = New System.Windows.Forms.TextBox
        Me.DataSet1 = New System.Data.DataSet
        Me.DataTable1 = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn7 = New System.Data.DataColumn
        Me.DataColumn19 = New System.Data.DataColumn
        Me.DataColumn20 = New System.Data.DataColumn
        Me.DataColumn21 = New System.Data.DataColumn
        Me.DataTable2 = New System.Data.DataTable
        Me.DataColumn8 = New System.Data.DataColumn
        Me.DataColumn9 = New System.Data.DataColumn
        Me.DataColumn10 = New System.Data.DataColumn
        Me.DataColumn11 = New System.Data.DataColumn
        Me.DataColumn12 = New System.Data.DataColumn
        Me.DataColumn13 = New System.Data.DataColumn
        Me.cjcierrm = New System.Data.DataTable
        Me.DataColumn14 = New System.Data.DataColumn
        Me.DataColumn15 = New System.Data.DataColumn
        Me.DataColumn16 = New System.Data.DataColumn
        Me.DataColumn17 = New System.Data.DataColumn
        Me.DataColumn18 = New System.Data.DataColumn
        Me.xlk_init_serial = New LibX.LibXLookup
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.LibXDbSourceTable3 = New LibX.LibXDbSourceTable
        Me.xcob_init_status = New LibX.LibXCombo
        Me.txtcierre = New LibX.XMaskEdit
        Me.LibxDateTimePicker1 = New LibX.LibxDateTimePicker
        Me.LibXLookup1 = New LibX.LibXLookup
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtcaja_code = New LibX.XTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.caja_name = New System.Windows.Forms.TextBox
        Me.vend_code1 = New System.Windows.Forms.TextBox
        Me.vend_name = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.LibXLookup2 = New LibX.LibXLookup
        Me.Label5 = New System.Windows.Forms.Label
        Me.LibxDateTimePicker2 = New LibX.LibxDateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.LibXShortNavigator1 = New LibX.LibXShortNavigator
        Me.btndesglo = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cjcierrm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.succode)
        Me.GroupBox1.Controls.Add(Me.xlk_init_serial)
        Me.GroupBox1.Controls.Add(Me.xcob_init_status)
        Me.GroupBox1.Controls.Add(Me.txtcierre)
        Me.GroupBox1.Controls.Add(Me.LibxDateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.LibXLookup1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtcaja_code)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.caja_name)
        Me.GroupBox1.Controls.Add(Me.vend_code1)
        Me.GroupBox1.Controls.Add(Me.vend_name)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.LibXLookup2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.LibxDateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(440, 168)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'succode
        '
        Me.succode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cjinitm.suc_code"))
        Me.succode.Location = New System.Drawing.Point(416, 16)
        Me.succode.Name = "succode"
        Me.succode.ReadOnly = True
        Me.succode.Size = New System.Drawing.Size(8, 20)
        Me.succode.TabIndex = 8
        Me.succode.Text = ""
        '
        'DataSet1
        '
        Me.LibXConnector1.SetDataGenerator(Me.DataSet1, Me.LibXConnector1)
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, True)
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1, Me.DataTable2, Me.cjcierrm})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21})
        Me.DataTable1.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"init_serial"}, True)})
        Me.DataTable1.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn1}
        Me.DataTable1.TableName = "cjinitm"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.AutoIncrement = True
        Me.DataColumn1.ColumnName = "init_serial"
        Me.DataColumn1.DataType = GetType(System.Int32)
        Me.DataColumn1.ReadOnly = True
        '
        'DataColumn2
        '
        Me.DataColumn2.AllowDBNull = False
        Me.DataColumn2.ColumnName = "vend_code"
        Me.DataColumn2.DataType = GetType(System.Int32)
        '
        'DataColumn3
        '
        Me.DataColumn3.AllowDBNull = False
        Me.DataColumn3.ColumnName = "caja_code"
        Me.DataColumn3.DataType = GetType(System.Int32)
        '
        'DataColumn4
        '
        Me.DataColumn4.AllowDBNull = False
        Me.DataColumn4.ColumnName = "init_date"
        Me.DataColumn4.DataType = GetType(System.DateTime)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "cash_amount"
        Me.DataColumn5.DataType = GetType(System.Decimal)
        '
        'DataColumn6
        '
        Me.DataColumn6.AllowDBNull = False
        Me.DataColumn6.ColumnName = "init_status"
        Me.DataColumn6.DataType = GetType(System.Int32)
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "close_date"
        Me.DataColumn7.DataType = GetType(System.DateTime)
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "no_cierre"
        Me.DataColumn19.DataType = GetType(System.Int32)
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "ncf"
        Me.DataColumn20.MaxLength = 19
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "suc_code"
        Me.DataColumn21.DataType = GetType(System.Int32)
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13})
        Me.DataTable2.TableName = "cjinitd"
        '
        'DataColumn8
        '
        Me.DataColumn8.AllowDBNull = False
        Me.DataColumn8.ColumnName = "init_serial"
        Me.DataColumn8.DataType = GetType(System.Int32)
        '
        'DataColumn9
        '
        Me.DataColumn9.AllowDBNull = False
        Me.DataColumn9.ColumnName = "mon_code"
        Me.DataColumn9.MaxLength = 3
        '
        'DataColumn10
        '
        Me.DataColumn10.AllowDBNull = False
        Me.DataColumn10.ColumnName = "mon_name"
        Me.DataColumn10.MaxLength = 50
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "qty"
        Me.DataColumn11.DataType = GetType(System.Int32)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "Valor"
        Me.DataColumn12.DataType = GetType(System.Decimal)
        Me.DataColumn12.Expression = "isnull(qty,0)*isnull(mon_denominacion,0)"
        Me.DataColumn12.ReadOnly = True
        '
        'DataColumn13
        '
        Me.DataColumn13.AllowDBNull = False
        Me.DataColumn13.ColumnName = "mon_denominacion"
        Me.DataColumn13.DataType = GetType(System.Decimal)
        '
        'cjcierrm
        '
        Me.cjcierrm.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18})
        Me.cjcierrm.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"init_serial", "type_code", "pay_method"}, True)})
        Me.cjcierrm.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn14, Me.DataColumn15, Me.DataColumn16}
        Me.cjcierrm.TableName = "cjcierrm"
        '
        'DataColumn14
        '
        Me.DataColumn14.AllowDBNull = False
        Me.DataColumn14.ColumnName = "init_serial"
        Me.DataColumn14.DataType = GetType(System.Int32)
        '
        'DataColumn15
        '
        Me.DataColumn15.AllowDBNull = False
        Me.DataColumn15.ColumnName = "type_code"
        Me.DataColumn15.MaxLength = 3
        '
        'DataColumn16
        '
        Me.DataColumn16.AllowDBNull = False
        Me.DataColumn16.ColumnName = "pay_method"
        Me.DataColumn16.MaxLength = 3
        '
        'DataColumn17
        '
        Me.DataColumn17.AllowDBNull = False
        Me.DataColumn17.ColumnName = "amount"
        Me.DataColumn17.DataType = GetType(System.Decimal)
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "qty"
        Me.DataColumn18.DataType = GetType(System.Int32)
        '
        'xlk_init_serial
        '
        Me.xlk_init_serial.AlternateFieldSearch = Nothing
        Me.xlk_init_serial.BeginCheck = False
        Me.xlk_init_serial.CheckText = Nothing
        Me.xlk_init_serial.ComboMode = False
        Me.xlk_init_serial.DataMember = Nothing
        Me.xlk_init_serial.DataSource = Me.LibXConnector1
        Me.xlk_init_serial.DestParameters = New String() {"init_serial=init_serial", "caja_code=caja_code", "vend_code=vend_code", "init_date=init_date", "no_cierre=no_cierre"}
        Me.xlk_init_serial.FilterField = Nothing
        Me.xlk_init_serial.IgnoreFindInBrowseMode = True
        Me.xlk_init_serial.isCanceled = False
        Me.xlk_init_serial.Location = New System.Drawing.Point(168, 16)
        Me.xlk_init_serial.LookCaption = "Cajas Abiertas"
        Me.xlk_init_serial.Name = "xlk_init_serial"
        Me.xlk_init_serial.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_init_serial.ShowFilter = True
        Me.xlk_init_serial.ShowMessageNotFound = True
        Me.xlk_init_serial.ShowWarning = False
        Me.xlk_init_serial.Size = New System.Drawing.Size(16, 20)
        Me.xlk_init_serial.SizesColumns = New String() {"caja_name=250", "vend_name=250"}
        Me.xlk_init_serial.SizesColumnsTab = Nothing
        Me.xlk_init_serial.SqlString = New String() {"select init_serial,cjcajam.no_cierre,init_date,ftvendm.vend_code,cjcajam.caja_cod" & _
        "e,vend_name,", "caja_name from cjinitm", "inner join cjcajam", "on cjinitm.caja_code = cjcajam.caja_code", "inner join ftvendm", "on cjinitm.vend_code = ftvendm.vend_code"}
        Me.xlk_init_serial.SQLTab = Nothing
        Me.xlk_init_serial.SrcParameters = New String() {"init_serial=init_serial"}
        Me.xlk_init_serial.TabIndex = 7
        Me.xlk_init_serial.TableName = "cjinitm"
        Me.xlk_init_serial.TabStop = False
        Me.xlk_init_serial.UseCopyConnection = False
        Me.xlk_init_serial.UseRowRetrieveEvents = False
        Me.xlk_init_serial.UseTab = False
        Me.xlk_init_serial.VisParameters = New String() {"Fecha Apertura=Init_date", "Caja=caja_name", "Cajera=vend_name"}
        Me.xlk_init_serial.WhereCondition = "init_status = 1"
        Me.xlk_init_serial.WhereParameters = Nothing
        '
        'LibXConnector1
        '
        Me.LibXConnector1.AllowDelete = False
        Me.LibXConnector1.AllowEdit = True
        Me.LibXConnector1.AllowNew = False
        Me.LibXConnector1.AllowPrint = True
        Me.LibXConnector1.AllowQuery = True
        Me.LibXConnector1.BOF = False
        Me.LibXConnector1.CanExecuteFind = True
        Me.LibXConnector1.DataMember = "cjinitm"
        Me.LibXConnector1.DataSource = Me.DataSet1
        Me.LibXConnector1.EOF = False
        Me.LibXConnector1.HandledRowsFill = False
        Me.LibXConnector1.HandledUpdates = False
        Me.LibXConnector1.HasRecords = False
        Me.LibXConnector1.IsEditing = False
        Me.LibXConnector1.IsHeaderOnGrid = False
        Me.LibXConnector1.ModuleName = "CAJ"
        Me.LibXConnector1.OwnerForm = Me
        Me.LibXConnector1.Parameters = Nothing
        Me.LibXConnector1.RecordCount = 0
        Me.LibXConnector1.ReportMode = False
        Me.LibXConnector1.ReportName = "r_cjinit01.rpt"
        Me.LibXConnector1.RequeryData = False
        Me.LibXConnector1.ShowWarningCancel = True
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.LibXDbSourceTable1, Me.LibXDbSourceTable3})
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
        Me.LibXDbSourceTable1.KeyFields = "init_serial"
        Me.LibXDbSourceTable1.LineColName = Nothing
        Me.LibXDbSourceTable1.MasterDetailRelation = Nothing
        Me.LibXDbSourceTable1.MasterTableName = Nothing
        Me.LibXDbSourceTable1.SerialColumnName = "init_serial"
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = Nothing
        Me.LibXDbSourceTable1.TableName = "cjinitm"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
        '
        'LibXDbSourceTable3
        '
        Me.LibXDbSourceTable3.AllowDelete = True
        Me.LibXDbSourceTable3.AllowEdit = True
        Me.LibXDbSourceTable3.AllowNew = True
        Me.LibXDbSourceTable3.AutoIncrementSerial = False
        Me.LibXDbSourceTable3.CustomDbUpdate = False
        Me.LibXDbSourceTable3.DeleteOrder = 0
        Me.LibXDbSourceTable3.FillOnQuery = True
        Me.LibXDbSourceTable3.FillOnRowChange = False
        Me.LibXDbSourceTable3.HeaderIsOnGrid = False
        Me.LibXDbSourceTable3.InnerJon = True
        Me.LibXDbSourceTable3.InsertOrder = 0
        Me.LibXDbSourceTable3.IsDetail = False
        Me.LibXDbSourceTable3.KeyFields = Nothing
        Me.LibXDbSourceTable3.LineColName = Nothing
        Me.LibXDbSourceTable3.MasterDetailRelation = Nothing
        Me.LibXDbSourceTable3.MasterTableName = Nothing
        Me.LibXDbSourceTable3.SerialColumnName = Nothing
        Me.LibXDbSourceTable3.Sort = Nothing
        Me.LibXDbSourceTable3.Source = Nothing
        Me.LibXDbSourceTable3.TableName = "cjcierrm"
        Me.LibXDbSourceTable3.UpdateOrder = 0
        Me.LibXDbSourceTable3.UseRowRetrieve = False
        '
        'xcob_init_status
        '
        Me.xcob_init_status.AllowDefaultSort = True
        Me.xcob_init_status.bound = True
        Me.xcob_init_status.currValue = Nothing
        Me.xcob_init_status.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet1, "cjinitm.init_status"))
        Me.xcob_init_status.DefaultWhereString = Nothing
        Me.xcob_init_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcob_init_status.EditInitialValue = Nothing
        Me.xcob_init_status.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcob_init_status.FieldDescription = ""
        Me.xcob_init_status.FindInitialValue = Nothing
        Me.xcob_init_status.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcob_init_status.IgnoreRequiered = False
        Me.xcob_init_status.Items.AddRange(New Object() {"2-Cerrada", "1-Abierta", "3-Pendiente Cierre"})
        Me.xcob_init_status.Location = New System.Drawing.Point(80, 112)
        Me.xcob_init_status.LookupKeyDisplayFields = Nothing
        Me.xcob_init_status.LookupKeyField = Nothing
        Me.xcob_init_status.LookupTableName = Nothing
        Me.xcob_init_status.Name = "xcob_init_status"
        Me.xcob_init_status.NewInitialValue = "1"
        Me.xcob_init_status.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcob_init_status.Requiered = False
        Me.xcob_init_status.Required = False
        Me.xcob_init_status.Size = New System.Drawing.Size(136, 21)
        Me.xcob_init_status.SqlString = Nothing
        Me.xcob_init_status.StatusBarPanelDescripcion = Nothing
        Me.xcob_init_status.TabIndex = 5
        '
        'txtcierre
        '
        Me.txtcierre.AcceptsReturn = True
        Me.txtcierre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cjinitm.no_cierre"))
        Me.txtcierre.EditInitialValue = Nothing
        Me.txtcierre.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtcierre.FieldDescription = ""
        Me.txtcierre.FindInitialValue = Nothing
        Me.txtcierre.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtcierre.IgnoreRequiered = False
        Me.txtcierre.Location = New System.Drawing.Point(80, 16)
        Me.txtcierre.Masked = MaskedTextBox.Mask.None
        Me.txtcierre.Name = "txtcierre"
        Me.txtcierre.NewInitialValue = Nothing
        Me.txtcierre.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtcierre.Requiered = False
        Me.txtcierre.Size = New System.Drawing.Size(88, 20)
        Me.txtcierre.StatusBarPanelDescripcion = Nothing
        Me.txtcierre.TabIndex = 0
        Me.txtcierre.Text = ""
        '
        'LibxDateTimePicker1
        '
        Me.LibxDateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.LibxDateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "cjinitm.init_date"))
        Me.LibxDateTimePicker1.EditInitialValue = Nothing
        Me.LibxDateTimePicker1.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.LibxDateTimePicker1.Enabled = False
        Me.LibxDateTimePicker1.FieldDescription = ""
        Me.LibxDateTimePicker1.FindInitialValue = Nothing
        Me.LibxDateTimePicker1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.LibxDateTimePicker1.IgnoreRequiered = False
        Me.LibxDateTimePicker1.Location = New System.Drawing.Point(80, 40)
        Me.LibxDateTimePicker1.Name = "LibxDateTimePicker1"
        Me.LibxDateTimePicker1.NewInitialValue = Nothing
        Me.LibxDateTimePicker1.NewState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.LibxDateTimePicker1.Requiered = False
        Me.LibxDateTimePicker1.Size = New System.Drawing.Size(104, 20)
        Me.LibxDateTimePicker1.StatusBarPanelDescripcion = Nothing
        Me.LibxDateTimePicker1.TabIndex = 1
        '
        'LibXLookup1
        '
        Me.LibXLookup1.AlternateFieldSearch = Nothing
        Me.LibXLookup1.BeginCheck = False
        Me.LibXLookup1.CheckText = Nothing
        Me.LibXLookup1.ComboMode = False
        Me.LibXLookup1.DataMember = Nothing
        Me.LibXLookup1.DataSource = Me.LibXConnector1
        Me.LibXLookup1.DestParameters = New String() {"caja_code=caja_code", "caja_name=caja_name"}
        Me.LibXLookup1.FilterField = Nothing
        Me.LibXLookup1.IgnoreFindInBrowseMode = False
        Me.LibXLookup1.isCanceled = False
        Me.LibXLookup1.Location = New System.Drawing.Point(408, 64)
        Me.LibXLookup1.LookCaption = "Cajas"
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
        Me.LibXLookup1.SrcParameters = New String() {"caja_code=caja_code"}
        Me.LibXLookup1.TabIndex = 4
        Me.LibXLookup1.TableName = "cjcajam"
        Me.LibXLookup1.TabStop = False
        Me.LibXLookup1.UseCopyConnection = False
        Me.LibXLookup1.UseRowRetrieveEvents = False
        Me.LibXLookup1.UseTab = False
        Me.LibXLookup1.VisParameters = New String() {"Código=caja_code", "Nombre=caja_name"}
        Me.LibXLookup1.WhereCondition = Nothing
        Me.LibXLookup1.WhereParameters = Nothing
        '
        'Label4
        '
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(240, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Efectivo Inicial:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtcaja_code
        '
        Me.txtcaja_code.AcceptsReturn = True
        Me.txtcaja_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cjinitm.caja_code"))
        Me.txtcaja_code.EditInitialValue = Nothing
        Me.txtcaja_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtcaja_code.FieldDescription = ""
        Me.txtcaja_code.FindInitialValue = Nothing
        Me.txtcaja_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtcaja_code.IgnoreRequiered = False
        Me.txtcaja_code.Location = New System.Drawing.Point(80, 64)
        Me.txtcaja_code.Name = "txtcaja_code"
        Me.txtcaja_code.NewInitialValue = Nothing
        Me.txtcaja_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtcaja_code.Requiered = False
        Me.txtcaja_code.Size = New System.Drawing.Size(56, 20)
        Me.txtcaja_code.StatusBarPanelDescripcion = Nothing
        Me.txtcaja_code.TabIndex = 3
        Me.txtcaja_code.TabStop = False
        Me.txtcaja_code.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(39, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Caja:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'caja_name
        '
        Me.caja_name.Location = New System.Drawing.Point(144, 64)
        Me.caja_name.Name = "caja_name"
        Me.caja_name.ReadOnly = True
        Me.caja_name.Size = New System.Drawing.Size(264, 20)
        Me.caja_name.TabIndex = 1
        Me.caja_name.Text = ""
        '
        'vend_code1
        '
        Me.vend_code1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cjinitm.vend_code"))
        Me.vend_code1.Location = New System.Drawing.Point(80, 88)
        Me.vend_code1.Name = "vend_code1"
        Me.vend_code1.Size = New System.Drawing.Size(56, 20)
        Me.vend_code1.TabIndex = 4
        Me.vend_code1.Text = ""
        '
        'vend_name
        '
        Me.vend_name.Location = New System.Drawing.Point(144, 88)
        Me.vend_name.Name = "vend_name"
        Me.vend_name.ReadOnly = True
        Me.vend_name.Size = New System.Drawing.Size(264, 20)
        Me.vend_name.TabIndex = 1
        Me.vend_name.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(29, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Cajera:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(272, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Cierre:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cjinitm.cash_amount"))
        Me.TextBox5.Location = New System.Drawing.Point(320, 40)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(104, 20)
        Me.TextBox5.TabIndex = 2
        Me.TextBox5.Text = ""
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LibXLookup2
        '
        Me.LibXLookup2.AlternateFieldSearch = Nothing
        Me.LibXLookup2.BeginCheck = False
        Me.LibXLookup2.CheckText = Nothing
        Me.LibXLookup2.ComboMode = False
        Me.LibXLookup2.DataMember = Nothing
        Me.LibXLookup2.DataSource = Me.LibXConnector1
        Me.LibXLookup2.DestParameters = New String() {"vend_code=vend_code", "vend_name=vend_name"}
        Me.LibXLookup2.FilterField = Nothing
        Me.LibXLookup2.IgnoreFindInBrowseMode = False
        Me.LibXLookup2.isCanceled = False
        Me.LibXLookup2.Location = New System.Drawing.Point(408, 88)
        Me.LibXLookup2.LookCaption = "Cajeras"
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
        Me.LibXLookup2.SrcParameters = New String() {"vend_code=vend_code"}
        Me.LibXLookup2.TabIndex = 4
        Me.LibXLookup2.TableName = "ftvendm"
        Me.LibXLookup2.TabStop = False
        Me.LibXLookup2.UseCopyConnection = False
        Me.LibXLookup2.UseRowRetrieveEvents = False
        Me.LibXLookup2.UseTab = False
        Me.LibXLookup2.VisParameters = New String() {"Código=vend_code", "Nombre=vend_name"}
        Me.LibXLookup2.WhereCondition = ""
        Me.LibXLookup2.WhereParameters = Nothing
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(19, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Apertura:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LibxDateTimePicker2
        '
        Me.LibxDateTimePicker2.CustomFormat = "dd/MM/yyyy"
        Me.LibxDateTimePicker2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSet1, "cjinitm.close_date"))
        Me.LibxDateTimePicker2.EditInitialValue = Nothing
        Me.LibxDateTimePicker2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxDateTimePicker2.FieldDescription = ""
        Me.LibxDateTimePicker2.FindInitialValue = Nothing
        Me.LibxDateTimePicker2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxDateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.LibxDateTimePicker2.IgnoreRequiered = False
        Me.LibxDateTimePicker2.Location = New System.Drawing.Point(320, 112)
        Me.LibxDateTimePicker2.Name = "LibxDateTimePicker2"
        Me.LibxDateTimePicker2.NewInitialValue = Nothing
        Me.LibxDateTimePicker2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.LibxDateTimePicker2.Requiered = False
        Me.LibxDateTimePicker2.Size = New System.Drawing.Size(104, 20)
        Me.LibxDateTimePicker2.StatusBarPanelDescripcion = Nothing
        Me.LibxDateTimePicker2.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(8, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Cuadre No."
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Location = New System.Drawing.Point(24, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Estatus:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnCerrar
        '
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCerrar.Location = New System.Drawing.Point(360, 208)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(88, 40)
        Me.btnCerrar.TabIndex = 2
        Me.btnCerrar.Text = "Aplicar Cierre"
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
        Me.LibXShortNavigator1.Size = New System.Drawing.Size(458, 24)
        Me.LibXShortNavigator1.TabIndex = 0
        '
        'btndesglo
        '
        Me.btndesglo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btndesglo.Location = New System.Drawing.Point(264, 208)
        Me.btndesglo.Name = "btndesglo"
        Me.btndesglo.Size = New System.Drawing.Size(88, 40)
        Me.btndesglo.TabIndex = 3
        Me.btndesglo.Text = "Desglose"
        '
        'p_cjinit01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(458, 280)
        Me.Controls.Add(Me.btndesglo)
        Me.Controls.Add(Me.LibXShortNavigator1)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "p_cjinit01"
        Me.Text = "Cierre de Caja"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cjcierrm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub p_cjcaja01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim prueba As String
        ' LibXConnector1.AddNew()
        Try
            'LibXGrid1.footerOperations.add("VALOR", "Sum(valor)")

            'LibXGrid1.getCurrentGridView.AllowNew = False
            'LibXGrid1.getCurrentGridView.AllowDelete = False
            'LibXConnector1.Find()
            oProgram = New SGT.Administracion.Entidades.Program
            mMachine = New SGT.Administracion.Entidades.Program.Autentication

            mMachine.Machine = System.Environment.MachineName
            'prueba = System.Environment.SystemDirectory

            If oProgram.BuildAutentication(mMachine) = False Then
                If MessageBox.Show("ESTE PROGRAMA ESTA PROTEGIDO CONTRA" & _
                                    vbCrLf & "COPIA NO AUTORIZADA, NECESITA" & _
                                    vbCrLf & "LA INTERVENSION DEL AUTOR, REDSOFT, S. A." & _
                                    vbCrLf & "TEL. 809-540-0547.", _
                                    "Copia no autorizada", _
                                    MessageBoxButtons.OK, MessageBoxIcon.Question) = DialogResult.OK Then
                    Me.Close()
                End If
            End If

            If System.Configuration.ConfigurationSettings.AppSettings.Get("LibxCaja") <> String.Empty Then
                mCaja = System.Configuration.ConfigurationSettings.AppSettings.Get("LibxCaja").ToString.Trim
            End If
            If System.Configuration.ConfigurationSettings.AppSettings.Get("LibxPrintDirect") <> String.Empty Then
                mPrint = Boolean.Parse(System.Configuration.ConfigurationSettings.AppSettings.Get("LibxPrintDirect"))
            End If
            If System.Configuration.ConfigurationSettings.AppSettings.Get("LibxNcfunico") <> String.Empty Then
                nCfunico = Boolean.Parse(System.Configuration.ConfigurationSettings.AppSettings.Get("LibxNcfunico"))
            End If
            WhDefault = Val(Configuration.ConfigurationSettings.AppSettings.Get("LibXWhDefault").ToString)
            ScDefault = Val(Configuration.ConfigurationSettings.AppSettings.Get("LibxScDefault").ToString)

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub FillGrid()
        Dim SelectStmt As String
        Dim oTAble As DataTable
        Dim oRows() As DataRow
        Dim NewRow As DataRow
        Try

            SelectStmt = "select * from stmoneda order by mon_denominacion DESC "

            oTAble = LibX.Data.Manager.GetDataTable(SelectStmt)

            For Each orow As DataRow In oTAble.Rows

                oRows = DataSet1.Tables("cjinitd").Select("mon_code = '" & orow!mon_code.ToString.Trim & "'")

                If oRows.Length <= 0 Then
                    NewRow = DataSet1.Tables("cjinitd").NewRow
                Else
                    NewRow = oRows(0)
                End If

                NewRow!mon_code = orow!mon_code
                NewRow!mon_denominacion = orow!mon_denominacion
                NewRow!mon_name = orow!mon_name

                DataSet1.Tables("cjinitd").Rows.Add(NewRow)
            Next

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub ShowOpen()
        Try

            LibX.LibXRunner.Run("i_cjopen", "CAJ", True)

            If CajaAbierta.CajeraCode <= 0 Then
                Exit Sub
            End If

            'txtcierre.Text = CajaAbierta.Serial
            txtcaja_code.Text = CajaAbierta.CajaCode
            vend_code1.Text = CajaAbierta.CajeraCode
            LibXConnector1.CurrentDataRow!init_serial = CajaAbierta.Serial
            LibXConnector1.CurrentDataRow!caja_code = CajaAbierta.CajaCode
            LibXConnector1.CurrentDataRow!vend_code = CajaAbierta.CajeraCode
            LibXConnector1.CurrentDataRow!suc_code = ScDefault
            'If CajaAbierta.Serial > 0 Then
            '    LibXConnector1.ExecuteFind("init_serial = " & CajaAbierta.Serial.ToString)
            'End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Dim xUpdate As LibX.Data.XUpdateStmt
        Dim xDelete As LibX.Data.XDeleteStmt
        Dim delctStmt As String
        Dim oTAble As DataTable
        Dim oProgram As SGT.Administracion.Entidades.Program
        Dim oParamRunning As SGT.Administracion.Entidades.Program.ParametroRunning
        Dim oCierre As SGT.Caja.Entidades.CuadreCaja
        Dim oDoc As SGT.Inventario.Entidades.Documento
        Try

            oProgram = New SGT.Administracion.Entidades.Program
            oParamRunning = New SGT.Administracion.Entidades.Program.ParametroRunning
            oCierre = New SGT.Caja.Entidades.CuadreCaja
            oDoc = New SGT.Inventario.Entidades.Documento("FPV")

            With oParamRunning
                .Caja = LibXConnector1.CurrentDataRow!caja_code
                .Cajera = LibXConnector1.CurrentDataRow!vend_code
                .Machine = mCaja
                .Fecha = LibXConnector1.CurrentDataRow!init_date
            End With

            'If oProgram.isRunning(oParamRunning) = True Then
            'Throw New ApplicationException("No puede cerrar esta caja, el punto de venta esta en uso!")
            'End If

            If LibXConnector1.CurrentDataRow!init_status <> 3 Then
                Throw New ApplicationException("Esta caja no esta en proceso de cierre, Verifique!")
            End If

            If MessageBox.Show("Seguro desea cerrar esta caja?", "Cerrar caja", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                delctStmt = "select * from ftfactm where init_serial = " & LibXConnector1.CurrentDataRow!init_serial
                oTAble = LibX.Data.Manager.GetDataTable(delctStmt)
                If oTAble.Rows.Count <= 0 Then
                    Throw New ApplicationException("Esta caja no tiene movimientos para ser cerrada")
                End If

                If nCfunico = True Then
                    xUpdate = New LibX.Data.XUpdateStmt("cjinitm")
                    xUpdate.FieldsSet("close_date") = LibX.Data.Manager.Connection.GetDate
                    xUpdate.FieldsSet("init_status") = 2 '//Cerrada
                    xUpdate.FieldsSet("no_cierre") = oCierre.GenerateNumberCierre(LibXConnector1.CurrentDataRow!caja_code)
                    xUpdate.FieldsSet("ncf") = oDoc.GenerateNCF("FPV", WhDefault, 2)
                    xUpdate.Fields("init_serial") = LibXConnector1.CurrentDataRow!init_serial
                    xUpdate.Execute()
                Else
                    xUpdate = New LibX.Data.XUpdateStmt("cjinitm")
                    xUpdate.FieldsSet("close_date") = LibX.Data.Manager.Connection.GetDate
                    xUpdate.FieldsSet("init_status") = 2 '//Cerrada
                    xUpdate.FieldsSet("no_cierre") = oCierre.GenerateNumberCierre(LibXConnector1.CurrentDataRow!caja_code)
                    xUpdate.Fields("init_serial") = LibXConnector1.CurrentDataRow!init_serial
                    xUpdate.Execute()
                End If

                delctStmt = "select * from ftbloqueo "
                oTAble = LibX.Data.Manager.GetDataTable(delctStmt)
                If oTAble.Rows.Count > 0 Then
                    For Each orow As DataRow In oTAble.Rows
                        xDelete = New LibX.Data.XDeleteStmt("ftbloqueo")
                        xDelete.Fields("ftserial_no") = orow!ftserial_no
                        xDelete.Execute()
                    Next
                End If

                SGF_backup()

                LibXConnector1.ExecuteFind("init_serial = " & LibXConnector1.CurrentDataRow!init_serial)
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_RowChange(ByVal sender As Object, ByVal e As LibX.XRowChangeEventArgs) Handles LibXConnector1.RowChange
        Try
            If LibXConnector1.HasRecords = True Then
                btnCerrar.Enabled = LibX.IsNull(LibXConnector1.CurrentDataRow!close_date)
                btndesglo.Enabled = LibX.IsNull(LibXConnector1.CurrentDataRow!close_date)
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_ExecutedAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutedAction
        Try
            'If e.Action = LibX.LibxConnectionActions.Find Then
            '    Me.xlk_init_serial.ExecuteLookup()
            'End If
            If e.Action = LibX.LibxConnectionActions.Find Then
                Me.xcob_init_status.currValue = 3
                Me.succode.Text = ScDefault
            End If

            'If e.AcceptedAction = LibX.LibxConnectionActions.Find _
            'And e.Action = LibX.LibxConnectionActions.Accept Then
            '    If LibXConnector1.HasRecords = True Then
            '        CuadrarCaja()
            '    End If
            'End If

            If e.Action = LibX.LibxConnectionActions.Edit Then
                'FillGrid()
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Function CuadrarCaja() As Boolean
        Dim SelectStmt As String
        Dim oTable As DataTable
        Dim oDoc As SGT.Inventario.Entidades.Documento
        Dim oMonto As Decimal
        Dim xUpdate As LibX.Data.XUpdateStmt
        Dim XDelete As LibX.Data.XDeleteStmt

        Try

            '// eliminar los registros existentes
            'SelectStmt = "delete from cjcierrm where init_serial =  " & LibXConnector1.CurrentDataRow!init_serial.ToString
            'LibX.Data.Manager.ExecuteNonQuery(SelectStmt)

            '// Cargar movimientos
            SelectStmt = String.Concat("SELECT cjtranrm.init_serial,ftfactm.type_code, ", _
                                        "cjtranrm.pay_method, sum(cjtranrm.amount) amount, count(*) qty", _
                                        " FROM cjtranrm cjtranrm INNER JOIN cjinitm cjinitm ON ", _
                                        " cjtranrm.init_serial = cjinitm.init_serial ", _
                                        " INNER JOIN ftfactm ftfactm ON ", _
                                        " cjtranrm.ftserial_no = ftfactm.ftserial_no ", _
                                        " INNER JOIN cjcajam cjcajam ON ", _
                                        " cjinitm.caja_code = cjcajam.caja_code ", _
                                        " WHERE ftfactm.fact_status = " & Val(EstatusDocumentosEnum.Cobrada).ToString, _
                                        " AND cjtranrm.init_serial = ", LibXConnector1.CurrentDataRow!init_serial.ToString, _
                                        " GROUP BY cjtranrm.init_serial,ftfactm.type_code,", _
                                        " cjtranrm.pay_method ", _
                                        " union ", _
                                        " SELECT cjinitm.init_serial,ftfactm.type_code,'NUL'pay_method,", _
                                        " sum(fact_total)amount, count(*) qty FROM ftfactm inner join cjinitm on ", _
                                        " cjinitm.init_date = ftfactm.fact_date and cjinitm.caja_code ", _
                                        " = ftfactm.caja_code and cjinitm.vend_code = ftfactm.caje_code ", _
                                        " and cjinitm.init_serial = " & LibXConnector1.CurrentDataRow!init_serial.ToString, _
                                        " and ftfactm.fact_status = 0 AND fact_number >0 " & _
                                        " GROUP BY cjinitm.init_serial,ftfactm.type_code ")

            '" ORDER BY cjtranrm.init_serial,ftfactm.type_code ASC,", _
            '" cjtranrm.pay_method ASC")

            oTable = LibX.Data.Manager.GetDataTable(SelectStmt)

            If oTable Is Nothing Then
                Throw New ApplicationException("Error buscando transacciones para este cuadre")
            End If

            If oTable.Rows.Count <= 0 Then
                Throw New ApplicationException("No se encontrarón transacciones para este cuadre")
            End If

            oTable.TableName = "cjcierrm"

            '// Eliminar los registros de cierre q hayan
            XDelete = New LibX.Data.XDeleteStmt("cjcierrm")
            XDelete.Fields("init_serial") = 0
            XDelete.Fields("type_code") = "NNN"
            XDelete.Fields("pay_method") = "NNN"

            For Each oRow As DataRow In oTable.Rows
                '''''// Verificar si en la tabla de cierre ya esta insertado
                '''''// este tipo de documento y esta forma de pago
                ''''Dim oRow1 As DataRow = DataSet1.Tables("cjcierrm").Rows.Find(New Object() {oRow!init_serial, _
                ''''                                                                            oRow!type_code, _
                ''''                                                                            oRow!pay_method})

                '// Eliminar Si existe
                XDelete.Fields("init_serial").value = oRow!init_serial
                XDelete.Fields("type_code").value = oRow!type_code
                XDelete.Fields("pay_method").value = oRow!pay_method

                XDelete.Execute()

                ' Buscar el tipo de documento
                oDoc = New SGT.Inventario.Entidades.Documento(oRow!type_code)

                ''''// Buscar el monto insertando en la tabla de cierre
                ''''// para este tipo de documento
                '''SelectStmt = "select amount from cjcierrm where init_serial =  " & _
                '''            LibXConnector1.CurrentDataRow!init_serial.ToString & _
                '''            " and type_code = '" & oRow!type_code.ToString.Trim & "'"

                '''oMonto = LibX.Data.Manager.GetScalar(SelectStmt)

                ''''// si no se encontro el monto agregar un nuevo
                ''''// registro a la tabla de cierre de lo contrario
                ''''// tomar los valores encontrados
                '''If oMonto = 0 Then
                Dim oRow1 As DataRow = DataSet1.Tables("cjcierrm").NewRow
                oRow1!init_serial = oRow!init_serial
                oRow1!type_code = oRow!type_code
                oRow1!pay_method = oRow!pay_method
                oRow1!amount = oRow!amount
                oRow1!qty = oRow!qty

                DataSet1.Tables("cjcierrm").Rows.Add(oRow1)
                '''Else
                '''    oRow1 = DataSet1.Tables("cjcierrm").NewRow
                '''    oRow1!init_serial = oRow!init_serial
                '''    oRow1!type_code = oRow!type_code
                '''    oRow1!pay_method = oRow!pay_method
                '''    oRow1!amount = oRow!amount
                '''    oRow1!qty = oRow!qty
                '''End If

                '// sumar el valor del tipo de documento al valor encontrado
                Select Case oRow!type_code
                    Case "FCT", "FPV"
                        oRow1!amount = oRow1!amount * 1
                    Case "FSG"
                        oRow1!amount = oRow1!amount * 1
                    Case "FTS"
                        oRow1!amount = oRow1!amount * 1
                    Case "DVF", "DEV"
                        oRow1!amount = oRow1!amount * -1
                    Case "RCE"
                        oRow1!amount = oRow1!amount * -1
                    Case "RCB"
                        oRow1!amount = oRow1!amount * 1
                    Case "EST"
                        oRow1!amount = oRow1!amount * 1
                End Select

                If oMonto <> 0 And oRow1!amount <> oMonto Then
                    xUpdate = New LibX.Data.XUpdateStmt("cjcierrm")
                    xUpdate.FieldsSet("amount") = oRow1!amount
                    xUpdate.Fields("init_serial") = LibXConnector1.CurrentDataRow!init_serial
                    xUpdate.Fields("type_code") = oRow!type_code
                    xUpdate.Fields("pay_method") = oRow!pay_method
                    xUpdate.Execute()
                End If
            Next

            LibX.Data.Manager.Save(DataSet1.Tables("cjcierrm"))

            ' DataSet1.Merge(oTable, False, MissingSchemaAction.Error)

        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Function
    'Private Sub LibXShortNavigator1_AfterClick(ByVal sender As Object, ByVal e As XMsaComponents.XMsaActionClickEventArgs) Handles LibXShortNavigator1.AfterClick

    '    Dim SelecStmt As String
    '    Dim AxCrystalReport1 As LibX.ReportLib
    '    Try

    '        Me.Cursor = Cursors.WaitCursor
    '        If e.ButtonAction = XMsaComponents.XmsaButtons.Print Then

    '            If nCfunico = True Then
    '                AxCrystalReport1 = New LibX.ReportLib("CAJ", "r_cjinit01ncf.rpt")
    '            Else
    '                AxCrystalReport1 = New LibX.ReportLib("CAJ", "r_cjinit01.rpt")
    '            End If

    '            With AxCrystalReport1
    '                '// Recibir el SQL Query
    '                .RetrieveSQLQuery()
    '                SelecStmt = .SQLQuery
    '                SelecStmt = LibX.MdlUtil.ConcatWherePart(SelecStmt, "cjinitm.init_serial = " & LibXConnector1.CurrentDataRow!init_serial)
    '                .SQLQuery = SelecStmt

    '                '// Ejecutar el reporte
    '                .Action = 1

    '            End With
    '        End If

    '    Catch ex As Exception
    '        LibX.Log.Add(ex, True)
    '    Finally
    '        Me.Cursor = Cursors.Default
    '    End Try
    'End Sub

    Private Sub LibXConnector1_BeforeExecuteQuery(ByVal sender As Object, ByVal e As LibX.XBeforeExecuteQueryEventArgs) Handles LibXConnector1.BeforeExecuteQuery

        Try

            If nCfunico = True Then
                Me.LibXConnector1.ReportName = "r_cjinit01ncf.rpt"
            Else
                Me.LibXConnector1.ReportName = "r_cjinit01.rpt"
                'Me.LibXConnector1.ReportName = "r_cjinit01Chino.rpt"
            End If
            If mPrint = True Then
                LibXConnector1.ReportObject.Destination = Crystal.DestinationConstants.crptToPrinter '// Imprimir Directo
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_AfterRowChange(ByVal sender As Object, ByVal e As LibX.XRowChangeEventArgs) Handles LibXConnector1.AfterRowChange
        Try
            If LibXConnector1.HasRecords = True Then
                If Not e.row Is Nothing Then
                    'If Not LibX.IsNull(e.row!no_cierre) Then
                    LibXConnector1.AllowPrint = True
                    'Else
                    '   LibXConnector1.AllowPrint = False
                    'End If
                If LibX.IsNull(e.row!init_status) = False AndAlso e.row!init_status = 2 Then '// Cerrada 
                    Me.btnCerrar.Enabled = False
                    Me.btndesglo.Enabled = False
                    LibXConnector1.AllowDelete = False
                    LibXConnector1.AllowEdit = False
                Else
                    Me.btnCerrar.Enabled = True
                    Me.btndesglo.Enabled = True

                    '// Cuadra la caja solo cuando la caja este abierta
                    '// de lo contario imprimir los registros de la tabla de cierre
                        CuadrarCaja()
                    End If
                    LibXShortNavigator1.UpdateState()
                End If
                Me.succode.Text = ScDefault
            End If
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub btndesglo_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndesglo.Click
        Dim oParametro As LibX.LibxPrgParams
        Try
            oParametro = New LibX.LibxPrgParams

            With oParametro
                .IsFromOther = True
                If LibXConnector1.CurrentDataRow!init_status = 2 Then '// Cerrada
                    .AllowDelete = False
                    .AllowEdit = False
                    .AllowNew = False
                    .initMode = LibX.LibxInitModes.none
                Else
                    .AllowDelete = False
                    .AllowNew = False
                    .initMode = LibX.LibxInitModes.Edit
                End If
                .WhereToExecute = "init_serial = " & LibXConnector1.CurrentDataRow!init_serial
            End With

            LibX.App.CurrentPrgParams = oParametro
            LibX.LibXRunner.Run("i_cjdesglosm01", "CAJ", True)
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_ChangingState(ByVal sender As Object, ByVal e As LibX.XChangeStateEventArgs) Handles LibXConnector1.ChangingState
        Me.succode.Text = ScDefault
        'If LibX.IsNull(LibXConnector1.CurrentDataRow!close_date) Or LibXConnector1.CurrentDataRow!init_status Then
        '    Me.btnCerrar.Enabled = Not e.isEditing AndAlso LibXConnector1.HasRecords = True
        '    Me.btndesglo.Enabled = Not e.isEditing AndAlso LibXConnector1.HasRecords = True
        'End If

    End Sub
    Private Sub SGF_backup()
        Dim SelectStmt As String
        SelectStmt = "exec SP_BK_SGF_desarollo"
        LibX.Data.Manager.GetDataTable(SelectStmt)
    End Sub
End Class
