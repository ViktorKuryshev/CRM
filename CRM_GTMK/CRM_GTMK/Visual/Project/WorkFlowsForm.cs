using CRM_GTMK.Model;
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
	public partial class WorkFlowsForm : Form
	{
		private MainScreenForm _form;

		public WorkFlowsForm(MainScreenForm form)
		{
			_form = form;

			InitializeComponent();
		}

		private void goBackButton_Click(object sender, EventArgs e)
		{
			_form.SwitchProjectDialogForm(3);
		}

		private void createProjectButton_Click(object sender, EventArgs e)
		{
			_form.SetProjectData();
		}
	}
}
