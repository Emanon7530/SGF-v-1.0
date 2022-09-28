using System;
using LibXPrintFiscal.Modelos;

namespace LibXPrintFiscal.Interfaces
{
	/// <summary>
	/// Summary description for IErrorRetorno.
	/// </summary>
	public interface IErrorRetorno
	{
		string GetErrorDescriptionByCode(string errorCode, int codigoImpresora);
		ErrorRetorno GetErrorByCode(string errorCode, int codigoImpresora);
	}
}
