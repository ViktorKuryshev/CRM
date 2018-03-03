using CRM_GTMK.Control;
using CRM_GTMK.Model;
using CRM_GTMK.Visual.ModifiedComponents;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_GTMK.Visual.MainScreenPanels
{
    public class MyAllProjectsFlowLayoutPanel : FlowLayoutPanel
	{
		public List<ProjectControls> AllProjects { get; set; } = new List<ProjectControls>();
		private MainScreenForm _form;

		public MyAllProjectsFlowLayoutPanel(MainScreenForm form, Controller controller)
		{
			_form = form;

			Controls.Add(new CreateNewProjectButton(form));
            Controls.Add(new RefreshProjectListButton(form, controller, this));
            Controls.Add(new MyOneProjectTableLayoutPanel(form));
			
			FlowDirection = FlowDirection.TopDown;
			Location = new System.Drawing.Point(211, 57);
			Name = "ProjectsFlowLayoutPanel";
			Size = new System.Drawing.Size(1075, 515);
			//TabIndex = 2;

			WrapContents = false;
			AutoScroll = true;
			
			AutoScrollMinSize = new System.Drawing.Size(0, 0);
		}

		public void ShowProjectsList()
		{
			foreach (var project in AllProjects)
			{
				//Рисую панель проекта
				MyOneProjectTableLayoutPanel oneProjectPanel = new MyOneProjectTableLayoutPanel(_form);
				oneProjectPanel.Controls.Clear();
				oneProjectPanel.Controls.Add(project.ShowProjectDetails, 0, 0);
				oneProjectPanel.Controls.Add(project.ProjectName, 1, 0);
				oneProjectPanel.Controls.Add(project.ProjectPogress, 2, 0);
				oneProjectPanel.Controls.Add(project.ProjectDeadLine, 3, 0);
				this.Controls.Add(oneProjectPanel);

				//Добавляю панель меню по проектам
				this.Controls.Add(project.MyProjectMenuPanel);

				foreach (var document in project.AllDocuments)
				{
					//Рисую панель документа
					MyOneDocumentTableLayoutPanel oneDocumentPanel = new MyOneDocumentTableLayoutPanel(_form);
                    oneDocumentPanel.Controls.Add(document.DocumentSelected, 0, 0);
					oneDocumentPanel.Controls.Add(document.DocumentName, 1, 0);
					oneDocumentPanel.Controls.Add(document.DocumentPogress, 2, 0);
					this.Controls.Add(oneDocumentPanel);

					//Добавляю в список панелей
					project.DocumentPanels.Add(oneDocumentPanel);


				}
			}

		}
	}

	public class CreateNewProjectButton : Button
	{
		private MainScreenForm _form;
		public CreateNewProjectButton(MainScreenForm form)
		{
			_form = form;

			this.Text = "Создать проект";
			this.Click += new EventHandler(CreateNewProjectButton_isClicked);
			this.Size = new System.Drawing.Size(175, 27);
			this.BackColor = System.Drawing.Color.Purple;
			this.ForeColor = System.Drawing.Color.White;
		}

		private void CreateNewProjectButton_isClicked(object sender, EventArgs e)
		{
			_form.AddNewProject();		
		}
	}

    public class RefreshProjectListButton : Button
    {
        private MainScreenForm _form;
        private Controller _controller;
        private MyAllProjectsFlowLayoutPanel _panel;

        public RefreshProjectListButton(MainScreenForm form,
                                        Controller controller,
                                        MyAllProjectsFlowLayoutPanel panel)
        {
            _form = form;
            _controller = controller;
            _panel = panel;

            this.Text = "Обновить список";
            this.Click += new EventHandler(RefreshProjectListButton_isClicked);
            this.Size = new System.Drawing.Size(175, 27);
            this.BackColor = System.Drawing.Color.Purple;
            this.ForeColor = System.Drawing.Color.White;
        }

        // Повторно загружаем список проектов с сайта при нажатии на кнопку "Обновить список".
        private async void RefreshProjectListButton_isClicked(object sender, EventArgs e)
        {
            GlobalValues.CurrentProjects.Clear();
            Task<List<ProjectControls>> newTask = new Task<List<ProjectControls>>(_controller.GetProjectsList);
            newTask.Start();
            _panel.AllProjects = await newTask;

            // Неравенство i > 2 не дает пройтись по первым трем элементам списка Controls.
            // Это сделано, потому что первые три элемента это заголовок таблицы и кнопки.
            // Их не нужно удалять из списка. Удалению подлежат элементы, являющиеся проектами.
            for (int i = _panel.Controls.Count - 1; i > 2; i--)
            {
                _panel.Controls.RemoveAt(i);
            }

            _panel.ShowProjectsList();
        }
    }

    public class MyOneProjectTableLayoutPanel : TableLayoutPanel { 
		
		public MyOneProjectTableLayoutPanel(MainScreenForm form) : base()
		{
			
			CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
			ColumnCount = 4;
			ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
			ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
			ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
			Location = new System.Drawing.Point(1, 1);
			Name = "ProjectsTableLayoutPanel";
			RowCount = 1;
			RowStyles.Add(new System.Windows.Forms.RowStyle());
			
			Size = new System.Drawing.Size(1070, 515);
			TabIndex = 2;
				
			//Setting Title Controls
			Controls.Add(new MyTitleElementsLabel("Название"), 1, 0);
			Controls.Add(new MyTitleElementsLabel("Прогресс"), 2, 0);
			Controls.Add(new MyTitleElementsLabel("Дедлайн"), 3, 0);
			AutoSize = true;
			this.Margin = new Padding(1, 1, 1, 1);

		}

	}

	public class MyOneDocumentTableLayoutPanel : TableLayoutPanel
	{

		public MyOneDocumentTableLayoutPanel(MainScreenForm form) : base()
		{

			CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
			ColumnCount = 4;
			ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
			ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
			ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));

			Location = new System.Drawing.Point(1, 1);
			Name = "DocumentsTableLayoutPanel";
			RowCount = 1;
			RowStyles.Add(new System.Windows.Forms.RowStyle());
	
			Size = new System.Drawing.Size(1070, 515);
			TabIndex = 2;
			AutoSize = true;
			this.Margin = new Padding(1, 1, 1, 1);

			Visible = false;

		}
	}

		#region Title elements
		public class MyTitleElementsLabel : Label
	{
		public MyTitleElementsLabel(string text)
		{
			AutoSize = true;

			Name = "TitleElementsTitleLabel";
			Padding = new System.Windows.Forms.Padding(5, 10, 5, 5);

			Text = text;
		}
	}
	#endregion

	public class ProjectControls
	{
		public string Id { get; set; }
		public CheckBox ShowProjectDetails { get; set; } = new CheckBox();
		public Label ProjectName { get; set; } = new Label();
		public ProgressBar ProjectPogress { get; set; } = new ProgressBar();
		public Label ProjectDeadLine { get; set; } = new Label();
		public Button LoadNewFilesButton { get; set; } = new Button();
		public MenuButton GetTranslationButton { get; set; } = new MenuButton();
		public MyProjectMenuPanel MyProjectMenuPanel { get; set; } = new MyProjectMenuPanel();

		public List<DocumentControls> AllDocuments { get; set; } = new List<DocumentControls>();
		public List<MyOneDocumentTableLayoutPanel> DocumentPanels { get; set; } = new List<MyOneDocumentTableLayoutPanel>();

		public ProjectControls(MainScreenForm form, string name, string deadline, string id)
		{
			Id = id;

			ProjectName.AutoSize = true;
			ProjectName.Padding = new Padding(5, 10, 0, 0);
			ProjectName.Text = name;
			ProjectDeadLine.AutoSize = true;
			ProjectDeadLine.Padding = new Padding(5, 10, 0, 0);
			ProjectDeadLine.Text = deadline;


			LoadNewFilesButton = SetNewLoadNewFilesButton();
			MyProjectMenuPanel.Controls.Add(LoadNewFilesButton);
			GetTranslationButton = GetTranslation();
			MyProjectMenuPanel.Controls.Add(GetTranslationButton);

			ShowProjectDetails.CheckedChanged += new System.EventHandler(ShowProjectDetails_CheckedChanged);
		}

		private void ShowProjectDetails_CheckedChanged(object sender, EventArgs e)
		{
			if (ShowProjectDetails.Checked)
			{
				MyProjectMenuPanel.Visible = true;
				foreach(var panel in DocumentPanels)
				{
					panel.Visible = true;
				}
			}
			else
			{
				MyProjectMenuPanel.Visible = false;
				foreach (var panel in DocumentPanels)
				{
					panel.Visible = false;
				}
			}
		}

		private MenuButton GetTranslation()
		{
			MenuButton menuButton1 = new MenuButton();
			menuButton1.Text = "Скачать";
			menuButton1.BackColor = System.Drawing.Color.Green;
			menuButton1.ForeColor = System.Drawing.Color.White;

			menuButton1.Menu = new ContextMenuStrip();
			menuButton1.Menu.Items.Add("Оригинал");
			menuButton1.Menu.Items.Add("Перевод");
			menuButton1.Menu.Items.Add("tmx");
			menuButton1.Menu.Items.Add("Двуязычный doc");

			return menuButton1;
		}
		private Button SetNewLoadNewFilesButton()
		{
			Button button = new Button();
			button.Location = new System.Drawing.Point(4, 4);
			button.Name = "LoadButton";
			button.BackColor = System.Drawing.Color.Green;
			button.ForeColor = System.Drawing.Color.White;

			button.Size = new System.Drawing.Size(75, 23);
			button.TabIndex = 0;
			button.Text = "Загрузить";
			
			return button;
		}

	}

	public class DocumentControls
	{
		public string Id { get; set; }
		public CheckBox DocumentSelected { get; set; } = new CheckBox();
		public Label DocumentName { get; set; } = new Label();
		public ProgressBar DocumentPogress { get; set; } = new ProgressBar();
		

		public DocumentControls(MainScreenForm form, string name, string id)
		{
			Id = id;

			DocumentName.AutoSize = true;
			DocumentName.Padding = new Padding(15, 10, 0, 0);
			DocumentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			DocumentName.Text = name;
			
		}

	}

	public class MyProjectMenuPanel : FlowLayoutPanel
	{
		public MyProjectMenuPanel()
		{
			Location = new System.Drawing.Point(5, 40);
			Name = "MyProjectMenuPanel";
			Size = new System.Drawing.Size(1070, 29);
			TabIndex = 3;
			Visible = false;


		}
		
	}
}
