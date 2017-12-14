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

namespace CRM_GTMK.Control
{
	
    public class Controller
    {
	    enum TestStep
	    {
		    AddCompanyForm,
			MainScreen
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

		    switch (TestStep.AddCompanyForm)
		    {
				case TestStep.MainScreen:
					ShowMainScreenDialog();
					break;

				case TestStep.AddCompanyForm:
					ShowAddNewCompanyDialog();
					break;

			}

	    }

	    public void ShowMainScreenDialog()
	    {
		    _myVisual.ShowMainScreenDialog();
	    }


		public void ShowAddNewCompanyDialog()
	    {
		    _myVisual.ShowAddNewCompanyDialog();
	    }


		public void SaveNewCompanyData()
	    {

			_myModel.NewCompany = GetCompanyDataGromForm();
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

	    private Company GetCompanyDataGromForm()
	    {
			Company company = new Company();
		    company.Name = _myVisual.AddNewClientForm.NewCompanyNameTextBox.Text;

            foreach (MyOneOfficeContactTableLayoutPanel tableLayoutPanel in _myVisual
                                                                                .AddNewClientForm
                                                                                .MyOneOfficeContactTableLayoutPanelList)
            {
                Office newOffice = new Office();
                foreach (MyPhonePanel panel in tableLayoutPanel
                                                .MyPhonesFlowLayoutPanel
                                                .MyPhonePanels)
                {
                    newOffice.Phones.Add(panel.MyPhoneTextBox.Text);
                }
                company.Offices.Add(newOffice);
            }
		    return company;
	    }
	}
}
