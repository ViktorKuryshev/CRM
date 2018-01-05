using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyCollections
{
	public partial class Form1 : Form
	{
		public List<Student> students = new List<Student>()
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
			schoolRoll.Students.Sort();
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

			int index = schoolRoll.Students.BinarySearch(newStudent);

			if(index < 0)
			{
				schoolRoll.Students.Insert(~index, newStudent);
			}

			DrawStudents();
		}
	}
}
