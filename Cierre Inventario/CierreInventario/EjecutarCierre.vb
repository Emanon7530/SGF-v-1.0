Public Class EjecutarCierre

    Private Function CierreExiste(ByVal pFecha As DateTime) As Boolean
        Dim oExist As Int16

        Dim SelectStmt As String
      
        SelectStmt = "select count(*) from CierreLog where Mes = " & pFecha.ToString("MM") & " and Ano = " & pFecha.ToString("yyyy")
        oExist = LibX.Data.Manager.GetScalar(SelectStmt)

        If oExist > 0 Then
            Return True
        Else
            Return False
            End If

        
    End Function

    Public Function CrearCierre(ByVal pFecha As DateTime) As Boolean
        Dim oArticulo As SGT.Inventario.Entidades.Articulo

        LibX.Data.Manager.OpenConnection()

        If CierreExiste(pFecha) = True Then
            Return True
        End If

        LibX.Data.Manager.Connection.BeginTransaction()

        oArticulo = New SGT.Inventario.Entidades.Articulo

        oArticulo.CerrarInventario(pFecha)

        MarcarCierre(pFecha)

        LibX.Data.Manager.Connection.CommitTransaction()

        Return True

    End Function

    'Public Function CierreResultado(ByVal pFecha As DateTime) As Boolean
    '    Dim num As Integer
    '    Dim year As Integer
    '    Dim FechaAnt As DateTime
    '    Dim oTable As DataTable
    '    Dim EstadoResultado As Decimal

    '    FechaAnt = pFecha.AddMonths(-1)

    '    Dim SelectStmt As String = _
    '                            "SELECT SUM(BALANCE) FROM (SELECT " & _
    '                            "    cgacctd.balance " & _
    '                            "        FROM " & _
    '                            "    cgacctm cgacctm INNER JOIN cgacctd cgacctd " & _
    '                            "ON cgacctm.acct_no = cgacctd.acct_no " & _
    '                            "and cgacctm.acct_contrl is not null " & _
    '                            "INNER JOIN cgperdd on cgacctd.perdr_num = cgperdd.perdr_num  " & _
    '                            "and cgacctd.perdr_year = cgperdd.perdr_year " & _
    '                            "        WHERE cgperdd.perdr_year = " & pFecha.Year.ToString & _
    '                            "and cgperdd.perdr_num = " & pFecha.Month.ToString & _
    '                            " UNION ALL " & _
    '                            "SELECT " & _
    '                            "	cgperdd.ic_balance balance " & _
    '                            " FROM cgperdd  " & _
    '                            " WHERE cgperdd.perdr_year = " & FechaAnt.Year.ToString & _
    '                            " and cgperdd.perdr_num = " & FechaAnt.Month.ToString & _
    '                            " UNION ALL  " & _
    '                            "SELECT  " & _
    '                            "	cgperdd.ic_balance balance  " & _
    '                            "        FROM cgperdd  " & _
    '                            "        WHERE cgperdd.perdr_year = " & pFecha.Year.ToString & _
    '                            "and cgperdd.perdr_num = " & pFecha.Month.ToString & ") as EstadoResultado"

    '    oTable = LibX.Data.Manager.GetDataTable(SelectStmt)


    '    LibX.Data.Manager.Connection.CommitTransaction()

    '    Return True
    'End Function

    Private Sub MarcarCierre(ByVal pFecha As DateTime)
        Dim oInsert As LibX.Data.XInsertStmt
        Dim Balance As Decimal
        Dim SelectStmt As String
        Dim oTable As DataTable
        Dim FechaAnt As DateTime

        oInsert = New LibX.Data.XInsertStmt("CierreLog")

        oInsert.Fields("Mes") = pFecha.Month
        oInsert.Fields("Ano") = pFecha.Year
        oInsert.Fields("FechaEjecucion") = DateTime.Now

        SelectStmt = "select * from cgperdd where perdr_year = " & pFecha.Year.ToString & " and perdr_num = " & pFecha.Month.ToString & " and suc_code = 1 "
        oTable = LibX.Data.Manager.GetDataTable(SelectStmt, "cgperdd", True)

        If oTable Is Nothing Then
            Exit Sub
        End If

        '// Calcular Inventario Final
        SelectStmt = "select sum(isnull(onhand,0) * isnull(cost,0)) from ivcierrm where cierr_date = '" & pFecha.ToString("yyyy/MM/dd") & "'"
        Balance = LibX.Data.Manager.GetScalar(SelectStmt)

        oTable.Rows(0)!ic_balance = Balance

        '// Calcular Utilidad Neta
        FechaAnt = pFecha.AddMonths(-1)
        '''SelectStmt = _
        '''                        "SELECT SUM(isnull(BALANCE,0)) AS Balance FROM (SELECT " & _
        '''                        "    isnull(cgacctd.balance,0) " & _
        '''                        "        FROM " & _
        '''                        "    cgacctm cgacctm INNER JOIN cgacctd cgacctd " & _
        '''                        "   ON cgacctm.acct_no = cgacctd.acct_no " & _
        '''                        "   and cgacctm.acct_contrl is not null " & _
        '''                        "   INNER JOIN cgperdd on cgacctd.perdr_num = cgperdd.perdr_num  " & _
        '''                        "   and cgacctd.perdr_year = cgperdd.perdr_year " & _
        '''                        "        WHERE cgperdd.perdr_year = " & pFecha.Year.ToString & _
        '''                        "   and cgperdd.perdr_num = " & pFecha.Month.ToString & _
        '''                        "   UNION ALL " & _
        '''                        "   SELECT " & _
        '''                        "	isnull(cgperdd.ic_balance,0) balance " & _
        '''                        "   FROM cgperdd  " & _
        '''                        "   WHERE cgperdd.perdr_year = " & FechaAnt.Year.ToString & _
        '''                        "   and cgperdd.perdr_num = " & FechaAnt.Month.ToString & _
        '''                        "   UNION ALL  " & _
        '''                        "   SELECT  " & _
        '''                        "	isnull(cgperdd.ic_balance,0) balance  " & _
        '''                        "        FROM cgperdd  " & _
        '''                        "        WHERE cgperdd.perdr_year = " & pFecha.Year.ToString & _
        '''                        "   and cgperdd.perdr_num = " & pFecha.Month.ToString & ") as EstadoResultado"

        '''Balance = LibX.Data.Manager.GetScalar(SelectStmt)

        '''oTable.Rows(0)!result_balance = Balance

        LibX.Data.Manager.Save(oTable)

        oInsert.Execute()

       
    End Sub

End Class
