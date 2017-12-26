using CRM_GTMK.Control;
using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.ContactPersonPanel.CommentsContactPersonFlowLayoutPanel.CommentsInnerFlowLayoutPanel.OneCommentPanel;
using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.ContactPersonPanel.PhonesContactPersonFlowLayoutPanel.OneContactPersonPhonePanel;
using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.ContactPersonPanel.PhonesContactPersonFlowLayoutPanel.OneContactPersonPhonePanel.ContactPersonPhonePanelElements;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CRM_GTMK.Visual
{
    public partial class AddNewContactPersonForm : Form
    {
        private Controller _controller;

        public int OfficeNumber { get; set; }
        public List<AddNewContactPersonPhoneForm> MyContactPersonPhoneFormList { get; set; } = new List<AddNewContactPersonPhoneForm>();
        public List<MyCommentPanel> MyCommentPanelList { get; set; } = new List<MyCommentPanel>();

        public string LastnameContactPerson { get; set; }
        public string FirstnameContactPerson { get; set; }
        public string MiddleNameContactPerson { get; set; }
        public string PositionContactPerson { get; set; }
        public string[] EmailContactPerson { get; set; } = new string[] { "", "", "" };

        public AddNewContactPersonForm(Controller controller, int officeNumber)
        {
            _controller = controller;
            OfficeNumber = officeNumber;
            InitializeComponent();
            ResetForms();
        }

        private void ResetForms()
        {
            phonesContactPersonFlowLayoutPanel.Controls.Remove(phoneContactPersonPanel);
            commentsInnerFlowLayoutPanel.Controls.Remove(commentPanel);
            emailContactPersonComboBox.SelectedIndex = 0;
        }

        #region Getters

        public FlowLayoutPanel GetCommentsContactPersonFlowLayoutPanel()
        {
            return commentsContactPersonFlowLayoutPanel;
        }

        public Panel GetCommentPanel()
        {
            return commentPanel;
        }

        public Label GetDateLabel()
        {
            return dateLabel;
        }

        public RichTextBox GetCommentRichTextBox()
        {
            return commentRichTextBox;
        }

        public FlowLayoutPanel GetPhonesContactPersonFlowLayoutPanel()
        {
            return phonesContactPersonFlowLayoutPanel;
        }

        public Panel GetPhonePanel()
        {
            return phoneContactPersonPanel;
        }

        public TextBox GetPhoneCommentTextBox()
        {
            return phoneCommentTextBox;
        }

        public Label GetPhoneNumberLabel()
        {
            return phoneNumberLabel;
        }

        public Label GetPhoneTypeLabel()
        {
            return phoneTypeLabel;
        }

        public FlowLayoutPanel GetCommentsInnerFlowLayoutPanel()
        {
            return commentsInnerFlowLayoutPanel;
        }

        #endregion

        private void addNewCommentContactPersonButton_Click(object sender, EventArgs e)
        {
            MyCommentPanel newCommentPanel = new MyCommentPanel(this);
            MyCommentPanelList.Add(newCommentPanel);
            commentsInnerFlowLayoutPanel.Controls.Add(newCommentPanel);
        }

        private void addNewContactPersonPhoneButton_Click(object sender, EventArgs e)
        {
            _controller.ShowAddNewContactPersonPhoneForm(this);
        }

        public void AddAndDisplayNewContactPersonPanel(AddNewContactPersonPhoneForm form)
        {
            MyContactPersonPhonePanel contactPersonPhonePanel = new MyContactPersonPhonePanel(this);
            contactPersonPhonePanel.MyPhoneTypeLabel.Text = form.NewPhoneType;
            contactPersonPhonePanel.MyPhoneNumberLabel.Text = form.NewPhoneNumber;
            contactPersonPhonePanel.MyPhoneCommentTextBox.Text = form.NewPhoneComment;

            phonesContactPersonFlowLayoutPanel.Controls.Add(contactPersonPhonePanel);
        }

        private void saveNewContactPersonButton_Click(object sender, EventArgs e)
        {
            LastnameContactPerson = lastnameContactPersonTextBox.Text;
            FirstnameContactPerson = firstnameContactPersonTextBox.Text;
            MiddleNameContactPerson = middleNameContactPersonTextBox.Text;
            PositionContactPerson = positionContactPersonTextBox.Text;
            if (EmailContactPerson[0].Equals(""))
                EmailContactPerson[0] = emailContactPersonTextBox.Text;
        }

        private void emailContactPersonComboBox_MouseClick(object sender, MouseEventArgs e)
        {
            int chosenItem = emailContactPersonComboBox
                            .Items.IndexOf(emailContactPersonComboBox.SelectedItem);

            switch (chosenItem)
            {
                case 0:
                    EmailContactPerson[0] = emailContactPersonTextBox.Text;
                    break;
                case 1:
                    EmailContactPerson[1] = emailContactPersonTextBox.Text;
                    break;
                default:
                    EmailContactPerson[2] = emailContactPersonTextBox.Text;
                    break;
            }
        }

        private void emailContactPersonComboBox_DropDownClosed(object sender, EventArgs e)
        {
            int chosenItem = emailContactPersonComboBox
                            .Items.IndexOf(emailContactPersonComboBox.SelectedItem);

            switch (chosenItem)
            {
                case 0:
                    emailContactPersonTextBox.Text = EmailContactPerson[0];
                    break;
                case 1:
                    emailContactPersonTextBox.Text = EmailContactPerson[1];
                    break;
                default:
                    emailContactPersonTextBox.Text = EmailContactPerson[2];
                    break;
            }
        }
    }
}
