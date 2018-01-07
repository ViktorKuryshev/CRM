using CRM_GTMK.Model;
using CRM_GTMK.Visual;
using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.ContactPersonPanel.CommentsContactPersonFlowLayoutPanel.CommentsInnerFlowLayoutPanel.OneCommentPanel;
using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.OneOfficeContactTableLayoutPanel;
using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.OneOfficeContactTableLayoutPanel.PhonesFlowPanel.OnePhonePanel;
using CRM_GTMK.Visual.MainScreenPanels;
using System.Collections.Generic;
using System.Windows.Forms;
using CRM_GTMK.Model.TestApi;
using Newtonsoft.Json;
using CRM_GTMK.Model.DataModels;

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

			//Создаем окружение
			SetLocalValues();
			//Todo Сформировать окружение. т.е. проверить есть ли таблицы с данными, если есть, то зарузить локальные переменные
			//, загрузить данные из API и сравнить с таблицами, если с Данные с АПИ новее то обновить данные в базе


			//Если тестируем определенный шаг.
			if (stepsTesting) { 
				//Выбираем тестовый шаг
				switch (TestStep.AddCompanyForm)
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

					//case TestStep.API:
					//	ApiClient client = new ApiClient();
					//	foreach (var project in client.GetCurrentProjects())
					//	{
					//		Console.WriteLine(project.name);
					//			}
					//	break;
				}
			}

			
		}

		//Загрузка окружения
		#region SettingGlobals
		private void SetLocalValues()
		{

			//Model.TestApi.ApiClient client = new Model.TestApi.ApiClient();
			//MessageBox.Show(client.CreateProject(LocalValues.DocumentsPaths, LocalValues.FocusedProject));
			//Todo если файл с данными существует, сделать десериализацию, учитывая то что статический файл не получится серриализовать
			//Думаю можно передавать его поля в такой же только не статический класс а при дессиреализации возвращать поля в статический
			GlobalValues.CurrentProjects = new List<Project>();
			
			//Todo Проверить 


		}
		#endregion


		/// <summary>
		/// Показываем главный экран
		/// </summary>
		public void ShowMainScreenDialog()
		{
			MainScreenForm.ShowDialog();
		}

		//Обработка данных проекта
		#region ProjectDataMethods

			public void SendNewProject()
		{
			ApiClient client = new ApiClient();
			MessageBox.Show(client.CreateProject(GlobalValues.DocumentsPaths, GlobalValues.FocusedProject.SiteProject));
		}

		/// <summary>
		/// Получаем список проектов
		/// </summary>
		public List<ProjectControls> GetProjectsList()
		{
			//Если список проектов пуст получаем его с сайта
			if (GlobalValues.CurrentProjects == null)
			{
				GlobalValues.CurrentProjects = _myModel.ApiClient.GetCurrentProjects();
				GlobalValues.CurrentProjects.Sort();
			}

			int numberOfShownProjects = 10; //Сколько проектов показываем

			List<ProjectControls> allProjects = new List<ProjectControls>();

			foreach (var project in GlobalValues.CurrentProjects)
			{
				ProjectControls projectControls = new ProjectControls(MainScreenForm, project.Name, project.Deadline.ToString(), project.Id);
				allProjects.Add(projectControls);
				//Создаем список документов
				foreach (var document in project.Documents)
				{
					DocumentControls documentControls = new DocumentControls(MainScreenForm, "**" + document.Name, document.Id);
					projectControls.AllDocuments.Add(documentControls);
				}
	
				numberOfShownProjects--;
				if (numberOfShownProjects < 0) break;

			}
			return allProjects;
		}
		#endregion

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
		/// Добавляем данные по компании в базу
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
			//Todo проверить компанию по названию, по телефону, по имейлу

			//todo присвоить компании уникальный id для получить последний id
			_myModel.NewCompany.Id = _myModel.XmlHelper.GetBigestCompanyId() + 1;
			//new ClientsListForm(clientsInfo).ShowDialog();
			_myModel.XmlHelper.AddNewCompanyInfo(_myModel.NewCompany);

			//Todo Автоматически поставилась задача на проработку компании менеджеру по какому-то принципу

			MainScreenForm.NewClientForm.Dispose();
		}

        // Передаем данные о компании из полей форм для ввода в соответствующие переменные.
		private Company GetCompanyDataFromForm()
		{
			Company company = new Company();
			company.Name = MainScreenForm.NewClientForm.NewCompanyNameTextBox.Text;
			GetOfficeDataFromForm(company);
			return company;
		}

        // Передаем данные об офисах компании из полей форм для ввода в соответствующие 
        // переменные.
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
				getOfficeContactPersonInfoFromForm(newOffice, officeList[i]);
				getOfficePhonesFromForm(newOffice, officeList[i]);

				company.Offices.Add(newOffice);
			}
		}

        // Передаем данные об одном офисе компании из полей форм для ввода в соответствующие 
        // переменные.
        private void GetOfficeContactInfoFromForm(Office office, MyOneOfficeContactTableLayoutPanel officeList)
		{
			office.Country = officeList.MyOfficeContactInfoPanel.MyOfficeCountryComboBox.Text;
			office.City = officeList.MyOfficeContactInfoPanel.MyOfficeCityTextBox.Text;
			office.Address = officeList.MyOfficeContactInfoPanel.MyOfficeAddressTextBox.Text;
			office.Site = officeList.MyOfficeContactInfoPanel.MyOfficeSiteTextBox.Text;
		}

        // Передаем данные о сотрудниках одного офиса компании из полей форм для ввода 
        // в соответствующие переменные.
        private void getOfficeContactPersonInfoFromForm(Office office,
                                                    MyOneOfficeContactTableLayoutPanel officePanel)
		{
			for (int i = 0; i < officePanel
                               .MyContactPersonFormList.Count; i++)
			{
				var form = officePanel.MyContactPersonFormList[i];
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

        // Передаем данные о телефоне одного сотрудника одного офиса компании из полей форм 
        // для ввода в соответствующие переменные.
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

        // Передаем данные о комментариях одного сотрудника одного офиса компании из полей форм 
        // для ввода в соответствующие переменные.
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

        // Передаем данные о телефонах одного офиса компании из полей форм 
        // для ввода в соответствующие переменные.
        private void getOfficePhonesFromForm(Office office,
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
