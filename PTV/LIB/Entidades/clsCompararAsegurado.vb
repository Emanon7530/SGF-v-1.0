Public Class clsCompararAsegurado
    Public Function ValidacionAsegurado(ByVal pCodAsegurado As String, ByVal mAutorizado As Decimal) As Boolean
        Dim SelectStmt As String
        Dim XSelect As LibX.Data.XSelecStmt
        Dim oTable As DataTable
        Dim tBalance As Decimal
        Dim tLimite As Decimal
        Dim tAcumulado As Decimal
        Try
            SelectStmt = "select * from sgasegm where aseg_poliza = '" & pCodAsegurado & "'"
            XSelect = New LibX.Data.XSelecStmt("sgasegm", SelectStmt)
            oTable = XSelect.GetTable(True)

            If Not LibX.IsNull(oTable.Rows(0)!aseg_balance) Then tBalance = oTable.Rows(0)!aseg_balance Else tBalance = 0
            If Not LibX.IsNull(oTable.Rows(0)!bal_acumulado) Then tAcumulado = oTable.Rows(0)!bal_acumulado Else tAcumulado = 0
            If Not LibX.IsNull(oTable.Rows(0)!aseg_limite) Then tLimite = oTable.Rows(0)!aseg_limite Else tLimite = 0
            tBalance = tBalance + mAutorizado
            tAcumulado = tAcumulado + mAutorizado

            If tLimite > 0 Then
                If tLimite >= tBalance Then
                    oTable.Rows(0)!aseg_balance = tBalance
                    oTable.Rows(0)!bal_acumulado = tAcumulado
                    LibX.Data.Manager.Save(oTable)
                    Return True
                Else
                    Return False
                End If
            Else
                Return True
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Function
    Public Function CoverturaDisponible(ByVal pCodAsegurado As String) As Decimal
        Dim SelectStmt As String
        Dim XSelect As LibX.Data.XSelecStmt
        Dim oTable As DataTable
        Dim mBalance As Decimal
        Dim mLimite As Decimal
        Dim mDisponible As Decimal
        Try
            SelectStmt = "select * from sgasegm where aseg_poliza = '" & pCodAsegurado & "'"
            XSelect = New LibX.Data.XSelecStmt("sgasegm", SelectStmt)
            oTable = XSelect.GetTable(True)

            If Not LibX.IsNull(oTable.Rows(0)!aseg_balance) Then mBalance = oTable.Rows(0)!aseg_balance Else mBalance = 0
            If Not LibX.IsNull(oTable.Rows(0)!aseg_limite) Then mLimite = oTable.Rows(0)!aseg_limite Else mLimite = 0
            mDisponible = mLimite - mBalance

            Return mDisponible
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Function
End Class
