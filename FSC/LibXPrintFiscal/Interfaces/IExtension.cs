using System;
using LibXPrintFiscal.Modelos;

namespace LibXPrintFiscal.Interfaces
{
	public interface IExtension
	{
		Extension GetExtensionById(string ExtensionId);
		Extension[] GetExtensionesByParametro(string ParametroID);
	}
}
