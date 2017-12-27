using System;
using System.Windows.Forms;
using CRM_GTMK.Control;
using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.OneOfficeContactTableLayoutPanel;
using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel;
using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.OneOfficeContactTableLayoutPanel.PhonesFlowPanel.OnePhonePanel;
using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.OneOfficeContactTableLayoutPanel.ContactPersonTablePanel.OneContactPersonTablePanel;
using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.ContactPersonPanel.CommentsContactPersonFlowLayoutPanel.CommentsInnerFlowLayoutPanel.OneCommentPanel;
using System.Collections.Generic;

namespace CRM_GTMK.Visual
{
    public partial class AddNewCompanyForm : Form
	{
		private Controller _controller;

        public MyAllOfficesFlowLayoutPanel MyAllOfficesFlowLayoutPanel { get; set; }
        public int OfficeNumber { get; set; }
        public TextBox NewCompanyNameTextBox;

        public AddNewCompanyForm(Controller controller)
		{
			_controller = controller;
			InitializeComponent();
			resetForms();
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
            return contactPersonFullnameLinkLabel;
        }

        public Label GetContactPersonPositionLabel()
        {
            return contactPersonPositionLabel;
        }

        public Label GetContactPersonPhoneLabel()
        {
            return contactPersonPhoneLabel;
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

        public TableLayoutPanel GetOneOfficeContactTableLayoutPanel()
        {
            return oneOfficeContactTableLayoutPanel;
        }

        public Label GetOfficeNumberLabel()
        {
            return officeNumberLabel;
        }

        public Label GetFullnameLabel()
        {
            return fullnameLabel;
        }

        #endregion

        private void resetForms()
		{
            this.Controls.Remove(allOfficesFlowLayoutPanel);

            MyAllOfficesFlowLayoutPanel myAllOfficesFlowLayoutPanel = new MyAllOfficesFlowLayoutPanel(this);

            this.Controls.Add(myAllOfficesFlowLayoutPanel);
            MyAllOfficesFlowLayoutPanel = myAllOfficesFlowLayoutPanel;
		}

        public void AddClientDataButton_Click()
        {
            NewCompanyNameTextBox = companyNameTextBox;
            _controller.SaveNewCompanyData();
            this.Dispose();
        }

        public void AddOneMorePhonePanel(MyOneOfficeContactTableLayoutPanel myOneOfficeContactTableLayoutPanel)
        {
            myOneOfficeContactTableLayoutPanel
           .MyPhonesFlowLayoutPanel
           .Add(new MyPhonePanel(this, myOneOfficeContactTableLayoutPanel));
        }

        private void addOfficeButton_Click(object sender, EventArgs e)
        {
            OfficeNumber++;
            MyAllOfficesFlowLayoutPanel.Controls.Remove(MyAllOfficesFlowLayoutPanel
                                                       .MyNewCompanyActionMenuPanel);

            MyOneOfficeContactTableLayoutPanel tableLayoutPanel = new MyOneOfficeContactTableLayoutPanel(this);

            MyAllOfficesFlowLayoutPanel.MyOneOfficeContactTableLayoutPanelList.Add(tableLayoutPanel);

            MyAllOfficesFlowLayoutPanel.Controls.Add(tableLayoutPanel);
            MyAllOfficesFlowLayoutPanel.Controls.Add(MyAllOfficesFlowLayoutPanel
                                                    .MyNewCompanyActionMenuPanel);
        }

        public void AddNewContactPerson(MyOneOfficeContactTableLayoutPanel panel)
        {
            _controller.ShowAddNewContactPersonDialog(panel);
        }

        public void AddAndDisplayNewContactPerson(AddNewContactPersonForm form, int officeNumber)
        {
            MyContactPersonFullnameLinkLabel contactPersonFullnameLinkLabel = new MyContactPersonFullnameLinkLabel(this);
            contactPersonFullnameLinkLabel.Text = form.NameContactPerson;
            MyContactPersonPositionLabel contactPersonPositionLabel = new MyContactPersonPositionLabel(this);
            contactPersonPositionLabel.Text = form.PositionContactPerson;
            MyContactPersonPhoneLabel contactPersonPhoneLabel = new MyContactPersonPhoneLabel(this);

            // Здесь нужно определить, какой номер телефона выводить в таблицу.
            contactPersonPhoneLabel.Text = form.MyContactPersonPhoneFormList[0].NewPhoneNumber;

            var myContactPersonTableLayoutPanel = MyAllOfficesFlowLayoutPanel
                                                 .MyOneOfficeContactTableLayoutPanelList[officeNumber]
                                                 .MyContactPersonTableLayoutPanel;

            myContactPersonTableLayoutPanel.Controls.Add(contactPersonFullnameLinkLabel);
            myContactPersonTableLayoutPanel.Controls.Add(contactPersonPositionLabel);
            myContactPersonTableLayoutPanel.Controls.Add(contactPersonPhoneLabel);
        }
    }
}
