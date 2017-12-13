using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.GeneralContactInfoPanel.OfficeContactInfoPanel.OneOfficeContactInfoPanel
{
    public class MyOfficeAddressTextBox : TextBox
    {
        public MyOfficeAddressTextBox(AddNewCompanyForm form)
        {
            TextBox officeAddressTextBox = form.GetOfficeAddressTextBox();

            Location = officeAddressTextBox.Location;
            Name = officeAddressTextBox.Name;
            Size = officeAddressTextBox.Size;
            TabIndex = officeAddressTextBox.TabIndex;
        }
    }
}
