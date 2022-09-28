Public Class Chequera
    Public Codigo As Integer
    Public Nombre As String
    Public CuentaBanco As String
    Public CuentaContable As String
    Public BalanceActual As Decimal
    Public Banco As Integer

    Public Class ParametrosAplicar
        Public TipoDocumento As String
        Public Chequera As Integer
        Public Monto As Decimal
    End Class

    Public Sub New(ByVal pChequera As Integer)
        Dim SelectStmt As String
        Dim oRow As DataRow

        SelectStmt = "select * from cpchequera " & _
                     " where chequera = " & pChequera.ToString

        oRow = LibX.Data.Manager.GetDataRow(SelectStmt)

        setvalue(oRow)
    End Sub

    Public Function GetBalanceByDate(ByVal Chequera As Integer, ByVal FechaCorte As DateTime)
        Dim SelectStmt As String
        Dim blnBalance As Double
        Dim blnMovimientos As Double
        Dim MovCR As Double
        Dim MovDB As Double
        Dim blnCreditos As Double
        Dim fEcha_conc As DateTime
        Dim Mfechaini, Mfechafin As String
        Dim Ufecha As DataRow
        Dim aNio, mEs, dIa As String
        Dim newMes As Integer
        Dim lastDaymes As Integer
        Try
            '// Saldo Anterior
            blnBalance = LibX.Data.Manager.GetScalar("select balance_ult_concil from cpchequera where chequera = " & Chequera.ToString)

            '//Fecha Conciliacion Anterior
            ''fEcha_conc = LibX.Data.Manager.GetScalar("select max(conc_date) from cbconcm  where conc_status = 1 and  chequera =" & Chequera.ToString & _
            ''             " and conc_date < '" & FechaCorte.ToString(LibX.Data.Manager.GetSaveDateFormat) & _
            ''             "' group by chequera  ")

            fEcha_conc = LibX.Data.Manager.GetScalar("select fecha_conciliacion from cpchequera  where chequera =" & Chequera.ToString)

            dIa = fEcha_conc.Day.ToString("00")
            mEs = fEcha_conc.Month.ToString("00")
            aNio = fEcha_conc.Year.ToString("0000")

            ''//Decterminar cual es el ultimo dia del mes para construir la fecha de inicio en la busqueda
            lastDaymes = LibX.Data.Manager.GetScalar("select day(dateadd(d,-1,dateadd(m,1,convert(datetime,'" & aNio & "' + " & "'" & mEs & "' + " & "'01'))))")

            If dIa = lastDaymes And mEs <> 12 Then
                dIa = "01"
                mEs = mEs + 1
            End If
            '//Cuando se busca la fecha del mes de febrero y el año es visiesto para que no se pierda el dia 29
            If dIa < lastDaymes And mEs = 2 Then
                dIa = dIa + 1
                mEs = mEs
            End If
            If dIa < lastDaymes And mEs <> 12 And mEs <> 2 Then
                dIa = dIa + 1
                mEs = mEs
            End If
            If mEs = 12 Then
                dIa = "01"
                mEs = "01"
                aNio = aNio + 1
            End If

            newMes = mEs

            Mfechaini = aNio & "/" & newMes.ToString("00") & "/" & dIa
            Mfechafin = FechaCorte.Year.ToString("0000") & "/" & FechaCorte.Month.ToString("00") & "/" & FechaCorte.Day.ToString("00")

            '// Movimientos
            SelectStmt = "select isnull(sum(amount),0) from cbdocsm, cgtrntpm " & _
                         " where cbdocsm.chequera = " & Chequera.ToString & _
                         "   and cgtrntpm.chequera = cbdocsm.chequera " & _
                         "   and cgtrntpm.tran_type = cbdocsm.tran_type " & _
                         "   and cgtrntpm.conciliable = 1 and origen = 1" & _
                         "   and cbdocsm.doc_status <> 0 " & _
                         "   and doc_date between '" & _
                         Mfechaini & "' and '" & Mfechafin.ToString & "'"

            MovDB = LibX.Data.Manager.GetScalar(SelectStmt)

            SelectStmt = "select isnull(sum(amount),0) from cbdocsm, cgtrntpm " & _
                         " where cbdocsm.chequera = " & Chequera.ToString & _
                         "   and cgtrntpm.chequera = cbdocsm.chequera " & _
                         "   and cgtrntpm.tran_type = cbdocsm.tran_type " & _
                         "   and cgtrntpm.conciliable = 1 and origen = -1 " & _
                         "   and cbdocsm.doc_status <> 0 " & _
                         "   and doc_date between '" & _
                         Mfechaini & "' and '" & Mfechafin.ToString & "'"

            MovCR = LibX.Data.Manager.GetScalar(SelectStmt)

            blnMovimientos = MovDB - MovCR

            '// Balance 
            blnBalance = (blnBalance + blnMovimientos)

            Return blnBalance

        Catch ex As Exception
        End Try
    End Function
    Function SaldoAnterior(ByVal Chequera As Integer, ByVal NoConcil As Integer) As Decimal
        Dim oSaldo As Decimal
        oSaldo = LibX.Data.Manager.GetScalar("select Saldo_Ant from cbconcm where chequera = " & Chequera.ToString & "   and conc_serial = " & NoConcil.ToString)
        Return oSaldo

    End Function
    Function ConcliadoAnterior(ByVal Chequera As Integer, ByVal NoConcil As Integer) As Decimal
        Dim oConciliadoAnterior As Decimal
        Dim oConSerial As Integer
        oConSerial = LibX.Data.Manager.GetScalar("select max(conc_serial) from cbconcm where chequera = " & Chequera.ToString & " and  conc_serial < " & NoConcil)
        oConciliadoAnterior = LibX.Data.Manager.GetScalar("select saldo_conciliado from cbconcm where chequera = " & Chequera.ToString & " and  conc_serial = " & oConSerial)
        Return oConciliadoAnterior
    End Function

    Function FechaAnterior(ByVal Chequera As Integer, ByVal FechaCorte As DateTime) As DateTime
        Dim oFecha As DateTime

        oFecha = LibX.Data.Manager.GetScalar("select top 1 conc_date from cbconcm " & _
                 " where chequera = " & Chequera.ToString & _
                 "   and conc_date < '" & FechaCorte.ToString(LibX.Data.Manager.GetSaveDateFormat) & _
                 "' order by chequera, conc_date DESC")

        Return oFecha
    End Function

    Public Function Aplicar(ByVal e As ParametrosAplicar) As Boolean
        Dim SelectStmt As String
        Dim oChequeraRow As DataRow
        Dim oTipoDocumento As TipoDocumento
        Dim oChequera As Chequera
        Dim Balance As Decimal
        Dim XUpdate As LibX.Data.XUpdateStmt

        '// Buscar el balance de la chequera
        oChequera = New Chequera(e.Chequera)

        Balance = oChequera.BalanceActual

        oTipoDocumento = New TipoDocumento(e.TipoDocumento, e.Chequera)

        '// Actualizar el balance de la chequera
        XUpdate = New LibX.Data.XUpdateStmt("cpchequera")

        If oTipoDocumento.Origen = 1 Then
            Balance = Balance + e.Monto
        Else
            Balance = Balance - e.Monto
        End If

        XUpdate.FieldsSet("balance_actual") = Balance
        XUpdate.Fields("chequera") = e.Chequera
        XUpdate.Execute()
    End Function

    Private Sub SetValue(ByVal oRow As DataRow)
        Codigo = Val(oRow!chequera.ToString.Trim)
        Nombre = oRow!descripcion.ToString.Trim
        CuentaBanco = oRow!cuenta_banco.ToString.Trim
        CuentaContable = oRow!cuenta_conta.ToString.Trim
        BalanceActual = Val(oRow!balance_actual.ToString.Trim)
        Banco = Val(oRow!ban_code.ToString.Trim)
    End Sub

    Public Function GenerarNumero(ByVal pChequera As Integer) As Integer
        Dim xUpdateStmt As LibX.Data.XUpdateStmt
        Dim UltNumero As Integer

        UltNumero = LibX.Data.Manager.GetScalar("select isnull(ultimo_no_cheque,0) from cpchequera " & " where chequera = " & pChequera.ToString)

        UltNumero += 1

        '// Actualizar el Numero
        xUpdateStmt = New LibX.Data.XUpdateStmt("cpchequera")
        xUpdateStmt.Fields("chequera") = pChequera
        xUpdateStmt.FieldsSet("ultimo_no_cheque") = UltNumero
        xUpdateStmt.Execute()

        xUpdateStmt.Dispose()

        Return UltNumero

    End Function
End Class
