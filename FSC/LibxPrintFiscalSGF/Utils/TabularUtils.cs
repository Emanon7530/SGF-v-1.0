using System;

namespace LibxPrintFiscalSGF.Utils
{
	/// <summary>
	/// Summary description for TabularUtils.
	/// </summary>
	public class TabularUtils
	{
		public TabularUtils()
		{
		}

		public string TabLine(int columnLength, string data, TabAlign alignment)
		{
			string returnString = string.Empty;

			if(data == null)
			{
				return returnString;
			}

			string dataCleaned = data.Trim();
			int lengthData = dataCleaned.Length;

			if(lengthData > columnLength)
			{
				return dataCleaned.Substring(0, columnLength);
			}

			if(alignment == TabAlign.Center)
			{
				int numberSpace = columnLength - lengthData;
				string leftSpace = new string(' ', numberSpace/2);
				string rigthSpace = new string(' ', numberSpace - leftSpace.Length);

				return leftSpace + dataCleaned + rigthSpace;
			}

			string spaces = new string(' ', columnLength - lengthData);

			returnString = (alignment == TabAlign.Right) ? spaces + dataCleaned : dataCleaned + spaces;

			return returnString;
		}
	}

	public enum TabAlign
	{
		Left,
		Right,
		Center
	}
}
