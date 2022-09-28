using System;
using LibxPrintFiscalFactura;
using LibxPrintFiscalSGF.Utils;
using LibXPrintFiscal.Interfaces;
using LibxPrintFiscalSGF.Modelos;

namespace LibxPrintFiscalSGF.NoFiscalTemplates
{
	/// <summary>
	/// Summary description for FacturaNoFiscal.
	/// </summary>
	public class FacturaNoFiscal
	{
		private const int Line = 56;
		private const int col1 = 28;
		private const int col2 = 10;
		private const int col3 = 15;
		private const int col4 = 3;
		private readonly string FULL_LINE = new string('-',Line);
		private const string EMPTY_SPACE = "  ";

		private readonly IPrinterFactory _printerFactory;
		private readonly string _codigoCaja;

		public FacturaNoFiscal(IPrinterFactory printerFactory, string codigoCaja)
		{
			_printerFactory = printerFactory;
			_codigoCaja = codigoCaja;
		}

		public string[] GetNoFiscalHeader(Sucursal sucursal, string tipoDocumento, int sequenciaNoFiscal)
		{
			FormatUtils fu = new FormatUtils();
			TabularUtils tu = new TabularUtils();

			int index =0;
			string[] documento = new string[150];

			documento[index++] = EMPTY_SPACE;

			documento[index++] = EMPTY_SPACE;
			documento[index++] = string.Format("DOCUMENTO NO FISCAL NO: {0}", sequenciaNoFiscal);
			documento[index++] = EMPTY_SPACE;

			documento[index++] = tu.TabLine(Line, sucursal.Nombre, TabAlign.Center);
			documento[index++] = tu.TabLine(Line, sucursal.Ciudad, TabAlign.Center);
			documento[index++] = sucursal != null ? sucursal.Direccion : string.Empty;
			documento[index++] = sucursal != null ? sucursal.RazonSocial : string.Empty;
			documento[index++] = string.Format("RNC {0}", sucursal.RNC);
			documento[index++] = string.Format("{0}", sucursal.Resolucion);
			documento[index++] = tu.TabLine(Line, "COMPROBANTE AUTORIZADO POR DGII", TabAlign.Center);
			//documento[index++] = string.Format("{0}  {1}", factura.Fecha.ToString("dd/MM/yyyy"), factura.Hora);

			documento[index++] = EMPTY_SPACE;

			documento[index++] = FULL_LINE;
			documento[index++] = tu.TabLine(Line, tipoDocumento, TabAlign.Center);
			documento[index++] = FULL_LINE;

			documento[index++] = EMPTY_SPACE;

			string [] returnRecord = new string[index];

			for(int x = 0; x<index; x++)
			{
				returnRecord[x] = documento[x];
			}

			documento = null;

			return returnRecord;
		}


		public string[] CreateTemplate(Factura factura, int sequenciaNoFiscal)
		{
			return BuildTemplate(factura,sequenciaNoFiscal);
		}

		public string[] CreateTemplate(Factura factura)
		{
			return BuildTemplate(factura,0);
		}

