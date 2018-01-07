using Newtonsoft.Json;


namespace CRM_GTMK.Model.DataModels
{
	public class Client
	{
		[JsonProperty("id"), JsonIgnore]
		public string Id { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		public Client(
			string id = null,
			string name = null)
		{
			Id = id;
			Name = name;
		}
	}
}
