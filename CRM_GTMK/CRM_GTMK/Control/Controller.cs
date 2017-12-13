using CRM_GTMK.Model;
using CRM_GTMK.Visual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.GeneralContactInfoPanel.PhonesFlowPanel.OnePhonePanel;
using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel;

namespace CRM_GTMK.Control
{

    public class Controller
    {
	    private MyModel _myModel;
	    private MyVisual _myVisual;

	    public Controller()
	    {
		    
	    }

	    public void Start(MyModel myModel, MyVisual myVisual)
	    {
		    _myModel = myModel;
		    _myVisual = myVisual;

			_myVisual.ShowMainScreenDialog();

	    }

	    public void ShowAddNewCompanyDialog()
	    {
		    _myVisual.ShowAddNewCompanyDialog();
	    }


		public void SaveNewCompanyData()
	    {
		    _myModel.NewCompany = new Company();
		    _myModel.NewCompany.Name = _myVisual.AddNewClientForm.NewCompanyNameTextBox.Text;
			Office newOffice = new Office();

            foreach (MyOneOfficeFlowLayoutPanel MyOneOfficeFlowLayoutPanel in MyOneOfficeFlowLayoutPanel
                                                                                .MyOneOfficeFlowLayoutPanelList)
            {
                foreach (MyPhonePanel panel in MyOneOfficeFlowLayoutPanel
                                                .MyGeneralContactFlowLayoutPanel
                                                .MyPhonesFlowLayout
                                                .MyPhonePanelList)
                {
                    newOffice.Phones.Add(panel.MyPhoneTextBox.Text);
                }
            }

			_myModel.NewCompany.Offices.Add(newOffice);
			
			//new ClientsListForm(clientsInfo).ShowDialog();
			_myModel.XmlHelper.AddNewCompanyInfo(_myModel.NewCompany);

		}
    }
}
