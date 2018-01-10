using CRM_GTMK.Control;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CRM_GTMK.Visual
{
    public partial class AddNewContactPersonForm : Form
    {
        private Controller _controller;
        private AddNewCompanyForm _form;

        #region Getters
        public Label DateLabel
        {
            get { return dateLabel; }
            set { dateLabel = value; }
        }
        public RichTextBox CommentRichTextBox
        {
            get { return commentRichTextBox; }
            set { commentRichTextBox = value; }
        }
        #endregion

        public int OfficeNumber { get; set; }
        public List<AddNewContactPersonPhoneForm> MyContactPersonPhoneFormList
        { get; set; } = new List<AddNewContactPersonPhoneForm>();
        public List<Panel> MyPhonePanelList { get; set; } = new List<Panel>();
        public List<Panel> MyCommentPanelList { get; set; } = new List<Panel>();

        public string NameContactPerson { get; set; }
        public string LastnameContactPerson { get; set; }
        public string FirstnameContactPerson { get; set; }
        public string MiddleNameContactPerson { get; set; }
        public string PositionContactPerson { get; set; }
        public string[] EmailContactPerson { get; set; } = new string[] { "", "", "" };

        public AddNewContactPersonForm(Controller controller, int officeNumber, AddNewCompanyForm form)
        {
            _controller = controller;
            _form = form;
            OfficeNumber = officeNumber;
            InitializeComponent();
            resetForms();
        }

        // Удаляем формы, которые добавляются по нажатию на соответствующие кнопки.
        // Задаем параметр для ComboBox с эл. почтой.
        private void resetForms()
        {
            phonesContactPersonFlowLayoutPanel.Controls.Remove(phoneContactPersonPanel);
            commentsInnerFlowLayoutPanel.Controls.Remove(commentPanel);
            emailContactPersonComboBox.SelectedIndex = 0;
            makeFormCollapse();
        }

        // Сжимаем окно добавления нового сотрудника при первом открытии, когда еще не добавлены
        // комментарии и телефоны. Size(360, 31) это новые размеры панели 
        // phonesContactPersonFlowLayoutPanel. Size(420, 376) это новые размеры окна добавления
        // сотрудника. Point(283, 9) это новые координаты расположения кнопки "Добавить комментарий". 
        // Point(165, 286) это новые координаты расположения кнопки "Добавить телефон".
        private void makeFormCollapse()
        {
            phonesContactPersonFlowLayoutPanel.Size = new Size(360, 31);
            phonesContactPersonFlowLayoutPanel.Hide();
            commentsInnerFlowLayoutPanel.Hide();
            commentsContactPersonFlowLayoutPanel.Hide();
            this.Size = new Size(420, 376);
            addNewCommentContactPersonButton.Location = new Point(283, 9);
            saveNewContactPersonButton.Location = new Point(165, 286);
        }

        // Кнопка добавления нового комментария.
        private void addNewCommentContactPersonButton_Click(object sender, EventArgs e)
        {
            makeFormExpandForComments();

            Panel newCommentPanel = commentPanelConstructor();

            MyCommentPanelList.Add(newCommentPanel);
            commentsInnerFlowLayoutPanel.Controls.Add(newCommentPanel);
        }

        /// <summary>
        /// Конструкторы для создания новой панели с лейблом и полем для ввода для комментария 
        /// по сотруднику.
        /// </summary>
        #region CommentPanelConstructor
        // Конструируем новый лейбл для комментария по сотруднику.
        private Label dateLabelConstructor()
        {
            Label label = new Label();

            label.AutoSize = dateLabel.AutoSize;
            label.Location = dateLabel.Location;
            label.Name = dateLabel.Name + MyCommentPanelList.Count;
            label.Size = dateLabel.Size;
            label.TabIndex = dateLabel.TabIndex;
            DateTime currentTime = DateTime.Now;
            CultureInfo russianCulture = new CultureInfo("ru-Ru");
            label.Text = currentTime.ToString("g", russianCulture) + "\r\nДобавил Вася";

            return label;
        }

        // Конструируем новое поле для ввода комментария по сотруднику.
        private RichTextBox commentRichTextBoxConstructor()
        {
            RichTextBox richTextBox = new RichTextBox();

            richTextBox.Location = commentRichTextBox.Location;
            richTextBox.Name = commentRichTextBox.Name + MyCommentPanelList.Count;
            richTextBox.Size = commentRichTextBox.Size;
            richTextBox.TabIndex = commentRichTextBox.TabIndex;
            richTextBox.Text = commentRichTextBox.Text;

            return richTextBox;
        }

        // Конструируем новую панель для комментария по сотруднику.
        private Panel commentPanelConstructor()
        {
            Panel panel = new Panel();

            panel.Anchor = commentPanel.Anchor;
            panel.Controls.Add(dateLabelConstructor());
            panel.Controls.Add(commentRichTextBoxConstructor());
            panel.Name = commentPanel.Name + MyContactPersonPhoneFormList.Count;
            panel.Size = commentPanel.Size;
            panel.TabIndex = commentPanel.TabIndex;

            return panel;
        }
        #endregion

        // Увеличиваем размер окна при добавлении нового комментария. Size(806, 515) это новые
        // размеры окна. Point(554, 9) это новые координаты расположения кнопки "Добавить 
        // комментарий". Point(356, 425) это новые координаты расположения кнопки "Добавить
        // телефон". 172 это высота панели phonesContactPersonFlowLayoutPanel, выбранная при
        // при дизайне формы AddNewContactPersonForm.
        private void makeFormExpandForComments()
        {
            if (commentsContactPersonFlowLayoutPanel.Visible == true)
                return;

            this.Size = new Size(806, 515);
            commentsInnerFlowLayoutPanel.Show();
            commentsContactPersonFlowLayoutPanel.Show();
            addNewCommentContactPersonButton.Location = new Point(554, 9);
            saveNewContactPersonButton.Location = new Point(356, 425);
            phonesContactPersonFlowLayoutPanel.Height = 172;
        }

        // Увеличиваем размер окна при добавлении нового телефона. 
        public void MakeFormExpandForPhones()
        {
            if (commentsContactPersonFlowLayoutPanel.Visible == true)
                phonesContactPersonFlowLayoutPanel.Show();
            else
            {
                phonesContactPersonFlowLayoutPanel.Show();
            }
        }

        // Кнопка добавления нового телефона сотрудника.
        private void addNewContactPersonPhoneButton_Click(object sender, EventArgs e)
        {
            _controller.ShowAddNewContactPersonPhoneForm(this);

            if (commentsContactPersonFlowLayoutPanel.Visible == true)
                return;
            else
            {
                if (phonesContactPersonFlowLayoutPanel.Height +
                    phoneContactPersonPanel.Height <= 172)
                {
                    this.Height += phoneContactPersonPanel.Height;
                    phonesContactPersonFlowLayoutPanel.Height += phoneContactPersonPanel.Height;
                }
            }
        }

        // Отображаем введенный телефон и комментарий на данной панели.
        public void AddAndDisplayNewContactPersonPhone(AddNewContactPersonPhoneForm form)
        {
            Panel newPhoneContactPersonPanel = phoneContactPersonPanelConstructor(form);

            phonesContactPersonFlowLayoutPanel.Controls.Add(newPhoneContactPersonPanel);
            MyPhonePanelList.Add(newPhoneContactPersonPanel);
        }

        /// <summary>
        /// Конструкторы для создания новой панели с отображением введенных данных о телефоне:
        /// тип, номер, комментарий.
        /// </summary>
        #region PhonePanelConstructors
        // Конструируем новый лейбл для типа телефона.
        private Label phoneTypeLabelConstructor(AddNewContactPersonPhoneForm form)
        {
            Label label = new Label();

            label.AutoSize = phoneTypeLabel.AutoSize;
            label.Location = phoneTypeLabel.Location;
            label.Name = phoneTypeLabel.Name + MyContactPersonPhoneFormList.IndexOf(form);
            label.Size = phoneTypeLabel.Size;
            label.TabIndex = phoneTypeLabel.TabIndex;
            label.Text = form.NewPhoneType;

            return label;
        }

        // Конструируем новый лейбл со ссылкой для номера телефона.
        private LinkLabel phoneNumberLinkLabelConstructor(AddNewContactPersonPhoneForm form)
        {
            LinkLabel linkLabel = new LinkLabel();

            linkLabel.AutoSize = phoneNumberLinkLabel.AutoSize;
            linkLabel.Location = phoneNumberLinkLabel.Location;
            linkLabel.Name = phoneNumberLinkLabel.Name + 
                             MyContactPersonPhoneFormList.IndexOf(form);
            linkLabel.Size = phoneNumberLinkLabel.Size;
            linkLabel.TabIndex = phoneNumberLinkLabel.TabIndex;
            linkLabel.TabStop = phoneNumberLinkLabel.TabStop;
            linkLabel.Text = form.NewPhoneNumber;
            linkLabel.Click += new EventHandler(phoneNumberLinkLabel_Click);

            return linkLabel;
        }

        // Конструируем новое поле для комментария телефона.
        private TextBox phoneCommentTextBoxConstructor(AddNewContactPersonPhoneForm form)
        {
            TextBox textBox = new TextBox();

            textBox.Cursor = phoneCommentTextBox.Cursor;
            textBox.Location = phoneCommentTextBox.Location;
            textBox.Name = phoneCommentTextBox.Name + MyContactPersonPhoneFormList.IndexOf(form);
            textBox.ReadOnly = phoneCommentTextBox.ReadOnly;
            textBox.Size = phoneCommentTextBox.Size;
            textBox.TabIndex = phoneCommentTextBox.TabIndex;
            textBox.MouseHover += new EventHandler(phoneCommentTextBox_MouseHover);
            textBox.Text = form.NewPhoneComment;

            return textBox;
        }

        // Конструируем новую панель для отображения номера телефона.
        private Panel phoneContactPersonPanelConstructor(AddNewContactPersonPhoneForm form)
        {
            Panel panel = new Panel();

            panel.AutoSize = phoneContactPersonPanel.AutoSize;
            panel.Controls.Add(phoneTypeLabelConstructor(form));
            panel.Controls.Add(phoneNumberLinkLabelConstructor(form));
            panel.Controls.Add(phoneCommentTextBoxConstructor(form));
            panel.Name = phoneContactPersonPanel.Name + MyContactPersonPhoneFormList.Count;
            panel.Size = phoneContactPersonPanel.Size;
            panel.TabIndex = phoneContactPersonPanel.TabIndex;

            return panel;
        }

        #endregion

        // Отображаем введенный телефон и комментарий повторно открытой формы для ввода телефона
        // с учетом внесенных изменений.
        public void RedisplayReopenedContactPersonPhonePanel(AddNewContactPersonPhoneForm form)
        {
            int index = MyContactPersonPhoneFormList.IndexOf(form);

            int phoneTypeLabelIndex = MyPhonePanelList[index].Controls.IndexOfKey(phoneTypeLabel.Name + index);
            MyPhonePanelList[index].Controls[phoneTypeLabelIndex].Text = form.NewPhoneType;
            int phoneNumberLinkLabelIndex = MyPhonePanelList[index].Controls.IndexOfKey(phoneNumberLinkLabel.Name + index);
            MyPhonePanelList[index].Controls[phoneNumberLinkLabelIndex].Text = form.NewPhoneNumber;
            int phoneCommentTextBoxIndex = MyPhonePanelList[index].Controls.IndexOfKey(phoneCommentTextBox.Name + index);
            MyPhonePanelList[index].Controls[phoneCommentTextBoxIndex].Text = form.NewPhoneComment;
        }

        // Сохраняем введенные данные по нажатию на кнопку "Сохранить и закрыть".
        private void saveNewContactPersonButton_Click(object sender, EventArgs e)
        {
            // TODO Проверить условие NameContactPerson != null. Иногда происходит не верное
            // сравнение.
            if (NameContactPerson != null)
            {
                if (assignContactPersonComponents(sender, e))
                    return;
                _form.RedisplayReopenedContactPersonForm(this);
            }
            else
            {
                if (assignContactPersonComponents(sender, e))
                    return;
                _controller.AddAndDisplayNewContactPerson(this, OfficeNumber);
            }
            this.Hide();
        }

        /// <summary>
        /// Методы, передающие введенные данные в переменные и проверяющие правильность 
        /// введенной информации.
        /// </summary>
        #region Checkers

        // Передаем данные из полей для ввода в соответствующие переменные.
        private bool assignContactPersonComponents(object sender, EventArgs e)
        {
            emailContactPersonComboBox_DropDown(sender, e);

            setContactPersonNameParts();

            if (checkIfInputValid())
                return true;

            NameContactPerson = lastnameContactPersonTextBox  .Text + " " +
                                firstnameContactPersonTextBox .Text + " " +
                                middleNameContactPersonTextBox.Text;
            PositionContactPerson = positionContactPersonTextBox.Text;
            return false;
        }

        // Передаем введенное ФИО в соответствующие переменные.
        private void setContactPersonNameParts()
        {
            LastnameContactPerson = lastnameContactPersonTextBox.Text;
            FirstnameContactPerson = firstnameContactPersonTextBox.Text;
            MiddleNameContactPerson = middleNameContactPersonTextBox.Text;
        }

        // Общий метод проверки правильности ввода.
        private bool checkIfInputValid()
        {
            if (checkNameAndPosiotionInputWithoutDigits())
                return true;
            if (checkNameAndPosiotionInputWasMade())
                return true;
            if (checkEmailInput())
                return true;
            if (checkPhoneInput())
                return true;

            return false;
        }

        // Проверка наличия ввода в поля "Фамилия", "Имя" и "Должность".
        private bool checkNameAndPosiotionInputWasMade()
        {
            if (lastnameContactPersonTextBox.Text == "" ||
                firstnameContactPersonTextBox.Text == "" ||
                positionContactPersonTextBox.Text == "")
            {
                MessageBox.Show("Необходимо заполнить поля \"Фамилия\", \"Имя\" и \"Должность\".");
                return true;
            }
            return false;
        }

        // Проверка отсутствия цифр в полях "Фамилия", "Имя", "Отчество"
        //и "Должность".
        private bool checkNameAndPosiotionInputWithoutDigits()
        {
            if (lastnameContactPersonTextBox.Text.Any(char.IsDigit) ||
                firstnameContactPersonTextBox.Text.Any(char.IsDigit) ||
                middleNameContactPersonTextBox.Text.Any(char.IsDigit) ||
                positionContactPersonTextBox.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Поля \"Фамилия\", \"Имя\", \"Отчество\" " +
                                "и \"Должность\" не должны содержать цифр.");
                return true;
            }
            return false;
        }

        // Проверка ввода эл. почты.
        private bool checkEmailInput()
        {
            if (EmailContactPerson.All(email => email == ""))//Need to change it to match all the cases
            {
                MessageBox.Show("Необходимо ввести хотя бы один адрес эл. почты.");
                return true;
            }
            foreach (string email in EmailContactPerson)
            {
                if (email == "")
                    continue;
                else if (!email.Contains("@"))
                {
                    MessageBox.Show("Адрес эл. почты обязательно должен содержать символ \"@\".");
                    return true;
                }
            }
            return false;
        }

        // Проверка наличия введенного телефона (не менее одного).
        private bool checkPhoneInput()
        {
            if (MyContactPersonPhoneFormList.Count == 0)
            {
                MessageBox.Show("Необходимо ввести хотя бы один номер телефона.");
                return true;
            }
            return false;
        }
        #endregion

        // Вывод значения эл. почты из соответствующей позиции множества при закрытии ComboBox.
        private void emailContactPersonComboBox_DropDownClosed(object sender, EventArgs e)
        {
            int chosenItem = emailContactPersonComboBox
                            .Items.IndexOf(emailContactPersonComboBox.SelectedItem);

            switch (chosenItem)
            {
                case 0:
                    emailContactPersonTextBox.Text = EmailContactPerson[0];
                    break;
                case 1:
                    emailContactPersonTextBox.Text = EmailContactPerson[1];
                    break;
                default:
                    emailContactPersonTextBox.Text = EmailContactPerson[2];
                    break;
            }
        }

        // Записываем введенную эл. почту в соответствующую позицию множества при открытии ComboBox.
        private void emailContactPersonComboBox_DropDown(object sender, EventArgs e)
        {
            int chosenItem = emailContactPersonComboBox
                .Items.IndexOf(emailContactPersonComboBox.SelectedItem);

            switch (chosenItem)
            {
                case 0:
                    EmailContactPerson[0] = emailContactPersonTextBox.Text;
                    break;
                case 1:
                    EmailContactPerson[1] = emailContactPersonTextBox.Text;
                    break;
                default:
                    EmailContactPerson[2] = emailContactPersonTextBox.Text;
                    break;
            }
        }

        // Повторно открываем закрытую форму ввода телефона по нажатию на LinkLabel.
        private void phoneNumberLinkLabel_Click(object sender, EventArgs e)
        {
            LinkLabel linkLabel = (LinkLabel)sender;

            int contactPersonPhoneFormIndex = phonesContactPersonFlowLayoutPanel
                                             .Controls.IndexOf(linkLabel.Parent);

            MyContactPersonPhoneFormList[contactPersonPhoneFormIndex].StartPosition = FormStartPosition.Manual;
            MyContactPersonPhoneFormList[contactPersonPhoneFormIndex].Show();
        }

        // При закрытии окна по нажатию на красный крестик выбираем,
        // что нужно сделать с формой: удалить или скрыть.
        private void AddNewContactPersonForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (NameContactPerson == null)
                this.Dispose();
            else
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        // Выводим всплывающее окно при наведении мыши на текстовое поля комментария телефона.
        // TODO Исправить баг в данном методе: при повторном открытии формы ввода телефона 
        // по нажатии на поле с ссылкой (LinkLabel), внесении изменений в комментарий и
        // сохранении и затем наведении курсора мыши на поле с комментарием ToolTip показывает 
        // старые данные и затем новые. Нужно понять, где берутся старые данные.
        private void phoneCommentTextBox_MouseHover(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            ToolTip toolTip = new ToolTip();
            Regex rgx = new Regex("(.{10}\\s)");
            string WrappedMessage = rgx.Replace(textBox.Text, "$1\n");

            toolTip.ShowAlways = true;
            toolTip.InitialDelay = 0;
            
            toolTip.SetToolTip(textBox, WrappedMessage);
        }
    }
}
