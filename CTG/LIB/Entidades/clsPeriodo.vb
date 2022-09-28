Public Class Periodo
    Public Enum PeriodoStatusEnum
        Abierto = 1
        Cerrado = 0
    End Enum
    Public year As Integer
    Public Description As String
    Public Count As Integer
    Public Number As Integer
    Public From As Date
    Public Thru As Date
    Public Begin As Boolean
    Public SucCode As Integer
    Public Status As PeriodoStatusEnum

    Public Overloads Function isOpen() As Boolean
        Dim ReturnValue As Boolean

        ReturnValue = isOpen(Number, year)

        Return ReturnValue
    End Function

    Public Function isValid(ByVal FechaDocumento As Date) As Boolean
        If FechaDocumento >= From AndAlso FechaDocumento <= Thru Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Overloads Function isOpen(ByVal PerNum As Integer, ByVal PerYear As Integer) As Boolean
        Dim SelectStmt As String
        Dim StatusNum As Integer
        SelectStmt = "select perdr_status from cgperdd " & _
                     " Where perdr_num = " & PerNum.ToString.Trim & _
                     "   and perdr_Year = " & PerYear.ToString.Trim & _
                     "   and suc_code = 1 "

        StatusNum = LibX.Data.Manager.GetScalar(SelectStmt)

        If StatusNum = PeriodoStatusEnum.Abierto Then
            Return True
        Else
            Return False
        End If

    End Function
End Class
