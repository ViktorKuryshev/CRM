using Newtonsoft.Json;
using System;

namespace CRM_GTMK.Model.DataModels
{
	public class TranslationMemory
	{
		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("accountId"), JsonIgnore]
		public string AccountId { get; set; }

		[JsonProperty("clientId")]
		public string ClientId { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("sourceLanguage")]
		public string SourceLanguage { get; set; }

		[JsonProperty("targetLanguages")]
		public string[] TargetLanguages { get; set; }

		[JsonProperty("createdDate"), JsonIgnore]
		public DateTime CreatedDate { get; set; }

		[JsonProperty("isAutomaticallyCreated"), JsonIgnore]
		public bool IsAutomaticallyCreated { get; set; }

		[JsonProperty("unitCountByLanguageId"), JsonIgnore]
		public Unitcountbylanguageid UnitCountByLanguageId { get; set; }

		public TranslationMemory(
			string id = null,
			string name = null,
			string sourceLanguage = null,
			string[] targetLanguages = null,
			string description = null,
			string clientId = null)
		{
			Id = id;
			Name = name;
			SourceLanguage = string.IsNullOrEmpty(sourceLanguage) ? DictionaryCollections.Languages["English"] : sourceLanguage;
			TargetLanguages = targetLanguages ?? new[] { DictionaryCollections.Languages["Russian"] };
			Description = description;
			ClientId = clientId;
		}
	}
}


public class Unitcountbylanguageid
{
}
