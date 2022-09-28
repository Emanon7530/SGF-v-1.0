using System;
using System.Collections;
using LibxPrintFiscalSGF.Modelos;
using LibXPrintFiscal;
using LibXPrintFiscal.Comandos;
using LibXPrintFiscal.Interfaces;
using LibXPrintFiscal.Repositorios;
using LibXPrintFiscal.Modelos;
using LibxPrintFiscalFactura;

using Microsoft.VisualBasic;
using EpsonFPHostControlX;
using AxEpsonFPHostControlX;
using LibxPrintFiscalSGF.NoFiscalTemplates;

using LibxPrintFiscalSGF.Utils;

namespace LibxPrintFiscalSGF
{
	/// <summary>
	/// Clase que se encargara de la impresion de los diferentes documentos Fiscales y No Fiscales.
	/// </summary>
	public class ImpresionFiscalEpson : IPrintFiscal
	{
		private int codigoImpresora;
		private string codigoCaja;
		private bool GlobalError = true;
		private AxEpsonFPHostControl EpsonDrive;

		private readonly TabularUtils _tabularUtils;
		private Factura _factura;
		private IPrinterFactory _printerFactory;

		private Parametro[] parametros;

		private Hashtable parametroHash;


		private Impresora _impresora;

		public int CodigoImpresora
		{
			get{return codigoImpresora;}
			set{codigoImpresora =value;}
		}


		public string CodigoCaja
		{
			get{return codigoCaja;}
			set{codigoCaja=value;}
		}


		public Impresora Impresora
		{
			get {return _impresora;}
		}

		public Factura UltimaFactura
		{
			get{return _factura;}
		}


		#region "Ctos"

		public ImpresionFiscalEpson():this(new PrinterFactory(), new AxEpsonFPHostControl())
		{
		}

		public ImpresionFiscalEpson(int codigoImpresora, string codigoCaja):this(new PrinterFactory(), new AxEpsonFPHostControl(), codigoImpresora, codigoCaja)
		{
		}

		public ImpresionFiscalEpson(IPrinterFactory printerFactory, AxEpsonFPHostControl Epson,  int codigoImpresora, string codigoCaja)
		{
			this.codigoCaja = codigoCaja;
			this.codigoImpresora = codigoImpresora;
			_printerFactory = printerFactory;

			EpsonDrive = Epson;

			parametros = _printerFactory.GetParametros(this.codigoCaja);

			EpsonDrive.OnWrite +=new AxEpsonFPHostControlX.IEpsonFPHostControlEvents_OnWriteEventHandler(EpsonDrive_OnWrite);
			EpsonDrive.OnError += new EventHandler(EpsonDrive_OnError);

			_tabularUtils = new TabularUtils();

		}
		
		public ImpresionFiscalEpson(IPrinterFactory printerFactory, AxEpsonFPHostControl Epson): this(printerFactory, Epson, 0, String.Empty)
		{
			//if (this.codigoCaja == null) throw new Exception("Codigo de Caja no ha sido inicializado");
		}

		#endregion


		/// <summary>
		/// Abre el puerto de la impresora buscando los parametros de configuracion desde la tabla de la Impresora.
		/// </summary>
		/// <param name="cajaNombre">Nombre de la Caja</param>
		/// <returns>True si se conecta satisfactorimante, No de lo contrario.</returns>
		public bool Connect(string cajaNombre)
		{
			EpsonFPHostControlX.TxCommPort puertoCom;
			bool resultado = false;

			_impresora = _printerFactory.GetDefaultImpresora(cajaNombre);

			if(_impresora == null || _impresora.Puerto == null || _impresora.Velocidad == null)
			{
				return false;
			}

			switch(_impresora.Puerto.ToLower())
			{
				case "com1":
					puertoCom = EpsonFPHostControlX.TxCommPort.Com1;
					break;
				case "com2":
					puertoCom = EpsonFPHostControlX.TxCommPort.Com2;
					break;
				case "com3":
					puertoCom = EpsonFPHostControlX.TxCommPort.Com3;
					break;
				case "com4":
					puertoCom = EpsonFPHostControlX.TxCommPort.Com4;
					break;
				default:
					puertoCom = EpsonFPHostControlX.TxCommPort.Com1;
					break;

			}

			this.Disconnect();

			this.FPDelay();
			this.EpsonDrive.CommPort = puertoCom;


			switch (_impresora.Velocidad.ToLower())
			{
				case "br1200" :
					this.EpsonDrive.BaudRate = EpsonFPHostControlX.TxBaudRate.br1200;
					break;

				case "br2400" :
					this.EpsonDrive.BaudRate = EpsonFPHostControlX.TxBaudRate.br2400;
					break;

				case "br4800" :
					this.EpsonDrive.BaudRate = EpsonFPHostControlX.TxBaudRate.br4800;
					break;

				case "br9600" :
					this.EpsonDrive.BaudRate = EpsonFPHostControlX.TxBaudRate.br9600;
					break;

				case "br19200" :
					this.EpsonDrive.BaudRate = EpsonFPHostControlX.TxBaudRate.br19200;
					break;

				case "br38400" :
					this.EpsonDrive.BaudRate = EpsonFPHostControlX.TxBaudRate.br38400;
					break;

				default:
					this.EpsonDrive.BaudRate = EpsonFPHostControlX.TxBaudRate.br9600;
					break;
			}

			this.EpsonDrive.ProtocolType = EpsonFPHostControlX.TxProtocolType.protocol_Extended;

			resultado = this.EpsonDrive.OpenPort();

			if (resultado)
			{
				this.FPDelay();
			}

			return resultado;
		}


