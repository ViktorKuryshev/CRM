﻿namespace CRM_GTMK.Visual
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
			this.showDeletedCheckBox = new System.Windows.Forms.CheckBox();
			this.NextStepButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(173, 12);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(738, 370);
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
			this.showFoldersCheckBox.Location = new System.Drawing.Point(20, 22);
			this.showFoldersCheckBox.Name = "showFoldersCheckBox";
			this.showFoldersCheckBox.Size = new System.Drawing.Size(122, 17);
			this.showFoldersCheckBox.TabIndex = 2;
			this.showFoldersCheckBox.Text = "Показывать папки";
			this.showFoldersCheckBox.UseVisualStyleBackColor = true;
			this.showFoldersCheckBox.CheckedChanged += new System.EventHandler(this.showFoldersCheckBox_CheckedChanged);
			// 
			// showDeletedCheckBox
			// 
			this.showDeletedCheckBox.AutoSize = true;
			this.showDeletedCheckBox.Checked = true;
			this.showDeletedCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.showDeletedCheckBox.Location = new System.Drawing.Point(20, 45);
			this.showDeletedCheckBox.Name = "showDeletedCheckBox";
			this.showDeletedCheckBox.Size = new System.Drawing.Size(147, 17);
			this.showDeletedCheckBox.TabIndex = 3;
			this.showDeletedCheckBox.Text = "Показывать удаленные";
			this.showDeletedCheckBox.UseVisualStyleBackColor = true;
			this.showDeletedCheckBox.CheckedChanged += new System.EventHandler(this.showDeletedCheckBox_CheckedChanged);
			// 
			// NextStepButton
			// 
			this.NextStepButton.Location = new System.Drawing.Point(28, 298);
			this.NextStepButton.Name = "NextStepButton";
			this.NextStepButton.Size = new System.Drawing.Size(75, 23);
			this.NextStepButton.TabIndex = 4;
			this.NextStepButton.Text = "Далее";
			this.NextStepButton.UseVisualStyleBackColor = true;
			this.NextStepButton.Click += new System.EventHandler(this.NextStepButton_Click);
			// 
			// newProjectForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(923, 394);
			this.Controls.Add(this.NextStepButton);
			this.Controls.Add(this.showDeletedCheckBox);
			this.Controls.Add(this.showFoldersCheckBox);
			this.Controls.Add(this.selectFilesButton);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Name = "newProjectForm";
			this.Text = "NewProjectForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Button selectFilesButton;
		private System.Windows.Forms.CheckBox showFoldersCheckBox;
		private System.Windows.Forms.CheckBox showDeletedCheckBox;
		private System.Windows.Forms.Button NextStepButton;
	}
}