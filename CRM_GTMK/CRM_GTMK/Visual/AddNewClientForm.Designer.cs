namespace CRM_GTMK.Visual
{
	partial class AddNewClientForm
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
			this.CompanyNameTextBox = new System.Windows.Forms.TextBox();
			this.CompanyNameLabel = new System.Windows.Forms.Label();
			this.CompanyActivityLabel = new System.Windows.Forms.Label();
			this.AddClientDataButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.CompanySiteTextBox = new System.Windows.Forms.TextBox();
			this.ContactInfoPanel = new System.Windows.Forms.Panel();
			this.CountryLabel = new System.Windows.Forms.Label();
			this.CountryComboBox = new System.Windows.Forms.ComboBox();
			this.CityLabel = new System.Windows.Forms.Label();
			this.CityTextBox = new System.Windows.Forms.TextBox();
			this.AddressLabel = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.PhoneLabel = new System.Windows.Forms.Label();
			this.PhoneTextBox = new System.Windows.Forms.TextBox();
			this.HeadOfficeLabel = new System.Windows.Forms.Label();
			this.HeadOfficeCheckBox = new System.Windows.Forms.CheckBox();
			this.PhonePanel = new System.Windows.Forms.Panel();
			this.MorePhonesButton = new System.Windows.Forms.Button();
			this.PhonesFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.ContactInfoPanel.SuspendLayout();
			this.PhonePanel.SuspendLayout();
			this.PhonesFlowLayoutPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// CompanyNameTextBox
			// 
			this.CompanyNameTextBox.Location = new System.Drawing.Point(176, 21);
			this.CompanyNameTextBox.Name = "CompanyNameTextBox";
			this.CompanyNameTextBox.Size = new System.Drawing.Size(165, 20);
			this.CompanyNameTextBox.TabIndex = 0;
			// 
			// CompanyNameLabel
			// 
			this.CompanyNameLabel.AutoSize = true;
			this.CompanyNameLabel.Location = new System.Drawing.Point(38, 24);
			this.CompanyNameLabel.Name = "CompanyNameLabel";
			this.CompanyNameLabel.Size = new System.Drawing.Size(113, 13);
			this.CompanyNameLabel.TabIndex = 1;
			this.CompanyNameLabel.Text = "Название компании:";
			// 
			// CompanyActivityLabel
			// 
			this.CompanyActivityLabel.AutoSize = true;
			this.CompanyActivityLabel.Location = new System.Drawing.Point(12, 281);
			this.CompanyActivityLabel.Name = "CompanyActivityLabel";
			this.CompanyActivityLabel.Size = new System.Drawing.Size(151, 13);
			this.CompanyActivityLabel.TabIndex = 2;
			this.CompanyActivityLabel.Text = "Направление деятельности:";
			// 
			// AddClientDataButton
			// 
			this.AddClientDataButton.Location = new System.Drawing.Point(300, 327);
			this.AddClientDataButton.Name = "AddClientDataButton";
			this.AddClientDataButton.Size = new System.Drawing.Size(75, 35);
			this.AddClientDataButton.TabIndex = 3;
			this.AddClientDataButton.Text = "Сохранить данные";
			this.AddClientDataButton.UseVisualStyleBackColor = true;
			this.AddClientDataButton.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(117, 57);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(34, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Сайт:";
			// 
			// CompanySiteTextBox
			// 
			this.CompanySiteTextBox.Location = new System.Drawing.Point(176, 57);
			this.CompanySiteTextBox.Name = "CompanySiteTextBox";
			this.CompanySiteTextBox.Size = new System.Drawing.Size(165, 20);
			this.CompanySiteTextBox.TabIndex = 5;
			// 
			// ContactInfoPanel
			// 
			this.ContactInfoPanel.AutoSize = true;
			this.ContactInfoPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ContactInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ContactInfoPanel.Controls.Add(this.PhonesFlowLayoutPanel);
			this.ContactInfoPanel.Controls.Add(this.textBox1);
			this.ContactInfoPanel.Controls.Add(this.AddressLabel);
			this.ContactInfoPanel.Controls.Add(this.CityTextBox);
			this.ContactInfoPanel.Controls.Add(this.CityLabel);
			this.ContactInfoPanel.Controls.Add(this.CountryComboBox);
			this.ContactInfoPanel.Controls.Add(this.CountryLabel);
			this.ContactInfoPanel.Location = new System.Drawing.Point(395, 12);
			this.ContactInfoPanel.Name = "ContactInfoPanel";
			this.ContactInfoPanel.Size = new System.Drawing.Size(307, 208);
			this.ContactInfoPanel.TabIndex = 6;
			// 
			// CountryLabel
			// 
			this.CountryLabel.AutoSize = true;
			this.CountryLabel.Location = new System.Drawing.Point(29, 14);
			this.CountryLabel.Name = "CountryLabel";
			this.CountryLabel.Size = new System.Drawing.Size(46, 13);
			this.CountryLabel.TabIndex = 0;
			this.CountryLabel.Text = "Страна:";
			// 
			// CountryComboBox
			// 
			this.CountryComboBox.FormattingEnabled = true;
			this.CountryComboBox.Items.AddRange(new object[] {
            "Россия"});
			this.CountryComboBox.Location = new System.Drawing.Point(101, 11);
			this.CountryComboBox.Name = "CountryComboBox";
			this.CountryComboBox.Size = new System.Drawing.Size(121, 21);
			this.CountryComboBox.TabIndex = 1;
			// 
			// CityLabel
			// 
			this.CityLabel.AutoSize = true;
			this.CityLabel.Location = new System.Drawing.Point(32, 50);
			this.CityLabel.Name = "CityLabel";
			this.CityLabel.Size = new System.Drawing.Size(40, 13);
			this.CityLabel.TabIndex = 2;
			this.CityLabel.Text = "Город:";
			// 
			// CityTextBox
			// 
			this.CityTextBox.Location = new System.Drawing.Point(101, 44);
			this.CityTextBox.Name = "CityTextBox";
			this.CityTextBox.Size = new System.Drawing.Size(100, 20);
			this.CityTextBox.TabIndex = 3;
			// 
			// AddressLabel
			// 
			this.AddressLabel.AutoSize = true;
			this.AddressLabel.Location = new System.Drawing.Point(34, 86);
			this.AddressLabel.Name = "AddressLabel";
			this.AddressLabel.Size = new System.Drawing.Size(41, 13);
			this.AddressLabel.TabIndex = 4;
			this.AddressLabel.Text = "Адрес:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(101, 83);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 5;
			// 
			// PhoneLabel
			// 
			this.PhoneLabel.AutoSize = true;
			this.PhoneLabel.Location = new System.Drawing.Point(5, 18);
			this.PhoneLabel.Name = "PhoneLabel";
			this.PhoneLabel.Size = new System.Drawing.Size(29, 13);
			this.PhoneLabel.TabIndex = 6;
			this.PhoneLabel.Text = "Тел:";
			// 
			// PhoneTextBox
			// 
			this.PhoneTextBox.Location = new System.Drawing.Point(61, 15);
			this.PhoneTextBox.Name = "PhoneTextBox";
			this.PhoneTextBox.Size = new System.Drawing.Size(100, 20);
			this.PhoneTextBox.TabIndex = 7;
			// 
			// HeadOfficeLabel
			// 
			this.HeadOfficeLabel.AutoSize = true;
			this.HeadOfficeLabel.Location = new System.Drawing.Point(64, 127);
			this.HeadOfficeLabel.Name = "HeadOfficeLabel";
			this.HeadOfficeLabel.Size = new System.Drawing.Size(87, 13);
			this.HeadOfficeLabel.TabIndex = 7;
			this.HeadOfficeLabel.Text = "Головной офис:";
			// 
			// HeadOfficeCheckBox
			// 
			this.HeadOfficeCheckBox.AutoSize = true;
			this.HeadOfficeCheckBox.Location = new System.Drawing.Point(176, 126);
			this.HeadOfficeCheckBox.Name = "HeadOfficeCheckBox";
			this.HeadOfficeCheckBox.Size = new System.Drawing.Size(44, 17);
			this.HeadOfficeCheckBox.TabIndex = 8;
			this.HeadOfficeCheckBox.Text = " Да";
			this.HeadOfficeCheckBox.UseVisualStyleBackColor = true;
			// 
			// PhonePanel
			// 
			this.PhonePanel.Controls.Add(this.MorePhonesButton);
			this.PhonePanel.Controls.Add(this.PhoneTextBox);
			this.PhonePanel.Controls.Add(this.PhoneLabel);
			this.PhonePanel.Location = new System.Drawing.Point(3, 3);
			this.PhonePanel.Name = "PhonePanel";
			this.PhonePanel.Size = new System.Drawing.Size(254, 51);
			this.PhonePanel.TabIndex = 9;
			this.PhonePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PhonePanel_Paint);
			// 
			// MorePhonesButton
			// 
			this.MorePhonesButton.Location = new System.Drawing.Point(187, 12);
			this.MorePhonesButton.Name = "MorePhonesButton";
			this.MorePhonesButton.Size = new System.Drawing.Size(47, 23);
			this.MorePhonesButton.TabIndex = 8;
			this.MorePhonesButton.Text = "Ещё";
			this.MorePhonesButton.UseVisualStyleBackColor = true;
			this.MorePhonesButton.Click += new System.EventHandler(this.MorePhonesButton_Click);
			// 
			// PhonesFlowLayoutPanel
			// 
			this.PhonesFlowLayoutPanel.AutoSize = true;
			this.PhonesFlowLayoutPanel.Controls.Add(this.PhonePanel);
			this.PhonesFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.PhonesFlowLayoutPanel.Location = new System.Drawing.Point(37, 114);
			this.PhonesFlowLayoutPanel.Name = "PhonesFlowLayoutPanel";
			this.PhonesFlowLayoutPanel.Size = new System.Drawing.Size(265, 89);
			this.PhonesFlowLayoutPanel.TabIndex = 10;
			// 
			// AddNewClientForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(882, 389);
			this.Controls.Add(this.HeadOfficeCheckBox);
			this.Controls.Add(this.HeadOfficeLabel);
			this.Controls.Add(this.ContactInfoPanel);
			this.Controls.Add(this.CompanySiteTextBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.AddClientDataButton);
			this.Controls.Add(this.CompanyActivityLabel);
			this.Controls.Add(this.CompanyNameLabel);
			this.Controls.Add(this.CompanyNameTextBox);
			this.Name = "AddNewClientForm";
			this.Text = "AddNewClientForm";
			this.Load += new System.EventHandler(this.AddNewClientForm_Load);
			this.ContactInfoPanel.ResumeLayout(false);
			this.ContactInfoPanel.PerformLayout();
			this.PhonePanel.ResumeLayout(false);
			this.PhonePanel.PerformLayout();
			this.PhonesFlowLayoutPanel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox CompanyNameTextBox;
		private System.Windows.Forms.Label CompanyNameLabel;
		private System.Windows.Forms.Label CompanyActivityLabel;
		private System.Windows.Forms.Button AddClientDataButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox CompanySiteTextBox;
		private System.Windows.Forms.Panel ContactInfoPanel;
		private System.Windows.Forms.Label CountryLabel;
		private System.Windows.Forms.TextBox PhoneTextBox;
		private System.Windows.Forms.Label PhoneLabel;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label AddressLabel;
		private System.Windows.Forms.TextBox CityTextBox;
		private System.Windows.Forms.Label CityLabel;
		private System.Windows.Forms.ComboBox CountryComboBox;
		private System.Windows.Forms.Label HeadOfficeLabel;
		private System.Windows.Forms.CheckBox HeadOfficeCheckBox;
		private System.Windows.Forms.FlowLayoutPanel PhonesFlowLayoutPanel;
		private System.Windows.Forms.Panel PhonePanel;
		private System.Windows.Forms.Button MorePhonesButton;
	}
}