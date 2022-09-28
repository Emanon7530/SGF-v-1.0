Imports System.Web.Services
Imports Transferencia

<System.Web.Services.WebService(Namespace:="http://REDSOFT-PR1/WSSGF1/WSSGF1")> _
Public Class WSSGF1
    Inherits System.Web.Services.WebService

#Region " Web Services Designer Generated Code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Web Services Designer.
        InitializeComponent()

        'Add your own initialization code after the InitializeComponent() call

    End Sub

    'Required by the Web Services Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Web Services Designer
    'It can be modified using the Web Services Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents WebService1 As System.Web.Services.WebService
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.WebService1 = New System.Web.Services.WebService

    End Sub

    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        'CODEGEN: This procedure is required by the Web Services Designer
        'Do not modify it using the code editor.
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

#End Region

    ' WEB SERVICE EXAMPLE
    ' The HelloWorld() example service returns the string Hello World.
    ' To build, uncomment the following lines then save and build the project.
    ' To test this web service, ensure that the .asmx file is the start page
    ' and press F5.
    '

    <WebMethod()> _
Public Function GetProduct(ByVal itemCode As String) As String
        Dim oitem As ivitemm
        Dim nombre As String

        oitem = New ivitemm
        oitem.LoadByPrimaryKey(itemCode)

        nombre = oitem.s_Item_name

        Return nombre

    End Function

    <WebMethod()> _
    Public Function InsertarMaestro(ByVal oDataSet As DataSet) As Boolean
        Dim itemCode As String
        Dim whCode As Integer
        Dim oTrx As MyGeneration.dOOdads.TransactionMgr

        Try

            If oDataSet.Tables.Count <= 0 Then
                Return False
            End If

            If oDataSet.Tables.Contains("ivitemm") = False Then
                Return False
            End If

            '// Instanciar las tablas
            Dim oivitemm As New ivitemm
            Dim oivitemd As New ivitemd
            Dim oivreferm As New ivreferm
            Dim oivcbarram As New ivcbarram
            Dim oivunitd As New ivunitd
            

            oTrx = MyGeneration.dOOdads.TransactionMgr.ThreadTransactionMgr
            oTrx.BeginTransaction()

            '// Asignar Valores e insertar
            For Each oRow As DataRow In oDataSet.Tables.Item("ivitemm").Rows
                '// Insertar ivitemm
                oivitemm.InsertFromRow(oRow)

                '// Codigo del Producto
                itemCode = oRow!item_code.ToString.Trim

                '// Insertar ivitemd
                For Each oRow_ivitemd As DataRow In oDataSet.Tables.Item("ivitemd").Rows
                    '// Insertar almacen
                    oivitemd.InsertFromRow(oRow_ivitemd)

                    '// Asignar Valores e insertar
                    For Each oRow_ivreferm As DataRow In oDataSet.Tables.Item("ivreferm").Rows
                        '// Insertar Referencia
                        oivreferm.InsertFromRow(oRow_ivreferm)
                    Next

                    '// Asignar Valores e insertar
                    For Each oRow_ivcbarram As DataRow In oDataSet.Tables.Item("ivcbarram").Rows
                        oivcbarram.InsertFromRow(oRow_ivcbarram)
                    Next

                    '// Asignar Valores e insertar
                    For Each oRow_ivunitd As DataRow In oDataSet.Tables.Item("ivunitd").Rows
                        oivunitd.InsertFromRow(oRow_ivunitd)
                    Next
                Next
            Next

            oTrx.CommitTransaction()

            '// Matar instancias

            Return True

        Catch ex As Exception
            If oTrx Is Nothing Then
                oTrx.RollbackTransaction()
            End If

            Throw
        Finally
            oTrx.ThreadTransactionMgrReset()
            oTrx = Nothing

        End Try
    End Function
