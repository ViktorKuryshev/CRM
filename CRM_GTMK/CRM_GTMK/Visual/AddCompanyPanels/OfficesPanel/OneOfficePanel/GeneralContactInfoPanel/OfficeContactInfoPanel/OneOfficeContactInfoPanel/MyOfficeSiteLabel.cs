using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.GeneralContactInfoPanel.OfficeContactInfoPanel.OneOfficeContactInfoPanel
{
    public class MyOfficeSiteLabel : Label
    {
        public MyOfficeSiteLabel(AddNewCompanyForm form)
        {
            Label officeSiteLabel = form.GetOfficeSiteLabel();

            AutoSize = true;
            Location = officeSiteLabel.Location;
            Name = officeSiteLabel.Name;
            Size = officeSiteLabel.Size;
            TabIndex = officeSiteLabel.TabIndex;
            Text = officeSiteLabel.Text;
        }
    }
}
