using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.GeneralContactInfoPanel.OfficeContactInfoPanel.OneOfficeContactInfoPanel
{
    public class OfficeCityTextBox : TextBox
    {
        public OfficeCityTextBox(AddNewCompanyForm form)
        {
            TextBox officeCityTextBox = form.GetOfficeCityTextBox();

            Location = officeCityTextBox.Location;
            Name = officeCityTextBox.Name;
            Size = officeCityTextBox.Size;
            TabIndex = officeCityTextBox.TabIndex;
        }
    }
}
