Public Class Form1
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(272, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(104, 160)
        Me.Button1.Name = "Button1"
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Iniciar"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 198)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Renumerar Productos"
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub Actualizar()

        Dim oTable As DataTable
        Dim SelectStmt As String


        SelectStmt = "select cust_code from cccustm order by cust_code"

        Try

            LibX.Data.Manager.OpenConnection()
        LibX.Data.Manager.Connection.BeginTransaction()

        oTable = LibX.Data.Manager.GetDataTable(SelectStmt)

        For Each oRow As DataRow In oTable.Rows
            Dim LastNumber As Integer
            Dim newCode As String

                'LastNumber = LibX.Data.Manager.GetScalar("select last_number from ivgroupm where group_code = " & oRow!group_code.ToString.Trim)
                LastNumber = LastNumber + 1

                '   newCode = Format(oRow!group_code, "00") & (LastNumber + 1).ToString("0000")

                Label1.Text = "Codigo Anterior " & oRow!cust_code.ToString.Trim & ", Codigo ACtual = " & LastNumber
                Label1.Refresh()

                LibX.Data.Manager.ExecuteNonQuery("update cccustm set cust_code = '" & LastNumber & "' where cust_code = '" & oRow!cust_code.ToString & "'")

                'LibX.Data.Manager.ExecuteNonQuery("update ivreferm set item_code = '" & newCode & "' where item_code = '" & oRow!item_code.ToString & "'")

                'LibX.Data.Manager.ExecuteNonQuery("update ivcbarram set item_code = '" & newCode & "' where item_code = '" & oRow!item_code.ToString & "'")

                'LibX.Data.Manager.ExecuteNonQuery("update cpprovm set prov_code = '" & LastNumber & "' where cust_code = '" & oRow!cust_code.ToString & "'")

                'LibX.Data.Manager.ExecuteNonQuery("update ivgroupm set last_number = last_number + 1 where group_code = " & oRow!group_code.ToString)
        Next

            LibX.Data.Manager.Connection.CommitTransaction()

        Catch ex As Exception
            LibX.Data.Manager.Connection.RollBackTransaction()
            LibX.Log.Show(ex)
        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MessageBox.Show("Seguro desea iniciar la renumeracion de Suplidores?", "Iniciar", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Actualizar()
        End If
    End Sub
End Class
