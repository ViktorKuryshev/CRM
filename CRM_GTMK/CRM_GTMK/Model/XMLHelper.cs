using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using CRM_GTMK.Visual;

namespace CRM_GTMK.Model
{
	public class XMLHelper
	{
		private string BASE_FOLDER = "Model\\XMLBase";

		public void AddNewCompanyInfoToBase()
		{
			if (!CompanyIsInBase())
			{
				
				XmlDocument xDoc = new XmlDocument();
				string path = Path.Combine(BASE_FOLDER, "Companies.xml");
				xDoc.Load(path);

				XmlElement xRoot = xDoc.DocumentElement;
				bool compaliesListEmpty = xRoot.ChildNodes.Count < 1;

				//if (xRoot.ChildNodes.Count)
				int id = 1;

				int nodes = xRoot.ChildNodes.Count;
				string[] test = {nodes.ToString(), "RootNodesCount "};
				new ClientsListForm(test).ShowDialog();

			}
		}

		private bool CompanyIsInBase()
		{
			return false;
		}
	}
}
