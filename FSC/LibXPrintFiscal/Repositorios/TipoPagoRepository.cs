using System;
using LibXPrintFiscal.Interfaces;
using LibXPrintFiscal.Modelos;
using LibXPrintFiscal.Helpers;
using System.Data;
using System.Data.SqlClient;

namespace LibXPrintFiscal.Repositorios
{
	/// <summary>
	/// Clase que implementa <ITipoPago> para manejar el Tipo de Pago por Impresora
	/// </summary>
	public class TipoPagoRepository : ITipoPago
	{

		private IDbHandler dbHandler;
		private TipoPago _tipoPago;


		public TipoPagoRepository() : this(new PrintDbHandler())
		{
		}

		public TipoPagoRepository(IDbHandler dbHandler)
		{
			this.dbHandler = dbHandler;
		}

		
		public string[] GetTipoPagoByImpresora(string impresoraId)
		{
			throw new NotImplementedException();
		}

		public string GetTipoPagoCode(int impresoraId, string tipoPagoId)
		{
			return GetTipoPago(impresoraId, tipoPagoId).CodigoPago;
		}

		public string GetTipoPagoNombre(int impresoraId, string tipoPagoId)
		{
			TipoPago pago = GetTipoPago(impresoraId, tipoPagoId);

			return pago != null ? pago.Nombre : string.Empty;
		}


		public TipoPago GetTipoPago(int impresoraId, string tipoPagoId)
		{
			string _codigoPago= string.Empty;
			string baseClause = "select * from {0} where {1} = {2} and {3} = '{4}'";

			string queryString = string.Format(baseClause,
				TipoPago.NombreTabla,
				TipoPago.Columnas.CodigoImpresora,
				impresoraId,
				TipoPago.Columnas.TipoPagoId,
				tipoPagoId);
			
			DataSet dsInfo =  dbHandler.GetDataFromDb(TipoPago.NombreTabla, queryString);

			if(dsInfo.Tables[0].Rows.Count == 1)
			{
				_tipoPago = ObjectMapper.MapToTipoPago(dsInfo.Tables[0].Rows[0]);
			}
			return _tipoPago;
		}
	}
}
