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

		public List<FileOrFolder> FilesOrFolders { get; set; } = new List<FileOrFolder>();

		public MyFilesAndFoldersFlowLayout MyFilesAndFoldersFlowLayout { get; set; }

		public bool ShowFolders { get; set; }
		public bool ShowDelete { get; set; }

		public NewProjectForm()
		{
			InitializeComponent();

			ShowFolders = showFoldersCheckBox.Checked;
			ShowDelete = showDeleteCheckBox.Checked;

			//Заменяем панель нашей панелью
			MyFilesAndFoldersFlowLayout = new MyFilesAndFoldersFlowLayout(this);
			this.Controls.Remove(flowLayoutPanel1);
			this.Controls.Add(MyFilesAndFoldersFlowLayout);

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
			if (ofd.ShowDialog() == DialogResult.OK)
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


		public void ShowDirectoriesAndFiles(List<string> paths)
		{
			GenerateListOfDirectoriesAndFiles(paths, FilesOrFolders);
			DrawFilesAndFolders();
		}

		public void GenerateListOfDirectoriesAndFiles(List<string> paths, List<FileOrFolder> FilesOrFolders)
		{
			foreach (var path in paths)
			{
				if (System.IO.File.Exists(path))
				{
					FileOrFolder file = new FileOrFolder();
					file.Path = path;
					file.Name = Path.GetFileName(path);
					file.isFolder = false;
					file.isShown = true;
					FilesOrFolders.Add(file);

					/*
					FileOrFolderContainer filePanel = new FileOrFolderContainer(file);
					MyFilesAndFoldersFlowLayout.FilesAndFolders.Add(filePanel);
					MyFilesAndFoldersFlowLayout.Controls.Add(filePanel);
					Console.WriteLine("Это файл");
					*/
				}
				else if (System.IO.Directory.Exists(path))
				{
					FileOrFolder folder = new FileOrFolder();
					folder.Path = path;
					folder.Name = Path.GetFileName(path);
					folder.isFolder = true;
					folder.isShown = true;
					FilesOrFolders.Add(folder);
					/*
					FileOrFolderContainer filePanel = new FileOrFolderContainer(folder);
					MyFilesAndFoldersFlowLayout.FilesAndFolders.Add(filePanel);
					MyFilesAndFoldersFlowLayout.Controls.Add(filePanel);
					*/
					List<string> newDirectories = Directory.GetDirectories(path).ToList();
					List<string> newFiles = Directory.GetFiles(path).ToList();
					List<string> newPaths = new List<string>();
					foreach (string directory in newDirectories) newPaths.Add(directory);
					foreach (string file in newFiles) newPaths.Add(file);
					Console.WriteLine("Это папка");
					GenerateListOfDirectoriesAndFiles(newPaths, folder.FilesOrFolders);
				}
			}
		}

		public void DrawFilesAndFolders()
		{
			MyFilesAndFoldersFlowLayout.Controls.Clear();
			MyFilesAndFoldersFlowLayout.FilesAndFolders = new List<FileOrFolderContainer>();
			DrawFilesAndFolders(FilesOrFolders);
		}

		public void DrawFilesAndFolders(List<FileOrFolder> filesOrFolders)
		{
			foreach(var fileOrFolder in filesOrFolders)
			{
				FileOrFolderContainer filePanel = new FileOrFolderContainer(fileOrFolder, this);
				
				//Если Файл
				if (!fileOrFolder.isFolder)
				{
					if (!ShowDelete && !fileOrFolder.isShown)
					{
						filePanel.Visible = false;
					} else
					{
						filePanel.Visible = true;
					}
						
					MyFilesAndFoldersFlowLayout.FilesAndFolders.Add(filePanel);
					MyFilesAndFoldersFlowLayout.Controls.Add(filePanel);
					
				}
				//Если Папка
				else if (fileOrFolder.isFolder)
				{
					if (!ShowFolders || !ShowDelete && !fileOrFolder.isShown)
					{
						filePanel.Visible = false;
					}
					else
					{
						filePanel.Visible = true;
					}
					
					MyFilesAndFoldersFlowLayout.FilesAndFolders.Add(filePanel);
					MyFilesAndFoldersFlowLayout.Controls.Add(filePanel);
					DrawFilesAndFolders(fileOrFolder.FilesOrFolders);
				}
			}
		}

		private void showFoldersCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			ShowFolders = showFoldersCheckBox.Checked;
			DrawFilesAndFolders();
		}

		private void showDeleteCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			ShowDelete = showDeleteCheckBox.Checked;
			DrawFilesAndFolders();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			new NewProjectSettingsForm().ShowDialog();
		}
	}

	public class FileOrFolder
	{
		public string Path { get; set; }
		public string Name { get; set; }
		public bool isFolder { get; set; }
		public bool isShown { get; set; } = true;
		public List<FileOrFolder> FilesOrFolders { get; set; } = new List<FileOrFolder>();
	}

	public class FileOrFolderContainer : FlowLayoutPanel
	{
		private NewProjectForm _form; 

		public FileOrFolder FileOrFolder { get; set; }

		private CheckBox isShown = new CheckBox();
		private Label fileOrFolderLabel = new Label();

		private Font fileFont = new Font("Microsoft Sans Serif", 9.0F, FontStyle.Italic, GraphicsUnit.Point, ((byte)(204)));
		private Font folderFont = new Font("Microsoft Sans Serif", 10.0F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
		private Font deleteFont = new Font("Microsoft Sans Serif", 9.0F, FontStyle.Strikeout, GraphicsUnit.Point, ((byte)(204)));

		public FileOrFolderContainer(FileOrFolder fileOrFolder, NewProjectForm form)
		{
			_form = form;

			FileOrFolder = fileOrFolder;

			//Установки панели
			AutoSize = true;
			FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
			WrapContents = false;

			//Формируем чек бокс
			isShown.Text = "Убрать";
			isShown.AutoSize = true;
			isShown.Checked = !FileOrFolder.isShown;
			isShown.CheckedChanged += new EventHandler(DeleteFileOrFolder);
			this.Controls.Add(isShown);

			SetFileOrFolderLabelStile();
			this.Controls.Add(fileOrFolderLabel);
		}

		private void DeleteFileOrFolder(object sender, EventArgs e)
		{
			FileOrFolder.isShown = !isShown.Checked;
			SetFileOrFolderLabelStile();
			if(!_form.ShowDelete && !FileOrFolder.isShown)
			{
				this.Visible = false;
			}
		}

		private void SetFileOrFolderLabelStile()
		{
			fileOrFolderLabel.AutoSize = true;
			fileOrFolderLabel.BackColor = Color.White;

			
			if (FileOrFolder.isFolder)
				{
					fileOrFolderLabel.Font = (FileOrFolder.isShown) ? folderFont : deleteFont;
					fileOrFolderLabel.Text = FileOrFolder.Name;
					fileOrFolderLabel.ForeColor = (FileOrFolder.isShown) ? Color.Purple : Color.Gray;
				}
				else
				{
					fileOrFolderLabel.Font = (FileOrFolder.isShown) ? fileFont : deleteFont;
					fileOrFolderLabel.Text = "  --> " + FileOrFolder.Name;
					fileOrFolderLabel.ForeColor = (FileOrFolder.isShown) ? Color.DarkBlue : Color.Gray;
				}
			}

	}

	public class MyFilesAndFoldersFlowLayout : FlowLayoutPanel
	{
		private NewProjectForm _form;

		public List<FileOrFolderContainer> FilesAndFolders { get; set; } = new List<FileOrFolderContainer>();

		public MyFilesAndFoldersFlowLayout(NewProjectForm form)
		{
			_form = form;

			AllowDrop = true;
			BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			Location = new System.Drawing.Point(173, 12);
			Name = "MyFilesAndFoldersFlowLayout";
			Size = new System.Drawing.Size(744, 416);
			TabIndex = 0;
			DragDrop += new DragEventHandler(IsDragDroped);
			DragEnter += new DragEventHandler(IsDragEntered);

			WrapContents = false; //если не добавить панель расишряется вправо не зависимо от заданного направления
			AutoScroll = true;
		}


		//Позволяет использвоать драг и дроп
		private void IsDragEntered(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				e.Effect = DragDropEffects.Copy;
			}
		}

		private void IsDragDroped(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop) && e.Effect == DragDropEffects.Copy)
			{
				string[] pathsArray = (string[])e.Data.GetData(DataFormats.FileDrop);
				List<string> pathsList = pathsArray.ToList<string>();

				_form.ShowDirectoriesAndFiles(pathsList);


			}
		}

	}

}
