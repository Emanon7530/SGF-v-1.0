Public Class TipoDocumento
    Public Tipo As String
    Public Nombre As String
    Public Origen As Integer
    Public Numero As Integer
    Public Conciliable As Boolean
    Public CargoEmision As Decimal
    Public DocumentoCargo As String
    Public AutoNumerable As Boolean
    Public Sub New(ByVal pTipo As String, ByVal cHequera As Integer)
        Dim SelectStmt As String
        Dim oRow As DataRow

        SelectStmt = "select * from cgtrntpm " & _
                    " where tran_type = '" & pTipo.Trim & "' and chequera = " & cHequera.ToString.Trim

        oRow = LibX.Data.Manager.GetDataRow(SelectStmt)

        SetValue(oRow)

    End Sub

    Private Sub SetValue(ByVal oRow As DataRow)

        Tipo = oRow!tran_type.ToString.Trim
        Nombre = oRow!tran_Descr.ToString.Trim
        Origen = Val(oRow!origen.ToString.Trim)
        Numero = Val(oRow!tran_number.ToString.Trim)
        If Val(oRow!conciliable.ToString.Trim) = 1 Then
            Conciliable = True
        Else
            Conciliable = False
        End If

        CargoEmision = Val(oRow!cargo_emision.ToString.Trim)
        DocumentoCargo = oRow!tran_cargo.ToString.Trim
        AutoNumerable = oRow!auto_number

    End Sub

    Public Function GenerateNumber(ByVal type_code As String, ByVal chequera As Integer) As Integer
        Dim NewNumber As Integer
        Dim XUpdate As LibX.Data.XUpdateStmt
        Dim XSelect As LibX.Data.XSelecStmt
        Try
            XSelect = New LibX.Data.XSelecStmt("cgtrntpm", "select tran_number from cgtrntpm")
            XSelect.Parameters.Add("tran_type", type_code)
            XSelect.Parameters.Add("chequera", chequera)

            Numero = Val(XSelect.GetScalar().ToString)

            XUpdate = New LibX.Data.XUpdateStmt("cgtrntpm")
            NewNumber = Numero + 1

            XUpdate.FieldsSet("tran_number") = NewNumber
            XUpdate.Fields("tran_type") = type_code
            XUpdate.Fields("chequera") = chequera

            XUpdate.Execute()
            XUpdate.Dispose()
            XSelect.Dispose()

            Return NewNumber

        Catch ex As Exception
            LibX.Log.Add(ex)
            Return -1
        Finally

        End Try
    End Function
    Public Function NumberExiste(ByVal typeCode As String, ByVal cheQuera As Integer, ByVal docNumber As Integer) As Boolean
        Dim nUmber As Integer
        Dim SelectStmt As String
        Try
            SelectStmt = "select doc_number from cbdocsm " & _
                        " where tran_type = '" & typeCode.Trim & "' and chequera = " & cheQuera.ToString.Trim & _
                        " and doc_number = " & docNumber

            nUmber = LibX.Data.Manager.GetScalar(SelectStmt)
            If nUmber > 0 Then
                Return True
            Else
                SelectStmt = "select paym_number from cppaymm " & _
                        " where type_code = '" & typeCode.Trim & "' and chequera = " & cheQuera.ToString.Trim & _
                        " and paym_number = " & docNumber

                nUmber = LibX.Data.Manager.GetScalar(SelectStmt)
                If nUmber > 0 Then
                    Return True
                Else
                    Return False
                End If
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)
            Return -1
        End Try
    End Function
End Class
