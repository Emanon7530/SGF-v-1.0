Public Class ClienteAsegurado
    Public Codigo As Integer
    Public CompaniaID As Integer
    Public PlanID As Integer
    Public Poliza As String = ""
    Public Nombre As String = ""
    Public Direccion As String = ""
    Public Telefono As String = ""
    Public Cedula As String = ""
    Public Credito As Integer
    Public Estatus As Integer
    Public Ciudad As Integer
    Public Sector As Integer
    Public Clinica As Integer
    Public Principal As Boolean = True
    Public Apellidos As String
    Public LimiteCredito As Decimal
    Public Balance As Decimal
    Public Acumulado As Decimal
    Public Sub New()

    End Sub
    Public Sub New(ByVal pPoliza As Integer, ByVal mCia As Integer)
        Me.Poliza = pPoliza
        Me.CompaniaID = mCia
    End Sub

    Public Function Load()
        Dim SelectStmt As String
        Dim oRow As DataRow
        Try
            SelectStmt = "select * from sgasegm where aseg_poliza = '" & Me.Poliza.ToString.Trim & "' and cia_serial = " & Me.CompaniaID.ToString.Trim
            oRow = LibX.Data.Manager.GetDataRow(SelectStmt)

            If oRow Is Nothing Then
                Exit Function
            End If

            SetValues(oRow)

        Catch ex As Exception
            Throw
        End Try
    End Function

    Private Sub SetValues(ByVal oRow As DataRow)
        Codigo = Val(oRow!aseg_serial.ToString.Trim)
        CompaniaID = Val(oRow!cia_serial.ToString.Trim)
        PlanID = Val(oRow!plan_serial.ToString.Trim)
        Poliza = oRow!aseg_poliza.ToString.Trim
        Nombre = oRow!aseg_nombre.ToString.Trim
        Direccion = oRow!aseg_address.ToString.Trim
        Telefono = oRow!aseg_phone.ToString.Trim
        Cedula = oRow!aseg_cedula.ToString.Trim
        Credito = Val(oRow!cust_code.ToString.Trim)
        Estatus = Val(oRow!aseg_status.ToString.Trim)
        Ciudad = Val(oRow!city_code.ToString.Trim)
        Sector = Val(oRow!sector_code.ToString.Trim)
        Ciudad = Val(oRow!clini_code.ToString.Trim)
        Principal = Val(oRow!aseg_principal.ToString.Trim)
        Apellidos = oRow!aseg_apellidos.ToString.Trim
        LimiteCredito = Val(oRow!aseg_limite.ToString.Trim)
        Balance = Val(oRow!aseg_balance.ToString.Trim)
        Acumulado = Val(oRow!bal_acumulado.ToString.Trim)
    End Sub

End Class
