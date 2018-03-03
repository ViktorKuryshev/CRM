using System.Collections.Generic;
using System.Xml.Serialization;

namespace CRM_GTMK.Model
{
    public class Company
	{
        [XmlAttribute]
        public int Id { get; set; }

		public string[] Fields { get; set; }
        [XmlAttribute]
        public string Name { get; set; }
		public string Sourse { get; set; }
		public string[] WebSites { get; set; }

		public List<Office> Offices { get; set; } = new List<Office>();

        public bool ShouldSerializeOffices()
        { return Offices.Count != 0; }

        //Todo Comments
    }


    public class Companies
    {
        [XmlElement("Company")]
        public List<Company> companyList { get; set; }
    }
}
