using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.ContactPersonPanel.CommentsContactPersonFlowLayoutPanel.CommentsInnerFlowLayoutPanel
{
    public class MyCommentsInnerFlowLayoutPanel : FlowLayoutPanel
    {
        public MyCommentsInnerFlowLayoutPanel(AddNewContactPersonForm form)
        {
            FlowLayoutPanel commentsInnerFlowLayoutPanel = form.GetCommentsInnerFlowLayoutPanel();

            Anchor = commentsInnerFlowLayoutPanel.Anchor;
            AutoSize = commentsInnerFlowLayoutPanel.AutoSize;
            FlowDirection = commentsInnerFlowLayoutPanel.FlowDirection;
            Location = commentsInnerFlowLayoutPanel.Location;
            Name = commentsInnerFlowLayoutPanel.Name;
            Size = commentsInnerFlowLayoutPanel.Size;
            TabIndex = commentsInnerFlowLayoutPanel.TabIndex;
            WrapContents = commentsInnerFlowLayoutPanel.WrapContents;
        }
    }
}
