using System;
using LibxPrintFiscalSGF.Modelos;
using LibxPrintFiscalFactura;

namespace LibxPrintFiscalSGF
{
	/// <summary>
	/// Summary description for IPrintFiscal.
	/// </summary>
	public interface IPrintFiscal
	{
		ImpresoraFisica CreditoFiscal(Factura factura);
		bool ConsumidorFinal(Factura factura);
		ImpresoraFisica CierreX();
		ImpresoraFisica CierreZ();
		ImpresoraFisica InformeJornada();
		bool Connect(Puerto puerto, Velocidad velocidad, string cajaNombre);
		bool Connect(string cajaNombre);
		void Disconnect();
		string ParametroFormateado(string parametro);
		ImpresoraFisica DocumentoNoFiscal(String [] documento);
		ImpresoraFisica ValidaPrinterStatus();
		bool isDayMissingCierreZ();
		ImpresoraFisica CancelarImpresionFiscal();

		ImpresoraFisica ImprimeCierreZPorFecha(DateTime fechaInicial, DateTime fechaFinal, int reportes);
		ImpresoraFisica ImprimeCierreZPorRango(int rangoInicial, int rangoFinal);
		ImpresoraFisica ReimprimirFactura(Factura factura);
		void IncrementaSecuenciaNoFiscal(string caja, int nuevaSecuencia);
		ImpresoraFisica PrintNoFiscalEgresos(Sucursal sucursal, string[] data);
	}
}