		public bool Connect(Puerto puerto, Velocidad velocidad, string cajaNombre)
		{
			bool result = false;
			EpsonFPHostControlX.TxCommPort puertoCom;

			_impresora = _printerFactory.GetDefaultImpresora(cajaNombre);

			switch(puerto)
			{
				case Puerto.COM1:
					puertoCom = EpsonFPHostControlX.TxCommPort.Com1;
					break;
				case Puerto.COM2:
					puertoCom = EpsonFPHostControlX.TxCommPort.Com2;
					break;
				case Puerto.COM3:
					puertoCom = EpsonFPHostControlX.TxCommPort.Com3;
					break;
				case Puerto.COM4:
					puertoCom = EpsonFPHostControlX.TxCommPort.Com4;
					break;
				default:
					puertoCom = EpsonFPHostControlX.TxCommPort.Com1;
					break;

			}

			this.Disconnect();

			this.FPDelay();
			this.EpsonDrive.CommPort = puertoCom;

			
			switch (velocidad)
			{
				case Velocidad.br1200 :
					this.EpsonDrive.BaudRate = EpsonFPHostControlX.TxBaudRate.br1200;
					break;

				case Velocidad.br2400 :
					this.EpsonDrive.BaudRate = EpsonFPHostControlX.TxBaudRate.br2400;
					break;

				case Velocidad.br4800 :
					this.EpsonDrive.BaudRate = EpsonFPHostControlX.TxBaudRate.br4800;
					break;

				case Velocidad.br9600 :
					this.EpsonDrive.BaudRate = EpsonFPHostControlX.TxBaudRate.br9600;
					break;

				case Velocidad.br19200 :
					this.EpsonDrive.BaudRate = EpsonFPHostControlX.TxBaudRate.br19200;
					break;

				case Velocidad.br38400 :
					this.EpsonDrive.BaudRate = EpsonFPHostControlX.TxBaudRate.br38400;
					break;

				default:
					this.EpsonDrive.BaudRate = EpsonFPHostControlX.TxBaudRate.br9600;
					break;
			}

			this.EpsonDrive.ProtocolType = EpsonFPHostControlX.TxProtocolType.protocol_Extended;

			result = this.EpsonDrive.OpenPort();

			if (result)
			{
				this.FPDelay();
			}

			return result;
		}


		public void Disconnect()
		{
			this.EpsonDrive.ClosePort();
		}



