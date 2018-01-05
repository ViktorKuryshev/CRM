using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.OneOfficeContactTableLayoutPanel;
using System;
using System.Windows.Forms;

namespace CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.OneOfficeContactTableLayoutPanel.PhonesFlowPanel.OnePhonePanel
{
	public class MyMorePhonesButton : Button
	{
        private MyOneOfficeContactTableLayoutPanel _myOneOfficeContactTableLayoutPanel;
        private AddNewCompanyForm _form;

		public MyMorePhonesButton(AddNewCompanyForm form, MyOneOfficeContactTableLayoutPanel myOneOfficeContactTableLayoutPanel)
		{
            _myOneOfficeContactTableLayoutPanel = myOneOfficeContactTableLayoutPanel;
            _form = form;
			Button morePhonesButton = form.GetMorePhonesButton();

			Location = morePhonesButton.Location;
			Name = morePhonesButton.Name;
			Size = morePhonesButton.Size;
			TabIndex = morePhonesButton.TabIndex;
			Text = morePhonesButton.Text;
			UseVisualStyleBackColor = morePhonesButton.UseVisualStyleBackColor;

			Click += new EventHandler(IsClicked);
		}

		public void IsClicked(object sender, EventArgs e)
		{
			_form.AddOneMorePhonePanel(_myOneOfficeContactTableLayoutPanel);
		}
	}
}
