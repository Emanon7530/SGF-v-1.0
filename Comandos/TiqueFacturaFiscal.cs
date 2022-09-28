using System;

namespace LibXPrintFiscal.Comandos
{

	public class TiqueFacturaFiscal : IComandos
	{

		private const string CODIGO="0B";
		private const string NOMBRE="Tique Factura Fiscal";
		private const string ABRIR = "SGF0B01";
		private const string ITEM = "SGF0B02";
		private const string SUBTOTAL = "SGF0B03";
		private const string DESCUENTO_RECARGOS = "SGF0B04";
		private const string PAGOS = "SGF0B05";
		private const string CERRAR = "SGF0B06";
		private const string CANCELAR = "SGF0B07";
		private const string CONFIGURAR_PREFERENCIA = "SGF0B08";
		private const string OBTENER_CONFIGURACION_PREFERENCIA = "SGF0B09";
		private const string INFORMACION = "SGF0B0A";
		private const string INFORMACION_IMPUESTO = "SGF0B0B";
		private const string INFORMACION_PAGOS = "SGF0B0C";
		private const string INFORMACION_VENTAS = "SGF0B0D";
		private const string INFORMACION_IMPUESTOS_INTERNOS = "SGF0B0E";
		private const string INFORMACION_PERSEPCIONES = "SGF0B0F";
		private const string PERSEPCIONES = "SGF0B20";


		public string Codigo
		{
			get{ return CODIGO; }
		}


		public string Nombre
		{
			get{return NOMBRE;}
		}


		public override string ToString()
		{
			return this.Nombre;
		}



		public static string Abrir
		{
			get{return ABRIR;}
		}


		public static string Item
		{
			get{return ITEM;}
		}


		public static string Subtotal
		{
			get{return SUBTOTAL;}
		}


		public static string DescuentoRango
		{
			get{return DESCUENTO_RECARGOS;}
		}

		public static string Pagos
		{
			get{return PAGOS;}
		}

		public static string Cerrar
		{
			get{return CERRAR;}
		}
		
		public static string Cancelar
		{
			get{return CANCELAR;}
		}

		public static string ConfigurarPreferencia
		{
			get{return CONFIGURAR_PREFERENCIA;}
		}
		
		public static string ObtenerConfiguracionPreferencia
		{
			get{return OBTENER_CONFIGURACION_PREFERENCIA;}
		}
		
		public static string Informacion
		{
			get{return INFORMACION;}
		}

		public static string InformacionImpuesto
		{
			get{return INFORMACION_IMPUESTO;}
		}
		
		public static string InformacionPagos
		{
			get{return INFORMACION_PAGOS;}
		}

		public static string InformacionVentas
		{
			get{return INFORMACION_VENTAS;}
		}

		public static string InformacionImpuestosInternos
		{
			get{return INFORMACION_IMPUESTOS_INTERNOS;}
		}

		public static string InformacionPersepciones
		{
			get{return PERSEPCIONES;}
		}

		public static string Persepciones
		{
			get{return PERSEPCIONES;}
		}

		public TiqueFacturaFiscal()
		{
		}
	}
}
