using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.ContactPersonPanel.PhonesContactPersonFlowLayoutPanel.OnePhonePanel.PhonePanelElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.ContactPersonPanel.PhonesContactPersonFlowLayoutPanel.OnePhonePanel
{
    public class MyPhonePanel : Panel
    {
        public List<MyPhoneCommentTextBox> MyPhoneCommentTextBox { get; set; } = new List<MyPhoneCommentTextBox>();
        public List<MyPhoneNumberLabel> MyPhoneNumberLabel { get; set; } = new List<MyPhoneNumberLabel>();
        public List<MyPhoneTypeLabel> MyPhoneTypeLabel { get; set; } = new List<MyPhoneTypeLabel>();

        public MyPhonePanel(AddNewContactPersonForm form)
        {
            Panel phonePanel = form.GetPhonePanel();

            Location = phonePanel.Location;
            Name = phonePanel.Name;
            Size = phonePanel.Size;
            TabIndex = phonePanel.TabIndex;

            MyPhoneCommentTextBox phoneCommentTextBox = new MyPhoneCommentTextBox(form);
            MyPhoneNumberLabel phoneNumberLabel = new MyPhoneNumberLabel(form);
            MyPhoneTypeLabel phoneTypeLabel = new MyPhoneTypeLabel(form);

            AddPhoneCommentTextBox(phoneCommentTextBox);
            AddPhoneNumberLabel(phoneNumberLabel);
            AddPhoneTypeLabel(phoneTypeLabel);
        }

        private void AddPhoneCommentTextBox(MyPhoneCommentTextBox textBox)
        {
            MyPhoneCommentTextBox.Add(textBox);
            Controls.Add(textBox);
        }

        private void AddPhoneNumberLabel(MyPhoneNumberLabel label)
        {
            MyPhoneNumberLabel.Add(label);
            Controls.Add(label);
        }

        private void AddPhoneTypeLabel(MyPhoneTypeLabel label)
        {
            MyPhoneTypeLabel.Add(label);
            Controls.Add(label);
        }
    }
}
