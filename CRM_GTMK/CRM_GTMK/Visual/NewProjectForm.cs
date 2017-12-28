using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_GTMK.Visual
{
	public partial class NewProjectForm : Form
	{
		public NewProjectForm()
		{
			InitializeComponent();
		}

		private void flowLayoutPanel1_DragDrop(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop) && e.Effect == DragDropEffects.Move)
			{
				string[] objects = (string[])e.Data.GetData(DataFormats.FileDrop);
				// В objects хранятся пути к папкам и файлам
				foreach(var obj in objects)
				{
					Label label = new Label();
					label.Text = obj;
					flowLayoutPanel1.Controls.Add(label);
				}
				
			}
		}

		private void flowLayoutPanel1_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				MessageBox.Show("Entered");
				e.Effect = DragDropEffects.Copy;
			}

				
		}

		private void flowLayoutPanel1_DragOver(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop) && e.Effect == DragDropEffects.Move)
			{
				string[] objects = (string[])e.Data.GetData(DataFormats.FileDrop);
				// В objects хранятся пути к папкам и файлам
				foreach (var obj in objects)
				{
					Label label = new Label();
					label.Text = obj;
					flowLayoutPanel1.Controls.Add(label);
				}

			}
		}
	}
}
