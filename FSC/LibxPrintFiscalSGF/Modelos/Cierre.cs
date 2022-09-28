using System;

namespace LibxPrintFiscalSGF.Modelos
{
	/// <summary>
	/// Summary description for Cerrar.
	/// </summary>
	public class Cierre
	{
		private string colaRemplazoNo1;
		private string colaRemplazoDescripcion1;

		private string colaRemplazoNo2;
		private string colaRemplazoDescripcion2;

		private string colaRemplazoNo3;
		private string colaRemplazoDescripcion3;


		public string ColaRemplazoNo1
		{
			get{return (colaRemplazoNo1 != null) ? colaRemplazoNo1 : String.Empty ;}
			set{colaRemplazoNo1 = value;}
		}

		public string ColaRemplazoDescripcion1
		{
			get{return (colaRemplazoDescripcion1 != null) ? colaRemplazoDescripcion1 : String.Empty;}
			set{colaRemplazoDescripcion1 = value;}
		}

		public string ColaRemplazoNo2
		{
			get{return (colaRemplazoNo2 != null) ? colaRemplazoNo2 : String.Empty;}
			set{colaRemplazoNo2 = value;}
		}

		public string ColaRemplazoDescripcion2
		{
			get{return (colaRemplazoDescripcion2 != null) ? colaRemplazoDescripcion2 : String.Empty ;}
			set{colaRemplazoDescripcion2 = value;}
		}


		public string ColaRemplazoNo3
		{
			get{return (colaRemplazoNo3 != null) ? colaRemplazoNo3 : String.Empty;}
			set{colaRemplazoNo3 = value;}
		}

		public string ColaRemplazoDescripcion3
		{
			get{return (colaRemplazoDescripcion3 != null) ? colaRemplazoDescripcion3 : String.Empty;}
			set{colaRemplazoDescripcion3 = value;}
		}


		public Cierre()
		{
		}
	}
}
