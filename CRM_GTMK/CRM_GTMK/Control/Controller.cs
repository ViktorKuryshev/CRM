using CRM_GTMK.Model;
using CRM_GTMK.Model.DataModels;
using CRM_GTMK.Model.TestApi;
using CRM_GTMK.Visual;
using CRM_GTMK.Visual.MainScreenPanels;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

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

        string _checkOfOfficeCountryComboBoxText;
        string _checkOfOfficeCityTextBoxText;
        string _checkOfOfficeAddressTextBoxText;
        string _checkOfOfficeSiteTextBoxText;
        List<TextBox> _checkOfPhoneTextBoxList = new List<TextBox>();
        List<AddNewContactPersonForm> _checkOfContactPersonFormList;

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
				switch (TestStep.MainScreen)
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
			//MessageBox.Show(client.CreateProject(GlobalValues.DocumentsPaths, GlobalValues.FocusedProject.SiteProject));
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
				if (project.Documents == null) continue;
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

		public void ShowAddNewContactPersonDialog(TableLayoutPanel parentTableLayoutPanel)
		{
			MainScreenForm.ShowAddNewContactPersonDialog(parentTableLayoutPanel);
		}

        // Вызываем метод для создания и отображения новой формы для ввода телефона сотрудника.
        public bool ShowAddNewContactPersonPhoneForm(AddNewContactPersonForm form)
		{
			return MainScreenForm.ShowAddNewContactPersonPhoneForm(form);
		}

        // Вызываем метод для отображения заполненных данных по новому сотруднику.
        public void AddAndDisplayNewContactPerson(AddNewContactPersonForm form, int officeNumber)
		{
			MainScreenForm.NewClientForm.AddAndDisplayNewContactPerson(form, officeNumber);
		}

		/// <summary>
		/// Добавляем данные по компании в базу
		/// </summary>
		public void SaveNewCompanyData()
		{
            Company newCompany = GetCompanyDataFromForm();

            if (newCompany == null)
                return;
            _myModel.NewCompany = newCompany;

            //Todo в форме добавить возможность вписывать название компании на другом языке
            //Todo добавить в форму поле email
            //Todo проверить компанию на уникальность.
            //Todo проверить компанию по названию, по телефону, по имейлу

            //todo присвоить компании уникальный id для получить последний id
            _myModel.NewCompany.Id = _myModel.XmlHelper.GetBigestCompanyId() + 1;
			//new ClientsListForm(clientsInfo).ShowDialog();
			_myModel.XmlHelper.SaveNewCompanyInfoInXml(_myModel.NewCompany);

			//Todo Автоматически поставилась задача на проработку компании менеджеру по какому-то принципу

			MainScreenForm.NewClientForm.Dispose();
		}

        // Передаем данные о компании из полей форм для ввода в соответствующие переменные
        // соответствующих классов.
		private Company GetCompanyDataFromForm()
		{
			Company company = new Company();
			company.Name = MainScreenForm.NewClientForm.NewCompanyNameTextBox.Text;

            if (company.Name.Equals(""))
            {
                MessageBox.Show("Надо ввести название компании");
                return null;
            }
            GetOfficeDataFromForm(company);
			return company;
		}

        // Передаем данные об офисах компании из полей форм для ввода в соответствующие 
        // переменные.
        private void GetOfficeDataFromForm(Company company)
		{
			var officeList = MainScreenForm
								.NewClientForm
								.OneOfficeContactTableLayoutPanelList;

			for (int i = 0; i < officeList.Count; i++)
			{
                if (checkIfOfficeInfoFilled(officeList[i], i) == false)
                    return;
				Office newOffice = new Office();
				newOffice.Id = i + 1;

                getOfficeContactInfoFromForm(newOffice);
                getOfficePhonesFromForm(newOffice);

				getOfficeContactPersonInfoFromForm(newOffice);
				

				company.Offices.Add(newOffice);
			}
		}

        // Проверяем заполнены ли все поля. Если хотя бы одно поле заполнено, тогда добавляем
        // офис в базу. В противном случае - пропускаем.
        private bool checkIfOfficeInfoFilled(TableLayoutPanel officePanel, int officeNumberInList)
        {
            findControlInList(officePanel, officeNumberInList);

            return _checkOfOfficeCountryComboBoxText == "" &&
                   _checkOfOfficeCityTextBoxText     == "" &&
                   _checkOfOfficeAddressTextBoxText  == "" &&
                   _checkOfOfficeSiteTextBoxText     == "" &&
                   _checkOfPhoneTextBoxList     .All(p => p.Text == "") &&
                   _checkOfContactPersonFormList.Count == 0 ? false : true;
        }

        // Ищем контроли и подсписки в соответствующих списках. Сначала находим панель "officeContactInfoPanel"
        // с данными об офисе (страна, город, адрес и эл. почта) в списке контролей офиса с порядковым номером
        // "officeNumberInList" в списке панелей офисов. Затем в списке контролей панели "officeContactInfoPanel"
        // находим контроли для ввода данных (страна, город, адрес и эл. почта). Далее находим поля для ввода
        // телефона в панелях подсписка списка телефонов офиса GeneralPhonePanelList с порядковым номером,  
        // совпадающим с "officeNumberInList". И наконец, находим подсписок форм сотрудников в списке 
        // GeneralContactPersonFormList, порядковый номер которого также совпадает с "officeNumberInList".
        private void findControlInList(TableLayoutPanel officePanel, int officeNumberInList)
        {
            int officeContactInfoPanelIndex = officePanel.Controls.IndexOfKey(MainScreenForm.NewClientForm
                                             .OfficeContactInfoPanel.Name + officeNumberInList);

            Panel officeContactInfoPanel = (Panel)officePanel.Controls[officeContactInfoPanelIndex];

            _checkOfOfficeCountryComboBoxText = findTextBoxInControls(officeContactInfoPanel,
                                                                      officeNumberInList,
                                                                      MainScreenForm.NewClientForm.OfficeCountryComboBox.Name);
            _checkOfOfficeCityTextBoxText     = findTextBoxInControls(officeContactInfoPanel,
                                                                      officeNumberInList,
                                                                      MainScreenForm.NewClientForm.OfficeCityTextBox.Name);
            _checkOfOfficeAddressTextBoxText  = findTextBoxInControls(officeContactInfoPanel,
                                                                      officeNumberInList,
                                                                      MainScreenForm.NewClientForm.OfficeAddressTextBox.Name);
            _checkOfOfficeSiteTextBoxText     = findTextBoxInControls(officeContactInfoPanel, 
                                                                      officeNumberInList, 
                                                                      MainScreenForm.NewClientForm.OfficeSiteTextBox.Name);
            int nameSuffix = 0;
            _checkOfPhoneTextBoxList.Clear();

            foreach (Panel panel in MainScreenForm.NewClientForm.GeneralPhonePanelList[officeNumberInList])
            {
                int phoneTextBoxIndex = panel.Controls.IndexOfKey(MainScreenForm.NewClientForm
                                                      .PhoneTextBox.Name + nameSuffix);

                _checkOfPhoneTextBoxList.Add((TextBox)panel.Controls[phoneTextBoxIndex]);
                ++nameSuffix;
            }

            _checkOfContactPersonFormList = MainScreenForm.NewClientForm
                                           .GeneralContactPersonFormList[officeNumberInList];
        }

        // Ищем поле для ввода (TextBox) в списке контролей панели с данными об офисе (страна, город, адрес и эл. почта).
        private string findTextBoxInControls(Panel officeContactInfoPanel, int officeNumberInList,
                                             string originalTextBoxName)
        {
            int officeTextBoxIndex = officeContactInfoPanel.Controls
                                        .IndexOfKey(originalTextBoxName + officeNumberInList);

            return officeContactInfoPanel.Controls[officeTextBoxIndex].Text;
        }

        // Передаем данные об одном офисе компании из полей форм для ввода в соответствующие 
        // переменные.
        private void getOfficeContactInfoFromForm(Office office)
		{
			office.Country = _checkOfOfficeCountryComboBoxText;
			office.City    = _checkOfOfficeCityTextBoxText;
			office.Address = _checkOfOfficeAddressTextBoxText;
			office.Site    = _checkOfOfficeSiteTextBoxText;
		}

        // Передаем данные о телефонах одного офиса компании из полей форм 
        // для ввода в соответствующие переменные.
        private void getOfficePhonesFromForm(Office office)
        {
            foreach (TextBox textBox in _checkOfPhoneTextBoxList)
            {
                if (textBox.Text != "")
                    office.OfficePhonesList.Add(textBox.Text);
            }
        }

        // Передаем данные о сотрудниках одного офиса компании из полей форм для ввода 
        // в соответствующие переменные. Число 1 в сумме "i + 1" необходимо для задания
        // порядкового Id, начиная с 1, а не с 0, с которого начинается перечисление в
        // списке.
        private void getOfficeContactPersonInfoFromForm(Office office)
		{
			for (int i = 0; i < _checkOfContactPersonFormList.Count; i++)
			{
				AddNewContactPersonForm form = _checkOfContactPersonFormList[i];
				Person person = new Person();
				person.LastName = form.LastnameContactPersonTextBox.Text;
				person.FirstName = form.FirstnameContactPersonTextBox.Text;
				person.MiddleName = form.MiddleNameContactPersonTextBox.Text;
				person.EmailsList = form.EmailContactPerson.Where(e => !string.IsNullOrEmpty(e)).ToArray();
				person.Position = form.PositionContactPersonTextBox.Text;
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
				personPhoneData.PhoneType = phoneForm.PhoneTypeComboBox.Text;
				personPhoneData.PhoneNumber = phoneForm.NewPhoneNumber;
				personPhoneData.PhoneComment = phoneForm.PhoneCommentRichTextBox.Text;
				person.PersonPhonesList.Add(personPhoneData);
			}
		}

        // Передаем данные о комментариях одного сотрудника одного офиса компании из полей форм 
        // для ввода в соответствующие переменные.
        private void getContactPersonCommentsFromForm(AddNewContactPersonForm form, Person person)
		{
			foreach (Panel panel in form.MyCommentPanelList)
			{
                int dateLabelIndex          = panel.Controls.IndexOfKey(form.DateLabel.Name +
                                                                        form.MyCommentPanelList.IndexOf(panel));
                int commentRichTextBoxIndex = panel.Controls.IndexOfKey(form.CommentRichTextBox.Name +
                                                                        form.MyCommentPanelList.IndexOf(panel));


                if (panel.Controls[commentRichTextBoxIndex].Text != "")
				{
					PersonComment personComment = new PersonComment();
					personComment.Date          = panel.Controls[dateLabelIndex].Text;
					personComment.Comment       = panel.Controls[commentRichTextBoxIndex].Text;
					person.PersonCommentList.Add(personComment);
				}
			}
		}
	}
}
