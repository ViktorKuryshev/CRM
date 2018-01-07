using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.ContactPersonPanel.PhonesContactPersonFlowLayoutPanel.OneContactPersonPhonePanel.ContactPersonPhonePanelElements;
using System.Windows.Forms;

namespace CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.ContactPersonPanel.PhonesContactPersonFlowLayoutPanel.OneContactPersonPhonePanel
{
    public class MyContactPersonPhonePanel : Panel
    {
        public MyPhoneCommentTextBox MyPhoneCommentTextBox { get; set; }
        public MyPhoneNumberLinkLabel MyPhoneNumberLinkLabel { get; set; }
        public MyPhoneTypeLabel MyPhoneTypeLabel { get; set; }

        public MyContactPersonPhonePanel(AddNewContactPersonForm form, AddNewContactPersonPhoneForm phoneForm)
        {
            Panel phonePanel = form.GetPhonePanel();

            Location = phonePanel.Location;
            Name = phonePanel.Name;
            Size = phonePanel.Size;
            TabIndex = phonePanel.TabIndex;

            MyPhoneCommentTextBox = new MyPhoneCommentTextBox(form);
            MyPhoneNumberLinkLabel = new MyPhoneNumberLinkLabel(form, phoneForm, this);
            MyPhoneTypeLabel = new MyPhoneTypeLabel(form);

            Controls.Add(MyPhoneCommentTextBox);
            Controls.Add(MyPhoneNumberLinkLabel);
            Controls.Add(MyPhoneTypeLabel);
        }
    }
}
