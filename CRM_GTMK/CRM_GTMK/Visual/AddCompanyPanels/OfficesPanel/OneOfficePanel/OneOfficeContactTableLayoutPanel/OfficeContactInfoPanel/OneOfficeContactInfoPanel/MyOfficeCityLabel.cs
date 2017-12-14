﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.GeneralContactInfoPanel.OfficeContactInfoPanel.OneOfficeContactInfoPanel
{
    public class MyOfficeCityLabel : Label
    {
        public MyOfficeCityLabel(AddNewCompanyForm form)
        {
            Label label = form.GetOfficeCityLabel();

            AutoSize = label.AutoSize;
            Location = label.Location;
            Name = label.Name;
            Size = label.Size;
            TabIndex = label.TabIndex;
            Text = label.Text;
        }
    }
}
