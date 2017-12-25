using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.ContactPersonPanel.PhonesContactPersonFlowLayoutPanel.OnePhonePanel.PhonePanelElements
{
    public class MyPhoneCommentTextBox : TextBox
    {
        public MyPhoneCommentTextBox(AddNewContactPersonForm form)
        {
            TextBox phoneCommentTextBox = form.GetPhoneCommentTextBox();

            ReadOnly = phoneCommentTextBox.ReadOnly;
            Enabled = phoneCommentTextBox.Enabled;
            Cursor = phoneCommentTextBox.Cursor;
            Location = phoneCommentTextBox.Location;
            Name = phoneCommentTextBox.Name;
            Size = phoneCommentTextBox.Size;
            TabIndex = phoneCommentTextBox.TabIndex;
        }
    }
}
