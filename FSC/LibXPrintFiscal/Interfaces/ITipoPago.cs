using System;
using LibXPrintFiscal.Modelos;

namespace LibXPrintFiscal.Interfaces
{
	/// <summary>
	/// Interface encargada de manejar el Tipo de Pago por Impresora
	/// </summary>
	public interface ITipoPago
	{
		string[] GetTipoPagoByImpresora(string impresoraId);
		string GetTipoPagoCode(int impresoraId, string tipoPagoId);
		TipoPago GetTipoPago(int impresoraId, string tipoPagoId);
		string GetTipoPagoNombre(int impresoraId, string tipoPagoId);
	}
}
