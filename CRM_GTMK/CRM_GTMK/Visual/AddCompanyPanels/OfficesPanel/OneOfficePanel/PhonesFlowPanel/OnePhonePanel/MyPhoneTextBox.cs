using System.Windows.Forms;

namespace CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.GeneralContactInfoPanel.PhonesFlowPanel.OnePhonePanel
{
	public class MyPhoneTextBox : TextBox
	{
		public MyPhoneTextBox(AddNewCompanyForm form)
		{
			TextBox phoneTextBox = form.GetPhoneTextBox();

			Location = phoneTextBox.Location;
			Name = phoneTextBox.Name;
			Size = phoneTextBox.Size;
			TabIndex = phoneTextBox.TabIndex;
		}
	}
}
