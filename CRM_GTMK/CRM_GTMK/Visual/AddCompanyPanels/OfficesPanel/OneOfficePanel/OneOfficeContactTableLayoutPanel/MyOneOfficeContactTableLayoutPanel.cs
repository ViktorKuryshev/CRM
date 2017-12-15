using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.ContactPersonFlowPanel.ContactPersonPanel;
using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.ContactPersonFlowPanel.ContactPersonTablePanel;
using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.GeneralContactInfoPanel.OfficeContactInfoPanel;
using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.GeneralContactInfoPanel.PhonesFlowPanel;
using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.OneOfficeContactTableLayoutPanel.OfficeNumberLabel;
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
        public MyOfficeContactInfoPanel MyOfficeContactInfoPanel { get; set; }

        public MyOneOfficeContactTableLayoutPanel(AddNewCompanyForm form)
        {
            TableLayoutPanel tableLayoutPanel = form.GetOneOfficeContactTableLayoutPanel();

            AutoScroll = tableLayoutPanel.AutoScroll;
            AutoSize = tableLayoutPanel.AutoSize;
            ColumnCount = tableLayoutPanel.ColumnCount;
            AssignColumnStyles(tableLayoutPanel);

            MyOfficeNumberLabel officeNumberLabel = new MyOfficeNumberLabel(form, this);
            MyOfficeContactInfoPanel = new MyOfficeContactInfoPanel(form, this);
            MyPhonesFlowLayoutPanel = new MyPhonesFlowLayout(form, this);
            MyContactPersonPanel contactPersonPanel = new MyContactPersonPanel(form, this);
            MyContactPersonTableLayoutPanel contactPersonTableLayoutPanel = new MyContactPersonTableLayoutPanel(form, this);

            Controls.Add(officeNumberLabel, 0, 0);
            Controls.Add(MyOfficeContactInfoPanel, 0, 1);
            Controls.Add(MyPhonesFlowLayoutPanel, 0, 3);
            Controls.Add(contactPersonPanel, 1, 1);
            Controls.Add(contactPersonTableLayoutPanel, 1, 2);

            Location = tableLayoutPanel.Location;
            Name = tableLayoutPanel.Name;
            RowCount = tableLayoutPanel.RowCount;

            AssignRowStyles(tableLayoutPanel);

            Size = tableLayoutPanel.Size;
            TabIndex = tableLayoutPanel.TabIndex;
            GrowStyle = tableLayoutPanel.GrowStyle;
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
    }
}
