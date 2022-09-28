using System;
using System.Collections;
using System.Data;
using LibXPrintFiscal.Modelos;
using LibXPrintFiscal.Interfaces;
using LibXPrintFiscal.Helpers;

namespace LibXPrintFiscal.Repositorios
{
	public class ParametroRepository : IParametro
	{
		private Parametro parametro = null;
		private IDbHandler dbHandler;

		public ParametroRepository() : this(new PrintDbHandler())
		{
		}

		public ParametroRepository(IDbHandler dbHandler)
		{
			this.dbHandler = dbHandler;
		}

		public Parametro[] GetParametrosByImpresora(int ImpresoraId)
		{
			Parametro[] parametros = null;
			string baseClause = "select * from {0} where {1} = {2}";

			string queryString = string.Format(baseClause,
				Parametro.NombreTabla,
				Parametro.Columnas.ImpresoraCodigo,
				ImpresoraId);

			DataSet dsInfo =  dbHandler.GetDataFromDb(Parametro.NombreTabla, queryString);

			if(dsInfo.Tables[0].Rows.Count > 0)
			{
				parametros = ObjectMapper.Map2Parametro(dsInfo);
			}
			
			return parametros;

		}

		public Parametro[] GetParametrosBySeccion(int ImpresoraId, string SeccionId)
		{
			Parametro[] parametros = null;
			string baseClause = "select * from {0} where {1} = {2} and {3} = '{4}'";

			string queryString = string.Format(baseClause,
				Parametro.NombreTabla,
				Parametro.Columnas.ImpresoraCodigo,
				ImpresoraId,
				Parametro.Columnas.SeccionCodigo,
				SeccionId);
			
			DataSet dsInfo =  dbHandler.GetDataFromDb(Parametro.NombreTabla, queryString);

			if(dsInfo.Tables[0].Rows.Count > 0)
			{
				parametros = ObjectMapper.Map2Parametro(dsInfo);
			}

			return parametros;
		}

		public string GetComando(int ImpresoraId, string ParametroId)
		{
			string Comando= string.Empty;
			string baseClause = "select * from {0} where {1} = {2} and {3} = '{4}'";

			string queryString = string.Format(baseClause,
				Parametro.NombreTabla,
				Parametro.Columnas.ImpresoraCodigo,
				ImpresoraId,
				Parametro.Columnas.Codigo,
				ParametroId);
			
			DataSet dsInfo =  dbHandler.GetDataFromDb(Parametro.NombreTabla, queryString);

			if(dsInfo.Tables[0].Rows.Count == 1)
			{
				parametro = ObjectMapper.MapToParametro(dsInfo.Tables[0].Rows[0]);

				if (parametro != null)
					Comando = parametro.Comando;
			}

			return Comando;
		}

	}
}
