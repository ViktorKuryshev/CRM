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
			XAttribute companyIdAttribute = new XAttribute("id", company.Id);
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

                officeElement.Add(new XElement("country", office.Country));
                officeElement.Add(new XElement("city", office.City));
                officeElement.Add(new XElement("address", office.Address));
                officeElement.Add(new XElement("site", office.Site));

                foreach (string phone in office.Phones)
                {
                    officeElement.Add(new XElement("phone", phone));
                }

                addNewContactPerson(office, officeElement);

                companyElement.Add(officeElement);
            }
        }

        private void addNewContactPerson(Office office, XElement officeElement)
        {
            foreach (Person person in office.ContactPersonList)
            {
                XElement contactPersonElement = new XElement("contact_person");
                contactPersonElement.Add(new XAttribute("id", person.Id));
                contactPersonElement.Add(new XElement("lastname", person.LastName));
                contactPersonElement.Add(new XElement("firstname", person.FirstName));
                if (person.MiddleName != "")
                    contactPersonElement.Add(new XElement("middlename", person.MiddleName));
                contactPersonElement.Add(new XElement("position", person.Position));

                foreach (string email in person.Email)
                {
                    if (email != "")
                    contactPersonElement.Add(new XElement("email", email));
                }

                AddNewContactPersonPhoneData(person, contactPersonElement);
                AddNewContactPersonComment(person, contactPersonElement);

                officeElement.Add(contactPersonElement);
            }
        }

        private void AddNewContactPersonPhoneData(Person person, XElement contactPersonElement)
        {
            foreach (PersonPhoneData phoneData in person.PersonPhonesList)
            {
                XElement phoneDataElement = new XElement("phone_data");
                phoneDataElement.Add(new XAttribute("type", phoneData.PhoneType));
                phoneDataElement.Add(new XElement("phone_number", phoneData.PhoneNumber));
                if (phoneData.PhoneComment != "")
                    phoneDataElement.Add(new XElement("phone_comment", phoneData.PhoneComment));
                contactPersonElement.Add(phoneDataElement);
            }
        }

        private void AddNewContactPersonComment(Person person, XElement contactPersonElement)
        {
            foreach (PersonComment personComment in person.PersonCommentList)
            {
                XElement personCommentElement = new XElement("person_comment");
                personCommentElement.Add(new XElement("data", personComment.Date));
                personCommentElement.Add(new XElement("comment", personComment.Comment));
                contactPersonElement.Add(personCommentElement);
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
