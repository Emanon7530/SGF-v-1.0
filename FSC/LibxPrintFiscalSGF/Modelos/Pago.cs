using System;

namespace LibxPrintFiscalSGF.Modelos
{
	/// <summary>
	/// Summary description for Pagos.
	/// </summary>
	public class Pago
	{
		private string _formaPago;
		private string _formaPagoId;
		private string _totalPagado;
		private string _descripcionExtra;

		public string FormaPago
		{
			get{return _formaPago;}
			set{_formaPago = value;}
		}

		public string FormaPagoId
		{
			get{return _formaPagoId;}
			set{_formaPagoId=value;}
		}

		public string TotalPagado
		{
			get{return _totalPagado;}
			set{_totalPagado=value;}
		}

		public string DescripcionExtra
		{
			get{return (_descripcionExtra != null) ? _descripcionExtra : String.Empty; }
			set{_descripcionExtra = value;}
		}

		public Pago()
		{
		}
	}
}
