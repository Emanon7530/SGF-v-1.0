Public Class Company

    Shared mCompID As Int16
    Shared mName As String
    Shared mAddress As String
    Shared mPhone1 As String
    Shared mPhone2 As String
    Shared mFax As String
    Shared mArea As String
    Shared mMail As String
    Shared mWebSite As String
    Shared mSigla As String
    Shared mSucCode As Int16

    Public Shared ReadOnly Property ID() As Integer
        Get
            If mCompID <= 0 Then
                Inicializa()
            End If
            Return mCompID
        End Get
    End Property
    Public Shared ReadOnly Property Name() As String
        Get
            If mName Is Nothing Then
                Inicializa()
            End If

            Return mName
        End Get
    End Property
    Public Shared ReadOnly Property Address() As String
        Get
            If mAddress Is Nothing Then
                Inicializa()
            End If

            Return mAddress
        End Get
    End Property
    Public Shared ReadOnly Property Area() As Int16
        Get
            If mArea <= 0 Then
                Inicializa()
            End If

            Return mArea
        End Get
    End Property
    Public Shared ReadOnly Property Phone1() As String
        Get
            If mPhone1 Is Nothing Then
                Inicializa()
            End If

            Return mPhone1
        End Get
    End Property
    Public Shared ReadOnly Property Phone2() As String
        Get
            If mPhone2 Is Nothing Then
                Inicializa()
            End If

            Return mPhone2
        End Get
    End Property
    Public Shared ReadOnly Property Fax() As String
        Get
            If mFax Is Nothing Then
                Inicializa()
            End If

            Return mFax
        End Get
    End Property
    Public Shared ReadOnly Property Mail() As String
        Get
            If mMail Is Nothing Then
                Inicializa()
            End If

            Return mMail
        End Get
    End Property

    Public Shared ReadOnly Property WebSite() As String
        Get
            If mWebSite Is Nothing Then
                Inicializa()
            End If

            Return mWebSite
        End Get
    End Property
    Public Shared ReadOnly Property Sigla() As String
        Get
            If mSigla Is Nothing Then
                Inicializa()
            End If

            Return mSigla
        End Get
    End Property
    Public Shared ReadOnly Property SucCode() As Integer
        Get
            If mSucCode <= 0 Then
                Inicializa()
            End If
            Return mSucCode
        End Get
    End Property
    Private Shared Sub Inicializa()
        Dim SelectStmt As String
        Dim oRow As DataRow
        Try

            SelectStmt = "select * from stinform"
            oRow = LibX.Data.Manager.GetDataRow(SelectStmt)

            If oRow Is Nothing Then
                Throw New ApplicationException("No existen datos de la compañia registrados!")
            End If

            mCompID = oRow!comp_id
            mName = oRow!comp_name.ToString
            mAddress = oRow!comp_address.ToString
            mPhone1 = oRow!comp_phone1.ToString
            mPhone2 = oRow!comp_phone2.ToString
            mFax = oRow!comp_fax.ToString
            mArea = Val(oRow!comp_area.ToString)
            mMail = oRow!comp_email.ToString
            mWebSite = oRow!comp_website.ToString
            mSigla = oRow!comp_sigla.ToString
            mSucCode = oRow!suc_code.ToString

            oRow = Nothing

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub
    Public Sub New()

    End Sub
End Class
