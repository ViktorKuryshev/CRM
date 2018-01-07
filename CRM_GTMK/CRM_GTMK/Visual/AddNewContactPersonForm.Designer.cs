namespace CRM_GTMK.Visual
{
    partial class AddNewContactPersonForm
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
            this.lastnameContactPersonLabel = new System.Windows.Forms.Label();
            this.lastnameContactPersonTextBox = new System.Windows.Forms.TextBox();
            this.firstnameContactPersonLabel = new System.Windows.Forms.Label();
            this.firstnameContactPersonTextBox = new System.Windows.Forms.TextBox();
            this.patronymicContactPersonLabel = new System.Windows.Forms.Label();
            this.middleNameContactPersonTextBox = new System.Windows.Forms.TextBox();
            this.positionContactPersonLabel = new System.Windows.Forms.Label();
            this.positionContactPersonTextBox = new System.Windows.Forms.TextBox();
            this.emailContactPersonComboBox = new System.Windows.Forms.ComboBox();
            this.emailContactPersonTextBox = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.commentRichTextBox = new System.Windows.Forms.RichTextBox();
            this.commentPanel = new System.Windows.Forms.Panel();
            this.commentsContactPersonFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.commentsInnerFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.addNewCommentContactPersonButton = new System.Windows.Forms.Button();
            this.saveNewContactPersonButton = new System.Windows.Forms.Button();
            this.phoneContactPersonPanel = new System.Windows.Forms.Panel();
            this.phoneCommentTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberLinkLabel = new System.Windows.Forms.LinkLabel();
            this.phoneTypeLabel = new System.Windows.Forms.Label();
            this.addNewContactPersonPhoneButton = new System.Windows.Forms.Button();
            this.phonesContactPersonFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.commentPanel.SuspendLayout();
            this.commentsContactPersonFlowLayoutPanel.SuspendLayout();
            this.commentsInnerFlowLayoutPanel.SuspendLayout();
            this.phoneContactPersonPanel.SuspendLayout();
            this.phonesContactPersonFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lastnameContactPersonLabel
            // 
            this.lastnameContactPersonLabel.AutoSize = true;
            this.lastnameContactPersonLabel.Location = new System.Drawing.Point(49, 32);
            this.lastnameContactPersonLabel.Name = "lastnameContactPersonLabel";
            this.lastnameContactPersonLabel.Size = new System.Drawing.Size(59, 13);
            this.lastnameContactPersonLabel.TabIndex = 0;
            this.lastnameContactPersonLabel.Text = "Фамилия:";
            // 
            // lastnameContactPersonTextBox
            // 
            this.lastnameContactPersonTextBox.Location = new System.Drawing.Point(115, 29);
            this.lastnameContactPersonTextBox.Name = "lastnameContactPersonTextBox";
            this.lastnameContactPersonTextBox.Size = new System.Drawing.Size(150, 20);
            this.lastnameContactPersonTextBox.TabIndex = 1;
            // 
            // firstnameContactPersonLabel
            // 
            this.firstnameContactPersonLabel.AutoSize = true;
            this.firstnameContactPersonLabel.Location = new System.Drawing.Point(76, 69);
            this.firstnameContactPersonLabel.Name = "firstnameContactPersonLabel";
            this.firstnameContactPersonLabel.Size = new System.Drawing.Size(32, 13);
            this.firstnameContactPersonLabel.TabIndex = 2;
            this.firstnameContactPersonLabel.Text = "Имя:";
            // 
            // firstnameContactPersonTextBox
            // 
            this.firstnameContactPersonTextBox.Location = new System.Drawing.Point(115, 66);
            this.firstnameContactPersonTextBox.Name = "firstnameContactPersonTextBox";
            this.firstnameContactPersonTextBox.Size = new System.Drawing.Size(150, 20);
            this.firstnameContactPersonTextBox.TabIndex = 3;
            // 
            // patronymicContactPersonLabel
            // 
            this.patronymicContactPersonLabel.AutoSize = true;
            this.patronymicContactPersonLabel.Location = new System.Drawing.Point(51, 106);
            this.patronymicContactPersonLabel.Name = "patronymicContactPersonLabel";
            this.patronymicContactPersonLabel.Size = new System.Drawing.Size(57, 13);
            this.patronymicContactPersonLabel.TabIndex = 4;
            this.patronymicContactPersonLabel.Text = "Отчетсво:";
            // 
            // middleNameContactPersonTextBox
            // 
            this.middleNameContactPersonTextBox.Location = new System.Drawing.Point(115, 103);
            this.middleNameContactPersonTextBox.Name = "middleNameContactPersonTextBox";
            this.middleNameContactPersonTextBox.Size = new System.Drawing.Size(150, 20);
            this.middleNameContactPersonTextBox.TabIndex = 5;
            // 
            // positionContactPersonLabel
            // 
            this.positionContactPersonLabel.AutoSize = true;
            this.positionContactPersonLabel.Location = new System.Drawing.Point(40, 146);
            this.positionContactPersonLabel.Name = "positionContactPersonLabel";
            this.positionContactPersonLabel.Size = new System.Drawing.Size(68, 13);
            this.positionContactPersonLabel.TabIndex = 6;
            this.positionContactPersonLabel.Text = "Должность:";
            // 
            // positionContactPersonTextBox
            // 
            this.positionContactPersonTextBox.Location = new System.Drawing.Point(115, 143);
            this.positionContactPersonTextBox.Name = "positionContactPersonTextBox";
            this.positionContactPersonTextBox.Size = new System.Drawing.Size(150, 20);
            this.positionContactPersonTextBox.TabIndex = 7;
            // 
            // emailContactPersonComboBox
            // 
            this.emailContactPersonComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.emailContactPersonComboBox.FormattingEnabled = true;
            this.emailContactPersonComboBox.Items.AddRange(new object[] {
            "Эл. почта 1",
            "Эл. почта 2",
            "Эл. почта 3"});
            this.emailContactPersonComboBox.Location = new System.Drawing.Point(18, 181);
            this.emailContactPersonComboBox.Name = "emailContactPersonComboBox";
            this.emailContactPersonComboBox.Size = new System.Drawing.Size(87, 21);
            this.emailContactPersonComboBox.TabIndex = 8;
            this.emailContactPersonComboBox.DropDown += new System.EventHandler(this.emailContactPersonComboBox_DropDown);
            this.emailContactPersonComboBox.DropDownClosed += new System.EventHandler(this.emailContactPersonComboBox_DropDownClosed);
            // 
            // emailContactPersonTextBox
            // 
            this.emailContactPersonTextBox.Location = new System.Drawing.Point(115, 182);
            this.emailContactPersonTextBox.Name = "emailContactPersonTextBox";
            this.emailContactPersonTextBox.Size = new System.Drawing.Size(150, 20);
            this.emailContactPersonTextBox.TabIndex = 9;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(3, 3);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(91, 26);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "27.12.2017 18:20\r\nДобавил Вася";
            // 
            // commentRichTextBox
            // 
            this.commentRichTextBox.Location = new System.Drawing.Point(100, 3);
            this.commentRichTextBox.Name = "commentRichTextBox";
            this.commentRichTextBox.Size = new System.Drawing.Size(232, 84);
            this.commentRichTextBox.TabIndex = 1;
            this.commentRichTextBox.Text = "";
            // 
            // commentPanel
            // 
            this.commentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.commentPanel.Controls.Add(this.commentRichTextBox);
            this.commentPanel.Controls.Add(this.dateLabel);
            this.commentPanel.Location = new System.Drawing.Point(3, 3);
            this.commentPanel.Name = "commentPanel";
            this.commentPanel.Size = new System.Drawing.Size(335, 90);
            this.commentPanel.TabIndex = 32;
            // 
            // commentsContactPersonFlowLayoutPanel
            // 
            this.commentsContactPersonFlowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.commentsContactPersonFlowLayoutPanel.AutoScroll = true;
            this.commentsContactPersonFlowLayoutPanel.Controls.Add(this.commentsInnerFlowLayoutPanel);
            this.commentsContactPersonFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.commentsContactPersonFlowLayoutPanel.Location = new System.Drawing.Point(408, 51);
            this.commentsContactPersonFlowLayoutPanel.Name = "commentsContactPersonFlowLayoutPanel";
            this.commentsContactPersonFlowLayoutPanel.Size = new System.Drawing.Size(366, 368);
            this.commentsContactPersonFlowLayoutPanel.TabIndex = 33;
            this.commentsContactPersonFlowLayoutPanel.WrapContents = false;
            // 
            // commentsInnerFlowLayoutPanel
            // 
            this.commentsInnerFlowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.commentsInnerFlowLayoutPanel.AutoSize = true;
            this.commentsInnerFlowLayoutPanel.Controls.Add(this.commentPanel);
            this.commentsInnerFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.commentsInnerFlowLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.commentsInnerFlowLayoutPanel.Name = "commentsInnerFlowLayoutPanel";
            this.commentsInnerFlowLayoutPanel.Size = new System.Drawing.Size(341, 96);
            this.commentsInnerFlowLayoutPanel.TabIndex = 33;
            this.commentsInnerFlowLayoutPanel.WrapContents = false;
            // 
            // addNewCommentContactPersonButton
            // 
            this.addNewCommentContactPersonButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addNewCommentContactPersonButton.Location = new System.Drawing.Point(554, 9);
            this.addNewCommentContactPersonButton.Name = "addNewCommentContactPersonButton";
            this.addNewCommentContactPersonButton.Size = new System.Drawing.Size(105, 36);
            this.addNewCommentContactPersonButton.TabIndex = 34;
            this.addNewCommentContactPersonButton.Text = "Добавить комментарий";
            this.addNewCommentContactPersonButton.UseVisualStyleBackColor = true;
            this.addNewCommentContactPersonButton.Click += new System.EventHandler(this.addNewCommentContactPersonButton_Click);
            // 
            // saveNewContactPersonButton
            // 
            this.saveNewContactPersonButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.saveNewContactPersonButton.Location = new System.Drawing.Point(356, 425);
            this.saveNewContactPersonButton.Name = "saveNewContactPersonButton";
            this.saveNewContactPersonButton.Size = new System.Drawing.Size(76, 35);
            this.saveNewContactPersonButton.TabIndex = 35;
            this.saveNewContactPersonButton.Text = "Сохранить и закрыть";
            this.saveNewContactPersonButton.UseVisualStyleBackColor = true;
            this.saveNewContactPersonButton.Click += new System.EventHandler(this.saveNewContactPersonButton_Click);
            // 
            // phoneContactPersonPanel
            // 
            this.phoneContactPersonPanel.AutoSize = true;
            this.phoneContactPersonPanel.Controls.Add(this.phoneCommentTextBox);
            this.phoneContactPersonPanel.Controls.Add(this.phoneNumberLinkLabel);
            this.phoneContactPersonPanel.Controls.Add(this.phoneTypeLabel);
            this.phoneContactPersonPanel.Location = new System.Drawing.Point(3, 3);
            this.phoneContactPersonPanel.Name = "phoneContactPersonPanel";
            this.phoneContactPersonPanel.Size = new System.Drawing.Size(337, 25);
            this.phoneContactPersonPanel.TabIndex = 36;
            // 
            // phoneCommentTextBox
            // 
            this.phoneCommentTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.phoneCommentTextBox.Location = new System.Drawing.Point(187, 2);
            this.phoneCommentTextBox.Name = "phoneCommentTextBox";
            this.phoneCommentTextBox.ReadOnly = true;
            this.phoneCommentTextBox.Size = new System.Drawing.Size(147, 20);
            this.phoneCommentTextBox.TabIndex = 2;
            // 
            // phoneNumberLinkLabel
            // 
            this.phoneNumberLinkLabel.AutoSize = true;
            this.phoneNumberLinkLabel.Location = new System.Drawing.Point(73, 6);
            this.phoneNumberLinkLabel.Name = "phoneNumberLinkLabel";
            this.phoneNumberLinkLabel.Size = new System.Drawing.Size(97, 13);
            this.phoneNumberLinkLabel.TabIndex = 37;
            this.phoneNumberLinkLabel.TabStop = true;
            this.phoneNumberLinkLabel.Text = "+7 (950) 123-45-67";
            // 
            // phoneTypeLabel
            // 
            this.phoneTypeLabel.AutoSize = true;
            this.phoneTypeLabel.Location = new System.Drawing.Point(3, 5);
            this.phoneTypeLabel.Name = "phoneTypeLabel";
            this.phoneTypeLabel.Size = new System.Drawing.Size(49, 13);
            this.phoneTypeLabel.TabIndex = 0;
            this.phoneTypeLabel.Text = "Рабочий";
            // 
            // addNewContactPersonPhoneButton
            // 
            this.addNewContactPersonPhoneButton.Location = new System.Drawing.Point(18, 218);
            this.addNewContactPersonPhoneButton.Name = "addNewContactPersonPhoneButton";
            this.addNewContactPersonPhoneButton.Size = new System.Drawing.Size(113, 23);
            this.addNewContactPersonPhoneButton.TabIndex = 37;
            this.addNewContactPersonPhoneButton.Text = "Добавить телефон";
            this.addNewContactPersonPhoneButton.UseVisualStyleBackColor = true;
            this.addNewContactPersonPhoneButton.Click += new System.EventHandler(this.addNewContactPersonPhoneButton_Click);
            // 
            // phonesContactPersonFlowLayoutPanel
            // 
            this.phonesContactPersonFlowLayoutPanel.AutoScroll = true;
            this.phonesContactPersonFlowLayoutPanel.Controls.Add(this.phoneContactPersonPanel);
            this.phonesContactPersonFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.phonesContactPersonFlowLayoutPanel.Location = new System.Drawing.Point(18, 247);
            this.phonesContactPersonFlowLayoutPanel.Name = "phonesContactPersonFlowLayoutPanel";
            this.phonesContactPersonFlowLayoutPanel.Size = new System.Drawing.Size(357, 172);
            this.phonesContactPersonFlowLayoutPanel.TabIndex = 38;
            this.phonesContactPersonFlowLayoutPanel.WrapContents = false;
            // 
            // AddNewContactPersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(786, 472);
            this.Controls.Add(this.saveNewContactPersonButton);
            this.Controls.Add(this.phonesContactPersonFlowLayoutPanel);
            this.Controls.Add(this.addNewContactPersonPhoneButton);
            this.Controls.Add(this.addNewCommentContactPersonButton);
            this.Controls.Add(this.commentsContactPersonFlowLayoutPanel);
            this.Controls.Add(this.emailContactPersonTextBox);
            this.Controls.Add(this.emailContactPersonComboBox);
            this.Controls.Add(this.positionContactPersonTextBox);
            this.Controls.Add(this.positionContactPersonLabel);
            this.Controls.Add(this.middleNameContactPersonTextBox);
            this.Controls.Add(this.patronymicContactPersonLabel);
            this.Controls.Add(this.firstnameContactPersonTextBox);
            this.Controls.Add(this.firstnameContactPersonLabel);
            this.Controls.Add(this.lastnameContactPersonTextBox);
            this.Controls.Add(this.lastnameContactPersonLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AddNewContactPersonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить нового сотрудника";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddNewContactPersonForm_FormClosing);
            this.commentPanel.ResumeLayout(false);
            this.commentPanel.PerformLayout();
            this.commentsContactPersonFlowLayoutPanel.ResumeLayout(false);
            this.commentsContactPersonFlowLayoutPanel.PerformLayout();
            this.commentsInnerFlowLayoutPanel.ResumeLayout(false);
            this.phoneContactPersonPanel.ResumeLayout(false);
            this.phoneContactPersonPanel.PerformLayout();
            this.phonesContactPersonFlowLayoutPanel.ResumeLayout(false);
            this.phonesContactPersonFlowLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lastnameContactPersonLabel;
        private System.Windows.Forms.TextBox lastnameContactPersonTextBox;
        private System.Windows.Forms.Label firstnameContactPersonLabel;
        private System.Windows.Forms.TextBox firstnameContactPersonTextBox;
        private System.Windows.Forms.Label patronymicContactPersonLabel;
        private System.Windows.Forms.TextBox middleNameContactPersonTextBox;
        private System.Windows.Forms.Label positionContactPersonLabel;
        private System.Windows.Forms.TextBox positionContactPersonTextBox;
        private System.Windows.Forms.TextBox emailContactPersonTextBox;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.RichTextBox commentRichTextBox;
        private System.Windows.Forms.Panel commentPanel;
        private System.Windows.Forms.FlowLayoutPanel commentsContactPersonFlowLayoutPanel;
        private System.Windows.Forms.Button addNewCommentContactPersonButton;
        private System.Windows.Forms.Button saveNewContactPersonButton;
        private System.Windows.Forms.Panel phoneContactPersonPanel;
        private System.Windows.Forms.TextBox phoneCommentTextBox;
        private System.Windows.Forms.Label phoneTypeLabel;
        private System.Windows.Forms.Button addNewContactPersonPhoneButton;
        private System.Windows.Forms.FlowLayoutPanel phonesContactPersonFlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel commentsInnerFlowLayoutPanel;
        private System.Windows.Forms.ComboBox emailContactPersonComboBox;
        private System.Windows.Forms.LinkLabel phoneNumberLinkLabel;
    }
}