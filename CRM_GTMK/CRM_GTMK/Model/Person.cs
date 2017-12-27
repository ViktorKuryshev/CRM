using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.ContactPersonPanel.CommentsContactPersonFlowLayoutPanel.CommentsInnerFlowLayoutPanel.OneCommentPanel;
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
        public int Id { get; set; }
        public string Position { get; set; }

        public bool IsMale { get; set; }

        public string BirthDate { get; set; }

        public string[] Email { get; set; }
        public string Address { get; set; }
        public List<PersonPhoneData> PersonPhonesList { get; set; } = new List<PersonPhoneData>();
        public List<PersonComment> PersonCommentList { get; set; } = new List<PersonComment>();
    }

    public class PersonPhoneData
    {
        public string PhoneType { get; set; }
        public string PhoneNumber { get; set; }
        public string PhoneComment { get; set; }
    }

    public class PersonComment
    {
        public string Date { get; set; }
        public string Comment { get; set; }
    }
}
