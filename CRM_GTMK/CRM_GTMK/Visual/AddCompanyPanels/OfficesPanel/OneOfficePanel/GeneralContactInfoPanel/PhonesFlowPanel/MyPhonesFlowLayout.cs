using System.Collections.Generic;
using System.Windows.Forms;
using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.GeneralContactInfoPanel.PhonesFlowPanel.OnePhonePanel;

namespace CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.GeneralContactInfoPanel.PhonesFlowPanel
{
	public class MyPhonesFlowLayout : FlowLayoutPanel
	{
		public List<MyPhonePanel> MyPhonePanelList { get; } = new List<MyPhonePanel>();

		public MyPhonesFlowLayout(AddNewCompanyForm form, MyOneOfficeFlowLayoutPanel myOneOfficeFlowLayoutPanel)
		{
			FlowLayoutPanel flowPanel = form.GetPhonesFlowLayoutPanel();

			AutoSize = flowPanel.AutoSize;
            AutoScroll = flowPanel.AutoScroll;
            Anchor = flowPanel.Anchor;
            BorderStyle = flowPanel.BorderStyle;
			FlowDirection = flowPanel.FlowDirection;
			Location = flowPanel.Location;
			Margin = flowPanel.Margin;
			Name = flowPanel.Name;
			Size = flowPanel.Size;
			TabIndex = flowPanel.TabIndex;

			MyPhonePanel MyPhonePanel = new MyPhonePanel(form, myOneOfficeFlowLayoutPanel);

            Add(MyPhonePanel);
		}

		public void Add(MyPhonePanel panel)
		{
			MyPhonePanelList.Add(panel);
			Controls.Add(panel);
		}
	}
}
