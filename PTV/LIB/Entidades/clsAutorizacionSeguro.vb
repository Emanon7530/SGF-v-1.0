Public Class AutorizacionSeguro
    Public Factura As Integer
    Public Poliza As String = ""
    Public Compania As Integer
    Public Plan As Integer
    Public Autorizacion As String = ""
    Public RecetaUnica As Integer
    Public TotalFacturado As Decimal
    Public MontoCobertura As Decimal
    Public MontoPagar As Decimal

    Public Sub New()

    End Sub

    Public Sub New(ByVal pFactura As Integer)
        Me.Factura = pFactura
    End Sub

    Public Function Load()
        Dim SelectStmt As String
        Dim oRow As DataRow
        Try

            SelectStmt = "select * from ftsegrm where ftserial_no = " & Me.Factura.ToString.Trim

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

        Poliza = oRow!aseg_poliza.ToString.Trim
        Compania = Val(oRow!cia_serial.ToString.Trim)
        Plan = Val(oRow!plan_serial.ToString.Trim)
        Autorizacion = oRow!segr_autorizacion.ToString.Trim
        RecetaUnica = Val(oRow!segr_recetaunica.ToString.Trim)
        TotalFacturado = Val(oRow!empl_amount.ToString.Trim) + Val(oRow!cia_amount.ToString.Trim)
        MontoCobertura = Val(oRow!cia_amount.ToString.Trim)
        MontoPagar = TotalFacturado - MontoCobertura

    End Sub
End Class
