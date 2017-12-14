using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.NewCompanyActionMenuPanel;
using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel
{
	public class MyAllOfficesFlowLayoutPanel : FlowLayoutPanel
	{
        public MyAllOfficesFlowLayoutPanel(AddNewCompanyForm form)
        {
            FlowLayoutPanel flowLayoutPanel = form.GetAllOfficesFlowLayoutPanel();

            FlowDirection = flowLayoutPanel.FlowDirection;
            Location = flowLayoutPanel.Location;
            Name = flowLayoutPanel.Name;
            Size = flowLayoutPanel.Size;
            TabIndex = flowLayoutPanel.TabIndex;
			/*
            MyOneOfficeFlowLayoutPanel oneOfficeFlowLayoutPanel = new MyOneOfficeFlowLayoutPanel(form);
            MyNewCompanyActionMenuPanel newCompanyActionMenuPanel = new MyNewCompanyActionMenuPanel(form);

            Controls.Add(oneOfficeFlowLayoutPanel);
            Controls.Add(newCompanyActionMenuPanel);*/
        }
    }
}
