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

		public MyFilesAndFoldersFlowLayout MyFilesAndFoldersFlowLayout { get; set; }

		public List<DirectoryOrFile> DirectoryOrFiles { get; set; } = new List<DirectoryOrFile>();

		public NewProjectForm()
		{
			InitializeComponent();

			//Добавляем нашу флоупанель
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
				CreateListOfDirectoriesAndFiles(fielNames, DirectoryOrFiles);

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
				CreateListOfDirectoriesAndFiles(foldersAndFiles, DirectoryOrFiles);

			}

		}
		/// <summary>
		/// Создаем список Папок и файлов используя рекурсию. Добавляем их в форму.
		/// </summary>
		public void CreateListOfDirectoriesAndFiles(List<string> paths, List<DirectoryOrFile> directoryOrFiles)
		{

			foreach (var path in paths)
			{
				//Если файл то сразу в список
				if (System.IO.File.Exists(path))
				{
					var file = new DirectoryOrFile();
					file.Path = path;
					file.Name = Path.GetFileName(path);
					file.isDirectory = false;
					directoryOrFiles.Add(file);
				}
				//Если папка, то добавляем список, получаем список директорий и файлов в ней и передаем его рекурсивно в этот же метод
				else if (System.IO.Directory.Exists(path))
				{

					var folder = new DirectoryOrFile();
					folder.Path = path;
					folder.Name = Path.GetFileName(path);
					folder.isDirectory = true;
					directoryOrFiles.Add(folder);

					List<string> newDirectories = Directory.GetDirectories(path).ToList();
					List<string> newFiles = Directory.GetFiles(path).ToList();
					List<string> newPaths = new List<string>();
					foreach (string directory in newDirectories) newPaths.Add(directory);
					foreach (string file in newFiles) newPaths.Add(file);
					Console.WriteLine("Это папка");
					CreateListOfDirectoriesAndFiles(newPaths, folder.DirectoryOrFiles);
				}

			}

		}

		/// <summary>
		/// Метод для внешнего вызова рисования файлов забирает список из формы и отрисовывает
		/// </summary>
		public void DrawDirectoriesAndFiles()
		{
			//Убираем ранее добавленные панели, список будет выведен заново
			MyFilesAndFoldersFlowLayout.FiledAndFolders = new List<FilesContainterPanel>();
			//Убираем ранее выведенные панели, список будет выведен заново
			MyFilesAndFoldersFlowLayout.Controls.Clear();
			DrawDirectoriesAndFiles(DirectoryOrFiles);
		}

		/// <summary>
		/// Отрисовывает список папок и файлов. Добавляет в панель ссылку на каждый элемент списка.
		/// Добавляем панели последовательно в список. Дальше буду обрабатывать его чтобы не делать миллион рекурсий.
		/// </summary>
		/// <param name="DirectoryOrFiles"></param>
		private void DrawDirectoriesAndFiles(List<DirectoryOrFile> DirectoryOrFiles)
		{
			//перебираем все файлы и папки в списке
			foreach (var directoryOrFile in DirectoryOrFiles)
			{
				//Если файл то сразу выводим на панель
				if (!directoryOrFile.isDirectory)
				{
					FilesContainterPanel fileContainerPanel = new FilesContainterPanel(directoryOrFile);
					if(!directoryOrFile.isShown && !showDeletedCheckBox.Checked)
					{
						fileContainerPanel.Visible = false;
					}
					else
					{
						fileContainerPanel.Visible = true;
					}
					MyFilesAndFoldersFlowLayout.Controls.Add(fileContainerPanel);
					MyFilesAndFoldersFlowLayout.FiledAndFolders.Add(fileContainerPanel);
				}
				//Если папка то выводим ее на панель и рекурсивно вызываем метод повторно для отрисовки содержащихся
				//в ней файлов или папок
				else if (directoryOrFile.isDirectory)
				{
					FilesContainterPanel fileContainerPanel = new FilesContainterPanel(directoryOrFile);
					if (!directoryOrFile.isShown && !showDeletedCheckBox.Checked || !showFoldersCheckBox.Checked)
					{
						fileContainerPanel.Visible = false;
					}
					else
					{
						fileContainerPanel.Visible = true;
					}
					MyFilesAndFoldersFlowLayout.Controls.Add(fileContainerPanel);
					MyFilesAndFoldersFlowLayout.FiledAndFolders.Add(fileContainerPanel);
					DrawDirectoriesAndFiles(directoryOrFile.DirectoryOrFiles);
				}
			}
		}

		private void showFoldersCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			DrawDirectoriesAndFiles();
		}

		private void showDeletedCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			DrawDirectoriesAndFiles();
		}

		private void NextStepButton_Click(object sender, EventArgs e)
		{
			NewProjectSettingsForm = new NewProjectSettingsForm(this);
			NewProjectSettingsForm.ShowDialog();

		}
	}

	//Класс содежит данные о файле или папке и список файлов или папок если папка.
	public class DirectoryOrFile
	{
		public string Path { get; set; }
		public string Name { get; set; }
		public bool isDirectory { get; set; } = false;
		public bool isShown { get; set; } = true;
		public List<DirectoryOrFile> DirectoryOrFiles { get; set; } = new List<DirectoryOrFile>();
	}

	//Панель для отображения одного файла или папки, позволяет изменять состояния отоборажать или нет 
	//и через ссылку изменяет этот стостояние у класса файла или папки, если файл вычеркнут он не будет в последствии добавляться в проект
	public class FilesContainterPanel : FlowLayoutPanel
	{
		public DirectoryOrFile DirectoryOrFile { get; set; } = new DirectoryOrFile();

		public CheckBox isShown { get; set; }
		public Label FileOrFolder { get; set; }

		//Styles
		Font directoryFont = new Font("Microsoft Sans Serif", 10.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
		Font fileFont = new Font("Microsoft Sans Serif", 9.25F, FontStyle.Italic, GraphicsUnit.Point, ((byte)(204)));

		public FilesContainterPanel(DirectoryOrFile directoryOrFile)
		{
			DirectoryOrFile = directoryOrFile;

			this.AutoSize = true;
			this.FlowDirection = FlowDirection.LeftToRight;

			isShown = new CheckBox();
			isShown.Text = "Убрать";
			isShown.Checked = !DirectoryOrFile.isShown;
			isShown.CheckedChanged += new EventHandler(DoNotShow);
			this.Controls.Add(isShown);
			FileOrFolder = GerFileOrFolderLabel(directoryOrFile.Name, directoryOrFile.isDirectory);
			IsShownStile();
			this.Controls.Add(FileOrFolder);
			
		}

		
		//Оформляем стиль папки или файла
		private Label GerFileOrFolderLabel(string name, bool fileOrFolder)
		{
			Label label = new Label();
			label.BackColor = Color.White;

			if (!fileOrFolder)
			{//Файл
				label.AutoSize = true;
				label.Name = "file";
				label.Text = "  --> " + name;
				label.Font = fileFont;
			}
			else
			{//Папка
				label.AutoSize = true;
				label.Name = "folder";
				label.Text = name;
				label.Font = directoryFont;
			}
			return label;
		}

		//При изменении чекбоса меняем видимость файла и его стиль
		private void DoNotShow(Object sender, EventArgs e)
		{
			IsShownStile();
		}

		//Если галочка стоит то зачеркиваем и не загружаем в СК, если не стоит то все ОК.
		private void IsShownStile()
		{
			if (isShown.Checked)
			{
				FileOrFolder.ForeColor = Color.Gray;
				FileOrFolder.Font = new Font("Microsoft Sans Serif", 10.25F, FontStyle.Strikeout, GraphicsUnit.Point, ((byte)(204)));
				DirectoryOrFile.isShown = false;
			}
			else
			{
				if (FileOrFolder.Name == "file")
				{
					FileOrFolder.ForeColor = Color.DarkBlue;
					FileOrFolder.Font = fileFont;
				}
				else
				{
					FileOrFolder.ForeColor = Color.Purple;
					FileOrFolder.Font = directoryFont;
				}
				DirectoryOrFile.isShown = true;
			}
		}

	}

	//Панель контейнер для отображения всех файлов и папок
	public class MyFilesAndFoldersFlowLayout : FlowLayoutPanel
	{
		private NewProjectForm _form;
		public List<FilesContainterPanel> FiledAndFolders { get; set; } = new List<FilesContainterPanel>();

		public MyFilesAndFoldersFlowLayout(NewProjectForm form)
		{
			_form = form;

			AllowDrop = true;
			BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			Location = new System.Drawing.Point(173, 12);
			Name = "flowLayoutPanel1";
			Size = new System.Drawing.Size(738, 370);
			TabIndex = 0;
			DragDrop += new System.Windows.Forms.DragEventHandler(flowLayoutPanel1_DragDrop);
			DragEnter += new System.Windows.Forms.DragEventHandler(flowLayoutPanel1_DragEnter);

			WrapContents = false; //если не добавить панель расишряется вправо не зависимо от заданного направления
			AutoScroll = true;
		}

		//Без этого метода драг и дроп не работает
		private void flowLayoutPanel1_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				e.Effect = DragDropEffects.Copy;
			}
		}

		//Метод драг и дроп
		private void flowLayoutPanel1_DragDrop(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop) && e.Effect == DragDropEffects.Copy)
			{
				string[] pathsArray = (string[])e.Data.GetData(DataFormats.FileDrop);
				List<string> pathsList = pathsArray.ToList<string>();

				_form.CreateListOfDirectoriesAndFiles(pathsList, _form.DirectoryOrFiles);
				_form.DrawDirectoriesAndFiles();

			}
		}


	}
}
