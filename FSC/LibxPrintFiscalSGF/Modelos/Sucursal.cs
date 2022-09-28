using System;

namespace LibxPrintFiscalSGF.Modelos
{
	/// <summary>
	/// Summary description for Sucursal.
	/// </summary>
	public class Sucursal
	{
		private string numeroLogo;
		private string densidad;
		private string codigo;

		private string nombre;
		private string direccion;
		private string telefono;
		private string rnc;
		private string razonSocial;
		private string resolucion;

		public string NumeroLogo
		{
			get {return numeroLogo;}
			set {numeroLogo = value;}
		}

		public string Densidad
		{
			get{return densidad;}
			set{densidad = value;}
		}

		public string Codigo
		{
			get{return codigo;}
			set{codigo = value;}
		}


		public string Nombre
		{
			get {return nombre;}
			set {nombre = value;}
		}

		public string Direccion
		{
			get{return direccion;}
			set{direccion = value;}
		}

		public string Telefono
		{
			get{return telefono;}
			set{telefono = value;}
		}

		public string RNC
		{
			get{return rnc;}
			set{rnc = value;}
		}

		public string RazonSocial
		{
			get{return razonSocial;}
			set{razonSocial = value;}
		}

		public string Resolucion
		{
			get {return resolucion;}
			set{resolucion = value;}
		}

		public Sucursal()
		{
		
		}

		public Sucursal(string numerologo, string densidad, string codigo)
		{
			this.numeroLogo = numerologo;
			this.densidad = densidad;
			this.codigo=codigo;
		}


	}
}
