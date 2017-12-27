using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRM_GTMK.Control;
using CRM_GTMK.Visual.MainScreenPanels;
using System.Threading;
using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.OneOfficeContactTableLayoutPanel;

namespace CRM_GTMK.Visual
{
	public partial class MainScreenForm : Form
	{
		private Controller _controller;

		//Формы диалогов
		public NewProjectForm NewProjectForm { get; set; }
        public AddNewCompanyForm NewClientForm { get; set; }
        public AddNewContactPersonForm ContactPersonForm { get; set; }

        //Панели 
        public MyAllProjectsFlowLayoutPanel MyAllProjectsFlowLayoutPanel { get; set; }
		public MyClientsPanel MyClientsPanel { get; set; }

		public Panel CurrentPanel { get; set; }

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

		/// <summary>
		/// Открываем диалог добавления компании
		/// </summary>
		public void ShowAddNewCompanyDialog()
		{
            NewClientForm = new AddNewCompanyForm(_controller);
            NewClientForm.ShowDialog();

		}

        public void ShowAddNewContactPersonDialog(MyOneOfficeContactTableLayoutPanel panel)
        {
            AddNewContactPersonForm newContactPersonForm = new AddNewContactPersonForm(_controller,
                                                            panel.MyOfficeNumberLabel.OfficeNumber,
                                                            NewClientForm);

            panel.MyContactPersonFormList.Add(newContactPersonForm);
            newContactPersonForm.ShowDialog();
        }

        public void ShowAddNewContactPersonPhoneForm(AddNewContactPersonForm form)
        {
            AddNewContactPersonPhoneForm newContactPersonPhoneForm = new AddNewContactPersonPhoneForm(_controller, form);
            form.MyContactPersonPhoneFormList.Add(newContactPersonPhoneForm);
            newContactPersonPhoneForm.ShowDialog();
        }


        #region NewProjectInicialize
        /// <summary>
        /// Создаем форму добавления проекта
        /// </summary>
        public void AddNewProject()
		{
			//Такой тане с бубнами нужен чтобы зарегистрировать DragDrop в противном случае Exception
			Thread t = new Thread(new ThreadStart(DragDropValidating));
			t.SetApartmentState(ApartmentState.STA);
			t.Start();
			
		}

		private void DragDropValidating()
		{
			NewProjectForm = new NewProjectForm();
			NewProjectForm.ShowDialog();
		}
		#endregion

		#region Unused
		private void addNewCompanyButton_Click(object sender, EventArgs e)
		{
			ShowAddNewCompanyDialog();
		}
		#endregion

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
		private void SwitchToProjectsPanel()
		{
			CurrentPanel.Visible = false;

			if (MyAllProjectsFlowLayoutPanel == null)
			{
				MyAllProjectsFlowLayoutPanel = new MyAllProjectsFlowLayoutPanel(this);
				MyAllProjectsFlowLayoutPanel.SuspendLayout();
				this.Controls.Add(MyAllProjectsFlowLayoutPanel);

				MyAllProjectsFlowLayoutPanel.AllProjects = _controller.GetProjectsList();

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
			

		
	}
}
