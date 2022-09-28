using System;
using System.Text;
using System.Data;
using LibXPrintFiscal.Modelos;
using LibXPrintFiscal.Interfaces;
using LibXPrintFiscal.Helpers;

namespace LibXPrintFiscal.Repositorios
{
	public class ImpresoraRepository : IImpresora
	{
		private Impresora impresora = null;
		private IDbHandler dbHandler;

		public ImpresoraRepository() : this(new PrintDbHandler())
		{
		}

		public ImpresoraRepository(IDbHandler dbHandler)
		{
			this.dbHandler = dbHandler;
		}

		/// <summary>
		/// Busca la impresora con el ID de esta
		/// </summary>
		/// <param name="Id"></param>
		/// <returns></returns>
		public Impresora GetImpresoraByID(int Id)
		{
			string baseClause = "select * from {0} where {1} = {2}";

			string queryString = string.Format(baseClause,
												Impresora.NombreTabla,
												Impresora.Columnas.Codigo,
												Id.ToString());


			DataSet dsInfo = dbHandler.GetDataFromDb(Impresora.NombreTabla, queryString);
			
			if(dsInfo.Tables[0].Rows.Count == 1)
			{
				impresora = ObjectMapper.MapToImpresora(dsInfo.Tables[0].Rows[0]);
			}
			else if(dsInfo.Tables[0].Rows.Count > 1)
			{
				throw new Exception("Error: No puede haber mas de 1 una impresora con el mismo ID:" + Id.ToString());
			}

			return impresora;

		}

		/// <summary>
		/// Busca la impresora por su nombre. 
		/// </summary>
		/// <param name="Nombre"></param>
		/// <returns></returns>
		public Impresora GetImpresoraByNombre(string Nombre)
		{
			string baseClause = "select * from {0} where {1} = '{2}'";

			string queryString = string.Format(baseClause,
				Impresora.NombreTabla,
				Impresora.Columnas.Nombre,
				Nombre.Trim());

			DataSet dsInfo = dbHandler.GetDataFromDb(Impresora.NombreTabla, queryString);

			if(dsInfo.Tables[0].Rows.Count == 1)
			{
				impresora = ObjectMapper.MapToImpresora(dsInfo.Tables[0].Rows[0]);
			}
			else if(dsInfo.Tables[0].Rows.Count > 1)
			{
				throw new Exception("Error: No puede haber mas de 1 una impresora con el mismo Nombre:" + Nombre);
			}

			return impresora;
			
		}
		
		/// <summary>
		/// Busca la Impreso por default para una caja en especifico
		/// </summary>
		/// <param name="Caja"></param>
		/// <returns>Impresora</returns>
		public Impresora GetDefaultImpresora(string Caja)
		{

			// 1 Significa True y 0 False para el Cambo bit [es_default]
			string baseClause = "select * from {0} where {1} = 1 and {2} = '{3}'";
			string queryString = string.Format( baseClause, 
												Impresora.NombreTabla, 
												Impresora.Columnas.EsDefault, 
												Impresora.Columnas.CajaAutorizada, 
												Caja);


			DataSet dsInfo =  dbHandler.GetDataFromDb(Impresora.NombreTabla, queryString);

			if(dsInfo.Tables[0].Rows.Count == 1)
			{
				impresora = ObjectMapper.MapToImpresora(dsInfo.Tables[0].Rows[0]);
			}
			else if(dsInfo.Tables[0].Rows.Count > 1)
			{
				throw new Exception("Error: No puede haber mas de 1 una impresora default para la misma caja: " + Caja);
			}

			return impresora;
		}

		public void IncrementaSecuenciaNoFiscal(string caja, int nuevaSecuencia)
		{
			try
			{
				string baseClause = "UPDATE {0} SET {1} = {2} WHERE {3} = '{4}'";
				string queryString = string.Format(baseClause,
					Impresora.NombreTabla,
					Impresora.Columnas.SecuenciaNoFiscal,
					nuevaSecuencia, 
					Impresora.Columnas.CajaAutorizada, 
					caja);

				int rows = dbHandler.SetDataToDb(queryString);
			}
			catch(Exception e)
			{
			}
		}

	}
}
