using System;

namespace LibxPrintFiscalSGF.Modelos
{
	/// <summary>
	/// Summary description for Factura.
	/// </summary>
	public class Factura
	{
		
		private Sucursal sucursal;
		private string codigoCaja;
		private string	ncf;
		private string ncfReferencia;

		private Cliente cliente;
		
		private DateTime fecha;
		private string nif;
		private string tipoDocumento;
		private string tipoDocumentoId;
		private Articulo[] articulos;
		private string totalPagar;
		private Pago[] _pago;
		private Cierre cierre;
		private string devuelta;
		private string cajera;
		private string cajeraId;


		public Cierre Cierre{
			get{return cierre;}
			set{cierre = value;}
		} 

		public string NcfReferencia
		{
			get{return (ncfReferencia !=null) ? ncfReferencia : String.Empty ;}
			set{ncfReferencia = value;}
		}

		public string CodigoCaja
		{
			get {return codigoCaja;}
			set {codigoCaja=value;}
		}

		public Sucursal Sucursal
		{
			get{return sucursal;}
			set{sucursal=value;}
		}

		public DateTime Fecha
		{
			get{return fecha;}
			set{fecha=value;}
		}

		public string NCF
		{
			get{return ncf;}
			set{ncf=value;}
		}

		public string NIF
		{
			get{return nif;}
			set{nif=value;}
		}

		public Cliente Cliente
		{
			get{return cliente;}
			set{cliente = value;}
		}

		public string TipoDocumento
		{
			get{return tipoDocumento;}
			set{tipoDocumento=value;}
		}

		public string TipoDocumentoId
		{
			get{return tipoDocumentoId;}
			set{tipoDocumentoId =value;}
		}

		public Articulo[] Articulos
		{
			get{return articulos;}
			set{articulos=value;}
		}

		public string TotalPagar
		{
			get{return totalPagar;}
			set{totalPagar=value;}
		}


		public Pago[] Pagos
		{
			get{return _pago;}
			set{_pago = value;}
		}

		public string Devuelta
		{
			get{return devuelta;}
			set{devuelta=value;}
		}

		public string Cajera
		{
			get{return cajera;}
			set{cajera=value;}
		}
		
		public string CajeraId
		{
			get{return cajeraId;}
			set{cajeraId=value;}
		}

		public Factura()
		{
		}
	}
}
