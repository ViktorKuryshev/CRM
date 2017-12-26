using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_GTMK.Model
{


	public class Project : IComparable<Project>
	{
		public string id { get; set; }
		public string name { get; set; }
		public string description { get; set; }
		public DateTime deadline { get; set; }
		public DateTime creationDate { get; set; }
		public string createdByUserId { get; set; }
		public DateTime modificationDate { get; set; }
		public string sourceLanguage { get; set; }
		public string[] targetLanguages { get; set; }
		public string status { get; set; }
		public DateTime statusModificationDate { get; set; }
		public string clientId { get; set; }
		public Workflowstage[] workflowStages { get; set; }
		public Document[] documents { get; set; }

		public int CompareTo(Project that)
		{
			return this.creationDate.CompareTo(that.creationDate)*-1;
		}
	}

	public class Workflowstage
	{
		public float progress { get; set; }
		public string stageType { get; set; }
	}

	public class Document
	{
		public string id { get; set; }
		public string name { get; set; }
		public DateTime creationDate { get; set; }
		public DateTime deadline { get; set; }
		public string sourceLanguage { get; set; }
		public string documentDisassemblingStatus { get; set; }
		public string targetLanguage { get; set; }
		public string status { get; set; }
		public int wordsCount { get; set; }
		public DateTime statusModificationDate { get; set; }
		public bool pretranslateCompleted { get; set; }
		public Workflowstage1[] workflowStages { get; set; }
		public string externalId { get; set; }
		public bool placeholdersAreEnabled { get; set; }
	}

	public class Workflowstage1
	{
		public float progress { get; set; }
		public int wordsTranslated { get; set; }
		public int unassignedWordsCount { get; set; }
		public string status { get; set; }
		public Executive[] executives { get; set; }
	}

	public class Executive
	{
		public int assignedWordsCount { get; set; }
		public float progress { get; set; }
		public string id { get; set; }
		public string type { get; set; }
	}

}
