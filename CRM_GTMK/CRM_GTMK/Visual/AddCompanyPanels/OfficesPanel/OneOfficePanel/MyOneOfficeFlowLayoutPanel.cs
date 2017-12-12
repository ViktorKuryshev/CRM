using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.ContactPersonFlowPanel;
using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.GeneralContactInfoPanel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel
{
    public class MyOneOfficeFlowLayoutPanel : FlowLayoutPanel
    {
        public MyOneOfficeFlowLayoutPanel(AddNewCompanyForm form)
        {
            FlowLayoutPanel oneOfficeFlowLayoutPanel = form.GetOneOfficeFlowLayoutPanel();

            Location = oneOfficeFlowLayoutPanel.Location;
            Name = oneOfficeFlowLayoutPanel.Name;
            Size = oneOfficeFlowLayoutPanel.Size;
            TabIndex = oneOfficeFlowLayoutPanel.TabIndex;

            MyGeneralContactFlowLayoutPanel generalContactFlowLayoutPanel = new MyGeneralContactFlowLayoutPanel(form);
            MyContactPersonFlowLayoutPanel contactPersonFlowLayoutPanel = new MyContactPersonFlowLayoutPanel(form);

            Controls.Add(generalContactFlowLayoutPanel);
            Controls.Add(contactPersonFlowLayoutPanel);
        }
    }
}
