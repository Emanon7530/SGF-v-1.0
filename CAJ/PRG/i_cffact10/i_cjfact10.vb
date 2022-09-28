Imports LibX
Public Class i_cjfact10
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
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.btnOk = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.Location = New System.Drawing.Point(8, 16)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(608, 432)
        Me.ListView1.TabIndex = 0
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Tipo"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Número"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Fecha"
        Me.ColumnHeader3.Width = 80
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Cliente"
        Me.ColumnHeader4.Width = 250
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Condición"
        Me.ColumnHeader5.Width = 70
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Total"
        Me.ColumnHeader6.Width = 80
        '
        'btnOk
        '
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnOk.Location = New System.Drawing.Point(416, 456)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(88, 32)
        Me.btnOk.TabIndex = 1
        Me.btnOk.Text = "Aceptar"
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnCancel.Location = New System.Drawing.Point(512, 456)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(104, 32)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancelar"
        '
        'i_cjfact10
        '
        Me.AcceptButton = Me.btnOk
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(626, 496)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.ListView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "i_cjfact10"
        Me.Text = "Lista de facturas"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub i_ftdevmn01a_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            LibX.Data.Manager.OpenConnection()

            Dim oRow As DataRow
            Dim oTable As DataTable
            Dim sql As String
            Dim sCli As String
            Dim oRow2 As DataRow

            sql = "Select * from ftfactm where fact_status = 2"

            oTable = LibX.Data.Manager.GetDataTable(sql)

            Me.ListView1.Items.Clear()
            Dim oITem As ListViewItem
            For Each oRow In oTable.Rows
                oITem = Me.ListView1.Items.Add(oRow!type_code.ToString.Trim)
                oITem.Tag = oRow!ftserial_no
                oITem.SubItems.Add(oRow!fact_number.ToString.Trim)
                oITem.SubItems.Add(CDate(oRow!fact_date.ToString).ToString("d").Trim)
                'oITem.SubItems.Add(oRow!fact_date)


                sCli = ""
                If oRow!fact_cond = 1 Then
                    '-->Contado
                    sql = "Select * from ftcustm where ftserial_no =" & oRow!ftserial_no
                    oRow2 = LibX.Data.Manager.GetDataRow(sql)
                    If Not IsNull(oRow2!cust_name) Then
                        sCli = oRow2!cust_name
                    End If
                    oITem.SubItems.Add(sCli)
                    oITem.SubItems.Add("Contado")
                Else
                    sql = "Select * from cccustm where cust_code =" & oRow!cust_code
                    oRow2 = LibX.Data.Manager.GetDataRow(sql)
                    If Not IsNull(oRow2!cust_name) Then
                        sCli = oRow2!cust_name
                    End If
                    oITem.SubItems.Add(sCli)
                    oITem.SubItems.Add("Crédtio")
                End If

                oITem.SubItems.Add(CDec(oRow!fact_total).ToString("###,###,##0.00"))


            Next


        Catch ex As Exception
            Log.Show(ex)
        End Try

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Me.Close()
    End Sub

    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        Try
            If ListView1.SelectedItems.Count = 0 Then
                Exit Sub
            End If

            Dim op As New LibxPrgParams
            op.IsFromOther = True
            op.Value = ListView1.SelectedItems(0).Tag
            App.CurrentPrgParams = op

            LibX.LibXRunner.Run("C:\SGT\Fuente\SGT\CAJ\PRG\i_cjfact01\bin\i_cjfact01.exe", True)

        Catch ex As Exception
            Log.Show(ex)
        End Try

    End Sub
End Class
