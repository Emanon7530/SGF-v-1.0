using System;
using LibXPrintFiscal.Interfaces;
using LibXPrintFiscal.Helpers;
using LibXPrintFiscal.Modelos;
using System.Data;
using System.Data.SqlClient;


namespace LibXPrintFiscal.Repositorios
{
	/// <summary>
	/// Summary description for ErrorRetornoRepository.
	/// </summary>
	public class ErrorRetornoRepository : IErrorRetorno
	{
		private IDbHandler dbHandler;

		public ErrorRetornoRepository() : this(new PrintDbHandler())
		{
		}

		public ErrorRetornoRepository(IDbHandler dbHandler)
		{
			this.dbHandler = dbHandler;
		}

		public string GetErrorDescriptionByCode(string errorCode, int codigoImpresora)
		{
			ErrorRetorno _error = GetErrorByCode(errorCode, codigoImpresora);

			return _error.Descripcion;
		}
		
		public ErrorRetorno GetErrorByCode(string errorCode, int codigoImpresora)
		{
			ErrorRetorno _error = new ErrorRetorno();
			string baseClause = "select * from {0} where {1} = {2} and {3} = '{4}'";

			string queryString = string.Format(baseClause,
				ErrorRetorno.NombreTabla,
				ErrorRetorno.Columnas.CodigoImpresora,
				codigoImpresora,
				ErrorRetorno.Columnas.CodigoError,
				errorCode);
			
			DataSet dsInfo =  dbHandler.GetDataFromDb(ErrorRetorno.NombreTabla, queryString);

			if(dsInfo.Tables[0].Rows.Count == 1)
			{
				_error = ObjectMapper.MapToErrorRetorno(dsInfo.Tables[0].Rows[0]);
			}

			return _error;
		}

	}
}
