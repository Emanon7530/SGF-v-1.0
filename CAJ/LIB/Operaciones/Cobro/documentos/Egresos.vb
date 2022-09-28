Public Class Egresos

    Private Const Linea_En_Blanco As String = "  "

    Public Shared Function GetEgresos(ByVal parametros As EgresoParametros) As String()

        Dim s_records(19) As String

        s_records(0) = Linea_En_Blanco
        s_records(1) = "                 RECIBO DE EGRESOS                  "
        s_records(2) = String.Format(parametros.Direccion)
        s_records(3) = String.Format("{0}      {1}", parametros.Telefono, parametros.Fecha)
        s_records(4) = String.Format("RNC: {0}", parametros.Rnc)
        s_records(5) = String.Format("CAJA : {0} ", parametros.Caja)
        s_records(6) = String.Format("CAJERA : {0}", parametros.Cajera)
        s_records(7) = String.Format("NUMERO : {0}   FECHA {1}", parametros.Numero, parametros.Fecha)
        s_records(8) = "------------------------------------------------------"
        s_records(9) = Linea_En_Blanco
        s_records(10) = String.Format("BENEFICIARIO: {0}      MONTO {1}", parametros.Beneficiario, parametros.Monto)
        s_records(11) = String.Format("CONCEPTO: {0}", parametros.Concepto)
        s_records(12) = Linea_En_Blanco
        s_records(13) = Linea_En_Blanco
        s_records(14) = Linea_En_Blanco
        s_records(15) = "          -----------------------------          "
        s_records(16) = String.Format("                {0}                 ", parametros.Beneficiario)
        s_records(17) = Linea_En_Blanco
        s_records(18) = Linea_En_Blanco
        s_records(19) = String.Format("                {0}                 ", parametros.Bottom)

        Return s_records

    End Function
End Class

Public Class EgresoParametros
    Private _caja As String
    Private _cajera As String
    Private _numero As String
    Private _fecha As String
    Private _beneficiario As String
    Private _monto As String
    Private _concepto As String
    Private _direccion As String
    Private _bottom As String
    Private _telefono As String
    Private _rnc As String

    Sub New(ByVal ftSerial As Integer)
        Dim oRow As DataRow
        Dim oTbale As DataTable
        Dim XSelect As LibX.Data.XSelecStmt

        XSelect = New LibX.Data.XSelecStmt("vw_ftnofiscal", "select * from vw_ftnofiscal where ftserial_no = " & ftSerial)
        oTbale = XSelect.GetTable

        oRow = oTbale.Rows(0)

        If oRow Is Nothing Then
            Exit Sub
        End If

        SetValue(oRow)
    End Sub
    Private Sub SetValue(ByVal oRow As DataRow)
        _caja = oRow!caja_nombre
        _cajera = oRow!caje_nombre
        _numero = oRow!fact_number
        _fecha = oRow!fact_date
        _beneficiario = oRow!cust_name
        _monto = oRow!fact_total
        _concepto = oRow!fact_nota
        _direccion = oRow!cust_address
        _bottom = String.Empty
        _telefono = oRow!cust_phone
        _rnc = oRow!rnc_id
    End Sub

    Public Property Caja() As String
        Get
            Return _caja
        End Get
        Set(ByVal Value As String)
            _caja = Value
        End Set
    End Property

    Public Property Cajera() As String
        Get
            Return _cajera
        End Get
        Set(ByVal Value As String)
            _cajera = Value
        End Set
    End Property

    Public Property Numero() As String
        Get
            Return _numero
        End Get
        Set(ByVal Value As String)
            _numero = Value
        End Set
    End Property

    Public Property Fecha() As String
        Get
            Return _fecha
        End Get
        Set(ByVal Value As String)
            _fecha = Value
        End Set
    End Property

    Public Property Beneficiario() As String
        Get
            Return _beneficiario
        End Get
        Set(ByVal Value As String)
            _beneficiario = Value
        End Set
    End Property

    Public Property Monto() As String
        Get
            Return _monto
        End Get
        Set(ByVal Value As String)
            _monto = Value
        End Set
    End Property

    Public Property Concepto() As String
        Get
            Return _concepto
        End Get
        Set(ByVal Value As String)
            _concepto = Value
        End Set
    End Property

    Public Property Direccion() As String
        Get
            Return _direccion
        End Get
        Set(ByVal Value As String)
            _direccion = Value
        End Set
    End Property

    Public Property Bottom() As String
        Get
            Return _bottom
        End Get
        Set(ByVal Value As String)
            _bottom = Value
        End Set
    End Property

    Public Property Telefono() As String
        Get
            Return _telefono
        End Get
        Set(ByVal Value As String)
            _telefono = Value
        End Set
    End Property

    Public Property Rnc() As String
        Get
            Return _rnc
        End Get
        Set(ByVal Value As String)
            _rnc = Value
        End Set
    End Property

End Class
