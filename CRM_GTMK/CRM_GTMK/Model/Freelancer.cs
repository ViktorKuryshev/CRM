using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_GTMK.Model
{


	public class Freelancer
	{
		public string id { get; set; }
		public string firstName { get; set; }
		public string lastName { get; set; }
		public string generalizedSourceLanguage { get; set; }
		public string generalizedTargetLanguage { get; set; }
		public string[] sourceLanguageDialects { get; set; }
		public string[] targetLanguageDialects { get; set; }
		public int pricePerUnit { get; set; }
		public string currency { get; set; }
		public string[] specializations { get; set; }
	}

}
