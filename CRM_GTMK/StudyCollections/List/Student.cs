using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCollections
{
	public class Student : IComparable<Student>
	{
		public string Name { get; set; }
		public int Grade { get; set; }

		public int CompareTo(Student other)
		{
			int result = this.Name.CompareTo(other.Name);

			if(result == 0)
			{
				result = this.Grade.CompareTo(other.Grade);
			}

			return result;
		}
	}

}
