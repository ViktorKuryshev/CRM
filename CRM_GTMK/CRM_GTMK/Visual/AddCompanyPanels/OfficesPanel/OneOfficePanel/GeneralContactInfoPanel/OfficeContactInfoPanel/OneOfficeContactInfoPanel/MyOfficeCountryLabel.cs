using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.GeneralContactInfoPanel.OfficeContactInfoPanel.OneOfficeContactInfoPanel
{
    public class MyOfficeCountryLabel : Label
    {
        public MyOfficeCountryLabel(AddNewCompanyForm form)
        {
            Label officeCountryLabel = form.GetOfficeCountryLabel();

            AutoSize = true;
            Location = officeCountryLabel.Location;
            Name = officeCountryLabel.Name;
            Size = officeCountryLabel.Size;
            TabIndex = officeCountryLabel.TabIndex;
            Text = officeCountryLabel.Text;
        }
    }
}
