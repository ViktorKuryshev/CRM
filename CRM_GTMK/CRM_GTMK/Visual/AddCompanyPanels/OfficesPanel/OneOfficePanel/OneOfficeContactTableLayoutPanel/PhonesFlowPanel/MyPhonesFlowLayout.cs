using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.OneOfficeContactTableLayoutPanel.PhonesFlowPanel.OnePhonePanel;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.OneOfficeContactTableLayoutPanel.PhonesFlowPanel
{
	public class MyPhonesFlowLayout : FlowLayoutPanel
	{
		public List<MyPhonePanel> MyPhonePanels { get; } = new List<MyPhonePanel>();

		public MyPhonesFlowLayout(AddNewCompanyForm form, MyOneOfficeContactTableLayoutPanel myOneOfficeContactTableLayoutPanel)
		{
			FlowLayoutPanel flowPanel = form.GetPhonesFlowLayoutPanel();

			AutoSize = flowPanel.AutoSize;
            AutoScroll = flowPanel.AutoScroll;
			BorderStyle = flowPanel.BorderStyle;
			FlowDirection = flowPanel.FlowDirection;
			Location = flowPanel.Location;
			Margin = flowPanel.Margin;
			Name = flowPanel.Name;
			Size = flowPanel.Size;
			TabIndex = flowPanel.TabIndex;

            MyPhonePanel myPhonePanel = new MyPhonePanel(form, myOneOfficeContactTableLayoutPanel);
			
			Add(myPhonePanel);

            SetSpans(form, flowPanel, myOneOfficeContactTableLayoutPanel);
        }

        public void Add(MyPhonePanel panel)
        {
            MyPhonePanels.Add(panel);
            Controls.Add(panel);
        }

        private void SetSpans(AddNewCompanyForm form, FlowLayoutPanel flowPanel,
                              MyOneOfficeContactTableLayoutPanel myOneOfficeContactTableLayoutPanel)
        {
            int columnSpan = form.GetOneOfficeContactTableLayoutPanel().GetColumnSpan(flowPanel);
            myOneOfficeContactTableLayoutPanel.SetColumnSpan(this, columnSpan);

            int rowSpan = form.GetOneOfficeContactTableLayoutPanel().GetRowSpan(flowPanel);
            myOneOfficeContactTableLayoutPanel.SetRowSpan(this, rowSpan);
        }   
    }
}
