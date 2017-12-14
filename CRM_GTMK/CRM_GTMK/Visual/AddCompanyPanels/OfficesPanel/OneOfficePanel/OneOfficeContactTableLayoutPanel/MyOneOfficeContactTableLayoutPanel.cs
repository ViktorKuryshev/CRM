using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.ContactPersonFlowPanel.ContactPersonPanel;
using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.ContactPersonFlowPanel.ContactPersonTablePanel;
using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.GeneralContactInfoPanel.OfficeContactInfoPanel;
using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.GeneralContactInfoPanel.PhonesFlowPanel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.OneOfficeContactTableLayoutPanel
{
    public class MyOneOfficeContactTableLayoutPanel : TableLayoutPanel
    {
        public MyPhonesFlowLayout MyPhonesFlowLayoutPanel { get; set; }

        public MyOneOfficeContactTableLayoutPanel(AddNewCompanyForm form)
        {
            TableLayoutPanel tableLayoutPanel = form.GetOneOfficeContactTableLayoutPanel();

            AutoSize = tableLayoutPanel.AutoSize;
            ColumnCount = tableLayoutPanel.ColumnCount;
            AssignColumnStyles(tableLayoutPanel);
            
            MyPhonesFlowLayout phonesFlowLayoutPanel = new MyPhonesFlowLayout(form, this);
            MyContactPersonTableLayoutPanel contactPersonTableLayoutPanel = new MyContactPersonTableLayoutPanel(form, this);
            MyContactPersonPanel contactPersonPanel = new MyContactPersonPanel(form, this);
            MyOfficeContactInfoPanel officeContactInfoPanel = new MyOfficeContactInfoPanel(form, this);

            AddMyPhonesFlowLayout(phonesFlowLayoutPanel);
            Controls.Add(contactPersonTableLayoutPanel, 1, 1);
            Controls.Add(contactPersonPanel, 1, 0);
            Controls.Add(officeContactInfoPanel, 0, 0);

            Location = tableLayoutPanel.Location;
            Name = tableLayoutPanel.Name;
            RowCount = tableLayoutPanel.RowCount;

            AssignRowStyles(tableLayoutPanel);

            Size = tableLayoutPanel.Size;
            TabIndex = tableLayoutPanel.TabIndex;
            GrowStyle = tableLayoutPanel.GrowStyle;
            AutoScroll = tableLayoutPanel.AutoScroll;
        }

        private void AssignColumnStyles(TableLayoutPanel panel)
        {
            for (int i = 0; i < panel.ColumnStyles.Count; i++)
            {
                ColumnStyles.Add(new ColumnStyle(panel.ColumnStyles[i].SizeType, panel.ColumnStyles[i].Width));
            }
        }

        private void AssignRowStyles(TableLayoutPanel panel)
        {
            for (int i = 0; i < panel.RowStyles.Count; i++)
            {
                RowStyles.Add(new RowStyle(panel.RowStyles[i].SizeType, panel.RowStyles[i].Height));
                
            }
        }

        private void AddMyPhonesFlowLayout(MyPhonesFlowLayout panel)
        {
            MyPhonesFlowLayoutPanel = panel;
            Controls.Add(panel, 0, 2);
        }
    }
}
