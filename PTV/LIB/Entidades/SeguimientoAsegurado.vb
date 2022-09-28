Public Class SeguimientoAsegurado
    Public Codigo As Integer
    Public FacturaSerial As Integer
    Public Fecha As DateTime
    Public Producto As String = ""
    Public Cantidad As Integer
    Public Factor As Integer
    Public Unidad As String = ""
    Public Dosis As Integer
    Public Dias As Integer
    Public Reposicion As DateTime
    Public Estatus As EstatusEnum = EstatusEnum.None

    Public Enum EstatusEnum
        Added = 1
        Edited = 2
        Deleted = 3
        None = 4
    End Enum
    Public Sub New()

    End Sub
    Public Sub New(ByVal pSeguimiento As Integer)

    End Sub

    Public Function Load()
        Dim SelectStmt As String
        Dim oRow As DataRow
        Try
            SelectStmt = "select ftfactd3.*, ftfactd.unit_code, ftfactd.factor, ftfactm.fact_date" & _
                            " from ftfactd3 " & _
                            " inner join ftfactd " & _
                           " on ftfactd3.ftserial_no= ftfactd.ftserial_no " & _
                           " ftfactd3.item_code = ftfactd.item_code " & _
                            " inner join ftfactm " & _
                           " on ftfactd3.ftserial_no= ftfactm.ftserial_no " & _
                           " where ftfactd3.item_code = '" _
                            & Me.Producto.ToString.Trim & _
                            "' and ftfactd3.ftserial_no = " & Me.FacturaSerial.ToString.Trim
            oRow = LibX.Data.Manager.GetDataRow(SelectStmt)

            If oRow Is Nothing Then
                Exit Function
            End If

            SetValues(oRow)

        Catch ex As Exception
            Throw
        End Try
    End Function

    Private Sub SetValues(ByVal oRow As DataRow)
        Codigo = Val(oRow!fact3_serial.ToString.Trim)
        FacturaSerial = Val(oRow!ftserial_no.ToString.Trim)
        Fecha = oRow!fact_date
        Producto = oRow!item_code.ToString.Trim
        Dosis = Val(oRow!dosis.ToString.Trim)
        Dias = Val(oRow!dias.ToString.Trim)
        Cantidad = Val(oRow!qty.ToString.Trim)
        Factor = Val(oRow!factor.ToString.Trim)
        Unidad = oRow!unit_code.ToString.Trim
        Reposicion = CDate(oRow!fact_date).AddDays(Dias)
        Estatus = EstatusEnum.None

    End Sub

    Public Function SetEstatus(ByVal pEstatus As EstatusEnum)
        Me.Estatus = pEstatus
    End Function

    Public Function Save() As Boolean

        Dim oftfactd3 As LibX.Data.XInsertStmt

        oftfactd3 = New LibX.Data.XInsertStmt("ftfactd3", "fact3_serial")

        oftfactd3!ftserial_no = FacturaSerial
        oftfactd3!fact_date = Fecha
        oftfactd3!item_code = Producto
        oftfactd3!dosis = Dosis
        oftfactd3!dias = Dias
        oftfactd3!qty = Cantidad
        oftfactd3!uso_continuo = 1

        Codigo = oftfactd3.Execute()

        'Codigo = oftfactd3!fact3_serial
        Return True

    End Function

    Public Function Delete() As Boolean

        Dim oftfactd3 As LibX.Data.XDeleteStmt

        oftfactd3 = New LibX.Data.XDeleteStmt("ftfactd3")

        oftfactd3!fact3_serial = Codigo

        oftfactd3.Execute()

        Return True

    End Function

    Public Function Update() As Boolean

        Dim oftfactd3 As LibX.Data.XUpdateStmt

        oftfactd3 = New LibX.Data.XUpdateStmt("ftfactd3")

        oftfactd3.Fields("fact3_serial") = Codigo
        oftfactd3!ftserial_no = FacturaSerial
        oftfactd3!fact_date = Fecha
        oftfactd3!item_code = Producto
        oftfactd3!dosis = Dosis
        oftfactd3!dias = Dias
        oftfactd3!qty = Cantidad
        oftfactd3!uso_continuo = 1

        oftfactd3.Execute()

        Return True

    End Function

End Class
