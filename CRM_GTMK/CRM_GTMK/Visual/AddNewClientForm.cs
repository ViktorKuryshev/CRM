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
using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.GeneralContactInfoPanel.OfficeContactInfoPanel;
using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.GeneralContactInfoPanel.PhonesFlowPanel;
using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.GeneralContactInfoPanel.PhonesFlowPanel.OnePhonePanel;

namespace CRM_GTMK.Visual
{
	public partial class AddNewCompanyForm : Form
	{
		private Controller _controller;

		public MyPhonesFlowLayout MyPhonesFlowLayout { get; set; }
		public MyOfficeContactInfoPanel MyOfficeContactInfoPanel { get; set; }
		public TextBox NewCompanyNameTextBox;

		public AddNewCompanyForm(Controller controller)
		{
			_controller = controller;
			InitializeComponent();
			ResetForms();
		}

		#region Getters

		public FlowLayoutPanel GetPhonesFlowLayoutPanel()
		{
			return phonesFlowLayoutPanel;
		}

		public Panel GetPhonePanel()
		{
			return onePhonePanel;
		}

		public TextBox GetPhoneTextBox()
		{
			return phoneTextBox;
		}

		public Button GetMorePhonesButton()
		{
			return morePhonesButton;
		}

		public Label GetPhoneLabel()
		{
			return phoneLabel;
		}

        public Panel GetOfficeContactInfoPanel()
        {
            return officeContactInfoPanel;
        }

        public TextBox GetOfficeAddressTextBox()
        {
            return officeAddressTextBox;
        }

        public Label GetOfficeAddressLabel()
        {
            return officeAddressLabel;
        }

        public TextBox GetOfficeCityTextBox()
        {
            return officeCityTextBox;
        }

        public Label GetOfficeCityLabel()
        {
            return officeCityLabel;
        }

        public TextBox GetOfficeSiteTextBox()
        {
            return officeSiteTextBox;
        }

        public Label GetOfficeSiteLabel()
        {
            return officeSiteLabel;
        }

        public ComboBox GetOfficeCountryComboBox()
        {
            return officeCountryComboBox;
        }

        public Label GetOfficeCountryLabel()
        {
            return officeCountryLabel;
        }

        public Panel GetContactPersonPanel()
        {
            return contactPersonPanel;
        }

        public Label GetContactPersonsLabel()
        {
            return contactPersonsLabel;
        }

        public Button GetContactPersonsButton()
        {
            return contactPersonsButton;
        }

        public TableLayoutPanel GetContactPersonTableLayoutPanel()
        {
            return contactPersonTableLayoutPanel;
        }

        public LinkLabel GetContactPersonLinkLabel()
        {
            return contactPersonLinkLabel;
        }

        public Label GetContactPersonLabel1()
        {
            return contactPersonLabel1;
        }

        public Label GetContactPersonLabel2()
        {
            return contactPersonLabel2;
        }

        #endregion

        private void ResetForms()
		{
			MyPhonesFlowLayout = new MyPhonesFlowLayout(this);
			MyOfficeContactInfoPanel = new MyOfficeContactInfoPanel(this);
			generalContactFlowLayoutPanel.Controls.Remove(officeContactInfoPanel);
			generalContactFlowLayoutPanel.Controls.Add(MyOfficeContactInfoPanel);
			generalContactFlowLayoutPanel.Controls.Remove(phonesFlowLayoutPanel);
			generalContactFlowLayoutPanel.Controls.Add(MyPhonesFlowLayout);
		}

		public void AddOneMorePhonePanel()
		{
			MyPhonesFlowLayout.Add(new MyPhonePanel(this));
		}

		private void CompanyActivityLabel_Click(object sender, EventArgs e)
		{

		}

		private void AddNewClientForm_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			NewCompanyNameTextBox = companyNameTextBox;
		    _controller.SaveNewCompanyData();
			
		}
        // Здесь заменил метод CreateNewPhonePanel() на создание объекта типа MyPhonePanel.
        private void MorePhonesButton_Click(object sender, EventArgs e)
		{
			phonesFlowLayoutPanel.Controls.Add(new MyPhonePanel(this));
		}

		private void PhonePanel_Paint(object sender, PaintEventArgs e)
		{

		}
		
		private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

        private void addOfficeButton_Click(object sender, EventArgs e)
        {

        }
    }
}
