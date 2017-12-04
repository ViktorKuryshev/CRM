using CRM_GTMK.Model;
using CRM_GTMK.Visual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CRM_GTMK.Control
{

    class Controller
    {
        public MyModel MyModel { get; set; }
        public MyVisual MyVisual { get; set; }

	    public Controller()
	    {
		    //MyModel = new MyModel();
			MyVisual = new MyVisual();
	    }

	    public void Start()
	    {
			MyVisual = new MyVisual();
		}

    }
}
