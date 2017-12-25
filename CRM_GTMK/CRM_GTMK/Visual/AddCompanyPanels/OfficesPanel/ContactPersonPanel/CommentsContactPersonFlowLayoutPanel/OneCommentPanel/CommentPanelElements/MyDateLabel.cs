using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.ContactPersonPanel.CommentsContactPersonFlowLayoutPanel.OneCommentPanel.CommentPanelElements
{
    public class MyDateLabel : Label
    {
        public MyDateLabel(AddNewContactPersonForm form)
        {
            Label dateLabel = form.GetDateLabel();

            AutoSize = dateLabel.AutoSize;
            Location = dateLabel.Location;
            Name = dateLabel.Name;
            Size = dateLabel.Size;
            TabIndex = dateLabel.TabIndex;
            DateTime currentTime = DateTime.Now;
            CultureInfo russianCulture = new CultureInfo("ru-Ru");
            Text = currentTime.ToString("g", russianCulture) + "\nДобавил Вася";
        }
    }
}
