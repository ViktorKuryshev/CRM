using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.OneOfficeContactTableLayoutPanel.ContactPersonTablePanel.OneContactPersonTablePanel
{
    public class MyContactPersonFullnameLinkLabel : LinkLabel
    {
        public MyContactPersonFullnameLinkLabel(AddNewCompanyForm form)
        {
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
        }
    }
}
