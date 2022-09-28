using System;

namespace LibXPrintFiscal.Modelos
{
	/// <summary>
	/// Summary description for ErrorRetorno.
	/// </summary>
	public class ErrorRetorno
	{

		private const string TABLE_NAME = "sgfiserror";

		private int _id;
		private string _codigoError;
		private int _codigoImpresora;
		private string _descripcion;

		public static string NombreTabla
		{
			get{return TABLE_NAME;}
		}

		public int Id
		{
			get{return _id;}
			set{_id = value;}
		}

		public string CodigoError
		{
			get{return _codigoError;}
			set{_codigoError = value;}
		}

		public int CodigoImpresora
		{
			get{return _codigoImpresora;}
			set{_codigoImpresora = value;}
		}

		public string Descripcion
		{
			get{return _descripcion;}
			set{_descripcion = value;}
		}

		public ErrorRetorno()
		{
		}


		public class Columnas
		{
			private const string _id = "id";
			private const string _codigoError = "codigo_error";
			private const string _codigoImpresora = "codigo_impresora";
			private const string _descripcion = "descripcion";

			public static string Id{get{return _id;}}
			public static string CodigoError{get{return _codigoError;}}
			public static string CodigoImpresora{get{return _codigoImpresora;}}
			public static string Descripcion{get{return _descripcion;}}
		}
	}
}
