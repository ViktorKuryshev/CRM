using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRM_GTMK.Control;
using CRM_GTMK.Model.TestApi;
using CRM_GTMK.Model.DataModels;

namespace CRM_GTMK.Model
{
	public class MyModel
	{
		private Controller _controller;
		public Company NewCompany { get; set; }

		public ApiClient ApiClient { get; } = new ApiClient(); 

		


        public MyModel(Controller controller)
		{
			_controller = controller;

		}
		public XmlHelper XmlHelper { get; set; } = new XmlHelper();

    }
}
