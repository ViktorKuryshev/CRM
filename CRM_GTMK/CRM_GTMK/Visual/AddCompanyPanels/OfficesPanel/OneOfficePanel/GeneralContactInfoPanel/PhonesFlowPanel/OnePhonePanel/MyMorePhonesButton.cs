using System;
using System.Windows.Forms;

namespace CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.GeneralContactInfoPanel.PhonesFlowPanel.OnePhonePanel
{
	public class MyMorePhonesButton : Button
	{
		private AddNewCompanyForm _form;
        private MyOneOfficeFlowLayoutPanel _myOneOfficeFlowLayoutPanel;

        public MyMorePhonesButton(AddNewCompanyForm form, MyOneOfficeFlowLayoutPanel myOneOfficeFlowLayoutPanel)
		{
			_form = form;
            _myOneOfficeFlowLayoutPanel = myOneOfficeFlowLayoutPanel;

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
			_form.AddOneMorePhonePanel(_myOneOfficeFlowLayoutPanel);
		}
	}
}
