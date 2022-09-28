using System;
using System.Data;
using LibXPrintFiscal.Modelos;

namespace LibXPrintFiscal.Helpers
{
	public class ObjectMapper
	{
		public ObjectMapper()
		{
		}

		public static Impresora[] Map2Impresora(DataSet dataImpresora)
		{
			int cnt = dataImpresora.Tables[0].Rows.Count;
			Impresora[] impresoras = new Impresora[cnt];

			try
			{
				for(int t=0; t<cnt; t++)
				{
					impresoras[t] = MapToImpresora(dataImpresora.Tables[0].Rows[t]);
				}
			}
			catch(Exception e)
			{
				throw e;
			}

			return impresoras;
		}


		public static Parametro[] Map2Parametro(DataSet dataParametro)
		{
			int cnt = dataParametro.Tables[0].Rows.Count;
			Parametro[] parametros = new Parametro[cnt];

				for(int t=0; t<cnt; t++)
				{
					parametros[t] = MapToParametro(dataParametro.Tables[0].Rows[t]);
				}
			return parametros;
		}


		public static Extension[] Map2Extension(DataSet dataExtension)
		{
			int cnt = dataExtension.Tables[0].Rows.Count;
			Extension[] extensiones = new Extension[cnt];

			try
			{
				for(int t=0; t<cnt; t++)
				{
					extensiones[t] = MapToExtension(dataExtension.Tables[0].Rows[t]);
				}
			}
			catch(Exception e)
			{
				throw e;
			}

			return extensiones;
		}



		public static Impresora MapToImpresora(DataRow dataImpresora)
		{
			Impresora impresora = new Impresora();

			try
			{
				impresora.Codigo = Convert.ToInt32( dataImpresora[Impresora.Columnas.Codigo] );
				impresora.Nombre = Convert.ToString( dataImpresora[Impresora.Columnas.Nombre]);
				impresora.Modelo = Convert.ToString(dataImpresora[Impresora.Columnas.Modelo]);
				impresora.Puerto = Convert.ToString(dataImpresora[Impresora.Columnas.Puerto]);
				impresora.CajaAutorizada =  Convert.ToString( dataImpresora[Impresora.Columnas.CajaAutorizada] );
				impresora.SerialNo = Convert.ToString( dataImpresora[Impresora.Columnas.SerialNo]);
				impresora.EsDefault = Convert.ToBoolean( dataImpresora[Impresora.Columnas.EsDefault] );
				impresora.FechaCreacion = Convert.ToDateTime( dataImpresora[Impresora.Columnas.FechaCreacion] );
				impresora.Velocidad = Convert.ToString( dataImpresora[Impresora.Columnas.Velocidad] );
				impresora.SecuenciaNoFiscal = Convert.ToInt32( dataImpresora[Impresora.Columnas.SecuenciaNoFiscal] );
			}
			catch(Exception e)
			{
				throw e;
			}

			return impresora;
		}

		public static Parametro MapToParametro(DataRow dataParametro)
		{
		
			Parametro parametro = new Parametro();

			try
			{
				parametro.Codigo = (string) dataParametro[Parametro.Columnas.Codigo];
				parametro.Comando =  (string) dataParametro[Parametro.Columnas.Comando];
				parametro.Descripcion =  Convert.ToString( dataParametro[Parametro.Columnas.Descripcion] );
				parametro.FechaCreacion = Convert.ToDateTime( dataParametro[Parametro.Columnas.FechaCreacion] );
				parametro.ImpresoraCodigo = Convert.ToInt32( dataParametro[Parametro.Columnas.ImpresoraCodigo] );
				parametro.Nombre =  (string) dataParametro[Parametro.Columnas.Nombre];
				parametro.SeccionCodigo =  (string) dataParametro[Parametro.Columnas.SeccionCodigo];
				parametro.SeccionNombre = Convert.ToString( dataParametro[Parametro.Columnas.SeccionNombre] );
			}
			catch(Exception e)
			{
				throw e;
			}

			return parametro;
		}


		public static Extension MapToExtension(DataRow dataExtension)
		{
			Extension extension = new Extension();

			try
			{
				extension.Codigo = Convert.ToString(dataExtension[Extension.Columnas.Codigo]);
				extension.Comando = Convert.ToString(dataExtension[Extension.Columnas.Comando]);
				extension.FechaCreacion = (DateTime) dataExtension[Extension.Columnas.FechaCreacion];
				extension.Nombre = Convert.ToString(dataExtension[Extension.Columnas.Nombre]);
				extension.ParametroCodigo = Convert.ToString(dataExtension[Extension.Columnas.ParametroCodigo]);
			
			}
			catch(Exception e)
			{
				throw e;
			}
		
			return extension;
		}

		public static TipoPago MapToTipoPago(DataRow dataExtension)
		{
			TipoPago _tipoPago = new TipoPago();

			try
			{
				_tipoPago.Id = Convert.ToInt32( dataExtension[TipoPago.Columnas.Id] );
				_tipoPago.CodigoImpresora = Convert.ToInt32( dataExtension[TipoPago.Columnas.CodigoImpresora] );
				_tipoPago.CodigoPago = (string) dataExtension[TipoPago.Columnas.CodigoPago];
				_tipoPago.TipoPagoId = (string) dataExtension[TipoPago.Columnas.TipoPagoId];
				_tipoPago.Nombre = (string) dataExtension[TipoPago.Columnas.Nombre];
			}
			catch(Exception e){
				throw e;
			}

			return _tipoPago;
		}

		public static ErrorRetorno MapToErrorRetorno(DataRow dataExtension)
		{
			ErrorRetorno _error = new ErrorRetorno();

			try
			{
				_error.Id = Convert.ToInt32( dataExtension[ErrorRetorno.Columnas.Id] );
				_error.CodigoImpresora = Convert.ToInt32( dataExtension[ErrorRetorno.Columnas.CodigoImpresora] );
				_error.CodigoError = (string) dataExtension[ErrorRetorno.Columnas.CodigoError];
				_error.Descripcion = (string) dataExtension[ErrorRetorno.Columnas.Descripcion];
			}
			catch(Exception e)
			{
				throw e;
			}

			return _error;
		}

	}
}

