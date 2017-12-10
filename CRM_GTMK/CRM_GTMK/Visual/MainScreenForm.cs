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

namespace CRM_GTMK.Visual
{
	public partial class MainScreenForm : Form
	{
		private Controller _controller;
		public MainScreenForm(Controller controller)
		{
			_controller = controller;
			InitializeComponent();
		}

		private void addNewCompanyButton_Click(object sender, EventArgs e)
		{
			_controller.ShowAddNewCompanyDialog();
		}
	}
}
