using RestSharp.Extensions;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace CRM_GTMK.Model
{
    public class Office
    {
        [XmlAttribute]
        public int Id { get; set; }

        //true if a head office, false otherwise 
        [XmlIgnore]
        public bool IsHeadOffice { get; set; }
        [XmlElement(IsNullable = false)]
        public string Country { get; set; }
        [XmlElement(IsNullable = false)]
        public string City { get; set; }
        [XmlElement(IsNullable = false)]
        public string Site { get; set; }
        [XmlElement(IsNullable = false)]
        public string Address { get; set; }
        [XmlArrayItem(ElementName = "Email")]
        public string[] EmailsList { get; set; }
        [XmlArrayItem(ElementName = "OfficePhone")]
        public List<string> OfficePhonesList { get; set; } = new List<string>();
        public List<Person> ContactPersonList { get; set; } = new List<Person>();

        public bool ShouldSerializeOfficePhonesList()
        { return OfficePhonesList.Any(p => p.HasValue()); }
        public bool ShouldSerializeContactPersonList()
        { return ContactPersonList.Any(p => p != null); }
    }
}
