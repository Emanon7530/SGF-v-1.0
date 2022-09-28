using System;

namespace LibxPrintFiscalFactura
{
	/// <summary>
	/// Summary description for Domicilio.
	/// </summary>
	public class Domicilio
	{

		private string _mensajero;
		private string _vuelto;
		private string _cambio;
		private Cliente _cliente;
		private string _nota;

		public String Mensajero
		{
			get{return _mensajero;}
			set{_mensajero=value;}
		}


		public String Vuelto
		{
			get{return _vuelto;}
			set{_vuelto=value;}
		}

		public String Cambio
		{
			get{return _cambio;}
			set{_cambio=value;}
		}

		public Cliente Cliente
		{
			get{return _cliente;}
			set{_cliente = value;}
		}


		public string Nota
		{
			get{return _nota;}
			set{_nota = value;}
		}
		

		public Domicilio()
		{
		}
	}
}
