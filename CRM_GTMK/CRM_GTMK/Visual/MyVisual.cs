using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRM_GTMK.Control;
using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.OneOfficeContactTableLayoutPanel;

namespace CRM_GTMK.Visual
{
	public class MyVisual
    {
	    private Controller _controller;

        public MainScreenForm MainScreenForm { get; set; }
        public AddNewCompanyForm NewClientForm { get; set; }
        
        public MyVisual(Controller controller)
		{
			_controller = controller;
        }
        //TODO открыть стартовое окно
        private void SetUpStartWindow()
        {
            //TODO set the properties of the main window
        }

	    public void ShowMainScreenDialog()
	    {
		    MainScreenForm = new MainScreenForm(_controller);
		    MainScreenForm.ShowDialog();
	    }

        public void ShowAddNewCompanyDialog()
        {
	        NewClientForm = new AddNewCompanyForm(_controller);
	        NewClientForm.ShowDialog();
		}

        public void ShowAddNewContactPersonDialog(MyOneOfficeContactTableLayoutPanel panel)
        {
            AddNewContactPersonForm newContactPersonForm = new AddNewContactPersonForm(_controller, 
                                                            panel.MyOfficeNumberLabel.OfficeNumber);

            panel.MyContactPersonFormList.Add(newContactPersonForm);
            newContactPersonForm.ShowDialog();
        }

        public void ShowAddNewContactPersonPhoneForm(AddNewContactPersonForm form)
        {
            AddNewContactPersonPhoneForm newContactPersonPhoneForm = new AddNewContactPersonPhoneForm(_controller, form);
            form.MyContactPersonPhoneFormList.Add(newContactPersonPhoneForm);
            newContactPersonPhoneForm.ShowDialog();
        }
    }
}
