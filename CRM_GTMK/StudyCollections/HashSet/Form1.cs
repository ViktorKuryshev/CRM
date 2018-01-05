using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyCollections.HashSet
{
	public partial class Form1 : Form
	{
		public HashSet<Student> students = new HashSet<Student>()//(new List<Students>) позволит перевести в список в хашсет и удалит повторяющиеся элементы
		{
		new Student() {Name = "Sally", Grade = 3 },
		new Student() {Name = "Bob", Grade = 4 },
		new Student() {Name = "Sally", Grade = 2 }
		};

		private SchoolRoll schoolRoll;
		public Form1()
		{
			InitializeComponent();
			foreach(var student in students)
			{
				listBox1.Items.Add(student.Name + " " + student.Grade.ToString());
			}

			schoolRoll = new SchoolRoll();
			schoolRoll.AddStudents(students);

		}

		private void button1_Click(object sender, EventArgs e)
		{
			
			DrawStudents();

		}

		private void DrawStudents()
		{
			listBox1.Items.Clear();
			foreach (var student in schoolRoll.Students)
			{
				listBox1.Items.Add(student.Name + " " + student.Grade.ToString());
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Student newStudent = new Student() { Name = "Joe", Grade = 2 };
			HashSet<Student> inStudents = new HashSet<Student>(schoolRoll.Students);


			inStudents.Add(newStudent);
			schoolRoll.AddStudents(inStudents);

			DrawStudents();
		}
	}
}
