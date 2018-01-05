using CRM_GTMK.Control;
using System;
using System.Linq;
using System.Text.RegularExpressions;
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
        // Сохраняем введенные данные после нажатия на кнопку "Сохранить и закрыть"
        private void savePhoneButton_Click(object sender, EventArgs e)
        {
            NewPhoneType = phoneTypeComboBox.Text;

            if (checkPhoneTextBoxesWithoutLetters())
                return;
            if (checkPhoneTextBoxesFilledIn())
                return;
            if (checkPhoneNumberTextBoxForMaxDigits())
                return;

            NewPhoneNumber = formatPhoneNumber();
            NewPhoneComment = phoneCommentRichTextBox.Text;
            _contactPersonForm.AddAndDisplayNewContactPersonPhone(this);
            this.Dispose();
        }

        /// <summary>
        /// Методы, предназначенные для проверки ввода номера телефона
        /// </summary>
        #region Checkers

        // Проверка отсутствия букв
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
        // Проверка наличия ввода
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

        // Проверка максимального количества введенных цифр в поле phoneNumberTextBox (должно быть не более 10 цифр)
        private bool checkPhoneNumberTextBoxForMaxDigits()
        {
            if(phoneNumberTextBox.Text.Length >= 11)
            {
                MessageBox.Show("Номер телефона должен содержать не более 10 цифр.");
                return true;
            }
            return false;
        }
        #endregion

        // Форматируем введенный номер телефона в виде +1 (234) 567-89-00
        private string formatPhoneNumber()
        {
            string phoneNumber = Regex.Replace(phoneNumberTextBox.Text, @"(\d{3})(\d{2})(\d{2})", "$1-$2-$3");

            phoneNumber = phoneCountryCodeTextBox.Text + " (" +
                             phoneCityCodeTextBox.Text + ") " +
                             phoneNumber;

            return phoneNumber;
        }
    }
}
