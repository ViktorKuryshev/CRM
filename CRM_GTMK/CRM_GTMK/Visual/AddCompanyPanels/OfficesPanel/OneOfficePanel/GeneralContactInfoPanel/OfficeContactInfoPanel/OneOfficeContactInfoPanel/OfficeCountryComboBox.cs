using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.GeneralContactInfoPanel.OfficeContactInfoPanel.OneOfficeContactInfoPanel
{
    public class OfficeCountryComboBox : ComboBox
    {
        public OfficeCountryComboBox(AddNewCompanyForm form)
        {
            ComboBox officeCountryComboBox = form.GetOfficeCountryComboBox();

            FormattingEnabled = true;
            Items.AddRange(new object[] {"Россия"});
            Location = officeCountryComboBox.Location;
            Name = officeCountryComboBox.Name;
            Size = officeCountryComboBox.Size;
            TabIndex = officeCountryComboBox.TabIndex;
        }
    }
}
