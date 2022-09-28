using System;

namespace LibXPrintFiscal.Comandos
{

	public class DocumentosNoFiscalesHomologados : IComandos
	{

		private const string CODIGO="0F";
		private const string NOMBRE="Tique Factura Fiscal";
		private const string DOCUMENTOS_TARJETA_CREDITO_DEBITO_CUPON = "SGF0F01";
		private const string DOCUMENTO_FARMACIA = "SGF0F02";
		private const string TALON_ESTACIONAMIENTO = "SGF0F03";
		private const string TALON_REPARTO_DOMICILIO = "SGF0F04";
		


		public string Codigo
		{
			get{ return CODIGO; }
		}


		public string Nombre
		{
			get{return NOMBRE;}
		}


		public override string ToString()
		{
			return this.Nombre;
		}



		public static string DocumentoTarjetaCreditoDebitoCupon
		{
			get{return DOCUMENTOS_TARJETA_CREDITO_DEBITO_CUPON;}
		}


		public static string DocumentoFarmacia
		{
			get{return DOCUMENTO_FARMACIA;}
		}

		public static string TalonEstacionamiento
		{
			get{return TALON_ESTACIONAMIENTO;}
		}
		
	
		public static string TalonRepartoDomicilio
		{
			get{return TALON_REPARTO_DOMICILIO;}
		}
		
		

		public DocumentosNoFiscalesHomologados()
		{
		}
	}
}
