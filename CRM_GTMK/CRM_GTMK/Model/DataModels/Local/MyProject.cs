using System.Collections.Generic;
using System.Xml.Serialization;

namespace CRM_GTMK.Model.DataModels
{
    public class MyProject
	{
        public List<FileOrFolder> ProjectStructure { get; set; } = new List<FileOrFolder>();
        public RecievedProject SiteProject { get; set; } = new RecievedProject();

		public MyProject()
		{
			
		}
	}
}
