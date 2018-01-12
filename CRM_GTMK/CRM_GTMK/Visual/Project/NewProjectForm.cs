using CRM_GTMK.Model;
using CRM_GTMK.Model.DataModels;
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

		public NewProjectSettingsForm NewProjectSettingsForm { get; set; }
		public WorkFlowsForm WorkFlowsForm { get; set; }

		//Древовидный список для отрисовки наполнения данными
		public List<FileOrFolder> FilesOrFolders { get; set; } = new List<FileOrFolder>();
		//Последовательный список для отрисовки и возврата
		public List<FileOrFolderContainer> FilesAndFoldersPlainList { get; set; } = new List<FileOrFolderContainer>();

		public string[] FilesPaths
		{
			get
			{
				List<string> result = new List<string>();
				foreach (var container in FilesAndFoldersPlainList)
				{
					if (!container.FileOrFolder.isFolder && container.FileOrFolder.isShown)
					{
						result.Add(container.FileOrFolder.Path);
					}
				}
				return result.ToArray();
			}
		}

		private MainScreenForm _form;

		public bool ShowFolders { get; set; }
		public bool ShowDelete { get; set; }

		//Конструктов
		public NewProjectForm(MainScreenForm form)
		{
			_form = form;

			InitializeComponent();

			ShowFolders = showFoldersCheckBox.Checked;
			ShowDelete = showDeleteCheckBox.Checked;

			filesLayoutPanel.WrapContents = false;


			this.Controls.Remove(selectFilesButton);
			this.Controls.Add(GetAddFilesButton());
			this.Controls.Add(GetAddFolderButton());

		}

		//Кнопки
		#region Buttons

		//Кнопка добавления файлов
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

		//EventHandler добавления файлов
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

		//Кнопка добавления папок
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

		//EventHandler добавления папок
		private void AddFolder(object sender, EventArgs e)
		{
			FolderBrowserDialog fbd = new FolderBrowserDialog();

			if (fbd.ShowDialog() == DialogResult.OK)
			{
				List<string> foldersAndFiles = Directory.GetFiles(fbd.SelectedPath).ToList<string>();
				ShowDirectoriesAndFiles(foldersAndFiles);

			}

		}
		#endregion

		//Создание структуры и отрисовка папко и файлов
		#region FilesAndFolders structuring and drawing
		public void ShowDirectoriesAndFiles(List<string> paths)
		{
			GenerateListOfDirectoriesAndFiles(paths, FilesOrFolders);
			DrawFilesAndFolders();
		}

		//Формируем дерево файлов
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

				}
				else if (System.IO.Directory.Exists(path))
				{
					FileOrFolder folder = new FileOrFolder();
					folder.Path = path;
					folder.Name = Path.GetFileName(path);
					folder.isFolder = true;
					folder.isShown = true;
					FilesOrFolders.Add(folder);

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
			filesLayoutPanel.Controls.Clear();
			FilesAndFoldersPlainList = new List<FileOrFolderContainer>();
			DrawFilesAndFolders(FilesOrFolders);
		}

		//Отрисовываем файлы и папки формируем линейный список файлов
		public void DrawFilesAndFolders(List<FileOrFolder> filesOrFolders)
		{
			foreach (var fileOrFolder in filesOrFolders)
			{
				FileOrFolderContainer filePanel = new FileOrFolderContainer(fileOrFolder, this);

				//Если Файл
				if (!fileOrFolder.isFolder)
				{
					if (!ShowDelete && !fileOrFolder.isShown)
					{
						filePanel.Visible = false;
					}
					else
					{
						filePanel.Visible = true;
					}

					FilesAndFoldersPlainList.Add(filePanel);
					filesLayoutPanel.Controls.Add(filePanel);

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

					FilesAndFoldersPlainList.Add(filePanel);
					filesLayoutPanel.Controls.Add(filePanel);
					DrawFilesAndFolders(fileOrFolder.FilesOrFolders);
				}
			}
		}

		#endregion

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

		//Перейти в следующую форму
		private void goOnButton_Click(object sender, EventArgs e)
		{
			_form.SwitchProjectDialogForm(1, true);
		}
		


		public void SetProjectData()
		{
			GlobalValues.DocumentsPaths = new string[FilesPaths.Count()];
			GlobalValues.DocumentsPaths = FilesPaths;
			GlobalValues.FocusedProject = new MyProject();

			GlobalValues.FocusedProject.SiteProject.Name = NewProjectSettingsForm.ProjectName;
			GlobalValues.FocusedProject.ProjectStructure = FilesOrFolders;
			_form.SendNewProject();
		}

		//Позволяет использвоать драг и дроп
		private void filesLayoutPanel_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				e.Effect = DragDropEffects.Copy;
			}
		}

		//Получаем сброшенные файлы и передаем их пути на обработку
		private void filesLayoutPanel_DragDrop(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop) && e.Effect == DragDropEffects.Copy)
			{
				string[] pathsArray = (string[])e.Data.GetData(DataFormats.FileDrop);
				List<string> pathsList = pathsArray.ToList<string>();

				ShowDirectoriesAndFiles(pathsList);

			}
		}

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

		//Изменить стиль и отображение при удалении папки или файла
		private void DeleteFileOrFolder(object sender, EventArgs e)
		{
			FileOrFolder.isShown = !isShown.Checked;
			SetFileOrFolderLabelStile();
			if (!_form.ShowDelete && !FileOrFolder.isShown)
			{
				this.Visible = false;
			}
		}

		//Устанавливаем стиль отображения в зависимости от того папка или файл и вычеркнута или нет
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

}
