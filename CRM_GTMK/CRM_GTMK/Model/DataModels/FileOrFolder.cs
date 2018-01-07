using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_GTMK.Model.DataModels
{
	public class FileOrFolder
	{
		public string Path { get; set; }
		public string Name { get; set; }
		public bool isFolder { get; set; }
		public bool isShown { get; set; } = true;
		public List<FileOrFolder> FilesOrFolders { get; set; } = new List<FileOrFolder>();
	}
}
