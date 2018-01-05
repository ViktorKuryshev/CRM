using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_GTMK.Model
{
	public class LocalValues
	{

		public List<Project> CurrentProjects { get; set; } 
		public Project focusedProject { get; set; }
		public Company focusedCompany { get; set; }
	}
}
