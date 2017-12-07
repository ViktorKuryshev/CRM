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
	    private MyModel _myModel;
	    private MyVisual _myVisual;

	    public Controller()
	    {
		    _myModel = new MyModel();
		    _myVisual = new MyVisual(this);
	    }

	    public void AddClientName(string[] clientsInfo)
	    {
		    //new ClientsListForm(clientsInfo).ShowDialog();

	    }

	    public void AddNewCompanyInfo(AddNewClientForm form)
	    {
		    _myModel.NewCompany.Name = form.GetCompanyNameBox().Text;

			_myModel.XmlHelper.AddNewCompanyInfoToBase(_myModel.NewCompany);

	    }
		
    }
}
