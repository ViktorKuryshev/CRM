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
            Location = contactPersonTableLayoutPanel.Location;
            Name = contactPersonTableLayoutPanel.Name;
            RowCount = contactPersonTableLayoutPanel.RowCount;
            Size = contactPersonTableLayoutPanel.Size;
            TabIndex = contactPersonTableLayoutPanel.TabIndex;
            ColumnStyles[0] = contactPersonTableLayoutPanel.ColumnStyles[0];
            ColumnStyles[1] = contactPersonTableLayoutPanel.ColumnStyles[1];
            ColumnStyles[2] = contactPersonTableLayoutPanel.ColumnStyles[2];
            RowStyles[0] = contactPersonTableLayoutPanel.RowStyles[0];
            RowStyles[1] = contactPersonTableLayoutPanel.RowStyles[1];

            MyContactPersonLinkLabel contactPersonLinkLabel = new MyContactPersonLinkLabel(form);
            MyContactPersonLabel1 contactPersonLabel1 = new MyContactPersonLabel1(form);
            MyContactPersonLabel2 contactPersonLabel2 = new MyContactPersonLabel2(form);

            Controls.Add(contactPersonLinkLabel, 0, 0);
            Controls.Add(contactPersonLabel1, 1, 0);
            Controls.Add(contactPersonLabel2, 2, 0);
        }
    }
}
