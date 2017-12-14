using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.GeneralContactInfoPanel.OfficeContactInfoPanel.OneOfficeContactInfoPanel;
using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.OneOfficeContactTableLayoutPanel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.GeneralContactInfoPanel.OfficeContactInfoPanel
{
    public class MyOfficeContactInfoPanel : Panel
    {
        public TextBox OfficeAddressTextBox { get; set; }
        public TextBox OfficeCityTextBox { get; set; }
        public TextBox OfficeSiteTextBox { get; set; }
        public ComboBox OfficeCountryComboBox { get; set; }

        public MyOfficeContactInfoPanel(AddNewCompanyForm form, MyOneOfficeContactTableLayoutPanel myOneOfficeContactTableLayoutPanel)
        {
            Panel panel = form.GetOfficeContactInfoPanel();

            BorderStyle = panel.BorderStyle;
            Location = panel.Location;
            Name = panel.Name;
            Size = panel.Size;
            TabIndex = panel.TabIndex;

            OfficeAddressTextBox = new MyOfficeAddressTextBox(form);
            MyOfficeAddressLabel officeAddressLabel = new MyOfficeAddressLabel(form);
            OfficeCityTextBox = new MyOfficeCityTextBox(form);
            MyOfficeCityLabel officeCityLabel = new MyOfficeCityLabel(form);
            OfficeSiteTextBox = new MyOfficeSiteTextBox(form);
            MyOfficeSiteLabel officeSiteLabel = new MyOfficeSiteLabel(form);
            OfficeCountryComboBox = new MyOfficeCountryComboBox(form);
            MyOfficeCountryLabel officeCountryLabel = new MyOfficeCountryLabel(form);

            Controls.Add(OfficeAddressTextBox);
            Controls.Add(officeAddressLabel);
            Controls.Add(OfficeCityTextBox);
            Controls.Add(officeCityLabel);
            Controls.Add(OfficeSiteTextBox);
            Controls.Add(officeSiteLabel);
            Controls.Add(OfficeCountryComboBox);
            Controls.Add(officeCountryLabel);

            SetSpans(form, panel, myOneOfficeContactTableLayoutPanel);
        }

        private void SetSpans(AddNewCompanyForm form, Panel panel,
                              MyOneOfficeContactTableLayoutPanel myOneOfficeContactTableLayoutPanel)
        {
            int columnSpan = form.GetOneOfficeContactTableLayoutPanel().GetColumnSpan(panel);
            myOneOfficeContactTableLayoutPanel.SetColumnSpan(this, columnSpan);

            int rowSpan = form.GetOneOfficeContactTableLayoutPanel().GetRowSpan(panel);
            myOneOfficeContactTableLayoutPanel.SetRowSpan(this, rowSpan);
        }
    }
}
