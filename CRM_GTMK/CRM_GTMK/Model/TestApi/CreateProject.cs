using System;

using Newtonsoft.Json;



namespace CRM_GTMK.Model.TestApi
{
	class CreateProject
	{
		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("deadline"), JsonIgnore]
		public DateTime Deadline { get; set; }

		[JsonProperty("sourceLanguage")]
		public string SourceLanguage { get; set; }

		[JsonProperty("targetLanguages")]
		public string[] TargetLanguages { get; set; }

		[JsonProperty("domainId"), JsonIgnore]
		public int DomainId { get; set; }

		[JsonProperty("clientId")]
		public string ClientId { get; set; }

		[JsonProperty("vendorAccountId")]
		public string VendorAccountId { get; set; }

		[JsonProperty("assignToVendor")]
		public bool AssignToVendor { get; set; }

		[JsonProperty("useMT"), JsonIgnore]
		public bool UseMT { get; set; }

		[JsonProperty("pretranslate"), JsonIgnore]
		public bool Pretranslate { get; set; }

		[JsonProperty("translationMemoryName"), JsonIgnore]
		public string TranslationMemoryName { get; set; }

		[JsonProperty("useTranslationMemory"), JsonIgnore]
		public bool UseTranslationMemory { get; set; }

		[JsonProperty("autoPropagateRepetitions"), JsonIgnore]
		public bool AutoPropagateRepetitions { get; set; }

		[JsonProperty("disassembleAlgorithmNames"), JsonIgnore]
		public string[] DisassembleAlgorithmNames { get; set; }

		[JsonProperty("documentProperties"), JsonIgnore]
		public DocumentProperties[] DocumentProperties { get; set; }

		[JsonProperty("workflowStages"), JsonIgnore]
		public WorkflowTask[] WorkflowStages { get; set; }

		[JsonProperty("isForTesting"), JsonIgnore]
		public bool IsForTesting { get; set; }

		[JsonProperty("externalTag"), JsonIgnore]
		public string ExternalTag { get; set; }

		public CreateProject(
			string id = null,
			string name = null,
			string description = null,
			string sourceLanguage = null,
			string[] targetLanguages = null)
		{
			Id = id;
			Name =  name;
			Description = description;
			SourceLanguage =  sourceLanguage;
			TargetLanguages = targetLanguages ?? new[] { Language.Russian.Description() }; 
		}
	}
}
