using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.ContactPersonPanel.CommentsContactPersonFlowLayoutPanel.CommentPanel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.ContactPersonPanel.CommentsContactPersonFlowLayoutPanel
{
    public class MyCommentsContactPersonFlowLayoutPanel : FlowLayoutPanel
    {
        public MyCommentsContactPersonFlowLayoutPanel(AddNewContactPersonForm form)
        {
            FlowLayoutPanel contactPersonFlowLayoutPanel = form.GetCommentsContactPersonFlowLayoutPanel();

            WrapContents = contactPersonFlowLayoutPanel.WrapContents;
            Anchor = contactPersonFlowLayoutPanel.Anchor;
            AutoScroll = contactPersonFlowLayoutPanel.AutoScroll;
            AutoSize = contactPersonFlowLayoutPanel.AutoSize;
            FlowDirection = contactPersonFlowLayoutPanel.FlowDirection;
            Location = contactPersonFlowLayoutPanel.Location;
            Name = contactPersonFlowLayoutPanel.Name;
            Size = contactPersonFlowLayoutPanel.Size;
            TabIndex = contactPersonFlowLayoutPanel.TabIndex;
        }
    }
}
