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
	public partial class TestFormProject : Form
	{
		public TestFormProject()
		{
			InitializeComponent();
			ResetControls();
			
			


		}
		private void ResetControls()
		{
			menuButton1.Menu = new ContextMenuStrip();
			menuButton1.Menu.Items.Add("Оригинал");
			menuButton1.Menu.Items.Add("Перевод");
			menuButton1.Menu.Items.Add("tmx");
			menuButton1.Menu.Items.Add("Двуязычный doc");
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if(checkBox1.Checked)
			{
				panel1.Visible = true;
			}
			else
			{
				panel1.Visible = false;
			}
			
		}
	}
}
