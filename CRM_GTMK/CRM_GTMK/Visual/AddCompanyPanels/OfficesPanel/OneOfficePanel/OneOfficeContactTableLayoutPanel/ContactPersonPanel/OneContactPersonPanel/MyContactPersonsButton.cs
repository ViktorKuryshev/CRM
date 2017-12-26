using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.OneOfficeContactTableLayoutPanel.ContactPersonPanel.OneContactPersonPanel
{
    public class MyContactPersonsButton : Button
    {
        private AddNewCompanyForm _form;
        private MyOneOfficeContactTableLayoutPanel _myOneOfficeContactTableLayoutPanel;

        public MyContactPersonsButton(AddNewCompanyForm form, MyOneOfficeContactTableLayoutPanel myOneOfficeContactTableLayoutPanel)
        {
            _form = form;
            _myOneOfficeContactTableLayoutPanel = myOneOfficeContactTableLayoutPanel;
            
            Button button = form.GetContactPersonsButton();

            Location = button.Location;
            Name = button.Name;
            Size = button.Size;
            TabIndex = button.TabIndex;
            Text = button.Text;
            UseVisualStyleBackColor = button.UseVisualStyleBackColor;

            Click += MyContactPersonsButton_Click;
        }

        private void MyContactPersonsButton_Click(object sender, EventArgs e)
        {
            _form.AddNewContactPerson(_myOneOfficeContactTableLayoutPanel);
        }
    }
}
