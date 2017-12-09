using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace CRM_GTMK.Model
{
	public class XmlHelper
	{
		private const string TEST_BASE_DIRECTORY = "..\\..\\Model\\XMLBase";
		private const string BASE_DIRECTORY = "Model\\XMLBase";
		private const string COMPANY_FILE_NAME = "companies.xml";

		public void AddNewCompanyInfo(Company company)
		{

			string path = "";
			XDocument xDoc = new XDocument();
			try
			{
				path = Path.Combine(TEST_BASE_DIRECTORY, COMPANY_FILE_NAME);
				xDoc = XDocument.Load(path);
			}
			catch (DirectoryNotFoundException)
			{
				path = Path.Combine(BASE_DIRECTORY, COMPANY_FILE_NAME);
				xDoc = XDocument.Load(path);
			}

			XAttribute companyNameAtribute = new XAttribute("name", company.Name);
			XElement companyElement = new XElement("company");
			companyElement.Add(companyNameAtribute);

			foreach (Office office in company.Offices)
			{
				XElement officeElement = new XElement("office");
				foreach (string phone in office.Phones)
				{
					XElement phoneElement = new XElement("phone", phone);
					officeElement.Add(phoneElement);
				}

				companyElement.Add(officeElement);

			}
			 

			xDoc.Element("companies").Add(companyElement);

			xDoc.Save(path);
		}
	}
}
