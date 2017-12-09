﻿using CRM_GTMK.Model;
using CRM_GTMK.Visual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRM_GTMK.Visual.MyPanels;


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

			_myVisual.ShowMainScreen();
			//_myVisual.ShowAddNewCompanyDialog();

	    }

	    public void SaveNewCompanyData()
	    {
		    _myModel.NewCompany = new Company();
		    _myModel.NewCompany.Name = _myVisual.AddNewClientForm.NewCompanyNameTextBox.Text;
			Office newOffice = new Office();
		    foreach (MyPhonePanel panel in _myVisual.AddNewClientForm.MyPhonesFlowLayout.MyPhonePanels)
		    {
			    newOffice.Phones.Add(panel.MyPhoneTextBox.Text);
		    }

			_myModel.NewCompany.Offices.Add(newOffice);
			
			//Todo проверить уникальность компании
		    bool companyIsUnique = true;

			if (companyIsUnique)
		    {
			    _myModel.XmlHelper.AddNewCompanyInfo(_myModel.NewCompany);
		    }
			
			//todo Добавить задачу связаться с компанией

		}

	    
    }
}
