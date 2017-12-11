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
					
			//Проверяем введно ли имя компании
		    if (IsCompanyNameEntered())
		    {
			    MessageBox.Show("Надо ввести название компании");
			    return;
		    }

		    _myModel.NewCompany = FetchCompanyDataFromForm();
	
		    //Todo проверить есть ли такая компания в базе 
				//todo поиск компании в базе по параметрам Название || телефон || имейл
				//todo если совпдение найдено выдать дилог, есть такая компания и данные компании и выбор что делать

		   // if (IsCompanyAlreadyInBase())
		   // {
			    
		   // }

			//ToDo добавить id в новую компанию
				//todo если есть компании в списке получить самый большой id и добавить 1
			
			//Добавляем компанию в базу
			_myModel.XmlHelper.AddNewCompanyInfo(_myModel.NewCompany);
			
			//Закрываем окно 
		}

		/// <summary>
		/// Проверяем введено ли имя компании в форму добавления
		/// </summary>
		/// <returns></returns>
		private bool IsCompanyNameEntered()
	    {
		    return _myVisual.AddNewClientForm.NewCompanyNameTextBox.Text == "";

	    }

	    private Company FetchCompanyDataFromForm()
	    {
			Company company = new Company();
			company.Name = _myVisual.AddNewClientForm.NewCompanyNameTextBox.Text;

			Office newOffice = new Office();
		    foreach (MyPhonePanel panel in _myVisual.AddNewClientForm.MyPhonesFlowLayout.MyPhonePanels)
		    {
			    newOffice.Phones.Add(panel.MyPhoneTextBox.Text);
		    }

		    company.Offices.Add(newOffice);
		    return company;
	    }



	}
}
