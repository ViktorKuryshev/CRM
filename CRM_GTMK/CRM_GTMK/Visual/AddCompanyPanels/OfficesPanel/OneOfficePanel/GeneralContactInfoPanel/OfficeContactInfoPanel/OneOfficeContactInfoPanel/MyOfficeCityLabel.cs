using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.GeneralContactInfoPanel.OfficeContactInfoPanel.OneOfficeContactInfoPanel
{
    public class MyOfficeCityLabel : Label
    {
        public MyOfficeCityLabel(AddNewCompanyForm form)
        {
            Label officeCityLabel = form.GetOfficeCityLabel();

            AutoSize = true;
            Location = officeCityLabel.Location;
            Name = officeCityLabel.Name;
            Size = officeCityLabel.Size;
            TabIndex = officeCityLabel.TabIndex;
            Text = officeCityLabel.Text;
        }
    }
}
