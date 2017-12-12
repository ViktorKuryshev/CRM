using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.ContactPersonFlowPanel.ContactPersonPanel;
using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.ContactPersonFlowPanel.ContactPersonTablePanel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.ContactPersonFlowPanel
{
    public class MyContactPersonFlowLayoutPanel : FlowLayoutPanel
    {
        public MyContactPersonFlowLayoutPanel(AddNewCompanyForm form)
        {
            FlowLayoutPanel contactPersonFlowLayoutPanel = form.GetContactPersonFlowLayoutPanel();

            BorderStyle = contactPersonFlowLayoutPanel.BorderStyle;
            FlowDirection = contactPersonFlowLayoutPanel.FlowDirection;
            Location = contactPersonFlowLayoutPanel.Location;
            Name = contactPersonFlowLayoutPanel.Name;
            Size = contactPersonFlowLayoutPanel.Size;
            TabIndex = contactPersonFlowLayoutPanel.TabIndex;

            MyContactPersonPanel contactPersonPanel = new MyContactPersonPanel(form);
            MyContactPersonTableLayoutPanel contactPersonTableLayoutPanel = new MyContactPersonTableLayoutPanel(form);

            Controls.Add(contactPersonPanel);
            Controls.Add(contactPersonTableLayoutPanel);
        }
    }
}
