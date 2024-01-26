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
			ToolStripMenuItem_File = new ToolStripMenuItem();
			newRepositoryToolStripMenuItem = new ToolStripMenuItem();
			toolStripSeparator1 = new ToolStripSeparator();
			addLocalRToolStripMenuItem = new ToolStripMenuItem();
			toolStripSeparator2 = new ToolStripSeparator();
			exitToolStripMenuItem = new ToolStripMenuItem();
			ToolStripMenuItem_Edit = new ToolStripMenuItem();
			optionToolStripMenuItem = new ToolStripMenuItem();
			ToolStripMenuItem_Repository = new ToolStripMenuItem();
			repulicateToolStripMenuItem = new ToolStripMenuItem();
			renameToolStripMenuItem1 = new ToolStripMenuItem();
			settingsToolStripMenuItem = new ToolStripMenuItem();
			toolStripSeparator3 = new ToolStripSeparator();
			removeToolStripMenuItem = new ToolStripMenuItem();
			toolStripSeparator5 = new ToolStripSeparator();
			detailsToolStripMenuItem1 = new ToolStripMenuItem();
			repositoryListToolStripMenuItem = new ToolStripMenuItem();
			streamsToolStripMenuItem = new ToolStripMenuItem();
			newStreamToolStripMenuItem = new ToolStripMenuItem();
			renameToolStripMenuItem = new ToolStripMenuItem();
			deleteToolStripMenuItem = new ToolStripMenuItem();
			toolStripSeparator4 = new ToolStripSeparator();
			compareToStreamToolStripMenuItem = new ToolStripMenuItem();
			toolStripSeparator6 = new ToolStripSeparator();
			detailsToolStripMenuItem = new ToolStripMenuItem();
			streamListToolStripMenuItem = new ToolStripMenuItem();
			helpToolStripMenuItem = new ToolStripMenuItem();
			aboutToolStripMenuItem = new ToolStripMenuItem();
			SplitContainer_Main = new SplitContainer();
			TabControl_Left = new TabControl();
			TabPage_Commit = new TabPage();
			Panel_CommitEdit = new Panel();
			TextBox_Commit = new TextBox();
			Button_Submit = new Button();
			TextBox_CommitTitle = new TextBox();
			TabPage_History = new TabPage();
			ListBox_History = new ListBox();
			ComboBox_Repository = new ComboBox();
			Panel_View = new Panel();
			Panel_ViewChanges = new Panel();
			SplitContainer_CommitChanges = new SplitContainer();
			ListBox_Changes = new ListBox();
			Panel_CommitInfo = new Panel();
			TextBox_HistoryInfo = new TextBox();
			Label_HistoryInfoTitle = new Label();
			Panel_ViewNoChanges = new Panel();
			Label_NoChanges = new Label();
			Panel_ViewTop = new Panel();
			Button_Replicate = new Button();
			Button_Stream = new Button();
			FolderBrowserDialog_Add = new FolderBrowserDialog();
			MenuStrip_Main.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)SplitContainer_Main).BeginInit();
			SplitContainer_Main.Panel1.SuspendLayout();
			SplitContainer_Main.Panel2.SuspendLayout();
			SplitContainer_Main.SuspendLayout();
			TabControl_Left.SuspendLayout();
			TabPage_Commit.SuspendLayout();
			Panel_CommitEdit.SuspendLayout();
			TabPage_History.SuspendLayout();
			Panel_View.SuspendLayout();
			Panel_ViewChanges.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)SplitContainer_CommitChanges).BeginInit();
			SplitContainer_CommitChanges.Panel1.SuspendLayout();
			SplitContainer_CommitChanges.SuspendLayout();
			Panel_CommitInfo.SuspendLayout();
			Panel_ViewNoChanges.SuspendLayout();
			Panel_ViewTop.SuspendLayout();
			SuspendLayout();
			// 
			// MenuStrip_Main
			// 
			MenuStrip_Main.Items.AddRange(new ToolStripItem[] { ToolStripMenuItem_File, ToolStripMenuItem_Edit, ToolStripMenuItem_Repository, streamsToolStripMenuItem, helpToolStripMenuItem });
			MenuStrip_Main.Location = new Point(0, 0);
			MenuStrip_Main.Name = "MenuStrip_Main";
			MenuStrip_Main.Size = new Size(794, 25);
			MenuStrip_Main.TabIndex = 0;
			MenuStrip_Main.Text = "menuStrip1";
			// 
			// ToolStripMenuItem_File
			// 
			ToolStripMenuItem_File.DropDownItems.AddRange(new ToolStripItem[] { newRepositoryToolStripMenuItem, toolStripSeparator1, addLocalRToolStripMenuItem, toolStripSeparator2, exitToolStripMenuItem });
			ToolStripMenuItem_File.Name = "ToolStripMenuItem_File";
			ToolStripMenuItem_File.Size = new Size(39, 21);
			ToolStripMenuItem_File.Text = "File";
			// 
			// newRepositoryToolStripMenuItem
			// 
			newRepositoryToolStripMenuItem.Name = "newRepositoryToolStripMenuItem";
			newRepositoryToolStripMenuItem.Size = new Size(195, 22);
			newRepositoryToolStripMenuItem.Text = "New repository";
			// 
			// toolStripSeparator1
			// 
			toolStripSeparator1.Name = "toolStripSeparator1";
			toolStripSeparator1.Size = new Size(192, 6);
			// 
			// addLocalRToolStripMenuItem
			// 
			addLocalRToolStripMenuItem.Name = "addLocalRToolStripMenuItem";
			addLocalRToolStripMenuItem.Size = new Size(195, 22);
			addLocalRToolStripMenuItem.Text = "Add local repository";
			// 
			// toolStripSeparator2
			// 
			toolStripSeparator2.Name = "toolStripSeparator2";
			toolStripSeparator2.Size = new Size(192, 6);
			// 
			// exitToolStripMenuItem
			// 
			exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			exitToolStripMenuItem.Size = new Size(195, 22);
			exitToolStripMenuItem.Text = "Exit";
			// 
			// ToolStripMenuItem_Edit
			// 
			ToolStripMenuItem_Edit.DropDownItems.AddRange(new ToolStripItem[] { optionToolStripMenuItem });
			ToolStripMenuItem_Edit.Name = "ToolStripMenuItem_Edit";
			ToolStripMenuItem_Edit.Size = new Size(42, 21);
			ToolStripMenuItem_Edit.Text = "Edit";
			// 
			// optionToolStripMenuItem
			// 
			optionToolStripMenuItem.Name = "optionToolStripMenuItem";
			optionToolStripMenuItem.Size = new Size(122, 22);
			optionToolStripMenuItem.Text = "Options";
			// 
			// ToolStripMenuItem_Repository
			// 
			ToolStripMenuItem_Repository.DropDownItems.AddRange(new ToolStripItem[] { repulicateToolStripMenuItem, renameToolStripMenuItem1, settingsToolStripMenuItem, toolStripSeparator3, removeToolStripMenuItem, toolStripSeparator5, detailsToolStripMenuItem1, repositoryListToolStripMenuItem });
			ToolStripMenuItem_Repository.Name = "ToolStripMenuItem_Repository";
			ToolStripMenuItem_Repository.Size = new Size(83, 21);
			ToolStripMenuItem_Repository.Text = "Repository";
			// 
			// repulicateToolStripMenuItem
			// 
			repulicateToolStripMenuItem.Name = "repulicateToolStripMenuItem";
			repulicateToolStripMenuItem.Size = new Size(162, 22);
			repulicateToolStripMenuItem.Text = "Repulicate";
			// 
			// renameToolStripMenuItem1
			// 
			renameToolStripMenuItem1.Name = "renameToolStripMenuItem1";
			renameToolStripMenuItem1.Size = new Size(162, 22);
			renameToolStripMenuItem1.Text = "Rename";
			// 
			// settingsToolStripMenuItem
			// 
			settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			settingsToolStripMenuItem.Size = new Size(162, 22);
			settingsToolStripMenuItem.Text = "Settings";
			// 
			// toolStripSeparator3
			// 
			toolStripSeparator3.Name = "toolStripSeparator3";
			toolStripSeparator3.Size = new Size(159, 6);
			// 
			// removeToolStripMenuItem
			// 
			removeToolStripMenuItem.Name = "removeToolStripMenuItem";
			removeToolStripMenuItem.Size = new Size(162, 22);
			removeToolStripMenuItem.Text = "Remove";
			// 
			// toolStripSeparator5
			// 
			toolStripSeparator5.Name = "toolStripSeparator5";
			toolStripSeparator5.Size = new Size(159, 6);
			// 
			// detailsToolStripMenuItem1
			// 
			detailsToolStripMenuItem1.Name = "detailsToolStripMenuItem1";
			detailsToolStripMenuItem1.Size = new Size(162, 22);
			detailsToolStripMenuItem1.Text = "Details";
			// 
			// repositoryListToolStripMenuItem
			// 
			repositoryListToolStripMenuItem.Name = "repositoryListToolStripMenuItem";
			repositoryListToolStripMenuItem.Size = new Size(162, 22);
			repositoryListToolStripMenuItem.Text = "Repository List";
			// 
			// streamsToolStripMenuItem
			// 
			streamsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newStreamToolStripMenuItem, renameToolStripMenuItem, deleteToolStripMenuItem, toolStripSeparator4, compareToStreamToolStripMenuItem, toolStripSeparator6, detailsToolStripMenuItem, streamListToolStripMenuItem });
			streamsToolStripMenuItem.Name = "streamsToolStripMenuItem";
			streamsToolStripMenuItem.Size = new Size(61, 21);
			streamsToolStripMenuItem.Text = "Stream";
			// 
			// newStreamToolStripMenuItem
			// 
			newStreamToolStripMenuItem.Name = "newStreamToolStripMenuItem";
			newStreamToolStripMenuItem.Size = new Size(190, 22);
			newStreamToolStripMenuItem.Text = "New stream";
			// 
			// renameToolStripMenuItem
			// 
			renameToolStripMenuItem.Name = "renameToolStripMenuItem";
			renameToolStripMenuItem.Size = new Size(190, 22);
			renameToolStripMenuItem.Text = "Rename";
			// 
			// deleteToolStripMenuItem
			// 
			deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			deleteToolStripMenuItem.Size = new Size(190, 22);
			deleteToolStripMenuItem.Text = "Delete";
			// 
			// toolStripSeparator4
			// 
			toolStripSeparator4.Name = "toolStripSeparator4";
			toolStripSeparator4.Size = new Size(187, 6);
			// 
			// compareToStreamToolStripMenuItem
			// 
			compareToStreamToolStripMenuItem.Name = "compareToStreamToolStripMenuItem";
			compareToStreamToolStripMenuItem.Size = new Size(190, 22);
			compareToStreamToolStripMenuItem.Text = "Compare to stream";
			// 
			// toolStripSeparator6
			// 
			toolStripSeparator6.Name = "toolStripSeparator6";
			toolStripSeparator6.Size = new Size(187, 6);
			// 
			// detailsToolStripMenuItem
			// 
			detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
			detailsToolStripMenuItem.Size = new Size(190, 22);
			detailsToolStripMenuItem.Text = "Details";
			// 
			// streamListToolStripMenuItem
			// 
			streamListToolStripMenuItem.Name = "streamListToolStripMenuItem";
			streamListToolStripMenuItem.Size = new Size(190, 22);
			streamListToolStripMenuItem.Text = "Stream List";
			// 
			// helpToolStripMenuItem
			// 
			helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
			helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			helpToolStripMenuItem.Size = new Size(47, 21);
			helpToolStripMenuItem.Text = "Help";
			// 
			// aboutToolStripMenuItem
			// 
			aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			aboutToolStripMenuItem.Size = new Size(111, 22);
			aboutToolStripMenuItem.Text = "About";
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
			Button_Submit.Click += Button_Submit_Click;
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
			TabPage_History.Controls.Add(ListBox_History);
			TabPage_History.Location = new Point(4, 26);
			TabPage_History.Name = "TabPage_History";
			TabPage_History.Padding = new Padding(3);
			TabPage_History.Size = new Size(190, 430);
			TabPage_History.TabIndex = 1;
			TabPage_History.Text = "History";
			TabPage_History.UseVisualStyleBackColor = true;
			// 
			// ListBox_History
			// 
			ListBox_History.Dock = DockStyle.Fill;
			ListBox_History.FormattingEnabled = true;
			ListBox_History.ItemHeight = 17;
			ListBox_History.Items.AddRange(new object[] { "Not Supported Yet" });
			ListBox_History.Location = new Point(3, 3);
			ListBox_History.Name = "ListBox_History";
			ListBox_History.Size = new Size(184, 424);
			ListBox_History.TabIndex = 0;
			// 
			// ComboBox_Repository
			// 
			ComboBox_Repository.Dock = DockStyle.Top;
			ComboBox_Repository.DropDownStyle = ComboBoxStyle.DropDownList;
			ComboBox_Repository.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 134);
			ComboBox_Repository.FormattingEnabled = true;
			ComboBox_Repository.Location = new Point(0, 0);
			ComboBox_Repository.Name = "ComboBox_Repository";
			ComboBox_Repository.Size = new Size(198, 34);
			ComboBox_Repository.TabIndex = 0;
			ComboBox_Repository.SelectedIndexChanged += ComboBox_Repository_SelectedIndexChanged;
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
			SplitContainer_CommitChanges.Location = new Point(0, 86);
			SplitContainer_CommitChanges.Name = "SplitContainer_CommitChanges";
			// 
			// SplitContainer_CommitChanges.Panel1
			// 
			SplitContainer_CommitChanges.Panel1.BackColor = SystemColors.Control;
			SplitContainer_CommitChanges.Panel1.Controls.Add(ListBox_Changes);
			SplitContainer_CommitChanges.Size = new Size(586, 372);
			SplitContainer_CommitChanges.SplitterDistance = 195;
			SplitContainer_CommitChanges.TabIndex = 1;
			// 
			// ListBox_Changes
			// 
			ListBox_Changes.BackColor = SystemColors.Control;
			ListBox_Changes.Dock = DockStyle.Fill;
			ListBox_Changes.FormattingEnabled = true;
			ListBox_Changes.ItemHeight = 17;
			ListBox_Changes.Location = new Point(0, 0);
			ListBox_Changes.Name = "ListBox_Changes";
			ListBox_Changes.Size = new Size(193, 370);
			ListBox_Changes.TabIndex = 0;
			// 
			// Panel_CommitInfo
			// 
			Panel_CommitInfo.BackColor = SystemColors.Control;
			Panel_CommitInfo.Controls.Add(TextBox_HistoryInfo);
			Panel_CommitInfo.Controls.Add(Label_HistoryInfoTitle);
			Panel_CommitInfo.Dock = DockStyle.Top;
			Panel_CommitInfo.Location = new Point(0, 0);
			Panel_CommitInfo.Name = "Panel_CommitInfo";
			Panel_CommitInfo.Size = new Size(586, 86);
			Panel_CommitInfo.TabIndex = 0;
			// 
			// TextBox_HistoryInfo
			// 
			TextBox_HistoryInfo.AcceptsReturn = true;
			TextBox_HistoryInfo.BackColor = SystemColors.Control;
			TextBox_HistoryInfo.Dock = DockStyle.Fill;
			TextBox_HistoryInfo.Location = new Point(0, 19);
			TextBox_HistoryInfo.Multiline = true;
			TextBox_HistoryInfo.Name = "TextBox_HistoryInfo";
			TextBox_HistoryInfo.ReadOnly = true;
			TextBox_HistoryInfo.ScrollBars = ScrollBars.Vertical;
			TextBox_HistoryInfo.Size = new Size(586, 67);
			TextBox_HistoryInfo.TabIndex = 1;
			// 
			// Label_HistoryInfoTitle
			// 
			Label_HistoryInfoTitle.AutoSize = true;
			Label_HistoryInfoTitle.BackColor = SystemColors.Control;
			Label_HistoryInfoTitle.Dock = DockStyle.Top;
			Label_HistoryInfoTitle.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 134);
			Label_HistoryInfoTitle.Location = new Point(0, 0);
			Label_HistoryInfoTitle.Name = "Label_HistoryInfoTitle";
			Label_HistoryInfoTitle.Size = new Size(51, 19);
			Label_HistoryInfoTitle.TabIndex = 0;
			Label_HistoryInfoTitle.Text = "label1";
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
			Panel_ViewTop.Controls.Add(Button_Replicate);
			Panel_ViewTop.Controls.Add(Button_Stream);
			Panel_ViewTop.Dock = DockStyle.Top;
			Panel_ViewTop.Location = new Point(0, 0);
			Panel_ViewTop.Name = "Panel_ViewTop";
			Panel_ViewTop.Size = new Size(588, 34);
			Panel_ViewTop.TabIndex = 0;
			// 
			// Button_Replicate
			// 
			Button_Replicate.Dock = DockStyle.Left;
			Button_Replicate.Location = new Point(150, 0);
			Button_Replicate.Name = "Button_Replicate";
			Button_Replicate.Size = new Size(150, 34);
			Button_Replicate.TabIndex = 3;
			Button_Replicate.Text = "Replicate";
			Button_Replicate.UseVisualStyleBackColor = true;
			Button_Replicate.Click += Button_Replicate_Click;
			// 
			// Button_Stream
			// 
			Button_Stream.Dock = DockStyle.Left;
			Button_Stream.Location = new Point(0, 0);
			Button_Stream.Name = "Button_Stream";
			Button_Stream.Size = new Size(150, 34);
			Button_Stream.TabIndex = 2;
			Button_Stream.Text = "Stream";
			Button_Stream.UseVisualStyleBackColor = true;
			Button_Stream.Click += Button_Stream_Click;
			// 
			// FolderBrowserDialog_Add
			// 
			FolderBrowserDialog_Add.Description = "Add local repository";
			FolderBrowserDialog_Add.ShowNewFolderButton = false;
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
			TabPage_History.ResumeLayout(false);
			Panel_View.ResumeLayout(false);
			Panel_ViewChanges.ResumeLayout(false);
			SplitContainer_CommitChanges.Panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)SplitContainer_CommitChanges).EndInit();
			SplitContainer_CommitChanges.ResumeLayout(false);
			Panel_CommitInfo.ResumeLayout(false);
			Panel_CommitInfo.PerformLayout();
			Panel_ViewNoChanges.ResumeLayout(false);
			Panel_ViewNoChanges.PerformLayout();
			Panel_ViewTop.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip MenuStrip_Main;
		private ToolStripMenuItem ToolStripMenuItem_File;
		private ToolStripMenuItem ToolStripMenuItem_Edit;
		private ToolStripMenuItem ToolStripMenuItem_Repository;
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
		private Panel Panel_View;
		private Panel Panel_ViewNoChanges;
		private Label Label_NoChanges;
		private Panel Panel_ViewChanges;
		private SplitContainer SplitContainer_CommitChanges;
		private Panel Panel_CommitInfo;
		private Button Button_Stream;
		private ToolStripMenuItem streamsToolStripMenuItem;
		private Button Button_Replicate;
		private ToolStripMenuItem newRepositoryToolStripMenuItem;
		private ToolStripSeparator toolStripSeparator1;
		private ToolStripMenuItem addLocalRToolStripMenuItem;
		private ToolStripSeparator toolStripSeparator2;
		private ToolStripMenuItem exitToolStripMenuItem;
		private ToolStripMenuItem optionToolStripMenuItem;
		private ToolStripMenuItem repulicateToolStripMenuItem;
		private ToolStripMenuItem settingsToolStripMenuItem;
		private ToolStripMenuItem removeToolStripMenuItem;
		private ToolStripMenuItem renameToolStripMenuItem1;
		private ToolStripMenuItem newStreamToolStripMenuItem;
		private ToolStripMenuItem renameToolStripMenuItem;
		private ToolStripSeparator toolStripSeparator3;
		private ToolStripSeparator toolStripSeparator5;
		private ToolStripMenuItem detailsToolStripMenuItem1;
		private ToolStripMenuItem repositoryListToolStripMenuItem;
		private ToolStripMenuItem deleteToolStripMenuItem;
		private ToolStripSeparator toolStripSeparator4;
		private ToolStripMenuItem compareToStreamToolStripMenuItem;
		private ToolStripSeparator toolStripSeparator6;
		private ToolStripMenuItem detailsToolStripMenuItem;
		private ToolStripMenuItem streamListToolStripMenuItem;
		private ToolStripMenuItem aboutToolStripMenuItem;
		private FolderBrowserDialog FolderBrowserDialog_Add;
		private ListBox ListBox_History;
		private ListBox ListBox_Changes;
		private Label label2;
		private Label Label_HistoryInfoTitle;
		private TextBox TextBox_HistoryInfo;
	}
}
