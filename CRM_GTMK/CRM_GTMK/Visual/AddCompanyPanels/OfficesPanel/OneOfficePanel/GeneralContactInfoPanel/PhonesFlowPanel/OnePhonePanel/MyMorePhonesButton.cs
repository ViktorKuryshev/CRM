using System;
using System.Windows.Forms;

namespace CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.GeneralContactInfoPanel.PhonesFlowPanel.OnePhonePanel
{
	public class MyMorePhonesButton : Button
	{

		private AddNewCompanyForm _form;
		public MyMorePhonesButton(AddNewCompanyForm form)
		{

			_form = form;
			Button morePhonesButton = form.GetMorePhonesButton();

			Location = morePhonesButton.Location;
			Name = morePhonesButton.Name;
			Size = morePhonesButton.Size;
			TabIndex = morePhonesButton.TabIndex;
			Text = morePhonesButton.Text;
			UseVisualStyleBackColor = morePhonesButton.UseVisualStyleBackColor;

			Click += new System.EventHandler(IsClicked);
		}

		public void IsClicked(object sender, EventArgs e)
		{
			_form.AddOneMorePhonePanel();
		}
	}
}
