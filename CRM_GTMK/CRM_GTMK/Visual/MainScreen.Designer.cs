namespace CRM_GTMK.Visual
{
	partial class MainScreen
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
			System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Компании");
			System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Физ. лица");
			System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Благотворительность");
			System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Клиенты", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
			System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Проекты");
			System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Список задач");
			System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Задачи", new System.Windows.Forms.TreeNode[] {
            treeNode6});
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.addNewClientButton = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.StateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LastContactDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AddingDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// treeView1
			// 
			this.treeView1.Location = new System.Drawing.Point(12, 50);
			this.treeView1.Name = "treeView1";
			treeNode1.Name = "CompaniesNode";
			treeNode1.Text = "Компании";
			treeNode2.Name = "PersonClientNode";
			treeNode2.Text = "Физ. лица";
			treeNode3.Name = "CharityNode";
			treeNode3.Text = "Благотворительность";
			treeNode4.Checked = true;
			treeNode4.Name = "ClientsRoot";
			treeNode4.Text = "Клиенты";
			treeNode5.Name = "ProgectsRoot";
			treeNode5.Text = "Проекты";
			treeNode6.Name = "TasksListNode";
			treeNode6.Text = "Список задач";
			treeNode7.Name = "TasksRoot";
			treeNode7.Text = "Задачи";
			this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode7});
			this.treeView1.Size = new System.Drawing.Size(165, 352);
			this.treeView1.TabIndex = 0;
			this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.dataGridView1);
			this.panel1.Controls.Add(this.addNewClientButton);
			this.panel1.Location = new System.Drawing.Point(209, 50);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(641, 352);
			this.panel1.TabIndex = 1;
			// 
			// addNewClientButton
			// 
			this.addNewClientButton.Location = new System.Drawing.Point(274, 14);
			this.addNewClientButton.Name = "addNewClientButton";
			this.addNewClientButton.Size = new System.Drawing.Size(164, 23);
			this.addNewClientButton.TabIndex = 0;
			this.addNewClientButton.Text = "Добавить";
			this.addNewClientButton.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.CityColumn,
            this.StateColumn,
            this.LastContactDate,
            this.AddingDateColumn});
			this.dataGridView1.Location = new System.Drawing.Point(12, 56);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(544, 284);
			this.dataGridView1.TabIndex = 1;
			// 
			// NameColumn
			// 
			this.NameColumn.HeaderText = "Название";
			this.NameColumn.Name = "NameColumn";
			// 
			// CityColumn
			// 
			this.CityColumn.HeaderText = "Город";
			this.CityColumn.Name = "CityColumn";
			// 
			// StateColumn
			// 
			this.StateColumn.HeaderText = "Статус";
			this.StateColumn.Name = "StateColumn";
			// 
			// LastContactDate
			// 
			this.LastContactDate.HeaderText = "Дата крайнего контакта";
			this.LastContactDate.Name = "LastContactDate";
			// 
			// AddingDateColumn
			// 
			this.AddingDateColumn.HeaderText = "Дата добавления";
			this.AddingDateColumn.Name = "AddingDateColumn";
			// 
			// MainScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(873, 435);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.treeView1);
			this.Name = "MainScreen";
			this.Text = "MainScreen";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn CityColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn StateColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn LastContactDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn AddingDateColumn;
		private System.Windows.Forms.Button addNewClientButton;
	}
}