		private string[] BuildTemplate(Factura factura, int sequenciaNoFiscal)
		{
			const int col1and2 = col1+col2;

			FormatUtils fu = new FormatUtils();
			TabularUtils tu = new TabularUtils();

			Fiscalizacion fiscalizacion = _printerFactory.GetFiscalizacionByDocumentId(factura.TipoDocumentoId);

			int index =0;
			string[] documento = new string[150];

			documento[index++] = EMPTY_SPACE;
			documento[index++] = string.Format("DOCUMENTO NO FISCAL NO: {0}", sequenciaNoFiscal);
			documento[index++] = EMPTY_SPACE;

			documento[index++] = tu.TabLine(Line, "COPIA", TabAlign.Center);
			documento[index++] = EMPTY_SPACE;

			documento[index++] = tu.TabLine(Line, factura.Sucursal.Nombre, TabAlign.Center);
			documento[index++] = tu.TabLine(Line, factura.Sucursal.Ciudad, TabAlign.Center);
			documento[index++] = factura.Sucursal != null ? factura.Sucursal.Direccion : string.Empty;
			documento[index++] = factura.Sucursal != null ? factura.Sucursal.RazonSocial : string.Empty;
			documento[index++] = string.Format("RNC {0}", factura.Sucursal.RNC);
			documento[index++] = string.Format("{0}", factura.Sucursal.Resolucion);
			documento[index++] = tu.TabLine(Line, "COMPROBANTE AUTORIZADO POR DGII", TabAlign.Center);
			documento[index++] = string.Format("{0}  {1}", factura.Fecha.ToString("dd/MM/yyyy"), factura.Hora);

			if(fiscalizacion.EsNotaCredito)
			{
				documento[index++] = string.Format("NCF Afectado: {0}", factura.NcfReferencia);
			}

			documento[index++] = string.Format("NIF {0}", factura.NIF);
			documento[index++] = string.Format("NCF {0}", factura.NCF);

			if(fiscalizacion.EsFiscal)
			{
				string clienteNombre = !StringIsNullOrEmpty(factura.Cliente.RazonSocial)
					? factura.Cliente.RazonSocial
					: !StringIsNullOrEmpty(factura.Cliente.Nombre)
					? factura.Cliente.Nombre : string.Empty;

				documento[index++] = string.Format("RNC {0}", factura.Cliente.RNC);
				documento[index++] = string.Format("{0}", clienteNombre);
			}

			documento[index++] = FULL_LINE;

			documento[index++] = tu.TabLine(Line, fiscalizacion.TipoDocumento, TabAlign.Center);
			documento[index++] = FULL_LINE;

			/* ==================PRODUCTOS======================= */
			documento[index++] = string.Format("DESCRIPCION                   IBTIS          VALOR");
			documento[index++] = FULL_LINE;

			foreach(Articulo articulo in factura.Articulos)
			{
				documento[index++] = string.Format("{0} x {1}", fu.FormatQuantity(articulo.Cantidad), fu.FormatAmount(articulo.Precio));
				documento[index++] = string.Format("{0}{1}{2}{3}",
					tu.TabLine(col1,articulo.Descripcion, TabAlign.Left),
					tu.TabLine(col2,fu.FormatAmount(articulo.Itbis), TabAlign.Right),
					tu.TabLine(col3,fu.FormatAmount(articulo.Precio),TabAlign.Right),
					tu.TabLine(col4, articulo.EsExcentoItbis ? "E" : "I",TabAlign.Right));
			}

			/* ==================END-PRODUCTOS==================== */

			documento[index++] = FULL_LINE;

			documento[index++] = string.Format("{0}{1}{2}{3}", 
				tu.TabLine(col1,"Subtotal", TabAlign.Left), 
				tu.TabLine(col2,fu.FormatAmount(factura.Itbis),TabAlign.Right), 
				tu.TabLine(col3,fu.FormatAmount(factura.SubTotal),TabAlign.Right),
				tu.TabLine(col4,"",TabAlign.Right));


			decimal descuento = DecimalTryParse(factura.DescuentoMonto);
			if(descuento > 0)
			{
				documento[index++] = string.Format("{0}{1}{2}{3}", 
					tu.TabLine(col1,"Descuento", TabAlign.Left), 
					tu.TabLine(col2,fu.FormatAmount(factura.Itbis), TabAlign.Right), 
					tu.TabLine(col3,fu.FormatAmount(factura.DescuentoMonto), TabAlign.Right),
					tu.TabLine(col4,"-", TabAlign.Left));
			}
			
			documento[index++] = string.Format("{0}{1}{2}{3}", 
				tu.TabLine(col1,"TOTAL", TabAlign.Left), 
				tu.TabLine(col2,fu.FormatAmount(factura.Itbis), TabAlign.Right),
				tu.TabLine(col3,fu.FormatAmount(factura.TotalPagar), TabAlign.Right),
				tu.TabLine(col4,"", TabAlign.Left));

			documento[index++] = EMPTY_SPACE;

			if(!fiscalizacion.EsNotaCredito)
			{
				/* ================= FORMAS DE PAGO ======================= */
				foreach(Pago pago in factura.Pagos)
				{
					string pagoNombre = GetTipoPagoDescripion(_codigoCaja,pago.FormaPago);

					documento[index++] = string.Format("{0}{1}{2}",
						tu.TabLine(col1and2,pagoNombre, TabAlign.Left),
						tu.TabLine(col3,fu.FormatAmount(pago.TotalPagado), TabAlign.Right),
						tu.TabLine(col4,"", TabAlign.Left));
				}

				documento[index++] = string.Format("{0}{1}{2}", 
					tu.TabLine(col1and2, "CAMBIO", TabAlign.Left),
					tu.TabLine(col3,fu.FormatAmount(factura.Devuelta), TabAlign.Right),
					tu.TabLine(col4,"", TabAlign.Left));
			}
			
			documento[index++] = EMPTY_SPACE;
			documento[index++] = EMPTY_SPACE;

			documento[index++] = string.Format("Documento No: {0}", factura.NumeroFactura);
			documento[index++] = string.Format("Cajera: {0}", factura.Cajera);

			/* ================= SEGURO MEDICO ================== */
			if(factura.EsSeguro)
			{
				documento[index++] = EMPTY_SPACE;
				documento[index++] = FULL_LINE;

				// Seguro: Letrero
				documento[index++] = tu.TabLine(Line,"INFORMACION SEGURO", TabAlign.Center);

				documento[index++] = FULL_LINE;

				// Seguro: Paciente
				string paciente = factura.Seguro.Asegurado != null ? factura.Seguro.Asegurado : "";
				documento[index++] = string.Format("ASEGURADO: {0}", paciente);

				// Seguro: ARS
				documento[index++] = string.Format("ARS: {0}", factura.Seguro.Ars != null ? factura.Seguro.Ars : "");

				// Seguro: PLAN
				documento[index++] = string.Format("PLAN: {0}", factura.Seguro.Plan != null ? factura.Seguro.Plan : "");

				// Seguro: POLIZA
				documento[index++] = string.Format("POLIZA: {0}", factura.Seguro.Poliza != null ? factura.Seguro.Poliza : "");

				documento[index++] = EMPTY_SPACE;

				// Seguro: Linea Firma
				documento[index++] = tu.TabLine(Line, "--------------------", TabAlign.Center);
			
				// Seguro: Firma
				documento[index++] = tu.TabLine(Line, "FIRMA", TabAlign.Center);

			}

			if(fiscalizacion.EsNotaCredito)
			{
				documento[index++] = EMPTY_SPACE;
				documento[index++] = FULL_LINE;

				// Nota de Credito: Letrero
				documento[index++] = tu.TabLine(Line, "NOTA DE CREDITO CXP", TabAlign.Center);

				documento[index++] = FULL_LINE;

				if(factura.NotaCredito != null)
				{
					// Nota de Credito: Numero y Fecha
					documento[index++] = string.Format("Numero: {0}      Fecha: {1}", factura.NotaCredito.Numero, factura.NotaCredito.Fecha);

					// Nota de Credito: Nombre
					documento[index++] = string.Format("Nombre: {0}", factura.NotaCredito.Nombre);

					// Nota de Credito: Nombre
					documento[index++] = string.Format("Monto: {0}      Balance: {1}", factura.NotaCredito.Monto, factura.NotaCredito.Balance);
				}
			}


			/* ================= DOMICILIO ===================== */
#region "DOMICILIO"
			// === Imprime la informacion del domicilio
			if(factura.EsDomicilio)
			{
				documento[index++] = EMPTY_SPACE;

				documento[index++] = FULL_LINE;

				documento[index++] = tu.TabLine(Line,"INFORMACION DOMICILIO", TabAlign.Center);

				documento[index++] = FULL_LINE;

				// Domicilio: Nombre o Razon Social
				string nombre_cliente = factura.Domicilio.Cliente.Nombre != null ? factura.Domicilio.Cliente.Nombre : factura.Cliente.RazonSocial;
				documento[index++] = String.Format("   Nombre: {0}", nombre_cliente);

				const int lineSize = 43;
				string direccion = factura.Cliente.Direccion;
				int times = Convert.ToInt32( Math.Ceiling( (float) direccion.Length / lineSize) );

				if (factura.Cliente.Direccion.Length == 0)
					factura.Cliente.Direccion = "No Direccion";

				if (direccion.Length <= lineSize)
				{
					documento[index++] = string.Format("Direccion: {0}", factura.Domicilio.Cliente.Direccion);
				}
				else
				{
					int residuo = direccion.Length;
					for(int x=0;x <times; x++)
					{
						if(residuo <0)
							break;

						string parteDireccion = factura.Cliente.Direccion.Substring(x*lineSize, (residuo> lineSize) ? lineSize : residuo );

						string direcctionImprimir = (x == 0) ?
							string.Format("Direccion: {0}", parteDireccion) :
							string.Format("           {0}", parteDireccion);

						documento[index++] = direcctionImprimir;

						residuo -= lineSize;;
					}
				}

				// Domicilio: Sector
				documento[index++] = string.Format("   Sector: {0}", factura.Domicilio.Cliente.Sector);

				// Domicilio: Mensajero
				documento[index++] = string.Format("    Notas: {0}", factura.Domicilio.Nota.Trim());

				// Domicilio: Telefono
				documento[index++] = string.Format("      TEL: {0}", factura.Domicilio.Cliente.Telefono);

				decimal cambiodecimal = Convert.ToDecimal( factura.Domicilio.Cambio);
				string vueltoToPrint = cambiodecimal > 0 ? factura.Domicilio.Vuelto : "0";

				// Domicilio: Cambio y Vuelto
				string cambio = string.Format("CAMBIO: {0}      VUELTO: {1}", factura.Domicilio.Cambio, vueltoToPrint);
				documento[index++] = cambio;

				// Domicilio: Linea en blanco
				documento[index++] = EMPTY_SPACE;

				// Domicilio: Mensajero
				documento[index++] = string.Format("Mensajero: {0}", factura.Domicilio.Mensajero).Trim();


			}
#endregion
			/* ================= END DOMICILIO ================== */


			if(factura.PiePagina != null)
			{
				foreach(string nota in factura.PiePagina)
				{
					documento[index++] = EMPTY_SPACE;
					if(nota == null)
					{
						continue;
					}
					documento[index++] = tu.TabLine(Constants.PrinterLineNumber, nota.Trim(), TabAlign.Center );
				}
			}


			documento[index++] = FULL_LINE;
			documento[index++] = string.Format("NIF: {0}", factura.NIF);

			string [] returnRecord = new string[index];

			for(int x = 0; x<index; x++)
			{
				returnRecord[x] = documento[x];
			}

			return returnRecord;
		}


