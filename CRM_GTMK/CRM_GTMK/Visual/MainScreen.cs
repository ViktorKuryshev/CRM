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
	public partial class MainScreen : Form
	{
		public MainScreen()
		{
			InitializeComponent();
		}

		private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
		{
			if (e.Node.Name.Equals("CompaniesNode"))
			{
				MessageBox.Show("Мы выбрали" + e.Node.Name);
			}
		}
	}
}
