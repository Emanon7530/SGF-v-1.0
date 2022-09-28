using System;
using System.Data;
using System.Data.SqlClient;
using LibXPrintFiscal.Modelos;

namespace LibXPrintFiscal.Helpers
{
	public class PrintDbHandler : IDbHandler
	{
		private DataSet dataSet;
		private SqlConnection dbcon;

		public PrintDbHandler() : this(new SqlConnection())
		{
		}

		public PrintDbHandler(SqlConnection connection)
		{
			this.dbcon = connection;
		}

		public DataSet GetDataFromDb(string TableName, string QueryString)
		{
			dataSet = new DataSet();
			try
			{
				SqlCommand sqlcm = new SqlCommand(QueryString, dbcon);
				sqlcm.CommandType= CommandType.Text;
				SqlDataAdapter da = new SqlDataAdapter(sqlcm);

				da.Fill(dataSet, TableName);
			}
			catch(Exception e)
			{
				throw e;	
			}

			return dataSet;
		}

		public int SetDataToDb(string QueryString)
		{
			int rowsAffected = 0;
			try
			{
				dbcon.Open();
				SqlCommand sqlcm = new SqlCommand(QueryString, dbcon);
				sqlcm.CommandType= CommandType.Text;

				rowsAffected = sqlcm.ExecuteNonQuery();
				return rowsAffected;
			}
			catch(Exception e)
			{
				throw e;	
			}
			finally
			{
				dbcon.Close();
			}
		}
	}
}
