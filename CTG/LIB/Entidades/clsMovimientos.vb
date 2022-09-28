Public Class Movimientos
    Public Class ParametrosCodificacion
        Public TipoDocumento As String
        Public Depto As String
        Public MontoBruto As Decimal
        Public Descuento As Decimal
        Public Impuesto As Decimal
        Public Devolucion As Decimal
        Public MontoNeto As Decimal
        Public DescuentoDevo As Decimal
        Public NotaDebito As Decimal
        Public Chequera As Integer
        Public Proveedor As Integer
        Public Modtype As String
        Public Sucursal As Integer
        Public RetIsr2 As Decimal
        Public RetIsr10 As Decimal
        Public RetItbis30 As Decimal
        Public RetItbis100 As Decimal
        Public PorcientoIsr As Decimal
        Public PorcientoItbis As Decimal
        Public RetornoCuentas As New SGT.Contabilidad.Entidades.CollectionCuentas
    End Class

    Public Function ExistenNoAplicados(ByVal pYear As Integer, ByVal pNumber As Integer) As Boolean
        Dim SelectStmt As String
        Dim Existen As Integer

        SelectStmt = "Select count(*) from cgtranrm " & _
                     " where perdr_year = " & pYear.ToString & _
                     "   and perdr_num = " & pNumber.ToString

        Existen = LibX.Data.Manager.GetScalar(SelectStmt)

        If Existen <= 0 Then
            Return False
        Else
            Return True
        End If

    End Function

    Public Function ExisteNoBalanceado(ByVal pPeriodo As Periodo) As Boolean
        Dim SelectStmt As String
        Dim oTablem As DataTable
        Try
            SelectStmt = String.Concat("select cgtranrd.suc_code,cgtranrd.tranr_serial, sum(case debit_credit ", _
                                        " when 1 then amount ", _
                                        " when -1 then 0 ", _
                                        " end) Debito, ", _
                                        " sum(case debit_credit  ", _
                                        " when -1 then amount ", _
                                        " when 1 then 0 ", _
                                        " end) Credito ", _
                                        " from cgtranrd inner join cgtranrm ", _
                                        " ON cgtranrm.tranr_serial = cgtranrd.tranr_serial ", _
                                        " WHERE perdr_year = ", pPeriodo.year.ToString, _
                                        " AND perdr_num = ", pPeriodo.Number.ToString, _
                                        "group by cgtranrd.suc_code,cgtranrd.tranr_serial")

            oTablem = LibX.Data.Manager.GetDataTable(SelectStmt)

            If oTablem.Rows.Count <= 0 Then
                Return False
            End If

            For Each oRow As DataRow In oTablem.Rows
                If oRow!Debito <> oRow!Credito Then
                    Return True
                End If
            Next

            Return False
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Function

    Public Function GetCodificacion(ByVal p_Args As ParametrosCodificacion) As Boolean
        Dim oTableAccount As DataTable
        Dim VentasExcentas As Decimal
        Dim VentasGrabadas As Decimal
        Dim Monto As Decimal

        Dim oConf As SGT.Inventario.Common.Configuration
        Dim oCodif As SGT.Contabilidad.Entidades.Codificacion
        Dim oDocument As SGT.Inventario.Entidades.Documento

        oConf = New SGT.Inventario.Common.Configuration
        oCodif = New SGT.Contabilidad.Entidades.Codificacion

        '// Calcular 
        VentasGrabadas = p_Args.Impuesto / (oConf.GetITBIS / 100)
        VentasExcentas = p_Args.MontoBruto - VentasGrabadas

        With p_Args.RetornoCuentas

            .Clear()

            '// buscar la codificación correspondiente
            oTableAccount = oCodif.BuscarPorCondicion(p_Args.TipoDocumento, Codificacion.CondicionEnum.Credito, p_Args.Proveedor, p_Args.Chequera, p_Args.Modtype)

            For Each oRowCodif As DataRow In oTableAccount.Rows
                Select Case Val(oRowCodif!orig_valor.ToString)

                    Case Entidades.Codificacion.OrigenValorEnum.MontoNeto
                        '''oDocument = New SGT.Inventario.Entidades.Documento(p_Args.TipoDocumento)
                        Monto = p_Args.MontoNeto

                    Case Entidades.Codificacion.OrigenValorEnum.MontoBruto
                        Monto = p_Args.MontoBruto

                    Case Entidades.Codificacion.OrigenValorEnum.Descuento
                        Monto = p_Args.Descuento

                    Case Entidades.Codificacion.OrigenValorEnum.Impuesto
                        Monto = p_Args.Impuesto

                    Case Entidades.Codificacion.OrigenValorEnum.Devolucion
                        Monto = p_Args.Devolucion

                    Case Entidades.Codificacion.OrigenValorEnum.DescuentoDevo
                        Monto = p_Args.DescuentoDevo

                    Case Entidades.Codificacion.OrigenValorEnum.MontoGrabado
                        Monto = VentasGrabadas

                    Case Entidades.Codificacion.OrigenValorEnum.MontoExcento
                        Monto = VentasExcentas

                    Case Entidades.Codificacion.OrigenValorEnum.NotaDebito
                        Monto = p_Args.NotaDebito

                    Case Entidades.Codificacion.OrigenValorEnum.RetIsr
                        ''//Asignar la retension de itbis calculada por el formato del suplidor(Pendiente)
                        Monto = p_Args.RetIsr2
                    Case Entidades.Codificacion.OrigenValorEnum.RetIsr2
                        ''//Asignar la retension de itbis calculada por el formato del suplidor(Pendiente)
                        Monto = p_Args.RetIsr10

                    Case Entidades.Codificacion.OrigenValorEnum.RetItbis
                        ''//Asignar la retension de impuesto sobre la renta calculada por el formato del suplidor(Pediente)
                        Monto = p_Args.RetItbis30

                    Case Entidades.Codificacion.OrigenValorEnum.RetItbis2
                        ''//Asignar la retension de impuesto sobre la renta calculada por el formato del suplidor(Pediente)
                        Monto = p_Args.RetItbis100

                End Select

                ''Asignar el origen de la cuenta
                oRowCodif!origen = IIf(Val(oRowCodif!origen.ToString) = 1, 1, -1)
                If Monto > 0 Then
                    .Add(oRowCodif!acct_no.ToString, p_Args.Depto, "", "", oRowCodif!origen, Monto)
                End If
            Next

        End With

        Return True

    End Function

End Class
