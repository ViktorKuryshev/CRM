using CRM_GTMK.Control;
using CRM_GTMK.Model;
using CRM_GTMK.Model.DataModels;
using CRM_GTMK.Visual.MainScreenPanels;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_GTMK.Visual
{
    public partial class MainScreenForm : Form
	{
		private Controller _controller;

		//Формы диалогов
		public NewProjectForm NewProjectForm { get; set; }
		public NewProjectSettingsForm NewProjectSettingsForm { get; set; }
		public WorkFlowsForm WorkFlowsForm { get; set; }

		public AddNewCompanyForm NewClientForm { get; set; }
		public AddNewContactPersonForm ContactPersonForm { get; set; }

		//Панели 
		public MyAllProjectsFlowLayoutPanel MyAllProjectsFlowLayoutPanel { get; set; }
		public MyClientsPanel MyClientsPanel { get; set; }

		public Panel CurrentPanel { get; set; }

		//Конструктор
		public MainScreenForm(Controller controller)
		{
			_controller = controller;
			InitializeComponent();

			//Заменяем дефолтные данные нашими
			MyClientsPanel = new MyClientsPanel(this);
			this.Controls.Remove(clientsPanel);
			clientsPanel = MyClientsPanel;
			this.Controls.Add(clientsPanel);

			CurrentPanel = clientsPanel;
		}

		//Методы работы с Клиентами
		#region Clients
		/// <summary>
		/// Открываем диалог добавления компании
		/// </summary>
		public void ShowAddNewCompanyDialog()
		{
			NewClientForm = new AddNewCompanyForm(_controller);
			NewClientForm.ShowDialog();

		}

		public void ShowAddNewContactPersonDialog(TableLayoutPanel parentOfficePanel)
		{
            int parentOfficePanelIndex = NewClientForm.OneOfficeContactTableLayoutPanelList
                                        .IndexOf(parentOfficePanel);

            AddNewContactPersonForm newContactPersonForm = 
                new AddNewContactPersonForm(_controller, NewClientForm, parentOfficePanelIndex);

			newContactPersonForm.ShowDialog();
            if (newContactPersonForm.IsDisposed)
                return;
        }

        // Создаем и отображаем новую форму для ввода телефона сотрудника.
		public bool ShowAddNewContactPersonPhoneForm(AddNewContactPersonForm form)
		{
			AddNewContactPersonPhoneForm newContactPersonPhoneForm = new AddNewContactPersonPhoneForm(_controller, form);

            newContactPersonPhoneForm.ShowDialog();
            if (newContactPersonPhoneForm.IsDisposed)
                return false;
            return true;
        }

		

		#endregion

		//Методы работы с Проектом
		#region Project

		/// <summary>
		/// Создаем форму добавления проекта
		/// </summary>
		public void AddNewProject()
		{
			//Такой танец с бубнами нужен чтобы зарегистрировать DragDrop в противном случае Exception
			Thread t = new Thread(new ThreadStart(DragDropValidating));
			t.SetApartmentState(ApartmentState.STA);
			t.Start();
			
		}

		//Инициализируем все формы диалогов создания проекта и показываем первую
		private void DragDropValidating()
		{
			NewProjectForm = new NewProjectForm(this);
			NewProjectSettingsForm = new NewProjectSettingsForm(this);
			WorkFlowsForm = new WorkFlowsForm(this);


		NewProjectForm.ShowDialog();
		}

		//Навигация по формам диалога
		/// <summary>
		/// 
		/// </summary>
		/// <param name="formNumber">1,2,3</param>
		/// <param name="direction">true - вперед, false - назад</param>
		public void SwitchProjectDialogForm(int formNumber, bool direction = false)
		{
			switch(formNumber)
			{
				case 1:
					NewProjectForm.Visible = false;
					NewProjectSettingsForm.ShowDialog();
					//Todo при клике по крестику вылетает эксепшен, нужно обработать закрытие формы.
					break;
				case 2:
					NewProjectSettingsForm.Visible = false;
					if (direction)
					{
						WorkFlowsForm.ShowDialog();
					} else
					{
						NewProjectForm.Visible = true;
					}
					break;
				case 3:
					WorkFlowsForm.Visible = false;
					NewProjectSettingsForm.Visible = true;
					break;

			}

		}

		public void SetProjectData()
		{
			GlobalValues.DocumentsPaths = new string[NewProjectForm.FilesPaths.Length];
			GlobalValues.DocumentsPaths = NewProjectForm.FilesPaths;
			GlobalValues.FocusedProject = new MyProject();

			GlobalValues.FocusedProject.SiteProject.Name = NewProjectSettingsForm.ProjectName;
			GlobalValues.FocusedProject.ProjectStructure = NewProjectForm.FilesOrFolders;
			SendNewProject();
		}

		public void SendNewProject()
		{
			_controller.SendNewProject();
		}

		#endregion

		#region Unused
		private void addNewCompanyButton_Click(object sender, EventArgs e)
		{
			ShowAddNewCompanyDialog();
		}
		#endregion

		//Методы меню главной формы
		#region MainFormMenue
		/// <summary>
		/// Навигация по дереву
		/// </summary>
		private void navigationTreeView_AfterSelect(object sender, TreeViewEventArgs e)
		{
			switch(e.Node.Name)
			{
				case "ProjectsRoot":
					SwitchToProjectsPanel();
					
					break;
				case "CompaniesNode":
					SwitchToCompaniesPanel();
					break;
			}
			
		}

		/// <summary>
		/// Переключение на панель "Компании"
		/// </summary>
		private void SwitchToCompaniesPanel()
		{
			CurrentPanel.Visible = false;
			CurrentPanel = MyClientsPanel;
			CurrentPanel.Visible = true;

		}

		/// <summary>
		/// Переключение на панель "Проекты"
		/// </summary>
		private async Task SwitchToProjectsPanel()
		{
			CurrentPanel.Visible = false;

            if (MyAllProjectsFlowLayoutPanel == null)
            {
                MyAllProjectsFlowLayoutPanel = new MyAllProjectsFlowLayoutPanel(this);
                MyAllProjectsFlowLayoutPanel.SuspendLayout();
                this.Controls.Add(MyAllProjectsFlowLayoutPanel);

                Task<List<ProjectControls>> newTask = new Task<List<ProjectControls>>(_controller.GetProjectsList);
                newTask.Start();

                MyAllProjectsFlowLayoutPanel.AllProjects = await newTask;

                MyAllProjectsFlowLayoutPanel.ShowProjectsList();

                CurrentPanel = MyAllProjectsFlowLayoutPanel;
                CurrentPanel.Visible = true;

                MyAllProjectsFlowLayoutPanel.ResumeLayout(false);
                MyAllProjectsFlowLayoutPanel.PerformLayout();
            }
            else
            {
                CurrentPanel = MyAllProjectsFlowLayoutPanel;
                CurrentPanel.Visible = true;
            }

        }
		#endregion


	}
}
