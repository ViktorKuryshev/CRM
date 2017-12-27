using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.ContactPersonPanel.CommentsContactPersonFlowLayoutPanel.CommentsInnerFlowLayoutPanel.OneCommentPanel.CommentPanelElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.ContactPersonPanel.CommentsContactPersonFlowLayoutPanel.CommentsInnerFlowLayoutPanel.OneCommentPanel
{
    public class MyCommentPanel : Panel
    {
        public MyRichTextBox MyCommentRichTextBox { get; set; }
        public MyDateLabel MyDateLabel { get; set; }

        public MyCommentPanel(AddNewContactPersonForm form)
        {
            Panel commentPanel = form.GetCommentPanel();

            Anchor = commentPanel.Anchor;
            Location = commentPanel.Location;
            Name = commentPanel.Name;
            Size = commentPanel.Size;
            TabIndex = commentPanel.TabIndex;

            MyCommentRichTextBox = new MyRichTextBox(form);
            MyDateLabel = new MyDateLabel(form);

            Controls.Add(MyCommentRichTextBox);
            Controls.Add(MyDateLabel);
        }
    }
}
