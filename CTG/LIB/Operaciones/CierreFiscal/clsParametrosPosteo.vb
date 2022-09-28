Public Class ParametrosPosteo
    Implements Intrefaces.IParametrosAplicar
    Dim _Fecha As Date
    Dim _Number As Integer
    Dim _NumeroDocumento As Integer
    Dim _Tipo As String
    Dim _Year As Integer


    Public Property Fecha() As Date Implements Intrefaces.IParametrosAplicar.Fecha
        Get
            Return _Fecha
        End Get
        Set(ByVal Value As Date)
            _Fecha = Value
        End Set
    End Property

    Public Property PeriodoNumber() As Integer Implements Intrefaces.IParametrosAplicar.Number
        Get
            Return _Number
        End Get
        Set(ByVal Value As Integer)
            _Number = Value
        End Set
    End Property

    Public Property DocumentoNumero() As Integer Implements Intrefaces.IParametrosAplicar.Numero
        Get
            Return _NumeroDocumento
        End Get
        Set(ByVal Value As Integer)
            _NumeroDocumento = Value
        End Set
    End Property

    Public Property TipoDocumento() As String Implements Intrefaces.IParametrosAplicar.Tipo
        Get
            Return _Tipo
        End Get
        Set(ByVal Value As String)
            _Tipo = Value
        End Set
    End Property

    Public Property Year() As Integer Implements Intrefaces.IParametrosAplicar.Year
        Get
            Return _Year
        End Get
        Set(ByVal Value As Integer)
            _Year = Value
        End Set
    End Property
End Class
