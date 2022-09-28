Public Enum TipoUsuarioEnum
    Cajera = 1
    Vendedor = 2
    Mensajero = 3
    Supervisor = 4
End Enum

Public Class Cajera
    Public Code As Int16
    Public Name As String
    Public esCajera As Boolean
    Public Porc_Descuento As Integer
    Public Cargo As TipoUsuarioEnum

    Public Sub New()

    End Sub

    Public Function Load() As Boolean
        Dim SelectStmt As String = "select * from ftvendm "
        Dim oRow As DataRow
        Try

            SelectStmt = SelectStmt & _
                         " where vend_code = " & Code.ToString & " and vend_estatus =1 "

            oRow = LibX.Data.Manager.GetDataRow(SelectStmt)

            If oRow Is Nothing Then
                Return False
            End If

            SetValues(oRow)

            Return True
        Catch ex As Exception
            LibX.Log.Add(ex)

        End Try

    End Function

    Private Sub SetValues(ByVal oRow As DataRow)
        Code = oRow!vend_code
        Name = oRow!vend_name.ToString.Trim
        '//            esCajera = Val(oRow!vend_indcajera.ToString.Trim)
        Porc_Descuento = Val(oRow!porc_descto.ToString.Trim)
        Cargo = Val(oRow!vend_cargo.ToString.Trim)

        If Cargo = TipoUsuarioEnum.Cajera Then
            esCajera = True
        Else
            esCajera = False
        End If

    End Sub

    Public Sub New(ByVal pCode As Integer)
        Code = pCode
        Load()

    End Sub
End Class
