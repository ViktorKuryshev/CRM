﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.GeneralContactInfoPanel.OfficeContactInfoPanel.OneOfficeContactInfoPanel
{
    class OfficeSiteTextBox : TextBox
    {
        public OfficeSiteTextBox(AddNewCompanyForm form)
        {
            TextBox officeSiteTextBox = form.GetOfficeSiteTextBox();

            Location = officeSiteTextBox.Location;
            Name = officeSiteTextBox.Name;
            Size = officeSiteTextBox.Size;
            TabIndex = officeSiteTextBox.TabIndex;
        }
    }
}
