using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.OneOfficeContactTableLayoutPanel.ContactPersonTablePanel.OneContactPersonTablePanel
{
    public class MyContactPersonPositionLabel : Label
    {
        public MyContactPersonPositionLabel(AddNewCompanyForm form)
        {
            Label label = form.GetContactPersonPositionLabel();

            MaximumSize = label.MaximumSize;
            Anchor = label.Anchor;
            AutoSize = label.AutoSize;
            Location = label.Location;
            Name = label.Name;
            Size = label.Size;
            TabIndex = label.TabIndex;
            Text = label.Text;
            TextAlign = label.TextAlign;
        }
    }
}
