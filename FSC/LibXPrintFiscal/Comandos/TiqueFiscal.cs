using System;

namespace LibXPrintFiscal.Comandos
{

	public class TiqueFiscal : IComandos
	{
		/* Developer Bartolo*/

		private const string CODIGO="0A";
		private const string NOMBRE="Tique Fiscal";

		private const string ABRIR = "SGF0A01";
		private const string ITEM = "SGF0A02";
		private const string SUBTOTAL = "SGF0A03";
		private const string DESCUENTO_RECARGOS = "SGF0A04";
		private const string PAGOS = "SGF0A05";
		private const string COMENTARIOS = "SGF0A12";
		private const string CERRAR = "SGF0A06";
		private const string CANCELAR = "SGF0A07";
		private const string CONFIGURAR_PREFERENCIA = "SGF0A08";
		private const string OBTENER_CONFIGURACION_PREFERENCIA = "SGF0A09";
		private const string INFORMACION = "SGF0A0A";
		private const string INFORMACION_IMPUESTO = "SGF0A0B";
		private const string INFORMACION_PAGOS = "SGF0A0C";
		private const string INFORMACION_VENTAS = "SGF0A0D";
		private const string INFORMACION_IMPUESTOS_INTERNOS = "SGF0A0E";
		private const string TIQUE_UNITARIO = "SGF0A30";

		
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


		public static string Comentarios
		{
			get{return COMENTARIOS;}
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

		public static string TiqueUnitario
		{
			get{return TIQUE_UNITARIO;}
		}

		
		public TiqueFiscal()
		{
		}
	}
}
