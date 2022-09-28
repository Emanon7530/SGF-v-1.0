
Public Class Codificacion
    Public Enum OrigenValorEnum
        MontoBruto = 1
        MontoNeto = 2
        Descuento = 3
        Impuesto = 4
        Devolucion = 5
        FOB = 6
        CIF = 7
        DiferenciaCambiaria = 8
        MontoExcento = 9
        MontoGrabado = 10
        DescuentoDevo = 11
        MontoSeguro = 12
        Credito = 13
        Tarjeta = 14
        Efectivo = 15
        NotaCredito = 16
        NotaDebito = 17
        CostoVenta = 18
        CxcCliente = 19
        RetItbis = 20
        RetIsr = 21
        costoVentasAgricolas = 22
        CostoVentasVeterinarios = 23
        RetIsr2 = 24
        RetItbis2 = 25
    End Enum

    Public Enum CondicionEnum
        Contado = 1
        Credito = 2
    End Enum

    Public TipoDocumento As String
    Public Orden As Integer
    Public Numero As String
    Public OrigenAsiento As Integer
    Public OrigenValor As OrigenValorEnum
    Public Condicion As CondicionEnum
    Public Proveedor As Integer
    Public Chequera As Integer

    Public Function Load() As Boolean
        Dim SelectStmt As String
        Dim oRow As DataRow

        SelectStmt = String.Concat("select * from cgentrdm ", _
                                   " where type_code = '", TipoDocumento.Trim, _
                                   "   and Condicion = ", Val(Condicion), _
                                   "   and Orig_valor = ", Val(OrigenValor), _
                                   " order by origen")

        oRow = LibX.Data.Manager.GetDataRow(SelectStmt)

        If oRow Is Nothing Then
            Return False
        End If

        With oRow
            Me.TipoDocumento = oRow!type_code.ToString
            Me.Numero = oRow!acct_no.ToString
            Me.Orden = Val(oRow!line_no.ToString)
            Me.OrigenAsiento = IIf(Val(oRow!ORIGEN.ToString) = 1, 1, -1)
            Me.Condicion = Val(oRow!condicion.ToString)
            Me.OrigenValor = Val(oRow!orig_valor.ToString)
        End With

        Return True
    End Function

    Public Function BuscarPorCondicion(ByVal TipoDocumento As String, ByVal Condicion As CondicionEnum, ByVal Proveedor As Integer, ByVal Chequera As Integer, ByVal Modtype As String) As DataTable
        Dim SelectStmt As String

        SelectStmt = "type_code = '" & TipoDocumento.Trim & "' and (condicion = " & Val(Condicion).ToString & " or condicion = 0)"

        Return Buscar(SelectStmt, Proveedor, Chequera, TipoDocumento, Modtype)

    End Function

    Public Function BuscarPorDocumento(ByVal TipoDocumento As String, ByVal proveedor As Integer, ByVal Chequera As Integer, ByVal Modtype As String) As DataTable
        Dim SelectStmt As String

        SelectStmt = "type_code = '" & TipoDocumento.Trim & "'"

        Return Buscar(SelectStmt, proveedor, Chequera, TipoDocumento, Modtype)

    End Function

    Public Function Buscar(ByVal WhereCondition As String, ByVal Proveedor As Integer, ByVal Chequera As Integer, ByVal TipoDocumento As String, ByVal Modtype As String) As DataTable
        Dim SelectStmt As String
        Dim oTable As DataTable

        Select Case TipoDocumento
            Case "CRD", "CUS", "FPV", "FSG", "FCT", "DVF", "FTS", "DEV", "RCE", "RCB", "EST", "DVI", "ADJ", "TRF", "NDP", "NDC", "NCR", "NCC", "REP"
                SelectStmt = String.Concat(" select * from  cuentascodificacion where ", WhereCondition.Trim, " and proveedor = " & Proveedor & " and chequera = " & Chequera)
            Case "SOL", "CHQ", "DPT", "DEP", "DCC", "RSM", "RET", "PEF"
                SelectStmt = String.Concat(" select * from  cuentascodificacion where ", WhereCondition.Trim, " or (proveedor = " & Proveedor & " and type_code = '" & Modtype & "')" & " Or type_code Is null Or Chequera = " & Chequera)
        End Select

        oTable = LibX.Data.Manager.GetDataTable(SelectStmt)

        Return oTable

    End Function
End Class
