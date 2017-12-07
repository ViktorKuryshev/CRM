using CRM_GTMK.Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_GTMK.Visual.Controls
{
	public class MySaveCompanyDataButton : Button
	{
		private Controller _controller;

		public MySaveCompanyDataButton(Controller controller) : base()
		{
			_controller = controller;

			Location = new System.Drawing.Point(343, 16);
			Name = "MyAddClientDataButton";
			Size = new System.Drawing.Size(162, 35);
			TabIndex = 3;
			Text = "Сохранить";
			UseVisualStyleBackColor = true;
			Click += new System.EventHandler(this.IsClicked);
		}

		private void IsClicked(object sender, EventArgs e)
		{
			_controller.SaveCompanyData();
		}
	}
}
