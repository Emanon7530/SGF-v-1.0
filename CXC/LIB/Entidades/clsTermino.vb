Public Class Termino
    Shared mDiasDescuento As Integer
    Shared mDiasVencimiento As Integer
    Shared mPorcDescuento As Integer
    Shared mNombre As String
    Shared mCodigo As String
    Shared mOtroDescuento As Integer


    Public Sub New(ByVal Codigo As String)
        Dim SelectStmt As String
        Dim oRow As DataRow
        Try

            SelectStmt = "select * from cctermm " & _
                         " where term_code = '" & Codigo.Trim & "'"

            oRow = LibX.Data.Manager.GetDataRow(SelectStmt)

            If oRow Is Nothing Then
                Throw New ApplicationException("No existe termino con este código")
            End If

            mCodigo = oRow!term_code.ToString
            mNombre = oRow!term_name.ToString
            mDiasDescuento = Val(oRow!disc_days.ToString)
            mDiasVencimiento = Val(oRow!due_days.ToString)
            mPorcDescuento = Val(oRow!disc_pct.ToString)
            mOtroDescuento = Val(oRow!etico.ToString.Trim)

        Catch ex As Exception
            LibX.Log.Add(ex)

        End Try
    End Sub

    Public Shared Property Nombre() As String
        Get
            Return mNombre
        End Get
        Set(ByVal Value As String)
            mNombre = Value
        End Set
    End Property

    Public Shared Property Codigo() As String
        Get
            Return mCodigo
        End Get
        Set(ByVal Value As String)
            mCodigo = Value
        End Set
    End Property

    Public Shared Property DiasDescuento() As Integer
        Get
            Return mDiasDescuento
        End Get
        Set(ByVal Value As Integer)
            mDiasDescuento = Value
        End Set
    End Property

    Public Shared Property DiasVencimiento() As Integer
        Get
            Return mDiasVencimiento
        End Get
        Set(ByVal Value As Integer)
            mDiasVencimiento = Value
        End Set
    End Property

    Public Shared Property PorcDescuento() As Integer
        Get
            Return mPorcDescuento
        End Get
        Set(ByVal Value As Integer)
            mPorcDescuento = Value
        End Set
    End Property

    Public Shared Property OtroDescuento() As Integer
        Get
            Return mOtroDescuento
        End Get
        Set(ByVal Value As Integer)
            mOtroDescuento = Value
        End Set
    End Property

    Public Function CalcularFechaDescuento(ByVal FechaDocumento As Date) As Date
        Dim FechaDescuento As Date
        Try

            FechaDescuento = FechaDocumento.AddDays(mDiasDescuento)

            Return FechaDescuento

        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try
    End Function
    Public Function CalcularVencimiento(ByVal FechaDocumento As Date) As Date
        Dim FechaVencimiento As Date
        Try

            FechaVencimiento = FechaDocumento.AddDays(mDiasVencimiento)

            Return FechaVencimiento

        Catch ex As Exception
            LibX.Log.Add(ex)

        End Try
    End Function

    Public Function CalcularDescuento(ByVal Monto As Decimal) As Decimal
        Dim MontoDescuento As Decimal
        Try

            MontoDescuento = Monto * (mPorcDescuento / 100)

            Return MontoDescuento

        Catch ex As Exception
            LibX.Log.Add(ex)
            Return -1
        End Try
    End Function
    Public Function CalcularOtroDescuento(ByVal Monto As Decimal) As Decimal
        Dim OtroDescuento As Decimal
        Try

            OtroDescuento = Monto * (mOtroDescuento / 100)

            Return OtroDescuento

        Catch ex As Exception
            LibX.Log.Add(ex)
            Return -1
        End Try
    End Function

End Class
