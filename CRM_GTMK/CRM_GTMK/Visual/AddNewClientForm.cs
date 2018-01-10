using CRM_GTMK.Control;
using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel;
using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.OneOfficeContactTableLayoutPanel;
using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.OneOfficeContactTableLayoutPanel.ContactPersonTablePanel;
using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.OneOfficeContactTableLayoutPanel.ContactPersonTablePanel.OneContactPersonTablePanel;
using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.OneOfficePanel.OneOfficeContactTableLayoutPanel.PhonesFlowPanel.OnePhonePanel;
using System;
using System.Windows.Forms;

namespace CRM_GTMK.Visual
{
    public partial class AddNewCompanyForm : Form
	{
		private Controller _controller;
        private MyContactPersonTableLayoutPanel _contactPersonTableLayoutPanel;
        private MyContactPersonFullnameLinkLabel _contactPersonFullnameLinkLabel;

        public MyAllOfficesFlowLayoutPanel MyAllOfficesFlowLayoutPanel { get; set; }
        public int OfficeNumber { get; set; }
        public TextBox NewCompanyNameTextBox;

        public AddNewCompanyForm(Controller controller)
		{
			_controller = controller;
			InitializeComponent();
			resetForms();
		}

		#region Getters

		public FlowLayoutPanel GetPhonesFlowLayoutPanel()
		{
			return phonesFlowLayoutPanel;
		}

		public Panel GetPhonePanel()
		{
			return onePhonePanel;
		}

		public TextBox GetPhoneTextBox()
		{
			return phoneTextBox;
		}

		public Button GetMorePhonesButton()
		{
			return morePhonesButton;
		}

		public Label GetPhoneLabel()
		{
			return phoneLabel;
		}

        public Panel GetOfficeContactInfoPanel()
        {
            return officeContactInfoPanel;
        }

        public TextBox GetOfficeAddressTextBox()
        {
            return officeAddressTextBox;
        }

        public Label GetOfficeAddressLabel()
        {
            return officeAddressLabel;
        }

        public TextBox GetOfficeCityTextBox()
        {
            return officeCityTextBox;
        }

        public Label GetOfficeCityLabel()
        {
            return officeCityLabel;
        }

        public TextBox GetOfficeSiteTextBox()
        {
            return officeSiteTextBox;
        }

        public Label GetOfficeSiteLabel()
        {
            return officeSiteLabel;
        }

        public ComboBox GetOfficeCountryComboBox()
        {
            return officeCountryComboBox;
        }

        public Label GetOfficeCountryLabel()
        {
            return officeCountryLabel;
        }

        public Panel GetContactPersonPanel()
        {
            return contactPersonPanel;
        }

        public Label GetContactPersonsLabel()
        {
            return contactPersonsLabel;
        }

        public Button GetContactPersonsButton()
        {
            return contactPersonsButton;
        }

        public TableLayoutPanel GetContactPersonTableLayoutPanel()
        {
            return contactPersonTableLayoutPanel;
        }

        public LinkLabel GetContactPersonLinkLabel()
        {
            return contactPersonFullnameLinkLabel;
        }

        public Label GetContactPersonPositionLabel()
        {
            return contactPersonPositionLabel;
        }

        public Label GetContactPersonPhoneLabel()
        {
            return contactPersonPhoneLabel;
        }

		public Panel GetNewCompanyActionMenuPanel()
        {
            return newCompanyActionMenuPanel;
        }

        public Button GetAddClientDataButton()
        {
            return addClientDataButton;
        }

        public FlowLayoutPanel GetAllOfficesFlowLayoutPanel()
        {
            return allOfficesFlowLayoutPanel;
        }

        public TableLayoutPanel GetOneOfficeContactTableLayoutPanel()
        {
            return oneOfficeContactTableLayoutPanel;
        }

        public Label GetOfficeNumberLabel()
        {
            return officeNumberLabel;
        }

        public Label GetFullnameLabel()
        {
            return fullnameLabel;
        }

        #endregion

        // Удаляем формы, которые добавляются по нажатию на соответствующие кнопки.
        // Добавляем свои формы.
        private void resetForms()
		{
            this.Controls.Remove(allOfficesFlowLayoutPanel);

            MyAllOfficesFlowLayoutPanel myAllOfficesFlowLayoutPanel = new MyAllOfficesFlowLayoutPanel(this);

            this.Controls.Add(myAllOfficesFlowLayoutPanel);
            MyAllOfficesFlowLayoutPanel = myAllOfficesFlowLayoutPanel;
		}

        // Сохраняем введенные данные о компании.
        public void AddCompanyDataButton_Click()
        {
            NewCompanyNameTextBox = companyNameTextBox;
            _controller.SaveNewCompanyData();
            this.Dispose();
        }

        // Добавляем новую форму для телефона в форме для офиса, на котором была нажата
        // кнопка "Еще".
        public void AddOneMorePhonePanel(MyOneOfficeContactTableLayoutPanel myOneOfficeContactTableLayoutPanel)
        {
            myOneOfficeContactTableLayoutPanel
           .MyPhonesFlowLayoutPanel
           .Add(new MyPhonePanel(this, myOneOfficeContactTableLayoutPanel));
        }

