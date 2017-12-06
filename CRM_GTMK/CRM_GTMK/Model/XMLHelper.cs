using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CRM_GTMK.Model
{
	public class XMLHelper
	{
		public void AddCompanyData(Company company)
		{
			XmlDocument xDoc = new XmlDocument();
			xDoc.Load("XMLDataBase/users.xml");
		}
	}
}
