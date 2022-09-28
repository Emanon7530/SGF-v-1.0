Imports System.Windows.Forms
Imports LibX

Public Class ParametrosCreditoFiscal
    Public TipoDocumento As String
    Public Almacen As Integer
    Public Cliente As Integer
    Public ClienteRegistrado As Boolean
    Public TipoNcf As Integer
    Public Cstype As Integer
    Public Class ValorRetorno
        Public Cliente As Integer
        Public NCF As String
        Public CustCode As Integer
    End Class
    Public Retorno As New ValorRetorno
End Class

Public Class ParametrosCreditoFiscalSeguro
    Public Compania As Integer
    Public Almacen As Integer
    Public Class ValorRetorno
        Public Cliente As Integer
        Public NCF As String
        Public CustCode As Integer
    End Class
    Public Retorno As New ValorRetorno

End Class

Public Class Documento
    Public Function Serializar(ByVal pftserial_no As Integer) As Boolean
        Dim SelectStmt As String
        Dim Xselect As LibX.Data.XSelecStmt
        Dim iCnt As Integer
        Dim oTable As DataTable

        Try
            SelectStmt = "select COUNT(*) from ftfactd, ivitemm " & _
                         " where ftfactd.item_code =ivitemm.item_code " & _
                         "   and ivitemm.item_serial = 1" & _
                         "   and ftfactd.ftserial_no = " & pftserial_no.ToString

            iCnt = LibX.Data.Manager.GetScalar(SelectStmt)

            If iCnt <= 0 Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception
            LibX.Log.Add(ex)

        End Try
    End Function

    Public Function FaltaSerial(ByVal pftserial_no As Integer) As Boolean
        Dim SelectStmt As String
        Dim Xselect As LibX.Data.XSelecStmt
        Dim iCnt As Integer
        Dim oTable As DataTable

        Try
            SelectStmt = "select ftserial_no,ftfactd.item_code,qty from ftfactd, ivitemm " & _
                         " where ftfactd.item_code =ivitemm.item_code " & _
                         "   and ivitemm.item_serial = 1" & _
                         "   and ftfactd.ftserial_no = " & pftserial_no.ToString

            Xselect = New LibX.Data.XSelecStmt("ftfactd", SelectStmt)

            oTable = Xselect.GetTable

            If oTable.Rows.Count <= 0 Then
                Return False
            End If

            For Each oRow As DataRow In oTable.Rows
                SelectStmt = "select count(*) from ivseriem " & _
                             " where item_code = " & oRow!item_code.ToString & _
                             "   and ftserial_no = " & oRow!ftserial_no

                Xselect = New LibX.Data.XSelecStmt("ivseriem", SelectStmt)

                iCnt = Xselect.GetScalar

                If iCnt < oRow!qty Then
                    Throw New ApplicationException("Falta serie!")
                End If
            Next

            Return False

        Catch ex As Exception
            LibX.Log.Add(ex)
            Return True
        End Try
    End Function
    Public Function AplicarCreditoFiscal(ByVal e As ParametrosCreditoFiscal) As Boolean
        Dim oInvDocumento As SGT.Inventario.Entidades.Documento
        Dim oParamProg As LibX.LibxPrgParams
        Dim XUpdate As LibX.Data.XUpdateStmt
        Dim oRow As DataRow
        ''Dim SelectStmt As String
        ''Dim CreditoFiscal As Boolean = False
        Dim Retorno As Boolean = False
        Dim DocNcf As String
        Try

            If e.TipoNcf = 0 Then
                If MessageBox.Show("Desea Comprobante Fiscal?", _
                    "NCF", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                    Retorno = False
                Else
                    Retorno = True
                End If

                oInvDocumento = New SGT.Inventario.Entidades.Documento(e.TipoDocumento)

                '// si es que si, pedir los datos del cliente
                '// de lo contrario buscar ncf sin valor credito fiscal
                If Retorno = True Then
                    oParamProg = New LibX.LibxPrgParams
                    Dim oNCF As New i_ftfact04

                    If e.Cliente > 0 Then
                        oParamProg.Datos.Add("ncf_type", e.TipoNcf)
                        oParamProg.Value = e.Cliente
                        oParamProg.initMode = LibxInitModes.Edit
                        oParamProg.WhereToExecute = "cust_code = " & e.Cliente.ToString
                    Else
                        oParamProg.Value = 0
                        oParamProg.initMode = LibxInitModes.Insert
                    End If

                    LibX.App.CurrentPrgParams = oParamProg
                    If oNCF.ShowDialog() = DialogResult.OK Then
                        If e.ClienteRegistrado = True Then
                            e.Retorno.CustCode = e.Cliente
                        Else
                            e.Retorno.Cliente = oNCF.Serial
                        End If
                        If oNCF.CSType <> 0 Then
                            e.Retorno.CustCode = oNCF.Serial
                        Else
                            e.Retorno.Cliente = oNCF.Serial
                        End If

                        If oNCF.NCFType = 0 And e.TipoNcf = 0 And e.Retorno.Cliente > 0 Then
                            e.TipoNcf = 1
                        End If
                        If oNCF.NCFType = 0 And e.TipoNcf > 0 Then
                            e.Retorno.NCF = oInvDocumento.GenerateNCF(e.TipoDocumento, e.Almacen, e.TipoNcf)
                            Retorno = True
                        Else
                            e.Retorno.NCF = oInvDocumento.GenerateNCF(e.TipoDocumento, e.Almacen, oNCF.NCFType)
                            Retorno = True
                        End If
                    Else
                        Retorno = False
                    End If
                Else
                    e.Retorno.NCF = oInvDocumento.GenerateNCF(e.TipoDocumento, e.Almacen, Inventario.Entidades.Documento.TipoNCFEnum.SinValorFiscal)
                    Retorno = True
                End If
            Else
                oInvDocumento = New SGT.Inventario.Entidades.Documento(e.TipoDocumento)
                e.Retorno.NCF = oInvDocumento.GenerateNCF(e.TipoDocumento, e.Almacen, e.TipoNcf)
                Retorno = True
            End If

            Return Retorno

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try

    End Function
    ''Public Function AplicarCreditoFiscal(ByVal e As ParametrosCreditoFiscal) As Boolean
    ''    Dim oInvDocumento As SGT.Inventario.Entidades.Documento
    ''    Dim oParamProg As LibX.LibxPrgParams
    ''    Dim XUpdate As LibX.Data.XUpdateStmt
    ''    Dim oRow As DataRow
    ''    Dim SelectStmt As String
    ''    Dim CreditoFiscal As Boolean = False
    ''    Dim Retorno As Boolean = False
    ''    Dim DocNcf As String
    ''    Try
    ''        oInvDocumento = New SGT.Inventario.Entidades.Documento(e.TipoDocumento)

    ''        If e.TipoNcf > 0 Then
    ''            If e.TipoNcf > 0 Then
    ''                e.Retorno.NCF = oInvDocumento.GenerateNCF(e.TipoDocumento, e.Almacen, e.TipoNcf)
    ''                Retorno = True
    ''            End If
    ''        Else
    ''            If MessageBox.Show("Desea documento con Crédito Fiscal?", _
    ''                "NCF", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
    ''                Retorno = False
    ''            Else
    ''                Retorno = True
    ''            End If

    ''            If e.TipoDocumento = "FSG" Or e.TipoDocumento = "RSM" Then
    ''                DocNcf = e.TipoDocumento
    ''                e.TipoDocumento = "FPV"
    ''            End If

    ''            '// si es que si, pedir los datos del cliente
    ''            '// de lo contrario buscar ncf sin valor credito fiscal
    ''            If Retorno = True Then
    ''                oParamProg = New LibX.LibxPrgParams
    ''                Dim oNCF As New i_ftfact04

    ''                LibX.App.CurrentPrgParams = oParamProg
    ''                If e.Cliente > 0 Then
    ''                    If e.TipoNcf = 0 Then
    ''                        e.TipoNcf = 1
    ''                    End If
    ''                    oParamProg.Datos.Add("ncf_type", e.TipoNcf)
    ''                    oParamProg.Value = e.Cliente
    ''                    oParamProg.WhereToExecute = "cust_serial = " & e.Cliente.ToString
    ''                    oParamProg.initMode = LibxInitModes.Edit
    ''                Else
    ''                    oParamProg.initMode = LibxInitModes.Insert
    ''                End If

    ''                If oNCF.ShowDialog() = DialogResult.OK Then
    ''                    '''If e.ClienteRegistrado = True Then
    ''                    '''    ''e.Retorno.Cliente = Val(oNCF.xmdcustCode.Text)
    ''                    '''    e.Retorno.CustCode = Val(oNCF.xmdcustCode.Text)
    ''                    '''Else
    ''                    '''    e.Retorno.Cliente = oNCF.Serial
    ''                    '''    ''e.Retorno.CustCode = oNCF.Serial
    ''                    '''End If
    ''                    If oNCF.CSType <> 0 Then
    ''                        e.Retorno.CustCode = oNCF.Serial
    ''                    Else
    ''                        e.Retorno.Cliente = oNCF.Serial
    ''                    End If

    ''                    If oNCF.NCFType = 0 And e.TipoNcf = 0 And e.Retorno.Cliente > 0 Then
    ''                        e.TipoNcf = 1
    ''                    End If
    ''                    If oNCF.NCFType = 0 And e.TipoNcf > 0 Then
    ''                        e.Retorno.NCF = oInvDocumento.GenerateNCF(e.TipoDocumento, e.Almacen, e.TipoNcf)
    ''                        Retorno = True
    ''                    Else
    ''                        e.Retorno.NCF = oInvDocumento.GenerateNCF(e.TipoDocumento, e.Almacen, oNCF.NCFType)
    ''                        Retorno = True
    ''                    End If
    ''                Else
    ''                    Retorno = False
    ''                    '''If oInvDocumento.Mensaje_NCF_Unifco = "" Then
    ''                    '''    e.Retorno.NCF = oInvDocumento.GenerateNCF(e.TipoDocumento, e.Almacen, Inventario.Entidades.Documento.TipoNCFEnum.SinValorFiscal)
    ''                    '''    Retorno = True
    ''                    '''End If
    ''                End If
    ''            Else
    ''                If oInvDocumento.Mensaje_NCF_Unifco = "" Then
    ''                    If e.TipoDocumento = "FPV" And DocNcf = "RSM" Then
    ''                        e.Retorno.NCF = oInvDocumento.GenerateNCF(e.TipoDocumento, e.Almacen, Inventario.Entidades.Documento.TipoNCFEnum.Gubernamental)
    ''                        Retorno = True
    ''                    Else
    ''                        e.Retorno.NCF = oInvDocumento.GenerateNCF(e.TipoDocumento, e.Almacen, Inventario.Entidades.Documento.TipoNCFEnum.SinValorFiscal)
    ''                        Retorno = True
    ''                    End If
    ''                Else
    ''                    Retorno = True
    ''                End If
    ''            End If
    ''        End If
    ''        Return Retorno

    ''    Catch ex As Exception
    ''        LibX.Log.Add(ex)
    ''    End Try

    ''End Function
    Public Function PrepareSelectStmt(ByVal SelecStmt As String) As String
        Dim Cargar As Integer = 1
        If Not System.Configuration.ConfigurationSettings.AppSettings.Get("LibxLoad") Is Nothing Then
            Cargar = Val(System.Configuration.ConfigurationSettings.AppSettings.Get("LibxLoad").ToString.Trim)
        End If

        If Cargar = 0 Then
            SelecStmt = LibX.ConcatWherePart(SelecStmt, "ftfactm.pay_adelant is null")
        End If

        Return SelecStmt
    End Function

    Public Function AplicarCreditoFiscalSeguro(ByVal e As ParametrosCreditoFiscal) As Boolean
        Dim oInvDocumento As SGT.Inventario.Entidades.Documento
        Dim oCliente As SGT.CXC.Entidades.Cliente

        Dim oRow As DataRow
        Dim XUpdate As LibX.Data.XUpdateStmt
        Dim XInsert As LibX.Data.XInsertStmt

        Dim strNCF As String
        Dim intSerial As Integer

        Try
            oInvDocumento = New SGT.Inventario.Entidades.Documento("FPV")
            oCliente = New SGT.CXC.Entidades.Cliente(e.Cliente)

            strNCF = oInvDocumento.GenerateNCF("FPV", e.Almacen, Inventario.Entidades.Documento.TipoNCFEnum.ConValorFiscal)

            XInsert = New LibX.Data.XInsertStmt("ftcustm", "cust_serial")

            XInsert.Fields("cust_rnc") = oCliente.RNC
            XInsert.Fields("cust_name") = oCliente.Nombre
            XInsert.Fields("ncf_type") = Inventario.Entidades.Documento.TipoNCFEnum.ConValorFiscal
            XInsert.Fields("phone") = oCliente.Telefono

            intSerial = XInsert.Execute()

            e.Retorno.Cliente = intSerial
            e.Retorno.NCF = strNCF

            Return True
        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try

    End Function

    Public Function GenerateNumber(ByVal TypeCode As String)
        Dim SelectStmt As String
        Dim LastNumber As Int16
        Dim xUpdate As LibX.Data.XUpdateStmt

        Try
            xUpdate = New LibX.Data.XUpdateStmt("ivtypem")

            SelectStmt = "select Last_Number from ivtype " & _
                         " where type_code = '" & TypeCode & "'"

            LastNumber = LibX.Data.Manager.GetScalar(SelectStmt)

            LastNumber += 1

            xUpdate.FieldsSet("Last_Number") = LastNumber
            xUpdate.Fields("type_code") = TypeCode

            xUpdate.Execute()

            Return LastNumber

        Catch ex As Exception
            LibX.Log.Add(ex)
            Return -1

        End Try
    End Function
End Class
