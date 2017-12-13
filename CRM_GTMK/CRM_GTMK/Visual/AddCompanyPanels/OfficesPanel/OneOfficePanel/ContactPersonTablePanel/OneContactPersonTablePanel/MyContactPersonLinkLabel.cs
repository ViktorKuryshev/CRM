using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.ContactPersonFlowPanel.ContactPersonTablePanel.OneContactPersonTablePanel
{
    public class MyContactPersonLinkLabel : LinkLabel
    {
        public MyContactPersonLinkLabel(AddNewCompanyForm form)
        {
            LinkLabel contactPersonLinkLabel = form.GetContactPersonLinkLabel();

            Anchor = contactPersonLinkLabel.Anchor;
            AutoSize = contactPersonLinkLabel.AutoSize;
            Location = contactPersonLinkLabel.Location;
            Name = contactPersonLinkLabel.Name;
            Size = contactPersonLinkLabel.Size;
            TabIndex = contactPersonLinkLabel.TabIndex;
            TabStop = contactPersonLinkLabel.TabStop;
            Text = contactPersonLinkLabel.Text;
            TextAlign = contactPersonLinkLabel.TextAlign;
        }
    }
}
