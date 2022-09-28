Public Class MontoFactura
    Public Shared MontoNeto As Decimal
    Public Shared MontoFactura As Decimal
    Public Shared MontoBruto As Decimal

    Public Sub New(ByVal pSerial As String)
        MontoLeido(pSerial)
    End Sub
    
    Private Shared Sub MontoLeido(ByVal pSerial As Integer)
        Dim Balores As DataRow
        Dim SelectStmt As String

        '// Buscar monto de factura
        SelectStmt = " select isnull(fact_total,0)-isnull(ftfactm.descto,0)+isnull(ftfactm.itbis,0)-isnull(seg_amount,0) totalneto," & _
                     " (sum(qty * ftfactd.price)) - sum(isnull(ftfactd.dscto, 0)) + sum(isnull(ftfactd.itbis, 0)) - isnull(seg_amount,0) facturado, " & _
                     " sum(qty * ftfactd.price) montobruto from ftfactm, ftfactd where " & _
                     " ftfactm.ftserial_no = ftfactd.ftserial_no And ftfactm.ftserial_no =" & pSerial.ToString.Trim & _
                     " and ftfactm.fact_status in(1,2,4,5) " & _
                     " group by ftfactm.fact_total,ftfactm.descto,ftfactm.itbis,ftfactm.seg_amount "

        Balores = LibX.Data.Manager.GetDataRow(SelectStmt)

        If Balores Is Nothing Then
            SelectStmt = " select isnull(fact_total,0)-isnull(ftfactm.descto,0)+isnull(ftfactm.itbis,0)-isnull(seg_amount,0) totalneto, " & _
                         " isnull(fact_total,0)-isnull(ftfactm.descto,0)+isnull(ftfactm.itbis,0)-isnull(seg_amount,0) facturado, 0 montobruto " & _
                         " from ftfactm where ftfactm.ftserial_no =" & pSerial.ToString.Trim & _
                         " and ftfactm.fact_status in(1,2,4,5) " & _
                         " group by ftfactm.fact_total,ftfactm.descto,ftfactm.itbis,ftfactm.seg_amount "

            Balores = LibX.Data.Manager.GetDataRow(SelectStmt)
            If Balores Is Nothing Then
                Exit Sub
            End If
        End If

        MontoNeto = Balores!totalneto
        MontoFactura = Balores!facturado
        MontoBruto = Balores!montobruto

    End Sub
    Public Function Isomovimiento(ByVal oType As String, ByVal pSerial As Integer) As Boolean
        Dim Ismovi As Integer

        Dim SelectStmt As String

        '// Buscar que el documento este en la tabala de transasion
        SelectStmt = " select doc_serial from ivtranrm where type_code ='" & oType.ToString.Trim & "'" & _
                     " and doc_serial =" & pSerial.ToString

        Ismovi = LibX.Data.Manager.GetScalar(SelectStmt)

        If Ismovi > 0 Or (oType <> "FPV" And oType <> "DEV" And oType <> "FSG") Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function FindDomicilio(ByVal pSerial As Integer) As Boolean
        Dim isDomi As Integer
        Dim oDomi As DataRow
        Dim XInsert As LibX.Data.XInsertStmt
        Dim SelectStmt As String
        Try
            '// Buscar que el domicilio este en la tabla de domicilio
            SelectStmt = " select ftserial_no from ftdomim where ftserial_no = " & pSerial.ToString
            isDomi = LibX.Data.Manager.GetScalar(SelectStmt)

            If isDomi > 0 Then
                Return True
            Else
                XInsert = New LibX.Data.XInsertStmt("ftdomim")
                SelectStmt = " select ftserial_no,cust_code,fact_date,null domi_cambio," & _
                             " null vend_mensaj,2 domi_status,'EFE' domi_pago,null tarj_code from ftfactm" & _
                             " where ftserial_no = " & pSerial.ToString

                oDomi = LibX.Data.Manager.GetDataRow(SelectStmt)

                XInsert.Fields("ftserial_no") = pSerial.ToString
                XInsert.Fields("cust_code") = oDomi!cust_code
                XInsert.Fields("domi_date") = oDomi!fact_date
                XInsert.Fields("domi_estatus") = oDomi!domi_status
                XInsert.Fields("domi_cambio") = oDomi!domi_cambio
                XInsert.Fields("vend_mensaj") = oDomi!vend_mensaj
                XInsert.Fields("domi_pago") = oDomi!domi_pago
                XInsert.Fields("tarj_code") = oDomi!tarj_code

                XInsert.Execute()
             End If
            Return True
        Catch ex As Exception
            Return False
            LibX.Log.Add(ex, True)
        End Try
    End Function
End Class
