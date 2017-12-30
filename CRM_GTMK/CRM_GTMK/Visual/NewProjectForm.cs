using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
			flowLayoutPanel1
				.WrapContents = false; //если не добавить панель расишряется вправо не зависимо от заданного направления
			flowLayoutPanel1
				.AutoScroll = true;

			this.Controls.Remove(selectFilesButton);
			this.Controls.Add(GetAddFilesButton());
			this.Controls.Add(GetAddFolderButton());

		}

		public Button GetAddFilesButton()
		{
			Button button = new Button();
			button.Location = new System.Drawing.Point(28, 77);
			button.Name = "SelectFilesButton";
			//button.Size = new System.Drawing.Size(81, 23);
			button.AutoSize = true;
			button.TabIndex = 1;
			button.Text = "Добавить файлы";
			button.UseVisualStyleBackColor = true;
			button.Click += new EventHandler(AddFiles);

			return button;
		}

		private void AddFiles(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Multiselect = true;
			if(ofd.ShowDialog() == DialogResult.OK)
			{
				List<string> fielNames = ofd.FileNames.ToList<string>();
				ShowDirectoriesAndFiles(fielNames);
				
			}
			
		}

		public Button GetAddFolderButton()
		{
			Button button = new Button();
			button.Location = new System.Drawing.Point(28, 127);
			button.Name = "SelectFolderButton";
			//button.Size = new System.Drawing.Size(81, 23);
			button.AutoSize = true;
			button.TabIndex = 1;
			button.Text = "Добавить папку";
			button.UseVisualStyleBackColor = true;
			button.Click += new EventHandler(AddFolder);

			return button;
		}

		private void AddFolder(object sender, EventArgs e)
		{
			FolderBrowserDialog fbd = new FolderBrowserDialog();
			
			if (fbd.ShowDialog() == DialogResult.OK)
			{
				List<string> foldersAndFiles = Directory.GetFiles(fbd.SelectedPath).ToList<string>();
				ShowDirectoriesAndFiles(foldersAndFiles);

			}

		}


		private void flowLayoutPanel1_DragDrop(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop) && e.Effect == DragDropEffects.Copy)
			{
				string[] pathsArray = (string[]) e.Data.GetData(DataFormats.FileDrop);
				List<string> pathsList = pathsArray.ToList<string>();
				
				ShowDirectoriesAndFiles(pathsList);


			}
		}

		private void ShowDirectoriesAndFiles(List<string> paths)
		{
			foreach (var path in paths)
			{
				if (System.IO.File.Exists(path))
				{
					Label label = new Label();
					label.AutoSize = true;
					label.Text = Path.GetFileName(path);
					flowLayoutPanel1.Controls.Add(label);
					Console.WriteLine("Это файл");
				}
				else if (System.IO.Directory.Exists(path))
				{
					Label label = new Label();
					label.AutoSize = true;
					label.Text = Path.GetFileName(path);
					flowLayoutPanel1.Controls.Add(label);

					List<string> newDirectories = Directory.GetDirectories(path).ToList();
					List<string> newFiles = Directory.GetFiles(path).ToList();
					List<string> newPaths = new List<string>();
					foreach (string directory in newDirectories) newPaths.Add(directory);
					foreach (string file in newFiles) newPaths.Add(file);
					Console.WriteLine("Это папка");
					ShowDirectoriesAndFiles(newPaths);
				}



			}
		}

		private void flowLayoutPanel1_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				
				e.Effect = DragDropEffects.Copy;
			}

				
		}

		private void flowLayoutPanel1_DragOver(object sender, DragEventArgs e)
		{

		}
	}
}
