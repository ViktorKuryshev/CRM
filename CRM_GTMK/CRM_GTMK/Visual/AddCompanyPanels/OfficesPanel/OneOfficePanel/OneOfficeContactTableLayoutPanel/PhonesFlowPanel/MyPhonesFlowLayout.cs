using System.Collections.Generic;
using System.Windows.Forms;
using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.GeneralContactInfoPanel.PhonesFlowPanel.OnePhonePanel;
using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.OneOfficeContactTableLayoutPanel;

namespace CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.GeneralContactInfoPanel.PhonesFlowPanel
{
	public class MyPhonesFlowLayout : FlowLayoutPanel
	{
		public List<MyPhonePanel> MyPhonePanels { get; } = new List<MyPhonePanel>();

		public MyPhonesFlowLayout(AddNewCompanyForm form, MyOneOfficeContactTableLayoutPanel myOneOfficeContactTableLayoutPanel)
		{
			FlowLayoutPanel flowPanel = form.GetPhonesFlowLayoutPanel();

			AutoSize = flowPanel.AutoSize;
			BorderStyle = flowPanel.BorderStyle;
			FlowDirection = flowPanel.FlowDirection;
			Location = flowPanel.Location;
			Margin = flowPanel.Margin;
			Name = flowPanel.Name;
			Size = flowPanel.Size;
			TabIndex = flowPanel.TabIndex;

			MyPhonePanel myPhonePanel = new MyPhonePanel(form, myOneOfficeContactTableLayoutPanel);
			
			Add(myPhonePanel);
		}

		public void Add(MyPhonePanel panel)
		{
			MyPhonePanels.Add(panel);
			Controls.Add(panel);
		}

	}
}
