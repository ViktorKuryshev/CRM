using CRM_GTMK.Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_GTMK.Visual.Controls
{
	public class MyDataActionButtonsPanel : Panel
	{
		
		public MyDataActionButtonsPanel(Controller controller) : base()
		{

			Controls.Add(new MySaveCompanyDataButton(controller));

			Location = new System.Drawing.Point(3, 279);
			Name = "dataActionsPanel";
			Size = new System.Drawing.Size(552, 71);
			TabIndex = 14;

		}
	}
}
