using System;

using Newtonsoft.Json;



namespace CRM_GTMK.Model.DataModels
{
	public class Project
	{
		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("deadline"), JsonIgnore]
		public DateTime Deadline { get; set; }

		[JsonProperty("creationDate"), JsonIgnore]
		public DateTime CreationDate { get; set; }

		[JsonProperty("createdByUserId"), JsonIgnore]
		public string CreatedByUserId { get; set; }

		[JsonProperty("modificationDate"), JsonIgnore]
		public DateTime ModificationDate { get; set; }

		[JsonProperty("sourceLanguage")]
		public string SourceLanguage { get; set; }

		[JsonProperty("targetLanguages")]
		public string[] TargetLanguages { get; set; }

		[JsonProperty("status"), JsonIgnore]
		public string Status { get; set; }

		[JsonProperty("statusModificationDate"), JsonIgnore]
		public DateTime StatusModificationDate { get; set; }

		[JsonProperty("domainId"), JsonIgnore]
		public int DomainId { get; set; }

		[JsonProperty("clientId")]
		public string ClientId { get; set; }

		[JsonProperty("vendorAccountId")]
		public string VendorAccountId { get; set; }

		[JsonProperty("assignToVendor")]
		public bool AssignToVendor { get; set; }

		[JsonProperty("workflowStages"), JsonIgnore]
		public Workflowstage[] WorkflowStages { get; set; }

		[JsonProperty("documents"), JsonIgnore]
		public Document[] Documents { get; set; }

		[JsonProperty("externalTag"), JsonIgnore]
		public string ExternalTag { get; set; }

		public Project(
			string id = null,
			string name = null,
			string description = null,
			string sourceLanguage = null,
			string[] targetLanguages = null)
		{
			Id = id;
			Name = name;
			Description = description;
			SourceLanguage = sourceLanguage ?? DictionaryCollections.Languages["English"];
			TargetLanguages = targetLanguages ?? new[] { DictionaryCollections.Languages["Russian"] };
		}
	}
}


