using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.NewCompanyActionMenuPanel;
using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel;
using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.OneOfficeContactTableLayoutPanel;
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
        public List<MyOneOfficeContactTableLayoutPanel> MyOneOfficeContactTableLayoutPanelList
        { get; set; } = new List<MyOneOfficeContactTableLayoutPanel>();
        public MyNewCompanyActionMenuPanel MyNewCompanyActionMenuPanel { get; set; }

        public MyAllOfficesFlowLayoutPanel(AddNewCompanyForm form)
        {
            FlowLayoutPanel flowLayoutPanel = form.GetAllOfficesFlowLayoutPanel();

            FlowDirection = flowLayoutPanel.FlowDirection;
            Location = flowLayoutPanel.Location;
            Name = flowLayoutPanel.Name;
            Size = flowLayoutPanel.Size;
            TabIndex = flowLayoutPanel.TabIndex;
            AutoSize = flowLayoutPanel.AutoSize;

            MyOneOfficeContactTableLayoutPanel oneOfficeContactTableLayoutPanel = new MyOneOfficeContactTableLayoutPanel(form);
            MyNewCompanyActionMenuPanel newCompanyActionMenuPanel = new MyNewCompanyActionMenuPanel(form);

            AddTableLayoutPanel(oneOfficeContactTableLayoutPanel);
            AddActionMenuPanel(newCompanyActionMenuPanel);
        }

        private void AddTableLayoutPanel(MyOneOfficeContactTableLayoutPanel tableLayoutPanel)
        {
            MyOneOfficeContactTableLayoutPanelList.Add(tableLayoutPanel);
            Controls.Add(tableLayoutPanel);
        }

        private void AddActionMenuPanel(MyNewCompanyActionMenuPanel actionMenuPanel)
        {
            MyNewCompanyActionMenuPanel = actionMenuPanel;
            Controls.Add(actionMenuPanel);
        }
    }
}
