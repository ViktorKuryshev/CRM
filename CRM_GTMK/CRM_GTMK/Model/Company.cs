﻿using System.Collections.Generic;

namespace CRM_GTMK.Model
{
    public class Company
	{
		public int Id { get; set; }

		public string[] Fields { get; set; }
		public string Name { get; set; }
		public string Sourse { get; set; }
		public string[] WebSites { get; set; }

		public List<Office> Offices { get; set; } = new List<Office>();



		//Todo Comments

		

	}
}
