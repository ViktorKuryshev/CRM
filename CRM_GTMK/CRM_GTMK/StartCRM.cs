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
			
			Controller controller = new Controller();
			MyVisual myVisual = new MyVisual(controller);
			MyModel myModel = new MyModel(controller);
	        controller.Start(myModel, myVisual);
        }
    }
}
