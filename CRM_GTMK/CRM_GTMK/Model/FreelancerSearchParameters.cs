using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_GTMK.Model
{
	
public class FreelancerSearchParameters
	{
		public int skip { get; set; }
		public int limit { get; set; }
		public string serviceType { get; set; }
		public Languagepair languagePair { get; set; }
		public string searchString { get; set; }
		public string[] specializations { get; set; }
		public Ratelimits rateLimits { get; set; }
		public bool serviceMustBeTested { get; set; }
		public bool daytime { get; set; }
	}

	public class Languagepair
	{
		public string sourceLanguage { get; set; }
		public string targetLanguage { get; set; }
		public bool onlyNativeSpeakers { get; set; }
		public bool allDialects { get; set; }
	}

	public class Ratelimits
	{
		public int minRate { get; set; }
		public int maxRate { get; set; }
		public string rateRangeCurrency { get; set; }
	}
}
