using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRM_GTMK.Control;
using CRM_GTMK.Model;
using CRM_GTMK.Visual;

namespace CRM_GTMK
{
    class StartCRM
    {
        
        static void Main(string[] args)
        {
			// Pull request test

			Controller controller = new Controller();
			MainScreenForm myVisual = new MainScreenForm(controller);
			MyModel myModel = new MyModel(controller);
	        controller.Start(myModel, myVisual);
        }
    }
}
