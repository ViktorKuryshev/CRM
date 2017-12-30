using CRM_GTMK.Model;
using CRM_GTMK.Visual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.GeneralContactInfoPanel.PhonesFlowPanel.OnePhonePanel;
using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.OneOfficeContactTableLayoutPanel;
using CRM_GTMK.Visual.MainScreenPanels;

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
			NewProjectForm
		}
	    private MyModel _myModel;
	    private MainScreenForm MainScreenForm;

	    public Controller()
	    {
		    
	    }

	    public void Start(MyModel myModel, MainScreenForm mainScreenForm)
	    {
		    _myModel = myModel;
			MainScreenForm = mainScreenForm;

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
				
				case TestStep.API:
					ApiClient client = new ApiClient();
					foreach (var project in client.GetCurrentProjects())
					{
						Console.WriteLine(project.name);
							}
					break;

			}

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
		    _myModel.NewCompany.id = _myModel.XmlHelper.GetBigestCompanyId() + 1;
			//new ClientsListForm(clientsInfo).ShowDialog();
			_myModel.XmlHelper.AddNewCompanyInfo(_myModel.NewCompany);

			//Todo Автоматически поставилась задача на проработку компании менеджеру по какойму-то принципу

			MainScreenForm.AddNewClientForm.Dispose();
		}

	    private Company GetCompanyDataFromForm()
	    {
			Company company = new Company();
		    company.Name = MainScreenForm.AddNewClientForm.NewCompanyNameTextBox.Text;
            GetOfficeDataFromForm(company);
            return company;
	    }

        private void GetOfficeDataFromForm(Company company)
        {
            var officeList = MainScreenForm
								.AddNewClientForm
                                .MyAllOfficesFlowLayoutPanel
                                .MyOneOfficeContactTableLayoutPanelList;

			for (int i = 0; i < officeList.Count; i++)
			{
				Office newOffice = new Office();
				newOffice.Id = i + 1;

				GetOfficeContactInfoFromForm(newOffice, officeList[i]);
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
