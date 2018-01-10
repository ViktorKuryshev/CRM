using RestSharp.Extensions;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace CRM_GTMK.Model
{
    public class Person
    {
        //Todo person Image

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        [XmlAttribute]
        public int Id { get; set; }
        public string Position { get; set; }
        [XmlIgnore]
        public bool IsMale { get; set; }

        public string BirthDate { get; set; }
        [XmlArrayItem(ElementName = "Email")]
        public string[] EmailsList { get; set; }
        public string Address { get; set; }
        
        public List<PersonPhoneData> PersonPhonesList { get; set; } = new List<PersonPhoneData>();
        public List<PersonComment> PersonCommentList { get; set; } = new List<PersonComment>();

        public bool ShouldSerializeMiddleName() { return MiddleName.HasValue(); }
        public bool ShouldSerializePersonCommentList()
        { return PersonCommentList.Count != 0; }
    }

    public class PersonPhoneData
    {
        [XmlAttribute]
        public string PhoneType { get; set; }
        public string PhoneNumber { get; set; }
        public string PhoneComment { get; set; }

        public bool ShouldSerializePhoneComment() { return PhoneComment.HasValue(); }
    }

    public class PersonComment
    {
        public string Date { get; set; }
        public string Comment { get; set; }

        public bool ShouldSerializeComment() { return Comment.HasValue(); }
    }
}
