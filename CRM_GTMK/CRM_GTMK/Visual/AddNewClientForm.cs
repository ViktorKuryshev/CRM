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
using CRM_GTMK.Visual.Controls;

namespace CRM_GTMK.Visual
{
	public partial class AddNewClientForm : Form
	{
		private Controller _controller;

		public MyOfficesFlowLayout MyOfficesFlowLayout;
		 
		public AddNewClientForm(Controller controller)
		{
			_controller = controller;
			InitializeComponent();
			ResetForm();

		}

		public TextBox GetCompanyNameTextBox() { return companyNameTextBox; }

		#region Predefined controls

		private void CompanyActivityLabel_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			
			/*
			string[] clientInfo =
			{
				companyNameTextBox.Text,
				companySiteTextBox.Text
			};
			_controller.AddClientName(clientInfo);
			*/
		}

		private void MorePhonesButton_Click(object sender, EventArgs e)
		{
			phonesFlowLayoutPanel.Controls.Add(CreateNewPhonePanel());
		}

		private void PhonePanel_Paint(object sender, PaintEventArgs e)
		{

		}

		#endregion

		private void ResetForm()
		{
			MyOfficesFlowLayout = new MyOfficesFlowLayout(_controller);

			this.Controls.Remove(officesFlowLayoutPanel);
			this.Controls.Add(MyOfficesFlowLayout); 
			


		}

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

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{

		}
	}
	
}
