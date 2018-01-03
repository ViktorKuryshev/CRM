using Newtonsoft.Json;


namespace CRM_GTMK.Model.TestApi
{
	public class TranslationMemory
	{
		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("sourceLanguage")]
		public string SourceLanguage { get; set; }

		[JsonProperty("targetLanguages")]
		public string[] TargetLanguages { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("clientId")]
		public string ClientId { get; set; }

		public TranslationMemory(
			string id = null,
			string name = null,
			string sourceLanguage = null,
			string[] targetLanguages = null,
			string description = null,
			string clientId = null)
		{
			Id = id;
			Name =  name;
			SourceLanguage = string.IsNullOrEmpty(sourceLanguage) ? Language.English.Description() : sourceLanguage;
			TargetLanguages = targetLanguages ?? new[] { Language.Russian.Description() };
			Description = description;
			ClientId = clientId;
		}
	}
}
