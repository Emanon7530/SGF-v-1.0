Imports LibX
Public Class i_ftcustm01
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
    Friend WithEvents btnAccept As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtCompany As System.Windows.Forms.TextBox
    Friend WithEvents txtContacto As System.Windows.Forms.TextBox
    Friend WithEvents txtTelArea As System.Windows.Forms.TextBox
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents LibXDbSourceTable2 As LibX.LibXDbSourceTable
    Friend WithEvents txtPhone1 As System.Windows.Forms.TextBox
    Friend WithEvents xlk_phone As LibX.LibXLookup
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtPhone1 = New System.Windows.Forms.TextBox
        Me.xlk_phone = New LibX.LibXLookup
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.LibXDbSourceTable2 = New LibX.LibXDbSourceTable
        Me.txtCompany = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtContacto = New System.Windows.Forms.TextBox
        Me.txtTelArea = New System.Windows.Forms.TextBox
        Me.txtTel = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnAccept = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.GroupBox1.SuspendLayout()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtPhone1)
        Me.GroupBox1.Controls.Add(Me.xlk_phone)
        Me.GroupBox1.Controls.Add(Me.txtCompany)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtContacto)
        Me.GroupBox1.Controls.Add(Me.txtTelArea)
        Me.GroupBox1.Controls.Add(Me.txtTel)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(480, 120)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtPhone1
        '
        Me.txtPhone1.Enabled = False
        Me.txtPhone1.Location = New System.Drawing.Point(200, 88)
        Me.txtPhone1.Name = "txtPhone1"
        Me.txtPhone1.Size = New System.Drawing.Size(112, 20)
        Me.txtPhone1.TabIndex = 5
        Me.txtPhone1.TabStop = False
        Me.txtPhone1.Text = ""
        '
        'xlk_phone
        '
        Me.xlk_phone.DataMember = Nothing
        Me.xlk_phone.DataSource = Me.LibXConnector1
        Me.xlk_phone.DestParameters = New String() {"txtPhone1=phone"}
        Me.xlk_phone.FilterField = Nothing
        Me.xlk_phone.IgnoreFindInBrowseMode = False
        Me.xlk_phone.Location = New System.Drawing.Point(248, 16)
        Me.xlk_phone.LookCaption = Nothing
        Me.xlk_phone.Name = "xlk_phone"
        Me.xlk_phone.Size = New System.Drawing.Size(16, 20)
        Me.xlk_phone.SqlString = Nothing
        Me.xlk_phone.SrcParameters = New String() {"txtPhone1=phone"}
        Me.xlk_phone.TabIndex = 4
        Me.xlk_phone.TableName = "ftcustm"
        Me.xlk_phone.UseCopyConnection = False
        Me.xlk_phone.UseRowRetrieveEvents = False
        Me.xlk_phone.VisParameters = New String() {"Teléfono=phone", "Company=company_name", "Nombre=cust_name", ""}
        Me.xlk_phone.WhereCondition = Nothing
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
        Me.LibXConnector1.HandledUpdates = True
        Me.LibXConnector1.HasRecords = False
        Me.LibXConnector1.IsEditing = False
        Me.LibXConnector1.IsHeaderOnGrid = False
        Me.LibXConnector1.OwnerForm = Me
        Me.LibXConnector1.Parameters = Nothing
        Me.LibXConnector1.RecordCount = 0
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.LibXDbSourceTable2})
        Me.LibXConnector1.State = LibX.LibxConnectorState.none
        Me.LibXConnector1.UpdatePrimaryKeyColumns = False
        Me.LibXConnector1.UseTransactions = False
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
        Me.LibXDbSourceTable2.InsertOrder = 0
        Me.LibXDbSourceTable2.IsDetail = False
        Me.LibXDbSourceTable2.KeyFields = Nothing
        Me.LibXDbSourceTable2.MasterDetailRelation = Nothing
        Me.LibXDbSourceTable2.MasterTableName = Nothing
        Me.LibXDbSourceTable2.SerialColumnName = Nothing
        Me.LibXDbSourceTable2.Sort = Nothing
        Me.LibXDbSourceTable2.Source = Nothing
        Me.LibXDbSourceTable2.TableName = "ftcustm"
        Me.LibXDbSourceTable2.UpdateOrder = 0
        Me.LibXDbSourceTable2.UseRowRetrieve = False
        '
        'txtCompany
        '
        Me.txtCompany.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCompany.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "ftcustm.company_name"))
        Me.txtCompany.Location = New System.Drawing.Point(144, 40)
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.Size = New System.Drawing.Size(288, 20)
        Me.txtCompany.TabIndex = 1
        Me.txtCompany.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(29, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Compañía Nombre:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(81, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Contacto"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(80, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Telefono:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtContacto
        '
        Me.txtContacto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtContacto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "ftcustm.cust_name"))
        Me.txtContacto.Location = New System.Drawing.Point(144, 64)
        Me.txtContacto.Name = "txtContacto"
        Me.txtContacto.Size = New System.Drawing.Size(288, 20)
        Me.txtContacto.TabIndex = 2
        Me.txtContacto.Text = ""
        '
        'txtTelArea
        '
        Me.txtTelArea.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTelArea.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "ftcustm.area_code"))
        Me.txtTelArea.Location = New System.Drawing.Point(144, 88)
        Me.txtTelArea.Name = "txtTelArea"
        Me.txtTelArea.Size = New System.Drawing.Size(48, 20)
        Me.txtTelArea.TabIndex = 3
        Me.txtTelArea.Text = ""
        '
        'txtTel
        '
        Me.txtTel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibXConnector1, "ftcustm.phone"))
        Me.txtTel.Location = New System.Drawing.Point(144, 16)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(104, 20)
        Me.txtTel.TabIndex = 0
        Me.txtTel.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(100, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Area:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnAccept
        '
        Me.btnAccept.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAccept.Location = New System.Drawing.Point(336, 136)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.TabIndex = 1
        Me.btnAccept.Text = "Aceptar"
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(416, 136)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancelar"
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
        Me.LibXDbSourceTable1.InsertOrder = 0
        Me.LibXDbSourceTable1.IsDetail = False
        Me.LibXDbSourceTable1.KeyFields = Nothing
        Me.LibXDbSourceTable1.MasterDetailRelation = Nothing
        Me.LibXDbSourceTable1.MasterTableName = Nothing
        Me.LibXDbSourceTable1.SerialColumnName = Nothing
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = Nothing
        Me.LibXDbSourceTable1.TableName = "ftcustm"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
        '
        'i_ftcustm01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(498, 167)
        Me.Controls.Add(Me.btnAccept)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "i_ftcustm01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Clientes de contado"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Cli As New ClienteContado
    Public ok As Boolean



    Private Sub btnAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccept.Click
        Try

            If Me.txtTel.Text.Length <= 0 Then
                Throw New ApplicationException("Debe especificar un No. de teléfono!")
            End If

            If Me.txtCompany.Text.Length <= 0 And Me.txtContacto.Text.Length <= 0 Then
                Throw New ApplicationException("Debe especificar un nombre para identificarlo")
            End If

            Cli.Company = Me.txtCompany.Text
            Cli.Contacto = Me.txtContacto.Text
            Cli.Tel = Me.txtTel.Text
            Cli.TelArea = Me.txtTelArea.Text

            ok = True
            If Cli.Modalidad = LibxConnectorState.Insert Then
                LibXConnector1.AcceptNew()
            End If

            If Cli.Modalidad = LibxConnectorState.Insert Then
                LibXConnector1.AcceptEdit()
            End If

            Me.Close()

        Catch ex As Exception
            Log.Show(ex)
        End Try
    End Sub

    Private Sub i_ftcustm01_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            xlk_phone.ShowMessageNotFound = False

            If Cli.Modalidad = LibxConnectorState.Insert Then
                LibXConnector1.AddNew()
                xlk_phone.Enabled = True
            End If

            If Cli.Modalidad = LibxConnectorState.Edit Then
                LibXConnector1.ExecuteFind("ftserial_no = " & Cli.Serie.ToString)
                If LibXConnector1.HasRecords = True Then
                    LibXConnector1.Edit()
                    xlk_phone.Enabled = True
                End If
            End If

            If Cli.Modalidad = LibxConnectorState.View Then
                LibXConnector1.ExecuteFind("ftserial_no = " & Cli.Serie.ToString)
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub LibXConnector1_ExecutedAction(ByVal sender As Object, ByVal e As LibX.ExecutingActionEventArgs) Handles LibXConnector1.ExecutedAction
        Try
            If e.Action = LibxConnectionActions.Add Then
                If Cli.Company.Length > 0 Then
                    Me.txtCompany.Text = Cli.Company
                    Me.txtContacto.Text = Cli.Contacto
                    Me.txtTel.Text = Cli.Tel
                    Me.txtTelArea.Text = Cli.TelArea
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub LibXLookup1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xlk_phone.Load

    End Sub


    Private Sub LibXLookup1_AfterSetValues(ByVal sender As System.Object, ByVal e As LibX.LookupValuesEventArgs) Handles xlk_phone.AfterSetValues
        Try
            If e.dataFound = False Then
                Cli.Found = False
                e.handled = True
                Exit Sub
            End If
            Cli.Found = True
            Me.txtCompany.Text = e.row!company_name
            Me.txtContacto.Text = e.row!cust_name
            Me.txtTel.Text = e.row!phone
            Me.txtTelArea.Text = e.row!area_code

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub txtTel_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTel.TextChanged

    End Sub

    Private Sub txtTel_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTel.Leave
        Try
            If txtTel.Text.Length > 0 Then
                txtPhone1.Text = txtTel.Text
                xlk_phone.ExecuteFind()
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub xlk_phone_BeforeSetValues(ByVal sender As Object, ByVal e As LibX.LookupValuesEventArgs) Handles xlk_phone.BeforeSetValues
        If e.dataFound = False Then
            e.handled = True
            Exit Sub
        End If

    End Sub
End Class
