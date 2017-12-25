using CRM_GTMK.Control;
using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.ContactPersonPanel.CommentsContactPersonFlowLayoutPanel;
using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.ContactPersonPanel.CommentsContactPersonFlowLayoutPanel.CommentPanel;
using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.ContactPersonPanel.PhonesContactPersonFlowLayoutPanel;
using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.ContactPersonPanel.PhonesContactPersonFlowLayoutPanel.OnePhonePanel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_GTMK.Visual
{
    public partial class AddNewContactPersonForm : Form
    {
        private Controller _controller;
        private MyPhonesContactPersonFlowLayoutPanel _myPhonesFlowLayoutPanel;
        private MyCommentsContactPersonFlowLayoutPanel _myCommentsFlowLayoutPanel;

        public List<MyCommentPanel> MyCommentPanel { get; set; } = new List<MyCommentPanel>();
        public List<MyPhonePanel> MyPhonePanel { get; set; } = new List<MyPhonePanel>();

        public AddNewContactPersonForm(Controller controller)
        {
            _controller = controller;
            InitializeComponent();
            ResetForms();
        }

        private void ResetForms()
        {
            Controls.Remove(phonesContactPersonFlowLayoutPanel);
            Controls.Remove(commentsContactPersonFlowLayoutPanel);

            MyPhonesContactPersonFlowLayoutPanel myPhonesFlowLayoutPanel = new MyPhonesContactPersonFlowLayoutPanel(this);
            MyCommentsContactPersonFlowLayoutPanel myCommentsFlowLayoutPanel = new MyCommentsContactPersonFlowLayoutPanel(this);

            _myPhonesFlowLayoutPanel = myPhonesFlowLayoutPanel;
            _myCommentsFlowLayoutPanel = myCommentsFlowLayoutPanel;

            Controls.Add(myPhonesFlowLayoutPanel);
            Controls.Add(myCommentsFlowLayoutPanel);
        }

        #region Getters

        public FlowLayoutPanel GetCommentsContactPersonFlowLayoutPanel()
        {
            return commentsContactPersonFlowLayoutPanel;
        }

        public Panel GetCommentPanel()
        {
            return commentPanel;
        }

        public Label GetDateLabel()
        {
            return dateLabel;
        }

        public RichTextBox GetCommentRichTextBox()
        {
            return commentRichTextBox;
        }

        public FlowLayoutPanel GetPhonesContactPersonFlowLayoutPanel()
        {
            return phonesContactPersonFlowLayoutPanel;
        }

        public Panel GetPhonePanel()
        {
            return phonePanel;
        }

        public TextBox GetPhoneCommentTextBox()
        {
            return phoneCommentTextBox;
        }

        public Label GetPhoneNumberLabel()
        {
            return phoneNumberLabel;
        }

        public Label GetPhoneTypeLabel()
        {
            return phoneTypeLabel;
        }

        #endregion

        private void addNewCommentContactPersonButton_Click(object sender, EventArgs e)
        {
            MyCommentPanel newCommentPanel = new MyCommentPanel(this);
            MyCommentPanel.Add(newCommentPanel);
            _myCommentsFlowLayoutPanel.Controls.Add(newCommentPanel);
        }

        private void addNewContactPersonPhoneButton_Click(object sender, EventArgs e)
        {
            MyPhonePanel newPhonePanel = new MyPhonePanel(this);
            MyPhonePanel.Add(newPhonePanel);
            _myPhonesFlowLayoutPanel.Controls.Add(newPhonePanel);
        }
    }
}
