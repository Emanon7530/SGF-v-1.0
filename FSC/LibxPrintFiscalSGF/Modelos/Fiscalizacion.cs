using System;

namespace LibxPrintFiscalSGF.Modelos
{
	/// <summary>
	/// Summary description for Fiscalizacion.
	/// </summary>
	public class Fiscalizacion
	{
		private bool _esFiscal;
		private bool _esNotaCredito;
		private string _paramTipoDoc;
		private string _tipoDocumento;

		public bool EsFiscal
		{
			get {return _esFiscal;}
			set {_esFiscal = value;}
		}

		public bool EsNotaCredito
		{
			get {return _esNotaCredito;}
			set {_esNotaCredito = value;}
		}

		public string ParamTipoDoc
		{
			get{return _paramTipoDoc;}
			set {_paramTipoDoc = value;}
		}

		public string TipoDocumento
		{
			get{return _tipoDocumento;}
			set {_tipoDocumento = value;}
		}

		public Fiscalizacion()
		{
		}

	}
	
}
