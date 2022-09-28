using System;
using LibXPrintFiscal.Modelos;
using System.Collections;

namespace LibXPrintFiscal.Interfaces
{
	public interface IParametro
	{
		Parametro[] GetParametrosByImpresora(int ImpresoraId);
		Parametro[] GetParametrosBySeccion(int ImpresoraId, string SeccionId);
		string GetComando(int ImpresoraId, string ParametroId);
	}
}
