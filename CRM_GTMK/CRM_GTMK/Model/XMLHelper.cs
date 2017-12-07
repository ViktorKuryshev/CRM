using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using CRM_GTMK.Visual;

namespace CRM_GTMK.Model
{
	public class XMLHelper
	{
		private string BASE_FOLDER ="Model\\XMLBase";// "..\\..\\Model\\XMLBase";

		public void AddNewCompanyInfoToBase(Company company)
		{
			if (!CompanyIsInBase())
			{



				string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, BASE_FOLDER, "Companies.xml");//Path.Combine(BASE_FOLDER, "Companies.xml");
				XDocument xDoc = XDocument.Load(path);
				company.companyId = xDoc.Element("companies").Elements("company").Count() + 1;
				XElement companyElement = new XElement("company");
				XAttribute companyId = new XAttribute("id", company.companyId.ToString());
				companyElement.Add(companyId);

				xDoc.Element("companies").Add(companyElement);
				int nodes = xDoc.Element("companies").Elements("company").Count();
				string[] test = { nodes.ToString(), "company elements count " };
				new ClientsListForm(test).ShowDialog();
				xDoc.Save(path);
				/*
				bool compaliesListEmpty = xRoot.ChildNodes.Count < 1;
				company.companyId = xRoot.ChildNodes.Count + 1;
				if (compaliesListEmpty)
				{
					
				}

				XmlElement companyElement = xDoc.CreateElement("company");
				xRoot.AppendChild(companyElement);
				xDoc.Save(path);
				int id = 1;
				
				int nodes = xRoot.ChildNodes.Count;
				string[] test = {nodes.ToString(), "RootNodesCount "};
				new ClientsListForm(test).ShowDialog();
				*/

			}
		}

		private bool CompanyIsInBase()
		{
			return false;
		}
	}
}
