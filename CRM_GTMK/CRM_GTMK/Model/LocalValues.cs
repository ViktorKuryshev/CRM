using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_GTMK.Model
{
	public static class LocalValues
	{

		public static List<Project> CurrentProjects { get; set; } 
		public static Project focusedProject { get; set; }
		public static Company focusedCompany { get; set; }
	}
}
