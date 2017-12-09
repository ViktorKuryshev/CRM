using CRM_GTMK.Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_GTMK.Visual.MyPanels
{
	public class MyPhonesFlowLayout : FlowLayoutPanel
	{
		public List<MyPhonePanel> MyPhonePanels { get; } = new List<MyPhonePanel>();

		public MyPhonesFlowLayout(AddNewClientForm form)
		{
			FlowLayoutPanel flowPanel = form.GetPhonesFlowLayoutPanel();

			AutoSize = true;
			BorderStyle = flowPanel.BorderStyle;
			FlowDirection = flowPanel.FlowDirection;
			Location = flowPanel.Location;
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
