Public Class CollectionSeguimientoAsegurado
    Inherits CollectionBase

    Public Function Add(ByVal item As SeguimientoAsegurado) As Integer
        Me.List.Add(item)
    End Function

    Public Function AddByKey(ByVal item As SeguimientoAsegurado) As Integer
        For Each oItem As SeguimientoAsegurado In Me.List
            If oItem.Codigo = item.Codigo Then
                Me.List.Remove(oItem)
            End If
        Next
        Me.List.Add(item)

    End Function

    Public Function AddByProducto(ByVal item As SeguimientoAsegurado) As Integer
        For Each oItem As SeguimientoAsegurado In Me.List
            If oItem.Producto = item.Producto Then
                Me.List.Remove(oItem)
            End If
        Next
        Me.List.Add(item)
    End Function

    Public Function Add(ByVal Codigo As Integer, _
    ByVal FacturaSerial As Integer, _
    ByVal Fecha As DateTime, _
    ByVal Producto As String, _
    ByVal Cantidad As Integer, _
    ByVal Factor As Integer, _
    ByVal Unidad As String, _
    ByVal Dosis As Integer, _
    ByVal Dias As Integer, _
    ByVal Estatus As SeguimientoAsegurado.EstatusEnum) As Integer

        Dim oSegAseg As SeguimientoAsegurado

        oSegAseg = New SeguimientoAsegurado
        With oSegAseg
            .Codigo = Codigo
            .FacturaSerial = FacturaSerial
            .Fecha = Fecha
            .Producto = Producto
            .Cantidad = Cantidad
            .Factor = Factor
            .Unidad = Unidad
            .Dosis = Dosis
            .Dias = Dias
            .Estatus = Estatus
        End With

        Return Me.List.Add(oSegAseg)

    End Function

    Public Function IndexOf(ByVal pSeguimientoAsegurado As SeguimientoAsegurado) As Integer
        Return Me.List.IndexOf(pSeguimientoAsegurado)
    End Function

    Public Function GetbyIndex(ByVal index As Integer) As SeguimientoAsegurado
        Return CType(Me.List.Item(index), SeguimientoAsegurado)

    End Function

    Public Function GetbyKey(ByVal pCodigo As Integer) As SeguimientoAsegurado
        For Each oItem As SeguimientoAsegurado In Me.List
            If oItem.Codigo = pCodigo Then
                Return oItem
            End If
        Next

    End Function

    Public Function GetbyProducto(ByVal pProducto As String) As SeguimientoAsegurado
        For Each oItem As SeguimientoAsegurado In Me.List
            If oItem.Producto = pProducto Then
                Return oItem
            End If
        Next

    End Function

    Public Function SetEstatusByIndex(ByVal index As Integer, ByVal pEstatus As SeguimientoAsegurado.EstatusEnum) As SeguimientoAsegurado
        CType(Me.List.Item(index), SeguimientoAsegurado).Estatus = pEstatus

        Return CType(Me.List.Item(index), SeguimientoAsegurado)
    End Function


    Public Function Update() As Boolean
        For Each oItem As SeguimientoAsegurado In Me.List
            If oItem.Estatus = SeguimientoAsegurado.EstatusEnum.Added Then
                oItem.Save()
            End If

            If oItem.Estatus = SeguimientoAsegurado.EstatusEnum.Edited Then
                oItem.Update()
            End If

            If oItem.Estatus = SeguimientoAsegurado.EstatusEnum.Deleted Then
                oItem.Delete()
            End If
        Next

        Return True

    End Function

    Public Function SetFacturaSerial(ByVal pFacturaSerial As Integer) As Boolean
        For Each oItem As SeguimientoAsegurado In Me.List
            oItem.FacturaSerial = pFacturaSerial
        Next

        Return True

    End Function

End Class
