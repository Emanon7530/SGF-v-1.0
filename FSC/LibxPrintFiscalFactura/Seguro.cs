using System;

namespace LibxPrintFiscalFactura
{
	/// <summary>
	/// Summary description for Seguro.
	/// </summary>
	public class Seguro
	{
		private string _poliza;
		private string _ars;
		private string _plan;
		private string _asegurado;


		public string Poliza
		{
			get {return _poliza;}
			set {_poliza = value;}
		}

		public string Ars
		{
			get {return _ars;}
			set {_ars = value;}
		}

		public string Plan
		{
			get {return _plan;}
			set {_plan = value;}
		}

		public string Asegurado
		{
			get {return _asegurado;}
			set {_asegurado = value;}
		}

		public Seguro()
		{
			//
			// TODO: Add constructor logic here
			//
		}
	}
}
