using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.GeneralContactInfoPanel.OfficeContactInfoPanel.OneOfficeContactInfoPanel
{
    class OfficeAddressTextBox : TextBox
    {
        public OfficeAddressTextBox(AddNewCompanyForm form)
        {
            TextBox officeAddressTextBox = form.GetOfficeAddressTextBox();

            Location = officeAddressTextBox.Location;
            Name = officeAddressTextBox.Name;
            Size = officeAddressTextBox.Size;
            TabIndex = officeAddressTextBox.TabIndex;
        }
    }
}
