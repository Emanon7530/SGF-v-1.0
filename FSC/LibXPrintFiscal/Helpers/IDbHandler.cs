using System;
using System.Data;

namespace LibXPrintFiscal.Helpers
{
	public interface IDbHandler
	{
		DataSet GetDataFromDb(string TableName, string QueryString);
		int SetDataToDb(string QueryString);
	}
}
