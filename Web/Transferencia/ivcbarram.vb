
' Generated by MyGeneration Version # (1.3.0.3)

Public Class ivcbarram 
	Inherits _ivcbarram

    Public Function InsertFromRow(ByVal oRow As DataRow) As Boolean
        If Me.LoadByPrimaryKey(oRow!barra) = False Then
            Me.AddNew()
        End If

        '// Salvar Producto
        With Me
            If Not oRow!Barra Is DBNull.Value Then .Barra = oRow!Barra.ToString.Trim
            If Not oRow!Item_code Is DBNull.Value Then .Item_code = oRow!Item_code
            If Not oRow!Unit_code Is DBNull.Value Then .Unit_code = oRow!Unit_code

            .Save()
        End With

        Return True
    End Function

End Class
