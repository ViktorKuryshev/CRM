using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.ContactPersonPanel.CommentsContactPersonFlowLayoutPanel.CommentsInnerFlowLayoutPanel.OneCommentPanel.CommentPanelElements
{
    public class MyRichTextBox : RichTextBox
    {
        public MyRichTextBox(AddNewContactPersonForm form)
        {
            RichTextBox commentRichTextBox = form.GetCommentRichTextBox();

            Location = commentRichTextBox.Location;
            Name = commentRichTextBox.Name;
            Size = commentRichTextBox.Size;
            TabIndex = commentRichTextBox.TabIndex;
            Text = commentRichTextBox.Text;
        }
    }
}
