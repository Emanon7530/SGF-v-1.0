using System;

namespace LibxPrintFiscalFactura
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
		private string _numeroFactura;

		private Cliente cliente;
		
		private DateTime fecha;
		private string nif;
		private string tipoDocumento;
		private string tipoDocumentoId;
		private Articulo[] articulos;
		private string _descuentoDescripcion;
		private Pago[] _pago;
		private Cierre cierre;
		private string devuelta;
		private string cajera;
		private string cajeraId;
		private bool _esDomicilio;
		private Domicilio _domicilio;
		private NotaCredito notaCredito;
		private bool _esSeguro;

		private string _subtotal;
		private string _itbis;
		private string _hora;
		private string _nombreVendedor;
		private string totalPagar;
		private string _descuento;
		private string _descuentoGeneral;
		private string[] _piePagina;
		private bool _imprimeCopia;
		private bool _descuentoGlobal;


		private Seguro _seguro;


		public Cierre Cierre
		{
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

		public string NumeroFactura
		{
			get{return _numeroFactura;}
			set{_numeroFactura = value;}
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

		public string DescuentoMonto
		{
			get{return _descuento;}
			set{_descuento=value;}
		}

		public string DescuentoGeneral
		{
			get{return _descuentoGeneral;}
			set{_descuentoGeneral=value;}
		}

		public string DescuentoDescripcion
		{
			get{return _descuentoDescripcion;}
			set{_descuentoDescripcion = value;}
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

		public bool EsDomicilio
		{
			get{return _esDomicilio;}
			set {_esDomicilio = value;}
		}

		public Domicilio Domicilio
		{
			get{return this._domicilio;}
			set{_domicilio = value;}
		}


		public NotaCredito NotaCredito
		{
			get{return this.notaCredito;}
			set{this.notaCredito = value;}
		}

		public string Itbis
		{
			get{return _itbis;}
			set{_itbis=value;}
		}
		
		public string SubTotal
		{
			get{return _subtotal;}
			set{_subtotal=value;}
		}
		
		public string Hora
		{
			get{return _hora;}
			set{_hora=value;}
		}

		public string VendedorNombre
		{
			get{return _nombreVendedor;}
			set{_nombreVendedor=value;}
		}

		public bool EsSeguro
		{
			get {return _esSeguro;}
			set {_esSeguro= value;}
		}

		public Seguro Seguro
		{
			get {return _seguro;}
			set {_seguro = value;}
		}

		public string[] PiePagina
		{
			get {return _piePagina;}
			set {_piePagina = value;}
		}

		public bool ImprimeCopia
		{
			get {return _imprimeCopia;}
			set {_imprimeCopia = value;}
		}

		public bool DescuentoGlobal
		{
			get {return _descuentoGlobal;}
			set {_descuentoGlobal = value;}
		}

		public Factura()
		{
			PiePagina = new string[0];
		}
	}
}
