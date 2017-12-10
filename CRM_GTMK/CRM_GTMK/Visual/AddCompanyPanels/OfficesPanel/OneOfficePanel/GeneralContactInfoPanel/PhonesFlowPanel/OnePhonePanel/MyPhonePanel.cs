using System.Windows.Forms;

namespace CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.GeneralContactInfoPanel.PhonesFlowPanel.OnePhonePanel
{
	public class MyPhonePanel : Panel
	{
		public MyPhoneTextBox MyPhoneTextBox { get; set; }

		public MyPhonePanel(AddNewCompanyForm form)
		{

			Panel phonesPanel = form.GetPhonePanel(); 

			Location = phonesPanel.Location;
			Name = phonesPanel.Name;
			Size = phonesPanel.Size;
			TabIndex = phonesPanel.TabIndex;
			
			MyPhoneTextBox = new MyPhoneTextBox(form);
			MyMorePhonesButton myMorePhonesButton = new MyMorePhonesButton(form);
			MyPhoneLabel myPhoneLabel = new MyPhoneLabel(form);

			Controls.Add(myMorePhonesButton);
			Controls.Add(MyPhoneTextBox);
			Controls.Add(myPhoneLabel);
		}
	}
}
