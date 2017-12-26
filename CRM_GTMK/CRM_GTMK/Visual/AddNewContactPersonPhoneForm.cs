using CRM_GTMK.Control;
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
        }

        private void savePhoneButton_Click(object sender, EventArgs e)
        {
            NewPhoneType = phoneTypeComboBox.Text;
            NewPhoneNumber = FormatPhoneNumber();
            NewPhoneComment = phoneCommentRichTextBox.Text;
            _contactPersonForm.AddAndDisplayNewContactPersonPanel(this);
            this.Dispose();
        }

    private string FormatPhoneNumber()
        {
            string phoneNumber = phoneCountryCodeTextBox.Text + " (" +
                                    phoneCityCodeTextBox.Text + ") " +
                                    string.Format("{0:###-##-##}", Int32.Parse(phoneNumberTextBox.Text));
            return phoneNumber;
        }
    }
}
