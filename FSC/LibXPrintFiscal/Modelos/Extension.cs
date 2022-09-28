using System;

namespace LibXPrintFiscal.Modelos
{
	/// <summary>
	/// Summary description for Extension.
	/// </summary>
	public class Extension
	{
		private const string TABLE_NAME = "sgfiscalp";
		
		private string codigo;
		private string parametro_codigo;
		private string nombre;
		private string comando;
		private DateTime fecha_creacion;


		public static string NombreTabla
		{
			get
			{
				return TABLE_NAME;
			}
		}


		public String Codigo
		{
			get
			{
				return codigo;
			}
			set{
				codigo = value;
			}
		}

		public String ParametroCodigo
		{
			get
			{
				return parametro_codigo;
			}
			set
			{
				parametro_codigo = value;
			}
		}

		public String Nombre
		{
			get{
				return nombre;
			}
			set{
				nombre = value;
			}
		}

		public String Comando
		{
			get{
				return comando;
			}
			set{
				comando = value;
			}
		}

		public DateTime FechaCreacion
		{
			get{
				return fecha_creacion;
			}
			set{
				fecha_creacion = value;
			}
		}

		public Extension()
		{
		}

		public class Columnas
		{
			private const string codigo = "codigo";
			private const string parametro_codigo = "parametro_codigo";
			private const string nombre = "nombre";
			private const string comando = "comando";
			private const string fecha_creacion = "fecha_creacion";

			public static string Codigo{get{return codigo;}}
			public static string ParametroCodigo{get{return parametro_codigo;}}
			public static string Nombre{get{return nombre;}}
			public static string Comando{get{return comando;}}
			public static string FechaCreacion{get{return fecha_creacion;}}


		}

	}
}
