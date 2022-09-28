using System;
using System.Data;
using LibXPrintFiscal.Modelos;
using LibXPrintFiscal.Interfaces;
using LibXPrintFiscal.Helpers;

namespace LibXPrintFiscal.Repositorios
{
	public class ExtensionRepository : IExtension
	{
		private Extension extension = null;
		private IDbHandler dbHandler;

		public ExtensionRepository() : this(new PrintDbHandler())
		{
		}

		public ExtensionRepository(IDbHandler dbHandler)
		{
			this.dbHandler = dbHandler;
		}

		public Extension GetExtensionById(string ExtensionId)
		{
			string baseClause = "select * from {0} where {1} = '{2}'";

			string queryString = string.Format(baseClause,
				Extension.NombreTabla,
				Extension.Columnas.Codigo,
				ExtensionId.Trim());

			DataSet dsInfo = dbHandler.GetDataFromDb(Extension.NombreTabla, queryString);

			if(dsInfo.Tables[0].Rows.Count == 1)
			{
				extension = ObjectMapper.MapToExtension(dsInfo.Tables[0].Rows[0]);
			}
			else if (dsInfo.Tables[0].Rows.Count > 1)
			{
				throw new Exception("No pude haber mas de 1 Extension con el mismo codigo");
			}


			return extension;
		}

		public Extension[] GetExtensionesByParametro(string ParametroID)
		{
			Extension[] extensions = null;
			string baseClause = "select * from {0} where {1} = '{2}'";

			string queryString = string.Format(baseClause,
				Extension.NombreTabla,
				Extension.Columnas.ParametroCodigo,
				ParametroID);

			DataSet dsInfo = dbHandler.GetDataFromDb(Extension.NombreTabla, queryString);

			if(dsInfo.Tables[0].Rows.Count > 0)
			{
				extensions = ObjectMapper.Map2Extension(dsInfo);
			}

			return extensions;
		}

	}
}
