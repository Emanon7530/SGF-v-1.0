Public Class ClienteContado
    Dim mSerie As Integer
    Dim mTel As String
    Dim mCompany As String
    Dim mAddress As String
    Dim mEmail As String
    Dim mPhone1 As String
    Dim mContacto As String
    Dim mTelArea As String
    Dim mRNC As String
    Dim mCStype As Integer

    Public Property Serie() As Integer
        Get
            Return mSerie
        End Get
        Set(ByVal Value As Integer)
            mSerie = Value
        End Set
    End Property

    Public Property Mail() As String
        Get
            Return mEmail
        End Get
        Set(ByVal Value As String)
            mEmail = Value
        End Set
    End Property

    Public Property Tel() As String
        Get
            Return mTel
        End Get
        Set(ByVal Value As String)
            mTel = Value
        End Set
    End Property

    Public Property Tel2() As String
        Get
            Return mPhone1
        End Get
        Set(ByVal Value As String)
            mPhone1 = Value
        End Set
    End Property

    Public Property Company() As String
        Get
            Return mCompany
        End Get
        Set(ByVal Value As String)
            mCompany = Value
        End Set
    End Property

    Public Property Contact() As String
        Get
            Return mContacto
        End Get
        Set(ByVal Value As String)
            mContacto = Value
        End Set
    End Property

    Public Property TelArea() As String
        Get
            Return mTelArea
        End Get
        Set(ByVal Value As String)
            mTelArea = Value
        End Set
    End Property

    Public Property Address() As String
        Get
            Return mAddress
        End Get
        Set(ByVal Value As String)
            mAddress = Value
        End Set
    End Property
    Public Property RNC() As String
        Get
            Return mRNC
        End Get
        Set(ByVal Value As String)
            mRNC = Value
        End Set
    End Property
    Public Property CSTYPE() As Integer
        Get
            Return mCStype
        End Get
        Set(ByVal Value As Integer)
            mCStype = Value
        End Set
    End Property

    Public Sub New(ByVal pSerial As Integer)

        mSerie = pSerial
        FillWithSerie()

    End Sub

    Public Sub New(ByVal pTel As String)
        mTel = pTel
        FillwithPhone()
    End Sub

    Public Sub New()
        mTel = ""
        mCompany = ""
        mContacto = ""
        mTelArea = ""
        mAddress = ""
        mPhone1 = ""
        mRNC = ""
        mCStype = ""
    End Sub

    '// Este metodo se blanqueo para que no haga nada cuando se invoke
    '// hasta nuevo aviso, ya que los clientes al contado no guardaran
    '// el no. de documento si no el no. de telefono del cliente
    Private Sub FillWithSerie()

    End Sub

    Private Sub FillwithPhone()
        Dim xSelect As LibX.Data.XSelecStmt
        Dim oRow As DataRow
        Dim SelectStmt As String
        Try
            xSelect = New LibX.Data.XSelecStmt("ftcustm")
            xSelect!phone = mTel

            oRow = xSelect.GetDataRow
            If oRow Is Nothing Then
                Throw New ApplicationException("No existe un cliente con esta serie")
            End If

            Fill(oRow)
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try


    End Sub

    Private Sub Fill(ByVal oRow)
        Try

            'mSerie = oRow!ftserial_no
            mTel = oRow!phone.ToString
            mCompany = oRow!company_name.ToString
            mContacto = oRow!cust_name.ToString
            mTelArea = oRow!area_code.ToString
            mAddress = oRow!address.ToString
            mPhone1 = oRow!phohe1.ToString
            mEmail = oRow!email.ToString
            mRNC = oRow!cust_rnc.ToString
            mCStype = oRow!cstype.ToString

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub
End Class
