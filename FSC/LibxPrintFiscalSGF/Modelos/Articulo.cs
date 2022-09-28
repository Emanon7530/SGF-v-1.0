using System;

namespace LibxPrintFiscalSGF.Modelos
{
	/// <summary>
	/// Summary description for Articulos.
	/// </summary>
	public class Articulo
	{
		private string cantidad;
		private string precio;
		private string descripcion;
		private string descripcionExtra1;
		private string itbis;
		private string valor;
		private string descuento;
		private string esExcentoItbis;


		public string Descuento
		{
			get{return descuento;}
			set{descuento = value;}
		}

		public string Cantidad
		{
			get{return cantidad;}
			set{cantidad=value;}
		}

		public string Precio
		{
			get{return precio;}
			set{precio=value;}
		}

		public string Descripcion
		{
			get{return descripcion;}
			set{descripcion = value;}
		}

		public string DescripcionExtra1
		{
			get{return descripcionExtra1 != null ? descripcionExtra1 : String.Empty ;}
			set{descripcionExtra1 = value;}
		}

		public string Itbis
		{
			get{return itbis;}
			set{itbis=value;}
		}

		public string Valor
		{
			get{return valor;}
			set{valor=value;}
		}

		public string EsExcentoItbis
		{
			get{return esExcentoItbis;}
			set{esExcentoItbis = value;}
		}

		public Articulo()
		{
		}
	}
}
