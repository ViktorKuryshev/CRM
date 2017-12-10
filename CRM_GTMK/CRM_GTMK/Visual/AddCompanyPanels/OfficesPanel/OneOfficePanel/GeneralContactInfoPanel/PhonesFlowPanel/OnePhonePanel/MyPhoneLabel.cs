using System.Windows.Forms;

namespace CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.GeneralContactInfoPanel.PhonesFlowPanel.OnePhonePanel
{
	public class MyPhoneLabel : Label
	{
		public MyPhoneLabel(AddNewCompanyForm form)
		{
			Label phoneLabel = form.GetPhoneLabel();

			AutoSize = phoneLabel.AutoSize;
			Location = phoneLabel.Location;
			Name = phoneLabel.Name;
			Size = phoneLabel.Size;
			TabIndex = phoneLabel.TabIndex;
			Text = phoneLabel.Text;
		}
	}
}
