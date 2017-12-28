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
			this.button1 = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
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
			this.flowLayoutPanel1.Size = new System.Drawing.Size(493, 370);
			this.flowLayoutPanel1.TabIndex = 0;
			this.flowLayoutPanel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel1_DragDrop);
			this.flowLayoutPanel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel1_DragEnter);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(28, 77);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(81, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Выбрать";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(28, 12);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(122, 17);
			this.checkBox1.TabIndex = 2;
			this.checkBox1.Text = "Показывать папки";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// NewProjectForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(678, 394);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Name = "NewProjectForm";
			this.Text = "NewProjectForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.CheckBox checkBox1;
	}
}