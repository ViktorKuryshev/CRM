using CRM_GTMK.Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_GTMK.Visual.MainScreenPanels
{
	public class MyAllProjectsTableLayoutPanel : TableLayoutPanel
	{
		public List<ProjectControls> AllProjects { get; set; } = new List<ProjectControls>();

		public MyAllProjectsTableLayoutPanel(MainScreenForm from) : base()
		{
			
			CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
			ColumnCount = 4;
			ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
			ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
			ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
			Location = new System.Drawing.Point(211, 57);
			Name = "ProjectsTableLayoutPanel";
			RowCount = 1;
			RowStyles.Add(new System.Windows.Forms.RowStyle());
			
			Size = new System.Drawing.Size(1075, 515);
			TabIndex = 2;
			AutoScroll = true;
			
			//Setting Title Controls
			Controls.Add(new MyTitleElementsLabel("Название"), 1, 0);
			Controls.Add(new MyTitleElementsLabel("Прогресс"), 2, 0);
			Controls.Add(new MyTitleElementsLabel("Дедлайн"), 3, 0);

		}
	
		
		public void AddOneProject(ProjectControls project)
		{
			RowCount++;
			RowStyles.Add(new System.Windows.Forms.RowStyle());
			Controls.Add(project.ShowProjectDetails, 0, RowCount - 1);
			Controls.Add(project.ProjectName, 1, RowCount - 1);
			Controls.Add(project.ProjectPogress, 2, RowCount - 1);
			Controls.Add(project.ProjectDeadLine, 3, RowCount - 1);

			AllProjects.Add(project);
			Thread.Sleep(10); 
		}

		
		/*
		this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
		this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
		this.tableLayoutPanel1.Controls.Add(this.checkBox1, 0, 0);
		this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
		this.tableLayoutPanel1.Controls.Add(this.progressBar1, 2, 0);
		this.tableLayoutPanel1.Controls.Add(this.label2, 3, 0);
		this.tableLayoutPanel1.Location = new System.Drawing.Point(41, 291);
		this.tableLayoutPanel1.Name = "tableLayoutPanel1";
		this.tableLayoutPanel1.RowCount = 4;
		this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
		this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
		this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
		this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
		this.tableLayoutPanel1.Size = new System.Drawing.Size(743, 184);
		this.tableLayoutPanel1.TabIndex = 0;
		this.tableLayoutPanel1.SetColumnSpan(this.panel1, 4);
		*/
	}

	#region Title elements
	public class MyTitleElementsLabel : Label
	{
		public MyTitleElementsLabel(string text)
		{
			AutoSize = true;

			Name = "TitleElementsTitleLabel";
			Padding = new System.Windows.Forms.Padding(5, 10, 5, 5);

			Text = text;
		}
	}
	#endregion

	public class ProjectControls
	{
		public CheckBox ShowProjectDetails { get; set; } = new CheckBox();
		public Label ProjectName { get; set; } = new Label();
		public ProgressBar ProjectPogress { get; set; } = new ProgressBar();
		public Label ProjectDeadLine { get; set; } = new Label();

		public ProjectControls()
		{
			ProjectName.AutoSize = true;
			ProjectDeadLine.AutoSize = true;
		}

	}
}
