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
            TableLayoutPanel contactPersonTableLayoutPanel = form.GetContactPersonTableLayoutPanel();

            CellBorderStyle = contactPersonTableLayoutPanel.CellBorderStyle;
            ColumnCount = contactPersonTableLayoutPanel.ColumnCount;

            GenerateNewColumnStyles(contactPersonTableLayoutPanel);

            MyContactPersonLinkLabel contactPersonLinkLabel = new MyContactPersonLinkLabel(form);
            MyContactPersonLabel1 contactPersonLabel1 = new MyContactPersonLabel1(form);
            MyContactPersonLabel2 contactPersonLabel2 = new MyContactPersonLabel2(form);

            Controls.Add(contactPersonLinkLabel, 0, 0);
            Controls.Add(contactPersonLabel1, 1, 0);
            Controls.Add(contactPersonLabel2, 2, 0);

            Location = contactPersonTableLayoutPanel.Location;
            Name = contactPersonTableLayoutPanel.Name;
            RowCount = contactPersonTableLayoutPanel.RowCount;

            GenerateNewRowStyles(contactPersonTableLayoutPanel);

            Size = contactPersonTableLayoutPanel.Size;
            TabIndex = contactPersonTableLayoutPanel.TabIndex;
        }

        private void GenerateNewColumnStyles(TableLayoutPanel contactPersonTableLayoutPanel)
        {
            for (int i = 0; i < contactPersonTableLayoutPanel.ColumnStyles.Count; i++)
            {
                ColumnStyles.Add(new ColumnStyle(SizeType.Percent, contactPersonTableLayoutPanel.ColumnStyles[i].Width));
            }
        }

        private void GenerateNewRowStyles(TableLayoutPanel contactPersonTableLayoutPanel)
        {
            for (int i = 0; i < contactPersonTableLayoutPanel.RowStyles.Count; i++)
            {
                RowStyles.Add(new RowStyle(SizeType.Percent, contactPersonTableLayoutPanel.RowStyles[i].Height));
            }
        }
    }
}
