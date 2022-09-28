using System;

namespace LibxPrintFiscalFactura.DocumentosNoFiscal
{
	/// <summary>
	/// Summary description for Egresos.
	/// </summary>
	public class Egresos
	{

		private string  _caja;
		private string  _cajera;
		private string  _numero;
		private string  _fecha;
		private string  _beneficiario;
		private string  _monto;
		private string  _concepto;
		private string  _direccion;
		//private string  _bottom;
		private string  _telefono;
		private string  _rnc;


		public string Caja
		{
			get {return _caja;}
			set {_caja = value;}
		}

		public string Cajera
		{
			get{return _cajera;}
			set {_cajera = value;}
		}

		public string Numero
		{
			get{return _numero;}
			set {_numero = value;}
		}

		public string Fecha
		{
			get{return _fecha;}
			set {_fecha = value;}
		}

		public string Beneficiario
		{
			get {return _beneficiario;}
			set {_beneficiario = value;}
		}

		public string Monto
		{
			get {return _monto;}
			set {_monto = value;}
		}

		public string Concepto
		{
			get {return _concepto;}
			set {_concepto = value;}
		}

		public string Direccion
		{
			get {return _direccion;}
			set {_direccion = value;}
		}

		public string Telefono
		{
			get {return _telefono;}
			set {_telefono = value;}
		}

		public string Rnc
		{
			get {return _rnc;}
			set {_rnc = value;}
		}


		public Egresos()
		{
			//
			// TODO: Add constructor logic here
			//
		}
	}
}
