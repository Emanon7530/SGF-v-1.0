Public Class ClienteDomicilio
    Public Codigo As Integer
    Public Nombre As String
    Public Direccion As String
    Public Telefono As String
    Public Rnc As String
    Public Ciudad As Integer
    Public Sector As Integer
    Public NombreCiudad As String
    Public NombreSector As String
    Public Mensajero As Integer
    Public NombreMensajero As String
    Public FormaPago As String
    Public Cambio As Decimal
    Public TarjetaCodigo As Integer
    Public TarjetaNumero As String
    Public TarjteaVencimineto As String
    Public TarjetaTipo As Integer
    Public TarjetaTipoNombre As String
    Public TarjetaRecargo As Decimal
    Public Ftserial As Integer
    Public Apellidos As String

    Public Sub New()

    End Sub

    Public Sub New(ByVal pCodigo As Integer)
        Me.Codigo = pCodigo
    End Sub

    Public Function LoadbyFactura(ByVal pftserial_no As Integer)
        Dim SelectStmt As String
        Dim oRow As DataRow
        Try

            SelectStmt = "select cccustm.*,ftdomim.ftserial_no,domi_date,domi_cambio," & _
                         "vend_mensaj,domi_estatus,domi_pago,ftdomim.tarj_code, " & _
                         "tarj_tipo,tarj_numero,tarj_vence" & _
                         "  from ftdomim inner join cccustm " & _
                         "   on cccustm.cust_code = ftdomim.cust_code " & _
                         " left outer join pvtarjeta " & _
                         "   on pvtarjeta.tarj_code = ftdomim.tarj_code " & _
                         "   and ftdomim.tarj_code is not null " & _
                         " where ftdomim.ftserial_no = " & pftserial_no.ToString.Trim

            oRow = LibX.Data.Manager.GetDataRow(SelectStmt)

            If oRow Is Nothing Then
                Exit Function
            End If

            SetValues(oRow)

        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Load()
        Dim SelectStmt As String
        Dim oRow As DataRow
        Try

            SelectStmt = "select cccustm.*,ftdomim.ftserial_no,domi_date,domi_cambio," & _
                         "vend_mensaj,domi_estatus,domi_pago,ftdomim.tarj_code, " & _
                         "tarj_tipo,tarj_numero,tarj_vence" & _
                         "  from cccustm,ftdomim,pvtarjeta " & _
                         " where cccustm.cust_code = " & Me.Codigo.ToString.Trim & _
                         "   and ftdomim.tarj_code = pvtarjeta.tarj_code " & _
                         "   and ftdomim.cust_code = cccustm.cust_code " & _
                         "   and ftdomim.ftserial_no in (select max(ftserial_no) " & _
                         "                                 from ftdomim where ftdomim.cust_code = cccustm.cust_code)"



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
        Codigo = Val(oRow!cust_code.ToString.Trim)
        Nombre = oRow!cust_name.ToString.Trim
        Direccion = oRow!cust_address.ToString.Trim
        Telefono = oRow!cust_phone.ToString.Trim
        Rnc = oRow!rnc_id.ToString.Trim
        Ciudad = Val(oRow!city_code.ToString.Trim)
        Sector = Val(oRow!sector_code.ToString.Trim)
        NombreCiudad = ""
        NombreSector = ""
        Mensajero = 0
        NombreMensajero = ""
        FormaPago = oRow!domi_pago.ToString.Trim
        Cambio = Val(oRow!domi_cambio.ToString.Trim)
        TarjetaCodigo = Val(oRow!tarj_code.ToString.Trim)
        TarjetaNumero = Val(oRow!tarj_numero.ToString.Trim)
        TarjteaVencimineto = oRow!tarj_vence.ToString.Trim
        TarjetaTipo = Val(oRow!tarj_tipo.ToString.Trim)
        TarjetaTipoNombre = ""
        TarjetaRecargo = 0
        Ftserial = Val(oRow!ftserial_no.ToString.Trim)
        Apellidos = oRow!cust_apellidos.ToString.Trim
    End Sub


    Public Function GetAditionalInformation(ByVal pftserial_no As Integer) As String
        Dim SelectStmt As String
        Dim oRow As DataRow
        Dim AditionalInformation As String

        SelectStmt = "select cust_phone,rnc_id, cust_address, sector_name, city_name, " & _
                     " domi_pago, vend_name, tarj_numero,tarj_vence,domi_cambio " & _
                     " from ftdomim " & _
                     " inner join cccustm " & _
                     "   on cccustm.cust_code = ftdomim.cust_code " & _
                     " left outer join cccity city " & _
                     "   on city.city_code = cccustm.city_code " & _
                     " left outer join ccsectorm sector " & _
                     "   on sector.city_code = cccustm.city_code " & _
                     "  and sector.sector_code = cccustm.sector_code " & _
                     " left outer join ftvendm " & _
                     "   on ftvendm.vend_code = ftdomim.vend_mensaj" & _
                     " left outer join pvtarjeta " & _
                     "   on pvtarjeta.tarj_code = ftdomim.tarj_code " & _
                     " Where ftdomim.ftserial_no = " & pftserial_no.ToString.Trim & _
                     "  and ftdomim.cust_code = " & Codigo.ToString.Trim

        oRow = LibX.Data.Manager.GetDataRow(SelectStmt)

        If oRow Is Nothing Then
            Return ""
        End If

        '//Telefono     :999-999-9999
        '//Direccion    :XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
        '//Sector       :XXXXXXXXXXXXXXXXXXXX   Ciudad  :XXXXXXXXXXXXXXXXXXXXX
        '//Mensajero    :XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
        '//Forma/Pago   :XXX                    Cambio  :99,999.99
        '//No.Tarjeta   :9999-9999-9999-9999    Vence   :99/9999

        AditionalInformation = "Telefono " & oRow!cust_phone.ToString.Trim & vbCrLf & _
                               "R n c " & oRow!rnc_id.ToString.Trim & vbCrLf & _
                               "Dirección " & oRow!cust_address.ToString.Trim & vbCrLf & _
                               "Sector " & oRow!sector_name.ToString.Trim & ", " & "Ciudad " & oRow!city_name.ToString.Trim & vbCrLf & _
                               IIf(LibX.IsNull(oRow!vend_name), "", "Mensajero " & oRow!vend_name.ToString.Trim & vbCrLf) & _
                               IIf(LibX.IsNull(oRow!domi_pago), "", "Forma/Pago " & oRow!domi_pago.ToString.Trim & ", Cambio " & oRow!domi_cambio.ToString.Trim & vbCrLf) & _
                               IIf(LibX.IsNull(oRow!tarj_numero), "", "Tarjeta " & oRow!tarj_numero.ToString.Trim & ", Vence " & oRow!tarj_vence.ToString.Trim)

        Return AditionalInformation
    End Function
End Class
