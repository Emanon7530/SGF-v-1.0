Public Class i_reloj
    Inherits System.Windows.Forms.Form
    Dim ScDefault As Integer
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
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents LibXDbSourceTable1 As LibX.LibXDbSourceTable
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents xtxbarra As LibX.XTextBox
    Friend WithEvents oCgxrelojcontrol As System.Data.DataTable
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.DataSet1 = New System.Data.DataSet
        Me.oCgxrelojcontrol = New System.Data.DataTable
        Me.DataColumn7 = New System.Data.DataColumn
        Me.DataColumn8 = New System.Data.DataColumn
        Me.DataColumn9 = New System.Data.DataColumn
        Me.DataColumn10 = New System.Data.DataColumn
        Me.DataColumn11 = New System.Data.DataColumn
        Me.LibXDbSourceTable1 = New LibX.LibXDbSourceTable
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.xtxbarra = New LibX.XTextBox
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.oCgxrelojcontrol, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.LibXConnector1.DataMember = "cgxrelojcontrol"
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
        Me.LibXConnector1.Sources.AddRange(New LibX.LibXDbSourceTable() {Me.LibXDbSourceTable1})
        Me.LibXConnector1.State = LibX.LibxConnectorState.none
        Me.LibXConnector1.UpdatePrimaryKeyColumns = False
        Me.LibXConnector1.UseTransactions = True
        '
        'DataSet1
        '
        Me.LibXConnector1.SetDataGenerator(Me.DataSet1, Me.LibXConnector1)
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.LibXConnector1.SetDefineAll(Me.DataSet1, True)
        Me.DataSet1.EnforceConstraints = False
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-DO")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.oCgxrelojcontrol})
        '
        'oCgxrelojcontrol
        '
        Me.oCgxrelojcontrol.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11})
        Me.oCgxrelojcontrol.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"reloj_id"}, True)})
        Me.oCgxrelojcontrol.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn7}
        Me.oCgxrelojcontrol.TableName = "cgxrelojcontrol"
        '
        'DataColumn7
        '
        Me.DataColumn7.AllowDBNull = False
        Me.DataColumn7.AutoIncrement = True
        Me.DataColumn7.ColumnName = "reloj_id"
        Me.DataColumn7.DataType = GetType(System.Int32)
        Me.DataColumn7.ReadOnly = True
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "suc_code"
        Me.DataColumn8.DataType = GetType(System.Int32)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "vend_code"
        Me.DataColumn9.DataType = GetType(System.Int32)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "fecha_reloj"
        Me.DataColumn10.DataType = GetType(System.DateTime)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "hora_reloj"
        Me.DataColumn11.DataType = GetType(System.DateTime)
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
        Me.LibXDbSourceTable1.SerialColumnName = "reloj_id"
        Me.LibXDbSourceTable1.Sort = Nothing
        Me.LibXDbSourceTable1.Source = Nothing
        Me.LibXDbSourceTable1.TableName = "cgxrelojcontrol"
        Me.LibXDbSourceTable1.UpdateOrder = 0
        Me.LibXDbSourceTable1.UseRowRetrieve = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.xtxbarra)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(488, 80)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'xtxbarra
        '
        Me.xtxbarra.AcceptsReturn = True
        Me.xtxbarra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xtxbarra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xtxbarra.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "cgxrelojcontrol.reloj_id"))
        Me.xtxbarra.EditInitialValue = Nothing
        Me.xtxbarra.EditState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxbarra.FieldDescription = ""
        Me.xtxbarra.FindInitialValue = Nothing
        Me.xtxbarra.FindState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxbarra.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.xtxbarra.IgnoreRequiered = False
        Me.xtxbarra.Location = New System.Drawing.Point(162, 24)
        Me.xtxbarra.Name = "xtxbarra"
        Me.xtxbarra.NewInitialValue = Nothing
        Me.xtxbarra.NewState = LibX.IEditProperty.InitialStateEnum.Enabled
        Me.xtxbarra.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.xtxbarra.Requiered = False
        Me.xtxbarra.Size = New System.Drawing.Size(184, 20)
        Me.xtxbarra.StatusBarPanelDescripcion = Nothing
        Me.xtxbarra.TabIndex = 0
        Me.xtxbarra.Text = ""
        '
        'i_reloj
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(512, 102)
        Me.Controls.Add(Me.GroupBox1)
        Me.Location = New System.Drawing.Point(100, 100)
        Me.Name = "i_reloj"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Control de Entrada y Salida"
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.oCgxrelojcontrol, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub xtxbarra_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles xtxbarra.KeyUp
        If e.KeyCode = Keys.Enter Then
            PuncHadera(xtxbarra.Text)
            Me.xtxbarra.Focus()
        End If
    End Sub
    Function PuncHadera(ByVal codigo As String) As Boolean
        Dim SelecStmt As String
        Dim fecha As Date
        SelecStmt = "select vend_code,cedula,vend_name,getdate(),getdate() from ftvendm where cedula = '" & codigo.ToString.Trim & "'"

        ''SelecStmt = LibX.MdlUtil.ConcatWherePart(SelecStmt, "")
        ''SelecStmt = SelecStmt & " order by ivitemm.item_code "
        oCgxrelojcontrol = LibX.Data.Manager.GetDataTable(SelecStmt)


        For Each oRow As DataRow In oCgxrelojcontrol.Rows
            Dim Reloj As DataRow = oCgxrelojcontrol.NewRow

            Reloj!suc_code = ScDefault
            Reloj!vend_code = oRow!vend_code
            Reloj!price = oRow!price
            Reloj!fecha_reloj = format(oRow!fecha_reloj,
            Reloj!costo2 = oRow!costo2
            Reloj!price2 = oRow!price2
            Reloj!unit_code = oRow!unit_code
            Reloj!prov_code = oRow!prov_code
            Reloj!group_code = oRow!group_code
            Reloj!sgroup_code = oRow!sgroup_code

            If Reloj!item_code <> " " Then
                oCgxrelojcontrol.Rows.Add(Reloj)
            End If
        Next

        LibX.Data.Manager.Save(oCgxrelojcontrol)
    End Function

    Private Sub i_reloj_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ScDefault = Val(Configuration.ConfigurationSettings.AppSettings.Get("LibXScDefault").ToString)
    End Sub
End Class
