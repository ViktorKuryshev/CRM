using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_GTMK.Model.DataModels
{
	public class RecievedProject : IComparable<RecievedProject>
	{
		[JsonProperty("id")]
		public string Id { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		public string description { get; set; }

		[JsonProperty("deadline")]
		public DateTime Deadline { get; set; }
		[JsonProperty("creationDate")]
		public DateTime CreationDate { get; set; }
		public string createdByUserId { get; set; }
		public DateTime modificationDate { get; set; }
		public string sourceLanguage { get; set; }
		public string[] targetLanguages { get; set; }
		public string status { get; set; }
		public DateTime statusModificationDate { get; set; }
		public int domainId { get; set; }
		public string clientId { get; set; }
		public string vendorAccountId { get; set; }

		[JsonProperty("workflowStages"), JsonIgnore]
		public Workflowstage1[] workflowStages { get; set; }
		[JsonProperty("documents")]
		public Document1[] Documents { get; set; }
		public string externalTag { get; set; }

		public int CompareTo(RecievedProject that)
		{
			return this.CreationDate.CompareTo(that.CreationDate) * -1;
		}
	}

	public class Workflowstage1
	{
		public int progress { get; set; }
		public string stageType { get; set; }
	}

	public class Document1
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

		[JsonProperty("workflowStages"), JsonIgnore]
		public Workflowstage2[] workflowStages { get; set; }
		public string externalId { get; set; }
		public string metaInfo { get; set; }
		public bool placeholdersAreEnabled { get; set; }
	}

	public class Workflowstage2
	{
		public int progress { get; set; }
		public int wordsTranslated { get; set; }
		public int unassignedWordsCount { get; set; }
		public string status { get; set; }
		public Executive1[] executives { get; set; }
	}

	public class Executive1
	{
		public int assignedWordsCount { get; set; }
		public int progress { get; set; }
		public string id { get; set; }
		public string type { get; set; }
	}

}




