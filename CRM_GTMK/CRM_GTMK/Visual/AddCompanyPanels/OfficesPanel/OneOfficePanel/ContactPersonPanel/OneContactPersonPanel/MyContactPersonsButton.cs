using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.ContactPersonFlowPanel.ContactPersonPanel.OneContactPersonPanel
{
    public class MyContactPersonsButton : Button
    {
        public MyContactPersonsButton(AddNewCompanyForm form)
        {
            Button contactPersonsButton = form.GetContactPersonsButton();

            Location = contactPersonsButton.Location;
            Name = contactPersonsButton.Name;
            Size = contactPersonsButton.Size;
            TabIndex = contactPersonsButton.TabIndex;
            Text = contactPersonsButton.Text;
            UseVisualStyleBackColor = contactPersonsButton.UseVisualStyleBackColor;
        }
    }
}
