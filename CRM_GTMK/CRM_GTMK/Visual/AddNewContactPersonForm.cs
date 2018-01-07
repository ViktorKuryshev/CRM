using CRM_GTMK.Control;
using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.ContactPersonPanel.CommentsContactPersonFlowLayoutPanel.CommentsInnerFlowLayoutPanel.OneCommentPanel;
using CRM_GTMK.Visual.AddCompanyPanels.OfficesPanel.ContactPersonPanel.PhonesContactPersonFlowLayoutPanel.OneContactPersonPhonePanel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CRM_GTMK.Visual
{
    public partial class AddNewContactPersonForm : Form
    {
        private Controller _controller;
        private AddNewCompanyForm _form;
        private MyContactPersonPhonePanel _reopenedContactPersonPhonePanel;

        public int OfficeNumber { get; set; }
        public List<AddNewContactPersonPhoneForm> MyContactPersonPhoneFormList
        { get; set; } = new List<AddNewContactPersonPhoneForm>();
        public List<MyCommentPanel> MyCommentPanelList { get; set; } = new List<MyCommentPanel>();

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
            return phoneContactPersonPanel;
        }

        public TextBox GetPhoneCommentTextBox()
        {
            return phoneCommentTextBox;
        }

        public LinkLabel GetPhoneNumberLinkLabel()
        {
            return phoneNumberLinkLabel;
        }

        public Label GetPhoneTypeLabel()
        {
            return phoneTypeLabel;
        }

        public FlowLayoutPanel GetCommentsInnerFlowLayoutPanel()
        {
            return commentsInnerFlowLayoutPanel;
        }

        #endregion

        // Кнопка добавления нового комментария.
        private void addNewCommentContactPersonButton_Click(object sender, EventArgs e)
        {
            makeFormExpandForComments();
            MyCommentPanel newCommentPanel = new MyCommentPanel(this);
            MyCommentPanelList.Add(newCommentPanel);
            commentsInnerFlowLayoutPanel.Controls.Add(newCommentPanel);
        }

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

        // Отображаем введенный телефон и комментарий на данной панели.
        public void AddAndDisplayNewContactPersonPhone(AddNewContactPersonPhoneForm form)
        {
            MyContactPersonPhonePanel contactPersonPhonePanel = 
                                    new MyContactPersonPhonePanel(this, form);
            contactPersonPhonePanel.MyPhoneTypeLabel.Text = form.NewPhoneType;
            contactPersonPhonePanel.MyPhoneNumberLinkLabel.Text = form.NewPhoneNumber;
            contactPersonPhonePanel.MyPhoneCommentTextBox.Text = form.NewPhoneComment;
            phonesContactPersonFlowLayoutPanel.Controls.Add(contactPersonPhonePanel);
        }

        // Отображаем введенный телефон и комментарий повторно открытой формы для ввода телефона
        // с учетом внесенных изменений.
        public void RedisplayReopenedContactPersonPhonePanel(AddNewContactPersonPhoneForm form)
        {
            _reopenedContactPersonPhonePanel.MyPhoneTypeLabel.Text = form.NewPhoneType;
            _reopenedContactPersonPhonePanel.MyPhoneNumberLinkLabel.Text = form.NewPhoneNumber;
            _reopenedContactPersonPhonePanel.MyPhoneCommentTextBox.Text = form.NewPhoneComment;
        }

        // Сохраняем введенные данные по нажатию на кнопку "Сохранить и закрыть".
        private void saveNewContactPersonButton_Click(object sender, EventArgs e)
        {
            if (LastnameContactPerson != null)
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
        /// Методы, передающие введенные данные в переменные и
        /// проверяющие правильность введенной информации.
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
        public void ReopenContactPersonPhone(AddNewContactPersonPhoneForm phoneForm,
                                             MyContactPersonPhonePanel phonePanel)
        {
            _reopenedContactPersonPhonePanel = phonePanel;
            phoneForm.Show();
        }

        // При закрытии окна по нажатию на красный крестик выбираем,
        //что нужно сделать с формой: удалить или скрыть.
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
    }
}
