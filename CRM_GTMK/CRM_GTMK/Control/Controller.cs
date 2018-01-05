using CRM_GTMK.Model;
using CRM_GTMK.Visual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.OneOfficeContactTableLayoutPanel;
using CRM_GTMK.Visual.MainScreenPanels;
using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.OneOfficeContactTableLayoutPanel.PhonesFlowPanel.OnePhonePanel;
using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.ContactPersonPanel.CommentsContactPersonFlowLayoutPanel.CommentsInnerFlowLayoutPanel.OneCommentPanel;

namespace CRM_GTMK.Control
{
	
	public class Controller
	{
		enum TestStep
		{
			AddCompanyForm,
			MainScreen,
			API,
			AllProjectsForm,
			NewProjectForm,
			AutoBrowser
		}

	    private MyModel _myModel;
	    private MainScreenForm MainScreenForm;

		private bool stepsTesting = true;

	    public Controller()
	    {
		    
	    }

		public void Start(MyModel myModel, MainScreenForm mainScreenForm)
		{
			_myModel = myModel;
			MainScreenForm = mainScreenForm;

			//Если тестируем определенный шаг.
			if (stepsTesting) { 
				//Выбираем тестовый шаг
				switch (TestStep.NewProjectForm)
				{
					case TestStep.MainScreen:
						ShowMainScreenDialog();
						break;
					case TestStep.NewProjectForm:
						MainScreenForm.AddNewProject();
						break;

					case TestStep.AddCompanyForm:
						MainScreenForm.ShowAddNewCompanyDialog();
						break;

					case TestStep.AutoBrowser:
						new BrowserPult().ShowDialog();
						break;

					case TestStep.API:
						ApiClient client = new ApiClient();
						foreach (var project in client.GetCurrentProjects())
						{
							Console.WriteLine(project.name);
								}
						break;
				}
			}

			//Создаем окружение
			//Todo Сформировать окружение. т.е. проверить есть ли таблицы с данными, если есть, то зарузить локальные переменные
			//, загрузить данные из API и сравнить с таблицами, если с Данные с АПИ новее то обновить данные в базе

		}

		/// <summary>
		/// Показываем главный экран
		/// </summary>
		public void ShowMainScreenDialog()
		{
			MainScreenForm.ShowDialog();
		}

		/// <summary>
		/// Получаем список проектов
		/// </summary>
		public List<ProjectControls> GetProjectsList()
		{
			//Если список проектов пуст получаем его с сайта
			if (_myModel.CurrentProjects == null)
			{
				_myModel.CurrentProjects = _myModel.ApiClient.GetCurrentProjects();
				_myModel.CurrentProjects.Sort();
			}

			int numberOfShownProjects = 10; //Сколько проектов показываем

			List<ProjectControls> allProjects = new List<ProjectControls>();

			foreach (var project in _myModel.CurrentProjects)
			{
				ProjectControls projectControls = new ProjectControls(MainScreenForm, project.name, project.deadline.ToString(), project.id);
				allProjects.Add(projectControls);
				//Создаем список документов
				foreach (var document in project.documents)
				{
					DocumentControls documentControls = new DocumentControls(MainScreenForm, "**" + document.name, document.id);
					projectControls.AllDocuments.Add(documentControls);
				}
	
				numberOfShownProjects--;
				if (numberOfShownProjects < 0) break;

			}
			return allProjects;
		}

		public void ShowAddNewCompanyDialog()
		{
			MainScreenForm.ShowAddNewCompanyDialog();
		}

		public void ShowAddNewContactPersonDialog(MyOneOfficeContactTableLayoutPanel panel)
		{
			MainScreenForm.ShowAddNewContactPersonDialog(panel);
		}
		public void ShowAddNewContactPersonPhoneForm(AddNewContactPersonForm form)
		{
			MainScreenForm.ShowAddNewContactPersonPhoneForm(form);
		}
		public void AddAndDisplayNewContactPerson(AddNewContactPersonForm form, int officeNumber)
		{
			MainScreenForm.NewClientForm.AddAndDisplayNewContactPerson(form, officeNumber);
		}

