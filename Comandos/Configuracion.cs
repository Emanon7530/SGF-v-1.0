using System;

namespace LibXPrintFiscal.Comandos
{
	public class Configuracion : IComandos
	{

		private const string CODIGO="05";
		private const string NOMBRE="Comandos de Configuracion";

		private const string CONFIGURAR_FECHA_HORA = "SGF0501";
		private const string OBTENER_CONFIGURACION_FECHA_HORA = "SGF0502";
		private const string CONFIGURAR_DATOS_FISCALIZACION = "SGF0503";
		private const string OBTENER_DATOS_FISCALIZACION = "SGF0507";
		private const string CONFIGURAR_LINEAS_ENCABEZADOS = "SGF0508";
		private const string OBTENER_LINEAS_ENCABEZADOS = "SGF0509";
		private const string CONFIGURAR_LINEAS_COLA = "SGF050A";
		private const string OBTENER_LINEAS_COLA = "SGF050B";
		private const string CONFIGURAR_INFORMACION_ESTABLECIMIENTO = "SGF050E";
		private const string OBTENER_INFORMACION_ESTABLECIMIENTO = "SGF050F";
		private const string INICIAR_CARGA_LOGO_USUARIO = "SGF0530";
		private const string ENVIAR_DATOS_LOGO_USUARIO = "SGF0531";
		private const string TERMINAR_CARGA_LOGO_USUARIO = "SGF0532";
		private const string CANCELAR_CARGA_LOGO_USUARIO = "SGF0533";
		private const string ELIMINAR_LOGO_USUARIO = "SGF0534";
		private const string CONFIGURAR_DATOS_DOMICILIO = "SGF0541";


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



		public static string ConfigurarFechaHora
		{
			get{return CONFIGURAR_FECHA_HORA;}
		}


		public static string ObtenerConfiguracionFechaHora
		{
			get{return OBTENER_CONFIGURACION_FECHA_HORA;}
		}


		public static string ConfigurarDatosFiscalizacion
		{
			get{return CONFIGURAR_DATOS_FISCALIZACION;}
		}


		public static string ObtenerDatosFiscalizacion
		{
			get{return OBTENER_DATOS_FISCALIZACION;}
		}


		public static string ConfigurarLineasEncabezados
		{
			get{return CONFIGURAR_LINEAS_ENCABEZADOS;}
		}


		public static string ObtenerLineasEncabezados
		{
			get{return OBTENER_LINEAS_ENCABEZADOS;}
		}


		public static string ConfigurarLineasCola
		{
			get{return CONFIGURAR_LINEAS_COLA;}
		}


		public static string ObtenerLineasCola
		{
			get{return OBTENER_LINEAS_COLA;}
		}


		public static string ConfigurarInformacionEstablecimiento
		{
			get{return CONFIGURAR_INFORMACION_ESTABLECIMIENTO;}
		}


		public static string ObtenerInformacionEstablecimiento
		{
			get{return OBTENER_INFORMACION_ESTABLECIMIENTO;}
		}


		public static string IniciarCargaLogoUsuario
		{
			get{return INICIAR_CARGA_LOGO_USUARIO;}
		}


		public static string EnviarDatosLogoUsuario
		{
			get{return ENVIAR_DATOS_LOGO_USUARIO;}
		}


		public static string TerminarCargaLogoUsuario
		{
			get{ return TERMINAR_CARGA_LOGO_USUARIO;}
		}


		public static string CancelarCargaLogoUsuario
		{
			get{return CANCELAR_CARGA_LOGO_USUARIO;}
		}


		public static string EliminarLogoUsuario
		{
			get{return ELIMINAR_LOGO_USUARIO;}
		}


		public static string ConfigurarDatosDomicilio
		{
			get{return CONFIGURAR_DATOS_FISCALIZACION;}
		}




		public Configuracion()
		{
		}

	}
}
