using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.ContactPersonFlowPanel.ContactPersonTablePanel.OneContactPersonTablePanel
{
    public class MyContactPersonLabel2 : Label
    {
        public MyContactPersonLabel2(AddNewCompanyForm form)
        {
            Label contactPersonLabel2 = form.GetContactPersonLabel2();

            Anchor = contactPersonLabel2.Anchor;
            AutoSize = contactPersonLabel2.AutoSize;
            Location = contactPersonLabel2.Location;
            Name = contactPersonLabel2.Name;
            Size = contactPersonLabel2.Size;
            TabIndex = contactPersonLabel2.TabIndex;
            Text = contactPersonLabel2.Text;
            TextAlign = contactPersonLabel2.TextAlign;
        }
    }
}
