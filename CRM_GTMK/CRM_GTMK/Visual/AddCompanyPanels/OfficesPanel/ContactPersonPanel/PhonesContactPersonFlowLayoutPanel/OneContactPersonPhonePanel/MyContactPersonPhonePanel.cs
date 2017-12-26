using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.ContactPersonPanel.PhonesContactPersonFlowLayoutPanel.OneContactPersonPhonePanel.ContactPersonPhonePanelElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.ContactPersonPanel.PhonesContactPersonFlowLayoutPanel.OneContactPersonPhonePanel
{
    public class MyContactPersonPhonePanel : Panel
    {
        public MyPhoneCommentTextBox MyPhoneCommentTextBox { get; set; }
        public MyPhoneNumberLabel MyPhoneNumberLabel { get; set; }
        public MyPhoneTypeLabel MyPhoneTypeLabel { get; set; }

        public MyContactPersonPhonePanel(AddNewContactPersonForm form)
        {
            Panel phonePanel = form.GetPhonePanel();

            Location = phonePanel.Location;
            Name = phonePanel.Name;
            Size = phonePanel.Size;
            TabIndex = phonePanel.TabIndex;

            MyPhoneCommentTextBox = new MyPhoneCommentTextBox(form);
            MyPhoneNumberLabel = new MyPhoneNumberLabel(form);
            MyPhoneTypeLabel = new MyPhoneTypeLabel(form);

            Controls.Add(MyPhoneCommentTextBox);
            Controls.Add(MyPhoneNumberLabel);
            Controls.Add(MyPhoneTypeLabel);
        }
    }
}
