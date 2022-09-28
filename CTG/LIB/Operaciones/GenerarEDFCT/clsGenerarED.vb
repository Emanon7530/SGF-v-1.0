Imports SGT
Imports SGT.Contabilidad
Imports SGT.Contabilidad.Intrefaces

Public Class GenerarED

    Public Function Aplicar(ByVal p_Args As ParametrosGenerarED) As Integer
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

        xInsert = New LibX.Data.XInsertStmt("cgtranrm", "tranr_serial")

        xInsert.Fields("tran_type") = p_Args.Tipo
        xInsert.Fields("tran_number") = p_Args.Numero
        xInsert.Fields("tran_date") = p_Args.Fecha
        xInsert.Fields("date_created") = LibX.Data.Manager.Connection.GetDate
        xInsert.Fields("tran_descr") = ""
        xInsert.Fields("tran_status") = 2 '// Pendiente
        xInsert.Fields("tran_orign") = p_Args.Modulo
        xInsert.Fields("tran_refer") = p_Args.Referencia
        xInsert.Fields("perdr_year") = oPeriodo.year
        xInsert.Fields("perdr_num") = oPeriodo.Number

        Serial = xInsert.Execute

        xInsert = New LibX.Data.XInsertStmt("cgtranrd")
        xInsert.Fields("tranr_serial") = Serial

        i = 0
        For Each oCuenta As Entidades.Cuenta In p_Args.Cuentas

            i = +1
            xInsert.Fields("line_no") = i
            xInsert.Fields("acct_no") = oCuenta.Numero
            xInsert.Fields("tranr_detail") = oCuenta.Nombre
            xInsert.Fields("debit_credit") = oCuenta.Origen
            xInsert.Fields("amount") = oCuenta.Monto

            xInsert.Execute()

        Next

        Return Serial

    End Function
End Class
