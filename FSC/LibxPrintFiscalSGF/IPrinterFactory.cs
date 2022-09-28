using System;
using System.Collections;
using LibXPrintFiscal.Modelos;
using LibxPrintFiscalSGF.Modelos;

namespace LibxPrintFiscalSGF
{
	/// <summary>
	/// Summary description for IPrinterFactory.
	/// </summary>
	public interface IPrinterFactory
	{
		Parametro[] GetParametros(string caja);
		Hashtable GetParametroDictionary(string caja);
		Hashtable GetExtensionDictionary(int parametroCodigo);
		string GetComando(string parametro);
		string GetTipoPagoCodigo(string codigoCaja, string tipoPagoId);
		string GetErrorDescripcion(string codigoCaja, string codigoError);
		Impresora GetDefaultImpresora(string codigoCaja);
		string GetTipoPagoNombre(string codigoCaja, string tipoPagoId);
		Fiscalizacion GetFiscalizacionByDocumentId(string documentId);
		void IncrementaSecuenciaNoFiscal(string caja, int nuevaSecuencia);
	}
}
