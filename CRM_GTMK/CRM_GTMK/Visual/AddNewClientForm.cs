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
	public partial class AddNewClientForm : Form
	{
		private Controller _controller;
		 
		public AddNewClientForm(Controller controller)
		{
			_controller = controller;
			InitializeComponent();

		}

		private void CompanyActivityLabel_Click(object sender, EventArgs e)
		{

		}

		private void AddNewClientForm_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			_controller.AddClientName(CompanyNameTextBox.Text);
		}
	}
}
