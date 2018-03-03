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
            MyModel myModel = new MyModel(controller);
            MainScreenForm myVisual = new MainScreenForm(controller, myModel);

	        controller.Start(myModel, myVisual);
        }
    }
}
