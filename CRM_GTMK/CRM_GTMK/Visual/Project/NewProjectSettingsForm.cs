using CRM_GTMK.Model;
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
		private MainScreenForm _form;
		
		public string ProjectName { get { return projectNameTextBox.Text; } }
		
		public DateTime ProjectDeadline { get { return deadLineDate.Value; } }
		public string ClientName { get { return clientNameBox.Text; } }
		public string SourceLanguage { get { return sourceLanguageBox.Text; } }
		public string TargetLanguage { get { return targetLanguageBox.Text; } }
		public string ClientNameItem { set
			{
				clientNameBox.Items.Add(value);
			} }

		

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

	

		public NewProjectSettingsForm(MainScreenForm form)
		{
			_form = form;

			InitializeComponent();

			foreach (var clientName in clientsList) ClientNameItem = clientName;

			sourceLanguageBox.DataSource = sLangsList;
			targetLanguageBox.DataSource = tLangsList;
			
			
	
		}

		private void comboBox1_TextUpdate(object sender, EventArgs e)
		{
			string text = clientNameBox.Text;

			IEnumerable<string> restClients = from client in clientsList where client.ToLower().Contains(text.ToLower()) select client;

			clientNameBox.Items.Clear();
			foreach(var clientName in restClients)  ClientNameItem = clientName;

			clientNameBox.SelectionStart = text.Length;

			//	List<string> newClientsList = new List<string>();
			//	foreach (var client in clientsList)
			//	{
			//		if (client.Contains(clientNameBox.Text))
			//		{
			//			newClientsList.Add(client);
			//		}
			//	}
			//	clientNameBox.DataSource = newClientsList;
			//clientNameBox.Text = text;
			//clientNameBox.SelectionStart = text.Length;
			/*string text = cb.Text;
			bs.Filter = "Name LIKE '*" + text + "*'"; //это действие изменяет свойство Text, т. е. затирает то что было введено юзером
			cb.Text = text; //тут восстанавливаем последствия предыдущей строки
			cb.SelectionStart = text.Length; */
		}

		private void goOnButton_Click(object sender, EventArgs e)
		{
			
			_form.SwitchProjectDialogForm(2, true);

		}

		private void goBackButton_Click(object sender, EventArgs e)
		{
			_form.SwitchProjectDialogForm(2, false);

		}

		private List<string> clientsList = new List<string>()
		{
			"ООО Арсенал-комплект",
			"ПК Спектр Плюс",
			"ООО Рускана Инжиниринг",

			"ОАО Кувандыкский завод КПО \"Долина\"",
			"ООО ETA Technology Pvt. - представительство в России",
			"ООО СтанТех-М",
			"ООО Промтехноснаб",

			"ООО «ТД «ХимСтальКомплект»",

			"ООО Компания Ливил - Профилегибочное оборудование",

			"ООО БашПромТоргИндустрия",
		};


	}
}
