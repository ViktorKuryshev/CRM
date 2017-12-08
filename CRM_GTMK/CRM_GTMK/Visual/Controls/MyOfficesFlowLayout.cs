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
		
		public MyOfficesFlowLayout(Controller controller, AddNewClientForm form) : base()
		{

			FlowLayoutPanel officesFlowLayout = form.GetOfficesFlowLayoutPanel();

			AutoSize = officesFlowLayout.AutoSize;
			
			//Controls.Add(this.flowLayoutPanel3);
			Controls.Add(new MyDataActionButtonsPanel(controller));

			FlowDirection = officesFlowLayout.FlowDirection;
			Location = officesFlowLayout.Location;
			Name = officesFlowLayout.Name;
			Size = officesFlowLayout.Size;
			TabIndex = officesFlowLayout.TabIndex;
		}

	}
}
