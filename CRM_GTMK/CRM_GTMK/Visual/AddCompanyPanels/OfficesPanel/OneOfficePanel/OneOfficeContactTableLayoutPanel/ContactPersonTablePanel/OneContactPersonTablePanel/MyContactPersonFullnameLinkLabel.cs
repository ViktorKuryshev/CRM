using System;
using System.Windows.Forms;

namespace CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.OneOfficeContactTableLayoutPanel.ContactPersonTablePanel.OneContactPersonTablePanel
{
    public class MyContactPersonFullnameLinkLabel : LinkLabel
    {
        private AddNewCompanyForm _form;
        private AddNewContactPersonForm _contactPersonForm;
        private MyContactPersonTableLayoutPanel _contactPersonTableLayoutPanel;

        public MyContactPersonFullnameLinkLabel(AddNewCompanyForm form,
                                                AddNewContactPersonForm contactPersonForm,
                                                MyContactPersonTableLayoutPanel contactPersonTableLayoutPanel)
        {
            _form = form;
            _contactPersonForm = contactPersonForm;
            _contactPersonTableLayoutPanel = contactPersonTableLayoutPanel;

            LinkLabel linkLabel = form.GetContactPersonLinkLabel();

            MaximumSize = linkLabel.MaximumSize;
            Anchor = linkLabel.Anchor;
            AutoSize = linkLabel.AutoSize;
            Location = linkLabel.Location;
            Name = linkLabel.Name;
            Size = linkLabel.Size;
            TabIndex = linkLabel.TabIndex;
            TabStop = linkLabel.TabStop;
            Text = linkLabel.Text;
            TextAlign = linkLabel.TextAlign;
            Click += new EventHandler(IsClicked);
        }

        private void IsClicked(object sender, EventArgs e)
        {
            _form.ReopenContactPersonForm(this, _contactPersonForm,
                                          _contactPersonTableLayoutPanel);
        }
    }
}
