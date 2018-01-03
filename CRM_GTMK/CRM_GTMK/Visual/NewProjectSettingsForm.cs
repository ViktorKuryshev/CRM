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
		private List<string> clientsList = new List<string>()
		{
			"",
			"Андрей",
			"Вася",
			"Коля"
		};

		BindingSource bs = new BindingSource();
	

		public NewProjectSettingsForm()
		{
			InitializeComponent();
			bs.DataSource = clientsList;
			comboBox1.DataSource = bs;
			
			
			
		}


		private void comboBox1_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void comboBox1_TextUpdate(object sender, EventArgs e)
		{
			string text = comboBox1.Text;

				List<string> newClientsList = new List<string>();
				foreach (var client in clientsList)
				{
					if (client.Contains(comboBox1.Text))
					{
						newClientsList.Add(client);
					}
				}
				comboBox1.DataSource = newClientsList;
			comboBox1.Text = text;
			comboBox1.SelectionStart = text.Length;
			/*string text = cb.Text;
			bs.Filter = "Name LIKE '*" + text + "*'"; //это действие изменяет свойство Text, т. е. затирает то что было введено юзером
			cb.Text = text; //тут восстанавливаем последствия предыдущей строки
			cb.SelectionStart = text.Length; */
		}
	}
}