		/// <summary>
		///		Metodo usado para imprimir Facturas con Creditos Fiscales.
		/// </summary>
		/// <param name="factura">
		///	  Campos Mandatorios
		/// 	campo1:  Nro de Logo -> Factura.Sucursal.NumeroLogo
		///		campo2:  Densidad -> Factura.Sucursal.Densidad
		///		campo3:  Codigo Sucursal -> Factura.Sucursal.Codigo
		///		campo4:  Caja -> Factura.Caja
		///		campo5:  NCF -> Factura.NCF
		///		campo6:  Razon Social Comprador -> Factura.Cliente.RazonSocial
		///		campo7:  RNC Comprador -> Factura.Cliente.RNC
		///		campo8:  NCF Referencia -> Factura.NcfRefencia
		///		campo9:  Descripcion del Articulo -> Factura.Articulo.Descripcion
		///		campo10: Cantidad -> Factura.Articulo.Cantidad
		///		campo11: Precio Unitario -> Factura.Articulo.Precio
		///		campo12: Tasa de Itbis -> Factura.Articulo.itbis
		/// </param>
		/// <returns>ImpresoraFisica {IsSuccess: si completo satisfactoriamente}</returns>
		/// 
		public ImpresoraFisica CreditoFiscal(Factura factura)
		{

			bool isNotaDeCredito = false;
			bool esNcfFiscal = false;
			bool isSuccess = true;
			string sCmd = string.Empty;
			string sCmdExt = string.Empty;
			ImpresoraFisica printer = new ImpresoraFisica();

			parametroHash = _printerFactory.GetParametroDictionary(this.codigoCaja);

			// -> setiando la factura enviada para saber que factura fue la ultima que se trabajo. Just in case.
			_factura = factura;

			// Tipo de Documento
			string paramTipoDoc;
			switch(_factura.TipoDocumentoId)
			{
				case "0": // Consumidor Final
					paramTipoDoc = _factura.ImprimeCopia ? "0040" :"0000";
					break;
				case "1": // Factura de Credito Fiscal
					paramTipoDoc = _factura.ImprimeCopia ? "0041" : "0001";
					esNcfFiscal = true;
					break;
				case "2": // Nota de Credito 
					paramTipoDoc = _factura.ImprimeCopia ? "0042" :"0002";
					isNotaDeCredito = true;
					break;
				case "3": // Nota de Credito a CreditoFiscal
					paramTipoDoc = _factura.ImprimeCopia ? "0043" :"0003";
					isNotaDeCredito = true;
					esNcfFiscal = true;
					break;
				case "4": // Factura consumidor final excento de itbis
					paramTipoDoc = _factura.ImprimeCopia ? "0044" :"0004";
					isNotaDeCredito = false;
					esNcfFiscal = false;
					break;
				case "5": // Factura Credito Fiscal excento de itbis
					paramTipoDoc = _factura.ImprimeCopia ? "0045" :"0005";
					isNotaDeCredito = false;
					esNcfFiscal = true;
					break;
				case "7": /// Nota de Credito Fiscal excento de itbis
					paramTipoDoc = _factura.ImprimeCopia ? "0047" :"0007";
					isNotaDeCredito = true;
					esNcfFiscal = true;
					break;
				default :
					paramTipoDoc = _factura.ImprimeCopia ? "0040" :"0000";
					break;
			};

			// Solo imprimir el NCF de referencia si es una nota de credito {Tipo de Documento 2 y 3}
			_factura.NcfReferencia = (isNotaDeCredito) ? _factura.NcfReferencia : String.Empty;

			// Solo imprime el RNC del cliente para documentos que tengan comprobante fiscal {1 y 3};
			if (!esNcfFiscal )
			{
				_factura.Cliente.RazonSocial = String.Empty;
				_factura.Cliente.RNC = String.Empty;
			}

			// ==> Abrir Caja
			sCmd =  ParForm(Convert.ToString(parametroHash[TiqueFiscal.Abrir]));

			sCmdExt = ParForm(paramTipoDoc);

			if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(sCmd);
			if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(sCmdExt);

			if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(_factura.Sucursal.NumeroLogo);
			if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(_factura.Sucursal.Densidad);
			if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(_factura.Sucursal.Codigo);
			if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(_factura.CodigoCaja);
			if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(_factura.NCF);
			if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(_factura.Cliente.RazonSocial);
			if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(_factura.Cliente.RNC);
			
			if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(_factura.NcfReferencia);

			if (isSuccess) isSuccess = this.EpsonDrive.SendCommand();
			
			FPDelay();
			
			printer = ValidateReturnCode(this.EpsonDrive.ReturnCode);
			if (!printer.IsSucess)
				return printer;


			foreach(Articulo item in factura.Articulos)
			{
				// ================> Items
				if(item != null)
				{
					sCmd =  ParForm( Convert.ToString( parametroHash[TiqueFiscal.Item] ));
					if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(sCmd);

					sCmdExt = ParForm("0000");
					if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(sCmdExt);
				
//					if (DoesFacturaHasDiscount(_factura.DescuentoMonto) && DoesFacturaHasDiscount(item.Descuento))
//						item.DescripcionExtra1 = String.Format("Descuento: {0}", this.FormatAmount(item.Descuento));

					if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(item.DescripcionExtra1); //item:campo1#descripcion_extra_1

					if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(""); //item:campo2#descripcion_extra_2
					if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(""); //item:campo3#descripcion_extra_3
					if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(""); //item:campo4#descripcion_extra_4
					if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(""); //item:campo5#descripcion_extra_5
					if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(""); //item:campo6#descripcion_extra_6
					if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(""); //item:campo7#descripcion_extra_7
					if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(""); //item:campo8#descripcion_extra_8
					if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(""); //item:campo9#descripcion_extra_9
					if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(item.Descripcion); //item:campo10#descripcion
					if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(item.Cantidad); //item:campo11#cantidad(5,3)
					if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(item.Precio); //item:campo12#precio_unitario(7,2)
					if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(item.Itbis); //item:campo13#tasa_itbis(2,2)

					if (isSuccess) isSuccess = this.EpsonDrive.SendCommand();
					this.FPDelay();

					printer = ValidateReturnCode(this.EpsonDrive.ReturnCode);
					
					if (!printer.IsSucess)
						return printer;

					if(!factura.DescuentoGlobal && DoesFacturaHasDiscount(item.Descuento))
					{
						short itemStatusCode = ImprimeDescuentoPorItem(item);
						printer = ValidateReturnCode(itemStatusCode);

						if (!printer.IsSucess)
							return printer;
					}
				}
			}

			// =======================> Descuentos a nivel General de factura
			if (factura.DescuentoGlobal && DoesFacturaHasDiscount(_factura.DescuentoMonto))
			{
				_factura.DescuentoDescripcion = (_factura.DescuentoDescripcion != null) ? _factura.DescuentoDescripcion : "Descuento:";

					sCmd =  ParForm(Convert.ToString(parametroHash[TiqueFiscal.DescuentoRango]));
					if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(sCmd);

					sCmdExt = ParForm("0000");
					if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(sCmdExt);

					if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(_factura.DescuentoDescripcion);
					if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(_factura.DescuentoMonto);

					if (isSuccess) isSuccess = this.EpsonDrive.SendCommand();
				
					this.FPDelay();

					printer = ValidateReturnCode(this.EpsonDrive.ReturnCode);
					if (!printer.IsSucess)
						return printer;
			}


			// =======================> Pagos
			if(!isNotaDeCredito)  //// las Notas de Credito calculan el pago automaticamente. no es necesario enviarlo.
			{
				foreach(Pago pago in _factura.Pagos)
				{
					if (pago != null) 
					{
						sCmd =  ParForm( Convert.ToString( parametroHash[TiqueFiscal.Pagos] ));
						if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(sCmd);

						sCmdExt = ParForm("0000");
						if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(sCmdExt);

						string formaPago = GetTipoPago(this.CodigoCaja, pago.FormaPago);

						if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(formaPago); //pago:campo1#tipo_pago
						if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(pago.TotalPagado); //pago:campo2#monto_pago

						if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(pago.DescripcionExtra); //pago:campo3#descripcion_extra1
						if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(""); //pago:campo4#descripcion_extra2
						if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(""); //pago:campo5#descripcion_extra3

						if (isSuccess) isSuccess = this.EpsonDrive.SendCommand();
						this.FPDelay();

						printer = ValidateReturnCode(this.EpsonDrive.ReturnCode);
						if (!printer.IsSucess)
							return printer;
					}
				}
			}
			else{

				if(_factura.Pagos.Length > 0)
				{
					Pago pago = _factura.Pagos[0];

					sCmd =  ParForm( Convert.ToString( parametroHash[TiqueFiscal.Pagos] ));
					if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(sCmd);

					sCmdExt = ParForm("0000");
					if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(sCmdExt);
			
					string formaPago = "1";

					if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(formaPago); //pago:campo1#tipo_pago
					if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(pago.TotalPagado); //pago:campo2#monto_pago

					if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(pago.DescripcionExtra); //pago:campo3#descripcion_extra1
					if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(""); //pago:campo4#descripcion_extra2
					if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(""); //pago:campo5#descripcion_extra3

					if (isSuccess) isSuccess = this.EpsonDrive.SendCommand();
					this.FPDelay();

					//printer = ValidateReturnCode(this.EpsonDrive.ReturnCode);
					//if (!printer.IsSucess)
					//	return printer;
				}
			}


			// =================> Ahorro en la factura en el comentario <=================
			// === Imprime el ahorro del cliente de haber alguno

			decimal _monto = GetDiscountAmount(_factura.DescuentoMonto);

			if (_monto > 0)
			{
				_factura.DescuentoDescripcion = (_factura.DescuentoDescripcion != null) ? _factura.DescuentoDescripcion : "Descuento:";

				sCmd =  ParForm( Convert.ToString( parametroHash[TiqueFiscal.Comentarios] ));
				sCmdExt = ParForm("0000");
			
				if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(sCmd);
				if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(sCmdExt);

				string descuentoComentario = String.Format("Ahorro Total en la factura: {0}",  _monto.ToString("##,###,##0.00") );

				if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(descuentoComentario); 

				if (isSuccess) isSuccess = this.EpsonDrive.SendCommand();
				
				this.FPDelay();

				printer = ValidateReturnCode(this.EpsonDrive.ReturnCode);
				if (!printer.IsSucess)
					return printer;
			}
			


			// =======================> Cajera y Numero de Factura
			// === Imprime la informacion de la cajera

			sCmd =  ParForm( Convert.ToString( parametroHash[TiqueFiscal.Comentarios] ));
			sCmdExt = ParForm("0000");

			string invoiceNo = String.Format("Documento No:  {0}", _factura.NumeroFactura);
			string messageCashier = String.Format("Cajera: {0}", _factura.Cajera);

			// Cajera: Numero documento
			printer = ImprimeLineaComentario(sCmd, sCmdExt, invoiceNo);
			if (!printer.IsSucess)
				return printer;

			// Cajera: Nombre Cajera
			printer = ImprimeLineaComentario(sCmd, sCmdExt, messageCashier);
			if (!printer.IsSucess)
				return printer;

			// Cajera: Linea en blanco
			printer = ImprimeLineaComentario(sCmd, sCmdExt, "  ");
			if (!printer.IsSucess)
				return printer;


/*
	   NOTA DE CREDITO CXP
Numero: 319 	Fecha: 07/12/2013
Nombre de: REDSOFT
Monto 445.00  Balance: 445.00

*/

			// =======================> Informacion de Nota de Credito
			// Imprime el detalle de la nota de credito

			if(isNotaDeCredito &&  _factura.NotaCredito != null)
			{
				sCmd =  ParForm( Convert.ToString( parametroHash[TiqueFiscal.Comentarios] ));
				sCmdExt = ParForm("0000");

				printer = this.PrintNotaCredito(sCmd, sCmdExt);
				if (!printer.IsSucess)
					return printer;
			}


			// =======================> INFORMACION SEGURO MEDICO
			if(_factura.EsSeguro)
			{
				sCmd =  ParForm( Convert.ToString( parametroHash[TiqueFiscal.Comentarios] ));
				sCmdExt = ParForm("0000");

				printer = ImprimeLineaComentario(sCmd, sCmdExt, " ");
				if (!printer.IsSucess)
					return printer;

				printer = ImprimeLineaComentario(sCmd, sCmdExt, _tabularUtils.TabLine(Constants.PrinterLineNumber,Constants.FullLine, TabAlign.Left));
				if (!printer.IsSucess)
					return printer;

				// Domicilio: Letrero
				printer = ImprimeLineaComentario(sCmd, sCmdExt,  _tabularUtils.TabLine(Constants.PrinterLineNumber,"INFORMACION SEGURO", TabAlign.Center));
				if (!printer.IsSucess)
					return printer;

				printer = ImprimeLineaComentario(sCmd, sCmdExt, _tabularUtils.TabLine(Constants.PrinterLineNumber,Constants.FullLine, TabAlign.Left));
				if (!printer.IsSucess)
					return printer;


				// Seguro: Paciente
				string paciente = _factura.Seguro.Asegurado != null ? _factura.Seguro.Asegurado : "";
				printer = ImprimeLineaComentario(sCmd, sCmdExt, String.Format("ASEGURADO: {0}", paciente));
				if (!printer.IsSucess)
					return printer;

				// Seguro: ARS
				printer = ImprimeLineaComentario(sCmd, sCmdExt, String.Format("ARS: {0}", _factura.Seguro.Ars != null ? _factura.Seguro.Ars : ""));
				if (!printer.IsSucess)
					return printer;

				// Seguro: PLAN
				printer = ImprimeLineaComentario(sCmd, sCmdExt, String.Format("PLAN: {0}", _factura.Seguro.Plan != null ? _factura.Seguro.Plan : ""));
				if (!printer.IsSucess)
					return printer;


				// Seguro: PLAN
				printer = ImprimeLineaComentario(sCmd, sCmdExt, String.Format("POLIZA: {0}", _factura.Seguro.Poliza != null ? _factura.Seguro.Poliza : ""));
				if (!printer.IsSucess)
					return printer;


				// Seguro: Espacio
				printer = ImprimeLineaComentario(sCmd, sCmdExt, " ");
				if (!printer.IsSucess)
					return printer;

				// Seguro: Linea Firma
				printer = ImprimeLineaComentario(sCmd, sCmdExt, _tabularUtils.TabLine(Constants.PrinterLineNumber, "--------------------", TabAlign.Center));
				if (!printer.IsSucess)
					return printer;


				// Seguro: Firma
				printer = ImprimeLineaComentario(sCmd, sCmdExt, _tabularUtils.TabLine(Constants.PrinterLineNumber, "FIRMA", TabAlign.Center));
				if (!printer.IsSucess)
					return printer;


				// Seguro: Espacio en blanco
				printer = ImprimeLineaComentario(sCmd, sCmdExt, " ");
				if (!printer.IsSucess)
					return printer;

			}




			// =======================> Domicilio
			// === Imprime la informacion del domicilio
			if(_factura.EsDomicilio)
			{
				sCmd =  ParForm( Convert.ToString( parametroHash[TiqueFiscal.Comentarios] ));
				sCmdExt = ParForm("0000");

				printer = ImprimeLineaComentario(sCmd, sCmdExt, " ");
				if (!printer.IsSucess)
					return printer;

				printer = ImprimeLineaComentario(sCmd, sCmdExt, _tabularUtils.TabLine(Constants.PrinterLineNumber,Constants.FullLine, TabAlign.Left));
				if (!printer.IsSucess)
					return printer;


				// Domicilio: Letrero
				printer = ImprimeLineaComentario(sCmd, sCmdExt, _tabularUtils.TabLine(Constants.PrinterLineNumber, "INFORMACION DOMICILIO", TabAlign.Center));
				if (!printer.IsSucess)
					return printer;

				printer = ImprimeLineaComentario(sCmd, sCmdExt, _tabularUtils.TabLine(Constants.PrinterLineNumber,Constants.FullLine, TabAlign.Left));
				if (!printer.IsSucess)
					return printer;

				// Domicilio: Nombre o Razon Social
				string nombre_cliente = _factura.Domicilio.Cliente.Nombre != null ? _factura.Domicilio.Cliente.Nombre : _factura.Cliente.RazonSocial;
				printer = ImprimeLineaComentario(sCmd, sCmdExt, String.Format("   Nombre: {0}", nombre_cliente));
				if (!printer.IsSucess)
					return printer;

				const int lineSize = 43;
				string direccion = _factura.Cliente.Direccion;
				int times = Convert.ToInt32( Math.Ceiling( (float) direccion.Length / lineSize) );

				if (_factura.Cliente.Direccion.Length == 0)
					_factura.Cliente.Direccion = "No Direccion";

				if (direccion.Length <= lineSize)
				{
					// Domicilio: Direccion
					printer = ImprimeLineaComentario(sCmd, sCmdExt, String.Format("Direccion: {0}", _factura.Domicilio.Cliente.Direccion));
					if (!printer.IsSucess)
						return printer;
				}
				else
				{
					int residuo = direccion.Length;
					for(int x=0;x <times; x++)
					{
						if(residuo <0)
							break;

						string parteDireccion = _factura.Cliente.Direccion.Substring(x*lineSize, (residuo> lineSize) ? lineSize : residuo );

						string direcctionImprimir = (x == 0) ?
							string.Format("Direccion: {0}", parteDireccion) :
							string.Format("           {0}", parteDireccion);

						printer = ImprimeLineaComentario(sCmd, sCmdExt, direcctionImprimir);
						if (!printer.IsSucess)
							return printer;

						residuo -= lineSize;;
					}
				}


				// Domicilio: Sector
				printer = ImprimeLineaComentario(sCmd, sCmdExt, String.Format("   Sector: {0}", _factura.Domicilio.Cliente.Sector));
				if (!printer.IsSucess)
					return printer;

				// Domicilio: Mensajero
				printer = ImprimeLineaComentario(sCmd, sCmdExt, String.Format("    Notas: {0}", _factura.Domicilio.Nota.Trim()));
				if (!printer.IsSucess)
					return printer;

				// Domicilio: Telefono
				printer = ImprimeLineaComentario(sCmd, sCmdExt, String.Format("      TEL: {0}", _factura.Domicilio.Cliente.Telefono));
				if (!printer.IsSucess)
					return printer;

				decimal cambiodecimal = Convert.ToDecimal( _factura.Domicilio.Cambio);
				string vueltoToPrint = cambiodecimal > 0 ? _factura.Domicilio.Vuelto : "0";

				// Domicilio: Cambio y Vuelto
				string cambio = String.Format("CAMBIO: {0}      VUELTO: {1}", _factura.Domicilio.Cambio, vueltoToPrint);
				printer = ImprimeLineaComentario(sCmd, sCmdExt, cambio);
				if (!printer.IsSucess)
					return printer;

				// Domicilio: Linea en blanco
				printer = ImprimeLineaComentario(sCmd, sCmdExt, "                                      ");
				if (!printer.IsSucess)
					return printer;

				// Domicilio: Mensajero
				printer = ImprimeLineaComentario(sCmd, sCmdExt, String.Format("Mensajero: {0}", _factura.Domicilio.Mensajero).Trim());
				if (!printer.IsSucess)
					return printer;

			}

			if(_factura.PiePagina != null)
			{
				sCmd =  ParForm( Convert.ToString( parametroHash[TiqueFiscal.Comentarios] ));
				sCmdExt = ParForm("0000");

				printer = ImprimeLineaComentario(sCmd, sCmdExt, " ");
				if (!printer.IsSucess)
					return printer;

				printer = ImprimeLineaComentario(sCmd, sCmdExt, " ");
				if (!printer.IsSucess)
					return printer;


				foreach(string nota in _factura.PiePagina)
				{
					if(nota == null)
					{
						continue;
					}
					printer = ImprimeLineaComentario(sCmd, sCmdExt, _tabularUtils.TabLine(Constants.PrinterLineNumber, nota.Trim(), TabAlign.Center ));
					if (!printer.IsSucess)
						return printer;

				}
			}


			//==========================> Cerrar Caja
			sCmd =  ParForm( Convert.ToString( parametroHash[TiqueFiscal.Cerrar] ));
			if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(sCmd);

			sCmdExt = ParForm("0001");
			if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(sCmdExt);

			if (isSuccess) isSuccess = this.EpsonDrive.AddDataField( _factura.Cierre.ColaRemplazoNo1 ); //cierre:campo1#numero_linea_cola_remplazo_1
			if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(_factura.Cierre.ColaRemplazoDescripcion1); //cierre:campo1#descripcion_remplazo_1
			if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(_factura.Cierre.ColaRemplazoNo2); //cierre:campo1#numero_linea_cola_remplazo_2
			if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(_factura.Cierre.ColaRemplazoDescripcion2); //cierre:campo1#descripcion_remplazo_2
			if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(_factura.Cierre.ColaRemplazoNo3); //cierre:campo1#numero_linea_cola_remplazo_3
			if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(_factura.Cierre.ColaRemplazoDescripcion3); //cierre:campo1#descripcion_remplazo_3

			if (isSuccess) isSuccess = this.EpsonDrive.SendCommand();
			this.FPDelay();

			printer = ValidateReturnCode(this.EpsonDrive.ReturnCode);
			if (!printer.IsSucess)
				return printer;

			printer.NIF = this.EpsonDrive.GetExtraField(1);

			return printer;
		}


