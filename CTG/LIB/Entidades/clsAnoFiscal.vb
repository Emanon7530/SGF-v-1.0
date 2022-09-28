Public Class AnoFiscal

    Public Enum ProcessStateEnum
        Continue = 1
        StopCurrent = 2
        Abort = 3
    End Enum
    Public Class IniciarEventArgs
        Inherits EventArgs
        Public Cantidad As Integer
        Public PeriodoActualNo As Integer
        Public Periodo As Periodo
        Public State As ProcessStateEnum
    End Class

    Public Event Iniciando(ByVal e As IniciarEventArgs)
    Public Event Iniciado(ByVal e As IniciarEventArgs)

    Public Class ParametrosIniciar
        Inherits SGT.Contabilidad.Common.ParameterBase

        Public Year As Integer
        Public Count As Integer
        Public From As Date
        Public Thru As Date
        Public CerrarActual As Boolean
        Public CerrarUnbalnced As Boolean
        Public SavePeriodo As Boolean = False
        Public SucCode As Integer

        Public ValoresRetorno As New CollectionPeriodo

    End Class

    Public Class ParametrosCerrar
        Public Year As Integer
        Public Number As Integer
        Public CerrarUnbalnced As Boolean
        Public Iniciar As Boolean
        Public Sucursal As Integer
    End Class

    Public Class ParametrosCalcularPeriodo
        Public AnoFiscal As Integer
        Public FechaInicio As Date
        Public FechaFinal As Date

        Public Class ValoresRetorno
            Public Shared AnoFiscal As Integer
            Public Shared FechaInicio As Date
            Public Shared FechaFinal As Date
        End Class
    End Class

    Public Function BuscarAnoFiscal() As Periodo
        Dim SelectStmt As String
        Dim oRow As DataRow
        Dim oPeriodo As Periodo
        Try

            oPeriodo = New Periodo
            SelectStmt = "select top 1 * from cgperdm " & _
                        " where perdm_status = 1"

            oRow = LibX.Data.Manager.GetDataRow(SelectStmt)

            If oRow Is Nothing Then
                Throw New ApplicationException("No existe ningun periodo definido")
            End If

            oPeriodo.year = Val(oRow!perdr_year.ToString)
            oPeriodo.Count = Val(oRow!perdr_count.ToString)
            oPeriodo.Description = oRow!perdr_descr.ToString
            oPeriodo.From = CType(oRow!from_date, Date)
            oPeriodo.Thru = CType(oRow!thru_date, Date)
            oPeriodo.Status = Val(oRow!perdm_status.ToString)

            Return oPeriodo
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function BuscarPeriodoPorFecha(ByVal pFecha As Date) As Periodo
        Dim oPeriodo As Periodo
        Dim SelectStmt As String
        Dim oRow As DataRow
        Try
            oPeriodo = New Periodo

            If IsDate(pFecha) = False Then
                Throw New ApplicationException("Fecha Inválida!")
            End If

            SelectStmt = String.Concat("select * from cgperdd", _
                                       " where '", pFecha.ToString(LibX.Data.Manager.GetSaveDateFormat), _
                                       "' between from_date and thru_date and suc_code = 1 ")

            oRow = LibX.Data.Manager.GetDataRow(SelectStmt)

            If oRow Is Nothing Then
                Return Nothing
            End If

            oPeriodo.year = Val(oRow!perdr_year.ToString)
            oPeriodo.Number = Val(oRow!perdr_num.ToString)
            oPeriodo.From = CType(oRow!from_date.ToString, Date)
            oPeriodo.Thru = CType(oRow!thru_date.ToString, Date)
            oPeriodo.Status = Val(oRow!perdr_status.ToString)
            oPeriodo.Begin = Val(oRow!perdr_begin.ToString)
            oPeriodo.SucCode = Val(oRow!suc_code.ToString)

            Return oPeriodo

        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function BuscarPeriodoPorNumero(ByVal pYear As Integer, ByVal pNumber As Integer) As Periodo
        Dim oPeriodo As Periodo
        Dim SelectStmt As String
        Dim oRow As DataRow
        Try

            If pYear <= 0 Then
                Throw New ApplicationException("Especifique un año válido!")
            End If

            If pNumber <= 0 Then
                Throw New ApplicationException("Especifique un periodo válido!")
            End If

            oPeriodo = New Periodo

            SelectStmt = String.Concat("select * from cgperdd", _
                                       " where perdr_year =", pYear.ToString, _
                                       " and perdr_num = ", pNumber.ToString & _
                                       " and suc_code = 1 ")

            oRow = LibX.Data.Manager.GetDataRow(SelectStmt)

            If oRow Is Nothing Then
                Return Nothing
            End If

            oPeriodo.year = Val(oRow!perdr_year.ToString)
            oPeriodo.Number = Val(oRow!perdr_num.ToString)
            oPeriodo.From = CType(oRow!from_date.ToString, Date)
            oPeriodo.Thru = CType(oRow!thru_date.ToString, Date)
            oPeriodo.Status = Val(oRow!perdr_status.ToString)
            oPeriodo.Begin = Val(oRow!perdr_begin.ToString)
            oPeriodo.SucCode = Val(oRow!suc_code.ToString)

            Return oPeriodo

        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function BuscarPeriodoActual() As Periodo
        Dim SelectStmt As String
        Dim oPeriodo As Periodo
        Dim oRow As DataRow
        Try
            oPeriodo = New Periodo

            '// Seleccionar el primer periodo en estatus abierto
            SelectStmt = String.Concat("select top 1 * from cgperdd", _
                                      " where perdr_status = '1'", _
                                      " order by perdr_year,perdr_num")

            oRow = LibX.Data.Manager.GetDataRow(SelectStmt)

            If oRow Is Nothing Then
                Throw New ApplicationException("No se encontrón periodo abierto!")
            End If

            oPeriodo.Thru = CType(oRow!thru_date, Date)
            oPeriodo.From = CType(oRow!from_date, Date)
            oPeriodo.Begin = CType(oRow!perdr_begin, Boolean)
            oPeriodo.Number = CType(oRow!perdr_num, Integer)
            oPeriodo.year = CType(oRow!perdr_year, Integer)
            oPeriodo.SucCode = CType(oRow!suc_code, Integer)

            Return oPeriodo

        Catch ex As Exception
            Throw

        Finally
            oRow = Nothing
        End Try
    End Function

    Public Function BuscarProximoPeriodo() As Periodo
        Dim SelectStmt As String
        Dim oPeriodo As Periodo
        Dim oRow As DataRow
        Try
            oPeriodo = BuscarPeriodoActual()

            '// Seleccionar el segundo periodo con estatus abierto
            SelectStmt = String.Concat("select * from cgperdd", _
                                      " where perdr_status = '1'", _
                                      "   AND perdr_year = ", oPeriodo.year.ToString, _
                                      "   and perdr_num = ", (oPeriodo.Number + 1).ToString, _
                                      "   and suc_code = 1 order by perdr_year,perdr_num ASC")

            oRow = LibX.Data.Manager.GetDataRow(SelectStmt)

            If oRow Is Nothing Then
                Throw New ApplicationException("No se encontrón periodo abierto!")
            End If

            oPeriodo.Thru = CType(oRow!thru_date, Date)
            oPeriodo.From = CType(oRow!from_date, Date)
            oPeriodo.Begin = CType(oRow!perdr_begin, Boolean)
            oPeriodo.Number = CType(oRow!perdr_num, Integer)
            oPeriodo.year = CType(oRow!perdr_year, Integer)
            oPeriodo.SucCode = CType(oRow!suc_code, Integer)

            Return oPeriodo

        Catch ex As Exception
            Throw

        Finally
            oRow = Nothing
        End Try
    End Function
    Public Function BuscarPeriodoAnterior() As Periodo
        Dim SelectStmt As String
        Dim oPeriodo As Periodo
        Dim oRow As DataRow
        Try
            oPeriodo = BuscarPeriodoActual()

            '// Seleccionar el segundo periodo con estatus abierto
            SelectStmt = String.Concat("select * from cgperdd", _
                                      " where perdr_status = '0'", _
                                      "   AND perdr_year = ", oPeriodo.year.ToString, _
                                      "   and perdr_num = ", (oPeriodo.Number - 1).ToString, _
                                      "   and suc_code = 1 order by perdr_year,perdr_num ASC")

            oRow = LibX.Data.Manager.GetDataRow(SelectStmt)

            If oRow Is Nothing Then
                Throw New ApplicationException("No se encontrón periodo abierto!")
            End If

            oPeriodo.Thru = CType(oRow!thru_date, Date)
            oPeriodo.From = CType(oRow!from_date, Date)
            oPeriodo.Begin = CType(oRow!perdr_begin, Boolean)
            oPeriodo.Number = CType(oRow!perdr_num, Integer)
            oPeriodo.year = CType(oRow!perdr_year, Integer)
            oPeriodo.SucCode = CType(oRow!suc_code, Integer)

            Return oPeriodo

        Catch ex As Exception
            Throw

        Finally
            oRow = Nothing
        End Try
    End Function

    Public Function CalcularProximo(ByVal p_Args As ParametrosCalcularPeriodo) As Boolean
        Dim BeginDate As Date
        Dim iMonths As Integer
        Dim iNewPer As Integer

        Try

            If IsDate(p_Args.FechaInicio) = False Then
                Throw New ApplicationException("Fecha de inicio inválida!")
            End If

            If IsDate(p_Args.FechaFinal) = False Then
                Throw New ApplicationException("Fecha de final inválida!")
            End If

            iMonths = DateDiff(DateInterval.Month, p_Args.FechaInicio, p_Args.FechaFinal) + 1

            p_Args.ValoresRetorno.FechaInicio = DateAdd(DateInterval.Month, iMonths, p_Args.FechaInicio)
            p_Args.ValoresRetorno.FechaFinal = DateAdd(DateInterval.Month, iMonths, p_Args.FechaFinal)
            p_Args.ValoresRetorno.AnoFiscal = p_Args.ValoresRetorno.FechaInicio.Year.ToString

            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Iniciar(ByVal p_Args As ParametrosIniciar) As Boolean
        Dim SelectStmt As String
        Dim oTable, oSucursal As DataTable
        Dim xInsert As LibX.Data.XInsertStmt
        Dim xUpdate As LibX.Data.XUpdateStmt
        Dim xSelect, xSelect1 As LibX.Data.XSelecStmt
        Dim oParam As ParametrosCalcularPeriodo
        Dim oPeriodo As Periodo
        Dim oMov As Movimientos
        Dim oArgs As IniciarEventArgs

        Dim BeginDate As Date
        Dim EndDate As Date
        Dim iMonths As Integer
        Dim iNewPer As Integer

        Try
            oMov = New Movimientos
            oArgs = New IniciarEventArgs
            xInsert = New LibX.Data.XInsertStmt("cgperdm")

            If IsDate(p_Args.From) = False Then
                Throw New ApplicationException("Fecha de inicio inválida!")
            End If

            If IsDate(p_Args.Thru) = False Then
                Throw New ApplicationException("Fecha final inválida!")
            End If

            If p_Args.Count <= 0 Then
                p_Args.Count = DateDiff(DateInterval.Month, p_Args.From, p_Args.Thru)
            End If

            If p_Args.Year <= 0 Then
                Throw New ApplicationException("Fecha final inválida!")
            End If

            '// Si cerrar el periodo actual y si no cerrar con movimientos desbalanceados
            If p_Args.CerrarActual = True And p_Args.CerrarUnbalnced = False Then
                If oMov.ExisteNoBalanceado(oPeriodo) = True Then
                    Throw New ApplicationException("Existen movimientos no balanceados!")
                End If
            End If

            '// Crear el detalle del nuevo periodo
            iNewPer = DateDiff(DateInterval.Month, p_Args.From, p_Args.Thru)
            iMonths = iNewPer / p_Args.Count
            iMonths *= 30.4

            '// CREAR EL ENCABEZADO
            If p_Args.SavePeriodo = True Then
                xSelect = New LibX.Data.XSelecStmt("cgperdm")
                xSelect1 = New LibX.Data.XSelecStmt("cgsucursal")

                oPeriodo = Me.BuscarAnoFiscal

                xSelect.Fields("perdr_year") = oPeriodo.year

                oTable = xSelect.GetTable
                oSucursal = xSelect1.GetTable

                If oTable.Rows.Count <= 0 Then
                    Throw New ApplicationException("Periodo No Existe, Verifique")
                End If

                xInsert = New LibX.Data.XInsertStmt("cgperdm")

                xInsert.Fields("perdr_year") = p_Args.Year
                xInsert.Fields("perdr_descr") = oPeriodo.Description.Replace(oPeriodo.year.ToString, p_Args.Year.ToString)
                xInsert.Fields("from_date") = p_Args.From
                xInsert.Fields("thru_date") = p_Args.Thru
                xInsert.Fields("perdm_status") = 1
                xInsert.Fields("perdr_count") = p_Args.Count
                xInsert.Fields("acct_utils") = oTable.Rows(0)!acct_utils
                xInsert.Fields("acct_superavit") = oTable.Rows(0)!acct_superavit
                xInsert.Fields("acct_anticipos") = oTable.Rows(0)!acct_anticipos

                xInsert.Execute()
            End If

            If p_Args.SavePeriodo = True Then
                xInsert = New LibX.Data.XInsertStmt("cgperdd")

                xInsert!perdr_year = p_Args.Year
                xInsert!from_date = LibX.Data.Manager.Connection.GetDate
                xInsert!thru_date = LibX.Data.Manager.Connection.GetDate
                xInsert!perdr_num = 0
                xInsert!perdr_status = "A"
                xInsert!perdr_begin = 1
                xInsert!suc_code = 0
            End If

            BeginDate = p_Args.From.AddDays(-1)

            ''SelectStmt = "select * from cgsucursal"
            ''oSucursal = LibX.Data.Manager.GetDataTable(SelectStmt)

            ''For Each oRow As DataRow In oSucursal.Rows

                For i As Integer = 1 To p_Args.Count
                    oPeriodo = New Periodo

                If i = 1 Then
                    BeginDate = DateSerial(p_Args.Year - 1, p_Args.From.Month, 1)
                Else
                    BeginDate = BeginDate.AddDays(1)
                End If

                If p_Args.SavePeriodo = True Then
                    xInsert.Parameters.Item("perdr_num").Value = i
                    xInsert.Parameters.Item("from_date").Value = BeginDate
                    xInsert.Parameters.Item("perdr_status").Value = Val(Periodo.PeriodoStatusEnum.Abierto)
                    xInsert.Parameters.Item("suc_code").Value = 1
                    ''xInsert.Parameters.Item("suc_code").Value = Val(oRow!suc_code)
                End If

                oPeriodo.Number = i

                oPeriodo.From = BeginDate

                If i <= p_Args.Count Then

                    BeginDate = DateSerial(BeginDate.Year, BeginDate.Month, DateTime.DaysInMonth(BeginDate.Year, BeginDate.Month))

                    If p_Args.SavePeriodo = True Then
                        xInsert.Parameters.Item("thru_date").Value = BeginDate
                    End If

                    oPeriodo.Thru = BeginDate
                Else
                    If p_Args.SavePeriodo = True Then
                        xInsert.Parameters.Item("thru_date").Value = p_Args.Thru
                    End If
                    oPeriodo.Thru = p_Args.Thru
                End If

                If i = 1 Then
                    If p_Args.SavePeriodo = True Then
                        xInsert.Parameters.Item("perdr_begin").Value = 1
                    End If
                    oPeriodo.Begin = 1
                Else
                    If p_Args.SavePeriodo = True Then
                        xInsert.Parameters.Item("perdr_begin").Value = 0
                    End If
                    oPeriodo.Begin = 0
                End If
                If p_Args.SavePeriodo = True Then
                    xInsert.Parameters.Item("suc_code").Value = 1
                    ''xInsert.Parameters.Item("suc_code").Value = Val(oRow!suc_code)
                End If

                oPeriodo.Status = Periodo.PeriodoStatusEnum.Abierto

                '// Ejecutar evento
                oArgs.Periodo = oPeriodo
                oArgs.State = ProcessStateEnum.Continue
                oArgs.Cantidad = p_Args.Count
                oArgs.PeriodoActualNo = i
                oPeriodo.SucCode = 1
                ''oPeriodo.SucCode = Val(oRow!suc_code)
                RaiseEvent Iniciando(oArgs)

                If oArgs.State = ProcessStateEnum.Abort Then
                    Throw New ApplicationException("Proceso abortado por el usuario!")
                End If

                If p_Args.SavePeriodo = True Then
                    xInsert.Execute()
                End If

                p_Args.ValoresRetorno.Add(oPeriodo)

                '// Ejecutar evento
                RaiseEvent Iniciado(oArgs)

                If oArgs.State = ProcessStateEnum.Abort Then
                    Throw New ApplicationException("Proceso abortado por el usuario!")
                End If
            Next
            ''Next
            Return True
        Catch ex As Exception
            Throw
        Finally
            xUpdate = Nothing
            xInsert = Nothing
            oTable = Nothing
            oParam = Nothing
            oPeriodo = Nothing
        End Try
    End Function

    Public Function CerrarPeriodo(ByVal p_args As ParametrosCerrar) As Boolean
        Dim XUpdate As LibX.Data.XUpdateStmt
        Dim XInsert As LibX.Data.XInsertStmt
        Dim oTable, oSucursal As DataTable

        Dim oMovimiento As Movimientos
        Dim oPeriodoActual As Periodo
        Dim oPeriodoSig As Periodo
        Dim oCuenta As Entidades.Cuenta
        Dim oSetup As SGT.Inventario.Common.Configuration
        Dim SelectStmt As String

        If p_args.Number <= 0 Then
            Throw New ApplicationException("Especifique un periodo válido!")
        End If

        If p_args.Year <= 0 Then
            Throw New ApplicationException("Especifique un Año válido!")
        End If

        '// Periodo Actual
        oPeriodoActual = BuscarPeriodoPorNumero(p_args.Year, p_args.Number)
        If oPeriodoActual.Status = Periodo.PeriodoStatusEnum.Cerrado Then
            Throw New ApplicationException("Este periodo ya esta cerrado")
        End If

        '// Periodo Siguiente
        Try
            oPeriodoSig = BuscarProximoPeriodo()
            If oPeriodoActual.Status = Periodo.PeriodoStatusEnum.Cerrado Then
                Throw New ApplicationException("El Próximo periodo ya esta cerrado")
            End If

        Catch ex As Exception
            oPeriodoSig = Nothing
        End Try

        '// SI NO SE INDICO QUE CIERRE EL PERIODO CON ENTRADAS DESBALANCEADAS
        '// Y EXISTEN ALETARTAR
        If p_args.CerrarUnbalnced = False Then
            oMovimiento = New Movimientos
            If oMovimiento.ExisteNoBalanceado(oPeriodoActual) = True Then
                Throw New ApplicationException("Existen movimientos desbalanceados")
            End If
        End If

        If Not oPeriodoSig Is Nothing Then
            '// SI NO ES EL PERIODO INICIAL BUSCAR LOS BALANCES DEL PERIODO ANTERIOR
            '// Y AGREGARLOS COMO BALANCE INICIAL AL NUEVO PERIODO
            'If oPeriodoActual.Begin = False If p_Args.Sucursal > 0 Then

            If p_args.Sucursal > 0 Then
                SelectStmt = "select * from cgsucursal where suc_code = " & p_args.Sucursal
            Else
                SelectStmt = "select * from cgsucursal"
            End If
            oSucursal = LibX.Data.Manager.GetDataTable(SelectStmt)

            For Each oRow1 As DataRow In oSucursal.Rows
                SelectStmt = String.Concat("select * from cgacctd ", _
                                            " where perdr_year = ", p_args.Year.ToString, _
                                            "   and perdr_num = ", p_args.Number.ToString, _
                                            " and suc_code =" & oRow1!suc_code)

                oTable = LibX.Data.Manager.GetDataTable(SelectStmt)

                If Not oTable Is Nothing Then
                    XInsert = New LibX.Data.XInsertStmt("cgacctd")
                    XInsert.Fields("acct_no") = ""
                    XInsert.Fields("dept_code") = 0
                    XInsert.Fields("perdr_num") = oPeriodoSig.Number
                    XInsert.Fields("perdr_year") = oPeriodoSig.year
                    XInsert.Fields("initial") = 0
                    XInsert.Fields("debit_amount") = 0
                    XInsert.Fields("credit_amount") = 0
                    XInsert.Fields("balance") = 0
                    XInsert.Fields("balance_acum") = 0
                    XInsert.Fields("suc_code") = 0

                    For Each oRow As DataRow In oTable.Rows
                        XInsert.Fields("acct_no").value = oRow!acct_no.ToString
                        XInsert.Fields("dept_code").value = oRow!dept_code
                        XInsert.Fields("balance").value = 0
                        XInsert.Fields("balance_acum").value = oRow!balance_acum
                        XInsert.Fields("initial").value = oRow!balance_acum
                        XInsert.Fields("suc_code").value = oRow!suc_code
                        XInsert.Execute()
                    Next
                End If

                oCuenta = New Entidades.Cuenta
                oSetup = New SGT.Inventario.Common.Configuration

                oCuenta.Buscar(oSetup.CuentaInventario, p_args.Number)

                '// CERRAR EL PERIODO ACTUAL
                XUpdate = New LibX.Data.XUpdateStmt("cgperdd")
                XUpdate.FieldsSet("perdr_status") = 0
                XUpdate.Fields("perdr_year") = p_args.Year
                XUpdate.Fields("perdr_num") = p_args.Number
                XUpdate.Fields("suc_code") = oRow1!suc_code

                XUpdate.Execute()
            Next
        End If

        Return True
    End Function
    Public Function ReversarPeriodo(ByVal p_args As ParametrosCerrar) As Boolean
        Dim XUpdate As LibX.Data.XUpdateStmt
        Dim XDelete As LibX.Data.XDeleteStmt
        Dim oTable, oSucursal As DataTable

        Dim oMovimiento As Movimientos
        Dim oPeriodoActual As Periodo
        Dim oPeriodoSig As Periodo
        Dim oCuenta As Entidades.Cuenta
        Dim oSetup As SGT.Inventario.Common.Configuration
        Dim SelectStmt As String

        If p_args.Number <= 0 Then
            Throw New ApplicationException("Especifique un periodo válido!")
        End If

        If p_args.Year <= 0 Then
            Throw New ApplicationException("Especifique un Año válido!")
        End If

        '// Periodo Actual
        oPeriodoActual = BuscarPeriodoPorNumero(p_args.Year, p_args.Number)
        If oPeriodoActual.Status = Periodo.PeriodoStatusEnum.Cerrado Then
            Throw New ApplicationException("Este periodo ya esta cerrado")
        End If

        '// Periodo Anterior
        Try
            oPeriodoSig = BuscarPeriodoAnterior()
            If oPeriodoActual.Status = Periodo.PeriodoStatusEnum.Cerrado Then
                Throw New ApplicationException("El Próximo periodo ya esta iniciado")
            End If

        Catch ex As Exception
            oPeriodoSig = Nothing
        End Try

        '''// SI NO SE INDICO QUE CIERRE EL PERIODO CON ENTRADAS DESBALANCEADAS
        '''// Y EXISTEN ALETARTAR
        ''If p_args.CerrarUnbalnced = False Then
        ''    oMovimiento = New Movimientos
        ''    If oMovimiento.ExisteNoBalanceado(oPeriodoActual) = True Then
        ''        Throw New ApplicationException("Existen movimientos desbalanceados")
        ''    End If
        ''End If

        If Not oPeriodoSig Is Nothing Then
            '// SI NO ES EL PERIODO INICIAL BUSCAR LOS BALANCES DEL PERIODO ANTERIOR
            '// Y AGREGARLOS COMO BALANCE INICIAL AL NUEVO PERIODO
            'If oPeriodoActual.Begin = False Then

            If p_args.Sucursal > 0 Then
                SelectStmt = "select * from cgsucursal where suc_code = " & p_args.Sucursal
            Else
                SelectStmt = "select * from cgsucursal"
            End If
            oSucursal = LibX.Data.Manager.GetDataTable(SelectStmt)

            For Each oRow1 As DataRow In oSucursal.Rows
                SelectStmt = String.Concat("select * from cgacctd ", _
                                            " where perdr_year = ", p_args.Year.ToString, _
                                            "   and perdr_num = ", p_args.Number.ToString, _
                                            "   and suc_code = ", oRow1!suc_code)

                oTable = LibX.Data.Manager.GetDataTable(SelectStmt)

                If Not oTable Is Nothing Then
                    XDelete = New LibX.Data.XDeleteStmt("cgacctd")
                    XDelete.Fields("perdr_year") = p_args.Year.ToString
                    XDelete.Fields("perdr_num") = p_args.Number.ToString
                    XDelete.Fields("suc_code") = oRow1!suc_code.ToString
                    XDelete.Execute()
                End If

                '// CERRAR EL PERIODO ACTUAL
                XUpdate = New LibX.Data.XUpdateStmt("cgperdd")
                XUpdate.FieldsSet("perdr_status") = 1
                XUpdate.Fields("perdr_year") = oPeriodoSig.year
                XUpdate.Fields("perdr_num") = oPeriodoSig.Number
                XUpdate.Fields("suc_code") = oRow1!suc_code

                XUpdate.Execute()
            Next
        End If

        Return True
    End Function


    Public Function ExistenPeriodosAbiertos(ByVal pYear As Integer) As Boolean
        Dim SelectStmt As String
        Dim Existen As Integer

        SelectStmt = "select count(*) from cgperdd " & _
                     " where perdr_year = " & pYear.ToString & _
                     "   and perdr_status = 1"

        Existen = LibX.Data.Manager.GetScalar(SelectStmt)

        If Existen > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function PeriodoCerrado(ByVal pYear As Integer, ByVal pNumber As Integer) As Boolean
        Dim SelectStmt As String
        Dim Existen As Integer

        SelectStmt = "select perdr_status from cgperdd " & _
                     " where perdr_year = " & pYear.ToString

        Existen = LibX.Data.Manager.GetScalar(SelectStmt)

        If Existen = 0 Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
