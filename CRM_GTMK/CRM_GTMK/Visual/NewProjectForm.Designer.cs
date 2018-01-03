namespace CRM_GTMK.Visual
{
	partial class NewProjectForm
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
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.selectFilesButton = new System.Windows.Forms.Button();
			this.showFoldersCheckBox = new System.Windows.Forms.CheckBox();
			this.showDeleteCheckBox = new System.Windows.Forms.CheckBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.AccessibleRole = System.Windows.Forms.AccessibleRole.DropList;
			this.flowLayoutPanel1.AllowDrop = true;
			this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(173, 12);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(744, 416);
			this.flowLayoutPanel1.TabIndex = 0;
			// 
			// selectFilesButton
			// 
			this.selectFilesButton.Location = new System.Drawing.Point(28, 77);
			this.selectFilesButton.Name = "selectFilesButton";
			this.selectFilesButton.Size = new System.Drawing.Size(81, 23);
			this.selectFilesButton.TabIndex = 1;
			this.selectFilesButton.Text = "Выбрать";
			this.selectFilesButton.UseVisualStyleBackColor = true;
			// 
			// showFoldersCheckBox
			// 
			this.showFoldersCheckBox.AutoSize = true;
			this.showFoldersCheckBox.Checked = true;
			this.showFoldersCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.showFoldersCheckBox.Location = new System.Drawing.Point(12, 21);
			this.showFoldersCheckBox.Name = "showFoldersCheckBox";
			this.showFoldersCheckBox.Size = new System.Drawing.Size(122, 17);
			this.showFoldersCheckBox.TabIndex = 2;
			this.showFoldersCheckBox.Text = "Показывать папки";
			this.showFoldersCheckBox.UseVisualStyleBackColor = true;
			this.showFoldersCheckBox.CheckedChanged += new System.EventHandler(this.showFoldersCheckBox_CheckedChanged);
			// 
			// showDeleteCheckBox
			// 
			this.showDeleteCheckBox.AutoSize = true;
			this.showDeleteCheckBox.Checked = true;
			this.showDeleteCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.showDeleteCheckBox.Location = new System.Drawing.Point(12, 45);
			this.showDeleteCheckBox.Name = "showDeleteCheckBox";
			this.showDeleteCheckBox.Size = new System.Drawing.Size(133, 17);
			this.showDeleteCheckBox.TabIndex = 3;
			this.showDeleteCheckBox.Text = "Показать удаленные";
			this.showDeleteCheckBox.UseVisualStyleBackColor = true;
			this.showDeleteCheckBox.CheckedChanged += new System.EventHandler(this.showDeleteCheckBox_CheckedChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(37, 392);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "Далее";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// NewProjectForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(929, 440);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.showDeleteCheckBox);
			this.Controls.Add(this.showFoldersCheckBox);
			this.Controls.Add(this.selectFilesButton);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Name = "NewProjectForm";
			this.Text = "NewProjectForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Button selectFilesButton;
		private System.Windows.Forms.CheckBox showFoldersCheckBox;
		private System.Windows.Forms.CheckBox showDeleteCheckBox;
		private System.Windows.Forms.Button button1;
	}
}