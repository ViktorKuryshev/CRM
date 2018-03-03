using CRM_GTMK.Model;
using CRM_GTMK.Model.DataModels;
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
		public string ClientNameItem { set  {clientNameBox.Items.Add(value);} }
		public string SourceLanguageItem { set { sourceLanguageBox.Items.Add(value); } }
		public string TargetLanguageItem { set { targetLanguageBox.Items.Add(value); } }


		public NewProjectSettingsForm(MainScreenForm form)
		{
			_form = form;

			InitializeComponent();

			foreach (var clientName in clientsList) ClientNameItem = clientName;

			foreach (var language in DictionaryCollections.Languages.Keys)
			{ 
				sourceLanguageBox.Items.Add(language);
				targetLanguageBox.Items.Add(language);
			}
		}

		private void clientNameBox_TextUpdate(object sender, EventArgs e)
		{
			IEnumerable<string> restClients = from client in clientsList where client.ToLower().Contains(ClientName.ToLower()) select client;

			clientNameBox.Items.Clear();
			foreach (var clientName in restClients) ClientNameItem = clientName;

			clientNameBox.SelectionStart = ClientName.Length;
		}

		private void sourceLanguageBox_TextUpdate(object sender, EventArgs e)
		{
			IEnumerable<string> restLanguages = from language in DictionaryCollections.Languages.Keys where language.ToLower().Contains(SourceLanguage.ToLower()) select language;

			sourceLanguageBox.Items.Clear();
			foreach (var language in restLanguages)
			{
				SourceLanguageItem = language;
			}
			
			sourceLanguageBox.SelectionStart = SourceLanguage.Length;
		}

		private void sourceLanguageBox_SelectedValueChanged(object sender, EventArgs e)
		{
			targetLanguageBox.Items.Clear();
			foreach (var language in DictionaryCollections.Languages.Keys)
			{
				TargetLanguageItem = language;
			}
			targetLanguageBox.Items.Remove(SourceLanguage);
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
