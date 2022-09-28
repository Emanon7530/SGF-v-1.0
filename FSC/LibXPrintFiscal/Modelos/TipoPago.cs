using System;

namespace LibXPrintFiscal.Modelos
{
	/// <summary>
	/// 
	/// </summary>
	public class TipoPago
	{

		private const string TABLE_NAME = "sgftipopago";

		private int _id;
		private int _codigoImpresora;
		private string _tipoPagoId;
		private string _codigoPago;
		private string _nombre;

		public int Id
		{
			get{return _id;}
			set{_id = value;}
		}

		public static string NombreTabla
		{
			get
			{
				return TABLE_NAME;
			}
		}		
	
		public int CodigoImpresora
		{
			get{return _codigoImpresora;}
			set{_codigoImpresora = value;}
		}

		public string TipoPagoId
		{
			get{return _tipoPagoId;}
			set{_tipoPagoId = value;}
		}

		public string CodigoPago
		{
			get{return _codigoPago;}
			set{_codigoPago = value;}
		}

		public string Nombre
		{
			get{return _nombre;}
			set{_nombre = value;}
		}

		public TipoPago()
		{
			
		}


		public class Columnas
		{
			private const string _id = "id";
			private const string _codigoImpresora = "codigo_impresora";
			private const string _tipoPagoId = "tipo_pago";
			private const string _codigoPago = "codigo_pago";
			private const string _nombre = "nombre";
		
			public static string Id {get {return _id;}}
			public static string CodigoImpresora {get {return _codigoImpresora;}}
			public static string TipoPagoId {get {return _tipoPagoId;}}
			public static string CodigoPago {get {return _codigoPago;}}
			public static string Nombre {get {return _nombre;}}

		}

		
	}
}
