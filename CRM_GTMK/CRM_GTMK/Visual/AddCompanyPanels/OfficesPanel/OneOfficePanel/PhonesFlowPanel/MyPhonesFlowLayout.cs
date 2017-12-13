using System.Collections.Generic;
using System.Windows.Forms;
using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.GeneralContactInfoPanel.PhonesFlowPanel.OnePhonePanel;

namespace CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.GeneralContactInfoPanel.PhonesFlowPanel
{
	public class MyPhonesFlowLayout : FlowLayoutPanel
	{
		public List<MyPhonePanel> MyPhonePanels { get; } = new List<MyPhonePanel>();

		public MyPhonesFlowLayout(AddNewCompanyForm form)
		{
			FlowLayoutPanel flowPanel = form.GetPhonesFlowLayoutPanel();

			AutoSize = true;
			BorderStyle = flowPanel.BorderStyle;
			FlowDirection = flowPanel.FlowDirection;
			Location = flowPanel.Location;
			Margin = flowPanel.Margin;
			Name = flowPanel.Name;
			Size = flowPanel.Size;
			TabIndex = flowPanel.TabIndex;

			MyPhonePanel MyPhonePanel = new MyPhonePanel(form);
			
			Add(MyPhonePanel);
		}

		public void Add(MyPhonePanel panel)
		{
			MyPhonePanels.Add(panel);
			Controls.Add(panel);
		}

	}
}
