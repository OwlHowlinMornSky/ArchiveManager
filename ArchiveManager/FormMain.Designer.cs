namespace ArchiveManager {
	partial class FormMain {
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			MenuStrip_Main = new MenuStrip();
			fileToolStripMenuItem = new ToolStripMenuItem();
			editToolStripMenuItem = new ToolStripMenuItem();
			viewToolStripMenuItem = new ToolStripMenuItem();
			repositoryToolStripMenuItem = new ToolStripMenuItem();
			branchToolStripMenuItem = new ToolStripMenuItem();
			helpToolStripMenuItem = new ToolStripMenuItem();
			SplitContainer_Main = new SplitContainer();
			TabControl_Left = new TabControl();
			TabPage_Commit = new TabPage();
			Panel_CommitEdit = new Panel();
			TextBox_Commit = new TextBox();
			Button_Submit = new Button();
			TextBox_CommitTitle = new TextBox();
			TabPage_History = new TabPage();
			ComboBox_Repository = new ComboBox();
			Panel_View = new Panel();
			Panel_ViewChanges = new Panel();
			SplitContainer_CommitChanges = new SplitContainer();
			Panel_CommitInfo = new Panel();
			Panel_ViewNoChanges = new Panel();
			Label_NoChanges = new Label();
			Panel_ViewTop = new Panel();
			button1 = new Button();
			ComboBox_Stream = new ComboBox();
			MenuStrip_Main.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)SplitContainer_Main).BeginInit();
			SplitContainer_Main.Panel1.SuspendLayout();
			SplitContainer_Main.Panel2.SuspendLayout();
			SplitContainer_Main.SuspendLayout();
			TabControl_Left.SuspendLayout();
			TabPage_Commit.SuspendLayout();
			Panel_CommitEdit.SuspendLayout();
			Panel_View.SuspendLayout();
			Panel_ViewChanges.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)SplitContainer_CommitChanges).BeginInit();
			SplitContainer_CommitChanges.SuspendLayout();
			Panel_ViewNoChanges.SuspendLayout();
			Panel_ViewTop.SuspendLayout();
			SuspendLayout();
			// 
			// MenuStrip_Main
			// 
			MenuStrip_Main.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem, repositoryToolStripMenuItem, branchToolStripMenuItem, helpToolStripMenuItem });
			MenuStrip_Main.Location = new Point(0, 0);
			MenuStrip_Main.Name = "MenuStrip_Main";
			MenuStrip_Main.Size = new Size(794, 25);
			MenuStrip_Main.TabIndex = 0;
			MenuStrip_Main.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			fileToolStripMenuItem.Size = new Size(39, 21);
			fileToolStripMenuItem.Text = "File";
			// 
			// editToolStripMenuItem
			// 
			editToolStripMenuItem.Name = "editToolStripMenuItem";
			editToolStripMenuItem.Size = new Size(42, 21);
			editToolStripMenuItem.Text = "Edit";
			// 
			// viewToolStripMenuItem
			// 
			viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			viewToolStripMenuItem.Size = new Size(47, 21);
			viewToolStripMenuItem.Text = "View";
			// 
			// repositoryToolStripMenuItem
			// 
			repositoryToolStripMenuItem.Name = "repositoryToolStripMenuItem";
			repositoryToolStripMenuItem.Size = new Size(83, 21);
			repositoryToolStripMenuItem.Text = "Repository";
			// 
			// branchToolStripMenuItem
			// 
			branchToolStripMenuItem.Name = "branchToolStripMenuItem";
			branchToolStripMenuItem.Size = new Size(60, 21);
			branchToolStripMenuItem.Text = "Branch";
			// 
			// helpToolStripMenuItem
			// 
			helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			helpToolStripMenuItem.Size = new Size(47, 21);
			helpToolStripMenuItem.Text = "Help";
			// 
			// SplitContainer_Main
			// 
			SplitContainer_Main.BorderStyle = BorderStyle.FixedSingle;
			SplitContainer_Main.Dock = DockStyle.Fill;
			SplitContainer_Main.FixedPanel = FixedPanel.Panel1;
			SplitContainer_Main.Location = new Point(0, 25);
			SplitContainer_Main.Name = "SplitContainer_Main";
			// 
			// SplitContainer_Main.Panel1
			// 
			SplitContainer_Main.Panel1.Controls.Add(TabControl_Left);
			SplitContainer_Main.Panel1.Controls.Add(ComboBox_Repository);
			SplitContainer_Main.Panel1MinSize = 180;
			// 
			// SplitContainer_Main.Panel2
			// 
			SplitContainer_Main.Panel2.Controls.Add(Panel_View);
			SplitContainer_Main.Panel2.Controls.Add(Panel_ViewTop);
			SplitContainer_Main.Panel2MinSize = 120;
			SplitContainer_Main.Size = new Size(794, 496);
			SplitContainer_Main.SplitterDistance = 200;
			SplitContainer_Main.TabIndex = 1;
			SplitContainer_Main.TabStop = false;
			// 
			// TabControl_Left
			// 
			TabControl_Left.Controls.Add(TabPage_Commit);
			TabControl_Left.Controls.Add(TabPage_History);
			TabControl_Left.Dock = DockStyle.Fill;
			TabControl_Left.Location = new Point(0, 34);
			TabControl_Left.Name = "TabControl_Left";
			TabControl_Left.SelectedIndex = 0;
			TabControl_Left.Size = new Size(198, 460);
			TabControl_Left.TabIndex = 1;
			// 
			// TabPage_Commit
			// 
			TabPage_Commit.Controls.Add(Panel_CommitEdit);
			TabPage_Commit.Location = new Point(4, 26);
			TabPage_Commit.Name = "TabPage_Commit";
			TabPage_Commit.Padding = new Padding(3);
			TabPage_Commit.Size = new Size(190, 430);
			TabPage_Commit.TabIndex = 0;
			TabPage_Commit.Text = "Commit";
			TabPage_Commit.UseVisualStyleBackColor = true;
			// 
			// Panel_CommitEdit
			// 
			Panel_CommitEdit.Controls.Add(TextBox_Commit);
			Panel_CommitEdit.Controls.Add(Button_Submit);
			Panel_CommitEdit.Controls.Add(TextBox_CommitTitle);
			Panel_CommitEdit.Dock = DockStyle.Fill;
			Panel_CommitEdit.Location = new Point(3, 3);
			Panel_CommitEdit.Name = "Panel_CommitEdit";
			Panel_CommitEdit.Size = new Size(184, 424);
			Panel_CommitEdit.TabIndex = 1;
			// 
			// TextBox_Commit
			// 
			TextBox_Commit.Dock = DockStyle.Fill;
			TextBox_Commit.Enabled = false;
			TextBox_Commit.Location = new Point(0, 28);
			TextBox_Commit.Multiline = true;
			TextBox_Commit.Name = "TextBox_Commit";
			TextBox_Commit.Size = new Size(184, 322);
			TextBox_Commit.TabIndex = 2;
			// 
			// Button_Submit
			// 
			Button_Submit.Dock = DockStyle.Bottom;
			Button_Submit.Enabled = false;
			Button_Submit.Location = new Point(0, 350);
			Button_Submit.Name = "Button_Submit";
			Button_Submit.Size = new Size(184, 74);
			Button_Submit.TabIndex = 1;
			Button_Submit.Text = "Submit";
			Button_Submit.UseVisualStyleBackColor = true;
			// 
			// TextBox_CommitTitle
			// 
			TextBox_CommitTitle.Dock = DockStyle.Top;
			TextBox_CommitTitle.Enabled = false;
			TextBox_CommitTitle.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
			TextBox_CommitTitle.Location = new Point(0, 0);
			TextBox_CommitTitle.Name = "TextBox_CommitTitle";
			TextBox_CommitTitle.Size = new Size(184, 28);
			TextBox_CommitTitle.TabIndex = 0;
			// 
			// TabPage_History
			// 
			TabPage_History.Location = new Point(4, 26);
			TabPage_History.Name = "TabPage_History";
			TabPage_History.Padding = new Padding(3);
			TabPage_History.Size = new Size(190, 430);
			TabPage_History.TabIndex = 1;
			TabPage_History.Text = "History";
			TabPage_History.UseVisualStyleBackColor = true;
			// 
			// ComboBox_Repository
			// 
			ComboBox_Repository.Dock = DockStyle.Top;
			ComboBox_Repository.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 134);
			ComboBox_Repository.FormattingEnabled = true;
			ComboBox_Repository.Location = new Point(0, 0);
			ComboBox_Repository.Name = "ComboBox_Repository";
			ComboBox_Repository.Size = new Size(198, 34);
			ComboBox_Repository.TabIndex = 0;
			// 
			// Panel_View
			// 
			Panel_View.BorderStyle = BorderStyle.FixedSingle;
			Panel_View.Controls.Add(Panel_ViewChanges);
			Panel_View.Controls.Add(Panel_ViewNoChanges);
			Panel_View.Dock = DockStyle.Fill;
			Panel_View.Location = new Point(0, 34);
			Panel_View.Name = "Panel_View";
			Panel_View.Size = new Size(588, 460);
			Panel_View.TabIndex = 1;
			// 
			// Panel_ViewChanges
			// 
			Panel_ViewChanges.BackColor = SystemColors.AppWorkspace;
			Panel_ViewChanges.Controls.Add(SplitContainer_CommitChanges);
			Panel_ViewChanges.Controls.Add(Panel_CommitInfo);
			Panel_ViewChanges.Dock = DockStyle.Fill;
			Panel_ViewChanges.Location = new Point(0, 0);
			Panel_ViewChanges.Name = "Panel_ViewChanges";
			Panel_ViewChanges.Size = new Size(586, 458);
			Panel_ViewChanges.TabIndex = 1;
			// 
			// SplitContainer_CommitChanges
			// 
			SplitContainer_CommitChanges.BorderStyle = BorderStyle.FixedSingle;
			SplitContainer_CommitChanges.Dock = DockStyle.Fill;
			SplitContainer_CommitChanges.Location = new Point(0, 69);
			SplitContainer_CommitChanges.Name = "SplitContainer_CommitChanges";
			SplitContainer_CommitChanges.Size = new Size(586, 389);
			SplitContainer_CommitChanges.SplitterDistance = 195;
			SplitContainer_CommitChanges.TabIndex = 1;
			// 
			// Panel_CommitInfo
			// 
			Panel_CommitInfo.Dock = DockStyle.Top;
			Panel_CommitInfo.Location = new Point(0, 0);
			Panel_CommitInfo.Name = "Panel_CommitInfo";
			Panel_CommitInfo.Size = new Size(586, 69);
			Panel_CommitInfo.TabIndex = 0;
			// 
			// Panel_ViewNoChanges
			// 
			Panel_ViewNoChanges.BackColor = SystemColors.Control;
			Panel_ViewNoChanges.Controls.Add(Label_NoChanges);
			Panel_ViewNoChanges.Dock = DockStyle.Fill;
			Panel_ViewNoChanges.Location = new Point(0, 0);
			Panel_ViewNoChanges.Name = "Panel_ViewNoChanges";
			Panel_ViewNoChanges.Size = new Size(586, 458);
			Panel_ViewNoChanges.TabIndex = 0;
			// 
			// Label_NoChanges
			// 
			Label_NoChanges.AutoSize = true;
			Label_NoChanges.Font = new Font("Microsoft YaHei UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 134);
			Label_NoChanges.Location = new Point(46, 40);
			Label_NoChanges.Name = "Label_NoChanges";
			Label_NoChanges.Size = new Size(219, 46);
			Label_NoChanges.TabIndex = 0;
			Label_NoChanges.Text = "No changes";
			// 
			// Panel_ViewTop
			// 
			Panel_ViewTop.Controls.Add(button1);
			Panel_ViewTop.Controls.Add(ComboBox_Stream);
			Panel_ViewTop.Dock = DockStyle.Top;
			Panel_ViewTop.Location = new Point(0, 0);
			Panel_ViewTop.Name = "Panel_ViewTop";
			Panel_ViewTop.Size = new Size(588, 34);
			Panel_ViewTop.TabIndex = 0;
			// 
			// button1
			// 
			button1.Location = new Point(198, 0);
			button1.Name = "button1";
			button1.Size = new Size(198, 34);
			button1.TabIndex = 1;
			button1.Text = "button1";
			button1.UseVisualStyleBackColor = true;
			// 
			// ComboBox_Stream
			// 
			ComboBox_Stream.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 134);
			ComboBox_Stream.FormattingEnabled = true;
			ComboBox_Stream.Location = new Point(0, 0);
			ComboBox_Stream.Name = "ComboBox_Stream";
			ComboBox_Stream.Size = new Size(198, 34);
			ComboBox_Stream.TabIndex = 0;
			// 
			// FormMain
			// 
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(794, 521);
			Controls.Add(SplitContainer_Main);
			Controls.Add(MenuStrip_Main);
			MainMenuStrip = MenuStrip_Main;
			MinimumSize = new Size(640, 320);
			Name = "FormMain";
			Text = "ArchiveManager";
			FormClosing += FormMain_FormClosing;
			FormClosed += FormMain_FormClosed;
			Load += FormMain_Load;
			MenuStrip_Main.ResumeLayout(false);
			MenuStrip_Main.PerformLayout();
			SplitContainer_Main.Panel1.ResumeLayout(false);
			SplitContainer_Main.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)SplitContainer_Main).EndInit();
			SplitContainer_Main.ResumeLayout(false);
			TabControl_Left.ResumeLayout(false);
			TabPage_Commit.ResumeLayout(false);
			Panel_CommitEdit.ResumeLayout(false);
			Panel_CommitEdit.PerformLayout();
			Panel_View.ResumeLayout(false);
			Panel_ViewChanges.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)SplitContainer_CommitChanges).EndInit();
			SplitContainer_CommitChanges.ResumeLayout(false);
			Panel_ViewNoChanges.ResumeLayout(false);
			Panel_ViewNoChanges.PerformLayout();
			Panel_ViewTop.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip MenuStrip_Main;
		private ToolStripMenuItem fileToolStripMenuItem;
		private ToolStripMenuItem editToolStripMenuItem;
		private ToolStripMenuItem viewToolStripMenuItem;
		private ToolStripMenuItem repositoryToolStripMenuItem;
		private ToolStripMenuItem branchToolStripMenuItem;
		private ToolStripMenuItem helpToolStripMenuItem;
		private SplitContainer SplitContainer_Main;
		private ComboBox ComboBox_Repository;
		private TabControl TabControl_Left;
		private TabPage TabPage_Commit;
		private TabPage TabPage_History;
		private Panel Panel_ViewTop;
		private ComboBox ComboBox_Stream;
		private Panel Panel_CommitEdit;
		private TextBox TextBox_Commit;
		private Button Button_Submit;
		private TextBox TextBox_CommitTitle;
		private Button button1;
		private Panel Panel_View;
		private Panel Panel_ViewNoChanges;
		private Label Label_NoChanges;
		private Panel Panel_ViewChanges;
		private SplitContainer SplitContainer_CommitChanges;
		private Panel Panel_CommitInfo;
	}
}
