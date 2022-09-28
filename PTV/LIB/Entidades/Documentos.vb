Public Class Documentos
    Public Enum TiposDocumentosEnum
        Domicilio
        Credito
        SegurosMedicos
        Devoluciones
        PedidoMercancias
        RecepcionMercancias
    End Enum

    Public Function GetAditionalInformation(ByVal Tipo As TiposDocumentosEnum, ByVal codigo As Object) As String
        Dim SelectStmt As String = ""
        Dim oRow As DataRow
        Dim AditionalInformation As String = ""

        Select Case Tipo
            '// CLIENTE A CREDITO
        Case TiposDocumentosEnum.Credito
                SelectStmt = "select cust_phone,rnc_id,cust_address, sector_name, city_name " & _
                             "  from cccustm, cccity city, ccsectorm sector " & _
                             " where cccustm.city_code = city.city_code " & _
                             "   and sector.city_code = cccustm.city_code " & _
                             "   and sector.sector_code = cccustm.sector_code " & _
                             "   and cccustm.cust_code = " & codigo.ToString.Trim

                oRow = LibX.Data.Manager.GetDataRow(SelectStmt)

                If oRow Is Nothing Then
                    Throw New ApplicationException("No se encontro este cliente")
                End If

                AditionalInformation = "Telefono " & oRow!cust_phone.ToString.Trim & vbCrLf & _
                                       "R n c " & oRow!rnc_id.ToString.Trim & vbCrLf & _
                                       "Dirección " & oRow!cust_address.ToString.Trim & vbCrLf & _
                                       "Sector " & oRow!sector_name.ToString.Trim & ", " & "Ciudad " & oRow!city_name.ToString.Trim

                '// CLIENTE A DOMICILIO
            Case TiposDocumentosEnum.Domicilio
                SelectStmt = "select cust_phone,rnc_id, cust_address, sector_name, city_name " & _
                             "  from cccustm left outer join cccity city " & _
                             " on city.city_code = cccustm.city_code " & _
                             " left outer join ccsectorm sector " & _
                             " on sector.city_code = cccustm.city_code " & _
                             "   and sector.sector_code = cccustm.sector_code " & _
                             "   where cccustm.cust_code = " & codigo.ToString.Trim

                oRow = LibX.Data.Manager.GetDataRow(SelectStmt)

                If oRow Is Nothing Then
                    Throw New ApplicationException("No se encontro este cliente")
                End If

                AditionalInformation = "Telefono " & oRow!cust_phone.ToString.Trim & vbCrLf & _
                                       "R n c " & oRow!rnc_id.ToString.Trim & vbCrLf & _
                                       "Dirección " & oRow!cust_address.ToString.Trim & vbCrLf & _
                                       "Sector " & oRow!sector_name.ToString.Trim & ", " & "Ciudad " & oRow!city_name.ToString.Trim

                '// DEVOLUCIONES
            Case TiposDocumentosEnum.Devoluciones
                SelectStmt = "select ftfactm.ftserial_no, " & _
                            " ftfactm.ftserial_afect," & _
                            " ftfactm.fact_nota," & _
                            " ftfactm.bus_name," & _
                            " ftfactm.dev_type," & _
                            " ftdevolt.dev_name," & _
                            " ftfactm.fact_cond," & _
                            " ftfactdv.type_code," & _
                            " ftfactdv.fact_number," & _
                            " ftfactdv.fact_date," & _
                            " (isnull(ftfactdv.fact_total,0) " & _
                            " + isnull(ftfactdv.itbis,0) - " & _
                            " isnull(ftfactdv.descto,0) - " & _
                            " isnull(ftfactdv.seg_amount,0)) fact_total " & _
                            " from ftfactm" & _
                            " left outer join ftfactm ftfactdv" & _
                            " on ftfactdv.ftserial_no = ftfactm.ftserial_afect" & _
                            " inner join ftdevolt" & _
                            " on ftdevolt.dev_type = ftfactm.dev_type " & _
                            " where ftfactm.ftserial_no = " & codigo.ToString.Trim

                oRow = LibX.Data.Manager.GetDataRow(SelectStmt)

                If oRow Is Nothing Then
                    Throw New ApplicationException("No se encontro este cliente")
                End If

                AditionalInformation = IIf(oRow!type_code.ToString.Trim = "", "", "TIPO: " & oRow!type_code.ToString.Trim) & _
                                       IIf(oRow!fact_number.ToString.Trim = "", "", ", NUMERO:" & oRow!fact_number.ToString.Trim & vbCrLf) & _
                                       IIf(LibX.IsNull(oRow!fact_date), "", "FECHA: " & CDate(IIf(LibX.IsNull(oRow!fact_date), DateTime.Now, oRow!fact_date)).ToString("dd/MM/yyyy")) & _
                                       IIf(Val(oRow!fact_total.ToString.Trim) <= 0, "", ", MONTO:" & CDec(oRow!fact_total).ToString("###,##0.00") & vbCrLf) & _
                                       "MOTIVO:" & oRow!dev_name.ToString.Trim & vbCrLf & _
                                       "CLIENTE: " & oRow!bus_name.ToString.Trim

                '// SEGURO MEDICO
            Case TiposDocumentosEnum.SegurosMedicos
                SelectStmt = "select sgasegm.aseg_poliza, " & _
                         " sgasegm.aseg_nombre, " & _
                         " plan_name,cia_name, " & _
                        " plan_cobertura, plan_descto " & _
                        " from sgasegm, sgplanm, sgciasm " & _
                        " where sgplanm.plan_serial = sgasegm.plan_serial " & _
                        " and sgciasm.cia_serial = sgasegm.cia_serial " & _
                        " and sgasegm.aseg_poliza = '" & codigo.ToString.Trim & "'"

                oRow = LibX.Data.Manager.GetDataRow(SelectStmt)

                If oRow Is Nothing Then
                    Throw New ApplicationException("No se encontro este cliente")
                End If

                AditionalInformation = "Poliza No " & oRow!aseg_poliza.ToString.Trim & vbCrLf & _
                                      "Compañía " & oRow!cia_name.ToString.Trim & vbCrLf & _
                                      "Plan " & oRow!plan_name.ToString.Trim & ", Cobertura " & oRow!plan_cobertura.ToString.Trim & _
                                      "%, Descuento " & oRow!plan_descto.ToString.Trim & "%"

            Case TiposDocumentosEnum.RecepcionMercancias

            Case TiposDocumentosEnum.PedidoMercancias

        End Select

        Return AditionalInformation
    End Function
End Class
