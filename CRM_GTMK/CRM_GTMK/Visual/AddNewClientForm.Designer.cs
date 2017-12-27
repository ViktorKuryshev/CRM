namespace CRM_GTMK.Visual
{
	partial class AddNewCompanyForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.companyNameTextBox = new System.Windows.Forms.TextBox();
			this.companyNameLabel = new System.Windows.Forms.Label();
			this.addClientDataButton = new System.Windows.Forms.Button();
			this.officeSiteLabel = new System.Windows.Forms.Label();
			this.officeSiteTextBox = new System.Windows.Forms.TextBox();
			this.officeContactInfoPanel = new System.Windows.Forms.Panel();
			this.officeAddressTextBox = new System.Windows.Forms.TextBox();
			this.officeAddressLabel = new System.Windows.Forms.Label();
			this.officeCityTextBox = new System.Windows.Forms.TextBox();
			this.officeCityLabel = new System.Windows.Forms.Label();
			this.officeCountryComboBox = new System.Windows.Forms.ComboBox();
			this.officeCountryLabel = new System.Windows.Forms.Label();
			this.addOfficeButton = new System.Windows.Forms.Button();
			this.contactPersonTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.contactPersonLabel1 = new System.Windows.Forms.Label();
			this.contactPersonLabel2 = new System.Windows.Forms.Label();
			this.contactPersonLinkLabel = new System.Windows.Forms.LinkLabel();
			this.contactPersonPanel = new System.Windows.Forms.Panel();
			this.contactPersonsButton = new System.Windows.Forms.Button();
			this.contactPersonsLabel = new System.Windows.Forms.Label();
			this.allOfficesFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.oneOfficeContactTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.phonesFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.onePhonePanel = new System.Windows.Forms.Panel();
			this.morePhonesButton = new System.Windows.Forms.Button();
			this.phoneTextBox = new System.Windows.Forms.TextBox();
			this.phoneLabel = new System.Windows.Forms.Label();
			this.officeNumberLabel = new System.Windows.Forms.Label();
			this.newCompanyActionMenuPanel = new System.Windows.Forms.Panel();
			this.officeContactInfoPanel.SuspendLayout();
			this.contactPersonTableLayoutPanel.SuspendLayout();
			this.contactPersonPanel.SuspendLayout();
			this.allOfficesFlowLayoutPanel.SuspendLayout();
			this.oneOfficeContactTableLayoutPanel.SuspendLayout();
			this.phonesFlowLayoutPanel.SuspendLayout();
			this.onePhonePanel.SuspendLayout();
			this.newCompanyActionMenuPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// companyNameTextBox
			// 
			this.companyNameTextBox.Location = new System.Drawing.Point(324, 17);
			this.companyNameTextBox.Name = "companyNameTextBox";
			this.companyNameTextBox.Size = new System.Drawing.Size(165, 20);
			this.companyNameTextBox.TabIndex = 0;
			// 
			// companyNameLabel
			// 
			this.companyNameLabel.AutoSize = true;
			this.companyNameLabel.Location = new System.Drawing.Point(186, 20);
			this.companyNameLabel.Name = "companyNameLabel";
			this.companyNameLabel.Size = new System.Drawing.Size(113, 13);
			this.companyNameLabel.TabIndex = 1;
			this.companyNameLabel.Text = "Название компании:";
			// 
			// addClientDataButton
			// 
			this.addClientDataButton.Location = new System.Drawing.Point(349, 12);
			this.addClientDataButton.Name = "addClientDataButton";
			this.addClientDataButton.Size = new System.Drawing.Size(75, 35);
			this.addClientDataButton.TabIndex = 3;
			this.addClientDataButton.Text = "Сохранить данные";
			this.addClientDataButton.UseVisualStyleBackColor = true;
			this.addClientDataButton.Click += new System.EventHandler(this.button1_Click);
			// 
			// officeSiteLabel
			// 
			this.officeSiteLabel.AutoSize = true;
			this.officeSiteLabel.Location = new System.Drawing.Point(38, 121);
			this.officeSiteLabel.Name = "officeSiteLabel";
			this.officeSiteLabel.Size = new System.Drawing.Size(34, 13);
			this.officeSiteLabel.TabIndex = 4;
			this.officeSiteLabel.Text = "Сайт:";
			// 
			// officeSiteTextBox
			// 
			this.officeSiteTextBox.Location = new System.Drawing.Point(101, 118);
			this.officeSiteTextBox.Name = "officeSiteTextBox";
			this.officeSiteTextBox.Size = new System.Drawing.Size(161, 20);
			this.officeSiteTextBox.TabIndex = 5;
			// 
			// officeContactInfoPanel
			// 
			this.officeContactInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.officeContactInfoPanel.Controls.Add(this.officeAddressTextBox);
			this.officeContactInfoPanel.Controls.Add(this.officeAddressLabel);
			this.officeContactInfoPanel.Controls.Add(this.officeCityTextBox);
			this.officeContactInfoPanel.Controls.Add(this.officeSiteTextBox);
			this.officeContactInfoPanel.Controls.Add(this.officeCityLabel);
			this.officeContactInfoPanel.Controls.Add(this.officeSiteLabel);
			this.officeContactInfoPanel.Controls.Add(this.officeCountryComboBox);
			this.officeContactInfoPanel.Controls.Add(this.officeCountryLabel);
			this.officeContactInfoPanel.Location = new System.Drawing.Point(3, 26);
			this.officeContactInfoPanel.Name = "officeContactInfoPanel";
			this.oneOfficeContactTableLayoutPanel.SetRowSpan(this.officeContactInfoPanel, 2);
			this.officeContactInfoPanel.Size = new System.Drawing.Size(335, 154);
			this.officeContactInfoPanel.TabIndex = 6;
			// 
			// officeAddressTextBox
			// 
			this.officeAddressTextBox.Location = new System.Drawing.Point(101, 83);
			this.officeAddressTextBox.Name = "officeAddressTextBox";
			this.officeAddressTextBox.Size = new System.Drawing.Size(161, 20);
			this.officeAddressTextBox.TabIndex = 5;
			// 
			// officeAddressLabel
			// 
			this.officeAddressLabel.AutoSize = true;
			this.officeAddressLabel.Location = new System.Drawing.Point(32, 86);
			this.officeAddressLabel.Name = "officeAddressLabel";
			this.officeAddressLabel.Size = new System.Drawing.Size(41, 13);
			this.officeAddressLabel.TabIndex = 4;
			this.officeAddressLabel.Text = "Адрес:";
			// 
			// officeCityTextBox
			// 
			this.officeCityTextBox.Location = new System.Drawing.Point(101, 44);
			this.officeCityTextBox.Name = "officeCityTextBox";
			this.officeCityTextBox.Size = new System.Drawing.Size(161, 20);
			this.officeCityTextBox.TabIndex = 3;
			// 
			// officeCityLabel
			// 
			this.officeCityLabel.AutoSize = true;
			this.officeCityLabel.Location = new System.Drawing.Point(32, 50);
			this.officeCityLabel.Name = "officeCityLabel";
			this.officeCityLabel.Size = new System.Drawing.Size(40, 13);
			this.officeCityLabel.TabIndex = 2;
			this.officeCityLabel.Text = "Город:";
			// 
			// officeCountryComboBox
			// 
			this.officeCountryComboBox.FormattingEnabled = true;
			this.officeCountryComboBox.Items.AddRange(new object[] {
            "Россия"});
			this.officeCountryComboBox.Location = new System.Drawing.Point(101, 11);
			this.officeCountryComboBox.Name = "officeCountryComboBox";
			this.officeCountryComboBox.Size = new System.Drawing.Size(161, 21);
			this.officeCountryComboBox.TabIndex = 1;
			// 
			// officeCountryLabel
			// 
			this.officeCountryLabel.AutoSize = true;
			this.officeCountryLabel.Location = new System.Drawing.Point(29, 14);
			this.officeCountryLabel.Name = "officeCountryLabel";
			this.officeCountryLabel.Size = new System.Drawing.Size(46, 13);
			this.officeCountryLabel.TabIndex = 0;
			this.officeCountryLabel.Text = "Страна:";
			// 
			// addOfficeButton
			// 
			this.addOfficeButton.Location = new System.Drawing.Point(529, 15);
			this.addOfficeButton.Name = "addOfficeButton";
			this.addOfficeButton.Size = new System.Drawing.Size(129, 23);
			this.addOfficeButton.TabIndex = 7;
			this.addOfficeButton.Text = "Добавить офис";
			this.addOfficeButton.UseVisualStyleBackColor = true;
			this.addOfficeButton.Click += new System.EventHandler(this.addOfficeButton_Click);
			// 
			// contactPersonTableLayoutPanel
			// 
			this.contactPersonTableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
			this.contactPersonTableLayoutPanel.ColumnCount = 3;
			this.contactPersonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.94305F));
			this.contactPersonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.95728F));
			this.contactPersonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.09968F));
			this.contactPersonTableLayoutPanel.Controls.Add(this.contactPersonLabel1, 1, 0);
			this.contactPersonTableLayoutPanel.Controls.Add(this.contactPersonLabel2, 2, 0);
			this.contactPersonTableLayoutPanel.Controls.Add(this.contactPersonLinkLabel, 0, 0);
			this.contactPersonTableLayoutPanel.Location = new System.Drawing.Point(376, 69);
			this.contactPersonTableLayoutPanel.Name = "contactPersonTableLayoutPanel";
			this.contactPersonTableLayoutPanel.RowCount = 2;
			this.oneOfficeContactTableLayoutPanel.SetRowSpan(this.contactPersonTableLayoutPanel, 2);
			this.contactPersonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.contactPersonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.contactPersonTableLayoutPanel.Size = new System.Drawing.Size(367, 148);
			this.contactPersonTableLayoutPanel.TabIndex = 12;
			// 
			// contactPersonLabel1
			// 
			this.contactPersonLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.contactPersonLabel1.AutoSize = true;
			this.contactPersonLabel1.Location = new System.Drawing.Point(143, 2);
			this.contactPersonLabel1.Name = "contactPersonLabel1";
			this.contactPersonLabel1.Size = new System.Drawing.Size(75, 71);
			this.contactPersonLabel1.TabIndex = 14;
			this.contactPersonLabel1.Text = "Менеджер по примерам";
			this.contactPersonLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// contactPersonLabel2
			// 
			this.contactPersonLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.contactPersonLabel2.AutoSize = true;
			this.contactPersonLabel2.Location = new System.Drawing.Point(237, 2);
			this.contactPersonLabel2.Name = "contactPersonLabel2";
			this.contactPersonLabel2.Size = new System.Drawing.Size(121, 71);
			this.contactPersonLabel2.TabIndex = 15;
			this.contactPersonLabel2.Text = "Моб.: +7 900 300 00 00";
			this.contactPersonLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// contactPersonLinkLabel
			// 
			this.contactPersonLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.contactPersonLinkLabel.AutoSize = true;
			this.contactPersonLinkLabel.Location = new System.Drawing.Point(10, 2);
			this.contactPersonLinkLabel.Name = "contactPersonLinkLabel";
			this.contactPersonLinkLabel.Size = new System.Drawing.Size(113, 71);
			this.contactPersonLinkLabel.TabIndex = 13;
			this.contactPersonLinkLabel.TabStop = true;
			this.contactPersonLinkLabel.Text = "Пример Примерович Примеров";
			this.contactPersonLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// contactPersonPanel
			// 
			this.contactPersonPanel.Controls.Add(this.contactPersonsButton);
			this.contactPersonPanel.Controls.Add(this.contactPersonsLabel);
			this.contactPersonPanel.Location = new System.Drawing.Point(376, 26);
			this.contactPersonPanel.Name = "contactPersonPanel";
			this.contactPersonPanel.Size = new System.Drawing.Size(338, 37);
			this.contactPersonPanel.TabIndex = 13;
			// 
			// contactPersonsButton
			// 
			this.contactPersonsButton.Location = new System.Drawing.Point(182, 4);
			this.contactPersonsButton.Name = "contactPersonsButton";
			this.contactPersonsButton.Size = new System.Drawing.Size(110, 23);
			this.contactPersonsButton.TabIndex = 1;
			this.contactPersonsButton.Text = "Добавить нового";
			this.contactPersonsButton.UseVisualStyleBackColor = true;
			// 
			// contactPersonsLabel
			// 
			this.contactPersonsLabel.AutoSize = true;
			this.contactPersonsLabel.Location = new System.Drawing.Point(95, 9);
			this.contactPersonsLabel.Name = "contactPersonsLabel";
			this.contactPersonsLabel.Size = new System.Drawing.Size(66, 13);
			this.contactPersonsLabel.TabIndex = 0;
			this.contactPersonsLabel.Text = "Сотрудники";
			// 
			// allOfficesFlowLayoutPanel
			// 
			this.allOfficesFlowLayoutPanel.AutoSize = true;
			this.allOfficesFlowLayoutPanel.Controls.Add(this.oneOfficeContactTableLayoutPanel);
			this.allOfficesFlowLayoutPanel.Controls.Add(this.newCompanyActionMenuPanel);
			this.allOfficesFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.allOfficesFlowLayoutPanel.Location = new System.Drawing.Point(12, 56);
			this.allOfficesFlowLayoutPanel.Name = "allOfficesFlowLayoutPanel";
			this.allOfficesFlowLayoutPanel.Size = new System.Drawing.Size(770, 413);
			this.allOfficesFlowLayoutPanel.TabIndex = 16;
			this.allOfficesFlowLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.allOfficesFlowLayoutPanel_Paint);
			// 
			// oneOfficeContactTableLayoutPanel
			// 
			this.oneOfficeContactTableLayoutPanel.AutoSize = true;
			this.oneOfficeContactTableLayoutPanel.ColumnCount = 2;
			this.oneOfficeContactTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.oneOfficeContactTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.oneOfficeContactTableLayoutPanel.Controls.Add(this.phonesFlowLayoutPanel, 0, 3);
			this.oneOfficeContactTableLayoutPanel.Controls.Add(this.contactPersonTableLayoutPanel, 1, 2);
			this.oneOfficeContactTableLayoutPanel.Controls.Add(this.contactPersonPanel, 1, 1);
			this.oneOfficeContactTableLayoutPanel.Controls.Add(this.officeContactInfoPanel, 0, 1);
			this.oneOfficeContactTableLayoutPanel.Controls.Add(this.officeNumberLabel, 0, 0);
			this.oneOfficeContactTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
			this.oneOfficeContactTableLayoutPanel.Name = "oneOfficeContactTableLayoutPanel";
			this.oneOfficeContactTableLayoutPanel.RowCount = 4;
			this.oneOfficeContactTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.oneOfficeContactTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.oneOfficeContactTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.oneOfficeContactTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.oneOfficeContactTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.oneOfficeContactTableLayoutPanel.Size = new System.Drawing.Size(746, 229);
			this.oneOfficeContactTableLayoutPanel.TabIndex = 17;
			// 
			// phonesFlowLayoutPanel
			// 
			this.phonesFlowLayoutPanel.AutoSize = true;
			this.phonesFlowLayoutPanel.Controls.Add(this.onePhonePanel);
			this.phonesFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.phonesFlowLayoutPanel.Location = new System.Drawing.Point(0, 183);
			this.phonesFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
			this.phonesFlowLayoutPanel.Name = "phonesFlowLayoutPanel";
			this.phonesFlowLayoutPanel.Size = new System.Drawing.Size(341, 46);
			this.phonesFlowLayoutPanel.TabIndex = 10;
			// 
			// onePhonePanel
			// 
			this.onePhonePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.onePhonePanel.Controls.Add(this.morePhonesButton);
			this.onePhonePanel.Controls.Add(this.phoneTextBox);
			this.onePhonePanel.Controls.Add(this.phoneLabel);
			this.onePhonePanel.Location = new System.Drawing.Point(3, 3);
			this.onePhonePanel.Name = "onePhonePanel";
			this.onePhonePanel.Size = new System.Drawing.Size(335, 40);
			this.onePhonePanel.TabIndex = 9;
			this.onePhonePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PhonePanel_Paint);
			// 
			// morePhonesButton
			// 
			this.morePhonesButton.Location = new System.Drawing.Point(212, 6);
			this.morePhonesButton.Name = "morePhonesButton";
			this.morePhonesButton.Size = new System.Drawing.Size(47, 23);
			this.morePhonesButton.TabIndex = 8;
			this.morePhonesButton.Text = "Ещё";
			this.morePhonesButton.UseVisualStyleBackColor = true;
			// 
			// phoneTextBox
			// 
			this.phoneTextBox.Location = new System.Drawing.Point(99, 8);
			this.phoneTextBox.Name = "phoneTextBox";
			this.phoneTextBox.Size = new System.Drawing.Size(100, 20);
			this.phoneTextBox.TabIndex = 7;
			// 
			// phoneLabel
			// 
			this.phoneLabel.AutoSize = true;
			this.phoneLabel.Location = new System.Drawing.Point(36, 11);
			this.phoneLabel.Name = "phoneLabel";
			this.phoneLabel.Size = new System.Drawing.Size(32, 13);
			this.phoneLabel.TabIndex = 6;
			this.phoneLabel.Text = "Тел.:";
			// 
			// officeNumberLabel
			// 
			this.officeNumberLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.oneOfficeContactTableLayoutPanel.SetColumnSpan(this.officeNumberLabel, 2);
			this.officeNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.officeNumberLabel.Location = new System.Drawing.Point(323, 0);
			this.officeNumberLabel.Name = "officeNumberLabel";
			this.officeNumberLabel.Size = new System.Drawing.Size(100, 23);
			this.officeNumberLabel.TabIndex = 14;
			this.officeNumberLabel.Text = "Офис №";
			this.officeNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// newCompanyActionMenuPanel
			// 
			this.newCompanyActionMenuPanel.Controls.Add(this.addClientDataButton);
			this.newCompanyActionMenuPanel.Location = new System.Drawing.Point(3, 238);
			this.newCompanyActionMenuPanel.Name = "newCompanyActionMenuPanel";
			this.newCompanyActionMenuPanel.Size = new System.Drawing.Size(477, 59);
			this.newCompanyActionMenuPanel.TabIndex = 17;
			// 
			// AddNewCompanyForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(795, 481);
			this.Controls.Add(this.allOfficesFlowLayoutPanel);
			this.Controls.Add(this.addOfficeButton);
			this.Controls.Add(this.companyNameLabel);
			this.Controls.Add(this.companyNameTextBox);
			this.Name = "AddNewCompanyForm";
			this.Text = "AddNewClientForm";
			this.Load += new System.EventHandler(this.AddNewClientForm_Load);
			this.officeContactInfoPanel.ResumeLayout(false);
			this.officeContactInfoPanel.PerformLayout();
			this.contactPersonTableLayoutPanel.ResumeLayout(false);
			this.contactPersonTableLayoutPanel.PerformLayout();
			this.contactPersonPanel.ResumeLayout(false);
			this.contactPersonPanel.PerformLayout();
			this.allOfficesFlowLayoutPanel.ResumeLayout(false);
			this.allOfficesFlowLayoutPanel.PerformLayout();
			this.oneOfficeContactTableLayoutPanel.ResumeLayout(false);
			this.oneOfficeContactTableLayoutPanel.PerformLayout();
			this.phonesFlowLayoutPanel.ResumeLayout(false);
			this.onePhonePanel.ResumeLayout(false);
			this.onePhonePanel.PerformLayout();
			this.newCompanyActionMenuPanel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox companyNameTextBox;
		private System.Windows.Forms.Label companyNameLabel;
		private System.Windows.Forms.Button addClientDataButton;
		private System.Windows.Forms.Label officeSiteLabel;
		private System.Windows.Forms.TextBox officeSiteTextBox;
		private System.Windows.Forms.Panel officeContactInfoPanel;
		private System.Windows.Forms.Label officeCountryLabel;
		private System.Windows.Forms.TextBox officeAddressTextBox;
		private System.Windows.Forms.Label officeAddressLabel;
		private System.Windows.Forms.TextBox officeCityTextBox;
		private System.Windows.Forms.Label officeCityLabel;
		private System.Windows.Forms.ComboBox officeCountryComboBox;
		private System.Windows.Forms.Button addOfficeButton;
		private System.Windows.Forms.TableLayoutPanel contactPersonTableLayoutPanel;
		private System.Windows.Forms.Label contactPersonLabel1;
		private System.Windows.Forms.Label contactPersonLabel2;
		private System.Windows.Forms.LinkLabel contactPersonLinkLabel;
		private System.Windows.Forms.Panel contactPersonPanel;
		private System.Windows.Forms.Button contactPersonsButton;
		private System.Windows.Forms.Label contactPersonsLabel;
		private System.Windows.Forms.FlowLayoutPanel allOfficesFlowLayoutPanel;
		private System.Windows.Forms.Panel newCompanyActionMenuPanel;
		private System.Windows.Forms.TableLayoutPanel oneOfficeContactTableLayoutPanel;
        private System.Windows.Forms.Label officeNumberLabel;
        private System.Windows.Forms.FlowLayoutPanel phonesFlowLayoutPanel;
        private System.Windows.Forms.Panel onePhonePanel;
        private System.Windows.Forms.Button morePhonesButton;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label phoneLabel;
    }
}