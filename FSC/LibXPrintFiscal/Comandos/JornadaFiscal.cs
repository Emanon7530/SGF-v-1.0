using System;

namespace LibXPrintFiscal.Comandos
{

	public class JornadaFiscal : IComandos
	{
		/* Developer Bartolo*/

		private const string CODIGO="08";
		private const string NOMBRE="Jornada Fiscal";

		private const string REPORTE_Z = "SGF0801";
		private const string REPORTE_X = "SGF0802";
		private const string INFORME_JORNADA = "SGF0803";
		private const string INFORMACION_ELECTRONICA_GRAL_JORNADA_CURSO  = "SGF080A";
		private const string INFORMACION_ELECTRONICA_IMPUESTO_JF_CURSO  = "SGF080B";
		private const string INFORMACION_ELECTRONICA_PERCEPCIONES_JF_CURSO  = "SGF080C";
		private const string INFORMACION_ELECTRICA_IMPUESTO_NC_JF_CURSO = "SGF080D";
		private const string INFORMACION_ELECTRICA_PERCEPCIONES_NC_JF_CURSO = "SGF080E";
		private const string AUDITORIA_RESUMIDA_JF_RANGO_FECHA = "SGF0810";
		private const string AUDITORIA_RESUMIDA_JF_RANGO_CIERRE_Z = "SGF0811";
		private const string COMENZAR_AUDITORIA_DETALLADA_JF_RANGO_FECHA = "SGF0812";
		private const string COMENZAR_AUDITORIA_DETALLADA_JF_RANGO_CIERRE_Z = "SGF0813";
		private const string CONTINUAR_AUDITORIA_DETALLADA_JF = "SGF0814";
		private const string FINALIZAR_AUDITORIA_DETALLADA_JF = "SGF0815";
		private const string CANCELAR_AUDITORIA_DETALLADA_JF = "SGF0816";
		private const string AUDITORIA_RESUMIDA_JF_RANGO_FECHA_RC = "SGF0820";
		private const string AUDITORIA_RESUMIDA_JF_RANGO_CIERRE_Z_RC = "SGF0821";
		private const string COMENZAR_AUDITORIA_DETALLADA_JF_RANGO_FECHA_RC = "SGF0822";
		private const string COMENZAR_AUDITORIA_DETALLADA_JF_RANGO_CIERRE_Z_RC = "SGF0823";
		private const string CONTINUAR_AUDITORIA_DETALLADA_JF_CONTADOR = "SGF0824";
		private const string FINALIZAR_AUDITORIA_DETALLADA_JF_CONTADOR = "SGF0825";
		private const string CANCELAR_AUDITORIA_DETALLADA_JF_CONTADOR = "SGF0826";
		
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



		public static string ReporteZ
		{
			get{return REPORTE_Z;}
		}


		public static string ReporteX
		{
			get{return REPORTE_X;}
		}



		public static string InformeJornada
		{
			get{return INFORME_JORNADA;}
		}


		public static string InformacionElectronicaGralJornadaCurso
		{
			get{return INFORMACION_ELECTRONICA_GRAL_JORNADA_CURSO;}
		}

		public static string InformacionElectronicaIimpuestoJFCurso
		{
			get{return INFORMACION_ELECTRONICA_IMPUESTO_JF_CURSO;}
		}

		public static string InformacionElectronicaPercepcionesJFCurso
		{
			get{return INFORMACION_ELECTRONICA_PERCEPCIONES_JF_CURSO;}
		}
		
		public static string InformacionElectronicaImpuestoNCJFCurso
		{
			get{return INFORMACION_ELECTRICA_IMPUESTO_NC_JF_CURSO;}
		}

		public static string InformacionElectronicaPercepcionesNCJFCurso
		{
			get{return INFORMACION_ELECTRICA_PERCEPCIONES_NC_JF_CURSO;}
		}
		
		public static string AuditoriaResumidaJFRangoFecha
		{
			get{return AUDITORIA_RESUMIDA_JF_RANGO_FECHA;}
		}
		
		public static string AuditoriaResumidaJFRangoCierreZ
		{
			get{return AUDITORIA_RESUMIDA_JF_RANGO_CIERRE_Z;}
		}

		public static string ComenzarAuditoriaDetalladaJFRangoFecha
		{
			get{return COMENZAR_AUDITORIA_DETALLADA_JF_RANGO_FECHA;}
		}
		
		public static string ComenzarAuditoriaDetalladaJFRangoCierreZ
		{
			get{return COMENZAR_AUDITORIA_DETALLADA_JF_RANGO_CIERRE_Z;}
		}

		public static string ContinuarAuditoriaDetalladaJF
		{
			get{return CONTINUAR_AUDITORIA_DETALLADA_JF;}
		}

		public static string FinalizarAuditoriaDetalladaJF
		{
			get{return FINALIZAR_AUDITORIA_DETALLADA_JF;}
		}

		public static string CancelarAuditoriaDetalladaJF
		{
			get{return CANCELAR_AUDITORIA_DETALLADA_JF;}
		}

		public static string AuditoriaResumidaJFRangoFechaRC
		{
			get{return AUDITORIA_RESUMIDA_JF_RANGO_FECHA_RC;}
		}

		public static string AuditoriaResumidaJFRangoCierreZRC
		{
			get{return AUDITORIA_RESUMIDA_JF_RANGO_CIERRE_Z_RC;}
		}
		
		public static string ComenzarAuditoriaDetalladaJFRangoFechaRC
		{
			get{return COMENZAR_AUDITORIA_DETALLADA_JF_RANGO_FECHA_RC;}
		}
		
		public static string ComenzarAuditoriaDetalladaJFRangoCierreZRC
		{
			get{return COMENZAR_AUDITORIA_DETALLADA_JF_RANGO_CIERRE_Z_RC;}
		}
		
		public static string ContinuarAuditoriaDetalladaJFContador
		{
			get{return CONTINUAR_AUDITORIA_DETALLADA_JF_CONTADOR;}
		}
		
		public static string FinalizarAuditoriaDetalladaJFContador
		{
			get{return FINALIZAR_AUDITORIA_DETALLADA_JF_CONTADOR;}
		}

		public static string CancelarAuditoriaDetalladaJFContador
		{
			get{return CANCELAR_AUDITORIA_DETALLADA_JF_CONTADOR;}
		}

		
		public JornadaFiscal()
		{
		}
	}
}
