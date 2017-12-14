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
        private MyPhonesFlowLayout _phonesFlowLayoutPanel;

        public MyOneOfficeContactTableLayoutPanel(AddNewCompanyForm form)
        {
            TableLayoutPanel tableLayoutPanel = form.GetOneOfficeContactTableLayoutPanel();

            AutoSize = tableLayoutPanel.AutoSize;
            ColumnCount = tableLayoutPanel.ColumnCount;

            AssignColumnStyles(tableLayoutPanel);
            
            Location = tableLayoutPanel.Location;
            Name = tableLayoutPanel.Name;
            RowCount = tableLayoutPanel.RowCount;

            AssignRowStyles(tableLayoutPanel);

            Size = tableLayoutPanel.Size;
            TabIndex = tableLayoutPanel.TabIndex;

            MyPhonesFlowLayout phonesFlowLayoutPanel = new MyPhonesFlowLayout(form, this);
            MyContactPersonTableLayoutPanel contactPersonTableLayoutPanel = new MyContactPersonTableLayoutPanel(form);
            MyContactPersonPanel contactPersonPanel = new MyContactPersonPanel(form);
            MyOfficeContactInfoPanel officeContactInfoPanel = new MyOfficeContactInfoPanel(form);

            Controls.Add(phonesFlowLayoutPanel, 0, 2);
            Controls.Add(contactPersonTableLayoutPanel, 1, 1);
            Controls.Add(contactPersonPanel, 1, 0);
            Controls.Add(officeContactInfoPanel, 0, 0);
        }

        private void AssignColumnStyles(TableLayoutPanel panel)
        {
            for (int i = 0; i < panel.ColumnStyles.Count; i++)
            {
                ColumnStyles.Add(new ColumnStyle(SizeType.Percent, panel.ColumnStyles[i].Width));
            }
        }

        private void AssignRowStyles(TableLayoutPanel panel)
        {
            for (int i = 0; i < panel.RowStyles.Count; i++)
            {
                RowStyles.Add(new RowStyle(SizeType.Absolute, panel.RowStyles[i].Height));
            }
        }
    }
}
