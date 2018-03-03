namespace CRM_GTMK.Visual
{
	partial class MainScreenForm
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
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Задачи");
            this.navigationTreeView = new System.Windows.Forms.TreeView();
            this.clientsPanel = new System.Windows.Forms.Panel();
            this.companiesDefaultListDataGridView = new System.Windows.Forms.DataGridView();
            this.CompanyNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyCityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyStatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastContactDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddingDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addNewCompanyButton = new System.Windows.Forms.Button();
            this.clientsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companiesDefaultListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // navigationTreeView
            // 
            this.navigationTreeView.Location = new System.Drawing.Point(12, 57);
            this.navigationTreeView.Name = "navigationTreeView";
            treeNode1.Name = "CompaniesNode";
            treeNode1.Text = "Компании";
            treeNode2.Name = "PhisicalPersonsNode";
            treeNode2.Text = "Физ. лица";
            treeNode3.Name = "CharityNode";
            treeNode3.Text = "Благотворительность";
            treeNode4.Checked = true;
            treeNode4.Name = "ClientsRoot";
            treeNode4.Text = "Клиенты";
            treeNode5.Name = "ProjectsRoot";
            treeNode5.Text = "Проекты";
            treeNode6.Name = "TasksRoot";
            treeNode6.Text = "Задачи";
            this.navigationTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6});
            this.navigationTreeView.Size = new System.Drawing.Size(165, 517);
            this.navigationTreeView.TabIndex = 0;
            this.navigationTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.navigationTreeView_AfterSelect);
            // 
            // clientsPanel
            // 
            this.clientsPanel.Controls.Add(this.companiesDefaultListDataGridView);
            this.clientsPanel.Controls.Add(this.addNewCompanyButton);
            this.clientsPanel.Location = new System.Drawing.Point(211, 57);
            this.clientsPanel.Name = "clientsPanel";
            this.clientsPanel.Size = new System.Drawing.Size(1075, 517);
            this.clientsPanel.TabIndex = 1;
            // 
            // companiesDefaultListDataGridView
            // 
            this.companiesDefaultListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.companiesDefaultListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CompanyNameColumn,
            this.CompanyCityColumn,
            this.CompanyStatusColumn,
            this.LastContactDateColumn,
            this.AddingDateColumn});
            this.companiesDefaultListDataGridView.Location = new System.Drawing.Point(18, 62);
            this.companiesDefaultListDataGridView.Name = "companiesDefaultListDataGridView";
            this.companiesDefaultListDataGridView.Size = new System.Drawing.Size(589, 275);
            this.companiesDefaultListDataGridView.TabIndex = 1;
            // 
            // CompanyNameColumn
            // 
            this.CompanyNameColumn.HeaderText = "Название";
            this.CompanyNameColumn.Name = "CompanyNameColumn";
            // 
            // CompanyCityColumn
            // 
            this.CompanyCityColumn.HeaderText = "Город";
            this.CompanyCityColumn.Name = "CompanyCityColumn";
            // 
            // CompanyStatusColumn
            // 
            this.CompanyStatusColumn.HeaderText = "Статус";
            this.CompanyStatusColumn.Name = "CompanyStatusColumn";
            // 
            // LastContactDateColumn
            // 
            this.LastContactDateColumn.HeaderText = "Дата крайнего контакта";
            this.LastContactDateColumn.Name = "LastContactDateColumn";
            // 
            // AddingDateColumn
            // 
            this.AddingDateColumn.HeaderText = "Дата внесения в базу";
            this.AddingDateColumn.Name = "AddingDateColumn";
            // 
            // addNewCompanyButton
            // 
            this.addNewCompanyButton.Location = new System.Drawing.Point(210, 22);
            this.addNewCompanyButton.Name = "addNewCompanyButton";
            this.addNewCompanyButton.Size = new System.Drawing.Size(135, 23);
            this.addNewCompanyButton.TabIndex = 0;
            this.addNewCompanyButton.Text = "Добавить компанию";
            this.addNewCompanyButton.UseVisualStyleBackColor = true;
            this.addNewCompanyButton.Click += new System.EventHandler(this.addNewCompanyButton_Click);
            // 
            // MainScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 586);
            this.Controls.Add(this.clientsPanel);
            this.Controls.Add(this.navigationTreeView);
            this.Name = "MainScreenForm";
            this.Text = "MainScreenForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainScreenForm_FormClosing);
            this.clientsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.companiesDefaultListDataGridView)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TreeView navigationTreeView;
		private System.Windows.Forms.Panel clientsPanel;
		private System.Windows.Forms.DataGridView companiesDefaultListDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn CompanyNameColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn CompanyCityColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn CompanyStatusColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn LastContactDateColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn AddingDateColumn;
		private System.Windows.Forms.Button addNewCompanyButton;
	}
}