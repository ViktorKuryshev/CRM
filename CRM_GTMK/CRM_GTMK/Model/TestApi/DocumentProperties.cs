using Newtonsoft.Json;

namespace CRM_GTMK.Model.TestApi
{
	public class DocumentProperties
	{
		[JsonProperty("externalId")]
		public string ExternalId { get; set; }

		[JsonProperty("metaInfo")]
		public string MetaInfo { get; set; }

		[JsonProperty("disassembleAlgorithmName")]
		public string DisassembleAlgorithmName { get; set; }

		[JsonProperty("bilingualFileImportSetings")]
		public BilingualFileImportSetings BilingualFileImportSetings { get; set; }

		[JsonProperty("targetLanguages")]
		public string[] TargetLanguages { get; set; }

		[JsonProperty("enablePlaceholders")]
		public bool EnablePlaceholders { get; set; }

		public DocumentProperties()
		{
		}
	}
}
