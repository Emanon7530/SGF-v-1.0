Public Class UnidadMedida
    Public Class ParametroConvertir
        Public Producto As String
        Public Cantidad As decimal
        Public UnidadOrigen As String
        Public UnidadDestino As String

        Public Class ValoresRetorno
            Public Cantidad As decimal
            Public Factor As Decimal
        End Class

        Public Retorno As New ValoresRetorno
    End Class

    Public Class ParametroConvertirUnidadMinima
        Public Producto As String
        Public Cantidad As Integer
        Public UnidadOrigen As String
        Public TipoDocumento As String

        Public Class ValoresRetorno
            Public Unidad As String
            Public Cantidad As decimal
            Public Factor As Decimal
        End Class

        Public Retorno As New ValoresRetorno
    End Class

    Public Class ParametroConvertirValor
        Public Producto As String
        Public Valor As Decimal
        Public UnidadOrigen As String
        Public UnidadDestino As String

        Public Class ValoresRetorno
            Public Valor As Decimal
            Public Factor As Decimal
        End Class

        Public Retorno As New ValoresRetorno
    End Class

    Public Function GetFactor(ByVal Producto As String, ByVal Unidad As String) As Decimal
        Dim SelectStmt As String
        Dim Factor As Decimal

        Try
            SelectStmt = "select cast(factor as decimal) from ivunitd" & _
                         " where unit_code = '" & Unidad.Trim & "'" & _
                         "   and item_code = '" & Producto.Trim & "'"

            Factor = LibX.Data.Manager.GetScalar(SelectStmt)

            If Factor <= 0 Then
                Factor = 1
            End If

            Return Factor

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Function
    Public Function GetFactorMinimo(ByVal Producto As String) As Decimal
        Dim SelectStmt As String
        Dim Pminimo As Decimal
        Try

            SelectStmt = "select price from ivitemd where item_code = '" & Producto.Trim & "'"

            Pminimo = LibX.Data.Manager.GetScalar(SelectStmt)
            If Pminimo <= 0 Then
                Pminimo = 1
            End If

            Return Pminimo

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Function
    Public Function GetUnidadMinimaVenta(ByVal Producto As String) As String
        Dim SelectStmt As String
        Dim Unidad As String
        Try
            SelectStmt = "select unit_code from ivunitd" & _
                         " where item_code = '" & Producto.Trim & "'" & _
                         "   and factor in (select min(factor) from ivunitd " & _
                                            " where item_code = '" & Producto.Trim & "')"

            Unidad = LibX.Data.Manager.GetScalar(SelectStmt)

            Return Unidad

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Function
    Public Function GetUnidadVendida(ByVal Producto As String, ByVal Sunidad As String) As String
        Dim SelectStmt As String
        Dim Unidad As String
        Try
            SelectStmt = "select unit_code from ivunitd" & _
                         " where item_code = '" & Producto.Trim & "'" & _
                         "   and unit_code = '" & Sunidad.Trim & "'"

            Unidad = LibX.Data.Manager.GetScalar(SelectStmt)

            Return Unidad

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Function
    Public Function ConfirmarUnidad(ByVal Producto As String, ByVal Unidad As String) As String
        Dim SelectStmt As String
        Try
            SelectStmt = "select unit_code from ivunitd" & _
                         " where item_code = '" & Producto.Trim & "'" & _
                         "   and unit_code = '" & Unidad.Trim & "'"

            Unidad = LibX.Data.Manager.GetScalar(SelectStmt)

            Return Unidad

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Function

    Public Function ConvertirUnidadMinima(ByVal e As ParametroConvertirUnidadMinima) As Boolean
        Dim FactorOrigen As Decimal
        Dim FactorDestino As Decimal
        Dim UnidadDestino As String
        Dim CantidadDestino As Integer
        Dim Tipo As String
        Try

            If e.TipoDocumento = "DEV" Then
                UnidadDestino = GetUnidadVendida(e.Producto, e.UnidadOrigen)
            Else
                UnidadDestino = GetUnidadMinimaVenta(e.Producto)
            End If

            FactorOrigen = GetFactor(e.Producto, e.UnidadOrigen)
            FactorDestino = GetFactor(e.Producto, UnidadDestino)

            CantidadDestino = e.Cantidad * FactorOrigen
            CantidadDestino = CantidadDestino / FactorDestino

            e.Retorno.Unidad = UnidadDestino
            e.Retorno.Cantidad = CantidadDestino
            e.Retorno.Factor = FactorDestino

            Return True

        Catch ex As Exception
            LibX.Log.Show(ex)
            Return False
        End Try

    End Function

    Public Function ConvertirUnidad(ByVal e As ParametroConvertir) As Boolean
        Dim FactorOrigen As Decimal
        Dim FactorDestino As Decimal
        Dim CantidadDestino As Decimal

        Try

            FactorOrigen = GetFactor(e.Producto, e.UnidadOrigen)
            FactorDestino = GetFactor(e.Producto, e.UnidadDestino)

            CantidadDestino = e.Cantidad * FactorOrigen
            CantidadDestino = CantidadDestino / FactorDestino

            e.Retorno.Cantidad = CantidadDestino
            e.Retorno.Factor = FactorDestino

            Return True

        Catch ex As Exception
            LibX.Log.Show(ex)
            Return False
        End Try

    End Function

    Public Function ConvertirValor(ByVal e As ParametroConvertirValor) As Boolean
        Dim FactorOrigen As Decimal
        Dim FactorDestino As Decimal
        Dim PrecioMinimo As Decimal
        Dim CantidadDestino As Integer
        Try

            FactorOrigen = GetFactor(e.Producto, e.UnidadOrigen)
            FactorDestino = GetFactor(e.Producto, e.UnidadDestino)
            PrecioMinimo = GetFactorMinimo(e.Producto)

            '// Si el factor destino es mayor que 1 se divide 
            '// el valor entre el factor de la unidad destino
            '// de lo contrario
            '// se divide el valor entre el factor de la unidad origen
            'If FactorDestino > FactorOrigen Then
            '    e.Retorno.Valor = e.Valor * FactorDestino
            '    e.Retorno.Factor = FactorDestino
            'Else
            '    e.Retorno.Valor = e.Valor / FactorOrigen
            '    e.Retorno.Factor = FactorOrigen
            'End If

            If FactorOrigen > FactorDestino Then
                If FactorDestino > 1 Then
                    e.Retorno.Valor = e.Valor / FactorDestino
                    e.Retorno.Factor = FactorDestino
                Else
                    e.Retorno.Valor = e.Valor / FactorOrigen
                    e.Retorno.Factor = FactorOrigen
                End If
            ElseIf FactorOrigen < FactorDestino Then
                If FactorOrigen > 1 Then
                    e.Retorno.Valor = e.Valor * FactorOrigen
                    e.Retorno.Factor = FactorOrigen
                Else
                    e.Retorno.Valor = e.Valor * FactorDestino
                    e.Retorno.Factor = FactorDestino
                End If
            ElseIf FactorOrigen = FactorDestino Then
                If FactorOrigen > 1 Then
                    e.Retorno.Valor = PrecioMinimo * FactorOrigen
                    e.Retorno.Factor = FactorOrigen
                Else
                    e.Retorno.Valor = PrecioMinimo * FactorDestino
                    e.Retorno.Factor = FactorDestino
                End If
            Else
                e.Retorno.Valor = e.Valor
                e.Retorno.Factor = FactorDestino
            End If

            If e.Retorno.Valor > 0 Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
            Return False
        End Try

    End Function

End Class
