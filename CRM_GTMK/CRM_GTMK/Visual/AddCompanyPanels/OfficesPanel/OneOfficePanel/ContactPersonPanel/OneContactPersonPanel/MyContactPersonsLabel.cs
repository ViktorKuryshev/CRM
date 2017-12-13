using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.ContactPersonFlowPanel.ContactPersonPanel.OneContactPersonPanel
{
    public class MyContactPersonsLabel : Label
    {
        public MyContactPersonsLabel(AddNewCompanyForm form)
        {
            Label contactPersonsLabel = form.GetContactPersonsLabel();

            AutoSize = contactPersonsLabel.AutoSize;
            Location = contactPersonsLabel.Location;
            Name = contactPersonsLabel.Name;
            Size = contactPersonsLabel.Size;
            TabIndex = contactPersonsLabel.TabIndex;
            Text = contactPersonsLabel.Text;
        }
    }
}
