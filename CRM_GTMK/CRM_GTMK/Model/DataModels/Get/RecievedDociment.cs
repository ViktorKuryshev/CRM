using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_GTMK.Model.DataModels
{
	public class RecievedDociment
	{
		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		public DateTime creationDate { get; set; }
		public DateTime deadline { get; set; }
		public string sourceLanguage { get; set; }
		public string documentDisassemblingStatus { get; set; }
		public string targetLanguage { get; set; }
		public string status { get; set; }
		public int wordsCount { get; set; }
		public DateTime statusModificationDate { get; set; }
		public bool pretranslateCompleted { get; set; }
		public DocumentWorkflowstage[] workflowStages { get; set; }
		public string externalId { get; set; }
		public string metaInfo { get; set; }
		public bool placeholdersAreEnabled { get; set; }
	}

	public class DocumentWorkflowstage
	{
		public int progress { get; set; }
		public int wordsTranslated { get; set; }
		public int unassignedWordsCount { get; set; }
		public string status { get; set; }
		public DocumentExecutive[] executives { get; set; }
	}

	public class DocumentExecutive
	{
		public int assignedWordsCount { get; set; }
		public int progress { get; set; }
		public string id { get; set; }
		public string type { get; set; }
	}
}
