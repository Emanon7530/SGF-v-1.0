Public Class i_pvmensj01
    Inherits System.Windows.Forms.Form
    Public mMensajero As SGT.Caja.Entidades.Cajera

    Public mSerial As Integer

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
Friend WithEvents xcbo_vend_mensj As LibX.LibXCombo
Friend WithEvents btnCancel As System.Windows.Forms.Button
Friend WithEvents btnAccept As System.Windows.Forms.Button
Friend WithEvents Label1 As System.Windows.Forms.Label
Friend WithEvents LibXConnector1 As LibX.LibXConnector
Friend WithEvents DataSet1 As System.Data.DataSet
Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
Friend WithEvents DataTable1 As System.Data.DataTable
Friend WithEvents DataColumn1 As System.Data.DataColumn
Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(i_pvmensj01))
        Me.xcbo_vend_mensj = New LibX.LibXCombo
        Me.DataSet1 = New System.Data.DataSet
        Me.DataTable1 = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnAccept = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'xcbo_vend_mensj
        '
        Me.xcbo_vend_mensj.AllowDefaultSort = False
        Me.xcbo_vend_mensj.bound = True
        Me.xcbo_vend_mensj.currValue = Nothing
        Me.xcbo_vend_mensj.DefaultWhereString = "vend_cargo = 3 and vend_estatus = 1"
        Me.xcbo_vend_mensj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xcbo_vend_mensj.EditInitialValue = Nothing
        Me.xcbo_vend_mensj.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_vend_mensj.FieldDescription = ""
        Me.xcbo_vend_mensj.FindInitialValue = Nothing
        Me.xcbo_vend_mensj.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_vend_mensj.IgnoreRequiered = False
        Me.xcbo_vend_mensj.Location = New System.Drawing.Point(136, 32)
        Me.xcbo_vend_mensj.LookupKeyDisplayFields = "vend_name"
        Me.xcbo_vend_mensj.LookupKeyField = "vend_code"
        Me.xcbo_vend_mensj.LookupTableName = "ftvendm"
        Me.xcbo_vend_mensj.Name = "xcbo_vend_mensj"
        Me.xcbo_vend_mensj.NewInitialValue = Nothing
        Me.xcbo_vend_mensj.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xcbo_vend_mensj.Requiered = False
        Me.xcbo_vend_mensj.Required = False
        Me.xcbo_vend_mensj.Size = New System.Drawing.Size(248, 21)
        Me.xcbo_vend_mensj.SqlString = Nothing
        Me.xcbo_vend_mensj.StatusBarPanelDescripcion = Nothing
        Me.xcbo_vend_mensj.TabIndex = 28
        '
        'DataSet1
        '
        Me.LibXConnector1.SetDataGenerator(Me.DataSet1, Me.LibXConnector1)
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, False)
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2})
        Me.DataTable1.TableName = "ftfactm"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.AutoIncrement = True
        Me.DataColumn1.ColumnName = "ftserial_no"
        Me.DataColumn1.DataType = GetType(System.Int32)
        Me.DataColumn1.ReadOnly = True
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "vend_mensaj"
        Me.DataColumn2.DataType = GetType(System.Int32)
        '
        'btnCancel
        '
        Me.btnCancel.CausesValidation = False
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(296, 56)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 23)
        Me.btnCancel.TabIndex = 30
        Me.btnCancel.Text = "Cancelar"
        '
        'btnAccept
        '
        Me.btnAccept.Location = New System.Drawing.Point(216, 56)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.TabIndex = 29
        Me.btnAccept.Text = "Aceptar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(136, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 16)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Identificacion de mensajero"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.LibXDbSourceTable1.Source = New String() {"select ftfactm.ftserial_no,vend_mensaj from ftfactm,ftdomim ", "where ftfactm.ftserial_no=ftdomim.ftserial_no"}
        Me.LibXDbSourceTable1.TableName = "ftfactm"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 96)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'i_pvmensj01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(392, 102)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAccept)
        Me.Controls.Add(Me.xcbo_vend_mensj)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "i_pvmensj01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Identificasion de mensajero"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
Private Function ValidaMensajero() As Boolean
    Dim SelectStmt As String
    Dim oRow As DataRow
    Try
        mMensajero.Code = Val(Me.xcbo_vend_mensj.currValue)
        If mMensajero.Load() = False Then
            Return False
        End If
        If mMensajero.Cargo = SGT.Caja.Entidades.TipoUsuarioEnum.Mensajero Then
            Return True
        End If

        Return True

    Catch ex As Exception
        Throw

    End Try
End Function

Public Overloads Function ShowDialog(ByVal oMesajser As Integer) As DialogResult
        xcbo_vend_mensj.LoadDbItems(True)
        mSerial = oMesajser
    Return MyBase.ShowDialog
End Function

Private Sub btnAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccept.Click
        Try
            If LibX.IsNull(xcbo_vend_mensj.SelectedValue) = True Then
                Throw New ApplicationException("Debe Indicar un mensajero antes!")
            End If
            If LibX.IsNull(xcbo_vend_mensj.SelectedValue) = False Then
                Dim xUpdate As LibX.Data.XUpdateStmt
                xUpdate = New LibX.Data.XUpdateStmt("ftdomim")

                xUpdate.FieldsSet("vend_mensaj") = xcbo_vend_mensj.SelectedValue
                xUpdate.Fields("ftserial_no") = mSerial
                xUpdate.Execute()
            End If

            Me.DialogResult = DialogResult.Yes
            Me.Close()
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
End Sub

Private Sub i_ptvvend01_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
    Try
            If e.KeyCode = Keys.F5 Then
                btnAccept_Click(sender, e)
                If LibX.IsNull(xcbo_vend_mensj.SelectedValue) = True Then
                    xcbo_vend_mensj.Focus()
                    Throw New ApplicationException("Debe especificar el Mensajero")
                End If
                If LibX.IsNull(xcbo_vend_mensj.SelectedValue) = False Then
                    Dim xUpdate As LibX.Data.XUpdateStmt
                    xUpdate = New LibX.Data.XUpdateStmt("ftdomim")

                    xUpdate.FieldsSet("vend_mensaj") = xcbo_vend_mensj.SelectedValue
                    xUpdate.Fields("ftserial_no") = mSerial
                    xUpdate.Execute()
                End If

                Me.DialogResult = DialogResult.Yes
                Me.Close()
            End If
        Catch ex As Exception
        LibX.Log.Show(ex)
    End Try
End Sub

    Private Sub xtxtVend_code_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles xcbo_vend_mensj.Validating
        Try
            If Me.xcbo_vend_mensj.Text.Length <= 0 Then
                xcbo_vend_mensj.Focus()
                ''Throw New ApplicationException("Debe especificar el Mensajero")
            End If
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub
    Private Sub i_pvmensj01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        xcbo_vend_mensj.LoadDbItems(True)
    End Sub
End Class
