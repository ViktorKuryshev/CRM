using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRM_GTMK.Control;

namespace CRM_GTMK.Visual.Elements
{
	public class MyMorePhonesButton : Button
	{

		private AddNewClientForm _form;
		public MyMorePhonesButton(AddNewClientForm form)
		{

			_form = form;
			Button morePhonesButton = form.GetMorePhonesButton();

			Location = morePhonesButton.Location;
			Name = morePhonesButton.Name;
			Size = morePhonesButton.Size;
			TabIndex = morePhonesButton.TabIndex;
			Text = morePhonesButton.Text;
			UseVisualStyleBackColor = morePhonesButton.UseVisualStyleBackColor;

			Click += new System.EventHandler(IsClicked);
		}

		public void IsClicked(object sender, EventArgs e)
		{
			_form.AddOneMorePhonePanel();
		}
	}
}
