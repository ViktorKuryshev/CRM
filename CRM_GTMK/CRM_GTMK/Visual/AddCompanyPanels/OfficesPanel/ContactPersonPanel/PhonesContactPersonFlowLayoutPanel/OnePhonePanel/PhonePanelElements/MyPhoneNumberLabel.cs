using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.ContactPersonPanel.PhonesContactPersonFlowLayoutPanel.OnePhonePanel.PhonePanelElements
{
    public class MyPhoneNumberLabel : Label
    {
        public MyPhoneNumberLabel(AddNewContactPersonForm form)
        {
            Label phoneNumberLabel = form.GetPhoneNumberLabel();

           AutoSize = phoneNumberLabel.AutoSize;
           Location = phoneNumberLabel.Location;
           Name = phoneNumberLabel.Name;
           Size = phoneNumberLabel.Size;
           TabIndex = phoneNumberLabel.TabIndex;
           Text = phoneNumberLabel.Text;
        }
    }
}
