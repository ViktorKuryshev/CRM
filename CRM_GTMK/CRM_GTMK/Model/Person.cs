using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_GTMK.Model
{
    public class Person
    {
        //Todo person Image

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public bool IsMale { get; set; }

        public string BirthDate { get; set; }

        public string[] Email { get; set; }
        public string Address { get; set; }
        public List<PersonPhoneData> PersonPhoneDataList { get; set; } = new List<PersonPhoneData>();
    }

    public class PersonPhoneData
    {
        public string PhoneType;
        public string PhoneNumber;
        public string PhoneComment;
    }
}
