﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.OneOfficeContactTableLayoutPanel.OfficeContactInfoPanel.OneOfficeContactInfoPanel
{
    public class MyOfficeAddressTextBox : TextBox
    {
        public MyOfficeAddressTextBox(AddNewCompanyForm form)
        {
            TextBox textBox = form.GetOfficeAddressTextBox();

            Location = textBox.Location;
            Name = textBox.Name;
            Size = textBox.Size;
            TabIndex = textBox.TabIndex;
        }
    }
}
