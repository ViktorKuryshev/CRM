using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRM_GTMK.Control;

namespace CRM_GTMK.Visual
{
	public class MyVisual
    {
	    private Controller _controller;

		public AddNewCompanyForm AddNewClientForm { get; set; }
		public MainScreenForm MainScreenForm { get; set; }
		public AllProjectsForm AllProjectsForm { get; set; }



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
	        AddNewClientForm = new AddNewCompanyForm(_controller);
	        AddNewClientForm.ShowDialog();

		}

		internal void ShowAllProjectsForm()
		{
			AllProjectsForm = new AllProjectsForm();
			AllProjectsForm.ShowDialog();
		}
	}
}
