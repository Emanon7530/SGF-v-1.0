Public Class c_cjpaym01
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
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents LBL_Title As System.Windows.Forms.Label
    '/TextBoxes
    Friend WithEvents xtxt_campo1 As LibX.XTextBox
    Friend WithEvents xtxt_campo2 As LibX.XTextBox
    Friend WithEvents xtxt_campo3 As LibX.XTextBox
    Friend WithEvents xtxt_campo4 As LibX.XTextBox
    Friend WithEvents xcbo_campo1 As LibX.LibXCombo
    Friend WithEvents xcbo_campo2 As LibX.LibXCombo

    '// Lookup 
    Friend WithEvents xlk_lookup1 As LibX.LibXLookup

    '/Labels
    Friend WithEvents lbl_label1 As Label
    Friend WithEvents lbl_label2 As Label
    Friend WithEvents lbl_label3 As Label
    Friend WithEvents lbl_label4 As Label
    Friend WithEvents lbl_label5 As Label
    Friend WithEvents lbl_label6 As Label
    Friend WithEvents lbl_cust_name As System.Windows.Forms.Label

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.xtxt_campo1 = New LibX.XTextBox
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.xtxt_campo2 = New LibX.XTextBox
        Me.xtxt_campo3 = New LibX.XTextBox
        Me.xtxt_campo4 = New LibX.XTextBox
        Me.xcbo_campo1 = New LibX.LibXCombo
        Me.xcbo_campo2 = New LibX.LibXCombo
        Me.xlk_lookup1 = New LibX.LibXLookup
        Me.lbl_label1 = New System.Windows.Forms.Label
        Me.lbl_label2 = New System.Windows.Forms.Label
        Me.lbl_label3 = New System.Windows.Forms.Label
        Me.lbl_label4 = New System.Windows.Forms.Label
        Me.lbl_label5 = New System.Windows.Forms.Label
        Me.lbl_label6 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.LBL_Title = New System.Windows.Forms.Label
        Me.lbl_cust_name = New System.Windows.Forms.Label
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'xtxt_campo1
        '
        Me.xtxt_campo1.AcceptsReturn = True
        Me.xtxt_campo1.EditInitialValue = Nothing
        Me.xtxt_campo1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_campo1.FieldDescription = ""
        Me.xtxt_campo1.FindInitialValue = Nothing
        Me.xtxt_campo1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_campo1.IgnoreRequiered = False
        Me.xtxt_campo1.Location = New System.Drawing.Point(0, 0)
        Me.xtxt_campo1.Name = "xtxt_campo1"
        Me.xtxt_campo1.NewInitialValue = Nothing
        Me.xtxt_campo1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_campo1.Requiered = False
        Me.xtxt_campo1.StatusBarPanelDescripcion = Nothing
        Me.xtxt_campo1.TabIndex = 0
        Me.xtxt_campo1.Text = ""
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
        Me.LibXConnector1.DataMember = "cjtranrm"
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
        Me.LibXDbSourceTable1.Source = New String() {"select cjtranrm.ftserial_no, " & Microsoft.VisualBasic.ChrW(9), "cjtranrm.amount, " & Microsoft.VisualBasic.ChrW(9), "cjtranrm.tart_code, " & Microsoft.VisualBasic.ChrW(9), "cjtranrm.tarj_code, " & Microsoft.VisualBasic.ChrW(9), "pvtarjeta.tarj_numero,", "pvtarjeta.tarj_vence,", "cjtranrm.cust_code,", "cccustm.csttype_code,", "cccustm.cust_name,", "cccustm.balance,", "cccustm.credit_limit,", "cccustm.cust_status,", "cjtranrm.chk_code,", "cjchkm.chk_number,", "cjchkm.chk_date,", "cjchkm.chk_amount,", "cjchkm.ban_code,", "cjchkm.chk_benef,", "cjchkm.chk_estatus,", "cjncrm.type_code,", "cjncrm.ncr_number,", "cjncrm.ncr_date,", "cjncrm.ncr_amount,", "cjncrm.ncr_balance,", "cjncrm.ncr_estatus,", "cjncrm.bus_name", "from cjtranrm ", "left outer join cjncrm ", "on cjncrm.ncr_code = cjtranrm.ncr_code ", "left outer join cjchkm ", "on cjchkm.chk_code = cjtranrm.chk_code ", "left outer join cccustm", "on cccustm.cust_code = cjtranrm.cust_code", "left outer join pvtarjeta", "on pvtarjeta.tarj_code = cjtranrm.tarj_code"}
        Me.LibXDbSourceTable1.TableName = "cjtranrm"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
        '
        'xtxt_campo2
        '
        Me.xtxt_campo2.AcceptsReturn = True
        Me.xtxt_campo2.EditInitialValue = Nothing
        Me.xtxt_campo2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_campo2.FieldDescription = ""
        Me.xtxt_campo2.FindInitialValue = Nothing
        Me.xtxt_campo2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_campo2.IgnoreRequiered = False
        Me.xtxt_campo2.Location = New System.Drawing.Point(0, 0)
        Me.xtxt_campo2.Name = "xtxt_campo2"
        Me.xtxt_campo2.NewInitialValue = Nothing
        Me.xtxt_campo2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_campo2.Requiered = False
        Me.xtxt_campo2.StatusBarPanelDescripcion = Nothing
        Me.xtxt_campo2.TabIndex = 0
        Me.xtxt_campo2.Text = ""
        '
        'xtxt_campo3
        '
        Me.xtxt_campo3.AcceptsReturn = True
        Me.xtxt_campo3.EditInitialValue = Nothing
        Me.xtxt_campo3.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_campo3.FieldDescription = ""
        Me.xtxt_campo3.FindInitialValue = Nothing
        Me.xtxt_campo3.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_campo3.IgnoreRequiered = False
        Me.xtxt_campo3.Location = New System.Drawing.Point(0, 0)
        Me.xtxt_campo3.Name = "xtxt_campo3"
        Me.xtxt_campo3.NewInitialValue = Nothing
        Me.xtxt_campo3.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_campo3.Requiered = False
        Me.xtxt_campo3.StatusBarPanelDescripcion = Nothing
        Me.xtxt_campo3.TabIndex = 0
        Me.xtxt_campo3.Text = ""
        '
        'xtxt_campo4
        '
        Me.xtxt_campo4.AcceptsReturn = True
        Me.xtxt_campo4.EditInitialValue = Nothing
        Me.xtxt_campo4.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_campo4.FieldDescription = ""
        Me.xtxt_campo4.FindInitialValue = Nothing
        Me.xtxt_campo4.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_campo4.IgnoreRequiered = False
        Me.xtxt_campo4.Location = New System.Drawing.Point(0, 0)
        Me.xtxt_campo4.Name = "xtxt_campo4"
        Me.xtxt_campo4.NewInitialValue = Nothing
        Me.xtxt_campo4.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_campo4.Requiered = False
        Me.xtxt_campo4.StatusBarPanelDescripcion = Nothing
        Me.xtxt_campo4.TabIndex = 0
        Me.xtxt_campo4.Text = ""
        '
        'xcbo_campo1
        '
        Me.xcbo_campo1.AllowDefaultSort = True
        Me.xcbo_campo1.bound = True
        Me.xcbo_campo1.currValue = Nothing
        Me.xcbo_campo1.DefaultWhereString = Nothing
        Me.xcbo_campo1.EditInitialValue = Nothing
        Me.xcbo_campo1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_campo1.FieldDescription = ""
        Me.xcbo_campo1.FindInitialValue = Nothing
        Me.xcbo_campo1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_campo1.IgnoreRequiered = False
        Me.xcbo_campo1.Location = New System.Drawing.Point(0, 0)
        Me.xcbo_campo1.LookupKeyDisplayFields = Nothing
        Me.xcbo_campo1.LookupKeyField = Nothing
        Me.xcbo_campo1.LookupTableName = Nothing
        Me.xcbo_campo1.Name = "xcbo_campo1"
        Me.xcbo_campo1.NewInitialValue = Nothing
        Me.xcbo_campo1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_campo1.Requiered = False
        Me.xcbo_campo1.Required = False
        Me.xcbo_campo1.SqlString = Nothing
        Me.xcbo_campo1.StatusBarPanelDescripcion = Nothing
        Me.xcbo_campo1.TabIndex = 0
        '
        'xcbo_campo2
        '
        Me.xcbo_campo2.AllowDefaultSort = True
        Me.xcbo_campo2.bound = True
        Me.xcbo_campo2.currValue = Nothing
        Me.xcbo_campo2.DefaultWhereString = Nothing
        Me.xcbo_campo2.EditInitialValue = Nothing
        Me.xcbo_campo2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_campo2.FieldDescription = ""
        Me.xcbo_campo2.FindInitialValue = Nothing
        Me.xcbo_campo2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_campo2.IgnoreRequiered = False
        Me.xcbo_campo2.Location = New System.Drawing.Point(0, 0)
        Me.xcbo_campo2.LookupKeyDisplayFields = Nothing
        Me.xcbo_campo2.LookupKeyField = Nothing
        Me.xcbo_campo2.LookupTableName = Nothing
        Me.xcbo_campo2.Name = "xcbo_campo2"
        Me.xcbo_campo2.NewInitialValue = Nothing
        Me.xcbo_campo2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_campo2.Requiered = False
        Me.xcbo_campo2.Required = False
        Me.xcbo_campo2.SqlString = Nothing
        Me.xcbo_campo2.StatusBarPanelDescripcion = Nothing
        Me.xcbo_campo2.TabIndex = 0
        '
        'xlk_lookup1
        '
        Me.xlk_lookup1.AlternateFieldSearch = Nothing
        Me.xlk_lookup1.BeginCheck = False
        Me.xlk_lookup1.CheckText = Nothing
        Me.xlk_lookup1.ComboMode = False
        Me.xlk_lookup1.DataMember = Nothing
        Me.xlk_lookup1.DataSource = Nothing
        Me.xlk_lookup1.DestParameters = Nothing
        Me.xlk_lookup1.FilterField = Nothing
        Me.xlk_lookup1.IgnoreFindInBrowseMode = False
        Me.xlk_lookup1.isCanceled = False
        Me.xlk_lookup1.Location = New System.Drawing.Point(0, 0)
        Me.xlk_lookup1.LookCaption = ""
        Me.xlk_lookup1.Name = "xlk_lookup1"
        Me.xlk_lookup1.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_lookup1.ShowFilter = True
        Me.xlk_lookup1.ShowMessageNotFound = True
        Me.xlk_lookup1.ShowWarning = False
        Me.xlk_lookup1.Size = New System.Drawing.Size(16, 20)
        Me.xlk_lookup1.SizesColumns = Nothing
        Me.xlk_lookup1.SizesColumnsTab = Nothing
        Me.xlk_lookup1.SqlString = Nothing
        Me.xlk_lookup1.SQLTab = Nothing
        Me.xlk_lookup1.SrcParameters = Nothing
        Me.xlk_lookup1.TabIndex = 0
        Me.xlk_lookup1.TableName = Nothing
        Me.xlk_lookup1.TabStop = False
        Me.xlk_lookup1.UseCopyConnection = False
        Me.xlk_lookup1.UseRowRetrieveEvents = False
        Me.xlk_lookup1.UseTab = False
        Me.xlk_lookup1.VisParameters = Nothing
        Me.xlk_lookup1.WhereCondition = Nothing
        Me.xlk_lookup1.WhereParameters = Nothing
        '
        'lbl_label1
        '
        Me.lbl_label1.Location = New System.Drawing.Point(0, 0)
        Me.lbl_label1.Name = "lbl_label1"
        Me.lbl_label1.TabIndex = 0
        '
        'lbl_label2
        '
        Me.lbl_label2.Location = New System.Drawing.Point(0, 0)
        Me.lbl_label2.Name = "lbl_label2"
        Me.lbl_label2.TabIndex = 0
        '
        'lbl_label3
        '
        Me.lbl_label3.Location = New System.Drawing.Point(0, 0)
        Me.lbl_label3.Name = "lbl_label3"
        Me.lbl_label3.TabIndex = 0
        '
        'lbl_label4
        '
        Me.lbl_label4.Location = New System.Drawing.Point(0, 0)
        Me.lbl_label4.Name = "lbl_label4"
        Me.lbl_label4.TabIndex = 0
        '
        'lbl_label5
        '
        Me.lbl_label5.Location = New System.Drawing.Point(0, 0)
        Me.lbl_label5.Name = "lbl_label5"
        Me.lbl_label5.TabIndex = 0
        '
        'lbl_label6
        '
        Me.lbl_label6.Location = New System.Drawing.Point(0, 0)
        Me.lbl_label6.Name = "lbl_label6"
        Me.lbl_label6.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(8, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(408, 216)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnCancelar.Location = New System.Drawing.Point(344, 280)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(72, 23)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.Text = "Cerrar"
        '
        'LBL_Title
        '
        Me.LBL_Title.BackColor = System.Drawing.Color.White
        Me.LBL_Title.Dock = System.Windows.Forms.DockStyle.Top
        Me.LBL_Title.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.LBL_Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Title.ForeColor = System.Drawing.Color.Blue
        Me.LBL_Title.Location = New System.Drawing.Point(0, 0)
        Me.LBL_Title.Name = "LBL_Title"
        Me.LBL_Title.Size = New System.Drawing.Size(424, 56)
        Me.LBL_Title.TabIndex = 2
        Me.LBL_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_cust_name
        '
        Me.lbl_cust_name.Location = New System.Drawing.Point(0, 0)
        Me.lbl_cust_name.Name = "lbl_cust_name"
        Me.lbl_cust_name.TabIndex = 0
        '
        'c_cjpaym01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(424, 312)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.LBL_Title)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "c_cjpaym01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Información de Pagos"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub CrearNCR()
        Dim lbl_cust_name As New Label
        '
        'xtxt_campo1
        '
        Me.xtxt_campo1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "cjtranrm.bus_name"))
        Me.xtxt_campo1.EditInitialValue = Nothing
        Me.xtxt_campo1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_campo1.FieldDescription = ""
        Me.xtxt_campo1.FindInitialValue = Nothing
        Me.xtxt_campo1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_campo1.IgnoreRequiered = False
        Me.xtxt_campo1.Location = New System.Drawing.Point(88, 40)
        Me.xtxt_campo1.Name = "xtxt_campo1"
        Me.xtxt_campo1.NewInitialValue = Nothing
        Me.xtxt_campo1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_campo1.Requiered = False
        Me.xtxt_campo1.Size = New System.Drawing.Size(312, 20)
        Me.xtxt_campo1.StatusBarPanelDescripcion = Nothing
        Me.xtxt_campo1.TabIndex = 0
        Me.xtxt_campo1.Text = ""
        '
        'xtxt_campo2
        '
        Me.xtxt_campo2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "cjtranrm.ncr_number"))
        Me.xtxt_campo2.EditInitialValue = Nothing
        Me.xtxt_campo2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_campo2.FieldDescription = ""
        Me.xtxt_campo2.FindInitialValue = Nothing
        Me.xtxt_campo2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_campo2.IgnoreRequiered = False
        Me.xtxt_campo2.Location = New System.Drawing.Point(88, 64)
        Me.xtxt_campo2.Name = "xtxt_campo2"
        Me.xtxt_campo2.NewInitialValue = Nothing
        Me.xtxt_campo2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_campo2.Requiered = False
        Me.xtxt_campo2.StatusBarPanelDescripcion = Nothing
        Me.xtxt_campo2.TabIndex = 1
        Me.xtxt_campo2.Text = ""
        '
        'xtxt_campo3
        '
        Me.xtxt_campo3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "cjtranrm.ncr_date"))
        Me.xtxt_campo3.EditInitialValue = Nothing
        Me.xtxt_campo3.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_campo3.FieldDescription = ""
        Me.xtxt_campo3.FindInitialValue = Nothing
        Me.xtxt_campo3.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_campo3.IgnoreRequiered = False
        Me.xtxt_campo3.Location = New System.Drawing.Point(296, 64)
        Me.xtxt_campo3.Name = "xtxt_campo3"
        Me.xtxt_campo3.NewInitialValue = Nothing
        Me.xtxt_campo3.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_campo3.Requiered = False
        Me.xtxt_campo3.Size = New System.Drawing.Size(104, 20)
        Me.xtxt_campo3.StatusBarPanelDescripcion = Nothing
        Me.xtxt_campo3.TabIndex = 3
        Me.xtxt_campo3.Text = ""
        '
        'xtxt_campo4
        '
        Me.xtxt_campo4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "cjtranrm.ncr_amount"))
        Me.xtxt_campo4.EditInitialValue = Nothing
        Me.xtxt_campo4.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_campo4.FieldDescription = ""
        Me.xtxt_campo4.FindInitialValue = Nothing
        Me.xtxt_campo4.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_campo4.IgnoreRequiered = False
        Me.xtxt_campo4.Location = New System.Drawing.Point(88, 88)
        Me.xtxt_campo4.Name = "xtxt_campo4"
        Me.xtxt_campo4.NewInitialValue = Nothing
        Me.xtxt_campo4.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_campo4.Requiered = False
        Me.xtxt_campo4.StatusBarPanelDescripcion = Nothing
        Me.xtxt_campo4.TabIndex = 2
        Me.xtxt_campo4.Text = ""
        '
        'xcbo_campo1
        '
        Me.xcbo_campo1.AllowDefaultSort = True
        Me.xcbo_campo1.bound = True
        Me.xcbo_campo1.currValue = Nothing
        Me.xcbo_campo1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.LibXConnector1, "cjtranrm.type_code"))
        Me.xcbo_campo1.DefaultWhereString = Nothing
        Me.xcbo_campo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_campo1.EditInitialValue = Nothing
        Me.xcbo_campo1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_campo1.FieldDescription = ""
        Me.xcbo_campo1.FindInitialValue = Nothing
        Me.xcbo_campo1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_campo1.IgnoreRequiered = False
        Me.xcbo_campo1.Location = New System.Drawing.Point(88, 16)
        Me.xcbo_campo1.LookupKeyDisplayFields = "type_name"
        Me.xcbo_campo1.LookupKeyField = "type_code"
        Me.xcbo_campo1.LookupTableName = "ivtypem"
        Me.xcbo_campo1.Name = "xcbo_campo1"
        Me.xcbo_campo1.NewInitialValue = Nothing
        Me.xcbo_campo1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_campo1.Requiered = False
        Me.xcbo_campo1.Required = False
        Me.xcbo_campo1.Size = New System.Drawing.Size(312, 21)
        Me.xcbo_campo1.SqlString = Nothing
        Me.xcbo_campo1.StatusBarPanelDescripcion = Nothing
        Me.xcbo_campo1.TabIndex = 4
        '
        'xcbo_campo2
        '
        Me.xcbo_campo2.AllowDefaultSort = True
        Me.xcbo_campo2.bound = True
        Me.xcbo_campo2.currValue = Nothing
        Me.xcbo_campo2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.LibXConnector1, "cjtranrm.ncr_estatus"))
        Me.xcbo_campo2.DefaultWhereString = Nothing
        Me.xcbo_campo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_campo2.EditInitialValue = Nothing
        Me.xcbo_campo2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_campo2.FieldDescription = ""
        Me.xcbo_campo2.FindInitialValue = Nothing
        Me.xcbo_campo2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_campo2.IgnoreRequiered = False
        Me.xcbo_campo2.Items.AddRange(New Object() {"1-Pendiente", "0-Cobrada"})
        Me.xcbo_campo2.Location = New System.Drawing.Point(296, 88)
        Me.xcbo_campo2.LookupKeyDisplayFields = Nothing
        Me.xcbo_campo2.LookupKeyField = Nothing
        Me.xcbo_campo2.LookupTableName = Nothing
        Me.xcbo_campo2.Name = "xcbo_campo2"
        Me.xcbo_campo2.NewInitialValue = Nothing
        Me.xcbo_campo2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_campo2.Requiered = False
        Me.xcbo_campo2.Required = False
        Me.xcbo_campo2.Size = New System.Drawing.Size(104, 21)
        Me.xcbo_campo2.SqlString = Nothing
        Me.xcbo_campo2.StatusBarPanelDescripcion = Nothing
        Me.xcbo_campo2.TabIndex = 5
        '
        'lbl_label1
        '
        Me.lbl_label1.AutoSize = True
        Me.lbl_label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lbl_label1.Location = New System.Drawing.Point(48, 16)
        Me.lbl_label1.Name = "lbl_label1"
        Me.lbl_label1.Size = New System.Drawing.Size(29, 16)
        Me.lbl_label1.TabIndex = 9
        Me.lbl_label1.Text = "Tipo:"
        Me.lbl_label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_label2
        '
        Me.lbl_label2.AutoSize = True
        Me.lbl_label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lbl_label2.Location = New System.Drawing.Point(34, 40)
        Me.lbl_label2.Name = "lbl_label2"
        Me.lbl_label2.Size = New System.Drawing.Size(43, 16)
        Me.lbl_label2.TabIndex = 7
        Me.lbl_label2.Text = "Cliente:"
        Me.lbl_label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_label3
        '
        Me.lbl_label3.AutoSize = True
        Me.lbl_label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lbl_label3.Location = New System.Drawing.Point(29, 64)
        Me.lbl_label3.Name = "lbl_label3"
        Me.lbl_label3.Size = New System.Drawing.Size(48, 16)
        Me.lbl_label3.TabIndex = 6
        Me.lbl_label3.Text = "Número:"
        Me.lbl_label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_label4
        '
        Me.lbl_label4.AutoSize = True
        Me.lbl_label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lbl_label4.Location = New System.Drawing.Point(248, 64)
        Me.lbl_label4.Name = "lbl_label4"
        Me.lbl_label4.Size = New System.Drawing.Size(39, 16)
        Me.lbl_label4.TabIndex = 8
        Me.lbl_label4.Text = "Fecha:"
        Me.lbl_label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_label5
        '
        Me.lbl_label5.AutoSize = True
        Me.lbl_label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lbl_label5.Location = New System.Drawing.Point(38, 88)
        Me.lbl_label5.Name = "lbl_label5"
        Me.lbl_label5.Size = New System.Drawing.Size(39, 16)
        Me.lbl_label5.TabIndex = 11
        Me.lbl_label5.Text = "Monto:"
        Me.lbl_label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_label6
        '
        Me.lbl_label6.AutoSize = True
        Me.lbl_label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lbl_label6.Location = New System.Drawing.Point(242, 88)
        Me.lbl_label6.Name = "lbl_label6"
        Me.lbl_label6.Size = New System.Drawing.Size(45, 16)
        Me.lbl_label6.TabIndex = 10
        Me.lbl_label6.Text = "Estatus:"
        Me.lbl_label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.xtxt_campo1)
        Me.GroupBox1.Controls.Add(Me.xtxt_campo2)
        Me.GroupBox1.Controls.Add(Me.xtxt_campo4)
        Me.GroupBox1.Controls.Add(Me.xtxt_campo3)
        Me.GroupBox1.Controls.Add(Me.xcbo_campo1)
        Me.GroupBox1.Controls.Add(Me.xcbo_campo2)
        Me.GroupBox1.Controls.Add(Me.lbl_label3)
        Me.GroupBox1.Controls.Add(Me.lbl_label2)
        Me.GroupBox1.Controls.Add(Me.lbl_label4)
        Me.GroupBox1.Controls.Add(Me.lbl_label1)
        Me.GroupBox1.Controls.Add(Me.lbl_label6)
        Me.GroupBox1.Controls.Add(Me.lbl_label5)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(8, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(408, 216)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
    End Sub

    Private Sub CrearTAR()
        'Dim lbl_cust_name As New Label

        ''// Codigo del cliente
        Me.GroupBox1.Controls.Add(xtxt_campo1)
        Me.GroupBox1.Controls.Add(xtxt_campo2)
        Me.GroupBox1.Controls.Add(xtxt_campo4)
        Me.GroupBox1.Controls.Add(lbl_label3)
        Me.GroupBox1.Controls.Add(xcbo_campo1)
        Me.GroupBox1.Controls.Add(lbl_label2)
        Me.GroupBox1.Controls.Add(lbl_label4)
        Me.GroupBox1.Controls.Add(lbl_label1)
        '// Banco
        With xcbo_campo1
            .AllowDefaultSort = True
            .bound = True
            .currValue = Nothing
            .DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.LibXConnector1, "cjtranrm.tart_code"))
            .DefaultWhereString = Nothing
            .DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            .EditInitialValue = Nothing
            .EditState = LibX.IEditProperty.InitialStateEnum.Enabled
            .FieldDescription = ""
            .FindInitialValue = Nothing
            .FindState = LibX.IEditProperty.InitialStateEnum.Enabled
            .IgnoreRequiered = False
            .Location = New System.Drawing.Point(96, 24)
            .LookupKeyDisplayFields = "Nombre"
            .LookupKeyField = "tart_code"
            .LookupTableName = "pvtipotarm"
            .Name = "xcbo_banco"
            .NewInitialValue = Nothing
            .NewState = LibX.IEditProperty.InitialStateEnum.Enabled
            .Requiered = False
            .Required = False
            .Size = New System.Drawing.Size(280, 21)
            .SqlString = Nothing
            .StatusBarPanelDescripcion = Nothing
            .TabIndex = 1
            .LoadDbItems(True)
        End With

        '// Label Banco
        With lbl_label3
            .AutoSize = True
            .Location = New System.Drawing.Point(18, 24)
            .Size = New System.Drawing.Size(39, 16)
            .Text = "Tipo Tarjeta:"
            .TextAlign = System.Drawing.ContentAlignment.TopRight
        End With

        '// Numero de Tarjeta de credito
        With xtxt_campo1
            .DataBindings.Add("Text", LibXConnector1, "cjtranrm.tarj_numero")
            .Text = ""
            .Location = New System.Drawing.Point(96, 48)
            .Size = New System.Drawing.Size(280, 20)
        End With

        With lbl_label1
            .AutoSize = True
            .Location = New System.Drawing.Point(18, 48)
            .Size = New System.Drawing.Size(48, 16)
            .Text = "Numero:"
            .TextAlign = System.Drawing.ContentAlignment.TopRight
        End With

        '// Vencimiento
        With xtxt_campo4
            .DataBindings.Add("Text", LibXConnector1, "cjtranrm.tarj_vence")
            .Location = New System.Drawing.Point(96, 72)
            .Size = New System.Drawing.Size(112, 20)
            .Text = ""
        End With

        '// label Vencimiento
        With Me.lbl_label4
            .AutoSize = True
            .Location = New System.Drawing.Point(18, 72)
            .Size = New System.Drawing.Size(34, 16)
            .Text = "Vencimiento:"
            .TextAlign = System.Drawing.ContentAlignment.TopRight
        End With

        '// Monto
        With lbl_label2
            .Text = "Monto:"
            .AutoSize = True
            .TextAlign = ContentAlignment.TopRight
            .Location = New System.Drawing.Point(212, 72)
            .Size = New System.Drawing.Size(39, 16)
        End With

        With xtxt_campo2
            .DataBindings.Add("Text", LibXConnector1, "cjtranrm.amount")
            .Text = ""
            .Location = New System.Drawing.Point(265, 72)
            .Size = New System.Drawing.Size(112, 20)
            .TextAlign = HorizontalAlignment.Right
        End With
    End Sub

    Private Sub CrearCHK()
        '
        'xtxt_campo1
        '
        Me.xtxt_campo1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "cjtranrm.chk_benef"))
        Me.xtxt_campo1.EditInitialValue = Nothing
        Me.xtxt_campo1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_campo1.FieldDescription = ""
        Me.xtxt_campo1.FindInitialValue = Nothing
        Me.xtxt_campo1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_campo1.IgnoreRequiered = False
        Me.xtxt_campo1.Location = New System.Drawing.Point(88, 40)
        Me.xtxt_campo1.Name = "xtxt_campo1"
        Me.xtxt_campo1.NewInitialValue = Nothing
        Me.xtxt_campo1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_campo1.Requiered = False
        Me.xtxt_campo1.Size = New System.Drawing.Size(312, 20)
        Me.xtxt_campo1.StatusBarPanelDescripcion = Nothing
        Me.xtxt_campo1.TabIndex = 0
        Me.xtxt_campo1.Text = ""
        '
        'xtxt_campo2
        '
        Me.xtxt_campo2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "cjtranrm.chk_number"))
        Me.xtxt_campo2.EditInitialValue = Nothing
        Me.xtxt_campo2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_campo2.FieldDescription = ""
        Me.xtxt_campo2.FindInitialValue = Nothing
        Me.xtxt_campo2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_campo2.IgnoreRequiered = False
        Me.xtxt_campo2.Location = New System.Drawing.Point(88, 64)
        Me.xtxt_campo2.Name = "xtxt_campo2"
        Me.xtxt_campo2.NewInitialValue = Nothing
        Me.xtxt_campo2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_campo2.Requiered = False
        Me.xtxt_campo2.StatusBarPanelDescripcion = Nothing
        Me.xtxt_campo2.TabIndex = 1
        Me.xtxt_campo2.Text = ""
        '
        'xtxt_campo3
        '
        Me.xtxt_campo3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "cjtranrm.chk_date"))
        Me.xtxt_campo3.EditInitialValue = Nothing
        Me.xtxt_campo3.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_campo3.FieldDescription = ""
        Me.xtxt_campo3.FindInitialValue = Nothing
        Me.xtxt_campo3.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_campo3.IgnoreRequiered = False
        Me.xtxt_campo3.Location = New System.Drawing.Point(296, 64)
        Me.xtxt_campo3.Name = "xtxt_campo3"
        Me.xtxt_campo3.NewInitialValue = Nothing
        Me.xtxt_campo3.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_campo3.Requiered = False
        Me.xtxt_campo3.Size = New System.Drawing.Size(104, 20)
        Me.xtxt_campo3.StatusBarPanelDescripcion = Nothing
        Me.xtxt_campo3.TabIndex = 3
        Me.xtxt_campo3.Text = ""
        '
        'xtxt_campo4
        '
        Me.xtxt_campo4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "cjtranrm.chk_amount"))
        Me.xtxt_campo4.EditInitialValue = Nothing
        Me.xtxt_campo4.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_campo4.FieldDescription = ""
        Me.xtxt_campo4.FindInitialValue = Nothing
        Me.xtxt_campo4.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_campo4.IgnoreRequiered = False
        Me.xtxt_campo4.Location = New System.Drawing.Point(88, 88)
        Me.xtxt_campo4.Name = "xtxt_campo4"
        Me.xtxt_campo4.NewInitialValue = Nothing
        Me.xtxt_campo4.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_campo4.Requiered = False
        Me.xtxt_campo4.StatusBarPanelDescripcion = Nothing
        Me.xtxt_campo4.TabIndex = 2
        Me.xtxt_campo4.Text = ""
        '
        'xcbo_campo1
        '
        Me.xcbo_campo1.AllowDefaultSort = True
        Me.xcbo_campo1.bound = True
        Me.xcbo_campo1.currValue = Nothing
        Me.xcbo_campo1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.LibXConnector1, "cjtranrm.ban_code"))
        Me.xcbo_campo1.DefaultWhereString = Nothing
        Me.xcbo_campo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_campo1.EditInitialValue = Nothing
        Me.xcbo_campo1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_campo1.FieldDescription = ""
        Me.xcbo_campo1.FindInitialValue = Nothing
        Me.xcbo_campo1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_campo1.IgnoreRequiered = False
        Me.xcbo_campo1.Location = New System.Drawing.Point(88, 16)
        Me.xcbo_campo1.LookupKeyDisplayFields = "ban_name"
        Me.xcbo_campo1.LookupKeyField = "ban_code"
        Me.xcbo_campo1.LookupTableName = "ftbanco"
        Me.xcbo_campo1.Name = "xcbo_campo1"
        Me.xcbo_campo1.NewInitialValue = Nothing
        Me.xcbo_campo1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_campo1.Requiered = False
        Me.xcbo_campo1.Required = False
        Me.xcbo_campo1.Size = New System.Drawing.Size(312, 21)
        Me.xcbo_campo1.SqlString = Nothing
        Me.xcbo_campo1.StatusBarPanelDescripcion = Nothing
        Me.xcbo_campo1.TabIndex = 4
        '
        'xcbo_campo2
        '
        Me.xcbo_campo2.AllowDefaultSort = True
        Me.xcbo_campo2.bound = True
        Me.xcbo_campo2.currValue = Nothing
        Me.xcbo_campo2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.LibXConnector1, "cjtranrm.chk_estatus"))
        Me.xcbo_campo2.DefaultWhereString = Nothing
        Me.xcbo_campo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_campo2.EditInitialValue = Nothing
        Me.xcbo_campo2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_campo2.FieldDescription = ""
        Me.xcbo_campo2.FindInitialValue = Nothing
        Me.xcbo_campo2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_campo2.IgnoreRequiered = False
        Me.xcbo_campo2.Items.AddRange(New Object() {"1-Aceptado", "0-Devuelto"})
        Me.xcbo_campo2.Location = New System.Drawing.Point(296, 88)
        Me.xcbo_campo2.LookupKeyDisplayFields = Nothing
        Me.xcbo_campo2.LookupKeyField = Nothing
        Me.xcbo_campo2.LookupTableName = Nothing
        Me.xcbo_campo2.Name = "xcbo_campo2"
        Me.xcbo_campo2.NewInitialValue = Nothing
        Me.xcbo_campo2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_campo2.Requiered = False
        Me.xcbo_campo2.Required = False
        Me.xcbo_campo2.Size = New System.Drawing.Size(104, 21)
        Me.xcbo_campo2.SqlString = Nothing
        Me.xcbo_campo2.StatusBarPanelDescripcion = Nothing
        Me.xcbo_campo2.TabIndex = 5
        '
        'lbl_label1
        '
        Me.lbl_label1.AutoSize = True
        Me.lbl_label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lbl_label1.Location = New System.Drawing.Point(40, 16)
        Me.lbl_label1.Name = "lbl_label1"
        Me.lbl_label1.Size = New System.Drawing.Size(39, 16)
        Me.lbl_label1.TabIndex = 9
        Me.lbl_label1.Text = "Banco:"
        Me.lbl_label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_label2
        '
        Me.lbl_label2.AutoSize = True
        Me.lbl_label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lbl_label2.Location = New System.Drawing.Point(12, 40)
        Me.lbl_label2.Name = "lbl_label2"
        Me.lbl_label2.Size = New System.Drawing.Size(67, 16)
        Me.lbl_label2.TabIndex = 7
        Me.lbl_label2.Text = "Beneficiario:"
        Me.lbl_label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_label3
        '
        Me.lbl_label3.AutoSize = True
        Me.lbl_label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lbl_label3.Location = New System.Drawing.Point(31, 64)
        Me.lbl_label3.Name = "lbl_label3"
        Me.lbl_label3.Size = New System.Drawing.Size(48, 16)
        Me.lbl_label3.TabIndex = 6
        Me.lbl_label3.Text = "Número:"
        Me.lbl_label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_label4
        '
        Me.lbl_label4.AutoSize = True
        Me.lbl_label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lbl_label4.Location = New System.Drawing.Point(248, 64)
        Me.lbl_label4.Name = "lbl_label4"
        Me.lbl_label4.Size = New System.Drawing.Size(39, 16)
        Me.lbl_label4.TabIndex = 8
        Me.lbl_label4.Text = "Fecha:"
        Me.lbl_label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_label5
        '
        Me.lbl_label5.AutoSize = True
        Me.lbl_label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lbl_label5.Location = New System.Drawing.Point(40, 88)
        Me.lbl_label5.Name = "lbl_label5"
        Me.lbl_label5.Size = New System.Drawing.Size(39, 16)
        Me.lbl_label5.TabIndex = 11
        Me.lbl_label5.Text = "Monto:"
        Me.lbl_label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_label6
        '
        Me.lbl_label6.AutoSize = True
        Me.lbl_label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lbl_label6.Location = New System.Drawing.Point(242, 88)
        Me.lbl_label6.Name = "lbl_label6"
        Me.lbl_label6.Size = New System.Drawing.Size(45, 16)
        Me.lbl_label6.TabIndex = 10
        Me.lbl_label6.Text = "Estatus:"
        Me.lbl_label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.xtxt_campo1)
        Me.GroupBox1.Controls.Add(Me.xtxt_campo2)
        Me.GroupBox1.Controls.Add(Me.xtxt_campo4)
        Me.GroupBox1.Controls.Add(Me.xtxt_campo3)
        Me.GroupBox1.Controls.Add(Me.xcbo_campo1)
        Me.GroupBox1.Controls.Add(Me.xcbo_campo2)
        Me.GroupBox1.Controls.Add(Me.lbl_label3)
        Me.GroupBox1.Controls.Add(Me.lbl_label2)
        Me.GroupBox1.Controls.Add(Me.lbl_label4)
        Me.GroupBox1.Controls.Add(Me.lbl_label1)
        Me.GroupBox1.Controls.Add(Me.lbl_label6)
        Me.GroupBox1.Controls.Add(Me.lbl_label5)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(8, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(408, 216)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
    End Sub

    Private Sub CrearCXC()
        Dim lbl_cust_name As New Label

        'xtxt_campo1
        '
        Me.xtxt_campo1.DataBindings.Add("Text", Me.LibXConnector1, "cjtranrm.cust_name")
        Me.xtxt_campo1.EditInitialValue = Nothing
        Me.xtxt_campo1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_campo1.FieldDescription = ""
        Me.xtxt_campo1.FindInitialValue = Nothing
        Me.xtxt_campo1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_campo1.IgnoreRequiered = False
        Me.xtxt_campo1.Location = New System.Drawing.Point(88, 40)
        Me.xtxt_campo1.Name = "xtxt_campo1"
        Me.xtxt_campo1.NewInitialValue = Nothing
        Me.xtxt_campo1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_campo1.Requiered = False
        Me.xtxt_campo1.Size = New System.Drawing.Size(312, 20)
        Me.xtxt_campo1.StatusBarPanelDescripcion = Nothing
        Me.xtxt_campo1.TabIndex = 0
        Me.xtxt_campo1.Text = ""
        '
        'xtxt_campo2
        '
        Me.xtxt_campo2.DataBindings.Add("Text", Me.LibXConnector1, "cjtranrm.balance")
        Me.xtxt_campo2.EditInitialValue = Nothing
        Me.xtxt_campo2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_campo2.FieldDescription = ""
        Me.xtxt_campo2.FindInitialValue = Nothing
        Me.xtxt_campo2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_campo2.IgnoreRequiered = False
        Me.xtxt_campo2.Location = New System.Drawing.Point(88, 64)
        Me.xtxt_campo2.Name = "xtxt_campo2"
        Me.xtxt_campo2.NewInitialValue = Nothing
        Me.xtxt_campo2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_campo2.Requiered = False
        Me.xtxt_campo2.StatusBarPanelDescripcion = Nothing
        Me.xtxt_campo2.TabIndex = 1
        Me.xtxt_campo2.Text = ""
        '
        'xtxt_campo3
        '
        Me.xtxt_campo3.DataBindings.Add("Text", Me.LibXConnector1, "cjtranrm.credit_limit")
        Me.xtxt_campo3.EditInitialValue = Nothing
        Me.xtxt_campo3.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_campo3.FieldDescription = ""
        Me.xtxt_campo3.FindInitialValue = Nothing
        Me.xtxt_campo3.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_campo3.IgnoreRequiered = False
        Me.xtxt_campo3.Location = New System.Drawing.Point(296, 64)
        Me.xtxt_campo3.Name = "xtxt_campo3"
        Me.xtxt_campo3.NewInitialValue = Nothing
        Me.xtxt_campo3.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_campo3.Requiered = False
        Me.xtxt_campo3.Size = New System.Drawing.Size(104, 20)
        Me.xtxt_campo3.StatusBarPanelDescripcion = Nothing
        Me.xtxt_campo3.TabIndex = 3
        Me.xtxt_campo3.Text = ""
        '
        'xtxt_campo4
        '

        Me.xtxt_campo4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "cjtranrm.cust_code"))
        Me.xtxt_campo4.EditInitialValue = Nothing
        Me.xtxt_campo4.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_campo4.FieldDescription = ""
        Me.xtxt_campo4.FindInitialValue = Nothing
        Me.xtxt_campo4.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_campo4.IgnoreRequiered = False
        Me.xtxt_campo4.Location = New System.Drawing.Point(88, 88)
        Me.xtxt_campo4.Name = "xtxt_campo4"
        Me.xtxt_campo4.NewInitialValue = Nothing
        Me.xtxt_campo4.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxt_campo4.Requiered = False
        Me.xtxt_campo4.StatusBarPanelDescripcion = Nothing
        Me.xtxt_campo4.TabIndex = 2
        Me.xtxt_campo4.Text = ""
        '
        'xcbo_campo1
        '
        Me.xcbo_campo1.DataBindings.Add("SelectedValue", Me.LibXConnector1, "cjtranrm.csttype_code")
        Me.xcbo_campo1.AllowDefaultSort = True
        Me.xcbo_campo1.bound = True
        Me.xcbo_campo1.currValue = Nothing
        Me.xcbo_campo1.DefaultWhereString = Nothing
        Me.xcbo_campo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_campo1.EditInitialValue = Nothing
        Me.xcbo_campo1.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_campo1.FieldDescription = ""
        Me.xcbo_campo1.FindInitialValue = Nothing
        Me.xcbo_campo1.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_campo1.IgnoreRequiered = False
        Me.xcbo_campo1.Location = New System.Drawing.Point(88, 16)
        Me.xcbo_campo1.LookupKeyDisplayFields = "csttype_name"
        Me.xcbo_campo1.LookupKeyField = "csttype_code"
        Me.xcbo_campo1.LookupTableName = "cccsttpm"
        Me.xcbo_campo1.Name = "xcbo_campo1"
        Me.xcbo_campo1.NewInitialValue = Nothing
        Me.xcbo_campo1.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_campo1.Requiered = False
        Me.xcbo_campo1.Required = False
        Me.xcbo_campo1.Size = New System.Drawing.Size(312, 21)
        Me.xcbo_campo1.SqlString = Nothing
        Me.xcbo_campo1.StatusBarPanelDescripcion = Nothing
        Me.xcbo_campo1.TabIndex = 4
        '
        'xcbo_campo2
        '
        Me.xcbo_campo2.DataBindings.Add("SelectedValue", Me.LibXConnector1, "cjtranrm.cust_status")
        Me.xcbo_campo2.AllowDefaultSort = True
        Me.xcbo_campo2.bound = True
        Me.xcbo_campo2.currValue = Nothing
        Me.xcbo_campo2.DefaultWhereString = Nothing
        Me.xcbo_campo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_campo2.EditInitialValue = Nothing
        Me.xcbo_campo2.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_campo2.FieldDescription = ""
        Me.xcbo_campo2.FindInitialValue = Nothing
        Me.xcbo_campo2.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_campo2.IgnoreRequiered = False
        Me.xcbo_campo2.Items.AddRange(New Object() {"1-Activo", "0-Inactivo"})
        Me.xcbo_campo2.Location = New System.Drawing.Point(296, 88)
        Me.xcbo_campo2.LookupKeyDisplayFields = Nothing
        Me.xcbo_campo2.LookupKeyField = Nothing
        Me.xcbo_campo2.LookupTableName = Nothing
        Me.xcbo_campo2.Name = "xcbo_campo2"
        Me.xcbo_campo2.NewInitialValue = Nothing
        Me.xcbo_campo2.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_campo2.Requiered = False
        Me.xcbo_campo2.Required = False
        Me.xcbo_campo2.Size = New System.Drawing.Size(104, 21)
        Me.xcbo_campo2.SqlString = Nothing
        Me.xcbo_campo2.StatusBarPanelDescripcion = Nothing
        Me.xcbo_campo2.TabIndex = 5
        '
        'lbl_label1
        '
        Me.lbl_label1.AutoSize = True
        Me.lbl_label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lbl_label1.Location = New System.Drawing.Point(48, 16)
        Me.lbl_label1.Name = "lbl_label1"
        Me.lbl_label1.Size = New System.Drawing.Size(29, 16)
        Me.lbl_label1.TabIndex = 9
        Me.lbl_label1.Text = "Tipo:"
        Me.lbl_label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_label2
        '
        Me.lbl_label2.AutoSize = True
        Me.lbl_label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lbl_label2.Location = New System.Drawing.Point(34, 40)
        Me.lbl_label2.Name = "lbl_label2"
        Me.lbl_label2.Size = New System.Drawing.Size(43, 16)
        Me.lbl_label2.TabIndex = 7
        Me.lbl_label2.Text = "Cliente:"
        Me.lbl_label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_label3
        '
        Me.lbl_label3.AutoSize = True
        Me.lbl_label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lbl_label3.Location = New System.Drawing.Point(29, 64)
        Me.lbl_label3.Name = "lbl_label3"
        Me.lbl_label3.Size = New System.Drawing.Size(48, 16)
        Me.lbl_label3.TabIndex = 6
        Me.lbl_label3.Text = "Balance:"
        Me.lbl_label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_label4
        '
        Me.lbl_label4.AutoSize = True
        Me.lbl_label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lbl_label4.Location = New System.Drawing.Point(208, 64)
        Me.lbl_label4.Name = "lbl_label4"
        Me.lbl_label4.Size = New System.Drawing.Size(77, 16)
        Me.lbl_label4.TabIndex = 8
        Me.lbl_label4.Text = "Limite Crédito:"
        Me.lbl_label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_label5
        '
        Me.lbl_label5.AutoSize = True
        Me.lbl_label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lbl_label5.Location = New System.Drawing.Point(38, 88)
        Me.lbl_label5.Name = "lbl_label5"
        Me.lbl_label5.Size = New System.Drawing.Size(39, 16)
        Me.lbl_label5.TabIndex = 11
        Me.lbl_label5.Text = "Codigo:"
        Me.lbl_label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_label6
        '
        Me.lbl_label6.AutoSize = True
        Me.lbl_label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lbl_label6.Location = New System.Drawing.Point(242, 88)
        Me.lbl_label6.Name = "lbl_label6"
        Me.lbl_label6.Size = New System.Drawing.Size(45, 16)
        Me.lbl_label6.TabIndex = 10
        Me.lbl_label6.Text = "Estatus:"
        Me.lbl_label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.xtxt_campo1)
        Me.GroupBox1.Controls.Add(Me.xtxt_campo2)
        Me.GroupBox1.Controls.Add(Me.xtxt_campo4)
        Me.GroupBox1.Controls.Add(Me.xtxt_campo3)
        Me.GroupBox1.Controls.Add(Me.xcbo_campo1)
        Me.GroupBox1.Controls.Add(Me.xcbo_campo2)
        Me.GroupBox1.Controls.Add(Me.lbl_label3)
        Me.GroupBox1.Controls.Add(Me.lbl_label2)
        Me.GroupBox1.Controls.Add(Me.lbl_label4)
        Me.GroupBox1.Controls.Add(Me.lbl_label1)
        Me.GroupBox1.Controls.Add(Me.lbl_label6)
        Me.GroupBox1.Controls.Add(Me.lbl_label5)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(8, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(408, 216)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False

        Me.xcbo_campo1.LoadDbItems(True)
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub LibXConnector1_ExecutingAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutingAction
        Try
            Select Case LibXConnector1.Parameters.Value
                Case "EFE"
                    Exit Sub
                Case "TAR"
                    LBL_Title.Text = "PAGO CON TARJETA"
                    CrearTAR()
                Case "CXC"
                    LBL_Title.Text = "PAGO A CREDITO"
                    CrearCXC()
                Case "CHK"
                    LBL_Title.Text = "PAGO CON CHEQUE"
                    CrearCHK()
                Case "NC"
                    LBL_Title.Text = "PAGO CON NOTA DE CREDITO"
                    CrearNCR()
            End Select
        Catch ex As Exception
            LibX.Log.Add(ex, True)
        End Try

    End Sub

    Private Sub c_cjpaym01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.xcbo_campo1.LoadDbItems(True)
        Me.xcbo_campo2.LoadDbItems(True)
    End Sub

End Class
