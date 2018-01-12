using CRM_GTMK.Control;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CRM_GTMK.Visual
{
    public partial class AddNewCompanyForm : Form
	{
		private Controller _controller;

        #region Properties
        public FlowLayoutPanel AllOfficesFlowLayoutPanel
        {
            get { return allOfficesFlowLayoutPanel; }
            set { allOfficesFlowLayoutPanel = value; }
        }
        public Panel NewCompanyActionMenuPanel
        {
            get { return newCompanyActionMenuPanel; }
            set { newCompanyActionMenuPanel = value; }
        }
        public TableLayoutPanel OneOfficeContactTableLayoutPanel
        {
            get { return oneOfficeContactTableLayoutPanel; }
            set { oneOfficeContactTableLayoutPanel = value; }
        }
        public Label OfficeNumberLabel
        {
            get { return officeNumberLabel; }
            set { officeNumberLabel = value; }
        }
        public Panel OfficeContactInfoPanel
        {
            get { return officeContactInfoPanel; }
            set { officeContactInfoPanel = value; }
        }
        public Label OfficeCountryLabel
        {
            get { return officeCountryLabel; }
            set { officeCountryLabel = value; }
        }
        public ComboBox OfficeCountryComboBox
        {
            get { return officeCountryComboBox; }
            set { officeCountryComboBox = value; }
        }
        public Label OfficeCityLabel
        {
            get { return officeCityLabel; }
            set { officeCityLabel = value; }
        }
        public TextBox OfficeCityTextBox
        {
            get { return officeCityTextBox; }
            set { officeCityTextBox = value; }
        }
        public Label OfficeAddressLabel
        {
            get { return officeAddressLabel; }
            set { officeAddressLabel = value; }
        }
        public TextBox OfficeAddressTextBox
        {
            get { return officeAddressTextBox; }
            set { officeAddressTextBox = value; }
        }
        public Label OfficeSiteLabel
        {
            get { return officeSiteLabel; }
            set { officeSiteLabel = value; }
        }
        public TextBox OfficeSiteTextBox
        {
            get { return officeSiteTextBox; }
            set { officeSiteTextBox = value; }
        }
        public FlowLayoutPanel PhonesFlowLayoutPanel
        {
            get { return phonesFlowLayoutPanel; }
            set { phonesFlowLayoutPanel = value; }
        }
        public Panel OnePhonePanel
        {
            get { return onePhonePanel; }
            set { onePhonePanel = value; }
        }
        public TextBox PhoneTextBox
        {
            get { return phoneTextBox; }
            set { phoneTextBox = value; }
        }
        public Button MorePhonesButton
        {
            get { return morePhonesButton; }
            set { morePhonesButton = value; }
        }
        public Label PhoneLabel
        {
            get { return phoneLabel; }
            set { phoneLabel = value; }
        }
        public Panel ContactPersonPanel
        {
            get { return contactPersonPanel; }
            set { contactPersonPanel = value; }
        }
        public Label ContactPersonsLabel
        {
            get { return contactPersonsLabel; }
            set { contactPersonsLabel = value; }
        }
        public Button ContactPersonsButton
        {
            get { return contactPersonsButton; }
            set { contactPersonsButton = value; }
        }
        public TableLayoutPanel ContactPersonTableLayoutPanel
        {
            get { return contactPersonTableLayoutPanel; }
            set { contactPersonTableLayoutPanel = value; }
        }
        public Label FullnameLabel
        {
            get { return fullnameLabel; }
            set { fullnameLabel = value; }
        }
        public LinkLabel СontactPersonFullnameLinkLabel
        {
            get { return contactPersonFullnameLinkLabel; }
            set { contactPersonFullnameLinkLabel = value; }
        }
        public Label ContactPersonPositionLabel
        {
            get { return contactPersonPositionLabel; }
            set { contactPersonPositionLabel = value; }
        }
        public Label СontactPersonPhoneLabel
        {
            get { return contactPersonPhoneLabel; }
            set { contactPersonPhoneLabel = value; }
        }
        #endregion

        public List<TableLayoutPanel> OneOfficeContactTableLayoutPanelList
        { get; set; } = new List<TableLayoutPanel>();

        public List<List<AddNewContactPersonForm>> GeneralContactPersonFormList
        { get; set; } = new List<List<AddNewContactPersonForm>>();

        public List<List<Panel>> GeneralPhonePanelList { get; set; } = new List<List<Panel>>();

        public int OfficeNumber { get; set; } = 0;

        public TextBox NewCompanyNameTextBox { get; set; }

        public AddNewCompanyForm(Controller controller)
		{
			_controller = controller;
            InitializeComponent();
			resetForms();
		}

        // Удаляем формы, которые добавляются по нажатию на соответствующие кнопки.
        // Добавляем свои формы.
        private void resetForms()
		{
            this.AllOfficesFlowLayoutPanel.Controls.Remove(OneOfficeContactTableLayoutPanel);
            this.AllOfficesFlowLayoutPanel.Controls.Remove(NewCompanyActionMenuPanel);

            TableLayoutPanel officesFlowLayoutPanel = oneOfficeContactTableLayoutPanelConstructor();

            this.AllOfficesFlowLayoutPanel.Controls.Add(officesFlowLayoutPanel);
            this.AllOfficesFlowLayoutPanel.Controls.Add(NewCompanyActionMenuPanel);
        }

        /// <summary>
        /// Конструкторы и методы для создания панели офиса.
        /// </summary>
        #region Constructors
        // Конструируем новую панель для нового офиса.
        private TableLayoutPanel oneOfficeContactTableLayoutPanelConstructor()
        {
            TableLayoutPanel newParentTableLayoutPanel = new TableLayoutPanel();
            int newOfficeNumber = ++OfficeNumber;

            newParentTableLayoutPanel.AutoScroll = OneOfficeContactTableLayoutPanel.AutoScroll;
            newParentTableLayoutPanel.AutoSize = OneOfficeContactTableLayoutPanel.AutoSize;
            newParentTableLayoutPanel.ColumnCount = OneOfficeContactTableLayoutPanel.ColumnCount;
            AssignColumnStyles(newParentTableLayoutPanel, OneOfficeContactTableLayoutPanel);
            AssignRowStyles(newParentTableLayoutPanel, OneOfficeContactTableLayoutPanel);

            Label newOfficeNumberLabel = officeNumberLabelConstructor(newParentTableLayoutPanel, newOfficeNumber);
            Panel newOfficeContactInfoPanel = officeContactInfoPanelConstructor(newParentTableLayoutPanel);
            FlowLayoutPanel newPhonesFlowLayoutPanel = phonesFlowLayoutPanelConstructor(newParentTableLayoutPanel);
            Panel newContactPersonPanel = contactPersonPanelConstructor(newParentTableLayoutPanel);
            TableLayoutPanel newContactPersonTableLayoutPanel = contactPersonTableLayoutPanelConstructor
                                                                    (newParentTableLayoutPanel);

            OneOfficeContactTableLayoutPanelList.Add(newParentTableLayoutPanel);
            newParentTableLayoutPanel.Controls.Add(newOfficeNumberLabel, 0, 0);
            newParentTableLayoutPanel.Controls.Add(newOfficeContactInfoPanel, 0, 1);
            newParentTableLayoutPanel.Controls.Add(newPhonesFlowLayoutPanel, 0, 3);
            newParentTableLayoutPanel.Controls.Add(newContactPersonPanel, 1, 1);
            newParentTableLayoutPanel.Controls.Add(newContactPersonTableLayoutPanel, 1, 2);

            newParentTableLayoutPanel.Location = OneOfficeContactTableLayoutPanel.Location;
            newParentTableLayoutPanel.Name = OneOfficeContactTableLayoutPanel.Name;
            newParentTableLayoutPanel.RowCount = OneOfficeContactTableLayoutPanel.RowCount;

            newParentTableLayoutPanel.Size = OneOfficeContactTableLayoutPanel.Size;
            newParentTableLayoutPanel.TabIndex = OneOfficeContactTableLayoutPanel.TabIndex;
            newParentTableLayoutPanel.GrowStyle = OneOfficeContactTableLayoutPanel.GrowStyle;

            return newParentTableLayoutPanel;
        }

        /// <summary>
        /// Конструкторы лейбла с номером офиса.
        /// </summary>
        #region NewOfficeNumberLabelConstructors
        // Конструируем новый лейбл с номером офиса. Число 1 в сумме "this.OfficeNumber + 1"
        // означает присвоение номера офису, следующего по порядку.
        private Label officeNumberLabelConstructor(TableLayoutPanel newParentTableLayoutPanel,
                                                   int newOfficeNumber)
        {
            Label newOfficeNumberLabel = new Label();

            newOfficeNumberLabel.Anchor = OfficeNumberLabel.Anchor;
            SetSpans(newOfficeNumberLabel, newParentTableLayoutPanel);
            SetFont(newOfficeNumberLabel);
            Location = newOfficeNumberLabel.Location;
            newOfficeNumberLabel.Name = OfficeNumberLabel.Name + OneOfficeContactTableLayoutPanelList.Count;
            newOfficeNumberLabel.Size = OfficeNumberLabel.Size;
            newOfficeNumberLabel.TabIndex = OfficeNumberLabel.TabIndex;
            newOfficeNumberLabel.Text = OfficeNumberLabel.Text + (newOfficeNumber);
            newOfficeNumberLabel.TextAlign = OfficeNumberLabel.TextAlign;

            return newOfficeNumberLabel;
        }

        // Задаем количество ячеек таблицы, которое может занимать лейбл с номером офиса.
        private void SetSpans(Label newOfficeNumberLabel, TableLayoutPanel newParentTableLayoutPanel)
        {
            int columnSpan = OneOfficeContactTableLayoutPanel.GetColumnSpan(OfficeNumberLabel);
            newParentTableLayoutPanel.SetColumnSpan(newOfficeNumberLabel, columnSpan);

            int rowSpan = OneOfficeContactTableLayoutPanel.GetRowSpan(OfficeNumberLabel);
            newParentTableLayoutPanel.SetRowSpan(newOfficeNumberLabel, rowSpan);
        }

        // Задаем стиль шрифта для лейбла с номером офиса.
        private void SetFont(Label officeNumberLabel)
        {
            string Name = OfficeNumberLabel.Font.FontFamily.Name;
            float emSize = OfficeNumberLabel.Font.SizeInPoints;
            FontStyle fontStyle = OfficeNumberLabel.Font.Style;
            GraphicsUnit graphicsUnit = OfficeNumberLabel.Font.Unit;
            Byte fontByte = OfficeNumberLabel.Font.GdiCharSet;
            officeNumberLabel.Font = new Font(Name, emSize, fontStyle, graphicsUnit, ((byte)(fontByte)));
        }
        #endregion

        /// <summary>
        /// Конструкторы панели с данными об офисе (страна, город, адрес и т. д.).
        /// </summary>
        #region OfficeContactInfoPanelConstructors
        // Конструируем новую панель.
        private Panel officeContactInfoPanelConstructor(TableLayoutPanel newParentTableLayoutPanel)
        {
            Panel panel = new Panel();

            panel.BorderStyle = OfficeContactInfoPanel.BorderStyle;
            panel.Location = OfficeContactInfoPanel.Location;
            panel.Name = OfficeContactInfoPanel.Name + OneOfficeContactTableLayoutPanelList.Count;
            panel.Size = OfficeContactInfoPanel.Size;
            panel.TabIndex = OfficeContactInfoPanel.TabIndex;

            Label newOfficeCountryLabel = officeLabelConstructor(OfficeCountryLabel);
            ComboBox newOfficeCountryComboBox = officeCountryComboBoxConstructor();
            Label newOfficeCityLabel = officeLabelConstructor(OfficeCityLabel);
            TextBox newOfficeCityTextBox = officeTextBoxConstructor(OfficeCityTextBox);
            Label newOfficeAddressLabel = officeLabelConstructor(OfficeAddressLabel);
            TextBox newOfficeAddressTextBox = officeTextBoxConstructor(OfficeAddressTextBox);
            Label neOfficeSiteLabel = officeLabelConstructor(OfficeSiteLabel);
            TextBox newOfficeSiteTextBox = officeTextBoxConstructor(OfficeSiteTextBox);

            panel.Controls.Add(newOfficeCountryLabel);
            panel.Controls.Add(newOfficeCountryComboBox);
            panel.Controls.Add(newOfficeCityLabel);
            panel.Controls.Add(newOfficeCityTextBox);
            panel.Controls.Add(newOfficeAddressLabel);
            panel.Controls.Add(newOfficeAddressTextBox);
            panel.Controls.Add(neOfficeSiteLabel);
            panel.Controls.Add(newOfficeSiteTextBox);

            SetSpans(panel, newParentTableLayoutPanel, OfficeContactInfoPanel);

            return panel;
        }

        // Конструируем новое поле с выбором стран.
        private ComboBox officeCountryComboBoxConstructor()
        {
            ComboBox comboBox = new ComboBox();

            comboBox.FormattingEnabled = OfficeCountryComboBox.FormattingEnabled;
            // TODO Здесь необходимо автоматизировать получение количества элементов в списке.
            comboBox.Items.AddRange(new object[] { "Россия" });
            comboBox.Location = OfficeCountryComboBox.Location;
            comboBox.Name = OfficeCountryComboBox.Name + OneOfficeContactTableLayoutPanelList.Count;
            comboBox.Size = OfficeCountryComboBox.Size;
            comboBox.TabIndex = OfficeCountryComboBox.TabIndex;

            return comboBox;
        }
        #endregion

        /// <summary>
        /// Конструкторы контейнера для панели телефонов офиса.
        /// </summary>
        #region PhonesFlowLayoutPanelConstructor
        // Конструируем контейнер для панелей.
        public FlowLayoutPanel phonesFlowLayoutPanelConstructor(TableLayoutPanel newParentTableLayoutPanel)
        {
            FlowLayoutPanel newFlowLayoutPanel = new FlowLayoutPanel();

            newFlowLayoutPanel.AutoSize = PhonesFlowLayoutPanel.AutoSize;
            newFlowLayoutPanel.AutoScroll = PhonesFlowLayoutPanel.AutoScroll;
            newFlowLayoutPanel.BorderStyle = PhonesFlowLayoutPanel.BorderStyle;
            newFlowLayoutPanel.FlowDirection = PhonesFlowLayoutPanel.FlowDirection;
            newFlowLayoutPanel.Location = PhonesFlowLayoutPanel.Location;
            newFlowLayoutPanel.Margin = PhonesFlowLayoutPanel.Margin;
            newFlowLayoutPanel.Name = PhonesFlowLayoutPanel.Name + OneOfficeContactTableLayoutPanelList.Count;
            newFlowLayoutPanel.Size = PhonesFlowLayoutPanel.Size;
            newFlowLayoutPanel.TabIndex = PhonesFlowLayoutPanel.TabIndex;
            newFlowLayoutPanel.WrapContents = PhonesFlowLayoutPanel.WrapContents;

            GeneralPhonePanelList.Add(new List<Panel>());

            Panel myPhonePanel = phonePanelConstructor(newFlowLayoutPanel);

            newFlowLayoutPanel.Controls.Add(myPhonePanel);
            SetSpans(newFlowLayoutPanel, newParentTableLayoutPanel);
            

            return newFlowLayoutPanel;
        }

        // Задаем количество ячеек таблицы, которое может занимать контейнер.
        private void SetSpans(FlowLayoutPanel newFlowLayoutPanel, TableLayoutPanel newParentTableLayoutPanel)
        {
            int columnSpan = OneOfficeContactTableLayoutPanel.GetColumnSpan(PhonesFlowLayoutPanel);
            newParentTableLayoutPanel.SetColumnSpan(newFlowLayoutPanel, columnSpan);

            int rowSpan = OneOfficeContactTableLayoutPanel.GetRowSpan(PhonesFlowLayoutPanel);
            newParentTableLayoutPanel.SetRowSpan(newFlowLayoutPanel, rowSpan);
        }

        /// <summary>
        /// Конструкторы одной панели.
        /// </summary>
        #region PhonePanelConstructors
        // Конструируем новую панель телефона офиса.
        private Panel phonePanelConstructor(FlowLayoutPanel parentFlowLayoutPanel)
        {
            Panel newPhonesPanel = new Panel();

            newPhonesPanel.BorderStyle = OnePhonePanel.BorderStyle;
            newPhonesPanel.Location = OnePhonePanel.Location;
            newPhonesPanel.Name = OnePhonePanel.Name +
               parentFlowLayoutPanel.Controls.Count;
            newPhonesPanel.Size = OnePhonePanel.Size;
            newPhonesPanel.TabIndex = OnePhonePanel.TabIndex;
            newPhonesPanel.Anchor = OnePhonePanel.Anchor;

            Label myPhoneLabel = officePhoneLabelConstructor(PhoneLabel, parentFlowLayoutPanel);
            TextBox newPhoneTextBox = officePhoneTextBoxConstructor(PhoneTextBox, parentFlowLayoutPanel);
            Button myMorePhonesButton = morePhonesButtonConstructor(parentFlowLayoutPanel);

            newPhonesPanel.Controls.Add(myMorePhonesButton);
            newPhonesPanel.Controls.Add(newPhoneTextBox);
            newPhonesPanel.Controls.Add(myPhoneLabel);

            int parentOfficeTableLayoutPanelIndex = Int32.Parse(Regex.Match(parentFlowLayoutPanel.Name, @"\d+").Value);

            GeneralPhonePanelList[parentOfficeTableLayoutPanelIndex].Add(newPhonesPanel);
            return newPhonesPanel;
        }

        // Конструируем новый лейбл телефона.
        private Label officePhoneLabelConstructor(Label originalLabel, FlowLayoutPanel parentFlowLayoutPanel)
        {
            Label newLabel = new Label();

            newLabel.AutoSize = originalLabel.AutoSize;
            newLabel.Location = originalLabel.Location;
            newLabel.Name = originalLabel.Name +
               parentFlowLayoutPanel.Controls.Count;
            newLabel.Size = originalLabel.Size;
            newLabel.TabIndex = originalLabel.TabIndex;
            newLabel.Text = originalLabel.Text;

            return newLabel;
        }

        // Конструируем новое поле для ввода телефона.
        private TextBox officePhoneTextBoxConstructor(TextBox originalBox, FlowLayoutPanel parentFlowLayoutPanel)
        {
            TextBox newTextBox = new TextBox();

            newTextBox.Location = originalBox.Location;
            newTextBox.Name = originalBox.Name +
               parentFlowLayoutPanel.Controls.Count;
            newTextBox.Size = originalBox.Size;
            newTextBox.TabIndex = originalBox.TabIndex;

            return newTextBox;
        }

        // Конструируем новую кнопку добавления телефона.
        private Button morePhonesButtonConstructor(FlowLayoutPanel parentFlowLayoutPanel)
        {
            Button newMorePhonesButton = new Button();

            newMorePhonesButton.Location = MorePhonesButton.Location;
            newMorePhonesButton.Name = MorePhonesButton.Name +
               parentFlowLayoutPanel.Controls.Count;
            newMorePhonesButton.Size = MorePhonesButton.Size;
            newMorePhonesButton.TabIndex = MorePhonesButton.TabIndex;
            newMorePhonesButton.Text = MorePhonesButton.Text;
            newMorePhonesButton.UseVisualStyleBackColor = MorePhonesButton.UseVisualStyleBackColor;

            newMorePhonesButton.Click += new EventHandler(morePhonesButton_Click);

            return newMorePhonesButton;
        }

        // При возникновении данного события (после нажатия на кнопку "Еще") создаем 
        // новую панель с телефоном офиса.
        private void morePhonesButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Panel parentPanel = (Panel)button.Parent;
            FlowLayoutPanel parentTableLayoutPanel = (FlowLayoutPanel)parentPanel.Parent;
            parentTableLayoutPanel.Controls.Add(phonePanelConstructor(parentTableLayoutPanel));
        }

        #endregion
        #endregion

        /// <summary>
        /// Конструктор контейнера для лейбла и кнопки добавления нового сотрудника.
        /// </summary>
        #region ContactPersonPanelConstructors
        // Конструируем контейнер.
        private Panel contactPersonPanelConstructor(TableLayoutPanel newParentTableLayoutPanel)
        {
            Panel newPanel = new Panel();

            newPanel.Location = ContactPersonPanel.Location;
            newPanel.Name = ContactPersonPanel.Name + OneOfficeContactTableLayoutPanelList.Count;
            newPanel.Size = ContactPersonPanel.Size;
            newPanel.TabIndex = ContactPersonPanel.TabIndex;

            Label newContactPersonsLabel = officeLabelConstructor(ContactPersonsLabel);
            Button newContactPersonsButton = contactPersonsButtonConstructor();

            newPanel.Controls.Add(newContactPersonsLabel);
            newPanel.Controls.Add(newContactPersonsButton);

            SetSpans(newPanel, newParentTableLayoutPanel, ContactPersonPanel);

            return newPanel;
        }

        // Конструируем новую кнопку добавления сотрудника.
        private Button contactPersonsButtonConstructor()
        {
            Button newButton = new Button();

            newButton.Location = ContactPersonsButton.Location;
            newButton.Name = ContactPersonsButton.Name + OneOfficeContactTableLayoutPanelList.Count;
            newButton.Size = ContactPersonsButton.Size;
            newButton.TabIndex = ContactPersonsButton.TabIndex;
            newButton.Text = ContactPersonsButton.Text;
            newButton.UseVisualStyleBackColor = ContactPersonsButton.UseVisualStyleBackColor;

            newButton.Click += new EventHandler(IsContactPersonsButtonClicked);

            return newButton;
        }

        // При возникновении данного события (после нажатия на кнопку добавления сотрудника) открываем 
        // новую форму добавления сотрудника.
        private void IsContactPersonsButtonClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Panel parentPanel = (Panel)button.Parent;
            addNewContactPerson((TableLayoutPanel)parentPanel.Parent);
        }
        #endregion

        /// <summary>
        /// Конструктор таблицы для вывода введенных данных о сотрудниках.
        /// </summary>
        #region ContactPersonTableLayoutPanelConstructors
        // Конструируем таблицу.
        private TableLayoutPanel contactPersonTableLayoutPanelConstructor(TableLayoutPanel newParentTableLayoutPanel)
        {
            TableLayoutPanel newTableLayoutPanel = new TableLayoutPanel();

            newTableLayoutPanel.MinimumSize = new Size(ContactPersonTableLayoutPanel.MinimumSize.Width,
                                                    ContactPersonTableLayoutPanel.MinimumSize.Height);
            newTableLayoutPanel.AutoSize = ContactPersonTableLayoutPanel.AutoSize;
            newTableLayoutPanel.CellBorderStyle = ContactPersonTableLayoutPanel.CellBorderStyle;
            newTableLayoutPanel.ColumnCount = ContactPersonTableLayoutPanel.ColumnCount;
            newTableLayoutPanel.Location = ContactPersonTableLayoutPanel.Location;
            newTableLayoutPanel.Name = ContactPersonTableLayoutPanel.Name +
                                       OneOfficeContactTableLayoutPanelList.Count;
            newTableLayoutPanel.RowCount = ContactPersonTableLayoutPanel.RowCount;
            newTableLayoutPanel.Size = ContactPersonTableLayoutPanel.Size;
            newTableLayoutPanel.TabIndex = ContactPersonTableLayoutPanel.TabIndex;

            AssignColumnStyles(newTableLayoutPanel, ContactPersonTableLayoutPanel);
            AssignRowStyles(newTableLayoutPanel, ContactPersonTableLayoutPanel);

            Label newFullnameLabel = contactPersonTableLabelConstructor(FullnameLabel);
            Label newPositionLabelLabel = contactPersonTableLabelConstructor(ContactPersonPositionLabel);
            Label newPhoneLabel = contactPersonTableLabelConstructor(СontactPersonPhoneLabel);

            newTableLayoutPanel.Controls.Add(newFullnameLabel, 0, 0);
            newTableLayoutPanel.Controls.Add(newPositionLabelLabel, 1, 0);
            newTableLayoutPanel.Controls.Add(newPhoneLabel, 2, 0);

            SetSpans(newTableLayoutPanel, newParentTableLayoutPanel);
            GeneralContactPersonFormList.Add(new List<AddNewContactPersonForm>());

            return newTableLayoutPanel;
        }

        // Задаем количество ячеек таблицы, которые может занимать таблица с сотрудниками в родительской таблице.
        private void SetSpans(TableLayoutPanel newTableLayoutPanel,
                              TableLayoutPanel newParentTableLayoutPanel)
        {
            int columnSpan = OneOfficeContactTableLayoutPanel.GetColumnSpan(ContactPersonTableLayoutPanel);
            newParentTableLayoutPanel.SetColumnSpan(newTableLayoutPanel, columnSpan);

            int rowSpan = OneOfficeContactTableLayoutPanel.GetRowSpan(ContactPersonTableLayoutPanel);
            newParentTableLayoutPanel.SetRowSpan(newTableLayoutPanel, rowSpan);
        }

        // Конструируем лейбл для заголовка таблицы "ФИО". Данный конструктор подходит для все лейблов в
        // шапке таблицы.
        private Label contactPersonTableLabelConstructor(Label originalLabel)
        {
            Label newLabel = new Label();

            newLabel.MaximumSize = originalLabel.MaximumSize;
            newLabel.Anchor = originalLabel.Anchor;
            newLabel.AutoSize = originalLabel.AutoSize;
            newLabel.Location = originalLabel.Location;
            newLabel.Name = originalLabel.Name;
            newLabel.Size = originalLabel.Size;
            newLabel.TabIndex = originalLabel.TabIndex;
            newLabel.Text = originalLabel.Text;
            newLabel.TextAlign = originalLabel.TextAlign;

            return newLabel;
        }

        // Конструируем лейбл для должности и телефона нового сотрудника. Описание индексов
        // parentOfficeTableLayoutPanel и contactPersonFormIndex аналогично описанию из
        // конструктора contactPersonFullnameLinkLabelConctructor. 
        private Label contactPersonTableLabelConstructor(Label originalLabel,
                                                         AddNewContactPersonForm contactPersonForm,
                                                         int parentOfficeTableLayoutPanel)
        {
            Label newLabel = new Label();

            int contactPersonFormIndex = GeneralContactPersonFormList[parentOfficeTableLayoutPanel]
                                        .IndexOf(contactPersonForm);

            newLabel.MaximumSize = originalLabel.MaximumSize;
            newLabel.Anchor = originalLabel.Anchor;
            newLabel.AutoSize = originalLabel.AutoSize;
            newLabel.Location = originalLabel.Location;
            newLabel.Name = originalLabel.Name + contactPersonFormIndex;
            newLabel.Size = originalLabel.Size;
            newLabel.TabIndex = originalLabel.TabIndex;
            newLabel.TextAlign = originalLabel.TextAlign;

            return newLabel;
        }

        // Конструируем лейбл-ссылку для ФИО вновь добавленного сотрудника. В данном методе мы 
        // сначала определяем порядковый номер панели офиса в списке панелей офисов, на которой 
        // создается лейбл-ссылка с ФИО. Порядковый номер данной панели совпадает с порядковым 
        // номером таблицы, которой принадлежит создаваемая ссылка, и с порядковым номером списка 
        // форм нового сотрудника (в котором находится форма, соответствующая создаваемой ссылке) 
        // в общем списке  форм новых сотрудников. Далее мы определяем добавочный номер для имени
        // создаваемой ссылки.
        private LinkLabel contactPersonFullnameLinkLabelConctructor(AddNewContactPersonForm contactPersonForm,
                                                                    int parentOfficeTableLayoutPanelIndex)
        {
            LinkLabel newLinkLabel = new LinkLabel();

            int contactPersonFormIndex = GeneralContactPersonFormList[parentOfficeTableLayoutPanelIndex]
                                        .IndexOf(contactPersonForm);

            newLinkLabel.MaximumSize = СontactPersonFullnameLinkLabel.MaximumSize;
            newLinkLabel.Anchor = СontactPersonFullnameLinkLabel.Anchor;
            newLinkLabel.AutoSize = СontactPersonFullnameLinkLabel.AutoSize;
            newLinkLabel.Location = СontactPersonFullnameLinkLabel.Location;
            newLinkLabel.Name = СontactPersonFullnameLinkLabel.Name + contactPersonFormIndex;
            newLinkLabel.Size = СontactPersonFullnameLinkLabel.Size;
            newLinkLabel.TabIndex = СontactPersonFullnameLinkLabel.TabIndex;
            newLinkLabel.TabStop = СontactPersonFullnameLinkLabel.TabStop;
            newLinkLabel.TextAlign = СontactPersonFullnameLinkLabel.TextAlign;
            newLinkLabel.Click += new EventHandler(IsPersonFullnameLinkLabelClicked);

            return newLinkLabel;
        }

        private void IsPersonFullnameLinkLabelClicked(object sender, EventArgs e)
        {
            LinkLabel childLinkLabel = (LinkLabel)sender;

            reopenContactPersonForm((TableLayoutPanel)childLinkLabel.Parent, childLinkLabel);
        }

        #endregion

        /// <summary>
        /// Методы и конструкторы, которые вызываются из нескольких методов или конструкторов.
        /// </summary>
        #region GenericConstructorsAndMethods
        // Конструируем новый лейбл. Данный конструктор подходит для лейблов: "страна", "город", "адрес", "сайт",
        // "телефон" (офиса).
        private Label officeLabelConstructor(Label originalLabel)
        {
            Label newLabel = new Label();

            newLabel.AutoSize = originalLabel.AutoSize;
            newLabel.Location = originalLabel.Location;
            newLabel.Name = originalLabel.Name + OneOfficeContactTableLayoutPanelList.Count;
            newLabel.Size = originalLabel.Size;
            newLabel.TabIndex = originalLabel.TabIndex;
            newLabel.Text = originalLabel.Text;

            return newLabel;
        }

        // Конструируем новое текстовое поле. Данный конструктор подходит для полей: "город", "адрес", "сайт",
        // "телефон" (офиса).
        private TextBox officeTextBoxConstructor(TextBox originalBox)
        {
            TextBox newTextBox = new TextBox();

            newTextBox.Location = originalBox.Location;
            newTextBox.Name = originalBox.Name + OneOfficeContactTableLayoutPanelList.Count;
            newTextBox.Size = originalBox.Size;
            newTextBox.TabIndex = originalBox.TabIndex;

            return newTextBox;
        }

        // Задаем количество ячеек таблицы, которые может занимать панель. Данный метод подходит для панелей:
        // "contactPersonPanelConstructor" и "officeContactInfoPanel".
        private void SetSpans(Panel panel, TableLayoutPanel newParentTableLayoutPanel, Panel originalPanel)
        {
            int columnSpan = OneOfficeContactTableLayoutPanel.GetColumnSpan(originalPanel);
            newParentTableLayoutPanel.SetColumnSpan(panel, columnSpan);

            int rowSpan = OneOfficeContactTableLayoutPanel.GetRowSpan(originalPanel);
            newParentTableLayoutPanel.SetRowSpan(panel, rowSpan);
        }


        // Назначаем стиль колонок и рядов таблицы. Данный метод подходит для таблицы "oneOfficeContactTableLayoutPanel"
        // и "contactPersonTableLayoutPanel".
        private void AssignColumnStyles(TableLayoutPanel panel, TableLayoutPanel originalPanel)
        {
            for (int i = 0; i < originalPanel.ColumnStyles.Count; i++)
            {
                panel.ColumnStyles.Add(new ColumnStyle(originalPanel.ColumnStyles[i].SizeType,
                                                       originalPanel.ColumnStyles[i].Width));
            }
        }
        private void AssignRowStyles(TableLayoutPanel panel, TableLayoutPanel originalPanel)
        {
            for (int i = 0; i < originalPanel.RowStyles.Count; i++)
            {
                panel.RowStyles.Add(new RowStyle(originalPanel.RowStyles[i].SizeType,
                                                 originalPanel.RowStyles[i].Height));
            }
        }
        #endregion

        #endregion

        // Добавляем новую форму для очередного офиса на данную панель.
        // TODO When a new office panel is being added, the window changes is position.
        // We need to fix it.
        private void addOfficeButton_Click(object sender, EventArgs e)
        {
            AllOfficesFlowLayoutPanel.Controls.Remove(NewCompanyActionMenuPanel);

            TableLayoutPanel newTableLayoutPanel = oneOfficeContactTableLayoutPanelConstructor();

            AllOfficesFlowLayoutPanel.Controls.Add(newTableLayoutPanel);
            AllOfficesFlowLayoutPanel.Controls.Add(NewCompanyActionMenuPanel);
            this.StartPosition = FormStartPosition.Manual;
        }

        // Открываем окно с формой ввода данных для нового сотрудника.
        private void addNewContactPerson(TableLayoutPanel parentOfficePanel)
        {
            _controller.ShowAddNewContactPersonDialog(parentOfficePanel);
        }

        // Отображаем введенные данные по сотруднику на данной панели. Сначала мы определяем
        // порядковый номер таблицы сотрудников в списке контролей панели офисов 
        // "OneOfficeContactTableLayoutPanel", которая, в свою очередь, определяется по номеру 
        // офиса "officeNumber", совпадающему с порядковым номером данной панели офисов.
        // Затем по порядковому номеру таблицы находим таблицу, в список контролей которой,
        // будет добавлять контроли с ФИО, должностью и телефоном, которые создаем через 
        // конструкторы. 
        public void AddAndDisplayNewContactPerson(AddNewContactPersonForm form, int officeNumber)
        {
            GeneralContactPersonFormList[officeNumber].Add(form);

            int contactPersonTableLayoutPanelIndex = OneOfficeContactTableLayoutPanelList[officeNumber]
                                                    .Controls
                                                    .IndexOfKey(ContactPersonTableLayoutPanel.Name + officeNumber);

            TableLayoutPanel originContactPersonTableLayoutPanel = 
                (TableLayoutPanel)OneOfficeContactTableLayoutPanelList[officeNumber]
                .Controls[contactPersonTableLayoutPanelIndex];

            LinkLabel contactPersonFullnameLinkLabel =
                contactPersonFullnameLinkLabelConctructor(form, officeNumber);

            contactPersonFullnameLinkLabel.Text = form.NameContactPerson;

            Label contactPersonPositionLabel = contactPersonTableLabelConstructor(ContactPersonPositionLabel, 
                                                                                  form, officeNumber);
            contactPersonPositionLabel.Text = form.PositionContactPersonTextBox.Text;

            Label contactPersonPhoneLabel = contactPersonTableLabelConstructor(СontactPersonPhoneLabel,
                                                                               form, officeNumber);
            // TODO Здесь нужно определить, какой номер телефона выводить в таблицу.
            contactPersonPhoneLabel.Text = form.MyContactPersonPhoneFormList[0].NewPhoneNumber;

            originContactPersonTableLayoutPanel.Controls.Add(contactPersonFullnameLinkLabel);
            originContactPersonTableLayoutPanel.Controls.Add(contactPersonPositionLabel);
            originContactPersonTableLayoutPanel.Controls.Add(contactPersonPhoneLabel);
        }

        // TODO Попробовать переделать данный метод с использованием GetNextControl метод.
        // Отображаем введенные ФИО, должность и телефон из повторно открытой формы для добавления
        // нового сотрудника с учетом внесенных изменений после ее очередного закрытия.
        // В данном методы мы сначала определяем порядковый номер таблицы сотрудников (contactTableLayoutPanelIndex),
        // в которой расположен лейбл-ссылка, соответствующая передаваемой форме (contactPersonForm).
        // Затем определяем порядковый номер передаваемой формы в подсписке списка форм сотрудников 
        // (GeneralContactPersonFormList), при чем номер необходимого подсписка соответствует номеру
        // офиса в списке офисов (OneOfficeContactTableLayoutPanelList). Далее мы определяем порядковый
        // номер лейбл-ссылки (relevantContactPersonFullnameLinkLabelIndex) в списке контролей таблицы
        // сотрудников (ContactTableLayoutPanel), передаем лейбл-ссылку во временную переменную и
        // передаем соответствующие данные из передаваемой формы. Аналогично поступаем с остальными
        // лейблами (должность, телефон). 
        public void RedisplayReopenedContactPersonForm(AddNewContactPersonForm contactPersonForm,
                                                       int officeNumber)
        {
            int contactTableLayoutPanelIndex = OneOfficeContactTableLayoutPanelList[officeNumber]
                                              .Controls
                                              .IndexOfKey(ContactPersonTableLayoutPanel.Name + officeNumber);

            TableLayoutPanel relevantContactTableLayoutPanel =
                (TableLayoutPanel)OneOfficeContactTableLayoutPanelList[officeNumber]
                                 .Controls[contactTableLayoutPanelIndex];

            int contactPersonFormIndex = GeneralContactPersonFormList[officeNumber]
                                        .IndexOf(contactPersonForm);

            int relevantContactPersonFullnameLinkLabelIndex = relevantContactTableLayoutPanel
                .Controls.IndexOfKey(СontactPersonFullnameLinkLabel.Name + contactPersonFormIndex);

            LinkLabel relevantContactPersonFullnameLinkLabel = (LinkLabel)relevantContactTableLayoutPanel
               .Controls[relevantContactPersonFullnameLinkLabelIndex];

            relevantContactPersonFullnameLinkLabel.Text = contactPersonForm.NameContactPerson;

            int relevantContactPersonPositionLabelIndex = relevantContactTableLayoutPanel
               .Controls.IndexOfKey(ContactPersonPositionLabel.Name + contactPersonFormIndex);

            Label relevantContactPersonPositionLabel = (Label)relevantContactTableLayoutPanel.
                Controls[relevantContactPersonPositionLabelIndex];

            relevantContactPersonPositionLabel.Text = contactPersonForm.PositionContactPersonTextBox.Text;

            int releventСontactPersonPhoneLabelIndex = relevantContactTableLayoutPanel
                .Controls.IndexOfKey(СontactPersonPhoneLabel.Name + contactPersonFormIndex);

            Label releventСontactPersonPhoneLabel = (Label)relevantContactTableLayoutPanel
                .Controls[releventСontactPersonPhoneLabelIndex];
            // TODO Здесь нужно определить, какой номер телефона выводить в таблицу.
            releventСontactPersonPhoneLabel.Text = contactPersonForm.MyContactPersonPhoneFormList[0].NewPhoneNumber;
        }

        // Повторно открываем закрытую форму добавления нового сотрудника при нажатии на
        // LinkLabel с ФИО конкретного сотрудника. В данном методе мы сначала определяем
        // порядковый номер панели офиса (parentOfficeTableLayoutPanel) в списке панелей офисов, 
        // на которой была кликнута ссылка с ФИО.
        // Порядковый номер данной панели совпадает с порядковым номером подсписка форм нового 
        // сотрудника (в котором находится форма, соответствующая кликнутой ссылке) в общем списке 
        // форм новых сотрудников. Далее из имени кликнутой ссылки в списке контролей
        // таблицы, которой принадлежит данная ссылка, извлекаем присвоенные ее в конструкторе
        // номер. Данный номер совпадает с порядковым номером соответствующей кликнутой ссылке
        // форме в подсписке форм (в котором находится данная форма, которую нам нужно открыть).
        private void reopenContactPersonForm(TableLayoutPanel parentTableLayoutPanel,
                                             LinkLabel childLinkLabel)
        {
            int parentOfficeTableLayoutPanel = OneOfficeContactTableLayoutPanelList
                                              .IndexOf((TableLayoutPanel)parentTableLayoutPanel.Parent);

            int contactPersonFormIndex = Int32.Parse(Regex.Match(childLinkLabel.Name, "\\d+").Value);


            GeneralContactPersonFormList[parentOfficeTableLayoutPanel][contactPersonFormIndex].StartPosition =
                                                                        FormStartPosition.Manual;
            GeneralContactPersonFormList[parentOfficeTableLayoutPanel][contactPersonFormIndex].Show();
        }

        // Сохраняем введенные данные о компании.
        private void addClientDataButton_Click(object sender, EventArgs e)
        {
            NewCompanyNameTextBox = companyNameTextBox;
            _controller.SaveNewCompanyData();
            this.Dispose();
        }
    }
}
