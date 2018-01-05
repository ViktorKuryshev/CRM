using CRM_GTMK.Control;
using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.ContactPersonPanel.CommentsContactPersonFlowLayoutPanel.CommentsInnerFlowLayoutPanel.OneCommentPanel;
using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.ContactPersonPanel.CommentsContactPersonFlowLayoutPanel.CommentsInnerFlowLayoutPanel.OneCommentPanel.CommentPanelElements;
using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.ContactPersonPanel.PhonesContactPersonFlowLayoutPanel.OneContactPersonPhonePanel;
using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.ContactPersonPanel.PhonesContactPersonFlowLayoutPanel.OneContactPersonPhonePanel.ContactPersonPhonePanelElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CRM_GTMK.Visual
{
    public partial class AddNewContactPersonForm : Form
    {
        private Controller _controller;
        private AddNewCompanyForm _form;

        public int OfficeNumber { get; set; }
        public List<AddNewContactPersonPhoneForm> MyContactPersonPhoneFormList
        { get; set; } = new List<AddNewContactPersonPhoneForm>();
        public List<MyCommentPanel> MyCommentPanelList { get; set; } = new List<MyCommentPanel>();

        public string NameContactPerson { get; set; }
        public string LastnameContactPerson { get; set; }
        public string FirstnameContactPerson { get; set; }
        public string MiddleNameContactPerson { get; set; }
        public string PositionContactPerson { get; set; }
        public string[] EmailContactPerson { get; set; } = new string[] { "", "", "" };

        public AddNewContactPersonForm(Controller controller, int officeNumber, AddNewCompanyForm form)
        {
            _controller = controller;
            _form = form;
            OfficeNumber = officeNumber;
            InitializeComponent();
            resetForms();
        }

        private void resetForms()
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

        public void AddAndDisplayNewContactPersonPhone(AddNewContactPersonPhoneForm form)
        {
            MyContactPersonPhonePanel contactPersonPhonePanel = new MyContactPersonPhonePanel(this);
            contactPersonPhonePanel.MyPhoneTypeLabel.Text = form.NewPhoneType;
            contactPersonPhonePanel.MyPhoneNumberLabel.Text = form.NewPhoneNumber;
            contactPersonPhonePanel.MyPhoneCommentTextBox.Text = form.NewPhoneComment;

            phonesContactPersonFlowLayoutPanel.Controls.Add(contactPersonPhonePanel);
        }

        private void saveNewContactPersonButton_Click(object sender, EventArgs e)
        {
            emailContactPersonComboBox_DropDown(sender, e);

            setContactPersonNameParts();

            if (checkIfInputValid())
                return;

            NameContactPerson = lastnameContactPersonTextBox.Text + " " +
                                firstnameContactPersonTextBox.Text + " " +
                                middleNameContactPersonTextBox.Text;
            PositionContactPerson = positionContactPersonTextBox.Text;
            
            _controller.AddAndDisplayNewContactPerson(this, OfficeNumber);

            this.Close();
        }

        private void setContactPersonNameParts()
        {
            LastnameContactPerson = lastnameContactPersonTextBox.Text;
            FirstnameContactPerson = firstnameContactPersonTextBox.Text;
            MiddleNameContactPerson = middleNameContactPersonTextBox.Text;
        }

        #region Checkers
        private bool checkIfInputValid()
        {
            if (checkNameAndPosiotionInputWithoutDigits())
                return true;
            if (checkNameAndPosiotionInputWasMade())
                return true;
            if (checkEmailInput())
                return true;
            if (checkPhoneInput())
                return true;

            return false;
        }

        private bool checkNameAndPosiotionInputWasMade()
        {
            if (lastnameContactPersonTextBox.Text == "" ||
                firstnameContactPersonTextBox.Text == "" ||
                positionContactPersonTextBox.Text == "")
            {
                MessageBox.Show("Необходимо заполнить поля \"Фамилия\", \"Имя\" и \"Должность\".");
                return true;
            }
            return false;
        }

        private bool checkNameAndPosiotionInputWithoutDigits()
        {
            if (lastnameContactPersonTextBox.Text.Any(char.IsDigit) ||
                firstnameContactPersonTextBox.Text.Any(char.IsDigit) ||
                middleNameContactPersonTextBox.Text.Any(char.IsDigit) ||
                positionContactPersonTextBox.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Поля \"Фамилия\", \"Имя\", \"Отчество\" " +
                                "и \"Должность\" не должны содержать цифр.");
                return true;
            }
            return false;
        }

        private bool checkEmailInput()
        {
            if (EmailContactPerson.All(email => email == ""))//Need to change it to match all the cases
            {
                MessageBox.Show("Необходимо ввести хотя бы один адрес эл. почты.");
                return true;
            }
            foreach (string email in EmailContactPerson)
            {
                if (email == "")
                    continue;
                else if (!email.Contains("@"))
                {
                    MessageBox.Show("Адрес эл. почты обязательно должен содержать символ \"@\".");
                    return true;
                }
            }
            return false;
        }

        private bool checkPhoneInput()
        {
            if (MyContactPersonPhoneFormList.Count == 0)
            {
                MessageBox.Show("Необходимо ввести хотя бы один номер телефона.");
                return true;
            }
            return false;
        }
        #endregion

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

        private void emailContactPersonComboBox_DropDown(object sender, EventArgs e)
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
    }
}
