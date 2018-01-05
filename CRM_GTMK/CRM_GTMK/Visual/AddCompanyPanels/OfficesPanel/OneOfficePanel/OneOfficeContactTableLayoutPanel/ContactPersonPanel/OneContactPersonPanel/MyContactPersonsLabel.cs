using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.OneOfficeContactTableLayoutPanel.ContactPersonPanel.OneContactPersonPanel
{
    public class MyContactPersonsLabel : Label
    {
        public MyContactPersonsLabel(AddNewCompanyForm form)
        {
            Label label = form.GetContactPersonsLabel();

            AutoSize = label.AutoSize;
            Location = label.Location;
            Name = label.Name;
            Size = label.Size;
            TabIndex = label.TabIndex;
            Text = label.Text;
        }
    }
}
