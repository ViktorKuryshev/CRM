using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_GTMK.Model
{
    public class Company
    {
        public string[] Fields { get; set; }
        public string Name { get; set; }
        public string Sourse { get; set; }
        public string[] WebSites { get; set; }

        public Office[] offices { get; set; }

        public ContactPerson persons { get; set; }

        //Todo Comments
	    

    }
}