		public ImpresoraFisica ReimprimirFactura(Factura factura)
		{
			NoFiscalTemplates.FacturaNoFiscal facturaNoFiscal = new NoFiscalTemplates.FacturaNoFiscal(_printerFactory, codigoCaja);

			string[] documento = facturaNoFiscal.CreateTemplate(factura, Impresora.SecuenciaNoFiscal);

			return this.DocumentoNoFiscal(documento);
		}


		/// <summary>
		/// Metodo usado para imprimir Facturas a Consumidores Finales (Sin Credito Fiscal).
		/// </summary>
		/// <param name="factura"></param>
		/// <returns>ImpresoraFisica {IsSuccess: si completo satisfactoriamente}</returns>
		public bool ConsumidorFinal(Factura factura)
		{
			throw new NotImplementedException();
		}


		/// <summary>
		/// Generar el Cierre X - Cierre de Turno
		/// </summary>
		/// <returns>True - Si la impresion es satisfactoria</returns>
		public ImpresoraFisica CierreX()
		{
			bool isSuccess = true;
			string sCmd = string.Empty;
			string sCmdExt = string.Empty;
			ImpresoraFisica printer = new ImpresoraFisica();

			Hashtable parametroHash = _printerFactory.GetParametroDictionary(this.codigoCaja);

			sCmd =  ParForm( Convert.ToString(parametroHash[JornadaFiscal.ReporteX ]));

			if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(sCmd);

			sCmdExt = ParForm("0001");
			if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(sCmdExt);
			if (isSuccess) isSuccess = this.EpsonDrive.SendCommand();
			
			FPDelay();

			printer = ValidateReturnCode(this.EpsonDrive.ReturnCode);

			return printer;
		}


