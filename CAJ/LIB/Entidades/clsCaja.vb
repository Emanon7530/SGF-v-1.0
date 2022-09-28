Public Class Caja
    Public Code As Integer
    Public Name As String
    Public Vender As Boolean
    Public Domicilio As Boolean
    Public DescuentoCxc As Boolean
    Public Sub New(ByVal pCode As Integer)
        Dim SelectStmt As String = "select * from cjcajam"
        Dim oRow As DataRow
        Try

            SelectStmt = SelectStmt & _
                         " where caja_code = " & pCode.ToString


            oRow = LibX.Data.Manager.GetDataRow(SelectStmt)

            If oRow Is Nothing Then
                Throw New ApplicationException("No existe caja con ese c�digo")
            End If

            Code = oRow!caja_code
            Name = oRow!caja_name
            Vender = oRow!caja_vender
            Domicilio = oRow!cierre_domicilio
            DescuentoCxc = oRow!descto_cxc

        Catch ex As Exception
            LibX.Log.Add(ex)

        End Try
    End Sub

End Class
