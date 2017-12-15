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
            Button button = form.GetContactPersonsButton();

            Location = button.Location;
            Name = button.Name;
            Size = button.Size;
            TabIndex = button.TabIndex;
            Text = button.Text;
            UseVisualStyleBackColor = button.UseVisualStyleBackColor;
        }
    }
}
