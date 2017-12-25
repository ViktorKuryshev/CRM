﻿using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.ContactPersonPanel.CommentsContactPersonFlowLayoutPanel.OneCommentPanel.CommentPanelElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.ContactPersonPanel.CommentsContactPersonFlowLayoutPanel.CommentPanel
{
    public class MyCommentPanel : Panel
    {
        public List<MyCommentRichTextBox> MyCommentRichTextBox { get; set; } = new List<MyCommentRichTextBox>();
        public List<MyDateLabel> MyDateLabel { get; set; } = new List<MyDateLabel>();

        public MyCommentPanel(AddNewContactPersonForm form)
        {
            Panel commentPanel = form.GetCommentPanel();

            Anchor = commentPanel.Anchor;
            Location = commentPanel.Location;
            Name = commentPanel.Name;
            Size = commentPanel.Size;
            TabIndex = commentPanel.TabIndex;

            MyCommentRichTextBox commentRichTextBox = new MyCommentRichTextBox(form);
            MyDateLabel dateLabel = new MyDateLabel(form);

            AddCommentRichTextBox(commentRichTextBox);
            AddDateLabel(dateLabel);
        }

        private void AddCommentRichTextBox(MyCommentRichTextBox richTextBox)
        {
            MyCommentRichTextBox.Add(richTextBox);
            Controls.Add(richTextBox);
        }

        private void AddDateLabel(MyDateLabel label)
        {
            MyDateLabel.Add(label);
            Controls.Add(label);
        }
    }
}
