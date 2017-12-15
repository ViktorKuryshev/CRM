using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.ContactPersonFlowPanel.ContactPersonTablePanel.OneContactPersonTablePanel;
using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.OneOfficeContactTableLayoutPanel;
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
        public MyContactPersonTableLayoutPanel(AddNewCompanyForm form, MyOneOfficeContactTableLayoutPanel myOneOfficeContactTableLayoutPanel)
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
            AssignRowStyles(tableLayoutPanel);

            MyContactPersonLinkLabel contactPersonLinkLabel = new MyContactPersonLinkLabel(form);
            MyContactPersonLabel1 contactPersonLabel1 = new MyContactPersonLabel1(form);
            MyContactPersonLabel2 contactPersonLabel2 = new MyContactPersonLabel2(form);

            Controls.Add(contactPersonLinkLabel, 0, 0);
            Controls.Add(contactPersonLabel1, 1, 0);
            Controls.Add(contactPersonLabel2, 2, 0);

            SetSpans(form, tableLayoutPanel, myOneOfficeContactTableLayoutPanel);
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

        private void SetSpans(AddNewCompanyForm form, TableLayoutPanel tableLayoutPanel,
                              MyOneOfficeContactTableLayoutPanel myOneOfficeContactTableLayoutPanel)
        {
            int columnSpan = form.GetOneOfficeContactTableLayoutPanel().GetColumnSpan(tableLayoutPanel);
            myOneOfficeContactTableLayoutPanel.SetColumnSpan(this, columnSpan);

            int rowSpan = form.GetOneOfficeContactTableLayoutPanel().GetRowSpan(tableLayoutPanel);
            myOneOfficeContactTableLayoutPanel.SetRowSpan(this, rowSpan);
        }
    }
}
