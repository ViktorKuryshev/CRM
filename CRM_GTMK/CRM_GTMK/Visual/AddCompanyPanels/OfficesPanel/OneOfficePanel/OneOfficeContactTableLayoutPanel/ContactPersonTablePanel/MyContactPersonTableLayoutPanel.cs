using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.ContactPersonFlowPanel.ContactPersonTablePanel.OneContactPersonTablePanel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.ContactPersonFlowPanel.ContactPersonTablePanel
{
    public class MyContactPersonTableLayoutPanel : TableLayoutPanel
    {
        public MyContactPersonTableLayoutPanel(AddNewCompanyForm form)
        {
            TableLayoutPanel tableLayoutPanel = form.GetContactPersonTableLayoutPanel();

            CellBorderStyle = tableLayoutPanel.CellBorderStyle;
            ColumnCount = tableLayoutPanel.ColumnCount;
            Location = tableLayoutPanel.Location;
            Name = tableLayoutPanel.Name;
            RowCount = tableLayoutPanel.RowCount;
            Size = tableLayoutPanel.Size;
            TabIndex = tableLayoutPanel.TabIndex;

            AssignColumnStyles(tableLayoutPanel);
            AssignColumnStyles(tableLayoutPanel);

            MyContactPersonLinkLabel contactPersonLinkLabel = new MyContactPersonLinkLabel(form);
            MyContactPersonLabel1 contactPersonLabel1 = new MyContactPersonLabel1(form);
            MyContactPersonLabel2 contactPersonLabel2 = new MyContactPersonLabel2(form);

            Controls.Add(contactPersonLinkLabel, 0, 0);
            Controls.Add(contactPersonLabel1, 1, 0);
            Controls.Add(contactPersonLabel2, 2, 0);
        }

        private void AssignColumnStyles(TableLayoutPanel panel)
        {
            for (int i = 0; i < panel.ColumnStyles.Count; i++)
            {
                ColumnStyles.Add(panel.ColumnStyles[i]);
            }
        }

        private void AssignRowStyles(TableLayoutPanel panel)
        {
            for (int i = 0; i < panel.RowStyles.Count; i++)
            {
                RowStyles.Add(panel.RowStyles[i]);
            }
        }
    }
}