		private string GetTipoDocumentoById(string tipoDocumentoId)
		{
			int id = int.Parse(tipoDocumentoId);

			switch(id)
			{
				case 0:
					return "FACTURA PARA CONSUMIDOR FINAL";
				case 1:
					return "FACTURA PARA CREDITO FISCAL";
				case 2: 
					return "NOTA DE CREDITO PARA CONSUMIDOR FINAL";
				case 3:
					return "NOTA DE CREDITO PARA FISCAL";
				case 4:
					return "FACTURA CONSUMIDOR FINAL EXCENTO DE ITBIS";
				case 5:
					return "FACTURA CREDITO FISCAL EXCENTO DE ITBIS";
				default:
 					return  "FACTURA PARA CONSUMIDOR FINAL";
			}
		}


		private decimal DecimalTryParse(string decimalValue)
		{
			decimal _monto = 0.00M;

			try {_monto = Decimal.Parse(decimalValue) / 100;}
			catch {}

			return _monto;
		}


		private static string FormatAmountExtra(string valor, string extra)
		{
			FormatUtils fu = new FormatUtils();

			string valorExtra = fu.FormatAmount(valor);

			valorExtra += extra;

			return valorExtra;
		}


		private string GetTipoPagoDescripion(string codigoCaja, string tipoPago)
		{
			string tipoPagoNombre = _printerFactory.GetTipoPagoNombre(codigoCaja,tipoPago);

			return tipoPagoNombre;
		}


		private static bool StringIsNullOrEmpty(string valor)
		{
			return valor!= null && valor != string.Empty;
		}

	}
}
