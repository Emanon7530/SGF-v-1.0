using System;

namespace LibxPrintFiscalFactura.Parametros
{
	/// <summary>
	/// Summary description for ImpresoraFisica.
	/// </summary>
	public class ImpresoraFisica
	{

		private short _returnCode;
		private short _printerStatus;
		private short _fiscalStatus;
		private bool _isSucess;
		private string _description;

		public short ReturnCode
		{
			get{return _returnCode;}
			set{_returnCode = value;}
		}

		public short PrinterStatus
		{
			get{return _printerStatus;}
			set{_printerStatus = value;}
		}

		public short FiscalStatus
		{
			get{return _fiscalStatus;}
			set {_fiscalStatus=value;}
		}

		public bool IsSucess
		{
			get{return _isSucess;}
			set{_isSucess = value;}
		}


		public string ErrorDescription
		{
			get{return _description;}
			set{_description = value;}
		}

		public ImpresoraFisica()
		{
		}
	}
}
