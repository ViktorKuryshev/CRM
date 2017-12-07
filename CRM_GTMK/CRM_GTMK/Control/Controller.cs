using CRM_GTMK.Model;
using CRM_GTMK.Visual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CRM_GTMK.Control
{

    public class Controller
    {
        private MyModel _myModel { get; set; }
        private MyVisual _myVisual { get; set; }

	    public Controller()
	    {
		    _myModel = new MyModel();
			_myVisual = new MyVisual(this);
	    }

	    public void AddClientName(string[] clientsInfo)
	    {
		    new ClientsListForm(clientsInfo).ShowDialog();
			_myModel.XmlHelper.AddNewCompanyInfo();

	    }
		
    }
}
