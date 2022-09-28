using System;

namespace LibXPrintFiscal.Modelos
{

	public class Parametro
	{

		private const string TABLE_NAME = "sgfiscald";

		private int parametroId;
		private string codigo;
		private int impresoraCodigo;
		private string seccionCodigo;
		private string seccionNombre;
		private string comando;
		private string nombre;
		private string descripcion;
		private DateTime fechaCreacion;

		private Extension[] extensiones;

		public static string NombreTabla
		{
			get
			{
				return TABLE_NAME;
			}
		}


		public int ParametroId
		{
			get{return parametroId;}
		}

		public string Codigo
		{
			get{return codigo;}
			set{codigo = value;}
		}

		public int ImpresoraCodigo
		{
			get{return impresoraCodigo;}
			set{impresoraCodigo=value;}
		}

		public string SeccionCodigo
		{
			get{return seccionCodigo;}
			set{seccionCodigo=value;}
		}

		public string SeccionNombre
		{
			get{return seccionNombre;}
			set{seccionNombre=value;}
		}

		public string Comando
		{
			get{return comando;}
			set{comando=value;}
		}

		public string Nombre
		{
			get{return nombre;}
			set{nombre=value;}
		}

		public string Descripcion
		{
			get{return descripcion;}
			set{descripcion=value;}
		}


		public DateTime FechaCreacion
		{
			get{return fechaCreacion;}
			set{fechaCreacion = value;}
		}

		public virtual Extension[] Extensiones
		{
			get{return extensiones;}
			set{extensiones = value;}
		}

		public Parametro()
		{
		}


		public class Columnas
		{
			private const string codigo = "codigo";
			private const string impresoraCodigo = "impresora_codigo";
			private const string seccionCodigo = "seccion_codigo";
			private const string seccionNombre = "seccion_nombre";
			private const string comando = "comando";
			private const string nombre = "nombre";
			private const string descripcion = "descripcion";
			private const string fechaCreacion = "fecha_creacion";
		

			public static string Codigo {get{return codigo;}}

			public static string ImpresoraCodigo {get{return impresoraCodigo;}}

			public static string SeccionCodigo {get{return seccionCodigo;}}

			public static string SeccionNombre {get{return seccionNombre;}}

			public static string Comando {get{return comando;}}

			public static string Nombre {get{return nombre;}}

			public static string Descripcion {get{return descripcion;}}

			public static string FechaCreacion {get{return fechaCreacion;}}

		}
	}
}
