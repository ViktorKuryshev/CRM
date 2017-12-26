using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.OneOfficeContactTableLayoutPanel.OfficeContactInfoPanel.OneOfficeContactInfoPanel
{
    public class MyOfficeAddressLabel : Label
    {
        public MyOfficeAddressLabel(AddNewCompanyForm form)
        {
            Label label = form.GetOfficeAddressLabel();

            AutoSize = label.AutoSize;
            Location = label.Location;
            Name = label.Name;
            Size = label.Size;
            TabIndex = label.TabIndex;
            Text = label.Text;
        }
    }
}