		/// <summary>
		/// Generar el Cierre Z - Cierre del Dia
		/// </summary>
		/// <returns>True - Si la impresion es satisfactoria</returns>
		public ImpresoraFisica CierreZ()
		{
			bool isSuccess = true;
			string sCmd = string.Empty;
			string sCmdExt = string.Empty;
			ImpresoraFisica printer = new ImpresoraFisica();

			Hashtable parametroHash = _printerFactory.GetParametroDictionary(this.codigoCaja);

			sCmd =  ParForm( Convert.ToString(parametroHash[JornadaFiscal.ReporteZ]) );

			if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(sCmd);

			sCmdExt = ParForm("0001");
			if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(sCmdExt);
			if (isSuccess) isSuccess = this.EpsonDrive.SendCommand();
			
			FPDelay();

			printer = ValidateReturnCode(this.EpsonDrive.ReturnCode);
			
			return printer;
		}


		public ImpresoraFisica InformeJornada()
		{
			bool isSuccess = true;
			string sCmd = string.Empty;
			string sCmdExt = string.Empty;
			ImpresoraFisica printer = new ImpresoraFisica();

			Hashtable parametroHash = _printerFactory.GetParametroDictionary(this.codigoCaja);

			sCmd =  ParForm( Convert.ToString(parametroHash[JornadaFiscal.InformeJornada]) );

			if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(sCmd);

			sCmdExt = ParForm("0001");
			if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(sCmdExt);
			if (isSuccess) isSuccess = this.EpsonDrive.SendCommand();
			
			FPDelay();

			printer = ValidateReturnCode(this.EpsonDrive.ReturnCode);
			
			return printer;
		}


