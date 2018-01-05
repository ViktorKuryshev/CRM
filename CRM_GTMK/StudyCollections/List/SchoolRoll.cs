using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCollections
{
	class SchoolRoll
	{
		private List<Student> _students = new List<Student>();

		public List<Student> Students { get { return _students; } }

		public void AddStudents(IEnumerable<Student> students)
		{
			_students.AddRange(students);
		}
	}
}
