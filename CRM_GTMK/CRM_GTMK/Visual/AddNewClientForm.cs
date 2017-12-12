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
using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.GeneralContactInfoPanel.PhonesFlowPanel;
using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.GeneralContactInfoPanel.PhonesFlowPanel.OnePhonePanel;

namespace CRM_GTMK.Visual
{
	public partial class AddNewCompanyForm : Form
	{
		private Controller _controller;

		public MyPhonesFlowLayout MyPhonesFlowLayout { get; set; }
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

        public FlowLayoutPanel GetContactPersonFlowLayoutPanel()
        {
            return contactPersonFlowLayoutPanel;
        }

        public FlowLayoutPanel GetGeneralContactFlowLayoutPanel()
        {
            return generalContactFlowLayoutPanel;
        }

        public FlowLayoutPanel GetOneOfficeFlowLayoutPanel()
        {
            return oneOfficeFlowLayoutPanel;
        }

        public Panel GetNewCompanyActionMenuPanel()
        {
            return newCompanyActionMenuPanel;
        }

        public Button GetAddClientDataButton()
        {
            return addClientDataButton;
        }

        public FlowLayoutPanel GetAllOfficesFlowLayoutPanel()
        {
            return allOfficesFlowLayoutPanel;
        }

        #endregion

        private void ResetForms()
		{
			MyPhonesFlowLayout = new MyPhonesFlowLayout(this);
			
			generalContactFlowLayoutPanel.Controls.Remove(phonesFlowLayoutPanel);
			generalContactFlowLayoutPanel.Controls.Add(MyPhonesFlowLayout);
			generalContactFlowLayoutPanel.AutoSize = true;
			oneOfficeFlowLayoutPanel.AutoSize = true;
			allOfficesFlowLayoutPanel.AutoSize = true;
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
			this.Dispose();
		}

        public void AddClientDataButton_Click()
        {
            NewCompanyNameTextBox = companyNameTextBox;
            _controller.SaveNewCompanyData();
            this.Dispose();
        }

        // Здесь заменил метод CreateNewPhonePanel() на создание объекта типа MyPhonePanel.
        private void MorePhonesButton_Click(object sender, EventArgs e)
		{
			phonesFlowLayoutPanel.Controls.Add(new MyPhonePanel(this));
		}

        public void AddOneMorePhonePanel()
        {
            MyPhonesFlowLayout.Add(new MyPhonePanel(this));
        }

        private void PhonePanel_Paint(object sender, PaintEventArgs e)
		{

		}

        /*
		private Panel CreateNewPhonePanel()
		{
			Panel PhonePanel = new Panel();
			PhonePanel.Controls.Add(CreateNewMorePhonesButton());
		    PhonePanel.Controls.Add(CreateNewPhoneTextBox());
		    PhonePanel.Controls.Add(CreatePhoneLabel());
		    PhonePanel.Location = new System.Drawing.Point(3, 3);
		    PhonePanel.Name = "PhonePanel";
		    PhonePanel.Size = new System.Drawing.Size(254, 51);
		    PhonePanel.TabIndex = 9;
		    PhonePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PhonePanel_Paint);
			return PhonePanel;
		}
		
		private Label CreatePhoneLabel()
		{
			Label PhoneLabel = new Label();
			PhoneLabel.AutoSize = true;
			PhoneLabel.Location = new System.Drawing.Point(5, 18);
			PhoneLabel.Name = "PhoneLabel";
			PhoneLabel.Size = new System.Drawing.Size(29, 13);
			PhoneLabel.TabIndex = 6;
			PhoneLabel.Text = "Тел:";
			return PhoneLabel;
		}
		
		// 
		// PhoneTextBox
		// 
		private TextBox CreateNewPhoneTextBox()
		{
			TextBox NewPhoneTextBox = new TextBox();

			NewPhoneTextBox.Location = new System.Drawing.Point(61, 15);
			NewPhoneTextBox.Name = "PhoneTextBox";
			NewPhoneTextBox.Size = new System.Drawing.Size(100, 20);
			NewPhoneTextBox.TabIndex = 7;
			return NewPhoneTextBox;
		}

		private Button CreateNewMorePhonesButton()
		{
			Button NewMorePhonesButton = new Button();
			NewMorePhonesButton.Location = new System.Drawing.Point(187, 12);
			NewMorePhonesButton.Name = "MorePhonesButton";
			NewMorePhonesButton.Size = new System.Drawing.Size(47, 23);
			NewMorePhonesButton.TabIndex = 8;
			NewMorePhonesButton.Text = "Ещё";
			NewMorePhonesButton.UseVisualStyleBackColor = true;
			NewMorePhonesButton.Click += new System.EventHandler(this.MorePhonesButton_Click);
			return NewMorePhonesButton;
		}
        */
		private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

        private void addOfficeButton_Click(object sender, EventArgs e)
        {

        }
    }
}
