Public Class Devolucion
    Public Serial As Integer
    Public TipoDocumento As String
    Public NumeroDocumento As Integer
    Public FechaDocumento As DateTime
    Public ValorDocumento As Decimal
    Public Motivo As String
    Public NombreMotivo As String
    Public Condicion As CondicionPagoEnum
    Public Cliente As Integer
    Public NombreCliente As String
    Public Observacion As String
    Public MontoSeguro As Decimal
    Public Poliza As String

    Public Sub New()

    End Sub

    Public Sub New(ByVal pSerial As Integer)
        Serial = pSerial

        Load()
    End Sub

    Public Function LoadPorFactura(ByVal p_Serial As Integer)
        Dim SelectStmt As String
        Dim oRow As DataRow

        SelectStmt = "select ftfactm.ftserial_no, " & _
                    " ftfactdv.fact_nota," & _
                    " ftfactdv.cust_code," & _
                    " ftfactdv.bus_name," & _
                    " ftfactdv.dev_type," & _
                    " ftdevolt.dev_name," & _
                    " ftfactdv.fact_cond," & _
                    " ftfactm.type_code," & _
                    " ftfactm.fact_number," & _
                    " ftfactm.fact_date," & _
                    " (isnull(ftfactm.fact_total,0) " & _
                    " + isnull(ftfactm.itbis,0) - " & _
                    " isnull(ftfactm.descto,0) - " & _
                    " isnull(ftfactm.seg_amount,0)) fact_total, " & _
                    " isnull(ftfactm.seg_amount,0) seg_amount, " & _
                    " ftsegrm.aseg_poliza " & _
                    " from ftfactm ftfactdv " & _
                    " inner join ftfactm " & _
                    " on ftfactm.ftserial_no = ftfactdv.ftserial_afect " & _
                    " inner join ftdevolt" & _
                    " on ftdevolt.dev_type = ftfactdv.dev_type " & _
                    " left outer join ftsegrm on ftsegrm.ftserial_no = ftfactm.ftserial_afect " & _
                    " where ftfactdv.ftserial_no = " & p_Serial.ToString.Trim

        oRow = LibX.Data.Manager.GetDataRow(SelectStmt)

        SetValues(oRow)

    End Function

    Public Function Load()
        Dim SelectStmt As String
        Dim oRow As DataRow

        SelectStmt = "select ftfactm.ftserial_no, " & _
                    " ftfactdv.fact_nota," & _
                    " ftfactdv.cust_code," & _
                    " ftfactdv.bus_name," & _
                    " ftfactdv.dev_type," & _
                    " ftfactm.fact_nota," & _
                    " ftdevolt.dev_name," & _
                    " ftfactdv.fact_cond," & _
                    " ftfactm.type_code," & _
                    " ftfactm.fact_number," & _
                    " ftfactm.fact_date," & _
                    " (isnull(ftfactm.fact_total,0) " & _
                    " + isnull(ftfactm.itbis,0) - " & _
                    " isnull(ftfactm.descto,0) - " & _
                    " isnull(ftfactm.seg_amount,0)) fact_total, " & _
                    " isnull(ftfactm.seg_amount,0) seg_amount, " & _
                    " ftsegrm.aseg_poliza " & _
                    " from ftfactm" & _
                    " inner join ftfactm ftfactdv" & _
                    " on ftfactdv.ftserial_afect = ftfactm.ftserial_no" & _
                    " inner join ftdevolt" & _
                    " on ftdevolt.dev_type = ftfactm.dev_type " & _
                    " left outer join ftsegrm on ftsegrm.ftserial_no = ftfactm.ftserial_afect " & _
                    " where ftfactm.ftserial_no = " & Serial.ToString.Trim

        oRow = LibX.Data.Manager.GetDataRow(SelectStmt)

        SetValues(oRow)

    End Function

    Private Sub SetValues(ByVal oRow As DataRow)
        Serial = Val(oRow!ftserial_no.ToString.Trim)
        TipoDocumento = oRow!type_code.ToString.Trim
        NumeroDocumento = Val(oRow!fact_number.ToString.Trim)
        FechaDocumento = CType(oRow!fact_date, DateTime)
        Motivo = oRow!dev_type.ToString.Trim
        ValorDocumento = Val(oRow!fact_total.ToString.Trim)
        Condicion = oRow!fact_cond.ToString.Trim
        Cliente = Val(oRow!cust_code.ToString.Trim)
        NombreCliente = oRow!bus_name.ToString.Trim
        Observacion = oRow!fact_nota.ToString.Trim
        MontoSeguro = Val(oRow!seg_amount.ToString.Trim)
        Poliza = Val(oRow!aseg_poliza.ToString.Trim)
    End Sub
End Class
