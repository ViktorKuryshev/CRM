namespace StudyCollections.Dictionary
{
	partial class MorseTranslatorForm
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
			this.stringInputBox = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.morseCodeBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// stringInputBox
			// 
			this.stringInputBox.Location = new System.Drawing.Point(36, 28);
			this.stringInputBox.Name = "stringInputBox";
			this.stringInputBox.Size = new System.Drawing.Size(100, 20);
			this.stringInputBox.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(168, 24);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Перевести";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// morseCodeBox
			// 
			this.morseCodeBox.Location = new System.Drawing.Point(36, 97);
			this.morseCodeBox.Multiline = true;
			this.morseCodeBox.Name = "morseCodeBox";
			this.morseCodeBox.Size = new System.Drawing.Size(207, 88);
			this.morseCodeBox.TabIndex = 2;
			// 
			// MorseTranslatorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.morseCodeBox);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.stringInputBox);
			this.Name = "MorseTranslatorForm";
			this.Text = "MorseTranslatorForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox stringInputBox;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox morseCodeBox;
	}
}