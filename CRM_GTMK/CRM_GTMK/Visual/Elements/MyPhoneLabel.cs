using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRM_GTMK.Control;

namespace CRM_GTMK.Visual.Elements
{
	public class MyPhoneLabel : Label
	{
		public MyPhoneLabel(Controller controller, AddNewClientForm form)
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
