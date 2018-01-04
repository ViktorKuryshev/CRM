namespace CRM_GTMK.Visual
{
	partial class NewProjectSettingsForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.projectNameTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.deadLineDate = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.goBackButton = new System.Windows.Forms.Button();
			this.goOnButton = new System.Windows.Forms.Button();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TMName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Write = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// projectNameTextBox
			// 
			this.projectNameTextBox.Location = new System.Drawing.Point(64, 57);
			this.projectNameTextBox.Name = "projectNameTextBox";
			this.projectNameTextBox.Size = new System.Drawing.Size(327, 20);
			this.projectNameTextBox.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(61, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Название проекта";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(474, 29);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(98, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Дата завершения";
			// 
			// deadLineDate
			// 
			this.deadLineDate.CustomFormat = "d.MM.yyyy - HH:m";
			this.deadLineDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.deadLineDate.Location = new System.Drawing.Point(477, 57);
			this.deadLineDate.Name = "deadLineDate";
			this.deadLineDate.Size = new System.Drawing.Size(200, 20);
			this.deadLineDate.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(61, 95);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(43, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Клиент";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(64, 124);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(327, 21);
			this.comboBox1.TabIndex = 6;
			this.comboBox1.TextUpdate += new System.EventHandler(this.comboBox1_TextUpdate);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(61, 159);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(91, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Язык оригинала";
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(64, 187);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(166, 21);
			this.comboBox2.TabIndex = 8;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(136, 90);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(115, 23);
			this.button1.TabIndex = 9;
			this.button1.Text = "Добавить нового";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(339, 158);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(86, 13);
			this.label5.TabIndex = 10;
			this.label5.Text = "Язык перевода";
			// 
			// comboBox3
			// 
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Location = new System.Drawing.Point(342, 187);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(335, 21);
			this.comboBox3.TabIndex = 11;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(64, 227);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(77, 13);
			this.label6.TabIndex = 12;
			this.label6.Text = "Комментарий";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(67, 257);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(610, 49);
			this.textBox2.TabIndex = 13;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(64, 362);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(137, 13);
			this.label7.TabIndex = 15;
			this.label7.Text = "Расширенные настройки:";
			// 
			// goBackButton
			// 
			this.goBackButton.Location = new System.Drawing.Point(184, 326);
			this.goBackButton.Name = "goBackButton";
			this.goBackButton.Size = new System.Drawing.Size(180, 23);
			this.goBackButton.TabIndex = 16;
			this.goBackButton.Text = "Вернуться";
			this.goBackButton.UseVisualStyleBackColor = true;
			this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
			// 
			// goOnButton
			// 
			this.goOnButton.Location = new System.Drawing.Point(392, 326);
			this.goOnButton.Name = "goOnButton";
			this.goOnButton.Size = new System.Drawing.Size(180, 23);
			this.goOnButton.TabIndex = 17;
			this.goOnButton.Text = "Далее";
			this.goOnButton.UseVisualStyleBackColor = true;
			this.goOnButton.Click += new System.EventHandler(this.goOnButton_Click);
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(602, 109);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Глоссарии";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(60, 381);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(610, 135);
			this.tabControl1.TabIndex = 14;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.dataGridView1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(602, 109);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Память переводов";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.TMName,
            this.Write});
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(3, 3);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(596, 103);
			this.dataGridView1.TabIndex = 0;
			// 
			// Number
			// 
			this.Number.HeaderText = "№";
			this.Number.Name = "Number";
			this.Number.ReadOnly = true;
			// 
			// TMName
			// 
			this.TMName.HeaderText = "Название";
			this.TMName.Name = "TMName";
			this.TMName.ReadOnly = true;
			// 
			// Write
			// 
			this.Write.HeaderText = "Запись";
			this.Write.Name = "Write";
			this.Write.ReadOnly = true;
			// 
			// NewProjectSettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(736, 541);
			this.Controls.Add(this.goOnButton);
			this.Controls.Add(this.goBackButton);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.comboBox3);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.deadLineDate);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.projectNameTextBox);
			this.Name = "NewProjectSettingsForm";
			this.Text = "NewProjectSettingsForm";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox projectNameTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker deadLineDate;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button goBackButton;
		private System.Windows.Forms.Button goOnButton;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Number;
		private System.Windows.Forms.DataGridViewTextBoxColumn TMName;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Write;
	}
}