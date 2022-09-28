using System;

namespace LibXPrintFiscal.Comandos
{
	public interface IComandos
	{
		string Codigo{get;}

		string Nombre{get;}

		string ToString();
	}
}
