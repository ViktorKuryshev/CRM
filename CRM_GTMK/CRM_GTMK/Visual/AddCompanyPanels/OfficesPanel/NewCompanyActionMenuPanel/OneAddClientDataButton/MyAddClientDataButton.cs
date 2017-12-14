using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.NewCompanyActionMenuPanel.OneAddClientDataButton
{
    public class MyAddClientDataButton : Button
    {
        private AddNewCompanyForm _form;

        public MyAddClientDataButton(AddNewCompanyForm form)
        {
            _form = form;

            Button addClientDataButton = form.GetAddClientDataButton();

            Location = addClientDataButton.Location;
            Name = addClientDataButton.Name;
            Size = addClientDataButton.Size;
            TabIndex = addClientDataButton.TabIndex;
            Text = addClientDataButton.Text;
            UseVisualStyleBackColor = addClientDataButton.UseVisualStyleBackColor;
            Click += new System.EventHandler(IsClicked);
        }

        private void IsClicked(object sender, EventArgs e)
        {
            _form.AddClientDataButton_Click();
        }
    }
}
