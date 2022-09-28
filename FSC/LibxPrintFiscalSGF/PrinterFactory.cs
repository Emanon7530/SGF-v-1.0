using System;
using LibXPrintFiscal.Modelos;
using LibXPrintFiscal.Interfaces;
using LibXPrintFiscal.Repositorios;
using System.Collections;
using LibxPrintFiscalSGF.Modelos;

namespace LibxPrintFiscalSGF
{
	/// <summary>
	/// Summary description for PrinterFactory.
	/// </summary>
	public class PrinterFactory : IPrinterFactory
	{
		private IParametro _parametro;
		private IExtension _extension;
		private IImpresora _impresora;
		private ITipoPago _tipoPago;
		private IErrorRetorno _error;

		Hashtable parametroHash;

		public IErrorRetorno ErrorRetorno
		{
			get{return _error;}
			set{_error = value;}
		}

		public PrinterFactory()
			:this(
			new ParametroRepository(), 
			new ImpresoraRepository(), 
			new ExtensionRepository(),
			new TipoPagoRepository()
			)
		{

		}

		public PrinterFactory(IParametro parametro, IImpresora impresora, IExtension extension, ITipoPago tipoPago)
		{
			this._parametro = parametro;
			this._extension = extension;
			this._impresora=impresora;
			this._tipoPago = tipoPago;
		}

		public Parametro[] GetParametros(string caja)
		{
			Impresora impresora = _impresora.GetDefaultImpresora(caja);
			return (impresora != null) ? _parametro.GetParametrosByImpresora(impresora.Codigo) : new Parametro[0];
		}

		public string GetComando(string parametro)
		{
			string comando = string.Empty;

			parametro = parametro.Trim();

			comando = Convert.ToString( parametroHash["parametro"]);

			return comando;
		}

		public Hashtable GetParametroDictionary(string caja)
		{
			parametroHash = new Hashtable();
			Impresora impresora = _impresora.GetDefaultImpresora(caja);

			if (impresora != null)
			{
				Parametro[] parametros = _parametro.GetParametrosByImpresora(impresora.Codigo);

				foreach(Parametro par in parametros)
				{
					parametroHash.Add(par.Codigo, par.Comando);
				}
			}

			return parametroHash;
		}


		public Hashtable GetExtensionDictionary(int parametroCodigo)
		{
			throw new NotImplementedException();
		}


		public string GetTipoPagoCodigo(string codigoCaja, string tipoPagoId)
		{
			Impresora impresora = _impresora.GetDefaultImpresora(codigoCaja);
			string codigoPago = string.Empty;

			if (impresora != null)
			{
				codigoPago = _tipoPago.GetTipoPagoCode(impresora.Codigo, tipoPagoId);
			}

			return codigoPago;
		}


		public string GetTipoPagoNombre(string codigoCaja, string tipoPagoId)
		{
			Impresora impresora = _impresora.GetDefaultImpresora(codigoCaja);
			string nombrePago = string.Empty;

			if (impresora != null)
			{
				nombrePago = _tipoPago.GetTipoPagoNombre(impresora.Codigo, tipoPagoId);
			}

			return nombrePago;
		}


		public string GetErrorDescripcion(string codigoCaja, string codigoError)
		{
			if (_error == null)
				throw new NullReferenceException("Error Library no ha sido Inicializada");

			Impresora impresora = _impresora.GetDefaultImpresora(codigoCaja);
			string errorDescripcion = string.Empty;

			if (impresora != null)
			{
				errorDescripcion = _error.GetErrorDescriptionByCode(codigoError, impresora.Codigo);
			}

			return errorDescripcion;

		}

		public Impresora GetDefaultImpresora(string codigoCaja)
		{
			return _impresora.GetDefaultImpresora(codigoCaja);
		}

		public Fiscalizacion GetFiscalizacionByDocumentId(string tipoDocumentId)
		{
			Fiscalizacion fiscalizacion = new Fiscalizacion();
		
			switch(tipoDocumentId)
			{
				case "0": // Consumidor Final
					fiscalizacion.TipoDocumento = "FACTURA PARA CONSUMIDOR FINAL";
					fiscalizacion.ParamTipoDoc = "0000";
					fiscalizacion.EsNotaCredito = false;
					fiscalizacion.EsFiscal = false;
					break;
				case "1": // Factura de Credito Fiscal
					fiscalizacion.TipoDocumento = "FACTURA PARA CREDITO FISCAL";
					fiscalizacion.ParamTipoDoc = "0001";
					fiscalizacion.EsNotaCredito = false;
					fiscalizacion.EsFiscal = true;
					break;
				case "2": // Nota de Credito 
					fiscalizacion.TipoDocumento = "NOTA DE CREDITO PARA CONSUMIDOR FINAL";
					fiscalizacion.ParamTipoDoc = "0002";
					fiscalizacion.EsNotaCredito = true;
					fiscalizacion.EsFiscal = false;
					break;
				case "3": // Nota de Credito a CreditoFiscal
					fiscalizacion.TipoDocumento = "NOTA DE CREDITO PARA FISCAL";
					fiscalizacion.ParamTipoDoc = "0003";
					fiscalizacion.EsNotaCredito = true;
					fiscalizacion.EsFiscal = true;
					break;
				case "4": // Factura consumidor final excento de itbis
					fiscalizacion.TipoDocumento = "FACTURA CONSUMIDOR FINAL EXCENTO DE ITBIS";
					fiscalizacion.ParamTipoDoc = "0004";
					fiscalizacion.EsNotaCredito = false;
					fiscalizacion.EsFiscal = false;
					break;
				case "5": // Factura Credito Fiscal excento de itbis
					fiscalizacion.TipoDocumento = "FACTURA CREDITO FISCAL EXCENTO DE ITBIS";
					fiscalizacion.ParamTipoDoc = "0005";
					fiscalizacion.EsNotaCredito = false;
					fiscalizacion.EsFiscal = true;
					break;
				case "7": /// Nota de Credito Fiscal excento de itbis
					fiscalizacion.TipoDocumento = "NOTA DE CREDITO FISCAL EXCENTO DE ITBIS";
					fiscalizacion.ParamTipoDoc = "0007";
					fiscalizacion.EsNotaCredito = true;
					fiscalizacion.EsFiscal = true;
					break;
				default :
					fiscalizacion.TipoDocumento = "FACTURA PARA CONSUMIDOR FINAL";
					fiscalizacion.ParamTipoDoc = "0000";
					fiscalizacion.EsNotaCredito = false;
					fiscalizacion.EsFiscal = false;
					break;
			};

			return fiscalizacion;
		}


		public void IncrementaSecuenciaNoFiscal(string caja, int nuevaSequencia)
		{
			_impresora.IncrementaSecuenciaNoFiscal(caja, nuevaSequencia);
		}

	}
}
