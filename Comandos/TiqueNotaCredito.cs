using System;

namespace LibXPrintFiscal.Comandos
{

	public class TiqueNotaCredito : IComandos
	{

		private const string CODIGO="0D";
		private const string NOMBRE="Tique Factura Fiscal";
		private const string ABRIR = "SGF0D01";
		private const string ITEM = "SGF0D02";
		private const string SUBTOTAL = "SGF0D03";
		private const string DESCUENTO_RECARGOS = "SGF0D04";
		private const string PAGOS = "SGF0D05";
		private const string CERRAR = "SGF0D06";
		private const string CANCELAR = "SGF0D07";
		private const string CONFIGURAR_PREFERENCIA = "SGF0D08";
		private const string OBTENER_CONFIGURACION_PREFERENCIA = "SGF0D09";
		private const string INFORMACION = "SGF0D0A";
		private const string INFORMACION_IMPUESTO = "SGF0D0B";
		private const string INFORMACION_PAGOS = "SGF0D0C";
		private const string INFORMACION_VENTAS = "SGF0D0D";
		private const string INFORMACION_IMPUESTOS_INTERNOS = "SGF0D0E";
		private const string INFORMACION_PERSEPCIONES = "SGF0D0F";
		private const string PERSEPCIONES = "SGF0D20";



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

		public TiqueNotaCredito()
		{
		}
	}
}