		/// <summary>
		/// Добавляем данные по комании в базу
		/// </summary>
		public void SaveNewCompanyData()
		{
			_myModel.NewCompany = GetCompanyDataFromForm();
			if (_myModel.NewCompany.Name.Equals(""))
			{
				MessageBox.Show("Надо ввести название компании");
				return;
			}

			//Todo в форме добавить возможность вписывать название компании на другом языке
			//Todo добавить в форму поле email
			//Todo проверить компанию на уникальность.
			//Todo проверить компанию по назвнию, по телефону, по имейлу

			//todo присвоить компании уникальный id для получить последний id
			_myModel.NewCompany.Id = _myModel.XmlHelper.GetBigestCompanyId() + 1;
			//new ClientsListForm(clientsInfo).ShowDialog();
			_myModel.XmlHelper.AddNewCompanyInfo(_myModel.NewCompany);

			//Todo Автоматически поставилась задача на проработку компании менеджеру по какойму-то принципу

			MainScreenForm.NewClientForm.Dispose();
		}

		private Company GetCompanyDataFromForm()
		{
			Company company = new Company();
			company.Name = MainScreenForm.NewClientForm.NewCompanyNameTextBox.Text;
			GetOfficeDataFromForm(company);
			return company;
		}

		private void GetOfficeDataFromForm(Company company)
		{
			var officeList = MainScreenForm
								.NewClientForm
								.MyAllOfficesFlowLayoutPanel
								.MyOneOfficeContactTableLayoutPanelList;

			for (int i = 0; i < officeList.Count; i++)
			{
				Office newOffice = new Office();
				newOffice.Id = i + 1;

				GetOfficeContactInfoFromForm(newOffice, officeList[i]);
				getOfficeContactPersonInfoFromForm(newOffice, i, officeList);
				GetOfficePhonesFromForm(newOffice, officeList[i]);

				company.Offices.Add(newOffice);
			}
		}

		private void GetOfficeContactInfoFromForm(Office office, MyOneOfficeContactTableLayoutPanel officeList)
		{
			office.Country = officeList.MyOfficeContactInfoPanel.MyOfficeCountryComboBox.Text;
			office.City = officeList.MyOfficeContactInfoPanel.MyOfficeCityTextBox.Text;
			office.Address = officeList.MyOfficeContactInfoPanel.MyOfficeAddressTextBox.Text;
			office.Site = officeList.MyOfficeContactInfoPanel.MyOfficeSiteTextBox.Text;
		}

		private void getOfficeContactPersonInfoFromForm(Office office,
													int officeNumberInTheList,
													List<MyOneOfficeContactTableLayoutPanel> officeList)
		{
			for (int i = 0; i < officeList[officeNumberInTheList]
							   .MyContactPersonFormList.Count; i++)
			{
				var form = officeList[officeNumberInTheList].MyContactPersonFormList[i];
				Person person = new Person();
				person.LastName = form.LastnameContactPerson;
				person.FirstName = form.FirstnameContactPerson;
				person.MiddleName = form.MiddleNameContactPerson;
				person.Email = form.EmailContactPerson;
				person.Position = form.PositionContactPerson;
				person.Id = i + 1;
				getContactPersonPhonesFromForm(form, person);
				getContactPersonCommentsFromForm(form, person);
				office.ContactPersonList.Add(person);
			}
		}

		private void getContactPersonPhonesFromForm(AddNewContactPersonForm form, Person person)
		{
			foreach (AddNewContactPersonPhoneForm phoneForm in form.MyContactPersonPhoneFormList)
			{
				PersonPhoneData personPhoneData = new PersonPhoneData();
				personPhoneData.PhoneType = phoneForm.NewPhoneType;
				personPhoneData.PhoneNumber = phoneForm.NewPhoneNumber;
				personPhoneData.PhoneComment = phoneForm.NewPhoneComment;
				person.PersonPhonesList.Add(personPhoneData);
			}
		}

		private void getContactPersonCommentsFromForm(AddNewContactPersonForm form, Person person)
		{
			foreach (MyCommentPanel panel in form.MyCommentPanelList)
			{
				if (panel.MyCommentRichTextBox.Text != "")
				{
					PersonComment personComment = new PersonComment();
					personComment.Date = panel.MyDateLabel.Text;
					personComment.Comment = panel.MyCommentRichTextBox.Text;
					person.PersonCommentList.Add(personComment);
				}
			}
		}

		private void GetOfficePhonesFromForm(Office office,
											 MyOneOfficeContactTableLayoutPanel officeList)
		{
			foreach (MyPhonePanel panel in officeList
								.MyPhonesFlowLayoutPanel
								.MyPhonePanels)
			{
				if (panel.MyPhoneTextBox.Text != "")
					office.Phones.Add(panel.MyPhoneTextBox.Text);
			}
		}
	}
}
