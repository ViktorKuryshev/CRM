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
        public MyGeneralContactFlowLayoutPanel MyGeneralContactFlowLayoutPanel { get; set; }
        public static List<MyOneOfficeFlowLayoutPanel> MyOneOfficeFlowLayoutPanelList { get; set; } = new List<MyOneOfficeFlowLayoutPanel>();

        public MyOneOfficeFlowLayoutPanel(AddNewCompanyForm form)
        {
            FlowLayoutPanel oneOfficeFlowLayoutPanel = form.GetOneOfficeFlowLayoutPanel();

            Location = oneOfficeFlowLayoutPanel.Location;
            Name = oneOfficeFlowLayoutPanel.Name;
            Size = oneOfficeFlowLayoutPanel.Size;
            TabIndex = oneOfficeFlowLayoutPanel.TabIndex;
            AutoScroll = oneOfficeFlowLayoutPanel.AutoScroll;
            AutoSize = oneOfficeFlowLayoutPanel.AutoSize;

            MyGeneralContactFlowLayoutPanel generalContactFlowLayoutPanel = new MyGeneralContactFlowLayoutPanel(form, this);
            MyContactPersonFlowLayoutPanel contactPersonFlowLayoutPanel = new MyContactPersonFlowLayoutPanel(form);

            AddMyGeneralContactFlowLayoutPanel(generalContactFlowLayoutPanel);
            Controls.Add(contactPersonFlowLayoutPanel);
        }

        private void AddMyGeneralContactFlowLayoutPanel(MyGeneralContactFlowLayoutPanel panel)
        {
            Controls.Add(panel);
            MyGeneralContactFlowLayoutPanel = panel;
        }
    }
}
