using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.OneOfficeContactTableLayoutPanel.OfficeContactInfoPanel.OneOfficeContactInfoPanel
{
    public class MyOfficeCountryComboBox : ComboBox
    {
        public MyOfficeCountryComboBox(AddNewCompanyForm form)
        {
            ComboBox comboBox = form.GetOfficeCountryComboBox();

            FormattingEnabled = comboBox.FormattingEnabled;

            // Здесь необходимо автоматизировать получение количества элементов в списке.
            Items.AddRange(new object[] {"Россия"});
            Location = comboBox.Location;
            Name = comboBox.Name;
            Size = comboBox.Size;
            TabIndex = comboBox.TabIndex;
        }
    }
}
