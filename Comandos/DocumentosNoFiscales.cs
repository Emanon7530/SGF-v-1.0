using System;

namespace LibXPrintFiscal.Comandos
{

	public class DocumentosNoFiscales : IComandos
	{

		private const string CODIGO="0E";
		private const string NOMBRE="Tique Factura Fiscal";
		private const string ABRIR = "SGF0E01";
		private const string IMPRIMIR_TEXTO_NO_FISCAL = "SGF0E02";
		private const string CERRAR = "SGF0E06";
		private const string CONFIGURAR_PREFERENCIA = "SGF0E08";
		private const string OBTENER_CONFIGURACION_PREFERENCIA = "SGF0E09";
		private const string INFORMACION = "SGF0E0A";
		private const string DOCUMENTO_NO_FISCAL_UNITARIO = "SGF0E30";
		


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


		public static string ImprimirTextoNoFiscal
		{
			get{return IMPRIMIR_TEXTO_NO_FISCAL;}
		}

		public static string Cerrar
		{
			get{return CERRAR;}
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

		public static string DocumentoNoFiscalUnitario
		{
			get{return DOCUMENTO_NO_FISCAL_UNITARIO;}
		}
		

		public DocumentosNoFiscales()
		{
		}
	}
}
