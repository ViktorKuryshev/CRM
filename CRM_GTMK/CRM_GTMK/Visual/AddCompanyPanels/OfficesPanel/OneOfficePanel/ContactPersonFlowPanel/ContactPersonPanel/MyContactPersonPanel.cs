using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.ContactPersonFlowPanel.ContactPersonPanel.OneContactPersonPanel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.ContactPersonFlowPanel.ContactPersonPanel
{
    public class MyContactPersonPanel : Panel
    {
        public MyContactPersonPanel(AddNewCompanyForm form)
        {
            Panel contactPersonPanel = form.GetContactPersonPanel();

            Location = contactPersonPanel.Location;
            Name = contactPersonPanel.Name;
            Size = contactPersonPanel.Size;
            TabIndex = contactPersonPanel.TabIndex;

            MyContactPersonsLabel contactPersonsLabel = new MyContactPersonsLabel(form);
            MyContactPersonsButton contactPersonsButton = new MyContactPersonsButton(form);

            Controls.Add(contactPersonsLabel);
            Controls.Add(contactPersonsButton);
        }
    }
}
