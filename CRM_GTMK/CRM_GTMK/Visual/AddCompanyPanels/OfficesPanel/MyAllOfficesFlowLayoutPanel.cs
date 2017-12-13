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
        public List<MyOneOfficeFlowLayoutPanel> MyOneOfficeFlowLayoutPanel { get; } = new List<MyOneOfficeFlowLayoutPanel>();
        public MyNewCompanyActionMenuPanel MyNewCompanyActionMenuPanel { get; set; }

        public MyAllOfficesFlowLayoutPanel(AddNewCompanyForm form)
        {
            FlowLayoutPanel allOfficesFlowLayoutPanel = form.GetAllOfficesFlowLayoutPanel();

            FlowDirection = allOfficesFlowLayoutPanel.FlowDirection;
            Location = allOfficesFlowLayoutPanel.Location;
            Name = allOfficesFlowLayoutPanel.Name;
            Size = allOfficesFlowLayoutPanel.Size;
            TabIndex = allOfficesFlowLayoutPanel.TabIndex;

            MyOneOfficeFlowLayoutPanel oneOfficeFlowLayoutPanel = new MyOneOfficeFlowLayoutPanel(form);
            MyNewCompanyActionMenuPanel newCompanyActionMenuPanel = new MyNewCompanyActionMenuPanel(form);

            AddMyOneOfficeFlowLayoutPanel(oneOfficeFlowLayoutPanel);
            AddMyNewCompanyActionMenuPanel(newCompanyActionMenuPanel);
        }

        public void AddMyOneOfficeFlowLayoutPanel(MyOneOfficeFlowLayoutPanel panel)
        {
            MyOneOfficeFlowLayoutPanel.Add(panel);
            Controls.Add(panel);
        }

        public void AddMyNewCompanyActionMenuPanel(MyNewCompanyActionMenuPanel panel)
        {
            MyNewCompanyActionMenuPanel = panel;
            Controls.Add(panel);
        }
    }
}
