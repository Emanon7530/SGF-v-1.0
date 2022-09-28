Public Class ClienteCredito
    Public Codigo As Integer
    Public Nombre As String
    Public Direccion As String
    Public Telefono As String
    Public Ciudad As Integer
    Public Sector As Integer
    Public NombreCiudad As String
    Public NombreSector As String
    Public Mensajero As Integer
    Public NombreMensajero As String
    Public Balance As Decimal
    Public LimiteCredito As Decimal
    Public Estado As Integer

    Public Sub New()

    End Sub

    Public Sub New(ByVal pCodigo As Integer)
        Me.Codigo = pCodigo
    End Sub

    Public Function Load()
        Dim SelectStmt As String
        Dim mBalance As Decimal
        Dim oRow As DataRow
        Try

            SelectStmt = "select cccustm.* " & _
                         "  from cccustm " & _
                         " where cccustm.cust_code = " & Me.Codigo.ToString.Trim

            oRow = LibX.Data.Manager.GetDataRow(SelectStmt)

            If oRow Is Nothing Then
                Exit Function
            End If

            SelectStmt = "select sum(balance) from ccopend where cust_code = " & Me.Codigo.ToString.Trim
            mBalance = LibX.Data.Manager.GetScalar(SelectStmt)
            oRow!balance = mBalance
            SetValues(oRow)

        Catch ex As Exception
            Throw
        End Try
    End Function

    Private Sub SetValues(ByVal oRow As DataRow)
        Codigo = Val(oRow!cust_code.ToString.Trim)
        Nombre = oRow!cust_name.ToString.Trim
        Direccion = oRow!cust_address.ToString.Trim
        Telefono = oRow!cust_phone.ToString.Trim
        Ciudad = Val(oRow!city_code.ToString.Trim)
        Sector = Val(oRow!sector_code.ToString.Trim)
        NombreCiudad = ""
        NombreSector = ""
        Mensajero = 0
        NombreMensajero = ""
        Balance = Val(oRow!balance.ToString.Trim)
        LimiteCredito = Val(oRow!credit_limit.ToString.Trim)
        Estado = Val(oRow!cust_status.ToString.Trim)
    End Sub

    Public Function GetAditionalInformation() As String
        Dim SelectStmt As String
        Dim oRow As DataRow
        Dim AditionalInformation As String

        SelectStmt = "select cust_code, cust_name, cust_address,sector_name, city_name, " & _
                     " balance, credit_limit " & _
                     " from cccustm " & _
                     " left outer join cccity city " & _
                     "   on city.city_code = cccustm.city_code " & _
                     " left outer join ccsectorm sector " & _
                     "   on sector.city_code = cccustm.city_code " & _
                     "  and sector.sector_code = cccustm.sector_code " & _
                     " Where cccustm.cust_code = " & Codigo.ToString.Trim

        oRow = LibX.Data.Manager.GetDataRow(SelectStmt)

        If oRow Is Nothing Then
            Return ""
        End If

        '//Codigo     :Codigo
        '//Direccion    :XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
        '//Sector       :XXXXXXXXXXXXXXXXXXXX   Ciudad  :XXXXXXXXXXXXXXXXXXXXX
        '//Balance      :9999-9999-9999-9999    Limite Credito:99/9999

        AditionalInformation = "Codigo " & oRow!cust_code.ToString.Trim & vbCrLf & _
                               "Dirección " & oRow!cust_address.ToString.Trim & vbCrLf & _
                               "Sector " & oRow!sector_name.ToString.Trim & ", " & "Ciudad " & oRow!city_name.ToString.Trim & vbCrLf & _
                               "Balance " & Val(oRow!balance.ToString.Trim).ToString("###,###,##0.00") & ", Limite Crédito " & Val(oRow!credit_limit.ToString.Trim).ToString("###,###,##0.00")

        Return AditionalInformation
    End Function
End Class
