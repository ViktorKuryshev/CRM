using CRM_GTMK.Model;
using CRM_GTMK.Visual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.GeneralContactInfoPanel.PhonesFlowPanel.OnePhonePanel;


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

		    ShowTestStep();
		    //_myVisual.ShowMainScreenDialog();

	    }

	    private void ShowTestStep()
	    {
		    ShowAddNewCompanyDialog();

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
		    _myModel.NewCompany = new Company();
			//todo Проверить введно ли имя компании
		    if (IsCompanyNameEntered())
		    {
			    MessageBox.Show("Надо ввести название компании");
			    //return;
		    }
			MessageBox.Show("Это сообщение не должно появиться потому что назание не введено"); 
			//Внесение данных из формы в структуру вынести в метод
		    _myModel.NewCompany.Name = _myVisual.AddNewClientForm.NewCompanyNameTextBox.Text;
			Office newOffice = new Office();
		    foreach (MyPhonePanel panel in _myVisual.AddNewClientForm.MyPhonesFlowLayout.MyPhonePanels)
		    {
			    newOffice.Phones.Add(panel.MyPhoneTextBox.Text);
		    }

			_myModel.NewCompany.Offices.Add(newOffice);
			
			//new ClientsListForm(clientsInfo).ShowDialog();
			_myModel.XmlHelper.AddNewCompanyInfo(_myModel.NewCompany);
			//

		}

		/// <summary>
		/// Проверяем введено ли имя компании в форму добавления
		/// </summary>
		/// <returns></returns>
	    private bool IsCompanyNameEntered()
	    {
		    return _myVisual.AddNewClientForm.NewCompanyNameTextBox.Text == "";

	    }



	}
}
