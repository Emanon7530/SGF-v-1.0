using System;
using System.Globalization;

namespace LibxPrintFiscalSGF.Utils
{
	/// <summary>
	/// Summary description for FormatUtils.
	/// </summary>
	public class FormatUtils
	{
		public FormatUtils()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		/// <summary>
		/// Quatity fields have 3 zeros.
		/// Ej: 1 ==> 1000
		/// </summary>
		/// <param name="quantity">Number formated</param>
		/// <returns></returns>
		public string FormatQuantity(string quantity)
		{
			int i;

			try 
			{ 
				i = int.Parse(quantity);
				i = (int)( i / 1000);
			}
			catch { i = 0;}

			return i.ToString("N");
		}

		public string FormatAmount(string amount)
		{
			decimal d;

			try
			{ 
				d = Decimal.Parse(amount);
				d /= 100;
			}
			catch { d = 0;}

			return d.ToString("N");
		}

		public string FormatDate(string date)
		{
			DateTime d;
			CultureInfo provider = CultureInfo.InvariantCulture;

			try
			{
				d = DateTime.Parse(date, provider);
			}
			catch{ d = DateTime.Today;}

			return d.ToString("dd/MM/yyyy");
		}

	}
}
