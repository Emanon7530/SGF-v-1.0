Public Class Afectado
    Public Serial As Integer
    Public Itbis As Decimal
    Public Descuento As Decimal
    Public Monto As Decimal
End Class

Public Class Afectados
    Inherits CollectionBase

    Public Function Add(ByVal value As Afectado) As Integer
        Return list.Add(value)
    End Function

    Public Function GetTotalItbis() As Decimal
        Dim ttItbis As Decimal = 0

        For Each oitem As Afectado In Me.List
            ttItbis += oitem.Itbis
        Next

        Return ttItbis
    End Function
    Public Function GetTotalDescto() As Decimal
        Dim ttDescto As Decimal = 0

        For Each oitem As Afectado In Me.List
            If oitem.Descuento > 0 Then
                ttDescto += oitem.Descuento
            End If
        Next

        Return ttDescto
    End Function
    Public Function GetTotalMonto() As Decimal
        Dim ttMonto As Decimal = 0

        For Each oitem As Afectado In Me.List
            ttMonto += oitem.Monto
        Next
        Return ttMonto

    End Function

    Public Function GetTotalItbisDevo() As Decimal
        Dim ttItbisDevo As Decimal = 0

        For Each oitem As Afectado In Me.List
            If oitem.Monto < 0 Then
                ttItbisDevo += oitem.Itbis * -1
            End If
        Next

        Return ttItbisDevo
    End Function

    Public Function GetTotalDesctoDevo() As Decimal
        Dim ttDesctoDevo As Decimal = 0

        For Each oitem As Afectado In Me.List

            If oitem.Monto < 0 Then
                ttDesctoDevo += oitem.Descuento * -1
            End If

        Next

        Return ttDesctoDevo
    End Function
    Public Function GetTotalDevo() As Decimal
        Dim ttDevo As Decimal = 0

        For Each oitem As Afectado In Me.List
            If oitem.Monto < 0 Then
                ttDevo += oitem.Monto * -1
            End If
        Next

        Return ttDevo
    End Function
    Public Function GetTotalNotaDebito() As Decimal
        Dim ttNdp As Decimal = 0

        For Each oitem As Afectado In Me.List
            If oitem.Monto < 0 Then
                ttNdp += oitem.Monto * -1
            End If
        Next

        Return ttNdp
    End Function

    Public Function add(ByVal Serial As Integer, ByVal Itbis As Decimal, ByVal Descuento As Decimal, ByVal Monto As Decimal) As Integer
        Dim oAfectado As New Afectado
        oAfectado.Monto = Monto
        oAfectado.Itbis = Itbis
        oAfectado.Serial = Serial
        oAfectado.Descuento = Descuento
        Return list.Add(oAfectado)
    End Function
End Class
