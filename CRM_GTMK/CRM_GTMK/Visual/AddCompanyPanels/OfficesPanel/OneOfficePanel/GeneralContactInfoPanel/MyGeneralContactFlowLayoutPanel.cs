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
        public MyGeneralContactFlowLayoutPanel(AddNewCompanyForm form)
        {
            FlowLayoutPanel generalContactFlowLayoutPanel = form.GetGeneralContactFlowLayoutPanel();

            FlowDirection = generalContactFlowLayoutPanel.FlowDirection;
            Location = generalContactFlowLayoutPanel.Location;
            Name = generalContactFlowLayoutPanel.Name;
            Size = generalContactFlowLayoutPanel.Size;
            TabIndex = generalContactFlowLayoutPanel.TabIndex;

            // Метод, на который ссылается PaintEventHandler, пустой. Не понятно зачем он нужен
            // Поэтому не использую строку для Paint. Возможно можно удалить метод flowLayoutPanel1_Paint,
            // и, соответственно, строку для Paint. 
            //Paint += new System.Windows.Forms.PaintEventHandler(form.flowLayoutPanel1_Paint);

            MyOfficeContactInfoPanel officeContactInfoPanel = new MyOfficeContactInfoPanel(form);
            MyPhonesFlowLayout phonesFlowLayoutPanel = new MyPhonesFlowLayout(form);

            Controls.Add(officeContactInfoPanel);
            Controls.Add(phonesFlowLayoutPanel);
        }
    }
}
