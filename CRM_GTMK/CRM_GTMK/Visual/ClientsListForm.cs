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
	public partial class ClientsListForm : Form
	{
		public ClientsListForm(string[] clientsInfo)
		{

			InitializeComponent();
			ClientsDataGridView.Rows.Add(clientsInfo);

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
