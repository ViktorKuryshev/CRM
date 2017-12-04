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
        public MyModel MyModel { get; set; }
        public MyVisual MyVisual { get; set; }

	    public Controller()
	    {
		    //MyModel = new MyModel();
			MyVisual = new MyVisual(this);
	    }

	    public void AddClientName(string text)
	    {
		    MessageBox.Show("Имя компании:" + text);

	    }
		
    }
}
