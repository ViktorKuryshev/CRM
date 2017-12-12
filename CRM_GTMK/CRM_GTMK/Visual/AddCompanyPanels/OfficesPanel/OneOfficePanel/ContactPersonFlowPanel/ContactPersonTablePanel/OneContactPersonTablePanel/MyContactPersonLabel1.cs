using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.ContactPersonFlowPanel.ContactPersonTablePanel.OneContactPersonTablePanel
{
    public class MyContactPersonLabel1 : Label
    {
        public MyContactPersonLabel1(AddNewCompanyForm form)
        {
            Label contactPersonLabel1 = form.GetContactPersonLabel1();

            Anchor = contactPersonLabel1.Anchor;
            AutoSize = contactPersonLabel1.AutoSize;
            Location = contactPersonLabel1.Location;
            Name = contactPersonLabel1.Name;
            Size = contactPersonLabel1.Size;
            TabIndex = contactPersonLabel1.TabIndex;
            Text = contactPersonLabel1.Text;
            TextAlign = contactPersonLabel1.TextAlign;
        }
    }
}
