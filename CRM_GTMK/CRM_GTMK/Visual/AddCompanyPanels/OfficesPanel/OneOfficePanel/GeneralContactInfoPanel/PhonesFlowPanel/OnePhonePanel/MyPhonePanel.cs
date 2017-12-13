using System.Windows.Forms;

namespace CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.GeneralContactInfoPanel.PhonesFlowPanel.OnePhonePanel
{
	public class MyPhonePanel : Panel
	{
		public MyPhoneTextBox MyPhoneTextBox { get; set; }

		public MyPhonePanel(AddNewCompanyForm form, MyOneOfficeFlowLayoutPanel myOneOfficeFlowLayoutPanel)
		{
			Panel phonesPanel = form.GetPhonePanel();

			BorderStyle = phonesPanel.BorderStyle;
			Location = phonesPanel.Location;
			Name = phonesPanel.Name;
			Size = phonesPanel.Size;
			TabIndex = phonesPanel.TabIndex;
            AutoSize = phonesPanel.AutoSize;
            AutoScroll = phonesPanel.AutoScroll;
            Anchor = phonesPanel.Anchor;

            MyPhoneTextBox = new MyPhoneTextBox(form);
			MyMorePhonesButton myMorePhonesButton = new MyMorePhonesButton(form, myOneOfficeFlowLayoutPanel);
			MyPhoneLabel myPhoneLabel = new MyPhoneLabel(form);

			Controls.Add(myMorePhonesButton);
			Controls.Add(MyPhoneTextBox);
			Controls.Add(myPhoneLabel);
		}
	}
}
