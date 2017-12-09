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
			this.AddClientDataButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.CompanySiteTextBox = new System.Windows.Forms.TextBox();
			this.ContactInfoPanel = new System.Windows.Forms.Panel();
			this.phonesFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.PhonePanel = new System.Windows.Forms.Panel();
			this.MorePhonesButton = new System.Windows.Forms.Button();
			this.PhoneTextBox = new System.Windows.Forms.TextBox();
			this.PhoneLabel = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.AddressLabel = new System.Windows.Forms.Label();
			this.CityTextBox = new System.Windows.Forms.TextBox();
			this.CityLabel = new System.Windows.Forms.Label();
			this.CountryComboBox = new System.Windows.Forms.ComboBox();
			this.CountryLabel = new System.Windows.Forms.Label();
			this.addOfficeButton = new System.Windows.Forms.Button();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.contactPersonLinkLabel = new System.Windows.Forms.LinkLabel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.contactPersonsLabel = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this.oneOfficeFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.allOfficesFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.ContactInfoPanel.SuspendLayout();
			this.phonesFlowLayoutPanel.SuspendLayout();
			this.PhonePanel.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.flowLayoutPanel2.SuspendLayout();
			this.oneOfficeFlowLayoutPanel.SuspendLayout();
			this.allOfficesFlowLayoutPanel.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// CompanyNameTextBox
			// 
			this.CompanyNameTextBox.Location = new System.Drawing.Point(324, 17);
			this.CompanyNameTextBox.Name = "CompanyNameTextBox";
			this.CompanyNameTextBox.Size = new System.Drawing.Size(165, 20);
			this.CompanyNameTextBox.TabIndex = 0;
			// 
			// CompanyNameLabel
			// 
			this.CompanyNameLabel.AutoSize = true;
			this.CompanyNameLabel.Location = new System.Drawing.Point(186, 20);
			this.CompanyNameLabel.Name = "CompanyNameLabel";
			this.CompanyNameLabel.Size = new System.Drawing.Size(113, 13);
			this.CompanyNameLabel.TabIndex = 1;
			this.CompanyNameLabel.Text = "Название компании:";
			// 
			// AddClientDataButton
			// 
			this.AddClientDataButton.Location = new System.Drawing.Point(349, 12);
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
			this.label1.Location = new System.Drawing.Point(38, 121);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(34, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Сайт:";
			// 
			// CompanySiteTextBox
			// 
			this.CompanySiteTextBox.Location = new System.Drawing.Point(101, 118);
			this.CompanySiteTextBox.Name = "CompanySiteTextBox";
			this.CompanySiteTextBox.Size = new System.Drawing.Size(161, 20);
			this.CompanySiteTextBox.TabIndex = 5;
			// 
			// ContactInfoPanel
			// 
			this.ContactInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ContactInfoPanel.Controls.Add(this.textBox1);
			this.ContactInfoPanel.Controls.Add(this.AddressLabel);
			this.ContactInfoPanel.Controls.Add(this.CityTextBox);
			this.ContactInfoPanel.Controls.Add(this.CompanySiteTextBox);
			this.ContactInfoPanel.Controls.Add(this.CityLabel);
			this.ContactInfoPanel.Controls.Add(this.label1);
			this.ContactInfoPanel.Controls.Add(this.CountryComboBox);
			this.ContactInfoPanel.Controls.Add(this.CountryLabel);
			this.ContactInfoPanel.Location = new System.Drawing.Point(3, 3);
			this.ContactInfoPanel.Name = "ContactInfoPanel";
			this.ContactInfoPanel.Size = new System.Drawing.Size(297, 155);
			this.ContactInfoPanel.TabIndex = 6;
			// 
			// phonesFlowLayoutPanel
			// 
			this.phonesFlowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.phonesFlowLayoutPanel.Controls.Add(this.PhonePanel);
			this.phonesFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.phonesFlowLayoutPanel.Location = new System.Drawing.Point(3, 164);
			this.phonesFlowLayoutPanel.Name = "phonesFlowLayoutPanel";
			this.phonesFlowLayoutPanel.Size = new System.Drawing.Size(297, 65);
			this.phonesFlowLayoutPanel.TabIndex = 10;
			// 
			// PhonePanel
			// 
			this.PhonePanel.Controls.Add(this.MorePhonesButton);
			this.PhonePanel.Controls.Add(this.PhoneTextBox);
			this.PhonePanel.Controls.Add(this.PhoneLabel);
			this.PhonePanel.Location = new System.Drawing.Point(3, 3);
			this.PhonePanel.Name = "PhonePanel";
			this.PhonePanel.Size = new System.Drawing.Size(274, 40);
			this.PhonePanel.TabIndex = 9;
			this.PhonePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PhonePanel_Paint);
			// 
			// MorePhonesButton
			// 
			this.MorePhonesButton.Location = new System.Drawing.Point(212, 6);
			this.MorePhonesButton.Name = "MorePhonesButton";
			this.MorePhonesButton.Size = new System.Drawing.Size(47, 23);
			this.MorePhonesButton.TabIndex = 8;
			this.MorePhonesButton.Text = "Ещё";
			this.MorePhonesButton.UseVisualStyleBackColor = true;
			this.MorePhonesButton.Click += new System.EventHandler(this.MorePhonesButton_Click);
			// 
			// PhoneTextBox
			// 
			this.PhoneTextBox.Location = new System.Drawing.Point(99, 8);
			this.PhoneTextBox.Name = "PhoneTextBox";
			this.PhoneTextBox.Size = new System.Drawing.Size(100, 20);
			this.PhoneTextBox.TabIndex = 7;
			// 
			// PhoneLabel
			// 
			this.PhoneLabel.AutoSize = true;
			this.PhoneLabel.Location = new System.Drawing.Point(36, 11);
			this.PhoneLabel.Name = "PhoneLabel";
			this.PhoneLabel.Size = new System.Drawing.Size(32, 13);
			this.PhoneLabel.TabIndex = 6;
			this.PhoneLabel.Text = "Тел.:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(101, 83);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(161, 20);
			this.textBox1.TabIndex = 5;
			// 
			// AddressLabel
			// 
			this.AddressLabel.AutoSize = true;
			this.AddressLabel.Location = new System.Drawing.Point(32, 86);
			this.AddressLabel.Name = "AddressLabel";
			this.AddressLabel.Size = new System.Drawing.Size(41, 13);
			this.AddressLabel.TabIndex = 4;
			this.AddressLabel.Text = "Адрес:";
			// 
			// CityTextBox
			// 
			this.CityTextBox.Location = new System.Drawing.Point(101, 44);
			this.CityTextBox.Name = "CityTextBox";
			this.CityTextBox.Size = new System.Drawing.Size(161, 20);
			this.CityTextBox.TabIndex = 3;
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
			// CountryComboBox
			// 
			this.CountryComboBox.FormattingEnabled = true;
			this.CountryComboBox.Items.AddRange(new object[] {
            "Россия"});
			this.CountryComboBox.Location = new System.Drawing.Point(101, 11);
			this.CountryComboBox.Name = "CountryComboBox";
			this.CountryComboBox.Size = new System.Drawing.Size(161, 21);
			this.CountryComboBox.TabIndex = 1;
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
			// addOfficeButton
			// 
			this.addOfficeButton.Location = new System.Drawing.Point(529, 15);
			this.addOfficeButton.Name = "addOfficeButton";
			this.addOfficeButton.Size = new System.Drawing.Size(129, 23);
			this.addOfficeButton.TabIndex = 7;
			this.addOfficeButton.Text = "Добавить офис";
			this.addOfficeButton.UseVisualStyleBackColor = true;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.ContactInfoPanel);
			this.flowLayoutPanel1.Controls.Add(this.phonesFlowLayoutPanel);
			this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(338, 269);
			this.flowLayoutPanel1.TabIndex = 11;
			this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.14286F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.85714F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.contactPersonLinkLabel, 0, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 46);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(367, 100);
			this.tableLayoutPanel1.TabIndex = 12;
			// 
			// contactPersonLinkLabel
			// 
			this.contactPersonLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.contactPersonLinkLabel.AutoSize = true;
			this.contactPersonLinkLabel.Location = new System.Drawing.Point(10, 2);
			this.contactPersonLinkLabel.Name = "contactPersonLinkLabel";
			this.contactPersonLinkLabel.Size = new System.Drawing.Size(116, 47);
			this.contactPersonLinkLabel.TabIndex = 13;
			this.contactPersonLinkLabel.TabStop = true;
			this.contactPersonLinkLabel.Text = "Пример Примерович Примеров";
			this.contactPersonLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.contactPersonsLabel);
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(338, 37);
			this.panel1.TabIndex = 13;
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
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(182, 4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(110, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Добавить нового";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(146, 2);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 47);
			this.label2.TabIndex = 14;
			this.label2.Text = "Менеджер по примерам";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(240, 2);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(121, 47);
			this.label3.TabIndex = 15;
			this.label3.Text = "Моб.: +7 900 300 00 00";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// flowLayoutPanel2
			// 
			this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.flowLayoutPanel2.Controls.Add(this.panel1);
			this.flowLayoutPanel2.Controls.Add(this.tableLayoutPanel1);
			this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flowLayoutPanel2.Location = new System.Drawing.Point(347, 3);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Size = new System.Drawing.Size(382, 269);
			this.flowLayoutPanel2.TabIndex = 14;
			// 
			// oneOfficeFlowLayoutPanel
			// 
			this.oneOfficeFlowLayoutPanel.Controls.Add(this.flowLayoutPanel1);
			this.oneOfficeFlowLayoutPanel.Controls.Add(this.flowLayoutPanel2);
			this.oneOfficeFlowLayoutPanel.Location = new System.Drawing.Point(3, 3);
			this.oneOfficeFlowLayoutPanel.Name = "oneOfficeFlowLayoutPanel";
			this.oneOfficeFlowLayoutPanel.Size = new System.Drawing.Size(744, 300);
			this.oneOfficeFlowLayoutPanel.TabIndex = 15;
			// 
			// allOfficesFlowLayoutPanel
			// 
			this.allOfficesFlowLayoutPanel.Controls.Add(this.oneOfficeFlowLayoutPanel);
			this.allOfficesFlowLayoutPanel.Controls.Add(this.panel2);
			this.allOfficesFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.allOfficesFlowLayoutPanel.Location = new System.Drawing.Point(12, 56);
			this.allOfficesFlowLayoutPanel.Name = "allOfficesFlowLayoutPanel";
			this.allOfficesFlowLayoutPanel.Size = new System.Drawing.Size(761, 402);
			this.allOfficesFlowLayoutPanel.TabIndex = 16;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.AddClientDataButton);
			this.panel2.Location = new System.Drawing.Point(3, 309);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(477, 59);
			this.panel2.TabIndex = 17;
			// 
			// AddNewClientForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(789, 702);
			this.Controls.Add(this.allOfficesFlowLayoutPanel);
			this.Controls.Add(this.addOfficeButton);
			this.Controls.Add(this.CompanyNameLabel);
			this.Controls.Add(this.CompanyNameTextBox);
			this.Name = "AddNewClientForm";
			this.Text = "AddNewClientForm";
			this.Load += new System.EventHandler(this.AddNewClientForm_Load);
			this.ContactInfoPanel.ResumeLayout(false);
			this.ContactInfoPanel.PerformLayout();
			this.phonesFlowLayoutPanel.ResumeLayout(false);
			this.PhonePanel.ResumeLayout(false);
			this.PhonePanel.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.flowLayoutPanel2.ResumeLayout(false);
			this.oneOfficeFlowLayoutPanel.ResumeLayout(false);
			this.allOfficesFlowLayoutPanel.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox CompanyNameTextBox;
		private System.Windows.Forms.Label CompanyNameLabel;
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
		private System.Windows.Forms.FlowLayoutPanel phonesFlowLayoutPanel;
		private System.Windows.Forms.Panel PhonePanel;
		private System.Windows.Forms.Button MorePhonesButton;
		private System.Windows.Forms.Button addOfficeButton;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.LinkLabel contactPersonLinkLabel;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label contactPersonsLabel;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
		private System.Windows.Forms.FlowLayoutPanel oneOfficeFlowLayoutPanel;
		private System.Windows.Forms.FlowLayoutPanel allOfficesFlowLayoutPanel;
		private System.Windows.Forms.Panel panel2;
	}
}