using System;
using LibXPrintFiscal.Modelos;

namespace LibXPrintFiscal.Interfaces
{
	public interface IImpresora
	{
		Impresora GetImpresoraByID(int Id);
		Impresora GetImpresoraByNombre(string Nombre);
		Impresora GetDefaultImpresora(string Caja);
		void IncrementaSecuenciaNoFiscal(string caja, int nuevaSecuencia);
	}
}
