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

		public MyPhonePanel(AddNewClientForm form)
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
