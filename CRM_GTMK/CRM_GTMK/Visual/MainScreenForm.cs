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

namespace CRM_GTMK.Visual
{
	public partial class MainScreenForm : Form
	{
		private Controller _controller;

		public MyAllProjectsTableLayoutPanel MyAllProjectsTableLayoutPanel { get; set; }
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

		public void addNewCompanyButton_Click()
		{
			_controller.ShowAddNewCompanyDialog();
		}

		private void addNewCompanyButton_Click(object sender, EventArgs e)
		{
			_controller.ShowAddNewCompanyDialog();
		}

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
		private void SwitchToCompaniesPanel()
		{
			CurrentPanel.Visible = false;
			CurrentPanel = MyClientsPanel;
			CurrentPanel.Visible = true;

		}

		private void SwitchToProjectsPanel()
		{
			CurrentPanel.Visible = false;

			if (MyAllProjectsTableLayoutPanel == null)
			{
				MyAllProjectsTableLayoutPanel = new MyAllProjectsTableLayoutPanel(this);
				this.Controls.Add(MyAllProjectsTableLayoutPanel);
				_controller.SetProjectsList();
				CurrentPanel = MyAllProjectsTableLayoutPanel;
				CurrentPanel.Visible = true;
			}
			else
			{
				CurrentPanel = MyAllProjectsTableLayoutPanel;
				CurrentPanel.Visible = true;
			}
		}
	}
}
