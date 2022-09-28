Public Class Configuracion

    Dim _ctautilidades As String
    Dim _ctautilidadesAnt As String
    Dim _ctaanticipos As String
    Dim _ctasuperavit As String
    Public ReadOnly Property CuentaUtilidadesAntieriores() As String
        Get
            Return _ctautilidadesAnt
        End Get
    End Property

    Public ReadOnly Property CuentaUtilidades() As String
        Get
            Return _ctautilidades
        End Get
    End Property

    Public ReadOnly Property CuentaAnticipos() As String
        Get
            Return _ctaanticipos
        End Get
    End Property

    Public ReadOnly Property CuentaSuperavit() As String
        Get
            Return _ctasuperavit
        End Get
    End Property


    Private Sub GetConf()
        Dim SelectStmt As String
        Dim oRow As DataRow

        SelectStmt = String.Concat("select * from cgconfm ")

        oRow = LibX.Data.Manager.GetDataRow(SelectStmt)

        If oRow Is Nothing Then
            Throw New ApplicationException("No se encontró configuración contable para este periodo ")
        End If

        _ctautilidades = oRow!acct_utilidades.ToString
        _ctautilidadesAnt = oRow!acct_utilidades_ant.ToString
        _ctaanticipos = oRow!acct_anticipos.ToString
        _ctasuperavit = oRow!acct_superavit.ToString

    End Sub

    Public Sub New(ByVal pYear As Integer, ByVal pNumber As Integer)
        GetConf()
    End Sub
End Class


