using CRM_GTMK.Visual;
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
	public partial class NewProjectSettingsForm : Form
	{
		private NewProjectForm _form;

		public NewProjectSettingsForm(NewProjectForm form)
		{
			_form = form;
			InitializeComponent();
			_form.Visible = false;
		}
	}
}
