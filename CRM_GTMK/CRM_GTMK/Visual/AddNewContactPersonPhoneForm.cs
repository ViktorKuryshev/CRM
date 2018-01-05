using CRM_GTMK.Control;
using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.ContactPersonPanel.CommentsContactPersonFlowLayoutPanel.CommentsInnerFlowLayoutPanel.OneCommentPanel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_GTMK.Visual
{
    public partial class AddNewContactPersonPhoneForm : Form
    {
        private Controller _controller;
        private AddNewContactPersonForm _contactPersonForm;

        public string NewPhoneType { get; set; }
        public string NewPhoneNumber { get; set; }
        public string NewPhoneComment { get; set; }

        public AddNewContactPersonPhoneForm(Controller controller, AddNewContactPersonForm contactPersonForm)
        {
            _controller = controller;
            _contactPersonForm = contactPersonForm;
            InitializeComponent();
            phoneTypeComboBox.SelectedIndex = 0;
        }

        private void savePhoneButton_Click(object sender, EventArgs e)
        {
            NewPhoneType = phoneTypeComboBox.Text;

            if (checkPhoneTextBoxesWithoutLetters())
                return;
            if (checkPhoneTextBoxesFilledIn())
                return;
            if (formatPhoneNumber() == "")
                return;

            NewPhoneNumber = formatPhoneNumber();
            NewPhoneComment = phoneCommentRichTextBox.Text;
            _contactPersonForm.AddAndDisplayNewContactPersonPhone(this);
            this.Dispose();
        }

        #region Checkers
        private bool checkPhoneTextBoxesWithoutLetters()
        {
            if (phoneCountryCodeTextBox.Text.Any(char.IsLetter) ||
                phoneCityCodeTextBox.Text.Any(char.IsLetter) ||
                phoneNumberTextBox.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Поля \"Код страны\", \"Код города\" и \"Номер\" " +
                                "не должны содержать букв.");
                return true;
            }
            return false;
        }

        private bool checkPhoneTextBoxesFilledIn()
        {
            if (!phoneCountryCodeTextBox.Text.Any(char.IsDigit) ||
                phoneCityCodeTextBox.Text == "" ||
                phoneNumberTextBox.Text == "")
            {
                MessageBox.Show("Поля \"Код страны\", \"Код города\" и \"Номер\" должны быть заполнены.");
                return true;
            }
            return false;
        }
        #endregion
        
        private string formatPhoneNumber() // Check the case when all the digits put in are 0.
        {
            try
            {
                string phoneNumber = phoneCountryCodeTextBox.Text + " (" +
                                     phoneCityCodeTextBox.Text + ") " +
                                     string.Format("{0:###-##-##}", 
                                     Int32.Parse(phoneNumberTextBox.Text));
                return phoneNumber;
            }
            catch (Exception)
            {
                MessageBox.Show("Номер телефона должен содержать от 1 до 10 цифр.");
                return "";
            }
        }
    }
}
