namespace CRM_GTMK.Visual
{
	partial class WorkFlowsForm
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
			this.goBackButton = new System.Windows.Forms.Button();
			this.createProjectButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// goBackButton
			// 
			this.goBackButton.Location = new System.Drawing.Point(39, 193);
			this.goBackButton.Name = "goBackButton";
			this.goBackButton.Size = new System.Drawing.Size(75, 23);
			this.goBackButton.TabIndex = 0;
			this.goBackButton.Text = "Назад";
			this.goBackButton.UseVisualStyleBackColor = true;
			this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
			// 
			// createProjectButton
			// 
			this.createProjectButton.Location = new System.Drawing.Point(175, 193);
			this.createProjectButton.Name = "createProjectButton";
			this.createProjectButton.Size = new System.Drawing.Size(75, 23);
			this.createProjectButton.TabIndex = 1;
			this.createProjectButton.Text = "Завершить";
			this.createProjectButton.UseVisualStyleBackColor = true;
			this.createProjectButton.Click += new System.EventHandler(this.createProjectButton_Click);
			// 
			// WorkFlowsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.createProjectButton);
			this.Controls.Add(this.goBackButton);
			this.Name = "WorkFlowsForm";
			this.Text = "WorkFlowsForm";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button goBackButton;
		private System.Windows.Forms.Button createProjectButton;
	}
}