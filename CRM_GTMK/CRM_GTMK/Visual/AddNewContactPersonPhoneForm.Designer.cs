namespace CRM_GTMK.Visual
{
    partial class AddNewContactPersonPhoneForm
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
            this.phoneTypeComboBox = new System.Windows.Forms.ComboBox();
            this.phoneCountryCodeTextBox = new System.Windows.Forms.TextBox();
            this.phoneCountryCodeLabel = new System.Windows.Forms.Label();
            this.phoneCityCodeLabel = new System.Windows.Forms.Label();
            this.phoneCityCodeTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.phoneCommentLabel = new System.Windows.Forms.Label();
            this.phoneCommentRichTextBox = new System.Windows.Forms.RichTextBox();
            this.savePhoneButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // phoneTypeComboBox
            // 
            this.phoneTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.phoneTypeComboBox.FormattingEnabled = true;
            this.phoneTypeComboBox.Items.AddRange(new object[] {
            "Рабочий",
            "Мобильный",
            "Домашний"});
            this.phoneTypeComboBox.Location = new System.Drawing.Point(97, 14);
            this.phoneTypeComboBox.Name = "phoneTypeComboBox";
            this.phoneTypeComboBox.Size = new System.Drawing.Size(76, 21);
            this.phoneTypeComboBox.TabIndex = 1;
            // 
            // phoneCountryCodeTextBox
            // 
            this.phoneCountryCodeTextBox.Location = new System.Drawing.Point(97, 41);
            this.phoneCountryCodeTextBox.Name = "phoneCountryCodeTextBox";
            this.phoneCountryCodeTextBox.Size = new System.Drawing.Size(76, 20);
            this.phoneCountryCodeTextBox.TabIndex = 2;
            this.phoneCountryCodeTextBox.Text = "+";
            // 
            // phoneCountryCodeLabel
            // 
            this.phoneCountryCodeLabel.AutoSize = true;
            this.phoneCountryCodeLabel.Location = new System.Drawing.Point(23, 44);
            this.phoneCountryCodeLabel.Name = "phoneCountryCodeLabel";
            this.phoneCountryCodeLabel.Size = new System.Drawing.Size(69, 13);
            this.phoneCountryCodeLabel.TabIndex = 3;
            this.phoneCountryCodeLabel.Text = "Код страны:";
            // 
            // phoneCityCodeLabel
            // 
            this.phoneCityCodeLabel.AutoSize = true;
            this.phoneCityCodeLabel.Location = new System.Drawing.Point(25, 70);
            this.phoneCityCodeLabel.Name = "phoneCityCodeLabel";
            this.phoneCityCodeLabel.Size = new System.Drawing.Size(67, 13);
            this.phoneCityCodeLabel.TabIndex = 4;
            this.phoneCityCodeLabel.Text = "Код города:";
            // 
            // phoneCityCodeTextBox
            // 
            this.phoneCityCodeTextBox.Location = new System.Drawing.Point(97, 67);
            this.phoneCityCodeTextBox.Name = "phoneCityCodeTextBox";
            this.phoneCityCodeTextBox.Size = new System.Drawing.Size(76, 20);
            this.phoneCityCodeTextBox.TabIndex = 5;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(97, 93);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(76, 20);
            this.phoneNumberTextBox.TabIndex = 6;
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Location = new System.Drawing.Point(48, 96);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(44, 13);
            this.phoneNumberLabel.TabIndex = 7;
            this.phoneNumberLabel.Text = "Номер:";
            // 
            // phoneCommentLabel
            // 
            this.phoneCommentLabel.AutoSize = true;
            this.phoneCommentLabel.Location = new System.Drawing.Point(12, 132);
            this.phoneCommentLabel.Name = "phoneCommentLabel";
            this.phoneCommentLabel.Size = new System.Drawing.Size(80, 13);
            this.phoneCommentLabel.TabIndex = 8;
            this.phoneCommentLabel.Text = "Комментарий:";
            // 
            // phoneCommentRichTextBox
            // 
            this.phoneCommentRichTextBox.Location = new System.Drawing.Point(97, 132);
            this.phoneCommentRichTextBox.Name = "phoneCommentRichTextBox";
            this.phoneCommentRichTextBox.Size = new System.Drawing.Size(154, 74);
            this.phoneCommentRichTextBox.TabIndex = 9;
            this.phoneCommentRichTextBox.Text = "";
            // 
            // savePhoneButton
            // 
            this.savePhoneButton.Location = new System.Drawing.Point(97, 227);
            this.savePhoneButton.Name = "savePhoneButton";
            this.savePhoneButton.Size = new System.Drawing.Size(75, 35);
            this.savePhoneButton.TabIndex = 10;
            this.savePhoneButton.Text = "Сохранить и закрыть";
            this.savePhoneButton.UseVisualStyleBackColor = true;
            this.savePhoneButton.Click += new System.EventHandler(this.savePhoneButton_Click);
            // 
            // AddNewContactPersonPhoneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(263, 274);
            this.Controls.Add(this.savePhoneButton);
            this.Controls.Add(this.phoneCommentRichTextBox);
            this.Controls.Add(this.phoneCommentLabel);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.phoneCityCodeTextBox);
            this.Controls.Add(this.phoneCityCodeLabel);
            this.Controls.Add(this.phoneCountryCodeLabel);
            this.Controls.Add(this.phoneCountryCodeTextBox);
            this.Controls.Add(this.phoneTypeComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AddNewContactPersonPhoneForm";
            this.Text = "Добавить телефон";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox phoneTypeComboBox;
        private System.Windows.Forms.TextBox phoneCountryCodeTextBox;
        private System.Windows.Forms.Label phoneCountryCodeLabel;
        private System.Windows.Forms.Label phoneCityCodeLabel;
        private System.Windows.Forms.TextBox phoneCityCodeTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.Label phoneCommentLabel;
        private System.Windows.Forms.RichTextBox phoneCommentRichTextBox;
        private System.Windows.Forms.Button savePhoneButton;
    }
}