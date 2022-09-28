Public Class i_ivcobm01
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
    'Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents TextBox3 As LibX.XTextBox
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents LibXNavigator1 As LibX.LibXNavigator
    Friend WithEvents LabelProducto As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LibXLookup2 As LibX.LibXLookup
    Friend WithEvents LabelUnit As System.Windows.Forms.Label
    Friend WithEvents xlk_item_code As LibX.LibXLookup
    Friend WithEvents txtItemCode As LibX.XTextBox
    Friend WithEvents TextBoxunit_code As LibX.XTextBox
    Friend WithEvents Barcode1 As IDAutomation.Windows.Forms.LinearBarCode.Barcode
    Friend WithEvents lblfactor As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LibXLookup2 = New LibX.LibXLookup
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.LabelUnit = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TextBoxunit_code = New LibX.XTextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.xlk_item_code = New LibX.LibXLookup
        Me.LabelProducto = New System.Windows.Forms.Label
        Me.TextBox3 = New LibX.XTextBox
        Me.txtItemCode = New LibX.XTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.LibXNavigator1 = New LibX.LibXNavigator
        Me.Barcode1 = New IDAutomation.Windows.Forms.LinearBarCode.Barcode
        Me.lblfactor = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblfactor)
        Me.GroupBox1.Controls.Add(Me.Barcode1)
        Me.GroupBox1.Controls.Add(Me.LibXLookup2)
        Me.GroupBox1.Controls.Add(Me.LabelUnit)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBoxunit_code)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.xlk_item_code)
        Me.GroupBox1.Controls.Add(Me.LabelProducto)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.txtItemCode)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(672, 200)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'LibXLookup2
        '
        Me.LibXLookup2.AlternateFieldSearch = Nothing
        Me.LibXLookup2.BeginCheck = False
        Me.LibXLookup2.CheckText = Nothing
        Me.LibXLookup2.ComboMode = False
        Me.LibXLookup2.DataMember = Nothing
        Me.LibXLookup2.DataSource = Me.LibXConnector1
        Me.LibXLookup2.DestParameters = New String() {"unit_code=unit_code", "LabelUnit=unit_name", "lblFactor=factor"}
        Me.LibXLookup2.FilterField = Nothing
        Me.LibXLookup2.IgnoreFindInBrowseMode = False
        Me.LibXLookup2.isCanceled = False
        Me.LibXLookup2.Location = New System.Drawing.Point(536, 48)
        Me.LibXLookup2.LookCaption = "Unidades de Medida"
        Me.LibXLookup2.Name = "LibXLookup2"
        Me.LibXLookup2.PopupSize = New System.Drawing.Size(0, 0)
        Me.LibXLookup2.ShowFilter = True
        Me.LibXLookup2.ShowMessageNotFound = True
        Me.LibXLookup2.ShowWarning = False
        Me.LibXLookup2.Size = New System.Drawing.Size(16, 20)
        Me.LibXLookup2.SizesColumns = New String() {"unit_code=25", "unit_name=200", "factor=25"}
        Me.LibXLookup2.SizesColumnsTab = Nothing
        Me.LibXLookup2.SqlString = Nothing
        Me.LibXLookup2.SQLTab = Nothing
        Me.LibXLookup2.SrcParameters = New String() {"unit_code=unit_code"}
        Me.LibXLookup2.TabIndex = 13
        Me.LibXLookup2.TableName = "ivunitm"
        Me.LibXLookup2.TabStop = False
        Me.LibXLookup2.UseCopyConnection = False
        Me.LibXLookup2.UseRowRetrieveEvents = False
        Me.LibXLookup2.UseTab = False
        Me.LibXLookup2.VisParameters = New String() {"Código=unit_code", "Descripción=unit_name", "Factor=factor"}
        Me.LibXLookup2.WhereCondition = Nothing
        Me.LibXLookup2.WhereParameters = Nothing
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
        Me.LibXConnector1.DataMember = Nothing
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
        Me.LibXDbSourceTable1.Source = Nothing
        Me.LibXDbSourceTable1.TableName = "ivcbarram"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
        '
        'LabelUnit
        '
        Me.LabelUnit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelUnit.Location = New System.Drawing.Point(232, 48)
        Me.LabelUnit.Name = "LabelUnit"
        Me.LabelUnit.Size = New System.Drawing.Size(248, 20)
        Me.LabelUnit.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(16, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Unidad:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBoxunit_code
        '
        Me.TextBoxunit_code.AcceptsReturn = True
        Me.TextBoxunit_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "ivcbarram.unit_code"))
        Me.TextBoxunit_code.EditInitialValue = Nothing
        Me.TextBoxunit_code.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBoxunit_code.FieldDescription = ""
        Me.TextBoxunit_code.FindInitialValue = Nothing
        Me.TextBoxunit_code.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBoxunit_code.IgnoreRequiered = False
        Me.TextBoxunit_code.Location = New System.Drawing.Point(128, 48)
        Me.TextBoxunit_code.Name = "TextBoxunit_code"
        Me.TextBoxunit_code.NewInitialValue = Nothing
        Me.TextBoxunit_code.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBoxunit_code.Requiered = False
        Me.TextBoxunit_code.Size = New System.Drawing.Size(96, 20)
        Me.TextBoxunit_code.StatusBarPanelDescripcion = Nothing
        Me.TextBoxunit_code.TabIndex = 1
        Me.TextBoxunit_code.Text = ""
        '
        'Label2
        '
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(16, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 0)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Cantidad:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xlk_item_code
        '
        Me.xlk_item_code.AlternateFieldSearch = Nothing
        Me.xlk_item_code.BeginCheck = False
        Me.xlk_item_code.CheckText = Nothing
        Me.xlk_item_code.ComboMode = False
        Me.xlk_item_code.DataMember = Nothing
        Me.xlk_item_code.DataSource = Me.LibXConnector1
        Me.xlk_item_code.DestParameters = New String() {"item_code=item_code", "LabelProducto=item_name"}
        Me.xlk_item_code.FilterField = Nothing
        Me.xlk_item_code.IgnoreFindInBrowseMode = False
        Me.xlk_item_code.isCanceled = False
        Me.xlk_item_code.Location = New System.Drawing.Point(536, 24)
        Me.xlk_item_code.LookCaption = Nothing
        Me.xlk_item_code.Name = "xlk_item_code"
        Me.xlk_item_code.PopupSize = New System.Drawing.Size(0, 0)
        Me.xlk_item_code.ShowFilter = True
        Me.xlk_item_code.ShowMessageNotFound = True
        Me.xlk_item_code.ShowWarning = False
        Me.xlk_item_code.Size = New System.Drawing.Size(16, 20)
        Me.xlk_item_code.SizesColumns = Nothing
        Me.xlk_item_code.SizesColumnsTab = Nothing
        Me.xlk_item_code.SqlString = Nothing
        Me.xlk_item_code.SQLTab = Nothing
        Me.xlk_item_code.SrcParameters = New String() {"item_code=item_code"}
        Me.xlk_item_code.TabIndex = 6
        Me.xlk_item_code.TableName = "ivitemm"
        Me.xlk_item_code.TabStop = False
        Me.xlk_item_code.UseCopyConnection = False
        Me.xlk_item_code.UseRowRetrieveEvents = False
        Me.xlk_item_code.UseTab = False
        Me.xlk_item_code.VisParameters = New String() {"Código=item_code", "Nombre=item_name"}
        Me.xlk_item_code.WhereCondition = Nothing
        Me.xlk_item_code.WhereParameters = Nothing
        '
        'LabelProducto
        '
        Me.LabelProducto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelProducto.Location = New System.Drawing.Point(232, 24)
        Me.LabelProducto.Name = "LabelProducto"
        Me.LabelProducto.Size = New System.Drawing.Size(304, 20)
        Me.LabelProducto.TabIndex = 5
        '
        'TextBox3
        '
        Me.TextBox3.AcceptsReturn = True
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "ivcbarram.barra"))
        Me.TextBox3.EditInitialValue = Nothing
        Me.TextBox3.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox3.FieldDescription = ""
        Me.TextBox3.FindInitialValue = Nothing
        Me.TextBox3.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox3.IgnoreRequiered = False
        Me.TextBox3.Location = New System.Drawing.Point(128, 72)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.NewInitialValue = Nothing
        Me.TextBox3.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.TextBox3.Requiered = False
        Me.TextBox3.Size = New System.Drawing.Size(96, 20)
        Me.TextBox3.StatusBarPanelDescripcion = Nothing
        Me.TextBox3.TabIndex = 2
        Me.TextBox3.Text = ""
        '
        'txtItemCode
        '
        Me.txtItemCode.AcceptsReturn = True
        Me.txtItemCode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "ivcbarram.item_code"))
        Me.txtItemCode.EditInitialValue = Nothing
        Me.txtItemCode.EditState = LibX.IEditProperty.InitialStateEnum.Disabled
        Me.txtItemCode.FieldDescription = ""
        Me.txtItemCode.FindInitialValue = Nothing
        Me.txtItemCode.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtItemCode.IgnoreRequiered = False
        Me.txtItemCode.Location = New System.Drawing.Point(128, 24)
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.NewInitialValue = Nothing
        Me.txtItemCode.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.txtItemCode.Requiered = False
        Me.txtItemCode.Size = New System.Drawing.Size(96, 20)
        Me.txtItemCode.StatusBarPanelDescripcion = Nothing
        Me.txtItemCode.TabIndex = 0
        Me.txtItemCode.Text = ""
        '
        'Label1
        '
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código Producto:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(16, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Codigo Barra:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LibXNavigator1
        '
        Me.LibXNavigator1.BuildMenu = True
        Me.LibXNavigator1.Connector = Me.LibXConnector1
        Me.LibXNavigator1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LibXNavigator1.FirstControlInEditMode = Me.TextBoxunit_code
        Me.LibXNavigator1.FirstControlInFindMode = Me.txtItemCode
        Me.LibXNavigator1.FirstControlInNewMode = Me.txtItemCode
        Me.LibXNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.LibXNavigator1.Name = "LibXNavigator1"
        Me.LibXNavigator1.Size = New System.Drawing.Size(690, 24)
        Me.LibXNavigator1.TabIndex = 0
        '
        'Barcode1
        '
        Me.Barcode1.ApplyTilde = True
        Me.Barcode1.BarHeightCM = 1.0!
        Me.Barcode1.BearerBarHorizontal = 0
        Me.Barcode1.BearerBarVertical = 0
        Me.Barcode1.CaptionAbove = ""
        Me.Barcode1.CaptionBelow = ""
        Me.Barcode1.CaptionBottomAlignment = System.Drawing.StringAlignment.Center
        Me.Barcode1.CaptionBottomColor = System.Drawing.Color.Black
        Me.Barcode1.CaptionBottomSpace = 0.1!
        Me.Barcode1.CaptionFontAbove = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Barcode1.CaptionFontBelow = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Barcode1.CaptionTopAlignment = System.Drawing.StringAlignment.Center
        Me.Barcode1.CaptionTopColor = System.Drawing.Color.Black
        Me.Barcode1.CaptionTopSpace = 0.1!
        Me.Barcode1.CharacterGrouping = 0
        Me.Barcode1.CheckCharacter = False
        Me.Barcode1.CheckCharacterInText = True
        Me.Barcode1.CODABARStartChar = "A"
        Me.Barcode1.CODABARStopChar = "B"
        Me.Barcode1.Code128Set = IDAutomation.Windows.Forms.LinearBarCode.Code128CharacterSets.Auto
        Me.Barcode1.DataToEncode = "12345678"
        Me.Barcode1.DoPaint = True
        Me.Barcode1.FitControlToBarcode = True
        Me.Barcode1.LeftMarginCM = 0.2!
        Me.Barcode1.Location = New System.Drawing.Point(232, 72)
        Me.Barcode1.Name = "Barcode1"
        Me.Barcode1.NarrowToWideRatio = 2.0!
        Me.Barcode1.OneBitPerPixelImage = False
        Me.Barcode1.PostnetHeightShort = 0.127!
        Me.Barcode1.PostnetHeightTall = 0.3226!
        Me.Barcode1.PostnetSpacing = 0.065!
        Me.Barcode1.Resolution = IDAutomation.Windows.Forms.LinearBarCode.Resolutions.Printer
        Me.Barcode1.ResolutionCustomDPI = -2.0!
        Me.Barcode1.ResolutionPrinterToUse = ""
        Me.Barcode1.RotationAngle = IDAutomation.Windows.Forms.LinearBarCode.RotationAngles.Zero_Degrees
        Me.Barcode1.ShowText = True
        Me.Barcode1.ShowTextLocation = IDAutomation.Windows.Forms.LinearBarCode.HRTextPositions.Bottom
        Me.Barcode1.Size = New System.Drawing.Size(145, 74)
        Me.Barcode1.SuppSeparationCM = 0.5!
        Me.Barcode1.SymbologyID = IDAutomation.Windows.Forms.LinearBarCode.Symbologies.Code39
        Me.Barcode1.TabIndex = 14
        Me.Barcode1.TextFontColor = System.Drawing.Color.Black
        Me.Barcode1.TextMarginCM = 0.1!
        Me.Barcode1.TopMarginCM = 0.2!
        Me.Barcode1.UPCESystem = "0"
        Me.Barcode1.WhiteBarIncrease = 0.0!
        Me.Barcode1.XDimensionCM = 0.0299!
        Me.Barcode1.XDimensionMILS = 0.0761!
        '
        'lblfactor
        '
        Me.lblfactor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblfactor.Location = New System.Drawing.Point(488, 48)
        Me.lblfactor.Name = "lblfactor"
        Me.lblfactor.Size = New System.Drawing.Size(44, 20)
        Me.lblfactor.TabIndex = 15
        '
        'i_ivcobm01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(690, 248)
        Me.Controls.Add(Me.LibXNavigator1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "i_ivcobm01"
        Me.Text = "Codigo Barra"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub LibXConnector1_SettingDefaultNewValues(ByVal sender As Object, ByVal e As LibX.SettingDefaultNewValues) Handles LibXConnector1.SettingDefaultNewValues
        If Not LibXConnector1.Parameters Is Nothing Then
            Me.txtItemCode.Text = LibXConnector1.Parameters.Value
            Me.xlk_item_code.ExecuteFind()
        End If
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        Barcode1.DataToEncode = TextBox3.Text
    End Sub
End Class
