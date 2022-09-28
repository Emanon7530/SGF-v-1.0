Public Class Permission
    Public Enum TipoAutorizacionEnum
        Descuento = 1
        VerCostos = 2
        AnularDocumento = 3
        PrecioFueraLimite = 4
        Todas = 5
        VentasVencimiento = 6
    End Enum

    Public Class ParametrosValidar
        Public UserID As Integer
        Public AccessKey As String = ""
        Public Password As String = ""
    End Class

    Dim _Descuento As Decimal
    Dim _Vend As Integer
    Dim scDefault As Integer
    Dim _VendUser As Integer
    Dim _PermisionAutorizer As Hashtable

    Public Property PermisosAutorizados() As Hashtable
        Get
            Return _PermisionAutorizer
        End Get
        Set(ByVal Value As Hashtable)
            _PermisionAutorizer = Value
        End Set
    End Property
    Public Property PorcientoDescuento() As Decimal
        Get
            _Descuento = VendAutorized(_Vend)
            Return _Descuento
        End Get
        Set(ByVal Value As Decimal)
            _Descuento = Value

        End Set
    End Property

    Public Sub New()
        _PermisionAutorizer = New Hashtable

    End Sub
    Public Property VendUsuer() As Integer
        Get
            Return _VendUser
        End Get
        Set(ByVal Value As Integer)
            _VendUser = Value
        End Set
    End Property
    Public Function isAutorization(ByVal p_args As ParametrosValidar) As Boolean
        Dim frmAut As frmAutorization
        Dim SelectStmt As String
        Dim oRow As DataRow
        Try

            If _PermisionAutorizer.Contains(p_args.AccessKey) = True Then
                If _PermisionAutorizer.Item(p_args.AccessKey) = True Then
                    Return True
                End If
            End If

            SelectStmt = "select * from scaccess " & _
                        " where accesskey ='" & p_args.AccessKey.Trim & "'"

            oRow = LibX.Data.Manager.GetDataRow(SelectStmt)

            If oRow Is Nothing Then
                Throw New ApplicationException("No existe esta autorización (" & p_args.AccessKey.Trim & ")!")
            End If

            frmAut = New frmAutorization

            frmAut.Text = oRow!description.ToString.Trim

            If frmAut.ShowDialog <> Windows.Forms.DialogResult.Yes Then
                Return False
            End If

            p_args.UserID = frmAut.UserID
            p_args.Password = frmAut.Password.Trim

            _VendUser = p_args.UserID

            Return Validar(p_args)

        Catch ex As Exception
            LibX.Log.Add(ex)
            Return False
        Finally
            If Not frmAut Is Nothing Then
                frmAut.Dispose()
            End If
        End Try
    End Function

    Public Function Validar(ByVal p_Args As ParametrosValidar) As Boolean
        Dim SelectStmt As String
        Dim Existe As Integer
        Dim Result As Boolean
        Try
            scDefault = System.Configuration.ConfigurationSettings.AppSettings.Get("LibxScDefault")

            SelectStmt = "select count(*) from scasignm " & _
                         " where scasignm.userid = " & p_Args.UserID.ToString.Trim & _
                         "   and scasignm.accesskey = '" & p_Args.AccessKey.Trim & "'"

            Existe = Val(LibX.Data.Manager.GetScalar(SelectStmt).ToString.Trim)

            If Existe > 0 Then
                Result = True
            Else
                Result = False
            End If
            SelectStmt = "select vend_code from scusers where userid = " & p_Args.UserID.ToString.Trim & " and suc_code = " & scDefault
            _Vend = Val(LibX.Data.Manager.GetScalar(SelectStmt).ToString.Trim)

            If _PermisionAutorizer.Contains(p_Args.AccessKey) = True Then
                _PermisionAutorizer.Item(p_Args.AccessKey) = Result
            Else
                _PermisionAutorizer.Add(p_Args.AccessKey, Result)
            End If

            Return Result

        Catch ex As Exception
            Throw
        End Try
    End Function
    Public Function VendAutorized(ByVal Code As Integer) As Decimal
        Dim oRow As DataRow
        Dim SelectStmt As String

        Try
            SelectStmt = "select porc_descto from ftvendm where vend_code = '" & Code & "'"

            _Descuento = LibX.Data.Manager.GetScalar(SelectStmt)
            If _Descuento > 0 Then
                Return _Descuento
            Else
                Return 0
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
            Return 0
        End Try

    End Function

End Class
