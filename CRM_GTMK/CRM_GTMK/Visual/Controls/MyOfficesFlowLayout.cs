using CRM_GTMK.Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_GTMK.Visual.Controls
{
	public class MyOfficesFlowLayout : FlowLayoutPanel
	{
		
		public MyOfficesFlowLayout(Controller controller) : base()
		{
			
			AutoSize = true;
			
			//Controls.Add(this.flowLayoutPanel3);
			Controls.Add(new MyDataActionButtonsPanel(controller));

			FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			Location = new System.Drawing.Point(20, 65);
			Name = "MyOfficesFlowLayout";
			Size = new System.Drawing.Size(821, 494);
			TabIndex = 11;
		}

	}
}
