using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.NewCompanyActionMenuPanel.OneAddClientDataButton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.NewCompanyActionMenuPanel
{
    public class MyNewCompanyActionMenuPanel : Panel
    {
        public MyNewCompanyActionMenuPanel(AddNewCompanyForm form)
        {
            Panel newCompanyActionMenuPanel = form.GetNewCompanyActionMenuPanel();

            Location = newCompanyActionMenuPanel.Location;
            Name = newCompanyActionMenuPanel.Name;
            Size = newCompanyActionMenuPanel.Size;
            TabIndex = newCompanyActionMenuPanel.TabIndex;

            MyAddClientDataButton addClientDataButton = new MyAddClientDataButton(form);

            Controls.Add(addClientDataButton);
        }
    }
}