        // Добавляем новую форму для очередного офиса на данную панель.
        private void addOfficeButton_Click(object sender, EventArgs e)
        {
            OfficeNumber++;
            MyAllOfficesFlowLayoutPanel.Controls.Remove(MyAllOfficesFlowLayoutPanel
                                                       .MyNewCompanyActionMenuPanel);

            MyOneOfficeContactTableLayoutPanel tableLayoutPanel = new MyOneOfficeContactTableLayoutPanel(this);

            MyAllOfficesFlowLayoutPanel.MyOneOfficeContactTableLayoutPanelList.Add(tableLayoutPanel);

            MyAllOfficesFlowLayoutPanel.Controls.Add(tableLayoutPanel);
            MyAllOfficesFlowLayoutPanel.Controls.Add(MyAllOfficesFlowLayoutPanel
                                                    .MyNewCompanyActionMenuPanel);
        }

        // Открываем окно с формой ввода данных для нового сотрудника.
        public void AddNewContactPerson(MyOneOfficeContactTableLayoutPanel panel)
        {
            _controller.ShowAddNewContactPersonDialog(panel);
        }

        // Отображаем введенные данные по сотруднику на данной панели.
        public void AddAndDisplayNewContactPerson(AddNewContactPersonForm form, int officeNumber)
        {
            MyContactPersonTableLayoutPanel myContactPersonTableLayoutPanel =
                                                  MyAllOfficesFlowLayoutPanel
                                                 .MyOneOfficeContactTableLayoutPanelList[officeNumber]
                                                 .MyContactPersonTableLayoutPanel;

            MyContactPersonFullnameLinkLabel contactPersonFullnameLinkLabel = 
                new MyContactPersonFullnameLinkLabel(this, form, myContactPersonTableLayoutPanel);
            contactPersonFullnameLinkLabel.Text = form.NameContactPerson;
            MyContactPersonPositionLabel contactPersonPositionLabel = new MyContactPersonPositionLabel(this);
            contactPersonPositionLabel.Text = form.PositionContactPerson;
            MyContactPersonPhoneLabel contactPersonPhoneLabel = new MyContactPersonPhoneLabel(this);

            // TODO Здесь нужно определить, какой номер телефона выводить в таблицу.
            contactPersonPhoneLabel.Text = form.MyContactPersonPhoneFormList[0].NewPhoneNumber;

            myContactPersonTableLayoutPanel.Controls.Add(contactPersonFullnameLinkLabel);
            myContactPersonTableLayoutPanel.Controls.Add(contactPersonPositionLabel);
            myContactPersonTableLayoutPanel.Controls.Add(contactPersonPhoneLabel);
        }

        // TODO Попробовать переделать данный метод с использованием GetNextControl метод.
        // Отображаем введенные ФИО, должность и телефон из повторно открытой формы для добавления
        // нового сотрудника с учетом внесенных изменений после ее очередного закрытия.
        public void RedisplayReopenedContactPersonForm(AddNewContactPersonForm contactPersonForm)
        {
            _contactPersonFullnameLinkLabel.Text = contactPersonForm.NameContactPerson;

            // Цифра 1 в выражении "IndexOf(_contactPersonFullnameLinkLabel) + 1" означает 
            // следующий индекс объекта типа "MyContactPersonPositionLabel" (поле с должностью 
            // сотрудника) относительно индекса объекта типа "MyContactPersonFullnameLinkLabel"
            // (поле с ФИО сотрудника).
            MyContactPersonPositionLabel positionLabel =
                (MyContactPersonPositionLabel)_contactPersonTableLayoutPanel
                .Controls[_contactPersonTableLayoutPanel.Controls
                .IndexOf(_contactPersonFullnameLinkLabel) + 1];

            positionLabel.Text = contactPersonForm.PositionContactPerson;

            MyContactPersonPhoneLabel phoneLabel =
                (MyContactPersonPhoneLabel)_contactPersonTableLayoutPanel
                .Controls[_contactPersonTableLayoutPanel.Controls
                .IndexOf(positionLabel) + 1];

            // TODO Здесь нужно определить, какой номер телефона выводить в таблицу.
            phoneLabel.Text = contactPersonForm.MyContactPersonPhoneFormList[0].NewPhoneNumber;
        }

        // Повторно открываем закрытую форму добавления нового сотрудника при нажатии на
        // LinkLabel с ФИО конкретного сотрудника.
        public void ReopenContactPersonForm(MyContactPersonFullnameLinkLabel contactPersonFullnameLinkLabel,
                                            AddNewContactPersonForm contactPersonForm,
                                            MyContactPersonTableLayoutPanel contactPersonTableLayoutPanel)
        {
            _contactPersonFullnameLinkLabel = contactPersonFullnameLinkLabel;
            _contactPersonTableLayoutPanel = contactPersonTableLayoutPanel;
            contactPersonForm.StartPosition = FormStartPosition.Manual;
            contactPersonForm.Show();
        }

    }
}
