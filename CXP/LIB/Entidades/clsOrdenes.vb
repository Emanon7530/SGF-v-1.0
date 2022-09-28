Imports SGT
Imports SGT.Inventario
Imports SGT.Inventario.Entidades
Public Class Ordenes

    Public Class ParametrosGenerar
        Public FechaInicial As DateTime
        Public Periodo As Integer
        Public Suplidor As Integer
        Public Grupo As Integer
        Public SuplidorPrincipal As Boolean
    End Class


    Public Function Generar(ByVal p_Args As ParametrosGenerar) As Integer
        Dim SelectStmt As String
        Dim Serial As Integer
        Dim NumeroOrden As Integer

        Dim FechaPeriodoInicial As DateTime
        Dim oTable As DataTable
        Dim oDocumento As Inventario.Entidades.Documento

        Dim XInsertHeader As LibX.Data.XInsertStmt
        Dim XInsertDetail As LibX.Data.XInsertStmt

        FechaPeriodoInicial = DateAdd(DateInterval.Month, -3, p_Args.FechaInicial)

        SelectStmt = "select * from cpordestm " & _
                     " where ordest_date between '" & FechaPeriodoInicial.ToString(LibX.Data.Manager.GetSaveDateFormat) & _
                     "   and '" & p_Args.FechaInicial.ToString(LibX.Data.Manager.GetSaveDateFormat) & "'"

        oTable = LibX.Data.Manager.GetDataTable(SelectStmt)

        If Not oTable Is Nothing Then
            Throw New ApplicationException("Error buscando productos para ordenese!")
        End If

        If oTable.Rows.Count <= 0 Then
            Throw New ApplicationException("No se encontraron estadisticas para este periodo!")
        End If

        oDocumento = New Inventario.Entidades.Documento("ORD")

        NumeroOrden = oDocumento.GenerateNumber("ORD")

        XInsertHeader = New LibX.Data.XInsertStmt("cpordnm", "ordn_serial")
        XInsertHeader!type_code = "ORD"
        XInsertHeader!prov_code = p_Args.Suplidor
        XInsertHeader!ordn_date = p_Args.FechaInicial
        XInsertHeader!ordn_number = NumeroOrden
        XInsertHeader!ordn_status = 1 'Pendiente de Aplicar

        Serial = XInsertHeader.Execute

        XInsertDetail = New LibX.Data.XInsertStmt("cpordnd")
        XInsertDetail!whse_code = 0
        XInsertDetail!item_code = ""
        XInsertDetail!unit_code = ""
        XInsertDetail!qty = 0
        XInsertDetail!price = 0
        XInsertDetail!itbis = 0

        For Each oRow As DataRow In oTable.Rows
            XInsertDetail!ordn_serial = Serial
            XInsertDetail!whse_code = 1
            XInsertDetail!unit_code = ""
            XInsertDetail!item_code = oRow!item_cde
            XInsertDetail!qty = oRow!qty_sug
            XInsertDetail!price = 0
            XInsertDetail!itbis = 0

            XInsertDetail.Execute()
        Next

        Return NumeroOrden
    End Function
End Class