		public ImpresoraFisica ImprimeCierreZPorFecha(DateTime fechaInicial, DateTime fechaFinal, int reportes)
		{
			bool isSuccess = true;
			string sCmd = string.Empty;
			string sCmdExt = string.Empty;
			ImpresoraFisica printer = new ImpresoraFisica();

			int cantidadReportes = reportes;

			Hashtable parametroHash = _printerFactory.GetParametroDictionary(this.codigoCaja);

			//sCmd =  ParForm( Convert.ToString(parametroHash[JornadaFiscal.AuditoriaResumidaJFRangoFecha]) );
			sCmd =  ParForm( "0901" );
			sCmdExt = ParForm("0001");

			if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(sCmd);
			if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(sCmdExt);

			string iFecha = fechaInicial.ToString("ddMMyyyy");
			string fFecha = fechaFinal.ToString("ddMMyyyy");

			if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(iFecha);
			if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(fFecha);

			if (isSuccess) isSuccess = this.EpsonDrive.SendCommand();
			
			FPDelay();

			printer = ValidateReturnCode(this.EpsonDrive.ReturnCode);
			isSuccess = printer.IsSucess;

			if(!printer.IsSucess)
				return printer;

			cantidadReportes++;
			for(int x = 0; x<cantidadReportes; x++)
			{
				sCmd =  ParForm( "0920" );
				sCmdExt = ParForm("0000");

				if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(sCmd);
				if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(sCmdExt);

				if (isSuccess) isSuccess = this.EpsonDrive.SendCommand();
			
				FPDelay();

				printer = ValidateReturnCode(this.EpsonDrive.ReturnCode);
				isSuccess = printer.IsSucess;
				
			}

			sCmd =  ParForm( "0921" );
			sCmdExt = ParForm("0000");

			if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(sCmd);
			if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(sCmdExt);

			if (isSuccess) isSuccess = this.EpsonDrive.SendCommand();
			
			FPDelay();

			printer = ValidateReturnCode(this.EpsonDrive.ReturnCode);

			return printer;

		}

		public ImpresoraFisica ImprimeCierreZPorRango(int rangoInicial, int rangoFinal)
		{
			bool isSuccess = true;
			string sCmd = string.Empty;
			string sCmdExt = string.Empty;
			ImpresoraFisica printer = new ImpresoraFisica();

			int cantidadReportes = rangoFinal - rangoInicial;

			Hashtable parametroHash = _printerFactory.GetParametroDictionary(this.codigoCaja);

			//sCmd =  ParForm( Convert.ToString(parametroHash[JornadaFiscal.AuditoriaResumidaJFRangoCierreZ]) );
			sCmd =  ParForm( "0902" );
			sCmdExt = ParForm("0001");

			if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(sCmd);
			if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(sCmdExt);

			if (isSuccess) isSuccess = this.EpsonDrive.AddDataField( Convert.ToString(rangoInicial));
			if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(Convert.ToString(rangoFinal));

			if (isSuccess) isSuccess = this.EpsonDrive.SendCommand();
			
			FPDelay();

			printer = ValidateReturnCode(this.EpsonDrive.ReturnCode);
			isSuccess = printer.IsSucess;

			if(!printer.IsSucess)
				return printer;


			cantidadReportes+=2;
			for(int x = 0; x<cantidadReportes; x++)
			{
				sCmd =  ParForm( "0920" );
				sCmdExt = ParForm("0000");

				if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(sCmd);
				if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(sCmdExt);

				if (isSuccess) isSuccess = this.EpsonDrive.SendCommand();
			
				FPDelay();

				printer = ValidateReturnCode(this.EpsonDrive.ReturnCode);
				isSuccess = printer.IsSucess;
				
			}


			sCmd =  ParForm( "0921" );
			sCmdExt = ParForm("0000");

			if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(sCmd);
			if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(sCmdExt);

			if (isSuccess) isSuccess = this.EpsonDrive.SendCommand();
			
			FPDelay();

			printer = ValidateReturnCode(this.EpsonDrive.ReturnCode);

			return printer;
		}

		public ImpresoraFisica PrintNoFiscalEgresos(Sucursal sucursal, string[] data)
		{
			string headerTipoDocumento = "RECIBO DE EGRESOS";
			FacturaNoFiscal facturaNoFiscal = new FacturaNoFiscal(_printerFactory, codigoCaja);

			string[] header = facturaNoFiscal.GetNoFiscalHeader(sucursal, headerTipoDocumento, _impresora.SecuenciaNoFiscal);

			int length = header.Length + data.Length;

			string[] newArray = new string[length];
		
			int indice = 0;
			for(int x=0; x<header.Length; x++)
			{
				newArray[indice++] = header[x];
			}

			for(int x=0; x < data.Length; x++)
			{
				string val = data[x];

				if(indice > length)
					break;

				if(val != null)
					newArray[indice++] = val;
			}

			header = null;
			data = null;
			return this.DocumentoNoFiscal(newArray);
		}
		
