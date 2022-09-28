using System;

namespace LibxPrintFiscalFactura
{
	/// <summary>
	/// Summary description for Cliente.
	/// </summary>
	public class Cliente
	{
		private string rnc;
		private string razonSocial;
		private string nombre;
		private string direccion;
		private string sector;
		private string seguroMedico;
		private string telefono;

		public string RNC
		{
			get {return rnc;} 
			set {rnc=value;}
		}

		public string RazonSocial
		{
			get{return razonSocial;}
			set{razonSocial = value;}
		}

		public string Nombre
		{
			get {return nombre;}
			set {nombre = value;}
		}

		public string Direccion
		{
			get {return direccion;}
			set {direccion = value;}
		}

		public string Sector
		{
			get {return sector;}
			set {sector = value;}
		}

		public string Telefono
		{
			get {return telefono;}
			set {telefono = value;}
		}

		public string SeguroMedico
		{
			get {return seguroMedico;}
			set {seguroMedico = value;}
		}
		
	}
}
