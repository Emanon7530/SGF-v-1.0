using System;

namespace LibxPrintFiscalFactura
{
	/// <summary>
	/// Summary description for Credito.
	/// </summary>
	public class NotaCredito
	{

		private string numero;
		private string fecha;
		private string nombre;
		private decimal monto;
		private decimal balance;

		public string Numero
		{
			get{return this.numero;}
			set{this.numero = value;}
		}

		public string Fecha
		{
			get{return this.fecha;}
			set{this.fecha = value;}
		}

		public string Nombre
		{
			get{return this.nombre;}
			set{this.nombre = value;}
		}

		public decimal Monto
		{
			get{return this.monto;}
			set{this.monto = value;}
		}

		public decimal Balance
		{
			get{return this.balance;}
			set{this.balance = value;}
		}
		
		public NotaCredito()
		{
		}
	}
}
