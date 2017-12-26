using CRM_GTMK.Model;
using CRM_GTMK.Visual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.OneOfficeContactTableLayoutPanel;
using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.OneOfficeContactTableLayoutPanel.PhonesFlowPanel.OnePhonePanel;

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

        public void ShowAddNewContactPersonDialog(MyOneOfficeContactTableLayoutPanel myOneOfficeContactTableLayoutPanel)
        {
            _myVisual.ShowAddNewContactPersonDialog(myOneOfficeContactTableLayoutPanel);
        }

        public void ShowAddNewContactPersonPhoneForm(AddNewContactPersonForm form)
        {
            _myVisual.ShowAddNewContactPersonPhoneForm(form);
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

		    _myVisual.NewClientForm.Dispose();
		}

	    private Company GetCompanyDataFromForm()
	    {
			Company company = new Company();
		    company.Name = _myVisual.NewClientForm.NewCompanyNameTextBox.Text;
            GetOfficeDataFromForm(company);
            return company;
	    }

        private void GetOfficeDataFromForm(Company company)
        {
            var officeList = _myVisual
                                .NewClientForm
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
                                                  int officeNumberInTheList, 
                                                  List<MyOneOfficeContactTableLayoutPanel> officeList)
        {
            office.Country = officeList[officeNumberInTheList].MyOfficeContactInfoPanel.MyOfficeCountryComboBox.Text;
            office.City = officeList[officeNumberInTheList].MyOfficeContactInfoPanel.MyOfficeCityTextBox.Text;
            office.Address = officeList[officeNumberInTheList].MyOfficeContactInfoPanel.MyOfficeAddressTextBox.Text;
            office.Site = officeList[officeNumberInTheList].MyOfficeContactInfoPanel.MyOfficeSiteTextBox.Text;
        }

        private void GetOfficePhonesFromForm(Office office,
                                             int officeNumberInTheList,
                                             List<MyOneOfficeContactTableLayoutPanel> officeList)
        {
            foreach (MyPhonePanel panel in officeList[officeNumberInTheList]
                                .MyPhonesFlowLayoutPanel
                                .MyPhonePanels)
            {
                if (panel.MyPhoneTextBox.Text != "")
                    office.Phones.Add(panel.MyPhoneTextBox.Text);
            }
        }

        public void SaveNewContactPersonPhone()
        {

            //_myModel.NewPersonList.Add(new Person());

            //PersonPhoneData newPersonPhoneData = new PersonPhoneData();
            //newPersonPhoneData.PhoneType = _myVisual.ContactPersonPhoneForm.NewPhoneTypeComboBox.Text;
            //newPersonPhoneData.PhoneNumber = _myVisual.ContactPersonPhoneForm.NewPhoneNumber;
            //newPersonPhoneData.PhoneComment = _myVisual.ContactPersonPhoneForm.NewPhoneCommentRichTextBox.Text;
            //_myModel.NewPerson.
        }
    }
}
