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

		public int GetBigestCompanyId()
		{
			string path = GetXmlDocumentPath();
			XDocument xDoc = XDocument.Load(path);
			int id = 0;

			foreach (var element in xDoc.Element("companies").Elements("company"))
			{
				if (id < Int32.Parse(element.Attribute("id").Value))
				{
					id = Int32.Parse(element.Attribute("id").Value);
				}
			}
			return id;
		}

		public void AddNewCompanyInfo(Company company)
		{
			string path = GetXmlDocumentPath();
			XDocument xDoc = XDocument.Load(path);

			XAttribute companyNameAtribute = new XAttribute("name", company.Name);
			XAttribute companyIdAttribute = new XAttribute("id", company.id);
			XElement companyElement = new XElement("company");
			companyElement.Add(companyNameAtribute);
			companyElement.Add(companyIdAttribute);

            AddNewOfficeInfo(company, companyElement);

            xDoc.Element("companies").Add(companyElement);

			xDoc.Save(path);
		}

        private void AddNewOfficeInfo(Company company, XElement companyElement)
        {
            foreach (Office office in company.Offices)
            {
                XElement officeElement = new XElement("office");
                officeElement.Add(new XAttribute("id", office.Id));

                officeElement.Add(new XElement("county", office.Country));
                officeElement.Add(new XElement("city", office.City));
                officeElement.Add(new XElement("address", office.Address));
                officeElement.Add(new XElement("site", office.Site));

                foreach (string phone in office.Phones)
                {
                    officeElement.Add(new XElement("phone", phone));
                }
                companyElement.Add(officeElement);
            }
        }

		private string GetXmlDocumentPath()
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
			return  path;
		}
	}
}
