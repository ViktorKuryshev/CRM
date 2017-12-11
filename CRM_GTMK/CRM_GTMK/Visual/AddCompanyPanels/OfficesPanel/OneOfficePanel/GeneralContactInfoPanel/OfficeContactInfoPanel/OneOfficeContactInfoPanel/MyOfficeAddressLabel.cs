using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.GeneralContactInfoPanel.OfficeContactInfoPanel.OneOfficeContactInfoPanel
{
    public class MyOfficeAddressLabel : Label
    {
        public MyOfficeAddressLabel(AddNewCompanyForm form)
        {
            Label officeAddressLabel = form.GetOfficeAddressLabel();

            AutoSize = officeAddressLabel.AutoSize;
            Location = officeAddressLabel.Location;
            Name = officeAddressLabel.Name;
            Size = officeAddressLabel.Size;
            TabIndex = officeAddressLabel.TabIndex;
            Text = officeAddressLabel.Text;
        }
    }
}
