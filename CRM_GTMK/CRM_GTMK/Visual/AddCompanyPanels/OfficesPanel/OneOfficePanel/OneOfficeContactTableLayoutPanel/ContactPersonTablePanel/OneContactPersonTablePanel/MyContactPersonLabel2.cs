using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.OneOfficeContactTableLayoutPanel.ContactPersonTablePanel.OneContactPersonTablePanel
{
    public class MyContactPersonLabel2 : Label
    {
        public MyContactPersonLabel2(AddNewCompanyForm form)
        {
            Label label = form.GetContactPersonLabel2();

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
