using Newtonsoft.Json;

namespace CRM_GTMK.Model.DataModels
{
	public class Tmx
	{
		[JsonProperty("tmId")]
		public string TmId { get; set; }

		[JsonProperty("replaceAllContent")]
		public bool ReplaceAllContent { get; set; }

		[JsonProperty("tmxFile")]
		public string TmxFile { get; set; }

		public Tmx(
			string tmId,
			string tmxFile,
			bool replaceAllContent)
		{
			TmId = tmId;
			ReplaceAllContent = replaceAllContent;
			TmxFile = tmxFile;
		}
	}
}
