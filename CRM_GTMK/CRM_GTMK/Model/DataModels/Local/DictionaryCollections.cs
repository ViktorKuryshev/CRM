using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_GTMK.Model.DataModels
{
	public class DictionaryCollections
	{
		public static Dictionary<string, string> Languages { get; set; } = new Dictionary<string, string>();
		public static Dictionary<string, string> LanguageCodes { get; set; } = new Dictionary<string, string>();

		static DictionaryCollections()
		{
			Languages.Add("English", "en");
			Languages.Add("Russian", "ru");
			Languages.Add("German", "de");
			Languages.Add("French", "fr");
			Languages.Add("Lithuanian", "lt");


			foreach (KeyValuePair<string, string> pair in Languages)
			{
				LanguageCodes.Add(pair.Value, pair.Key);
			}
		}
	}
}
