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


        SelectStmt = "select paym_serial,paym_number,invce_date,type_code,chequera from ccpaymm " & _
                     "where chequera is not null and invce_status = 3 order by invce_date,type_code"

        Try

            LibX.Data.Manager.OpenConnection()
            LibX.Data.Manager.Connection.BeginTransaction()

            oTable = LibX.Data.Manager.GetDataTable(SelectStmt)

            For Each oRow As DataRow In oTable.Rows
                Dim LastNumber As Integer
                Dim newCode As String
                Dim newCode1 As String

                LastNumber = GenerateNumber(oRow!type_code, oRow!chequera)
                Label1.Text = LastNumber & " = " & oRow!type_code & " = " & oRow!chequera
                LibX.Data.Manager.ExecuteNonQuery("update ccpaymm set paym_number = " & LastNumber & " where paym_serial = " & oRow!paym_serial.ToString)
                LibX.Data.Manager.ExecuteNonQuery("update cbdocsm set doc_number = " & LastNumber & " where doc_origen = " & oRow!paym_serial.ToString)
            Next

            SelectStmt = "select paym_serial,paym_number,invce_date,type_code,chequera from ccpaymm " & _
                     "where chequera is not null and invce_status in(0,2) order by invce_date,type_code"

            oTable = LibX.Data.Manager.GetDataTable(SelectStmt)

            For Each oRow As DataRow In oTable.Rows
                Dim LastNumber As Integer
                Dim newCode As String
                Dim newCode1 As String

                LastNumber = genNum(orow!type_code)
                Label1.Text = LastNumber & " = " & oRow!type_code & " = " & oRow!chequera
                LibX.Data.Manager.ExecuteNonQuery("update ccpaymm set paym_number = " & 99 & LastNumber & 99 & " where paym_serial = " & oRow!paym_serial.ToString)
            Next

            LibX.Data.Manager.Connection.CommitTransaction()

        Catch ex As Exception
            LibX.Data.Manager.Connection.RollBackTransaction()
            LibX.Log.Show(ex)
        End Try

    End Sub
    Private Function GenerateNumber(ByVal type_code As String, ByVal chequera As Integer) As Integer
        Dim NewNumber As Integer
        Dim Numero As Integer
        Dim XUpdate As LibX.Data.XUpdateStmt
        Dim XSelect As LibX.Data.XSelecStmt
        Try
            XSelect = New LibX.Data.XSelecStmt("cgtrntpm", "select tran_number from cgtrntpm")
            XSelect.Parameters.Add("tran_type", type_code)
            XSelect.Parameters.Add("chequera", chequera)

            Numero = Val(XSelect.GetScalar().ToString)

            XUpdate = New LibX.Data.XUpdateStmt("cgtrntpm")
            NewNumber = Numero + 1

            XUpdate.FieldsSet("tran_number") = NewNumber
            XUpdate.Fields("tran_type") = type_code
            XUpdate.Fields("chequera") = chequera

            XUpdate.Execute()
            XUpdate.Dispose()
            XSelect.Dispose()

            Return NewNumber

        Catch ex As Exception
            LibX.Log.Add(ex)
            Return -1
        Finally

        End Try
    End Function
    Private Function genNum(ByVal type_code As String) As Integer
        Dim NewNumber As Integer
        Dim Numero As Integer
        Dim XUpdate As LibX.Data.XUpdateStmt
        Dim XSelect As LibX.Data.XSelecStmt
        Try
            XSelect = New LibX.Data.XSelecStmt("ivtypen", "select last_number from ivtypen")
            XSelect.Parameters.Add("type_code", type_code)

            Numero = Val(XSelect.GetScalar().ToString)

            XUpdate = New LibX.Data.XUpdateStmt("ivtypen")
            NewNumber = Numero + 1

            XUpdate.FieldsSet("last_number") = NewNumber
            XUpdate.Fields("type_code") = type_code

            XUpdate.Execute()
            XUpdate.Dispose()
            XSelect.Dispose()

            Return NewNumber

        Catch ex As Exception
            LibX.Log.Add(ex)
            Return -1
        Finally

        End Try
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MessageBox.Show("Seguro desea iniciar la renumeracion de recibos?", "Iniciar", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Actualizar()
        End If
    End Sub
End Class
