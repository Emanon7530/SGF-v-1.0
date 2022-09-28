
Public Class Documento
    Public Enum ModoValorizacion
        Precio = 1
        Costo = 2
    End Enum
    Public Enum EstatusHojaConteoEnum
        Generada = 0
        Editada = 1
        Impresa = 2
        Aplicada = 3
    End Enum
    Public Enum MonedaEnum
        RD = 1
        US = 2
    End Enum

    Public Enum TipoNCFEnum
        ConValorFiscal = 1
        SinValorFiscal = 2
        NotaDebito = 3
        NotasCredito = 4
        ProveedoresInformales = 11
        IngresosUnico = 12
        GastosMenores = 13
        ZonasFrancas = 14
        Gubernamental = 15
        None = 5
    End Enum

    Public Shared Name As String
    Public Shared Moneda As Integer
    Public Shared AfectaCXC As Boolean
    Public Shared AfectaCXP As Boolean
    Public Shared AfectaINV As Boolean
    Public Shared AfectaCTG As Boolean
    Public Shared AfectaPOS As Boolean
    Public Shared AfectaOtrosDocumentos As Boolean
    Public Shared AfectaSeguroMedico As Boolean
    Public Shared AfectaDomicilio As Boolean
    Public Shared Origen As Integer
    Public Shared CantCopiasEFE As Integer
    Public Shared CantCopiasTAR As Integer
    Public Shared CantCopiasCXC As Integer
    Public Shared CantCopiasCHK As Integer
    Public Shared CantCopiasDOM As Integer
    Public Shared SoloDomicilio As Boolean
    Public Shared AplicarPrecio As Boolean
    Public Shared AutoNumerar As Boolean
    Public Shared AutoImprimir As Boolean
    Public Shared AutoImpEfe As Boolean
    Public Shared AutoImpTar As Boolean
    Public Shared AutoImpCxc As Boolean
    Public Shared AutoImpChq As Boolean
    Public Shared AutoImpDom As Boolean
    Public Shared UltNumero As Integer
    Public Shared RequiereVendedor As Boolean
    Public Shared RequiereCliente As Boolean
    Public Shared RequiereSuplidor As Boolean
    Public Shared Entrada As Boolean
    Public Shared Local As Boolean
    Public Shared PagaComision As Boolean
    Public Shared GenerarNCF As Boolean
    Public Shared Mensaje_NCF_Unifco As String = ""

    Public Sub New(ByVal type_code As String)
        FillData(type_code)
    End Sub

    Public Function ExisteDocumento(ByVal prov_code As Integer, ByVal doc_number As String, ByVal type_code As String) As Boolean
        Dim SelectStmt As String
        Dim Existe As Integer

        SelectStmt = "select count(*) from iventrdm " & _
                     " where type_code = '" & type_code.Trim & "'" & _
                     "   and entr_number =  '" & doc_number.Trim & "'" & _
                     "   and prov_code = " & prov_code.ToString.Trim

        Existe = LibX.Data.Manager.GetScalar(SelectStmt)

        If Existe > 0 Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Function GenerateNumber(ByVal type_code As String) As Integer
        Dim whDefault As Integer
        Dim whDefaultNo As Integer
        Try

            whDefault = System.Configuration.ConfigurationSettings.AppSettings.Get("LibxWhDefault")
            whDefaultNo = Val(Configuration.ConfigurationSettings.AppSettings.Get("LibxWhDefaultNo").ToString)
            If whDefaultNo = 1 Then
                Return GenerateNumber(type_code, whDefaultNo)
            Else
                Return GenerateNumber(type_code, whDefault)
            End If


        Catch ex As Exception
            LibX.Log.Add(ex)
            Return -1

        End Try
    End Function

    Public Function ExistePedido(ByVal Number As Integer) As Boolean
        Dim XSelect As LibX.Data.XSelecStmt
        Dim Existe As Integer

        XSelect = New LibX.Data.XSelecStmt("iventrdm", "select count(*) from iventrdm")
        XSelect.Parameters.Add("type_code", "PDI")
        XSelect.Parameters.Add("entr_number", Number)

        Existe = XSelect.GetScalar()

        If Existe > 0 Then
            Return True
        End If

        Return False

    End Function

    Public Function GenerarEtiqueta(ByVal Numero As Integer) As Boolean
        Dim SelectStmt As String
        Dim oTable As DataTable
        Dim oNewTAble As DataTable

        ''inserta los productos en la tabla de etiquetas
        SelectStmt = " SELECT 0 etiq_no, iventrdd.whse_code almacen, " & _
                     " iventrdd.item_code , " & _
                     " iventrdd.costo,  " & _
                     " iventrdd.price as precio," & _
                     " isnull((SELECT top 1 ivitemd.price * FACTOR FROM IVUNITD WHERE ITEM_CODE=ivitemm.ITEM_CODE AND unit_code=ivitemm.purch_unit),NULL) AS precio2," & _
                     " ivitemm.item_name as descripcion,  " & _
                     " ivitemm.abreviada as abreviada,   " & _
                     " iventrdm.entr_number as fact_no," & _
                     " iventrdm.entr_date as fecha_factura," & _
                     " iventrdm.prov_code,	" & _
                     " (case when asumir_emp=1 then iventrdd.qty else 1 end )+ isnull(iventrdd.qty_oferta,0) AS Cantidad," & _
                     " iventrdd.unit_code as unidad_compra," & _
                     " isnull((SELECT  top 1 unit_code FROM IVUNITD WHERE ITEM_CODE=ivitemm.ITEM_CODE AND unit_code = ivitemm.unit_code),(SELECT  top 1 unit_code FROM IVUNITD WHERE ITEM_CODE=ivitemm.ITEM_CODE AND unit_code = ivitemm.purch_unit)) as unidad_venta ," & _
                     " ivitemd.existencia," & _
                     " ivitemm.group_code as grupo," & _
                     " ivitemm.sgroup_code as subgrp," & _
                     " 0 as estato," & _
                     " ivitemm.brand_code as marca," & _
                     " getdate() as fecha" & _
                     "  FROM iventrdm INNER JOIN iventrdd " & _
                     " ON iventrdm.entr_serial = iventrdd.entr_serial " & _
                     " INNER JOIN ivitemd " & _
                     " ON ivitemd.item_code = iventrdd.item_code " & _
                     " AND ivitemd.whse_code = iventrdd.whse_code " & _
                     " INNER JOIN ivitemm " & _
                     " ON ivitemm.item_code = ivitemd.item_code   " & _
                     " where iventrdm.entr_serial = " & Numero.ToString.Trim & _
                     " and ivitemm.imprimir_etiq = 1 order by iventrdd.line_no "

        oTable = LibX.Data.Manager.GetDataTable(SelectStmt, "ivetiqm", True)

        If oTable.Rows.Count > 0 Then
            oNewTAble = LibX.Data.Manager.GetNewDataTable("ivetiqm", True)
            For Each oRow As DataRow In oTable.Rows
                Dim oNewRow As DataRow = oNewTAble.NewRow

                oNewRow.ItemArray = oRow.ItemArray
                oNewTAble.Rows.Add(oNewRow)
            Next

            LibX.Data.Manager.Save(oNewTAble)
        End If

    End Function

    Public Function GenerateNumber(ByVal type_code As String, ByVal whse_code As Integer) As Integer
        Dim NewNumber As Integer
        Dim XUpdate As LibX.Data.XUpdateStmt
        Dim XSelect As LibX.Data.XSelecStmt
        Try

            XSelect = New LibX.Data.XSelecStmt("ivtypen", "select last_number from ivtypen")
            XSelect.Parameters.Add("type_code", type_code)
            XSelect.Parameters.Add("whse_code", whse_code)

            UltNumero = Val(XSelect.GetScalar().ToString)

            XUpdate = New LibX.Data.XUpdateStmt("ivtypen")
            NewNumber = UltNumero + 1

            XUpdate.FieldsSet("last_number") = NewNumber
            XUpdate.Fields("type_code") = type_code
            XUpdate.Fields("whse_code") = whse_code

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

    Private Shared Sub FillData(ByVal ptype_code As String)
        Dim oRow As DataRow
        Dim XSelect As LibX.Data.XSelecStmt
        Try
            XSelect = New LibX.Data.XSelecStmt("ivtypem", "select * from ivtypem where type_code ='" & ptype_code & "'")
            oRow = XSelect.GetDataRow

            If oRow Is Nothing Then
                Throw New ApplicationException("No se ha definido este tipo de documento")
            End If

            Name = oRow!type_name
            AfectaCXC = Val(oRow!apply_cxc.ToString)
            AfectaCXP = Val(oRow!apply_cxp.ToString)
            AfectaINV = Val(oRow!apply_inv.ToString)
            AfectaCTG = Val(oRow!apply_ctg.ToString)
            AfectaPOS = Val(oRow!apply_pos.ToString)
            AfectaOtrosDocumentos = Val(oRow!afect_other.ToString)
            AfectaSeguroMedico = Val(oRow!afect_seguro.ToString)
            AfectaDomicilio = Val(oRow!afect_Domicilio.ToString)
            AutoImprimir = Val(oRow!auto_imprimir.ToString.Trim)
            AutoImpEfe = Val(oRow!auto_imp_efe.ToString.Trim)
            AutoImpTar = Val(oRow!auto_imp_tar.ToString.Trim)
            AutoImpCxc = Val(oRow!auto_imp_cxc.ToString.Trim)
            AutoImpChq = Val(oRow!auto_imp_chq.ToString.Trim)
            AutoImpDom = Val(oRow!auto_imp_dom.ToString.Trim)
            GenerarNCF = Val(oRow!genera_ncf.ToString.Trim)
            Origen = Val(oRow!origen.ToString.Trim)
            CantCopiasEFE = Val(oRow!no_copias.ToString.Trim)
            CantCopiasTAR = Val(oRow!no_copias_tar.ToString.Trim)
            CantCopiasCXC = Val(oRow!no_copias_cxc.ToString.Trim)
            CantCopiasCHK = Val(oRow!no_copias_chk.ToString.Trim)
            CantCopiasDOM = Val(oRow!no_copias_dom.ToString.Trim)
            SoloDomicilio = Val(oRow!solo_domici.ToString.Trim)
            AplicarPrecio = Val(oRow!apply_price.ToString)
            AutoNumerar = Val(oRow!auto_number.ToString)
            UltNumero = Val(oRow!last_number.ToString)
            RequiereVendedor = Val(oRow!use_salesman.ToString)
            RequiereCliente = Val(oRow!use_customer.ToString)
            RequiereSuplidor = Val(oRow!use_prov.ToString)
            Entrada = Val(oRow!doc_input.ToString)
            Local = Val(oRow!type_local.ToString)
            PagaComision = Val(oRow!pay_comm.ToString)
            Mensaje_NCF_Unifco = oRow!type_ncf_unico.ToString.Trim
            oRow = Nothing

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try

    End Sub

    Public Shared Function GetDollar() As String
        FillData("CUS")
        Return "CUS"
    End Function

    Public Shared Function GetPesos() As String
        FillData("CRD")
        Return "CRD"
    End Function

    Public Shared Function GetND() As String
        FillData("N/D")
        Return "N/D"
    End Function

    Public Shared Function GetFactura() As String
        FillData("FCT")
        Return "FCT"
    End Function

    Public Function GetDevInventario() As String
        FillData("DVI")
        Return "DVI"
    End Function

    Public Shared Function GetDevFacturación() As String
        FillData("DVF")
        Return "DVF"
    End Function

    Public Function GenerateNCF(ByVal type_code As String, ByVal whse_code As Integer, ByVal Tipo As TipoNCFEnum) As String
        Dim NewNumber As Integer
        Dim NCF As String
        Dim oRow As DataRow
        Dim XUpdate As LibX.Data.XUpdateStmt
        Dim XSelect As LibX.Data.XSelecStmt
        Try
            If type_code = "" Then
                type_code = "FPV"
            End If

            '// conneccion
            XSelect = New LibX.Data.XSelecStmt("ftncfm", "select * from ftncfm")

            'XSelect.Parameters.Add("ftncfm.type_code", type_code)
            XSelect.Parameters.Add("ftncfm.whse_code", whse_code)
            XSelect.Parameters.Add("ftncfm.ncf_type", Val(Tipo))

            oRow = XSelect.GetDataRow()

            If oRow Is Nothing Then
                Return "-1"
            End If

            XUpdate = New LibX.Data.XUpdateStmt("ftncfm")

            NCF = oRow!ncf_literal
            NewNumber = Val(oRow!ncf_actual.ToString.Trim)
            NewNumber += 1
            XUpdate.FieldsSet("ncf_actual") = NewNumber

            NCF = NCF.Trim & NewNumber.ToString("00000000")

            XUpdate.Fields("type_code") = type_code
            XUpdate.Fields("whse_code") = whse_code
            XUpdate.Fields("ncf_type") = Val(Tipo)

            XUpdate.Execute()
            XUpdate.Dispose()
            XSelect.Dispose()

            Return NCF

        Catch ex As Exception
            LibX.Log.Add(ex)
            Return -1
        Finally
        End Try
    End Function
End Class
