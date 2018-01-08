using CRM_GTMK.Visual;
using RestSharp.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        public string Country { get; set; }
        public string City { get; set; }
        public string Site { get; set; }
        public string Address { get; set; }
        public string[] Email { get; set; }
        [XmlArray(ElementName = "OfficePhone")]
        public List<string> OfficePhones { get; set; } = new List<string>();

        public List<Person> ContactPersonList { get; set; } = new List<Person>();

        public bool ShouldSerializeCountry() { return Country.HasValue(); }
        public bool ShouldSerializeCity() { return City.HasValue(); }
        public bool ShouldSerializeSite() { return Site.HasValue(); }
        public bool ShouldSerializeAddress() { return Address.HasValue(); }
        public bool ShouldSerializeOfficePhones()
        { return OfficePhones.Any(p => p.HasValue()); }
        public bool ShouldSerializeContactPersonList()
        { return ContactPersonList.Any(p => p != null); }
    }
}