		public ImpresoraFisica DocumentoNoFiscal(String[] documento)
		{
			bool isSuccess = true;
			string sCmd = string.Empty;
			string sCmdExt = string.Empty;
			ImpresoraFisica printer = new ImpresoraFisica();

			Hashtable parametroHash = _printerFactory.GetParametroDictionary(this.codigoCaja);

			// ==> Inicializa Documento
			sCmd =  ParForm(Convert.ToString(parametroHash[DocumentosNoFiscales.Abrir]));
			if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(sCmd);

			sCmdExt = ParForm("0000");
			if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(sCmdExt);

			if (isSuccess) isSuccess = this.EpsonDrive.SendCommand();
			
			FPDelay();

			printer = ValidateReturnCode(this.EpsonDrive.ReturnCode);

			if(!printer.IsSucess)
				return printer;
			
			sCmd =  ParForm(Convert.ToString(parametroHash[DocumentosNoFiscales.ImprimirTextoNoFiscal]));
			sCmdExt = ParForm("0000");

			foreach(string doc in documento)
			{
				if(sCmd == null)
					continue;

				printer = this.ImprimeLineaNoFiscal(sCmd, sCmdExt, doc);
				if(!printer.IsSucess)
					return printer;
			}

			// Cerrar documento.
			sCmd =  ParForm(Convert.ToString(parametroHash[DocumentosNoFiscales.Cerrar]));
			if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(sCmd);

			sCmdExt = ParForm("0001");
			if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(sCmdExt);

			if (isSuccess) isSuccess = this.EpsonDrive.SendCommand();
			printer = ValidateReturnCode(this.EpsonDrive.ReturnCode);

			IncrementaSecuenciaNoFiscal(this.codigoCaja, ++Impresora.SecuenciaNoFiscal);

			return printer;

		}


		public void FPDelay()
		{
			DateTime start = DateTime.Now;
		
			while (this.EpsonDrive.CtlState == EpsonFPHostControlX.TxFiscalState.EFP_S_Busy)
			{
				while(DateTime.Now < start.AddMilliseconds(0.125))
				{
					if(start > DateTime.Now)
						continue;
					System.Windows.Forms.Application.DoEvents();
				}
			}

		}


		private void FPDelayTimed()
		{
			DateTime start = DateTime.Now;
		
			while (this.EpsonDrive.CtlState == EpsonFPHostControlX.TxFiscalState.EFP_S_Busy)
			{
				while(DateTime.Now < start.AddMilliseconds(1000))
				{
					if(start > DateTime.Now)
						continue;
					System.Windows.Forms.Application.DoEvents();
				}
			}

		}


		public string ParametroFormateado(string parametro)
		{
			string _cmd = string.Empty;

			_cmd = HelperClass.PrintHelper.FormatearParametro(parametro);

			return _cmd;
		}


