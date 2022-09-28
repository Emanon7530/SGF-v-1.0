using System;

namespace LibXPrintFiscal.Comandos
{

	public class Sistema : IComandos
	{

		private const string CODIGO="00";
		private const string NOMBRE="Comandos de Sistema";
		private const string OBTENER_ESTADO = "SGF0001";
		private const string OBTENER_ERROR_INICIO = "SGF0003";
		private const string OBTENER_ERROR_PROCESO_INTERNO = "SGF0004";
		private const string CONFIGURAR_VELOCIDAD_COMUNICACION  = "SGF000A";


		public string Codigo{
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



		public static string ObtenerEstado
		{
			get{return OBTENER_ESTADO;}
		}


		public static string ObtenerErrorInicio
		{
			get{return OBTENER_ERROR_INICIO;}
		}


		public static string ObtenerErrorProcesoInterno
		{
			get{return OBTENER_ERROR_PROCESO_INTERNO;}
		}


		public static string ConfigurarVelocidadComunicacion
		{
			get{return CONFIGURAR_VELOCIDAD_COMUNICACION;}
		}



		public Sistema()
		{
		}
	}
}
