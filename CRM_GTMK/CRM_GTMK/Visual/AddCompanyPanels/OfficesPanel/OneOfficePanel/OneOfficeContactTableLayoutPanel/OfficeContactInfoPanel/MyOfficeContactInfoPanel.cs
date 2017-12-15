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
        public ComboBox MyOfficeCountryComboBox { get; set; }
        public TextBox MyOfficeCityTextBox { get; set; }
        public TextBox MyOfficeAddressTextBox { get; set; }
        public TextBox MyOfficeSiteTextBox { get; set; }
        

        public MyOfficeContactInfoPanel(AddNewCompanyForm form, MyOneOfficeContactTableLayoutPanel myOneOfficeContactTableLayoutPanel)
        {
            Panel panel = form.GetOfficeContactInfoPanel();

            BorderStyle = panel.BorderStyle;
            Location = panel.Location;
            Name = panel.Name;
            Size = panel.Size;
            TabIndex = panel.TabIndex;

            MyOfficeAddressTextBox = new MyOfficeAddressTextBox(form);
            MyOfficeAddressLabel officeAddressLabel = new MyOfficeAddressLabel(form);
            MyOfficeCityTextBox = new MyOfficeCityTextBox(form);
            MyOfficeCityLabel officeCityLabel = new MyOfficeCityLabel(form);
            MyOfficeSiteTextBox = new MyOfficeSiteTextBox(form);
            MyOfficeSiteLabel officeSiteLabel = new MyOfficeSiteLabel(form);
            MyOfficeCountryComboBox = new MyOfficeCountryComboBox(form);
            MyOfficeCountryLabel officeCountryLabel = new MyOfficeCountryLabel(form);

            Controls.Add(MyOfficeAddressTextBox);
            Controls.Add(officeAddressLabel);
            Controls.Add(MyOfficeCityTextBox);
            Controls.Add(officeCityLabel);
            Controls.Add(MyOfficeSiteTextBox);
            Controls.Add(officeSiteLabel);
            Controls.Add(MyOfficeCountryComboBox);
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