<WebMethod()> _
    Public Function InsertarCompra(ByVal oDataSet As DataSet) As Boolean
        Dim oTrx As MyGeneration.dOOdads.TransactionMgr

        Try

            If oDataSet.Tables.Count <= 0 Then
                Return False
            End If

            If oDataSet.Tables.Contains("cpinvcem") = False Then
                Return False
            End If

            '// Instanciar las tablas
            dim ocpinvcem as new cpinvcem
            
            oTrx = MyGeneration.dOOdads.TransactionMgr.ThreadTransactionMgr
            oTrx.BeginTransaction()

            '// Asignar Valores e insertar
            For Each oRow As DataRow In oDataSet.Tables.Item("cpinvcem").Rows
                '// Insertar cpinvcem
                ocpinvcem.InsertFromRow(oRow)
            Next

            oTrx.CommitTransaction()

            '// Matar instancias

            Return True

        Catch ex As Exception
            If oTrx Is Nothing Then
                oTrx.RollbackTransaction()
            End If

            Throw
        Finally
            oTrx.ThreadTransactionMgrReset()
            oTrx = Nothing

        End Try
    End Function

    <WebMethod()> _
    Public Function CrearEntradasFromSalidas(ByVal oDataSet As DataSet) As Boolean
        Dim itemCode As String
        Dim whCode As Integer
        Dim oTrx As MyGeneration.dOOdads.TransactionMgr

        Try

            If oDataSet.Tables.Count <= 0 Then
                Return False
            End If

            If oDataSet.Tables.Contains("ivdocsm") = False Then
                Return False
            End If

            '// Instanciar las tablas
            Dim oiventrdm As New iventrdm


            oTrx = MyGeneration.dOOdads.TransactionMgr.ThreadTransactionMgr
            oTrx.BeginTransaction()
            Dim EntradaSerial As Int16

            '// Asignar Valores e insertar
            For Each oRow As DataRow In oDataSet.Tables.Item("ivdocsm").Rows
                '// Insertar ivitemm
                EntradaSerial = oiventrdm.CreateFromRowSalida(oRow)


                '// Insertar ivitemd
                For Each oRow_ivitemd As DataRow In oDataSet.Tables.Item("ivdocsd").Rows
                    '// Insertar almacen
                    Dim oiventrdd As New iventrdd
                    oiventrdd.CreateFromRowSalida(oRow_ivitemd, oiventrdm.Entr_serial, oiventrdm.Total_amount, oiventrdm.Itbis_amount)
                Next
            Next

            oTrx.CommitTransaction()

            '// Matar instancias

            Return True

        Catch ex As Exception
            If oTrx Is Nothing Then
                oTrx.RollbackTransaction()
            End If

            Throw
        Finally
            oTrx.ThreadTransactionMgrReset()
            oTrx = Nothing

        End Try
    End Function
    <WebMethod()> _
    Public Function InsertarEntradaDiario(ByVal oDataSet As DataSet) As Boolean
        Dim traneSerial As String
        ''Dim whCode As Integer
        Dim oTrx As MyGeneration.dOOdads.TransactionMgr

        Try

            If oDataSet.Tables.Count <= 0 Then
                Return False
            End If

            If oDataSet.Tables.Contains("cgtranrm") = False Then
                Return False
            End If

            '// Instanciar las tablas
            Dim ocgtranrm As New cgtranrm
            Dim ocgtranrd As New cgtranrd

            oTrx = MyGeneration.dOOdads.TransactionMgr.ThreadTransactionMgr
            oTrx.BeginTransaction()

            '// Asignar Valores e insertar
            For Each oRow As DataRow In oDataSet.Tables.Item("ocgtranrm").Rows
                '// Insertar ivitemm
                ocgtranrm.InsertFromRow(oRow)

                '// Insertar ivitemd
                For Each oRow_ocgtranrd As DataRow In oDataSet.Tables.Item("cgtranrd").Rows
                    '// Insertar almacen
                    ocgtranrd.InsertFromRow(oRow_ocgtranrd)
                Next
            Next

            oTrx.CommitTransaction()

            '// Matar instancias

            Return True

        Catch ex As Exception
            If oTrx Is Nothing Then
                oTrx.RollbackTransaction()
            End If

            Throw
        Finally
            oTrx.ThreadTransactionMgrReset()
            oTrx = Nothing

        End Try
    End Function

End Class
