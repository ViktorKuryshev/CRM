using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRM_GTMK.Control;
using CRM_GTMK.Visual.Elements;

namespace CRM_GTMK.Visual.MyPanels
{
	public class MyPhonePanel : Panel
	{
		public MyPhoneTextBox MyPhoneTextBox { get; set; }

		public MyPhonePanel(Controller controller, AddNewClientForm form)
		{

			Panel phonesPanel = form.GetPhonePanel(); 

			Location = phonesPanel.Location;
			Name = phonesPanel.Name;
			Size = phonesPanel.Size;
			TabIndex = phonesPanel.TabIndex;
			
			MyPhoneTextBox = new MyPhoneTextBox(controller, form);
			MyMorePhonesButton myMorePhonesButton = new MyMorePhonesButton(controller, form);
			MyPhoneLabel myPhoneLabel = new MyPhoneLabel(controller, form);

			Controls.Add(myMorePhonesButton);
			Controls.Add(MyPhoneTextBox);
			Controls.Add(myPhoneLabel);
		}
	}
}
