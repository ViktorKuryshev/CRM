using Newtonsoft.Json;
using System;

namespace CRM_GTMK.Model.DataModels
{
	public class Document
	{
		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("creationDate"), JsonIgnore]
		public DateTime CreationDate { get; set; }

		[JsonProperty("deadline"), JsonIgnore]
		public DateTime Deadline { get; set; }

		[JsonProperty("sourceLanguage"), JsonIgnore]
		public string SourceLanguage { get; set; }

		[JsonProperty("documentDisassemblingStatus"), JsonIgnore]
		public string DocumentDisassemblingStatus { get; set; }

		[JsonProperty("targetLanguage"), JsonIgnore]
		public string TargetLanguage { get; set; }

		[JsonProperty("status"), JsonIgnore]
		public string Status { get; set; }

		[JsonProperty("wordsCount"), JsonIgnore]
		public int WordsCount { get; set; }

		[JsonProperty("statusModificationDate"), JsonIgnore]
		public DateTime StatusModificationDate { get; set; }

		[JsonProperty("pretranslateCompleted"), JsonIgnore]
		public bool PretranslateCompleted { get; set; }

		[JsonProperty("workflowStages"), JsonIgnore]
		public Workflowstage[] WorkflowStages { get; set; }

		[JsonProperty("externalId"), JsonIgnore]
		public string ExternalId { get; set; }

		[JsonProperty("metaInfo"), JsonIgnore]
		public string MetaInfo { get; set; }

		[JsonProperty("placeholdersAreEnabled"), JsonIgnore]
		public bool PlaceholdersAreEnabled { get; set; }

		public Document()
		{
		}
	}
}

