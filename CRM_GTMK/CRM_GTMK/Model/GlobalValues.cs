using CRM_GTMK.Model.DataModels;
using CRM_GTMK.Model.TestApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_GTMK.Model
{
	public static class GlobalValues
	{

		public static List<RecievedProject> CurrentProjects { get; set; } 
		public static MyProject FocusedProject { get; set; }
		public static string[] DocumentsPaths { get; set; }
		public static Company FocusedCompany { get; set; }
	}
}
