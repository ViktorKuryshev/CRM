using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRM_GTMK.Control;

namespace CRM_GTMK.Visual.MyPanels
{
	public class MyPhoneTextBox : TextBox
	{
		public MyPhoneTextBox(AddNewClientForm form)
		{
			TextBox phoneTextBox = form.GetPhoneTextBox();

			Location = phoneTextBox.Location;
			Name = phoneTextBox.Name;
			Size = phoneTextBox.Size;
			TabIndex = phoneTextBox.TabIndex;
		}
	}
}
