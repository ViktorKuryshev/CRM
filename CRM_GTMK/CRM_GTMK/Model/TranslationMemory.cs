using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_GTMK.Model
{

	public class TranslationMemory
	{
		public string id { get; set; }
		public string accountId { get; set; }
		public string clientId { get; set; }
		public string name { get; set; }
		public string description { get; set; }
		public string sourceLanguage { get; set; }
		public string[] targetLanguages { get; set; }
		public DateTime createdDate { get; set; }
		public bool isAutomaticallyCreated { get; set; }
		public Unitcountbylanguageid unitCountByLanguageId { get; set; }
	}

	public class Unitcountbylanguageid
	{
	}

}
