using CRM_GTMK.Model.TestApi;
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
		
		public string ProjectName { get { return projectNameTextBox.Text; } }
		
		public DateTime ProjectDeadline { get { return deadLineDate.Value; } }
		public string ClientName { get { return clientNameBox.Text; } }
		public string SourceLanguage { get { return sourceLanguageBox.Text; } }
		public string TargetLanguage { get { return targetLanguageBox.Text; } }

		private List<string> clientsList = new List<string>()
		{
			"",
			"Андрей",
			"Вася",
			"Коля"
		};

		private List<string> sLangsList = new List<string>()
		{
			"English",
			"Russian",
			"German",
			"French"
		};

		private List<string> tLangsList = new List<string>()
		{
			"English",
			"Russian",
			"German",
			"French"
		};

		BindingSource bs = new BindingSource();

	

		public NewProjectSettingsForm(NewProjectForm form)
		{
			_form = form;

			InitializeComponent();
			bs.DataSource = clientsList;
			clientNameBox.DataSource = bs;

			sourceLanguageBox.DataSource = sLangsList;
			targetLanguageBox.DataSource = tLangsList;
			
			
	
		}

		private void comboBox1_TextUpdate(object sender, EventArgs e)
		{
			string text = clientNameBox.Text;

				List<string> newClientsList = new List<string>();
				foreach (var client in clientsList)
				{
					if (client.Contains(clientNameBox.Text))
					{
						newClientsList.Add(client);
					}
				}
				clientNameBox.DataSource = newClientsList;
			clientNameBox.Text = text;
			clientNameBox.SelectionStart = text.Length;
			/*string text = cb.Text;
			bs.Filter = "Name LIKE '*" + text + "*'"; //это действие изменяет свойство Text, т. е. затирает то что было введено юзером
			cb.Text = text; //тут восстанавливаем последствия предыдущей строки
			cb.SelectionStart = text.Length; */
		}

		private void goOnButton_Click(object sender, EventArgs e)
		{
			
			_form.ShowWorkflowForm();

		}

		private void goBackButton_Click(object sender, EventArgs e)
		{
			this.Visible = false;
			_form.Visible = true;
			
		}
	}
}
