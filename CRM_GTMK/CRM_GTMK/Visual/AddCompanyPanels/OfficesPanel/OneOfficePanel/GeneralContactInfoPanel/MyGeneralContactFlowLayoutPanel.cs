using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.GeneralContactInfoPanel.OfficeContactInfoPanel;
using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.GeneralContactInfoPanel.PhonesFlowPanel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.GeneralContactInfoPanel
{
    public class MyGeneralContactFlowLayoutPanel : FlowLayoutPanel
    {
        public MyPhonesFlowLayout MyPhonesFlowLayout { get; set; }

        public MyGeneralContactFlowLayoutPanel(AddNewCompanyForm form, MyOneOfficeFlowLayoutPanel myOneOfficeFlowLayoutPanel)
        {
            FlowLayoutPanel generalContactFlowLayoutPanel = form.GetGeneralContactFlowLayoutPanel();

            FlowDirection = generalContactFlowLayoutPanel.FlowDirection;
            Location = generalContactFlowLayoutPanel.Location;
            Name = generalContactFlowLayoutPanel.Name;
            Size = generalContactFlowLayoutPanel.Size;
            TabIndex = generalContactFlowLayoutPanel.TabIndex;
            AutoScroll = generalContactFlowLayoutPanel.AutoScroll;
            AutoSize = generalContactFlowLayoutPanel.AutoSize;
            Anchor = generalContactFlowLayoutPanel.Anchor;

            // Метод, на который ссылается PaintEventHandler, пустой. Не понятно зачем он нужен
            // Поэтому не использую строку для Paint. Возможно можно удалить метод flowLayoutPanel1_Paint,
            // и, соответственно, строку для Paint. 
            // Paint += new System.Windows.Forms.PaintEventHandler(form.flowLayoutPanel1_Paint);

            MyOfficeContactInfoPanel officeContactInfoPanel = new MyOfficeContactInfoPanel(form);
            MyPhonesFlowLayout phonesFlowLayoutPanel = new MyPhonesFlowLayout(form, myOneOfficeFlowLayoutPanel);

            Controls.Add(officeContactInfoPanel);
            AddMyPhonesFlowLayout(phonesFlowLayoutPanel);
        }

        private void AddMyPhonesFlowLayout(MyPhonesFlowLayout panel)
        {
            MyPhonesFlowLayout = panel;
            Controls.Add(panel);
        }
    }
}
