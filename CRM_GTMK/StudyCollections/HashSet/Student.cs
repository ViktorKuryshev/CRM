using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCollections.HashSet
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

		public override int GetHashCode()
		{
			return Name.GetHashCode() + Grade.GetHashCode();
		}

		public override bool Equals(object obj)
		{
			Student that = obj as Student;
			if(that == null)
			{
				return false;
			}
			return this.Name == that.Name && this.Grade == that.Grade;
		}
	}

}
