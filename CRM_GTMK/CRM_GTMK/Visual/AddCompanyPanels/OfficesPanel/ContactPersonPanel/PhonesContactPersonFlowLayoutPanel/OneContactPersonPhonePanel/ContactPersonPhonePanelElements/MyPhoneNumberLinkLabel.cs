using System;
using System.Windows.Forms;

namespace CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.ContactPersonPanel.PhonesContactPersonFlowLayoutPanel.OneContactPersonPhonePanel.ContactPersonPhonePanelElements
{
    public class MyPhoneNumberLinkLabel : LinkLabel
    {
        private AddNewContactPersonForm _form;
        private AddNewContactPersonPhoneForm _phoneForm;
        private MyContactPersonPhonePanel _phonePanel;

        public MyPhoneNumberLinkLabel(AddNewContactPersonForm form,
                                      AddNewContactPersonPhoneForm phoneForm,
                                      MyContactPersonPhonePanel phonePanel)
        {
            _form = form;
            _phoneForm = phoneForm;
            _phonePanel = phonePanel;

            LinkLabel phoneNumberLinkLabel = form.GetPhoneNumberLinkLabel();

            AutoSize = phoneNumberLinkLabel.AutoSize;
            Location = phoneNumberLinkLabel.Location;
            Name = phoneNumberLinkLabel.Name;
            Size = phoneNumberLinkLabel.Size;
            TabIndex = phoneNumberLinkLabel.TabIndex;
            TabStop = phoneNumberLinkLabel.TabStop;
            Text = phoneNumberLinkLabel.Text;
            Click += new System.EventHandler(isClicked);
        }

        private void isClicked(object sender, EventArgs e)
        {
            _form.ReopenContactPersonPhone(_phoneForm, _phonePanel);
        }
    }
}
