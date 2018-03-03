using CRM_GTMK.Model.DataModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace CRM_GTMK.Model
{
    public class XmlHelper
	{
		private const string TEST_BASE_DIRECTORY = "..\\..\\Model\\XMLBase";
		private const string BASE_DIRECTORY = "Model\\XMLBase";
		private const string COMPANY_FILE_NAME = "companies.xml";
        private const string CURRENTPROJECTS_FILE_NAME = "CurrentProjects.xml";
        private const string FOCUSEDPROJECT_FILE_NAME = "FocusedProject.xml";
        private const string DOCUMENTSPATHS_FILE_NAME = "DocumentsPaths.xml";
        private const string FOCUSEDCOMPANY_FILE_NAME = "FocusedCompany.xml";
        
        // Определяем наибольший Id среди всех компаний для назначения Id + 1 новой компании.
        public int GetBigestCompanyId()
		{
			string path = GetXmlDocumentPath(COMPANY_FILE_NAME);
			XDocument xDoc = XDocument.Load(path);

            int id = 0;

			foreach (var element in xDoc.Element("Companies").Elements("Company"))
			{
				if (id < Int32.Parse(element.Attribute("Id").Value))
				{
					id = Int32.Parse(element.Attribute("Id").Value);
				}
			}
			return id;
		}
        
        // Передаем созданную новую компанию в метод сериализации.
        public void SaveNewCompanyToFile(Company company)
        {
            SerializeObjectInfoInXml(company, GetXmlDocumentPath(COMPANY_FILE_NAME));
        }

        // Передаем объекты из класса GlobalValues в метод сериализации.
        public void SaveGlobalValuesToFile()
        {
            string currentProjectsPath = GetXmlDocumentPath(CURRENTPROJECTS_FILE_NAME);
            IEnumerable<XElement> currentProjectsIdNodes = GetDescendants(currentProjectsPath);
            foreach (RecievedProject project in GlobalValues.CurrentProjects)
            {
                if (currentProjectsIdNodes.Any(id => id.Value == project.Id))
                    continue;
                SerializeObjectInfoInXml(project, currentProjectsPath);
            }

            string focusedProjectPath = GetXmlDocumentPath(FOCUSEDPROJECT_FILE_NAME);
            FlushXmlFile(focusedProjectPath);
            if (GlobalValues.ShouldSerializeFocusedProject())
                SerializeObjectInfoInXml(GlobalValues.FocusedProject, focusedProjectPath);

            string documentsPathsPath = GetXmlDocumentPath(DOCUMENTSPATHS_FILE_NAME);
            FlushXmlFile(documentsPathsPath);
            foreach (string documentPath in GlobalValues.DocumentsPaths)
                SerializeObjectInfoInXml(documentPath, documentsPathsPath);


            string focusedCompanyPath = GetXmlDocumentPath(FOCUSEDCOMPANY_FILE_NAME);
            FlushXmlFile(focusedCompanyPath);
            if (GlobalValues.ShouldSerializeFocusedCompany())
                SerializeObjectInfoInXml(GlobalValues.FocusedCompany, focusedCompanyPath);
        }

        // Получаем коллекцию элементов корневого узла xml файла.
        private IEnumerable<XElement> GetDescendants(string filePath)
        {
            string nodeName = filePath.Contains(CURRENTPROJECTS_FILE_NAME) ? "Id" : null;

            XDocument doc = XDocument.Load(filePath);
            return from el in doc.Root.Descendants(nodeName)
                   select el;
        }

        // Очищаем xml файл перед сериализацией. 
        private void FlushXmlFile(string path)
        {
            XDocument documentsPathsDoc = XDocument.Load(path);
            documentsPathsDoc.Root.RemoveNodes();
            documentsPathsDoc.Save(path);
        }

        // Вызываем метод десериализации DeserializeObjectInfoFromXml для объектов класса GlobalValues.
        public void RestoreGlobalValuesFromFile()
        {
            string currentProjectsPath = GetXmlDocumentPath(CURRENTPROJECTS_FILE_NAME);
            if (CheckIfXmlEmpty(currentProjectsPath))
                GlobalValues.CurrentProjects =
                    DeserializeObjectInfoFromXml<List<RecievedProject>>(currentProjectsPath);
            
            GlobalValues.CurrentProjects.Sort();
            
            string focusedProjectPath = GetXmlDocumentPath(FOCUSEDPROJECT_FILE_NAME);
            if (CheckIfXmlEmpty(focusedProjectPath))
            {
                List<MyProject> myProjectList = 
                    DeserializeObjectInfoFromXml<List<MyProject>>(focusedProjectPath);
                // Число ноль в myProjectList[0] используется для доступа к первому объекту
                // типа MyProject в списке, при чем он будет единственным элементом списка.
                // Список приходится использовать, т. к. метод десериализации DeserializeObjectInfoFromXml
                // работает только со списками. Для companyList[0] тоже самое.
                GlobalValues.FocusedProject = myProjectList[0];
            }

            string documentsPathsPath = GetXmlDocumentPath(DOCUMENTSPATHS_FILE_NAME);
            if (CheckIfXmlEmpty(documentsPathsPath))
                GlobalValues.DocumentsPaths =
                    DeserializeObjectInfoFromXml<string[]>(GetXmlDocumentPath(documentsPathsPath));

            string focusedCompanyPath = GetXmlDocumentPath(FOCUSEDCOMPANY_FILE_NAME);
            if (CheckIfXmlEmpty(focusedCompanyPath))
            {
                List<Company> companyList =
                    DeserializeObjectInfoFromXml<List<Company>>(GetXmlDocumentPath(focusedCompanyPath));
                GlobalValues.FocusedCompany = companyList[0];
            }
        }

        // Проверяем пустой ли xml файл.
        private bool CheckIfXmlEmpty(string filePath)
        {
            XDocument doc = XDocument.Load(filePath);
            return doc.Root.Descendants().Count() != 0 ? true : false;
        }

        // Передаем данные из классов (Company, Office, Person, и т. д.) в xml файл.
        private void SerializeObjectInfoInXml<T>(T obj, string path)
        {
            XmlDocument doc = new XmlDocument();
            XmlWriter writer = doc.CreateNavigator().AppendChild();
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("", "");
            serializer.Serialize(writer, obj, ns);
            writer.Close();

            XmlDocument parentDocument = new XmlDocument();
            parentDocument.Load(path);
            XmlNode childNode = parentDocument.ImportNode(doc.DocumentElement, true);
            parentDocument.DocumentElement.AppendChild(childNode);
            parentDocument.Save(path);
        }

        // Восстанавливаем объекты из xml файлов.
        private T DeserializeObjectInfoFromXml<T>(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            FileStream fs = new FileStream(path, FileMode.Open);
            XmlReader reader = XmlReader.Create(fs);
            T obj;
            obj = (T)serializer.Deserialize(reader);
            fs.Close();

            return obj;
        }

        // Формируем путь к файлу в папке XMLBase.
        private string GetXmlDocumentPath(string fileName)
		{
			string path = "";
			XDocument xDoc = new XDocument();
			try
			{
				path = Path.Combine(TEST_BASE_DIRECTORY, fileName);
				xDoc = XDocument.Load(path);
			}
			catch (DirectoryNotFoundException)
			{
				path = Path.Combine(BASE_DIRECTORY, fileName);
				xDoc = XDocument.Load(path);
			}
			return  path;
		}
	}
}

