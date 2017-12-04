﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_GTMK.Model
{
    class Office
    {
        //true if a head office, false otherwise 
        public bool IsHeadOffice { get; set; }
        public string Country { get; set; }
        public string City { get; set; }

        public string Address { get; set; }
        public string[] Email { get; set; }
        public string[] Phone { get; set; }
        
    }
}