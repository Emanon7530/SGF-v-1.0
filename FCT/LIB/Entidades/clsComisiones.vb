Public Class Comisiones
    Dim MyTran As Boolean
    Public Class Facturas
        Inherits CollectionBase
        Public Function Add(ByVal ftserial_no As Integer) As Int16
            list.Add(ftserial_no)
        End Function

        Public Function Remove(ByVal ftserial_no As Integer) As Int16
            list.Remove(ftserial_no)
        End Function

        Default Public Property Item(ByVal Index As Integer) As Int16
            Get
                Return list.Item(Index)
            End Get
            Set(ByVal Value As Int16)
                list.Item(Index) = Value
            End Set
        End Property

    End Class

    Public Function Cerrar(ByVal e As Facturas) As Boolean
        Dim SelectStmt As String
        Dim WhereStmt As String
        Dim Serial As Int16
        Dim oRow As DataRow
        Dim xUpdate As LibX.Data.XUpdateStmt
        Dim xInsert As LibX.Data.XInsertStmt
        Dim oTable As DataTable
        Try
            WhereStmt = "ftserial_no in (0"

            For Each Serial In e
                WhereStmt = "," & Serial.ToString
            Next

            WhereStmt = WhereStmt.Trim & ")"

            SelectStmt = "select vend_code,sum(amount) from ftcomid " & _
                         " where " & WhereStmt.Trim & " and comm_status = 2 "

            oTable = LibX.Data.Manager.GetDataTable(SelectStmt, "ftcomid")

            For Each oRow In oTable.Rows
                xInsert = New LibX.Data.XInsertStmt("ftcomim", "comm_serial")
                xInsert.Fields("vend_code") = oRow!vend_code
                xInsert.Fields("comm_date") = LibX.Data.Manager.Connection.GetDate
                xInsert.Fields("amount") = oRow!amount

                Serial = xInsert.Execute

                SelectStmt = "update ftcomid set comm_serial = " & Serial.ToString & _
                             ",comm_status = 1 where " & WhereStmt.Trim & _
                             " and comm_status = 2 " & _
                             " and vend_code = " & oRow!vend_code.ToString

                LibX.Data.Manager.ExecuteNonQuery(SelectStmt)
            Next
            Return True
        Catch ex As Exception
            LibX.Log.Add(ex)
            Return False
        End Try
    End Function

    Public Function Crear(ByVal pftserial_no As Integer) As Boolean
        Dim SelectStmt As String
        Dim AmountComm As Decimal
        Dim porcComm As Decimal

        Dim oRow As DataRow
        Dim XInsert As LibX.Data.XInsertStmt

        Try
            MyTran = False
            XInsert = New LibX.Data.XInsertStmt("ftcomid")

            SelectStmt = "select ftserial_no,vend_code,(fact_total+itbis)-descto total_amount from ftfactm " & _
                         " where ftserial_no = " & pftserial_no.ToString

            oRow = LibX.Data.Manager.GetDataRow(SelectStmt)

            If oRow Is Nothing Then
                Throw New ApplicationException("No se encontró este documento")
            End If

            If oRow!vend_code.ToString = "" Then
                Return True
            End If

            SelectStmt = "select porc_comision from ftvendm " & _
                         " where vend_code = " & oRow!vend_code.ToString

            porcComm = LibX.Data.Manager.GetScalar(SelectStmt)

            If LibX.IsNull(porcComm) Then
                Return True
            End If

            If porcComm <= 0 Then
                Return True
            End If

            If LibX.Data.Manager.Connection.IsIntransaction = False Then
                LibX.Data.Manager.Connection.BeginTransaction()
                MyTran = True
            End If
            AmountComm = Val(oRow!total_amount.ToString) * porcComm

            XInsert.Fields("vend_code") = oRow!vend_code
            XInsert.Fields("ftserial_no") = pftserial_no
            XInsert.Fields("comm_status") = 2 'Pendiente de Pago
            XInsert.Fields("amount") = AmountComm

            XInsert.Execute()

            If MyTran = True And LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.CommitTransaction()
                MyTran = False
            End If

            Return True

        Catch ex As Exception
            LibX.Log.Add(ex)
            If MyTran = True And LibX.Data.Manager.Connection.IsIntransaction = True Then
                LibX.Data.Manager.Connection.RollBackTransaction()
                MyTran = False
            End If
            Return False

        End Try

    End Function

    Public Function Anular(ByVal pftserial_no As Integer) As Boolean
        Dim SelectStmt As String
        Dim AmountComm As Decimal
        Dim porcComm As Decimal

        Dim oRow As DataRow
        Dim xUpdate As LibX.Data.XUpdateStmt

        Try

            xUpdate = New LibX.Data.XUpdateStmt("ftcomid")

            xUpdate.FieldsSet("comm_status") = 0
            xUpdate.Fields("ftserial_no") = pftserial_no

            xUpdate.Execute()

            Return True

        Catch ex As Exception
            LibX.Log.Add(ex)
            Return False

        End Try

    End Function
End Class