#region Old method of appending a new company's data to the xml file.
//public void AddNewCompanyInfo(Company company)
//{
//	string path = GetXmlDocumentPath();
//	XDocument xDoc = XDocument.Load(path);

//	XAttribute companyNameAtribute = new XAttribute("name", company.Name);
//	XAttribute companyIdAttribute = new XAttribute("id", company.Id);
//	XElement companyElement = new XElement("company");
//	companyElement.Add(companyNameAtribute);
//	companyElement.Add(companyIdAttribute);

//          AddNewOfficeInfo(company, companyElement);

//          xDoc.Element("companies").Add(companyElement);

//	xDoc.Save(path);
//}

//      private void AddNewOfficeInfo(Company company, XElement companyElement)
//      {
//          foreach (Office office in company.Offices)
//          {
//              XElement officeElement = new XElement("office");
//              officeElement.Add(new XAttribute("id", office.Id));

//              officeElement.Add(new XElement("country", office.Country));
//              officeElement.Add(new XElement("city", office.City));
//              officeElement.Add(new XElement("address", office.Address));
//              officeElement.Add(new XElement("site", office.Site));

//              foreach (string phone in office.Phones)
//              {
//                  officeElement.Add(new XElement("phone", phone));
//              }

//              addNewContactPerson(office, officeElement);

//              companyElement.Add(officeElement);
//          }
//      }

//      private void addNewContactPerson(Office office, XElement officeElement)
//      {
//          foreach (Person person in office.ContactPersonList)
//          {
//              XElement contactPersonElement = new XElement("contact_person");
//              contactPersonElement.Add(new XAttribute("id", person.Id));
//              contactPersonElement.Add(new XElement("lastname", person.LastName));
//              contactPersonElement.Add(new XElement("firstname", person.FirstName));
//              if (person.MiddleName != "")
//                  contactPersonElement.Add(new XElement("middlename", person.MiddleName));
//              contactPersonElement.Add(new XElement("position", person.Position));

//              foreach (string email in person.Email)
//              {
//                  if (email != "")
//                  contactPersonElement.Add(new XElement("email", email));
//              }

//              AddNewContactPersonPhoneData(person, contactPersonElement);
//              AddNewContactPersonComment(person, contactPersonElement);

//              officeElement.Add(contactPersonElement);
//          }
//      }

//      private void AddNewContactPersonPhoneData(Person person, XElement contactPersonElement)
//      {
//          foreach (PersonPhoneData phoneData in person.PersonPhonesList)
//          {
//              XElement phoneDataElement = new XElement("phone_data");
//              phoneDataElement.Add(new XAttribute("type", phoneData.PhoneType));
//              phoneDataElement.Add(new XElement("phone_number", phoneData.PhoneNumber));
//              if (phoneData.PhoneComment != "")
//                  phoneDataElement.Add(new XElement("phone_comment", phoneData.PhoneComment));
//              contactPersonElement.Add(phoneDataElement);
//          }
//      }

//      private void AddNewContactPersonComment(Person person, XElement contactPersonElement)
//      {
//          foreach (PersonComment personComment in person.PersonCommentList)
//          {
//              XElement personCommentElement = new XElement("person_comment");
//              personCommentElement.Add(new XElement("data", personComment.Date));
//              personCommentElement.Add(new XElement("comment", personComment.Comment));
//              contactPersonElement.Add(personCommentElement);
//          }
//      }
#endregion