using System.Collections.Generic;
using System.Xml.Serialization;

namespace CRM_GTMK.Model.DataModels
{
	public class MyProject : IComparable <MyProject>
	{
		//Структура проекта включая папки и удаленные файлы
		public List<FileOrFolder> ProjectStructure { get; set; }

		//Данные проекта
		public string Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public DateTime Deadline { get; set; }
		public DateTime CreationDate { get; set; }
		public string CreatedByUserId { get; set; }
		public DateTime ModificationDate { get; set; }
		public string SourceLanguage { get; set; }
		public string[] TargetLanguages { get; set; }
		public string Status { get; set; }
		public DateTime StatusModificationDate { get; set; }
		public string ClientId { get; set; }
		public Workflowstage[] WorkflowStages { get; set; }
		public Document[] Documents { get; set; }
		public string ExternalTag { get; set; }

		public MyProject(
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

		#region Простые методы

		/// <summary>
		/// Сравниваем два экзеипляра проекта по дате создания
		/// </summary>
		/// <param name="that">Экземпляр проекта переданный для сравнения</param>
		public int CompareTo(MyProject that)
		{
			return this.CreationDate.CompareTo(that.CreationDate) * -1;
		}

		#endregion

		public void SetDataFromRecieveProject(RecievedProject project)
		{
			Id = project.Id;
		}
	}
}
