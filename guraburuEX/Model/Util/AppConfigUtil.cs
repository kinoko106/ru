using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guraburuEX.Model.Util
{
	public class AppConfigUtil
	{
		public static bool IsExsistKey(string inKey)
		{
			string value = string.Empty;
			value = System.Configuration.ConfigurationManager.AppSettings.Get(inKey);
			return (value != null);
		}

		public static string GetAppSettingString(string inKey)
		{
			string value = string.Empty;
			value = System.Configuration.ConfigurationManager.AppSettings.Get(inKey);
			return value;
		}

		public static string GetAppSettingString(string inKey,string inDefaultValue)
		{
			string value = string.Empty;

			if (IsExsistKey(inKey))
			{
				value = System.Configuration.ConfigurationManager.AppSettings.Get(inKey);
			}
			else
			{
				return inDefaultValue;
			}
			return value;
		}

		public static int GetAppSettingInt(string inKey, int inDefaultValue)
		{
			int value = inDefaultValue;
			string stringValue = string.Empty;
			stringValue = System.Configuration.ConfigurationManager.AppSettings.Get(inKey);

			if (int.TryParse(stringValue, out value))
			{
				return value;
			}
			else
			{
				return inDefaultValue;
			}
		}
	}
}
