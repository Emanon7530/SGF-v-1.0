Imports SGT
Imports SGT.Contabilidad
Imports SGT.Contabilidad.Intrefaces

Public Class GenerarED

    Public Function Aplicar(ByVal p_Args As ParametrosGenerarCODIF) As Integer
        Dim xInsert As LibX.Data.XInsertStmt
        Dim oPeriodo As Entidades.Periodo
        Dim oAnoFiscal As Entidades.AnoFiscal
        Dim Serial As Integer
        Dim i As Integer = 1
        Try

            oAnoFiscal = New Entidades.AnoFiscal
            oPeriodo = oAnoFiscal.BuscarPeriodoPorFecha(p_Args.Fecha)

            If oPeriodo Is Nothing Then
                Throw New ApplicationException("No se ha definido periodo para esta fecha!")
            End If

            If oPeriodo.Status = Entidades.Periodo.PeriodoStatusEnum.Cerrado Then
                Throw New ApplicationException("Este periodo esta cerrado y no se puede procesar movimientos!")
            End If

        Catch ex As Exception
            Throw
        End Try

        xInsert = New LibX.Data.XInsertStmt("ftcodifm", "codif_serial")
        xInsert.Fields("line_no") = 0
        xInsert.Fields("acct_no") = ""
        xInsert.Fields("codif_detail") = ""
        xInsert.Fields("debit_credit") = 0
        xInsert.Fields("amount") = 0
        xInsert.Fields("suc_code") = 0
        xInsert.Fields("type_code") = ""
        xInsert.Fields("caja_code") = 0
        xInsert.Fields("caje_code") = 0
        xInsert.Fields("codif_date") = ""
        xInsert.Fields("num_per") = 0
        xInsert.Fields("num_year") = 0

        i = 0
        For Each oCuenta As Entidades.Cuenta In p_Args.Cuentas

            i += 1
            xInsert.Fields("line_no").value = i
            xInsert.Fields("acct_no").value = oCuenta.Numero
            xInsert.Fields("codif_detail").value = oCuenta.Nombre
            xInsert.Fields("type_code").value = p_Args.Tipo
            xInsert.Fields("debit_credit").value = oCuenta.Origen
            xInsert.Fields("amount").value = oCuenta.Monto
            xInsert.Fields("suc_code").value = p_Args.Sucursal
            xInsert.Fields("caja_code").value = p_Args.Caja
            xInsert.Fields("caje_code").value = p_Args.Cajera
            xInsert.Fields("codif_date").value = p_Args.Fecha
            xInsert.Fields("num_per").value = p_Args.Fecha.Month
            xInsert.Fields("num_year").value = p_Args.Fecha.Year

            xInsert.Execute()

        Next

        Return Serial

    End Function
End Class
