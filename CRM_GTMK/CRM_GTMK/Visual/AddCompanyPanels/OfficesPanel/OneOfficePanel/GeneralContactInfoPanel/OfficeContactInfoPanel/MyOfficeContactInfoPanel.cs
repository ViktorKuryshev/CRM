﻿using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.GeneralContactInfoPanel.OfficeContactInfoPanel.OneOfficeContactInfoPanel;
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

        public MyOfficeContactInfoPanel(AddNewCompanyForm form)
        {
            Panel officeContactInfoPanel = form.GetOfficeContactInfoPanel();

            BorderStyle = officeContactInfoPanel.BorderStyle;
            Location = officeContactInfoPanel.Location;
            Name = officeContactInfoPanel.Name;
            Size = officeContactInfoPanel.Size;
            TabIndex = officeContactInfoPanel.TabIndex;

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
        }
    }
}
