using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.OneOfficeContactTableLayoutPanel.ContactPersonTablePanel.OneContactPersonTablePanel
{
    public class MyFullnameLabel : Label
    {
        public MyFullnameLabel(AddNewCompanyForm form)
        {
            Label fullnameLabel = form.GetFullnameLabel();

            MaximumSize = fullnameLabel.MaximumSize;
            Anchor = fullnameLabel.Anchor;
            AutoSize = fullnameLabel.AutoSize;
            Location = fullnameLabel.Location;
            Name = fullnameLabel.Name;
            Size = fullnameLabel.Size;
            TabIndex = fullnameLabel.TabIndex;
            Text = fullnameLabel.Text;
            TextAlign = fullnameLabel.TextAlign;
        }
    }
}
