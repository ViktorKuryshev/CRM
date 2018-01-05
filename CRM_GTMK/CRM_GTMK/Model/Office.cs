using CRM_GTMK.Visual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_GTMK.Model
{
    public class Office
    {
        public int Id { get; set; }

        //true if a head office, false otherwise 
        public bool IsHeadOffice { get; set; }
        public string Country { get; set; }
        public string City { get; set; }

        public string Site { get; set; }
        public string Address { get; set; }
        public string[] Email { get; set; }
        public List<string> Phones { get; set; } = new List<string>();

        public List<Person> ContactPersonList { get; set; } = new List<Person>();
    }
}
