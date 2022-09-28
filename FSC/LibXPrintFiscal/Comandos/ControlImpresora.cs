using System;

namespace LibXPrintFiscal.Comandos
{
	public class ControlImpresora : IComandos
	{
		/* Developer By Andres Pineda*/

		private const string CODIGO="07";
		private const string NOMBRE="Comandos de Control de Impresora";

		private const string AVANZAR_PAPEL = "SGF0701";
		private const string CORTAR_PAPEL="SGF0702";
		private const string CARGAR_PAPEL="SGF0703";
		private const string EXPULSAR_PAPEL="SGF0704";
		private const string CANCELAR_ESPERA="SGF0705";
		private const string ABRIR_CAJON_DINERO="SGF0707";


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



		public static string AvanzarPapel 
		{
			get{return AVANZAR_PAPEL;}
		}


		public static string CortarPapel 
		{
			get{return CORTAR_PAPEL;}
		}


		public static string CargarPapel 
		{
			get{return CARGAR_PAPEL;}
		}


		public static string ExpulsarPapel 
		{
			get{return EXPULSAR_PAPEL;}
		}


		public static string CancelarEspera 
		{
			get{return CANCELAR_ESPERA;}
		}


		public static string AbrirCajónDinero 
		{
			get{return ABRIR_CAJON_DINERO;}
		}



		public ControlImpresora()
		{
		}
	}
}
