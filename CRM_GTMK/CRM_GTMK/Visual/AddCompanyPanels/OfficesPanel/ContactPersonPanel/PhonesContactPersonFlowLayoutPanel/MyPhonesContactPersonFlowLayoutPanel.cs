using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.ContactPersonPanel.PhonesContactPersonFlowLayoutPanel.OnePhonePanel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.ContactPersonPanel.PhonesContactPersonFlowLayoutPanel
{
    public class MyPhonesContactPersonFlowLayoutPanel : FlowLayoutPanel
    {
        public MyPhonesContactPersonFlowLayoutPanel(AddNewContactPersonForm form)
        {
            FlowLayoutPanel phonesContactPersonFlowLayoutPanel = form.GetPhonesContactPersonFlowLayoutPanel();

            FlowDirection = phonesContactPersonFlowLayoutPanel.FlowDirection;
            WrapContents = phonesContactPersonFlowLayoutPanel.WrapContents;
            AutoScroll = phonesContactPersonFlowLayoutPanel.AutoScroll;
            AutoSize = phonesContactPersonFlowLayoutPanel.AutoSize;
            Location = phonesContactPersonFlowLayoutPanel.Location;
            Name = phonesContactPersonFlowLayoutPanel.Name;
            Size = phonesContactPersonFlowLayoutPanel.Size;
            TabIndex = phonesContactPersonFlowLayoutPanel.TabIndex;
        }
    }
}
