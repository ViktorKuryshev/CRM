using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.ContactPersonPanel.PhonesContactPersonFlowLayoutPanel.OnePhonePanel.PhonePanelElements
{
    public class MyPhoneTypeLabel : Label
    {
        public MyPhoneTypeLabel(AddNewContactPersonForm form)
        {
            Label phoneTypeLabel = form.GetPhoneTypeLabel();

            AutoSize = phoneTypeLabel.AutoSize;
            Location = phoneTypeLabel.Location;
            Name = phoneTypeLabel.Name;
            Size = phoneTypeLabel.Size;
            TabIndex = phoneTypeLabel.TabIndex;
            Text = phoneTypeLabel.Text;
        }
    }
}
