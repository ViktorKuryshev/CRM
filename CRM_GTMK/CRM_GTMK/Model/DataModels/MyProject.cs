using CRM_GTMK.Model.TestApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_GTMK.Model.DataModels
{
	public class MyProject
	{
		public List<FileOrFolder> ProjectStructure { get; set; }
		public Project SiteProject { get; set; }

		public MyProject()
		{
			SiteProject = new Project();
		}
	}
}
