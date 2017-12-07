using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_GTMK.Model
{
	public class MyModel
	{
		public Company NewCompany { get; set; } = new Company();
		public XMLHelper XmlHelper { get; set; } = new XMLHelper();
		
	}
}
