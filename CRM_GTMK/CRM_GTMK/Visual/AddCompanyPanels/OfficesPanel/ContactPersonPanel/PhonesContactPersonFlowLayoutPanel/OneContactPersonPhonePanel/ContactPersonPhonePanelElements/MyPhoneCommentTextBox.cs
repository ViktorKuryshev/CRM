using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.ContactPersonPanel.PhonesContactPersonFlowLayoutPanel.OneContactPersonPhonePanel.ContactPersonPhonePanelElements
{
    public class MyPhoneCommentTextBox : TextBox
    {
        private AddNewContactPersonForm _form;

        public MyPhoneCommentTextBox(AddNewContactPersonForm form)
        {
            _form = form;

            TextBox phoneCommentTextBox = form.GetPhoneCommentTextBox();

            ReadOnly = phoneCommentTextBox.ReadOnly;
            Enabled = phoneCommentTextBox.Enabled;
            Cursor = phoneCommentTextBox.Cursor;
            Location = phoneCommentTextBox.Location;
            Name = phoneCommentTextBox.Name;
            Size = phoneCommentTextBox.Size;
            TabIndex = phoneCommentTextBox.TabIndex;

            MouseHover += new EventHandler(phoneCommentTextBox_MouseHover);
        }

        private void phoneCommentTextBox_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            Regex rgx = new Regex("(.{10}\\s)");
            string WrappedMessage = rgx.Replace(Text, "$1\n");
            toolTip.SetToolTip(this, WrappedMessage);
        }
    }
}
