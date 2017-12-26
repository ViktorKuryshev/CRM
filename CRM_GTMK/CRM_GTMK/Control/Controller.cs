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
			AllProjectsForm
		}
	    private MyModel _myModel;
	    private MyVisual _myVisual;

	    public Controller()
	    {
		    
	    }

	    public void Start(MyModel myModel, MyVisual myVisual)
	    {
		    _myModel = myModel;
		    _myVisual = myVisual;

		    switch (TestStep.MainScreen)
		    {
				case TestStep.MainScreen:
					ShowMainScreenDialog();
					break;

				case TestStep.AddCompanyForm:
					ShowAddNewCompanyDialog();
					break;
				case TestStep.AllProjectsForm:
					ShowAllProjectsForm();
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

		public void ShowAllProjectsForm()
		{
			_myVisual.ShowAllProjectsForm();
		}

		public void ShowMainScreenDialog()
	    {
		    _myVisual.ShowMainScreenDialog();
	    }


		public void ShowAddNewCompanyDialog()
	    {
		    _myVisual.ShowAddNewCompanyDialog();
	    }

		public void SetProjectsList()
		{
			if (_myModel.CurrentProjects == null)
			{
				_myModel.CurrentProjects = _myModel.ApiClient.GetCurrentProjects();
				_myModel.CurrentProjects.Sort();
			}
			
			
			_myVisual.MainScreenForm.MyAllProjectsTableLayoutPanel.SuspendLayout();

			foreach (var project in _myModel.CurrentProjects)
			{
				
				ProjectControls projectControls = new ProjectControls();
				
				projectControls.ProjectName.Text = project.name;
				

				projectControls.ProjectDeadLine.Text = project.deadline.ToString();
				_myVisual.MainScreenForm.MyAllProjectsTableLayoutPanel.AddOneProject(projectControls);
				

			}
			_myVisual.MainScreenForm.MyAllProjectsTableLayoutPanel.ResumeLayout(false);
			_myVisual.MainScreenForm.MyAllProjectsTableLayoutPanel.PerformLayout();


		}

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

		    _myVisual.AddNewClientForm.Dispose();
		}

	    private Company GetCompanyDataFromForm()
	    {
			Company company = new Company();
		    company.Name = _myVisual.AddNewClientForm.NewCompanyNameTextBox.Text;
            GetOfficeDataFromForm(company);
            return company;
	    }

        private void GetOfficeDataFromForm(Company company)
        {
            var officeList = _myVisual
                                .AddNewClientForm
                                .MyAllOfficesFlowLayoutPanel
                                .MyOneOfficeContactTableLayoutPanelList;

            for (int i = 0; i < officeList.Count; i++)
            {
                Office newOffice = new Office();
                newOffice.Id = i + 1;

                GetOfficeContactInfoFromForm(newOffice, i, officeList);
                GetOfficePhonesFromForm(newOffice, i, officeList);

                company.Offices.Add(newOffice);
            }
        }

        private void GetOfficeContactInfoFromForm(Office office, 
                                                  int i, 
                                                  List<MyOneOfficeContactTableLayoutPanel> officeList)
        {
            office.Country = officeList[i].MyOfficeContactInfoPanel.MyOfficeCountryComboBox.Text;
            office.City = officeList[i].MyOfficeContactInfoPanel.MyOfficeCityTextBox.Text;
            office.Address = officeList[i].MyOfficeContactInfoPanel.MyOfficeAddressTextBox.Text;
            office.Site = officeList[i].MyOfficeContactInfoPanel.MyOfficeSiteTextBox.Text;
        }

        private void GetOfficePhonesFromForm(Office office,
                                             int i,
                                             List<MyOneOfficeContactTableLayoutPanel> officeList)
        {
            foreach (MyPhonePanel panel in officeList[i]
                                .MyPhonesFlowLayoutPanel
                                .MyPhonePanels)
            {
                if (panel.MyPhoneTextBox.Text != "")
                    office.Phones.Add(panel.MyPhoneTextBox.Text);
            }
        }
    }
}
