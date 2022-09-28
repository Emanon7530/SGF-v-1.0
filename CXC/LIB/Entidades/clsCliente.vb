Public Class Cliente

    Public Codigo As Integer
    Public Nombre As String = ""
    Public Termino As String = ""
    Public Telefono As String = ""
    Public StoAbono As Integer
    Public StoVenci As Integer
    Public StoCheque As Integer
    Public DiasGracia As Integer
    Public Estado As Integer
    Public VendeCredito As Integer
    Public TipoCliente As Integer
    Public LimiteCredito As Decimal
    Public Ncf As Integer
    Public RNC As String = ""
    Public Transferencia As Integer
    Public OtroDescuento As Integer

    Private Sub Load()
        Dim SelectStmt As String
        Dim oRow As DataRow

        SelectStmt = "select * from cccustm" & _
                     " where cust_code = " & Me.Codigo.ToString.Trim

        oRow = LibX.Data.Manager.GetDataRow(SelectStmt)

        If oRow Is Nothing Then
            Throw New ApplicationException("Cliente No existe!")
        End If

        Codigo = oRow!cust_code.ToString.Trim
        Nombre = oRow!cust_name.ToString.Trim
        Termino = oRow!term_code.ToString.Trim
        Telefono = oRow!cust_phone.ToString.Trim
        RNC = oRow!rnc_id.ToString.Trim
        Ncf = Val(oRow!ncf_type.ToString.Trim)
        Estado = Val(oRow!cust_status.ToString.Trim)
        VendeCredito = Val(oRow!cust_credito.ToString.Trim)
        StoAbono = Val(oRow!stop_abono.ToString.Trim)
        StoVenci = Val(oRow!stop_venct.ToString.Trim)
        StoCheque = Val(oRow!stop_cheque.ToString.Trim)
        DiasGracia = Val(oRow!day_benef.ToString.Trim)
        TipoCliente = Val(oRow!csttype_code.ToString.Trim)
        LimiteCredito = Val(oRow!credit_limit.ToString.Trim)
        Transferencia = Val(oRow!web_transf.ToString.Trim)
        OtroDescuento = Val(oRow!otro_dsct.ToString.Trim)
    End Sub

    Public Sub New()

    End Sub
    Public Sub New(ByVal pCodigo As Integer)
        MyBase.new()
        Me.Codigo = pCodigo
        Me.Load()
    End Sub

    Public Class ParametrosExcedeLimite
        Public Cliente As Integer
        Public MontoAplicar As Decimal
    End Class
    Public Class ParametrosEstadoCliente
        Public Cliente As Integer
        Public DiaTermino As Integer
    End Class

    Public Function GetBalance(ByVal Codigo As Integer) As Decimal
        Dim SelectStmt As String
        Dim Balance As Decimal

        SelectStmt = "select cast(balance as decimal) from cccustm " & _
                     " where cust_code = " & Codigo.ToString.Trim

        Balance = LibX.Data.Manager.GetScalar(SelectStmt)

        Return Balance
    End Function

    Public Function ExcedeLimite(ByVal p_Args As ParametrosExcedeLimite) As Boolean
        Dim oRow As DataRow
        Dim SelectStmt As String
        Dim Balance, Limite As Decimal
        Try

            SelectStmt = "select cccustm.cust_code,isnull(credit_limit,0) credit_limit,sum(isnull(ccopend.balance,0)) balance from " & _
                         " cccustm left outer join ccopend on cccustm.cust_code = ccopend.cust_code where cccustm.cust_code = " & p_Args.Cliente.ToString & _
                         " group by cccustm.cust_code,cccustm.credit_limit"

            oRow = LibX.Data.Manager.GetDataRow(SelectStmt)

            If oRow Is Nothing Then
                Throw New ApplicationException("Error buscando cliente")
            End If

            Balance = Val(oRow!balance.ToString)
            Limite = Val(oRow!credit_limit.ToString)

            If Limite <= 0 Then
                Return True
            End If

            If Balance >= Limite Then
                Return True
            End If

            If Balance + p_Args.MontoAplicar >= Limite Then
                Return True
            End If

            Return False

        Catch ex As Exception
            LibX.Log.Add(ex)
            Return True
        End Try
    End Function

    Public Function EstadoCliente(ByVal p_Args As ParametrosEstadoCliente) As Boolean
        Dim SelectStmt As String
        Dim Bencida As Integer
        Try

            SelectStmt = "select count(*) from ccopend where balance > 0 " & _
                         " and cust_code = " & p_Args.Cliente.ToString & _
                         " and datediff(day,doc_date,getdate()) > " & p_Args.DiaTermino

            Bencida = LibX.Data.Manager.GetScalar(SelectStmt)

            If Bencida <= 0 Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
            Return True
        End Try
    End Function

End Class
