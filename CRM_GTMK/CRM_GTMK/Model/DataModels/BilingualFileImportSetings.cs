using Newtonsoft.Json;

namespace CRM_GTMK.Model.DataModels
{
	public class BilingualFileImportSetings
	{
		[JsonProperty("targetSubstitutionMode")]
		public string TargetSubstitutionMode { get; set; }

		[JsonProperty("lockMode")]
		public string LockMode { get; set; }

		[JsonProperty("confirmMode")]
		public string ConfirmMode { get; set; }

		public BilingualFileImportSetings(string targetSubstitutionMode = null, string lockMode = null, string confirmMode = null)
		{
			TargetSubstitutionMode = string.IsNullOrEmpty(targetSubstitutionMode) ? "all" : targetSubstitutionMode;
			TargetSubstitutionMode = string.IsNullOrEmpty(lockMode) ? "all" : lockMode;
			TargetSubstitutionMode = string.IsNullOrEmpty(confirmMode) ? "all" : confirmMode;
		}
	}
}