		/// <summary>
		/// Method Used to Retreive the Printer Status
		/// </summary>
		/// <returns></returns>
		public ImpresoraFisica ValidaPrinterStatus()
		{
		
			bool isSuccess = true;
			string sCmd = string.Empty;
			string sCmdExt = string.Empty;
			ImpresoraFisica printer = new ImpresoraFisica();
			printer.IsSucess = true;

			Hashtable parametroHash = _printerFactory.GetParametroDictionary(this.codigoCaja);

			//sCmd = ParForm(Convert.ToString(parametroHash[Sistema.ObtenerEstado]));
			sCmd = ParForm("0001");
			sCmdExt = ParForm("0000");

            if(printer.IsSucess) printer.IsSucess = this.EpsonDrive.AddDataField(sCmd);
			if (printer.IsSucess) printer.IsSucess = this.EpsonDrive.AddDataField(sCmdExt);

			if (printer.IsSucess) printer.IsSucess = this.EpsonDrive.SendCommand();
			this.FPDelayTimed();

			if (printer.IsSucess)  printer = ValidateReturnCode(this.EpsonDrive.ReturnCode);

			return printer;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <returns>True if Day is Missing CierreZ and False otherwise.</returns>
		public bool isDayMissingCierreZ()
		{
			ImpresoraFisica printer = ValidaPrinterStatus();

			// Codigo de Error para Cierre Z para las Epson
			return (Convert.ToString(printer.ReturnCode) == "2519");
		}


		public ImpresoraFisica CancelarImpresionFiscal()
		{
		
			bool isSuccess = true;
			string sCmd = string.Empty;
			string sCmdExt = string.Empty;
			ImpresoraFisica printer = new ImpresoraFisica();

			Hashtable parametroHash = _printerFactory.GetParametroDictionary(this.codigoCaja);

			sCmd = ParForm(Convert.ToString(parametroHash[TiqueFiscal.Cancelar]));
			sCmdExt = ParForm("0000");

			if(isSuccess) isSuccess = this.EpsonDrive.AddDataField(sCmd);
			if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(sCmdExt);

			if (isSuccess) isSuccess = this.EpsonDrive.SendCommand();
			this.FPDelay();

			printer = ValidateReturnCode(this.EpsonDrive.ReturnCode);

			return printer;
		}


		#region "Private Methods"

		// Used as a shorthand of the implementation. Just for naming convinience.
		private string ParForm(string parametro)
		{
			return ParametroFormateado(parametro);
		}

		private ImpresoraFisica ValidateReturnCode(short returnCode)
		{
			ImpresoraFisica printer = new ImpresoraFisica();

			if (returnCode == 0 && GlobalError) 
				printer.IsSucess = true;
			else
			{
				printer.IsSucess = false;
				printer.ErrorDescription = _printerFactory.GetErrorDescripcion(this.CodigoCaja, Convert.ToString(printer.ReturnCode));	
			}

			// Setting this values so they can be accessed from the outside of the Library
			printer.FiscalStatus = this.EpsonDrive.FiscalStatus;
			printer.PrinterStatus = this.EpsonDrive.PrinterStatus;
			printer.ReturnCode = this.EpsonDrive.ReturnCode;

			return printer;
		}


		private string GetTipoPago(string codigoCaja, string tipoPago)
		{
			return _printerFactory.GetTipoPagoCodigo(codigoCaja, tipoPago);
		}


		/// <summary>
		/// Function to print a line of comment
		/// </summary>
		/// <param name="sCmd">Command</param>
		/// <param name="sCmdExt">Extension</param>
		/// <param name="valor">Value to be printed</param>
		/// <returns>ImpresoraFisica con el Status y el ErrorCode de haber alguno</returns>
		private ImpresoraFisica ImprimeLineaComentario(string sCmd, string sCmdExt, string valor )
		{
			ImpresoraFisica printer;
			bool isSuccess = true;

			if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(sCmd);
			if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(sCmdExt);

			if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(valor);

			if (isSuccess) isSuccess = this.EpsonDrive.SendCommand();
			this.FPDelay();

			printer = ValidateReturnCode(this.EpsonDrive.ReturnCode);

			return printer;
		}

		/// <summary>
		/// Function to print No-Fiscal documents line
		/// </summary>
		/// <param name="sCmd">Comando</param>
		/// <param name="sCmdExt">Extension</param>
		/// <param name="texto">Texto a imprimir en la linea</param>
		/// <returns>ImpresoraFisica con el Status y el ErrorCode de haber alguno</returns>
		private ImpresoraFisica ImprimeLineaNoFiscal(string sCmd, string sCmdExt, string texto ){

			ImpresoraFisica printer;
			bool isSuccess = true;

			if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(sCmd);
			if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(sCmdExt);

			if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(texto);

			if (isSuccess) isSuccess = this.EpsonDrive.SendCommand();
			FPDelay();
		
			printer = ValidateReturnCode(this.EpsonDrive.ReturnCode);

			return printer;
		
		}

		/// <summary>
		/// Format string values in the form of 1800 without dot  nor commas.
		/// </summary>
		/// <param name="amount">Value in the form of 185000</param>
		/// <returns>String value formated ej 1,850.00</returns>
		private string FormatAmount(string amount)
		{
			decimal _value = 0.00m;

			try
			{
				string _result = String.Format("{0}.{1}", amount.Substring(0, amount.Length - 2), amount.Substring(amount.Length - 2)) ;
				_value = Decimal.Parse(_result);
			}
			catch{}

			return _value.ToString("##,###,##0.00");

		}


		private ImpresoraFisica PrintNotaCredito(string sCmd, string sCmdExt)
		{
			ImpresoraFisica printer = new ImpresoraFisica();

			printer = ImprimeLineaComentario(sCmd, sCmdExt, _tabularUtils.TabLine(Constants.PrinterLineNumber,Constants.FullLine, TabAlign.Left));
			if (!printer.IsSucess)
				return printer;

			// Nota de Credito: Letrero
			printer = ImprimeLineaComentario(sCmd, sCmdExt, _tabularUtils.TabLine(Constants.PrinterLineNumber,"NOTA DE CREDITO CXP", TabAlign.Center));
			if (!printer.IsSucess)
				return printer;

			printer = ImprimeLineaComentario(sCmd, sCmdExt, _tabularUtils.TabLine(Constants.PrinterLineNumber,Constants.FullLine, TabAlign.Left));
			if (!printer.IsSucess)
				return printer;

			// Nota de Credito: Numero y Fecha
			string lineNotaCredito = string.Format("Numero: {0}      Fecha: {1}", _factura.NotaCredito.Numero, _factura.NotaCredito.Fecha);
			printer = ImprimeLineaComentario(sCmd, sCmdExt, lineNotaCredito);
			if (!printer.IsSucess)
				return printer;
		
			// Nota de Credito: Nombre
			lineNotaCredito = string.Format("Nombre: {0}", _factura.NotaCredito.Nombre);
			printer = ImprimeLineaComentario(sCmd, sCmdExt, lineNotaCredito);
			if (!printer.IsSucess)
				return printer;

			// Nota de Credito: Nombre
			lineNotaCredito = string.Format("Monto: {0}      Balance: {1}", _factura.NotaCredito.Monto, _factura.NotaCredito.Balance);
			printer = ImprimeLineaComentario(sCmd, sCmdExt, lineNotaCredito);
			if (!printer.IsSucess)
				return printer;

		return printer;
		
		}

		private decimal GetDiscountAmount(string discount)
		{
			decimal _monto = 0.00M;

			try {_monto = Decimal.Parse(discount) / 100;}
			catch {}

			return _monto;
		}

		private bool DoesFacturaHasDiscount(string discount)
		{
			decimal _monto = 0.00M;

			try {_monto = Decimal.Parse(discount);}
			catch {}

			return (_monto > 0);
		}



		#endregion

		private void EpsonDrive_OnError(object sender, EventArgs e)
		{
			GlobalError = false;
		}

		private void EpsonDrive_OnWrite(object sender, IEpsonFPHostControlEvents_OnWriteEvent e)
		{
			GlobalError = true;
		}

		public void IncrementaSecuenciaNoFiscal(string caja, int nuevaSecuencia)
		{
			_printerFactory.IncrementaSecuenciaNoFiscal(caja, nuevaSecuencia);
		}

		private short ImprimeDescuentoPorItem(Articulo item)
		{
			bool isSuccess = true;
			string sCmdExt;
			string sCmd;
			decimal _itemDescuento;
			decimal _itebis;

			try
			{
				_itemDescuento = decimal.Parse( item.Descuento);
				_itebis = decimal.Parse(item.Itbis);

				if(_itemDescuento > 0)
				{
					_itemDescuento = _itemDescuento / 100;
				}

				if(_itebis > 0)
				{
					_itebis = _itebis / 10000;

					_itemDescuento = _itemDescuento * (1 + _itebis);

					item.Descuento = FormatNumber(_itemDescuento);
				}

			}
			catch(Exception e)
			{
			
			}

			sCmd =  ParForm( Convert.ToString( parametroHash[TiqueFiscal.Item] ));

			if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(sCmd);

			sCmdExt = ParForm("0002");
			if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(sCmdExt);
				
			if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(item.DescripcionExtra1); //item:campo1#descripcion_extra_1
			if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(""); //item:campo2#descripcion_extra_2
			if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(""); //item:campo3#descripcion_extra_3
			if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(""); //item:campo4#descripcion_extra_4
			if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(""); //item:campo5#descripcion_extra_5
			if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(""); //item:campo6#descripcion_extra_6
			if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(""); //item:campo7#descripcion_extra_7
			if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(""); //item:campo8#descripcion_extra_8
			if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(""); //item:campo9#descripcion_extra_9
			if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(item.Descripcion); //item:campo10#descripcion
			if (isSuccess) isSuccess = this.EpsonDrive.AddDataField("1000"); //item:campo11#cantidad(5,3)
			if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(item.Descuento); //item:campo12#precio_unitario(7,2)
			if (isSuccess) isSuccess = this.EpsonDrive.AddDataField(item.Itbis); //item:campo13#tasa_itbis(2,2)

			if (isSuccess) isSuccess = this.EpsonDrive.SendCommand();
			this.FPDelay();

			return this.EpsonDrive.ReturnCode;
		}


		private static string FormatNumber(object number)
		{
			string _tempNumber;
			string _returnNumber = String.Empty;

			if(number != null)
			{
				_tempNumber = string.Format("{0:0.00}", number);
				_returnNumber = _tempNumber.Replace(".","").Replace(",","");
			}

			return _returnNumber;
		}

	}
}
