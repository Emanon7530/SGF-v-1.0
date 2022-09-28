Imports System.Text
Imports LibxPrintFiscalFactura

Public Class DocDomicilio

    Private Const Linea_En_Blanco As String = "  "


    Public Function CreateDomicilios(ByVal fac As Factura) As String()

        Dim arrayObjects As New ArrayList

        Dim builder(20) As String

        ''////// =====> ENCABEZADO
        Dim CA As String = String.Format("CAJA:      {0}", fac.CodigoCaja)
        Dim CJ As String = String.Format("CAJERA:    {0}", fac.Cajera)
        Dim VE As String = String.Format("VENDEDOR:  {0}", fac.VendedorNombre)
        Dim NU As String = String.Format("NUMERO:    {0}", fac.NumeroFactura)
        Dim FH As String = String.Format("FECHA:     {0}  HORA:{1}", fac.Fecha.ToString("dd/MMMM/yyyy"), fac.Hora)
        Dim CF As String = String.Format("NCF:       {0}", fac.NCF)
        ''////// =====> ENCABEZADO

        arrayObjects.Add(CA)
        arrayObjects.Add(CJ)
        arrayObjects.Add(VE)
        arrayObjects.Add(NU)
        arrayObjects.Add(FH)
        arrayObjects.Add(CF)

        arrayObjects.Add(Linea_En_Blanco)
        arrayObjects.Add(Linea_En_Blanco)

        ''////// =====> PARTE MEDIA
        Dim TF As String = "      FACTURA PARA CONSUMIDOR FINAL"
        Dim TD As String = "           #TIPO_DE_DOMICILIO"
        Dim NC As String = String.Format("{0}", fac.Cliente.Nombre)
        Dim D1 As String = String.Format("{0}", fac.Domicilio.Cliente.Nombre)
        Dim D2 As String = String.Format("{0}", fac.Domicilio.Cliente.Direccion)
        Dim TE As String = String.Format("{0}", fac.Domicilio.Cliente.Sector)
        Dim CV As String = String.Format("CAMBIO:   {0}   VUELTO {1}", fac.Domicilio.Cambio, fac.Domicilio.Vuelto)
        Dim DE As String = String.Format("{0}", fac.Domicilio.Mensajero)
        ''////// =====> PARTE MEDIA

        arrayObjects.Add(TF)
        arrayObjects.Add(TD)
        arrayObjects.Add(NC)
        arrayObjects.Add(D1)
        arrayObjects.Add(D2)
        arrayObjects.Add(TE)
        arrayObjects.Add(CV)
        arrayObjects.Add(DE)

        arrayObjects.Add(Linea_En_Blanco)
        arrayObjects.Add(Linea_En_Blanco)

        ''////// =====> PRODUCTO DETALLE
        Dim HP As String = "PRODUCTO"
        Dim HD As String = "      CANT   PRECIO    DESC   ITBIS   IMPORTE"

        'Dim PD As String = String.Format("{0}", "")
        'Dim ID As String = String.Format("{0}   {1}    {2}    {3}    {4}", "", "", "", "", "")
        ''////// =====> PRODUCTO

        arrayObjects.Add(HP)
        arrayObjects.Add(HD)

        Dim i As Integer = 0
        For i = 0 To fac.Articulos.Length() - 1
            Dim PD As String = String.Format("{0}", fac.Articulos(i).Descripcion)
            arrayObjects.Add(PD)
            Dim ID As String = String.Format("      {0}   {1}    {2}    {3}    {4}", fac.Articulos(i).Cantidad, fac.Articulos(i).Precio, fac.Articulos(i).Descuento, fac.Articulos(i).Itbis, fac.Articulos(i).Valor)
            arrayObjects.Add(ID)
        Next

        arrayObjects.Add(Linea_En_Blanco)
        arrayObjects.Add(Linea_En_Blanco)

        ''////// =====> PRODUCTO TOTAL
        Dim TL As String = String.Format("                      Total: {0}", fac.SubTotal)
        Dim DT As String = String.Format("                  Descuento: {0}", fac.DescuentoMonto)
        Dim IT As String = String.Format("                      ITBIS: {0}", fac.Itbis)
        Dim NT As String = String.Format("                 Total Neto: {0}", fac.TotalPagar)
        ''////// =====> PRODUCTO TOTAL

        arrayObjects.Add(TL)
        arrayObjects.Add(DT)
        arrayObjects.Add(IT)
        arrayObjects.Add(NT)


        ''////// =====> CIERRE
        Dim LI As String = "---------------------------"
        Dim RP As String = "        RECIBIDO POR       "
        Dim ND As String = "** NO DEVOLUCION DE EFECTIVO **"
        Dim ZZ As String = "** Para Nota de Credito 2 Dias **"
        ''////// =====> CIERRE

        arrayObjects.Add(LI)
        arrayObjects.Add(RP)
        arrayObjects.Add(ND)
        arrayObjects.Add(ZZ)

        Dim resultObjects(arrayObjects.Count) As String

        arrayObjects.CopyTo(resultObjects)

        Return resultObjects

    End Function

End Class

