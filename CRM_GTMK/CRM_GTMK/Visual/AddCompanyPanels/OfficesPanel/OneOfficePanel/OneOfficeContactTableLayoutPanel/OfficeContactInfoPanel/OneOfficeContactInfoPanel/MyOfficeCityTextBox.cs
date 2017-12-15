using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.GeneralContactInfoPanel.OfficeContactInfoPanel.OneOfficeContactInfoPanel
{
    public class MyOfficeCityTextBox : TextBox
    {
        public MyOfficeCityTextBox(AddNewCompanyForm form)
        {
            TextBox textBox = form.GetOfficeCityTextBox();

            Location = textBox.Location;
            Name = textBox.Name;
            Size = textBox.Size;
            TabIndex = textBox.TabIndex;
        }
    }
}
