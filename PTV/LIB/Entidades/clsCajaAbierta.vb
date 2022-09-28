Public Class CajaAbierta
    Public Shared Serial As Integer
    Public Shared CajaCode As Int16
    Public Shared CajaName As String
    Public Shared CajeraCode As Integer
    Public Shared CajeraName As String
    Public Shared Fecha As Date
    Public Shared Status As Integer
    Public Shared EfectivoInicial As Decimal

    Public Sub New()

    End Sub

    Public Sub New(ByVal CajaCode As Integer)
        Dim oRow As DataRow
        Dim SelectStmt As String

        SelectStmt = "Select * from cjinitm where init_status = 1 and caja_code = " & CajaCode.ToString

        oRow = LibX.Data.Manager.GetDataRow(SelectStmt)

        If oRow Is Nothing Then
            Throw New ApplicationException("No hay caja abierta para esta caja!")
        End If

        SetValue(oRow)

        EfectivoInicial = oRow!cash_amount
    End Sub

    Public Function GetAbiertaByCajeraID(ByVal CajeraID As Integer) As Boolean
        Dim oRow As DataRow
        Dim SelectStmt As String

        SelectStmt = "Select * from cjinitm where init_status = 1 and vend_code = " & CajeraID.ToString

        oRow = LibX.Data.Manager.GetDataRow(SelectStmt)

        If oRow Is Nothing Then
            Return False
        End If

        SetValue(oRow)

        Return True
    End Function

    Public Function HayCajasAbiertas() As Boolean
        Dim Existen As Integer
        Dim SelectStmt As String

        SelectStmt = "Select count(*) from cjinitm where init_status = 1 "
        Existen = Val(LibX.Data.Manager.GetScalar(SelectStmt).ToString.Trim)

        If Existen > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function HayCajasAbiertas(ByVal pCajera As Integer) As Boolean
        Dim Existen As Integer
        Dim SelectStmt As String

        If pCajera <= 0 Then
            Throw New ApplicationException("Debe Especificar la cajera!")
        End If

        SelectStmt = "Select count(*) from cjinitm where init_status = 1 and vend_code = " & pCajera.ToString.Trim
        Existen = Val(LibX.Data.Manager.GetScalar(SelectStmt).ToString.Trim)

        If Existen > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub SetValue(ByVal oRow As DataRow)
        Dim oCaja As Caja
        Dim oCajera As Cajera

        oCaja = New Caja(oRow!caja_code)
        oCajera = New Cajera(oRow!vend_code)

        CajaCode = oRow!caja_code
        CajeraCode = oRow!vend_code
        Fecha = oRow!init_date
        EfectivoInicial = oRow!cash_amount
        Serial = oRow!init_serial

        CajeraName = oCajera.Name
        CajaName = oCaja.Name

    End Sub

    Public Function Load() As Boolean
        Dim oRow As DataRow
        Dim SelectStmt As String

        SelectStmt = "Select * from cjinitm where init_serial = " & Serial.ToString

        oRow = LibX.Data.Manager.GetDataRow(SelectStmt)

        If oRow Is Nothing Then
            Return False
        End If

        SetValue(oRow)

        Return True
    End Function

End Class
