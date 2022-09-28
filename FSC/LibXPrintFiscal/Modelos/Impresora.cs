using System;

namespace LibXPrintFiscal.Modelos
{
	/// <summary>
	/// Clase que va a manejar las propiedades de las impresoras fiscales.
	/// </summary>
	public class Impresora
	{
		private const string TABLE_NAME = "sgfiscalm";

		private int codigo;
		private string nombre;
		private string modelo;
		private string puerto;
		private string serial_no;
		private Boolean es_default;
		private string caja_autorizada;
		private DateTime fecha_creacion;
		private string velocidad;
		private int secuencia_nofiscal;

		public static string NombreTabla{
			get
			{
				return TABLE_NAME;
			}
		}

		public int Codigo{
			get{
				return codigo;
			}
			set{
				codigo = value;
			}
		}


		public String Nombre
		{
			get
			{
				return nombre;
			}
			set
			{
				nombre = value;
			}
		}


		public String Modelo
		{
			get
			{
				return modelo;
			}
			set
			{
				modelo = value;
			}
		}


		public String Puerto
		{
			get
			{
				return puerto;
			}
			set
			{
				puerto = value;
			}
		}


		public String SerialNo
		{
			get
			{
				return serial_no;
			}
			set
			{
				serial_no = value;
			}
		}


		public Boolean EsDefault
		{
			get
			{
				return es_default;
			}
			set
			{
				es_default = value;
			}
		}


		public String CajaAutorizada
		{
			get
			{
				return caja_autorizada;
			}
			set
			{
				caja_autorizada = value;
			}
		}


		public DateTime FechaCreacion
		{
			get
			{
				return fecha_creacion;
			}
			set
			{
				fecha_creacion = value;
			}
		}


		public string Velocidad
		{
			get{return velocidad;}
			set{velocidad = value;}
		}

		public int SecuenciaNoFiscal
		{
			get {return secuencia_nofiscal;}
			set {secuencia_nofiscal= value;}
		}

		public Impresora()
		{
			
		}


		public class Columnas{

			private const string codigo = "codigo";
			private const string nombre = "nombre";
			private const string modelo = "modelo";
			private const string puerto = "puerto";
			private const string serial_no = "serial_no";
			private const string es_default = "es_default";
			private const string caja_autorizada = "caja_autorizada";
			private const string fecha_creacion = "fecha_creacion";	
			private const string velocidad = "velocidad";
			private const string secuencia_nofiscal = "secuencia_nofiscal";
		
			public static string Codigo
			{
				get{return codigo;}
			}

			public static string Nombre
			{
				get{return nombre;}
			}

			public static string Modelo{ get{return modelo;}}

			public static string Puerto{ get{return puerto;}}

			public static string SerialNo{ get{return serial_no;}}

			public static string EsDefault{ get{return es_default;}}

			public static string CajaAutorizada{ get{return caja_autorizada;}}

			public static string FechaCreacion{ get{return fecha_creacion;}}

			public static string Velocidad{get {return velocidad;}}

			public static string SecuenciaNoFiscal {get {return secuencia_nofiscal;}}

		}


	}
}
